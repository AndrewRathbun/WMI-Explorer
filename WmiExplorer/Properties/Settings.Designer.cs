﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WmiExplorer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool bCheckForUpdates {
            get {
                return ((bool)(this["bCheckForUpdates"]));
            }
            set {
                this["bCheckForUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool bPreserveLayout {
            get {
                return ((bool)(this["bPreserveLayout"]));
            }
            set {
                this["bPreserveLayout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool bRememberEnumOptions {
            get {
                return ((bool)(this["bRememberEnumOptions"]));
            }
            set {
                this["bRememberEnumOptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool bRememberRecentPaths {
            get {
                return ((bool)(this["bRememberRecentPaths"]));
            }
            set {
                this["bRememberRecentPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool bUpdateAvailable {
            get {
                return ((bool)(this["bUpdateAvailable"]));
            }
            set {
                this["bUpdateAvailable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool bUpgradeSettings {
            get {
                return ((bool)(this["bUpgradeSettings"]));
            }
            set {
                this["bUpgradeSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public string CacheAgeInMinutes {
            get {
                return ((string)(this["CacheAgeInMinutes"]));
            }
            set {
                this["CacheAgeInMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::WmiExplorer.Classes.EnumOptions EnumOptionsFlags {
            get {
                return ((global::WmiExplorer.Classes.EnumOptions)(this["EnumOptionsFlags"]));
            }
            set {
                this["EnumOptionsFlags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1970-01-01")]
        public global::System.DateTime LastUpdateCheck {
            get {
                return ((global::System.DateTime)(this["LastUpdateCheck"]));
            }
            set {
                this["LastUpdateCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentPaths {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentPaths"]));
            }
            set {
                this["RecentPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("220")]
        public int SplitterDistanceNamespaces {
            get {
                return ((int)(this["SplitterDistanceNamespaces"]));
            }
            set {
                this["SplitterDistanceNamespaces"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int SplitterDistanceClasses {
            get {
                return ((int)(this["SplitterDistanceClasses"]));
            }
            set {
                this["SplitterDistanceClasses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("180")]
        public int SplitterDistanceInstances {
            get {
                return ((int)(this["SplitterDistanceInstances"]));
            }
            set {
                this["SplitterDistanceInstances"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public string UpdateCheckIntervalInDays {
            get {
                return ((string)(this["UpdateCheckIntervalInDays"]));
            }
            set {
                this["UpdateCheckIntervalInDays"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/vinaypamnani/wmie2/master/WmiExplorer/releases." +
            "xml")]
        public string UpdateCheckUrl {
            get {
                return ((string)(this["UpdateCheckUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://wmie.azurewebsites.net/releases.xml")]
        public string UpdateCheckUrlBackup {
            get {
                return ((string)(this["UpdateCheckUrlBackup"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/vinaypamnani/wmie2/releases")]
        public string UpdateUrl {
            get {
                return ((string)(this["UpdateUrl"]));
            }
            set {
                this["UpdateUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string WindowPlacement {
            get {
                return ((string)(this["WindowPlacement"]));
            }
            set {
                this["WindowPlacement"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool bEnumModeAsync {
            get {
                return ((bool)(this["bEnumModeAsync"]));
            }
            set {
                this["bEnumModeAsync"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool bSmsMode {
            get {
                return ((bool)(this["bSmsMode"]));
            }
            set {
                this["bSmsMode"] = value;
            }
        }
    }
}
