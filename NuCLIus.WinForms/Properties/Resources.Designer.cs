﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuCLIus.WinForms.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuCLIus.WinForms.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The location where all created .nupkg files should be created at. If blank it defaults to {path of .csproj/.nuspec}\bin\Nuget.
        /// </summary>
        internal static string pref_nuget_default_output_path {
            get {
                return ResourceManager.GetString("pref_nuget_default_output_path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path to your nuget.exe file. If blank it is assumed that an environment variable for it exists or it is at C:\Windows\system32.
        /// </summary>
        internal static string pref_nuget_exe_path {
            get {
                return ResourceManager.GetString("pref_nuget_exe_path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simple local folder for pre-release nuget packages. .nupkgs are just copied there. If blank no dev nuget server is used..
        /// </summary>
        internal static string pref_nuget_local_dev_nuget_server {
            get {
                return ResourceManager.GetString("pref_nuget_local_dev_nuget_server", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to local nuget &apos;server&apos; with hierachical struggle created by &apos;nuget add &lt;.nupkg&gt; -Source &lt;this Path&gt;&apos; commands. If blank no local nuget server is used..
        /// </summary>
        internal static string pref_nuget_local_nuget_server {
            get {
                return ResourceManager.GetString("pref_nuget_local_nuget_server", resourceCulture);
            }
        }
    }
}
