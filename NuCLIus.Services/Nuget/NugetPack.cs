using NuCLIus.Core.Contracts;
using NuCLIus.Core.Contracts.Nuget;
using NuCLIus.Core.Preferences;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Services.Nuget {
    public class NugetPack : INugetPack {
        public INugetPack Build() {
            throw new NotImplementedException();
        }

        public INugetCLIService ClosePack() {
            throw new NotImplementedException();
        }

        public INugetPack Exclude(string filter) {
            throw new NotImplementedException();
        }

        public INugetPack ExcludeEmptyDirectories() {
            throw new NotImplementedException();
        }

        public INugetPack IncludeProjectReference() {
            throw new NotImplementedException();
        }

        public INugetPack OutputDirectory(string path) {
            throw new NotImplementedException();
        }

        public INugetPackProperties Properties() {
            throw new NotImplementedException();
        }

        public INugetPack Symbols() {
            throw new NotImplementedException();
        }

        public INugetPack Verbosity(NugetVerbosityLevels verbosity) {
            throw new NotImplementedException();
        }
    }
}
