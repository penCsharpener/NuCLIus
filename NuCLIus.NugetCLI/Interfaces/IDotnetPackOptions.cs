using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IDotnetPackOptions : IDotnetOut {
        IDotnetPackOptions Output(string relativePath);
        IDotnetPackOptions NoBuild();
        IDotnetPackOptions VersionSuffix(string suffix);
        IDotnetPackOptions PackageVersion(string version);
        IDotnetPackOptions TargetFramework(DotnetTargetFrameworks enumValue);
    }
}
