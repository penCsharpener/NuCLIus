using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface INugetPackProperties : INugetOut {
        
        INugetPackProperties Configuration(string config = "Release");
    }
}
