using NuCLIus.NugetCLI;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Tests {
    public class MSBuildCLITests {

        private string msbuildPath;

        [SetUp]
        public void Setup() {
            msbuildPath = @"D:\Code\VS2019\MSBuild\Current\Bin\MSBuild.exe";
        }

        [TestCase("Execute", false)]
        [TestCase("Execute", true)]
        public void PropertyConfigReleaseTest(string desc, bool doExecute) {
            Assert.Pass(MSBuild.Init(msbuildPath).Property().Configuration("Release").Out);
        }

        [TestCase]
        public void VerbosityLevelTest() {
            Assert.Pass(MSBuild.Init(msbuildPath).Verbosity(MSBuildVerbosityLevels.minimal).Restore().Out);
        }
    }
}