using NuCLIus.NugetCLI.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NuCLIus.NugetCLI {
    public abstract class CLIBase {
        protected StringBuilder sb = new StringBuilder();
        protected bool ValidatePaths = true;

        public CLIBase(string baseCommand) {
            if (string.IsNullOrWhiteSpace(baseCommand)) {
                throw new ArgumentNullException($"Base command cannot be '{baseCommand}'");
            }
            sb.Append(baseCommand.EnQuote()).Space();
        }

        protected void FilePathValidation(string path, bool mayBeNull) {
            if (ValidatePaths) {
                if (string.IsNullOrWhiteSpace(path) && mayBeNull == false) {
                    throw new ArgumentNullException($"invalid path in '{sb.ToString()}' command.");
                } else if (!string.IsNullOrWhiteSpace(path) && !File.Exists(path)) {
                    throw new FileNotFoundException($"File '{path}' not found for command '{sb.ToString()}'");
                }
            }
        }

        protected void DirPathValidation(string path, bool mayBeNull) {
            if (ValidatePaths) {
                if (string.IsNullOrWhiteSpace(path) && mayBeNull == false) {
                    throw new ArgumentNullException($"invalid path in '{sb.ToString()}' command.");
                } else if (!string.IsNullOrWhiteSpace(path) && !Directory.Exists(path)) {
                    throw new DirectoryNotFoundException($"Directory '{path}' not found for command '{sb.ToString()}'");
                }
            }
        }
    }
}
