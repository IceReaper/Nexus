using LibNexus.Core;
using LibNexus.Editor;
using LibNexus.Files;
using LibNexus.Files.ModelFiles;
using System.Diagnostics;

namespace Playground;

file static class Program
{
	public static async Task Main()
	{
		/*foreach (var file in Directory.GetFiles("A_TestProject/dist/Data/DB"))
		{
			Console.WriteLine(file);

			using var stream = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			var tableBase = new TableBase(stream);

			var className = PruneName($"{tableBase.Name}Row");

			var lines = new List<string> { "namespace LibNexus.Editor.Tables;", string.Empty, $"public class {className}", "{" };

			for (var i = 0; i < tableBase.Columns.Count; i++)
			{
				if (i > 0)
					lines.Add(string.Empty);

				lines.AddRange(CreateProperty(tableBase.Columns[i]).Select(static line => $"\t{line}"));
			}

			lines.Add("}");

			File.WriteAllLines($"Libraries/LibNexus.Editor/Tables/{className}.cs", lines);
		}*/

		var project = await Project.Load("A_TestProject/project.nexus", new Progress(), CancellationToken.None);

		foreach (var (name, fileSystem) in project.FileSystems)
			Test(name, fileSystem, "Art/Dev", ".m3", stream => _ = new Model(stream));
	}

	private static void Test(string name, FileSystem fileSystem, string path, string extension, Action<Stream> test)
	{
		foreach (var directory in fileSystem.ListDirectories(path))
		{
			var directoryPath = string.IsNullOrEmpty(path) ? directory : $"{path}/{directory}";
			Test(name, fileSystem, directoryPath, extension, test);
		}

		foreach (var file in fileSystem.ListFiles(path))
		{
			if (!file.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
				continue;

			var filePath = string.IsNullOrEmpty(path) ? file : $"{path}/{file}";
			var bytes = fileSystem.Read(filePath) ?? throw new UnreachableException();

			using var memoryStream = new MemoryStream(bytes);

			try
			{
				test(memoryStream);
			}
			catch (Exception e)
			{
				Console.WriteLine($"{e.Message}\t\t\t{name}:{filePath}");
			}
		}
	}

	/*private static IEnumerable<string> CreateProperty(TableColumn column)
	{
		var propertyType = column.Type switch
		{
			TableColumnType.Uint => "uint",
			TableColumnType.Float => "float",
			TableColumnType.Bool => "bool",
			TableColumnType.Ulong => "ulong",
			TableColumnType.String => "string",
			_ => throw new ArgumentOutOfRangeException($"Column type {column.Type} not supported.")
		};

		var propertyName = PruneName(column.Name);
		var defaultValue = column.Type == TableColumnType.String ? " = string.Empty;" : string.Empty;

		return [$"[Column(\"{column.Name}\")]", $"public {propertyType} {propertyName} {{ get; set; }}{defaultValue}"];
	}

	private static string PruneName(string originalName)
	{
		var prunedName = originalName;

		prunedName = char.ToUpper(prunedName[0], CultureInfo.InvariantCulture) + prunedName[1..];

		prunedName = Regex.Replace(prunedName, "_([a-z])", static match => match.Groups[1].Value.ToUpperInvariant().ToString());

		prunedName = Regex.Replace(
			prunedName,
			"(?!=[^A-Z])([A-Z])([A-Z]+)([A-Z]|$)",
			static match => match.Groups[1].Value + match.Groups[2].Value.ToLowerInvariant() + match.Groups[3].Value
		);

		return prunedName;
	}*/
}
