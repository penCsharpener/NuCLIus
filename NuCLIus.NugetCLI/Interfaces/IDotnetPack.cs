using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IDotnetPack : IDotnetOut {
        /// <summary>
        /// null assume working directory
        /// </summary>
        /// <param name="path">null assume working directory</param>
        /// <returns></returns>
        IDotnetPackOptions Pack(string path = null);
    }
}
