﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Teams.Apps.AskHR.Configuration.Resources {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessages {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Microsoft.Teams.Apps.AskHR.Configuration.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string InvalidKnowledgeBaseId {
            get {
                return ResourceManager.GetString("InvalidKnowledgeBaseId", resourceCulture);
            }
        }
        
        internal static string TeamIdValidMessage {
            get {
                return ResourceManager.GetString("TeamIdValidMessage", resourceCulture);
            }
        }
        
        internal static string UnableToSaveHelpText {
            get {
                return ResourceManager.GetString("UnableToSaveHelpText", resourceCulture);
            }
        }
        
        internal static string UnableToSaveKnowledgeBaseId {
            get {
                return ResourceManager.GetString("UnableToSaveKnowledgeBaseId", resourceCulture);
            }
        }
        
        internal static string UnabletoSaveQnAKey {
            get {
                return ResourceManager.GetString("UnabletoSaveQnAKey", resourceCulture);
            }
        }
        
        internal static string UnableToSaveTeamId {
            get {
                return ResourceManager.GetString("UnableToSaveTeamId", resourceCulture);
            }
        }
        
        internal static string UnableToSaveWelcomeMsg {
            get {
                return ResourceManager.GetString("UnableToSaveWelcomeMsg", resourceCulture);
            }
        }
    }
}
