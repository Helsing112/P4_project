﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication5.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point Location {
            get {
                return ((global::System.Drawing.Point)(this["Location"]));
            }
            set {
                this["Location"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\Library\\Table_Library\\")]
        public string Path_of_Table_list_file {
            get {
                return ((string)(this["Path_of_Table_list_file"]));
            }
            set {
                this["Path_of_Table_list_file"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tables")]
        public string Table_file_name {
            get {
                return ((string)(this["Table_file_name"]));
            }
            set {
                this["Table_file_name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\Library\\Table_Library\\Plan_OLearys.png")]
        public string Path_of_resturant_plan {
            get {
                return ((string)(this["Path_of_resturant_plan"]));
            }
            set {
                this["Path_of_resturant_plan"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\Library\\Table_Library\\Table_types")]
        public string Path_of_table_type_lib {
            get {
                return ((string)(this["Path_of_table_type_lib"]));
            }
            set {
                this["Path_of_table_type_lib"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\Library\\Product library")]
        public string Path_Of_ProductLibrary {
            get {
                return ((string)(this["Path_Of_ProductLibrary"]));
            }
            set {
                this["Path_Of_ProductLibrary"] = value;
            }
        }
    }
}
