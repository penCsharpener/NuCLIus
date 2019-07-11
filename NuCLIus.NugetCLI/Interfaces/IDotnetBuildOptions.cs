using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IDotnetBuildOptions : IDotnetOut, IDotnetBuildConfig {
        IDotnetBuildOptions Runtime(string runtime);
        IDotnetBuildOptions Source(string path);
        IDotnetBuildOptions Version(string version);

    }
}
