using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IDotnetMSBuildOptions : IDotnetOut {
        IDotnetMSBuildOptions Publish();
        IDotnetMSBuildOptions RuntimeIdentifiers(params string[] identifier);
        IDotnetMSBuildOptions MSBuildConfiguration(string configName);
    }
}
