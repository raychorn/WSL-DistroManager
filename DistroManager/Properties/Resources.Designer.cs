﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistroManager.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DistroManager.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Please create a default UNIX user account. The username does not need to match your Windows username.
        ///For more information visit: https://aka.ms/wslusers.
        /// </summary>
        internal static string MSG_CREATE_USER_PROMPT {
            get {
                return ResourceManager.GetString("MSG_CREATE_USER_PROMPT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter new UNIX username:.
        /// </summary>
        internal static string MSG_ENTER_USERNAME {
            get {
                return ResourceManager.GetString("MSG_ENTER_USERNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: 0x{0:X8} {1}.
        /// </summary>
        internal static string MSG_ERROR_CODE {
            get {
                return ResourceManager.GetString("MSG_ERROR_CODE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The distribution installation has become corrupted.
        ///Please select Reset from App Settings or uninstall and reinstall the app..
        /// </summary>
        internal static string MSG_INSTALL_ALREADY_EXISTS {
            get {
                return ResourceManager.GetString("MSG_INSTALL_ALREADY_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installation successful!.
        /// </summary>
        internal static string MSG_INSTALL_SUCCESS {
            get {
                return ResourceManager.GetString("MSG_INSTALL_SUCCESS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You do not have sufficient rights to install a new distro..
        /// </summary>
        internal static string MSG_INSUFFICIENT_RIGHTS {
            get {
                return ResourceManager.GetString("MSG_INSUFFICIENT_RIGHTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Windows Subsystem for Linux optional component is not enabled. Please enable it and try again.
        ///See https://aka.ms/wslinstall for details..
        /// </summary>
        internal static string MSG_MISSING_OPTIONAL_COMPONENT {
            get {
                return ResourceManager.GetString("MSG_MISSING_OPTIONAL_COMPONENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press any key to continue....
        /// </summary>
        internal static string MSG_PRESS_A_KEY {
            get {
                return ResourceManager.GetString("MSG_PRESS_A_KEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing, this may take a few minutes....
        /// </summary>
        internal static string MSG_STATUS_INSTALLING {
            get {
                return ResourceManager.GetString("MSG_STATUS_INSTALLING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Launches or configures a Linux distribution.
        ///
        ///Usage: 
        ///    &lt;no args&gt; 
        ///        Launches the user&apos;s default shell in the user&apos;s home directory.
        ///
        ///    install [--root]
        ///        Install the distribuiton and do not launch the shell when complete.
        ///          --root
        ///              Do not create a user account and leave the default user set to root.
        ///
        ///    run &lt;command line&gt; 
        ///        Run the provided command line in the current working directory. If no
        ///        command line is provided, the default shell is la [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MSG_USAGE {
            get {
                return ResourceManager.GetString("MSG_USAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WslGetDistributionConfiguration failed with error: 0x{0:X8}.
        /// </summary>
        internal static string MSG_WSL_CONFIGURE_DISTRIBUTION_FAILED {
            get {
                return ResourceManager.GetString("MSG_WSL_CONFIGURE_DISTRIBUTION_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WslLaunch {0} failed with error: 0x{1:X8}.
        /// </summary>
        internal static string MSG_WSL_LAUNCH_FAILED {
            get {
                return ResourceManager.GetString("MSG_WSL_LAUNCH_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WslLaunchInteractive {0} failed with error: 0x{1:X8}.
        /// </summary>
        internal static string MSG_WSL_LAUNCH_INTERACTIVE_FAILED {
            get {
                return ResourceManager.GetString("MSG_WSL_LAUNCH_INTERACTIVE_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WslRegisterDistribution failed with error: 0x{0:X8}.
        /// </summary>
        internal static string MSG_WSL_REGISTER_DISTRIBUTION_FAILED {
            get {
                return ResourceManager.GetString("MSG_WSL_REGISTER_DISTRIBUTION_FAILED", resourceCulture);
            }
        }
    }
}
