using NuCLIus.Core.Contracts.Nuget;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Services.Nuget {
    public class NugetPackProperties : INugetPackProperties {
        public INugetPack CloseProperties() {
            throw new NotImplementedException();
        }

        public INugetPackProperties Configuration(string config = "Release") {
            throw new NotImplementedException();
        }

        public INugetPackProperties VersionSuffix(string suffix) {
            throw new NotImplementedException();
        }
    }
}
