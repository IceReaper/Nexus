namespace LibNexus.Files.TableFiles;

[AttributeUsage(AttributeTargets.Property)]
public sealed class ColumnAttribute : Attribute
{
	public string Name { get; }

	public ColumnAttribute(string name)
	{
		Name = name;
	}
}
