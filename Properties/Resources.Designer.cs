﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MacroDeckWebView.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MacroDeckWebView.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to blank.
        /// </summary>
        internal static string BALLOON_TEXT {
            get {
                return ResourceManager.GetString("BALLOON_TEXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System Initiated.
        /// </summary>
        internal static string BALLOON_TITLE {
            get {
                return ResourceManager.GetString("BALLOON_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Macro Deck WebView.
        /// </summary>
        internal static string FORM_TITLE {
            get {
                return ResourceManager.GetString("FORM_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ICON {
            get {
                object obj = ResourceManager.GetObject("ICON", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something wrong just happened :(.
        /// </summary>
        internal static string MAIN_UNKNOW_EXCEPTION {
            get {
                return ResourceManager.GetString("MAIN_UNKNOW_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit.
        /// </summary>
        internal static string NOTIFY_EXIT_MENU {
            get {
                return ResourceManager.GetString("NOTIFY_EXIT_MENU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open Macro Deck WebView.
        /// </summary>
        internal static string NOTIFY_MENU_1 {
            get {
                return ResourceManager.GetString("NOTIFY_MENU_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Macro Deck WebView.
        /// </summary>
        internal static string NOTIFY_TOOLTIP {
            get {
                return ResourceManager.GetString("NOTIFY_TOOLTIP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/emerysteele/macrodeckwebview.
        /// </summary>
        internal static string REPOSITORY_URL {
            get {
                return ResourceManager.GetString("REPOSITORY_URL", resourceCulture);
            }
        }
    }
}
