using Godot;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class FileEntry : Control
{
	[Export]
	public required TextureRect Icon { get; set; }

	[Export]
	public required Label Label { get; set; }

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

	public string File { get; set; } = string.Empty;

	public override void _Ready()
	{
		var extension = Path.GetExtension(File);

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

		Label.Text = Icon.Texture == IconDefault ? File : Path.GetFileNameWithoutExtension(File);
	}
}
