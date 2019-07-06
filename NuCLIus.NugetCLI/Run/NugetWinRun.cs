using NuCLIus.NugetCLI.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.NugetCLI.Run {
    public class NugetWinRun : IRunNuget {
        public void Run(string command, string workingDir = null) {
            var proc = Process.Start(GetProcessInfo(command));
            OnGetCmdStandardOutput(proc.StandardOutput);
        }

        public async Task RunAsync(string command, string workingDir = null) {
            await await Task.Factory.StartNew(async () => {
                var proc = Process.Start(GetProcessInfo(command));
                await OnGetCmdStandardOutputAsync(proc.StandardOutput);
            });
        }

        private ProcessStartInfo GetProcessInfo(string command, string workingDir = null) {
            var info = new ProcessStartInfo() {
                FileName = "cmd.exe",
                Arguments = "/C " + command,
                UseShellExecute = false,
                CreateNoWindow = false,
                RedirectStandardOutput = true,
            };
            if (!string.IsNullOrWhiteSpace(workingDir)) {
                info.WorkingDirectory = workingDir;
            }
            return info;
        }

        public event EventHandler<string> GetCmdStandardOutput;
        protected virtual void OnGetCmdStandardOutput(StreamReader sr) {
            GetCmdStandardOutput?.Invoke(this, sr.ReadToEndAsync().GetAwaiter().GetResult());
        }

        protected async virtual Task OnGetCmdStandardOutputAsync(StreamReader sr) {
            GetCmdStandardOutput?.Invoke(this, await sr.ReadToEndAsync());
        }

    }
}
