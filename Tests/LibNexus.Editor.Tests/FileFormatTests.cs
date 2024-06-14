using LibNexus.Core;
using LibNexus.Editor.Tables;
using LibNexus.Files;
using LibNexus.Files.ModelFiles;
using LibNexus.Files.TableFiles;
using LibNexus.Files.TextureFiles;
using LibNexus.Files.TranslationsFiles;
using NUnit.Framework;

namespace LibNexus.Editor.Tests;

public class FileFormatTests
{
	// TODO create a local AppSettings.json, so i can make an AppSettings.Development.json (on .gitignore) to override it with my local path.
	private const string ClientPath = "../../../../../A_TestProject/dist/";

	[Test]
	public async Task TestTranslations()
	{
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientDataEN"), true, null, CancellationToken.None);

		Assert.That(() => new Translation(new MemoryStream(fileSystem.Read("en-US.bin") ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTextureJpg0()
	{
		const string file = "Art/Character/Aurin/Female/newUVLayout/aurin_f_color.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTextureJpg1()
	{
		const string file = "Art/Character/Aurin/Female/newUVLayout/aurin_f_normal.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTextureJpg2()
	{
		const string file = "Art/Character/Aurin/Female/Textures/chr_Aurin_F_ear_04_color.Skin_Body.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTexture0()
	{
		const string file = "Art/Cinematics/Characters/Belle_Walker/Textures/Death_Flux_Thick_GRN_Ramp.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTexture1()
	{
		const string file = "Art/Dev/ColorVariationRamp.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTexture5()
	{
		const string file = "Art/Structure/Model/Building_Kits/Defiance/Bridge/STR_Bridge_DefianceRollerExtension_000.Data/Sector_Exterior_layer.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTexture6()
	{
		const string file = "Art/Character/Aurin/Female/Textures/chr_aurin_f_ear_01_dye.Skin_Ear_Horn.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTexture13()
	{
		const string file = "Art/Character/Draken/Female/CHR_Draken_F_Color.Skin_Body.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTexture15()
	{
		const string file = "Art/Character/Chua/Male/Textures/CHR_Chua_M_Eyemouth_01_Color.Skin_Hair.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTexture18()
	{
		const string file = "Art/Dev/MaterialConstant.tex";
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Texture(new MemoryStream(fileSystem.Read(file) ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestTable()
	{
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new TableWithRows<Item2Row>(new MemoryStream(fileSystem.Read("DB/Item2.tbl") ?? throw new Exception())), Throws.Nothing);
	}

	[Test]
	public async Task TestModel()
	{
		using var fileSystem = await FileSystem.Create(new Progress(), Path.Combine(ClientPath, "Patch/ClientData"), true, null, CancellationToken.None);

		Assert.That(() => new Model(new MemoryStream(fileSystem.Read("Art/Dev/Temp/Glue_Screen_001.m3") ?? throw new Exception())), Throws.Nothing);
	}
}
