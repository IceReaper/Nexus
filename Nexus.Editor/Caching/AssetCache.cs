namespace Nexus.Editor.Caching;

public class AssetCache : IDisposable
{
	private sealed record AddTask(Subscriber Subscriber, string Key, Func<object?> Load, Action<object> Loaded);

	private sealed record RemoveTask(Subscriber Subscriber, string? Key);

	private readonly CancellationTokenSource _cancellationTokenSource = new();

	private readonly Dictionary<string, object> _cache = [];
	private readonly Dictionary<Subscriber, List<string>> _subscriberObjects = [];
	private readonly Dictionary<string, List<Subscriber>> _objectSubscribers = [];
	private readonly List<AddTask> _addQueue = [];
	private readonly List<RemoveTask> _removeQueue = [];
	private bool _releaseLock;

	public AssetCache()
	{
		Task.Run(async () => await Loop(_cancellationTokenSource.Token));
	}

	private async Task Loop(CancellationToken token)
	{
		while (!token.IsCancellationRequested)
		{
			while (!_releaseLock)
			{
				try
				{
					if (LoopRemove())
						continue;

					if (LoopAdd())
						continue;
				}
				catch (Exception exception)
				{
					Console.WriteLine(exception);
				}

				break;
			}

			await Task.Delay(TimeSpan.FromMilliseconds(100), token);
		}
	}

	private bool LoopRemove()
	{
		lock (_removeQueue)
		{
			lock (_addQueue)
			{
				if (_removeQueue.Count == 0)
					return false;

				var task = _removeQueue[0];
				_removeQueue.RemoveAt(0);

				if (task.Key == null)
				{
					if (!_subscriberObjects.TryGetValue(task.Subscriber, out var subscriberObjects))
						return true;

					foreach (var key in subscriberObjects.ToArray())
						RemoveSubscription(key, task.Subscriber);

					_addQueue.RemoveAll(other => other.Subscriber == task.Subscriber);
				}
				else
				{
					RemoveSubscription(task.Key, task.Subscriber);

					_addQueue.RemoveAll(other => other.Subscriber == task.Subscriber && other.Key == task.Key);
				}
			}
		}

		return true;
	}

	private void RemoveSubscription(string key, Subscriber subscriber)
	{
		if (!_objectSubscribers.TryGetValue(key, out var objectSubscribers))
			return;

		objectSubscribers.Remove(subscriber);

		if (objectSubscribers.Count == 0)
			Remove(key);

		if (!_subscriberObjects.TryGetValue(subscriber, out var subscriberObjects))
			return;

		subscriberObjects.Remove(key);

		if (subscriberObjects.Count == 0)
			_subscriberObjects.Remove(subscriber);
	}

	private bool LoopAdd()
	{
		lock (_addQueue)
		{
			if (_addQueue.Count == 0)
				return false;

			var task = _addQueue[0];
			_addQueue.RemoveAt(0);

			if (!_cache.TryGetValue(task.Key, out var result))
			{
				result = task.Load();

				if (result == null)
					return true;

				_cache.Add(task.Key, result);
				_objectSubscribers.Add(task.Key, []);
			}

			var objectSubscribers = _objectSubscribers[task.Key];

			if (!objectSubscribers.Contains(task.Subscriber))
				objectSubscribers.Add(task.Subscriber);

			if (!_subscriberObjects.TryGetValue(task.Subscriber, out var subscriberObjects))
				_subscriberObjects.Add(task.Subscriber, subscriberObjects = []);

			if (!subscriberObjects.Contains(task.Key))
				subscriberObjects.Add(task.Key);

			task.Loaded(result);
		}

		return true;
	}

	public void Add<T>(object subscriber, string key, Func<T?> load, Action<T> loaded, bool prioritize = false)
	{
		_releaseLock = true;

		lock (_addQueue)
		{
			var task = new AddTask(new Subscriber(subscriber), key, () => load(), asset => loaded((T)asset));

			if (prioritize)
				_addQueue.Insert(0, task);
			else
				_addQueue.Add(task);
		}

		_releaseLock = false;
	}

	public void Remove(object subscriber, string? key = null)
	{
		_releaseLock = true;

		lock (_removeQueue)
			_removeQueue.Add(new RemoveTask(new Subscriber(subscriber), key));

		_releaseLock = false;
	}

	private void Remove(string key)
	{
		(_cache[key] as IDisposable)?.Dispose();
		_cache.Remove(key);
		_objectSubscribers.Remove(key);
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		foreach (var key in _cache.Keys.ToArray())
			Remove(key);

		_subscriberObjects.Clear();

		_cancellationTokenSource.Cancel();
		_cancellationTokenSource.Dispose();
	}
}
