using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IMSBuildVerbosity : IMSBuildOut {
        IMSBuild Verbosity(MSBuildVerbosityLevels level);
    }
}
