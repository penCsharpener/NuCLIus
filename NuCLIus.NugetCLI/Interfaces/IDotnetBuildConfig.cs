using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IDotnetBuildConfig{
        IDotnetOut Configuration(string configName);
    }
}
