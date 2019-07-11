using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IMSBuildProperty : IMSBuildOut {
        IMSBuildProperty Configuration(string configName);
        
    }
}
