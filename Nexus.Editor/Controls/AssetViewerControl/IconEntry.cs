using Godot;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class IconEntry : Control
{
	[Export]
	public required TextureRect Icon { get; set; }

	[Export]
	public required Label Label { get; set; }

	[Export]
	public required Control MainHandle { get; set; }

	[Export]
	public required Texture2D IconDefault { get; set; }

	[Export]
	public required Texture2D IconDirectory { get; set; }

	[Export]
	public required Texture2D IconParentDirectory { get; set; }

	[Export]
	public required Texture2D IconComplexModel { get; set; }

	[Export]
	public required Texture2D IconSimpleModel { get; set; }

	[Export]
	public required Texture2D IconTexture { get; set; }

	[Export]
	public required Texture2D IconDungeon { get; set; }

	[Export]
	public required Texture2D IconSound { get; set; }

	[Export]
	public required Texture2D IconUi { get; set; }

	[Export]
	public required Texture2D IconTable { get; set; }

	[Export]
	public required Texture2D IconArea { get; set; }

	[Export]
	public required Texture2D IconMap { get; set; }

	[Export]
	public required Texture2D IconShader { get; set; }

	[Export]
	public required Texture2D IconSky { get; set; }

	[Export]
	public required Texture2D IconScript { get; set; }

	[Export]
	public required Texture2D IconTranslations { get; set; }

	[Export]
	public required Texture2D IconVideo { get; set; }

	public AssetViewer? AssetViewer { get; set; }

	public FileSystemPath? FileSystemPath { get; set; }
	public FileType FileType { get; set; }

	public override void _Ready()
	{
		Icon.Texture = FileType switch
		{
			FileType.ComplexModel => IconComplexModel,
			FileType.SimpleModel => IconSimpleModel,
			FileType.Texture => IconTexture,
			FileType.Dungeon => IconDungeon,
			FileType.Sound => IconSound,
			FileType.Ui => IconUi,
			FileType.Table => IconTable,
			FileType.Area => IconArea,
			FileType.Map => IconMap,
			FileType.Shader => IconShader,
			FileType.Sky => IconSky,
			FileType.Script => IconScript,
			FileType.Translations => IconTranslations,
			FileType.Video => IconVideo,
			FileType.Directory => IconDirectory,
			FileType.ParentDirectory => IconParentDirectory,
			_ => IconDefault
		};

		if (FileType != FileType.ParentDirectory && FileType != FileType.Directory && FileType != FileType.Unknown)
			Label.Text = Path.GetFileNameWithoutExtension(Label.Text);

		MainHandle.GuiInput += OnGuiInput;
	}

	private void OnGuiInput(InputEvent @event)
	{
		if (@event is not InputEventMouseButton { Pressed: true } eventMouseButton)
			return;

		switch (eventMouseButton)
		{
			case { ButtonIndex: MouseButton.Left, DoubleClick: true }:
				if (AssetViewer != null && FileType is FileType.Directory or FileType.ParentDirectory)
					AssetViewer.CurrentPath = FileSystemPath;

				break;

			case { ButtonIndex: MouseButton.Right }:
				AddChild(
					new ContextMenu
					{
						Position = new Vector2I((int)eventMouseButton.GlobalPosition.X, (int)eventMouseButton.GlobalPosition.Y),
						FileSystemPath = FileSystemPath,
						FileType = FileType
					}
				);

				break;
		}
	}
}
