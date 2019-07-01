using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using NuCLIus.Services;
using NUnit.Framework;
using penCsharpener.DotnetUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Tests {
    public class EntityTests {

        [SetUp]
        public void Setup() {
        }

        [TestCase("MyAmazingNamespace.With.Nuget.1.4.3.nupkg", ExpectedResult = true)]
        [TestCase("MyAmazingNamespace.100.Nuget.1.4.3.nupkg", ExpectedResult = true)]
        [TestCase("MyAmazingNamespace.With.Nuget.1.4.1.3.nupkg", ExpectedResult = true)]
        [TestCase("MyAmazingNamespace.With.Nuget.1.4.nupkg", ExpectedResult = true)]
        [TestCase("MyAmazingNamespace.With.Nuget.1.4.1.3.4143.nupkg", ExpectedResult = false)]
        public bool NupkgDetermineNugetInfoTest(string filename) {
            if (File.Exists(filename) == false) {
                File.WriteAllText(filename, "essentially fake nuget package");
            }
            var fi = new FileInfo(filename);
            var nupkg = new Nupkg() {
                Path = filename,
                PathSha1 = filename.ToSha1(),
                PackageSha256 = fi.ToSha256(),
            }.DetermineNugetInfo();
            return $"{nupkg.PackageName}.{nupkg.Version}.nupkg" == filename;
        }

        [TestCase(@"%userprofile%\Source\Repos\NuCLIus\NuCLIus.Core\NuCLIus.Core.csproj")]
        public void ProjectGitRepoSearchTest(string projectFile) {
            var path = Environment.ExpandEnvironmentVariables(projectFile);
            var proj = new Project() {
                Path = path,
                PathSha1 = path.ToSha1(),
            };
            var gitRepo = proj.FindGitRepo();
            Assert.IsTrue(Directory.Exists(gitRepo));
        }

        [TestCase(@"%userprofile%\Source\Repos\NuCLIus\NuCLIus.Core\NuCLIus.Core.csproj")]
        public void ProjectGetSolutionTest(string projectFile) {
            var path = Environment.ExpandEnvironmentVariables(projectFile);
            var proj = new Project() {
                Path = path,
                PathSha1 = path.ToSha1(),
            };
            var solution = proj.GetSolutionInfo();
            Assert.IsTrue(solution != null);
        }

        [TestCase(@"%userprofile%\Source\Repos\")]
        public async Task GetFilesTest(string rootFolder) {
            var path = Environment.ExpandEnvironmentVariables(rootFolder);
            IStorageService storage = new SqliteStorageService();
            await storage.SetupStorageSolution(
                Environment.ExpandEnvironmentVariables(@"%appdata%\NuCLIus")
                );
            await storage.SaveEntity(new RootFolder() {
                Path = path,
                PathSha1 = path.ToSha1()
            });
            IFileService fs = new FileService(new FileSearch(new PreferenceService(storage)),
                                                             new FileStorage(storage));
            var filesFound = await fs.GetFiles();
            Assert.IsTrue(filesFound?.Count > 0);
        }

        [Test]
        public void GetScanIgnorePathHashes() {
            Assert.Pass(
                "git: " + ".git".ToSha1() + Environment.NewLine +
                "Release: " + "Release".ToSha1() + Environment.NewLine +
                "Debug: " + "Debug".ToSha1() + Environment.NewLine +
                ".vs: " + ".vs".ToSha1() + Environment.NewLine +
                "obj: " + "obj".ToSha1() + Environment.NewLine +
                "node_modules: " + "node_modules".ToSha1() + Environment.NewLine +
                "packages: " + "packages".ToSha1() + Environment.NewLine
                );
        }
    }
}