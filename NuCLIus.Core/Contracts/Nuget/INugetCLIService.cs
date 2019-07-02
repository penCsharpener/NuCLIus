using NuCLIus.Core.Contracts.Nuget;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Contracts {
    public interface INugetCLIService {
        INugetAddOptions NugetAddOptions { get; set; }
        INugetPackProperties NugetPackProperties { get; set; }

        INugetCLIService SetFilePath(string path);
        INugetPack Pack();
        INugetCLIService Restore();
        INugetAddOptions Add();
        INugetCLIService Delete();
        INugetCLIService List();
        INugetCLIService Source(string path);
    }
}
