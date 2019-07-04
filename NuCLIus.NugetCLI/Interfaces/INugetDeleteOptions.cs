using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface INugetDeleteOptions : INugetOptionSource {

        INugetDeleteOptions PackageVersion(string version);
        INugetDeleteOptions APIKey(string apiKey);

    }
}
