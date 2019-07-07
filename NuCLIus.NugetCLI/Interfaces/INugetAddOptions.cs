using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface INugetAddOptions : INugetOptionSource {
        INugetAddOptions VerbosityAdd(NugetVerbosityLevels level);
    }
}
