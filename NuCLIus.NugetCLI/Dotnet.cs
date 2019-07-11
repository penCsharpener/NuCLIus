using NuCLIus.NugetCLI.Interfaces;
using NuCLIus.NugetCLI.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace NuCLIus.NugetCLI {
    public sealed class Dotnet : CLIBase,
                          IDotnetMSBuild,
                          IDotnetMSBuildOptions,
                          IDotnetBuild,
                          IDotnetBuildOptions,
                          IDotnetPack,
                          IDotnetPackOptions {
        public string Out => sb.ToString();

        public static Dotnet Init() => new Dotnet();
        internal Dotnet() : base("dotnet") { }

        public Dotnet NoPathValidation() {
            ValidatePaths = false;
            return this;
        }

        public IDotnetMSBuildOptions MSBuild() {
            sb.Append("msbuild ");
            return this;
        }

        public IDotnetPackOptions Pack(string path = null) {
            FilePathValidation(path, mayBeNull: true);
            sb.Append("pack ");
            if (!string.IsNullOrWhiteSpace(path)) {
                sb.Append(path.EnQuote()).Space();
            }
            return this;
        }

        public IDotnetPackOptions Output(string relativePath) {
            sb.Append("--output ").Append(relativePath.EnQuote()).Space();
            return this;
        }

        public IDotnetPackOptions NoBuild() {
            sb.Append("--no-build ");
            return this;
        }

        public IDotnetPackOptions VersionSuffix(string suffix) {
            sb.Append("--version-suffix \"").Append(suffix).Append("\" ");
            return this;
        }

        public IDotnetPackOptions PackageVersion(string version) {
            sb.Append("-p:PackageVersion=").Append(version).Space();
            return this;
        }

        public IDotnetPackOptions TargetFramework(DotnetTargetFrameworks enumValue) {
            sb.Append("-p:TargetFrameworks=").Append(enumValue.ToString().Replace("_", ".")).Space();
            return this;
        }

        public IDotnetBuildOptions Build() {
            sb.Append("build ");
            return this;
        }

        public IDotnetOut Configuration(string configName) {
            sb.Append("--configuration ").Append(configName).Space();
            return this;
        }

        public IDotnetBuildOptions Runtime(string runtime) {
            sb.Append("--runtime ").Append(runtime).Space();
            return this;
        }

        public IDotnetBuildOptions Source(string path) {
            DirPathValidation(path, false);
            sb.Append("--source ").Append(path.EnQuote()).Space();
            return this;
        }

        public IDotnetBuildOptions Version(string version) {
            sb.Append("-p:Version=").Append(version).Space();
            return this;
        }

        public IDotnetMSBuildOptions MSBuildConfiguration(string configName) {
            sb.Append("-p:Configuration=").Append(configName).Space();
            return this;
        }

        public IDotnetMSBuildOptions Publish() {
            sb.Append("-t:Publish ");
            return this;
        }

        /// <summary>
        /// osx.10.11-x64, osx.10.14-x64, win10-x64, linux-x64, rhel-x64, rhel.6-x64
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public IDotnetMSBuildOptions RuntimeIdentifiers(params string[] identifier) {
            sb.Append("-p:RuntimeIdentifiers=").Append(string.Join(";", identifier)).Space();
            return this;
        }

    }
}
