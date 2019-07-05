using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface INuget {

        INugetAddOptions Add(string filePath);
        INugetPackOptions Pack(string path);
        INugetDeleteOptions Delete(string packageID);

    }
}
