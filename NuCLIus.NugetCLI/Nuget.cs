using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NuCLIus.NugetCLI.Interfaces;
using NuCLIus.NugetCLI.Utils;

namespace NuCLIus.NugetCLI {
    public class Nuget : INuget,
                         INugetAddOptions,
                         INugetPackOptions,
                         INugetPackProperties,
                         INugetDeleteOptions {

        private StringBuilder sb = new StringBuilder();

        public static bool Validate { get; set; } = true;

        public static Nuget Init() => new Nuget();
        public static Nuget Init(string nugetExePath) => new Nuget(nugetExePath);

        internal Nuget() {
            sb.Append("nuget ");
        }

        internal Nuget(string nugetExePath) {
            nugetExePath.FileValidate();
            sb.Append(nugetExePath.EnQuote()).Space();
        }

        #region Add

        public INugetAddOptions Add(string filePath) {
            filePath.FileValidate();
            sb.Append("add ").Append(filePath.EnQuote()).Space();
            return this;
        }

        public INugetAddOptions VerbosityAdd(NugetVerbosityLevels level) {
            sb.Append("-Verbosity ").Append(level.ToString()).Space();
            return this;
        }

        public INugetAddOptions NonInteractive() {
            sb.Append("-NonInteractive ");
            return this;
        }

        #endregion

        #region Delete

        public INugetDeleteOptions Delete(string packageID) {
            sb.Append("delete ").Append(packageID).Space();
            return this;
        }

        public INugetDeleteOptions PackageVersion(string version) {
            sb.Append(version).Space();
            return this;
        }

        public INugetOptionSource Source(string pathOrURL) {
            sb.Append("-Source ").Append(pathOrURL.EnQuote()).Space();
            return this;
        }

        public INugetDeleteOptions APIKey(string apiKey) {
            sb.Append("-apikey ").Append(apiKey).Space();
            return this;
        }

        #endregion

        #region Pack

        public INugetPackOptions Pack(string pathProjOrNuspec) {
            pathProjOrNuspec.FileValidate();
            sb.Append("pack ").Append(pathProjOrNuspec.EnQuote()).Space();
            return this;
        }

        public INugetPackOptions Build() {
            sb.Append("-Build ");
            return this;
        }

        public INugetPackOptions Exclude(string filter) {
            sb.Append("-Exclude \"").Append(filter).Append("\" ");
            return this;
        }

        public INugetPackOptions ExcludeEmptyDirectories() {
            sb.Append("-ExcludeEmptyDirectories ");
            return this;
        }

        /// <summary>
        /// a null or whitespace path will omit this option entirely but not throw exception
        /// </summary>
        /// <param name="path"></param>
        /// <param name="createIfNotExists"></param>
        /// <returns></returns>
        public INugetPackOptions OutputDirectory(string path, bool createIfNotExists = false) {
            if (string.IsNullOrWhiteSpace(path)) {
                return this;
            }
            if (!Directory.Exists(path)) {
                if (createIfNotExists) {
                    Directory.CreateDirectory(path);
                } else {
                    throw new DirectoryNotFoundException($"Directory '{path}' not found.");
                }
            }
            sb.Append("-OutputDirectory ").Append(path.EnQuote()).Space();
            return this;
        }

        /// <summary>
        /// Should appear last on the command line after other options.
        /// </summary>
        /// <returns></returns>
        public INugetPackProperties Properties() {
            sb.Append("-Properties ");
            return this;
        }

        public INugetPackProperties Configuration(string config = "Release") {
            sb.Append("Configuration=").Append(config);
            return this;
        }

        public INugetPackOptions VersionSuffix(string suffix) {
            sb.Append("-Suffix ").Append(suffix);
            return this;
        }

        public INugetPackOptions Symbols() {
            sb.Append("-Symbols ");
            return this;
        }

        public INugetPackOptions VerbosityPack(NugetVerbosityLevels level) {
            sb.Append("-Verbosity ").Append(level.ToString()).Space();
            return this;
        }

        #endregion

        public string Out => sb.ToString();
    }
}
