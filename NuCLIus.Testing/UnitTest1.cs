using NuCLIus.Core.Entities;
using NUnit.Framework;
using penCsharpener.DotnetUtils;
using System.Collections.Generic;
using System.IO;

namespace Tests {
    public class Tests {

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
    }
}