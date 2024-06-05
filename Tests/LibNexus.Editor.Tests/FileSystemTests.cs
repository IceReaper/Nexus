using LibNexus.Core;
using LibNexus.Files;
using NUnit.Framework;

namespace LibNexus.Editor.Tests;

public class FileSystemTests
{
	private static readonly string[] ExpectedFiles = ["Test1.txt"];
	private static readonly string[] ExpectedDirectories = ["Test1", "Test3"];

	[Test]
	public void TestCreatePacked()
	{
		Assert.Multiple(
			static () =>
			{
				FileSystem? fileSystem = null;
				Assert.That(async () => fileSystem = await FileSystem.Create(new Progress(), "packed", true, null, CancellationToken.None), Throws.Nothing);

				if (fileSystem == null)
					return;

				Assert.That(File.Exists("packed.index"), Is.True);
				Assert.That(File.Exists("packed.archive"), Is.True);

				TestFileSystem(fileSystem);

				fileSystem.Dispose();

				File.Delete("packed.index");
				File.Delete("packed.archive");
			}
		);
	}

	[Test]
	public void TestCreateUnpacked()
	{
		Assert.Multiple(
			static () =>
			{
				FileSystem? fileSystem = null;

				Assert.That(
					async () => fileSystem = await FileSystem.Create(new Progress(), "unpacked", false, "unpacked", CancellationToken.None),
					Throws.Nothing
				);

				if (fileSystem == null)
					return;

				Assert.That(File.Exists("unpacked.index"), Is.True);
				Assert.That(Directory.Exists("unpacked"), Is.True);

				TestFileSystem(fileSystem);

				fileSystem.Dispose();

				File.Delete("unpacked.index");
				Directory.Delete("unpacked", true);
			}
		);
	}

	private static void TestFileSystem(FileSystem fileSystem)
	{
		Assert.That(() => fileSystem.Write("Test1.txt", "Hello world 1!"u8.ToArray(), DateTime.UtcNow), Throws.Nothing);
		Assert.That(() => fileSystem.Write("Test2.txt", "Hello world 2!"u8.ToArray(), DateTime.UtcNow), Throws.Nothing);

		Assert.That(() => fileSystem.Validate("Test1.txt"), Is.True);
		Assert.That(() => fileSystem.Validate("Test3.txt"), Is.False);

		Assert.That(() => fileSystem.CreateDirectory("Test1"), Throws.Nothing);
		Assert.That(() => fileSystem.CreateDirectory("Test2"), Throws.Nothing);

		Assert.That(() => fileSystem.Rename("Test2", "Test3"), Throws.Nothing);
		Assert.That(() => fileSystem.Rename("Test2.txt", "Test3/Test3.txt"), Throws.Nothing);

		Assert.That(() => fileSystem.ListFiles(string.Empty), Is.EqualTo(ExpectedFiles));
		Assert.That(() => fileSystem.ListDirectories(string.Empty), Is.EqualTo(ExpectedDirectories));

		Assert.That(() => fileSystem.Read("Test1.txt"), Is.EqualTo("Hello world 1!"u8.ToArray()));

		Assert.That(() => fileSystem.Delete("Test2"), Throws.Nothing);
		Assert.That(() => fileSystem.Delete("TestDirectory/Test2.txt"), Throws.Nothing);
	}
}
