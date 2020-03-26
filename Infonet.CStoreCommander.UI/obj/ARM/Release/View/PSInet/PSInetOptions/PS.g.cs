﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\PSInet\PSInetOptions\PS.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9BC3BFD788A19ECBC39F7788FFB77A7F"
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
    partial class PS : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(global::MyToolkit.Extended.Controls.CustomTextBox obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.EnterPressedCommand = value;
            }
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
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        private class PS_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPS_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.PS dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::MyToolkit.Extended.Controls.CustomTextBox obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj7;

            private PS_obj1_BindingsTracking bindingsTracking;

            public PS_obj1_Bindings()
            {
                this.bindingsTracking = new PS_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5:
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7:
                        this.obj7 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IPS_Bindings

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

            // PS_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.PS newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.PS obj, int phase)
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
                        this.Update_PaymentSourceVM_CardNumberCommand(obj.CardNumberCommand, phase);
                        this.Update_PaymentSourceVM_AmountLabel(obj.AmountLabel, phase);
                        this.Update_PaymentSourceVM_CardActivationCommand(obj.CardActivationCommand, phase);
                        this.Update_PaymentSourceVM_ProdInfo(obj.ProdInfo, phase);
                        this.Update_PaymentSourceVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, phase);
                    }
                }
            }
            private void Update_PaymentSourceVM_CardNumberCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj2, obj, null);
                }
            }
            private void Update_PaymentSourceVM_AmountLabel(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_PaymentSourceVM_CardActivationCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_PaymentSourceVM_ProdInfo(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                }
            }
            private void Update_PaymentSourceVM_InvokeKeyboardCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj7, obj, null);
                }
            }

            private class PS_obj1_BindingsTracking
            {
                global::System.WeakReference<PS_obj1_Bindings> WeakRefToBindingObj; 

                public PS_obj1_BindingsTracking(PS_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<PS_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_PaymentSourceVM(null);
                }

                public void PropertyChanged_PaymentSourceVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    PS_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_PaymentSourceVM_CardNumberCommand(obj.CardNumberCommand, DATA_CHANGED);
                                    bindings.Update_PaymentSourceVM_AmountLabel(obj.AmountLabel, DATA_CHANGED);
                                    bindings.Update_PaymentSourceVM_CardActivationCommand(obj.CardActivationCommand, DATA_CHANGED);
                                    bindings.Update_PaymentSourceVM_ProdInfo(obj.ProdInfo, DATA_CHANGED);
                                    bindings.Update_PaymentSourceVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CardNumberCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_CardNumberCommand(obj.CardNumberCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
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
                                case "InvokeKeyboardCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, DATA_CHANGED);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.CardNumberBox = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
                }
                break;
            case 4:
                {
                    this.AmtBox = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    PS_obj1_Bindings bindings = new PS_obj1_Bindings();
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

