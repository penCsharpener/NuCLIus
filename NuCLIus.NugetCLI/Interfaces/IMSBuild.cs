using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IMSBuild : IMSBuildOut {
        IMSBuildOut Restore();
        IMSBuildProperty Property();
    }
}
