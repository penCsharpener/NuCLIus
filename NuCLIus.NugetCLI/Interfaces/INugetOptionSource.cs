using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface INugetOptionSource : INugetOut {
        INugetOptionSource Source(string pathOrURL);
        INugetOptionSource NonInteractive();
    }
}
