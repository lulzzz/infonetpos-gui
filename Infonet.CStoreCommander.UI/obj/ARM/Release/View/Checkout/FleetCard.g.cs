﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Checkout\FleetCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "159940F832ED5DA7F145C438B97B2651"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Checkout
{
    partial class FleetCard : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Infonet_CStoreCommander_UI_Controls_SecondFrameHeading_PreviousFrame(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.PreviousFrame = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(global::MyToolkit.Extended.Controls.CustomTextBox obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.EnterPressedCommand = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
        };

        private class FleetCard_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IFleetCard_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Checkout.FleetCard dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;
            private global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj5;
            private global::Windows.UI.Xaml.Controls.ComboBox obj6;
            private global::Windows.UI.Xaml.Controls.ComboBox obj7;
            private global::Windows.UI.Xaml.Controls.ComboBox obj8;

            private FleetCard_obj1_BindingsTracking bindingsTracking;

            public FleetCard_obj1_Bindings()
            {
                this.bindingsTracking = new FleetCard_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        ((global::Windows.UI.Xaml.Controls.Grid)target).Loaded += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.GridLoaded(param0, param1);
                        };
                        break;
                    case 3:
                        this.obj3 = (global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        (this.obj6).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.FleetTenderVM.SelectedLanguageIndex = (this.obj6).SelectedIndex;
                                }
                            });
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IFleetCard_Bindings

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

            // FleetCard_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Checkout.FleetCard newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Checkout.FleetCard obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FleetTenderVM(obj.FleetTenderVM, phase);
                    }
                }
            }
            private void Update_FleetTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_FleetTenderVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FleetTenderVM_BackCommand(obj.BackCommand, phase);
                        this.Update_FleetTenderVM_IsAcceptButtonEnabled(obj.IsAcceptButtonEnabled, phase);
                        this.Update_FleetTenderVM_CompleteFleetPaymentCommand(obj.CompleteFleetPaymentCommand, phase);
                        this.Update_FleetTenderVM_CardNumberEnteredCommand(obj.CardNumberEnteredCommand, phase);
                        this.Update_FleetTenderVM_Languages(obj.Languages, phase);
                        this.Update_FleetTenderVM_SelectedLanguageIndex(obj.SelectedLanguageIndex, phase);
                        this.Update_FleetTenderVM_Month(obj.Month, phase);
                        this.Update_FleetTenderVM_Year(obj.Year, phase);
                    }
                }
            }
            private void Update_FleetTenderVM_BackCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SecondFrameHeading_PreviousFrame(this.obj3, obj, null);
                }
            }
            private void Update_FleetTenderVM_IsAcceptButtonEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_FleetTenderVM_CompleteFleetPaymentCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                }
            }
            private void Update_FleetTenderVM_CardNumberEnteredCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj5, obj, null);
                }
            }
            private void Update_FleetTenderVM_Languages(global::System.Collections.Generic.List<global::System.String> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                }
            }
            private void Update_FleetTenderVM_SelectedLanguageIndex(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj6, obj);
                }
            }
            private void Update_FleetTenderVM_Month(global::System.Collections.Generic.List<global::System.Int32> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
            private void Update_FleetTenderVM_Year(global::System.Collections.Generic.List<global::System.Int32> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                }
            }

            private class FleetCard_obj1_BindingsTracking
            {
                global::System.WeakReference<FleetCard_obj1_Bindings> WeakRefToBindingObj; 

                public FleetCard_obj1_BindingsTracking(FleetCard_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<FleetCard_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_FleetTenderVM(null);
                }

                public void PropertyChanged_FleetTenderVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    FleetCard_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_FleetTenderVM_BackCommand(obj.BackCommand, DATA_CHANGED);
                                    bindings.Update_FleetTenderVM_IsAcceptButtonEnabled(obj.IsAcceptButtonEnabled, DATA_CHANGED);
                                    bindings.Update_FleetTenderVM_CompleteFleetPaymentCommand(obj.CompleteFleetPaymentCommand, DATA_CHANGED);
                                    bindings.Update_FleetTenderVM_CardNumberEnteredCommand(obj.CardNumberEnteredCommand, DATA_CHANGED);
                                    bindings.Update_FleetTenderVM_Languages(obj.Languages, DATA_CHANGED);
                                    bindings.Update_FleetTenderVM_SelectedLanguageIndex(obj.SelectedLanguageIndex, DATA_CHANGED);
                                    bindings.Update_FleetTenderVM_Month(obj.Month, DATA_CHANGED);
                                    bindings.Update_FleetTenderVM_Year(obj.Year, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "BackCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_BackCommand(obj.BackCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsAcceptButtonEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_IsAcceptButtonEnabled(obj.IsAcceptButtonEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CompleteFleetPaymentCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_CompleteFleetPaymentCommand(obj.CompleteFleetPaymentCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CardNumberEnteredCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_CardNumberEnteredCommand(obj.CardNumberEnteredCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Languages":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_Languages(obj.Languages, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedLanguageIndex":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_SelectedLanguageIndex(obj.SelectedLanguageIndex, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Month":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_Month(obj.Month, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Year":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_Year(obj.Year, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM cache_FleetTenderVM = null;
                public void UpdateChildListeners_FleetTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM obj)
                {
                    if (obj != cache_FleetTenderVM)
                    {
                        if (cache_FleetTenderVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_FleetTenderVM).PropertyChanged -= PropertyChanged_FleetTenderVM;
                            cache_FleetTenderVM = null;
                        }
                        if (obj != null)
                        {
                            cache_FleetTenderVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_FleetTenderVM;
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
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.txtCard = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
                    FleetCard_obj1_Bindings bindings = new FleetCard_obj1_Bindings();
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

