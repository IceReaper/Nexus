using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RealmDataCenterRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("deploymentRegionEnum")]
	public uint DeploymentRegionEnum { get; set; }

	[Column("deploymentTypeEnum")]
	public uint DeploymentTypeEnum { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("authServer")]
	public string AuthServer { get; set; } = string.Empty;

	[Column("ncClientAuthServer")]
	public string NcClientAuthServer { get; set; } = string.Empty;

	[Column("ncRedirectUrlTemplate")]
	public string NcRedirectUrlTemplate { get; set; } = string.Empty;

	[Column("ncRedirectUrlTemplateSignature")]
	public string NcRedirectUrlTemplateSignature { get; set; } = string.Empty;

	[Column("ncAppGroupCode")]
	public string NcAppGroupCode { get; set; } = string.Empty;

	[Column("ncProgramAuth")]
	public uint NcProgramAuth { get; set; }

	[Column("steamSignatureUrlTemplate")]
	public string SteamSignatureUrlTemplate { get; set; } = string.Empty;

	[Column("steamNCoinUrlTemplate")]
	public string SteamNCoinUrlTemplate { get; set; } = string.Empty;

	[Column("storeBannerDataUrlTemplate")]
	public string StoreBannerDataUrlTemplate { get; set; } = string.Empty;
}
