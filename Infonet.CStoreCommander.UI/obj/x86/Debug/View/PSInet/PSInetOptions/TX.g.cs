﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\View\PSInet\PSInetOptions\TX.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "67D4E9D98D271A61C632374D08653AB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions
{
    partial class TX : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TX_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITX_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.TX dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3TextDisabled = false;
            private static bool isobj4CommandDisabled = false;
            private static bool isobj5TextDisabled = false;

            private TX_obj1_BindingsTracking bindingsTracking;

            public TX_obj1_Bindings()
            {
                this.bindingsTracking = new TX_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 65 && columnNumber == 34)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 81 && columnNumber == 43)
                {
                    isobj4CommandDisabled = true;
                }
                else if (lineNumber == 92 && columnNumber == 77)
                {
                    isobj5TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // View\PSInet\PSInetOptions\TX.xaml line 65
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4: // View\PSInet\PSInetOptions\TX.xaml line 78
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5: // View\PSInet\PSInetOptions\TX.xaml line 92
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ITX_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.TX)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.TX obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PaymentSourceVM(obj.PaymentSourceVM, phase);
                    }
                }
            }
            private void Update_PaymentSourceVM(global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PaymentSourceVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PaymentSourceVM_AmountLabel(obj.AmountLabel, phase);
                        this.Update_PaymentSourceVM_CardActivationCommand(obj.CardActivationCommand, phase);
                        this.Update_PaymentSourceVM_ProdInfo(obj.ProdInfo, phase);
                    }
                }
            }
            private void Update_PaymentSourceVM_AmountLabel(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\TX.xaml line 65
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                    }
                }
            }
            private void Update_PaymentSourceVM_CardActivationCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\TX.xaml line 78
                    if (!isobj4CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                    }
                }
            }
            private void Update_PaymentSourceVM_ProdInfo(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\TX.xaml line 92
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class TX_obj1_BindingsTracking
            {
                private global::System.WeakReference<TX_obj1_Bindings> weakRefToBindingObj; 

                public TX_obj1_BindingsTracking(TX_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<TX_obj1_Bindings>(obj);
                }

                public TX_obj1_Bindings TryGetBindingObject()
                {
                    TX_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_PaymentSourceVM(null);
                }

                public void PropertyChanged_PaymentSourceVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TX_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_PaymentSourceVM_AmountLabel(obj.AmountLabel, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_CardActivationCommand(obj.CardActivationCommand, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_ProdInfo(obj.ProdInfo, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "AmountLabel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_AmountLabel(obj.AmountLabel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CardActivationCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_CardActivationCommand(obj.CardActivationCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ProdInfo":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_ProdInfo(obj.ProdInfo, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM cache_PaymentSourceVM = null;
                public void UpdateChildListeners_PaymentSourceVM(global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM obj)
                {
                    if (obj != cache_PaymentSourceVM)
                    {
                        if (cache_PaymentSourceVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_PaymentSourceVM).PropertyChanged -= PropertyChanged_PaymentSourceVM;
                            cache_PaymentSourceVM = null;
                        }
                        if (obj != null)
                        {
                            cache_PaymentSourceVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_PaymentSourceVM;
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
            case 2: // View\PSInet\PSInetOptions\TX.xaml line 40
                {
                    this.txtPhone = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
            case 1: // View\PSInet\PSInetOptions\TX.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TX_obj1_Bindings bindings = new TX_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

