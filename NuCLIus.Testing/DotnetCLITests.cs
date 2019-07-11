using NuCLIus.NugetCLI;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Tests {
    public class DotnetCLITests {

        [SetUp]
        public void Setup() {

        }

        [TestCase("Execute", false)]
        [TestCase("Execute", true)]
        public void BuildConfigTest(string desc, bool doExecute) {
            Assert.Pass(Dotnet.Init().Build().Configuration("Release").Out);
        }

        [TestCase]
        public void BuildRuntimeTest() {
            Assert.Pass(Dotnet.Init().Build().Runtime("ubuntu.18.04-x64").Out);
        }

        [TestCase]
        public void BuildSourceTest() {
            Assert.Pass(Dotnet.Init().Build().Source(@"E:\My Nuget Server").Out);
        }

        [TestCase]
        public void BuildVersionTest() {
            Assert.Pass(Dotnet.Init().Build().Version("1.2.3.4").Out);
        }

        [TestCase]
        public void PackTest() {
            Assert.Pass(Dotnet.Init().Pack().Out);
        }

        [TestCase]
        public void PackProjectPathTest() {
            Assert.Pass(Dotnet.Init().Pack(Environment.ExpandEnvironmentVariables(@"%userprofile%\Source\Repos\NuCLIus\NuCLIus.NugetCLI\NuCLIus.NugetCLI.csproj")).Out);
        }

        [TestCase]
        public void PackOutputTest() {
            Assert.Pass(Dotnet.Init().Pack().Output("nupkgs").Out);
        }

        [TestCase]
        public void PackVersionSuffixTest() {
            Assert.Pass(Dotnet.Init().Pack().VersionSuffix("beta-1").Out);
        }

        [TestCase]
        public void PackPackageVersion() {
            Assert.Pass(Dotnet.Init().Pack().PackageVersion("1.2.3.4").Out);
        }

        [TestCase]
        public void PackTargetFrameworksTest() {
            Assert.Pass(Dotnet.Init().Pack().TargetFramework(DotnetTargetFrameworks.netstandard2_0).Out);
        }

        [TestCase]
        public void PackNoBuildTest() {
            Assert.Pass(Dotnet.Init().Pack().NoBuild().Out);
        }
    }
}