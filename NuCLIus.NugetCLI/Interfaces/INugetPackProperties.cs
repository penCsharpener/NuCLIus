using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface INugetPackProperties {
        
        INugetPackProperties Configuration(string config = "Release");
        string Close();
    }
}
