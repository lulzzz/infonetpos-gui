﻿#pragma checksum "F:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\Controls\PumpOptions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "59D4A035464E5D58ECC53F1E57A52D21"
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
    partial class PumpOptions : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Border_Background(global::Windows.UI.Xaml.Controls.Border obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.CancelCommand = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PumpOptions_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPumpOptions_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.PumpOptions dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Border obj2;
            private global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj3;

            private PumpOptions_obj1_BindingsTracking bindingsTracking;

            public PumpOptions_obj1_Bindings()
            {
                this.bindingsTracking = new PumpOptions_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\PumpOptions.xaml line 22
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 3: // Controls\PumpOptions.xaml line 41
                        this.obj3 = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)target;
                        break;
                    default:
                        break;
                }
            }

            // IPumpOptions_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.Controls.PumpOptions)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.PumpOptions obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BackgroundOverlay(obj.BackgroundOverlay, phase);
                        this.Update_CancelCommand(obj.CancelCommand, phase);
                    }
                }
            }
            private void Update_BackgroundOverlay(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\PumpOptions.xaml line 22
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj2, obj, null);
                }
            }
            private void Update_CancelCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\PumpOptions.xaml line 41
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(this.obj3, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class PumpOptions_obj1_BindingsTracking
            {
                private global::System.WeakReference<PumpOptions_obj1_Bindings> weakRefToBindingObj; 

                public PumpOptions_obj1_BindingsTracking(PumpOptions_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<PumpOptions_obj1_Bindings>(obj);
                }

                public PumpOptions_obj1_Bindings TryGetBindingObject()
                {
                    PumpOptions_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_BackgroundOverlay(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    PumpOptions_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.PumpOptions obj = sender as global::Infonet.CStoreCommander.UI.Controls.PumpOptions;
                        if (obj != null)
                        {
                            bindings.Update_BackgroundOverlay(obj.BackgroundOverlay, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_CancelCommand(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    PumpOptions_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.PumpOptions obj = sender as global::Infonet.CStoreCommander.UI.Controls.PumpOptions;
                        if (obj != null)
                        {
                            bindings.Update_CancelCommand(obj.CancelCommand, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_BackgroundOverlay = 0;
                private long tokenDPC_CancelCommand = 0;
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Controls.PumpOptions obj)
                {
                    PumpOptions_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.PumpOptions.BackgroundOverlayProperty, tokenDPC_BackgroundOverlay);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.PumpOptions.CancelCommandProperty, tokenDPC_CancelCommand);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_BackgroundOverlay = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.PumpOptions.BackgroundOverlayProperty, DependencyPropertyChanged_BackgroundOverlay);
                            tokenDPC_CancelCommand = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.PumpOptions.CancelCommandProperty, DependencyPropertyChanged_CancelCommand);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // Controls\PumpOptions.xaml line 41
                {
                    this.TitleText = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Controls\PumpOptions.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    PumpOptions_obj1_Bindings bindings = new PumpOptions_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

