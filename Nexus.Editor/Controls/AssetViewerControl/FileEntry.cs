using Godot;
using LibNexus.Files;
using Nexus.Editor.Extensions;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class FileEntry : Control
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

	public FileSystem? FileSystem { get; set; }
	public string Path { get; set; } = string.Empty;

	public override void _Ready()
	{
		var extension = System.IO.Path.GetExtension(Path);

		Icon.Texture = extension switch
		{
			".m3" => IconComplexModel,
			".i3" => IconSimpleModel,
			".tex" => IconTexture,
			".dgn" => IconDungeon,
			".wem" => IconSound,
			".xml" => IconUi,
			".tbl" => IconTable,
			".area" => IconArea,
			".map" => IconMap,
			".sho" => IconShader,
			".sky" => IconSky,
			".lua" => IconScript,
			".bin" => IconTranslations,
			".bnk" or ".bk2" => IconVideo,
			_ => IconDefault
		};

		Label.Text = Icon.Texture == IconDefault ? System.IO.Path.GetFileName(Path) : System.IO.Path.GetFileNameWithoutExtension(Path);

		MainHandle.GuiInput += OnGuiInput;
	}

	// TODO this copy / paste is ugly. Make this whole context menu thing somehow more elegant.
	private void OnGuiInput(InputEvent @event)
	{
		if (@event is not InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Right } eventMouseButton)
			return;

		var popupMenu = new PopupMenu
		{
			Position = new Vector2I((int)eventMouseButton.GlobalPosition.X, (int)eventMouseButton.GlobalPosition.Y), Visible = true
		};

		popupMenu.AddItem("Extract", 1);

		popupMenu.IdPressed += id =>
		{
			if (id == 1)
				FileSystem?.Unpack(Path);
		};

		popupMenu.CloseRequested += () => popupMenu.Free();

		AddChild(popupMenu);

		popupMenu.ResetSize();
		popupMenu.Jail();
	}
}
