﻿#pragma checksum "F:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\Controls\SecondFrameHeading.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "317E8B4F3A610D5B334ADCEA218F8478"
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
    partial class SecondFrameHeading : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
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
        private class SecondFrameHeading_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISecondFrameHeading_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;

            private SecondFrameHeading_obj1_BindingsTracking bindingsTracking;

            public SecondFrameHeading_obj1_Bindings()
            {
                this.bindingsTracking = new SecondFrameHeading_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\SecondFrameHeading.xaml line 54
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 3: // Controls\SecondFrameHeading.xaml line 64
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // ISecondFrameHeading_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BackArrowVisibility(obj.BackArrowVisibility, phase);
                        this.Update_PreviousFrame(obj.PreviousFrame, phase);
                        this.Update_Text(obj.Text, phase);
                    }
                }
            }
            private void Update_BackArrowVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\SecondFrameHeading.xaml line 54
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj2, obj);
                }
            }
            private void Update_PreviousFrame(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\SecondFrameHeading.xaml line 54
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                }
            }
            private void Update_Text(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\SecondFrameHeading.xaml line 64
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SecondFrameHeading_obj1_BindingsTracking
            {
                private global::System.WeakReference<SecondFrameHeading_obj1_Bindings> weakRefToBindingObj; 

                public SecondFrameHeading_obj1_BindingsTracking(SecondFrameHeading_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SecondFrameHeading_obj1_Bindings>(obj);
                }

                public SecondFrameHeading_obj1_Bindings TryGetBindingObject()
                {
                    SecondFrameHeading_obj1_Bindings bindingObject = null;
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

                public void DependencyPropertyChanged_BackArrowVisibility(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    SecondFrameHeading_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj = sender as global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading;
                        if (obj != null)
                        {
                            bindings.Update_BackArrowVisibility(obj.BackArrowVisibility, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_PreviousFrame(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    SecondFrameHeading_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj = sender as global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading;
                        if (obj != null)
                        {
                            bindings.Update_PreviousFrame(obj.PreviousFrame, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Text(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    SecondFrameHeading_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj = sender as global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading;
                        if (obj != null)
                        {
                            bindings.Update_Text(obj.Text, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_BackArrowVisibility = 0;
                private long tokenDPC_PreviousFrame = 0;
                private long tokenDPC_Text = 0;
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj)
                {
                    SecondFrameHeading_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading.BackArrowVisibilityProperty, tokenDPC_BackArrowVisibility);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading.PreviousFrameProperty, tokenDPC_PreviousFrame);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading.TextProperty, tokenDPC_Text);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_BackArrowVisibility = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading.BackArrowVisibilityProperty, DependencyPropertyChanged_BackArrowVisibility);
                            tokenDPC_PreviousFrame = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading.PreviousFrameProperty, DependencyPropertyChanged_PreviousFrame);
                            tokenDPC_Text = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading.TextProperty, DependencyPropertyChanged_Text);
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
            case 1: // Controls\SecondFrameHeading.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    SecondFrameHeading_obj1_Bindings bindings = new SecondFrameHeading_obj1_Bindings();
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

