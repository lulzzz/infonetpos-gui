﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\PumpOptions\Fuel Pricing\AddManual.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7624136612F88F36AE891206BAD0CAF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.PumpOptions.Fuel_Pricing
{
    partial class AddManual : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_WinRT_Triggers_InvokeCommandAction_Command(global::WinRT.Triggers.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Infonet_CStoreCommander_UI_Controls_ViewHeading_BackCommand(global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.BackCommand = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ComboBox_Header(global::Windows.UI.Xaml.Controls.ComboBox obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Header = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
        };

        private class AddManual_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAddManual_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.PumpOptions.Fuel_Pricing.AddManual dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.ComboBox obj6;
            private global::Windows.UI.Xaml.Controls.ComboBox obj7;

            private AddManual_obj1_BindingsTracking bindingsTracking;

            public AddManual_obj1_Bindings()
            {
                this.bindingsTracking = new AddManual_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 3:
                        this.obj3 = (global::Infonet.CStoreCommander.UI.Controls.ViewHeading)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        (this.obj6).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedItemProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.AddManualVM.SelectedPaymentMode = (this.obj6).SelectedItem != null ? (this.obj6).SelectedItem.ToString() : null;
                                }
                            });
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        (this.obj7).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedItemProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.AddManualVM.SelectedGrade = (this.obj7).SelectedItem != null ? (this.obj7).SelectedItem.ToString() : null;
                                }
                            });
                        break;
                    default:
                        break;
                }
            }

            // IAddManual_Bindings

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

            // AddManual_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.PumpOptions.Fuel_Pricing.AddManual newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.PumpOptions.Fuel_Pricing.AddManual obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AddManualVM(obj.AddManualVM, phase);
                    }
                }
            }
            private void Update_AddManualVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.AddManualVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_AddManualVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AddManualVM_CheckUserCanPerformManualSalesCommand(obj.CheckUserCanPerformManualSalesCommand, phase);
                        this.Update_AddManualVM_BackCommand(obj.BackCommand, phase);
                        this.Update_AddManualVM_AddFuelCommand(obj.AddFuelCommand, phase);
                        this.Update_AddManualVM_IsAddFuelEnabled(obj.IsAddFuelEnabled, phase);
                        this.Update_AddManualVM_Title(obj.Title, phase);
                        this.Update_AddManualVM_IsPaymentModeEnabled(obj.IsPaymentModeEnabled, phase);
                        this.Update_AddManualVM_PaymentModes(obj.PaymentModes, phase);
                        this.Update_AddManualVM_PaymentModeHeading(obj.PaymentModeHeading, phase);
                        this.Update_AddManualVM_SelectedPaymentMode(obj.SelectedPaymentMode, phase);
                        this.Update_AddManualVM_IsGradeEnabled(obj.IsGradeEnabled, phase);
                        this.Update_AddManualVM_Grades(obj.Grades, phase);
                        this.Update_AddManualVM_SelectedGrade(obj.SelectedGrade, phase);
                    }
                }
            }
            private void Update_AddManualVM_CheckUserCanPerformManualSalesCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_AddManualVM_BackCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_ViewHeading_BackCommand(this.obj3, obj, null);
                }
            }
            private void Update_AddManualVM_AddFuelCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                }
            }
            private void Update_AddManualVM_IsAddFuelEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_AddManualVM_Title(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                }
            }
            private void Update_AddManualVM_IsPaymentModeEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj6, obj);
                }
            }
            private void Update_AddManualVM_PaymentModes(global::System.Collections.Generic.List<global::System.String> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                }
            }
            private void Update_AddManualVM_PaymentModeHeading(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ComboBox_Header(this.obj6, obj, null);
                }
            }
            private void Update_AddManualVM_SelectedPaymentMode(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj6, obj, null);
                }
            }
            private void Update_AddManualVM_IsGradeEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj7, obj);
                }
            }
            private void Update_AddManualVM_Grades(global::System.Collections.Generic.List<global::System.String> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
            private void Update_AddManualVM_SelectedGrade(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj7, obj, null);
                }
            }

            private class AddManual_obj1_BindingsTracking
            {
                global::System.WeakReference<AddManual_obj1_Bindings> WeakRefToBindingObj; 

                public AddManual_obj1_BindingsTracking(AddManual_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<AddManual_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_AddManualVM(null);
                }

                public void PropertyChanged_AddManualVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AddManual_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.AddManualVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.AddManualVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_AddManualVM_CheckUserCanPerformManualSalesCommand(obj.CheckUserCanPerformManualSalesCommand, DATA_CHANGED);
                                    bindings.Update_AddManualVM_BackCommand(obj.BackCommand, DATA_CHANGED);
                                    bindings.Update_AddManualVM_AddFuelCommand(obj.AddFuelCommand, DATA_CHANGED);
                                    bindings.Update_AddManualVM_IsAddFuelEnabled(obj.IsAddFuelEnabled, DATA_CHANGED);
                                    bindings.Update_AddManualVM_Title(obj.Title, DATA_CHANGED);
                                    bindings.Update_AddManualVM_IsPaymentModeEnabled(obj.IsPaymentModeEnabled, DATA_CHANGED);
                                    bindings.Update_AddManualVM_PaymentModes(obj.PaymentModes, DATA_CHANGED);
                                    bindings.Update_AddManualVM_PaymentModeHeading(obj.PaymentModeHeading, DATA_CHANGED);
                                    bindings.Update_AddManualVM_SelectedPaymentMode(obj.SelectedPaymentMode, DATA_CHANGED);
                                    bindings.Update_AddManualVM_IsGradeEnabled(obj.IsGradeEnabled, DATA_CHANGED);
                                    bindings.Update_AddManualVM_Grades(obj.Grades, DATA_CHANGED);
                                    bindings.Update_AddManualVM_SelectedGrade(obj.SelectedGrade, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CheckUserCanPerformManualSalesCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_CheckUserCanPerformManualSalesCommand(obj.CheckUserCanPerformManualSalesCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BackCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_BackCommand(obj.BackCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AddFuelCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_AddFuelCommand(obj.AddFuelCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsAddFuelEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_IsAddFuelEnabled(obj.IsAddFuelEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Title":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_Title(obj.Title, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsPaymentModeEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_IsPaymentModeEnabled(obj.IsPaymentModeEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "PaymentModes":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_PaymentModes(obj.PaymentModes, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "PaymentModeHeading":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_PaymentModeHeading(obj.PaymentModeHeading, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedPaymentMode":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_SelectedPaymentMode(obj.SelectedPaymentMode, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsGradeEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_IsGradeEnabled(obj.IsGradeEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Grades":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_Grades(obj.Grades, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedGrade":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AddManualVM_SelectedGrade(obj.SelectedGrade, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.AddManualVM cache_AddManualVM = null;
                public void UpdateChildListeners_AddManualVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.AddManualVM obj)
                {
                    if (obj != cache_AddManualVM)
                    {
                        if (cache_AddManualVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_AddManualVM).PropertyChanged -= PropertyChanged_AddManualVM;
                            cache_AddManualVM = null;
                        }
                        if (obj != null)
                        {
                            cache_AddManualVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_AddManualVM;
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
                    AddManual_obj1_Bindings bindings = new AddManual_obj1_Bindings();
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

