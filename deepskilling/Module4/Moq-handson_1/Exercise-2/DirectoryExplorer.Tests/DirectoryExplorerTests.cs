using MagicFilesLib;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTest
    {
        Mock<IDirectoryExplorer> mockDirectory;

        private readonly string file1 = "file.txt";
        private readonly string file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            mockDirectory = new Mock<IDirectoryExplorer>();
        }

        [TestCase]
        [Test]
public void TestFiles()
{
    mockDirectory.Setup(x => x.GetFiles(It.IsAny<string>()))
        .Returns(new List<string>
        {
            file1,
            file2
        });

    var files = mockDirectory.Object.GetFiles("C:\\");

    Assert.That(files, Is.Not.Null);
    Assert.That(files.Count, Is.EqualTo(2));
    Assert.That(files, Does.Contain(file1));
}
    }
}