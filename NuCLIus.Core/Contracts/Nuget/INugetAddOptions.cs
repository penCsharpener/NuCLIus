using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Contracts {
    public interface INugetAddOptions {
        INugetAddOptions Verbosity();
        INugetAddOptions Source(string path = null);
        INugetAddOptions NonInteractive();
        INugetCLIService CloseOptions();
    }
}
