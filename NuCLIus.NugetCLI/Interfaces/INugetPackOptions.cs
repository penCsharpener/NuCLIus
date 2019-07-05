using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface INugetPackOptions : INugetOut {

        INugetPackOptions Build();
        INugetPackOptions Exclude(string filter);
        INugetPackOptions ExcludeEmptyDirectories();
        INugetPackOptions OutputDirectory(string path, bool createIfNotExists = false);
        INugetPackOptions VerbosityPack(NugetVerbosityLevels verbosity);
        INugetPackOptions VersionSuffix(string suffix);
        INugetPackOptions Symbols();
        INugetPackProperties Properties();
    }
}
