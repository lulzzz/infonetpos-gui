﻿#pragma checksum "F:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\Controls\LargePopupHeader.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F94D66D523F5E669064E710FE327E9A5"
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
    partial class LargePopupHeader : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_WinRT_Triggers_InvokeCommandAction_Command(global::WinRT.Triggers.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class LargePopupHeader_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ILargePopupHeader_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;

            private LargePopupHeader_obj1_BindingsTracking bindingsTracking;

            public LargePopupHeader_obj1_Bindings()
            {
                this.bindingsTracking = new LargePopupHeader_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\LargePopupHeader.xaml line 36
                        this.obj2 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 3: // Controls\LargePopupHeader.xaml line 14
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // ILargePopupHeader_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CancelCommand(obj.CancelCommand, phase);
                        this.Update_Text(obj.Text, phase);
                    }
                }
            }
            private void Update_CancelCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\LargePopupHeader.xaml line 36
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_Text(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\LargePopupHeader.xaml line 14
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class LargePopupHeader_obj1_BindingsTracking
            {
                private global::System.WeakReference<LargePopupHeader_obj1_Bindings> weakRefToBindingObj; 

                public LargePopupHeader_obj1_BindingsTracking(LargePopupHeader_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<LargePopupHeader_obj1_Bindings>(obj);
                }

                public LargePopupHeader_obj1_Bindings TryGetBindingObject()
                {
                    LargePopupHeader_obj1_Bindings bindingObject = null;
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

                public void DependencyPropertyChanged_CancelCommand(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    LargePopupHeader_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader obj = sender as global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader;
                        if (obj != null)
                        {
                            bindings.Update_CancelCommand(obj.CancelCommand, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Text(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    LargePopupHeader_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader obj = sender as global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader;
                        if (obj != null)
                        {
                            bindings.Update_Text(obj.Text, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_CancelCommand = 0;
                private long tokenDPC_Text = 0;
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader obj)
                {
                    LargePopupHeader_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader.CancelCommandProperty, tokenDPC_CancelCommand);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader.TextProperty, tokenDPC_Text);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_CancelCommand = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader.CancelCommandProperty, DependencyPropertyChanged_CancelCommand);
                            tokenDPC_Text = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.LargePopupHeader.TextProperty, DependencyPropertyChanged_Text);
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
            case 1: // Controls\LargePopupHeader.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    LargePopupHeader_obj1_Bindings bindings = new LargePopupHeader_obj1_Bindings();
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
