using System.Net;

using var httpListener = new HttpListener();
httpListener.Prefixes.Add("http://localhost:8080/");
httpListener.Start();

var runServer = true;

// TODO simple proxy to get a local copy of the repo, simple placeholder :-P
while (runServer)
{
	var context = httpListener.GetContext();

	var request = context.Request;
	var response = context.Response;

	if (request is { Url.AbsolutePath: "/shutdown" })
		runServer = false;
	else if (request.Url != null)
	{
		var file = request.Url.AbsolutePath[1..];
		var directory = Path.GetDirectoryName(file) ?? string.Empty;

		Console.Write($"'{file}':");

		if (!File.Exists(file))
		{
			Console.Write(" FromProxy");

			if (!Directory.Exists(directory))
				Directory.CreateDirectory(directory);

			using var httpClient = new HttpClient();
			using var message = new HttpRequestMessage(HttpMethod.Get, new Uri($"http://cdn.nexus-reborn.com/{file}"));
			using var proxyResponse = httpClient.Send(message);
			using var output = File.Open(file, FileMode.Create, FileAccess.Write);

			proxyResponse.Content.ReadAsStream().CopyTo(output);
		}

		switch (request.HttpMethod)
		{
			case "HEAD":
				Console.Write(" Informing");

				response.ContentLength64 = new FileInfo(file).Length;

				break;

			case "GET":
			{
				Console.Write(" ToClient");

				// TODO this is likely happening in chunks!!!
				var data = File.ReadAllBytes(file);

				response.ContentLength64 = data.LongLength;

				response.OutputStream.Write(data);

				break;
			}

			default:
				throw new NotImplementedException();
		}

		Console.WriteLine();
	}

	response.Close();
}

httpListener.Close();
