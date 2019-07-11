using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IDotnetBuild : IDotnetOut {
        IDotnetBuildOptions Build();
    }
}
