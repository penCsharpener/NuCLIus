using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NuCLIus.NugetCLI.Utils {
    public static class NugetExtensions {
        internal static string EnQuote(this string str) {
            return str.Contains(" ") ? $"\"{str}\"" : str;
        }

        internal static void FileValidate(this string filePath) {
            if (!File.Exists(filePath) && Nuget.Validate) {
                throw new FileNotFoundException($"File '{filePath}' not found.");
            }
        }

        internal static void DirectoryValidate(this string directoryPath) {
            if (!File.Exists(directoryPath) && Nuget.Validate) {
                throw new FileNotFoundException($"File '{directoryPath}' not found.");
            }
        }

        internal static StringBuilder Space(this StringBuilder sb) {
            return sb.Append(" ");
        }
    }
}
