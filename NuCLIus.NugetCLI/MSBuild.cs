using NuCLIus.NugetCLI.Interfaces;
using NuCLIus.NugetCLI.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NuCLIus.NugetCLI {
    public sealed class MSBuild : CLIBase,
                           IMSBuild,
                           IMSBuildProperty,
                           IMSBuildVerbosity {

        public static MSBuild Init(string baseCommand = "msbuild") => new MSBuild(baseCommand);
        internal MSBuild(string baseCommand) : base(baseCommand) {
            if (!File.Exists(baseCommand)) {
                throw new FileNotFoundException($"'{baseCommand}' could not be found".);
            }
        }

        public IMSBuildOut Restore() {
            sb.Append("-r");
            return this;
        }

        public IMSBuildProperty Property() {
            sb.Append("-p:");
            return this;
        }

        public IMSBuildProperty Configuration(string configName) {
            sb.Append("Configuration=").Append(configName).Space();
            return this;
        }

        public IMSBuild Verbosity(MSBuildVerbosityLevels level) {
            sb.Append("-verbosity:").Append(level.ToString()).Space();
            return this;
        }

        public string Out => sb.ToString();
    }
}
