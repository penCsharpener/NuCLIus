using NuCLIus.Core.Contracts;
using NuCLIus.Core.Contracts.Nuget;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Services.Nuget {
    public class NugetCLIService : INugetCLIService {
        private readonly IPreferenceService _preference;


        public NugetCLIService(IPreferenceService preference) {
            _preference = preference;
        }

        public INugetAddOptions NugetAddOptions { get; set; }
        public INugetPackProperties NugetPackProperties { get; set; }

        public INugetAddOptions Add() {
            throw new NotImplementedException();
        }

        public INugetCLIService Delete() {
            throw new NotImplementedException();
        }

        public INugetCLIService List() {
            throw new NotImplementedException();
        }

        public INugetPack Pack() {
            throw new NotImplementedException();
        }

        public INugetCLIService Restore() {
            throw new NotImplementedException();
        }

        public INugetCLIService SetFilePath(string path) {
            throw new NotImplementedException();
        }

        public INugetCLIService Source(string path) {
            throw new NotImplementedException();
        }
    }
}
