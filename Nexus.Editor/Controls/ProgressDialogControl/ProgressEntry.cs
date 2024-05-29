using Godot;
using LibNexus.Core;

namespace Nexus.Editor.Controls.ProgressDialogControl;

public partial class ProgressEntry : Control
{
	[Export]
	public required ProgressBar ProgressBar { get; set; }

	[Export]
	public required Label Label { get; set; }

	[Export]
	public required Label ProgressLabel { get; set; }

	[Export]
	public required Control Children { get; set; }

	public PackedScene? Template { get; set; }
	public Progress? Progress { get; set; }

	private readonly Dictionary<Progress, Control> _children = [];

	public override void _Process(double delta)
	{
		if (Progress == null)
			return;

		ProgressBar.Value = Progress.Value;
		Label.Text = Progress.Title;
		ProgressLabel.Text = Progress.GetProgressLabel(Progress);

		if (Template == null)
			return;

		var newChildren = Progress.Children.ToList();
		var oldChildren = _children.Keys.ToList();

		foreach (var oldChild in oldChildren.Where(oldChild => !newChildren.Remove(oldChild)))
		{
			_children[oldChild].QueueFree();
			_children.Remove(oldChild);
		}

		foreach (var newChild in newChildren)
		{
			var childEntry = (ProgressEntry)Template.Instantiate();
			childEntry.Progress = newChild;
			childEntry.Template = Template;

			Children.AddChild(childEntry);
			_children.Add(newChild, childEntry);
		}
	}
}
