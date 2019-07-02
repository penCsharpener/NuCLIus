using NuCLIus.Core.Preferences;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Contracts.Nuget {
    public interface INugetPack {
        INugetPack Build();
        INugetPack Exclude(string filter);
        INugetPack ExcludeEmptyDirectories();
        INugetPack IncludeProjectReference();
        INugetPack OutputDirectory(string path);
        INugetPackProperties Properties();
        INugetPack Verbosity(NugetVerbosityLevels verbosity);
        INugetPack Symbols();
        INugetCLIService ClosePack();
    }
}
