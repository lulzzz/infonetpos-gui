﻿#pragma checksum "F:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\Controls\EmergencyPopup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BE2C6108D016605CD5B00298878FD257"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.Controls
{
    partial class EmergencyPopup : global::Windows.UI.Xaml.Controls.UserControl
    {


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        private global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader TitleText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        private global::Infonet.CStoreCommander.ControlLib.GenericButton ConfirmButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;

            global::System.Uri resourceLocator = new global::System.Uri("ms-appx:///Controls/EmergencyPopup.xaml");
            global::Windows.UI.Xaml.Application.LoadComponent(this, resourceLocator, global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
        }

        partial void UnloadObject(global::Windows.UI.Xaml.DependencyObject unloadableObject);

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        private interface IEmergencyPopup_Bindings
        {
            void Initialize();
            void Update();
            void StopTracking();
            void DisconnectUnloadedObject(int connectionId);
        }

        private interface IEmergencyPopup_BindingsScopeConnector
        {
            global::System.WeakReference Parent { get; set; }
            bool ContainsElement(int connectionId);
            void RegisterForElementConnection(int connectionId, global::Windows.UI.Xaml.Markup.IComponentConnector connector);
        }
#pragma warning disable 0169    //  Proactively suppress unused field warning in case Bindings is not used.
#pragma warning disable 0649
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        private IEmergencyPopup_Bindings Bindings;
#pragma warning restore 0649
#pragma warning restore 0169
    }
}


