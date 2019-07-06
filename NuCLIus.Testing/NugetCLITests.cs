using NuCLIus.NugetCLI;
using NuCLIus.NugetCLI.Interfaces;
using NuCLIus.NugetCLI.Run;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Tests {
    public class NugetCLITests {

        private IRunNuget run;

        [SetUp]
        public void Setup() {
            Nuget.Validate = true;
            run = new NugetWinRun();
            
        }


        [TestCase("Execute", false)]
        [TestCase("Execute", true)]
        public async Task NugetPackTest(string desc, bool doExecute) {
            var cmd = Nuget.Init()
                        .Pack(@"..\..\..\..\NuCLIus.Services\NuCLIus.Services.csproj")
                        .OutputDirectory("E:\\NuCLIusTests", createIfNotExists: true)
                        .Properties()
                        .Configuration()
                        .Out;
            Debug.WriteLine(cmd);
            run.GetCmdStandardOutput += (s, stdout) => {
                Debug.WriteLine(stdout);
            };
            if (doExecute) {
                await run.RunAsync(cmd);
            }
            Assert.IsTrue(cmd == @"nuget pack ..\..\..\..\NuCLIus.Services\NuCLIus.Services.csproj " +
                                 @"-OutputDirectory E:\NuCLIusTests -Properties Configuration=Release");
        }

        [TestCase(ExpectedResult = @"nuget add ..\..\..\..\NuCLIus.Services\NuCLIus.Services.1.0.0.nupkg " +
                                   @"-Verbosity Normal -Source \\localnugetserver ")]
        public string NugetAddTest() {
            return Nuget.Init()
                        .Add(@"..\..\..\..\NuCLIus.Services\NuCLIus.Services.1.0.0.nupkg")
                        .VerbosityAdd(NugetVerbosityLevels.Normal)
                        .Source(@"\\localnugetserver")
                        .Out;
        }

        [TestCase(ExpectedResult = @"nuget delete NuCLIus.Services 1.0.0 " +
                                   @"-Source \\localnugetserver ")]
        public string NugetDeleteTest() {
            return Nuget.Init()
                        .Delete(@"NuCLIus.Services")
                        .PackageVersion("1.0.0")
                        .Source(@"\\localnugetserver")
                        .Out;
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