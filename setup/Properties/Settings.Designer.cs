//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Terraria.ModLoader.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files (x86)\\Steam\\steamapps\\common\\terraria")]
        public string SteamDir {
            get {
                return ((string)(this["SteamDir"]));
            }
            set {
                this["SteamDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2015-01-01")]
        public global::System.DateTime TerrariaDiffCutoff {
            get {
                return ((global::System.DateTime)(this["TerrariaDiffCutoff"]));
            }
            set {
                this["TerrariaDiffCutoff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2015-01-01")]
        public global::System.DateTime tModLoaderDiffCutoff {
            get {
                return ((global::System.DateTime)(this["tModLoaderDiffCutoff"]));
            }
            set {
                this["tModLoaderDiffCutoff"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.3.5.3")]
        public string ClientVersion {
            get {
                return ((string)(this["ClientVersion"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.3.5.3")]
        public string ServerVersion {
            get {
                return ((string)(this["ServerVersion"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int PatchMode {
            get {
                return ((int)(this["PatchMode"]));
            }
            set {
                this["PatchMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FormatAfterDecompiling {
            get {
                return ((bool)(this["FormatAfterDecompiling"]));
            }
            set {
                this["FormatAfterDecompiling"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3179a1ec67d5f80bfb77175c403d59c7")]
        public string SteamClientWinMD5 {
            get {
                return ((string)(this["SteamClientWinMD5"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("b92f242bc874dddbf08f705661b313a9")]
        public string GoGClientWinMD5 {
            get {
                return ((string)(this["GoGClientWinMD5"]));
            }
        }
    }
}
