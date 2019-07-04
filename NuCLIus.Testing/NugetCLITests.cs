using NuCLIus.NugetCLI;
using NuCLIus.NugetCLI.Interfaces;
using NUnit.Framework;
using System;
using System.IO;

namespace Tests {
    public class NugetCLITests {

        [SetUp]
        public void Setup() {
            Nuget.Validate = false;
        }

        [TestCase(ExpectedResult = @"nuget pack ..\..\..\..\NuCLIus.Services\NuCLIus.Services.csproj " +
                                @"-OutputDirectory E:\NuCLIusTests -Build -Properties Configuration=Release")]
        public string NugetPackTest() {
            return Nuget.Init()
                        .Pack(@"..\..\..\..\NuCLIus.Services\NuCLIus.Services.csproj")
                        .OutputDirectory("E:\\NuCLIusTests", createIfNotExists: true)
                        .Build()
                        .Properties()
                        .Configuration()
                        .ToString();
        }

        [TestCase(ExpectedResult = @"nuget add ..\..\..\..\NuCLIus.Services\NuCLIus.Services.1.0.0.nupkg " +
                                @"-Verbosity Normal -Source \\localnugetserver ")]
        public string NugetAddTest() {
            return Nuget.Init()
                        .Add(@"..\..\..\..\NuCLIus.Services\NuCLIus.Services.1.0.0.nupkg")
                        .VerbosityAdd(NugetVerbosityLevels.Normal)
                        .Source(@"\\localnugetserver")
                        .ToString();
        }

        [TestCase(ExpectedResult = @"nuget delete NuCLIus.Services 1.0.0 " +
                                @"-Source \\localnugetserver ")]
        public string NugetDeleteTest() {
            return Nuget.Init()
                        .Delete(@"NuCLIus.Services")
                        .PackageVersion("1.0.0")
                        .Source(@"\\localnugetserver")
                        .ToString();
        }

        [TestCase()]
        public void RelativeFileTest() {
            var path = Environment.CurrentDirectory;
            var fi = new FileInfo(@"..\..\..\NuCLIus.Testing.csproj");
            var fi2 = new FileInfo(@"..\..\..\..\NuCLIus.Services\NuCLIus.Services.csproj");
            Assert.IsTrue(fi.Exists && fi2.Exists);
        }

    }
}