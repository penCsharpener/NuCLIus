using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IDotnetMSBuild : IDotnetOut {
        IDotnetMSBuildOptions MSBuild();
    }
}
