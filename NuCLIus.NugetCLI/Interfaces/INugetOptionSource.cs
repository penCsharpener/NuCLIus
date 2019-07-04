using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface INugetOptionSource {
        INugetOptionSource Source(string pathOrURL);
    }
}
