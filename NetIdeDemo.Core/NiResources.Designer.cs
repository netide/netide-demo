﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetIdeDemo.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class NiResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NiResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NetIdeDemo.Core.NiResources", typeof(NiResources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap About {
            get {
                object obj = ResourceManager.GetObject("About", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon MainIcon {
            get {
                object obj = ResourceManager.GetObject("MainIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!--
        ///    This code was generated by a tool.
        ///
        ///    Changes to this file may cause incorrect behavior and will be lost if
        ///    the code is regenerated.
        ///--&gt;
        ///&lt;resources xmlns=&quot;http://netide.github.io/netide-schemas/Resources.xsd&quot;&gt;
        ///  &lt;ui&gt;
        ///    &lt;menu kind=&quot;Toolbar&quot; priority=&quot;100&quot; id=&quot;Nid_Toolbar_About&quot; guid=&quot;{64F1B542-127E-4E94-8D5C-32ECF2A1E8A6}&quot;&gt;
        ///      &lt;group priority=&quot;100&quot;&gt;
        ///        &lt;button image=&quot;@About&quot; text=&quot;@AboutNetIdeDemo&quot; style=&quot;ImageAndText&quot; priority=&quot;100&quot; id=&quot;Nid_About_About&quot; guid=&quot;{7BA76FBF-2D7 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NiMenu {
            get {
                return ResourceManager.GetString("NiMenu", resourceCulture);
            }
        }
    }
}
