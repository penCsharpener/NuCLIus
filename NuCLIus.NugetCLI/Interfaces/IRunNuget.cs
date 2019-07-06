using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IRunNuget {
        Task RunAsync(string command, string workingDir = null);
        void Run(string command, string workingDir = null);
        event EventHandler<string> GetCmdStandardOutput;
    }
}
