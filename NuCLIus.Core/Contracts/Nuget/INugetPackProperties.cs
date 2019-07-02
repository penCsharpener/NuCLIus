using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Contracts.Nuget {
    public interface INugetPackProperties {
        INugetPackProperties Configuration(string config = "Release");
        INugetPackProperties VersionSuffix(string suffix);
        INugetPack CloseProperties();
    }
}
