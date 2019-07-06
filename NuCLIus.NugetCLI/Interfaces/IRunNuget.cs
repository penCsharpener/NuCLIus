using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.NugetCLI.Interfaces {
    public interface IRunNuget {
        Task RunAsync(string command);
        void Run(string command);
        event EventHandler<string> GetCmdStandardOutput;
    }
}
