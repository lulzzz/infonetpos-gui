﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Customer\LoyaltyCustomers.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B710A156F65AEEC2264408CD935938C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Customer
{
    partial class LoyaltyCustomers : 
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
            public static void Set_MyToolkit_Controls_DataGrid_SelectedItem(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(global::MyToolkit.Extended.Controls.CustomTextBox obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.EnterPressedCommand = value;
            }
        };

        private class LoyaltyCustomers_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ILoyaltyCustomers_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Customer.LoyaltyCustomers dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::MyToolkit.Controls.DataGrid obj5;
            private global::WinRT.Triggers.InvokeCommandAction obj6;
            private global::WinRT.Triggers.InvokeCommandAction obj7;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj8;

            private LoyaltyCustomers_obj1_BindingsTracking bindingsTracking;

            public LoyaltyCustomers_obj1_Bindings()
            {
                this.bindingsTracking = new LoyaltyCustomers_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::MyToolkit.Controls.DataGrid)target;
                        (this.obj5).RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedItemProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.LoyaltyCustomersScreenVM.SelectedCustomer = (global::Infonet.CStoreCommander.EntityLayer.Entities.Customer.Customer)this.LookupConverter("SelectedCustomerConverter").ConvertBack((this.obj5).SelectedItem, typeof(global::Infonet.CStoreCommander.EntityLayer.Entities.Customer.Customer), null, null);
                                }
                            });
                        break;
                    case 6:
                        this.obj6 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 7:
                        this.obj7 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 8:
                        this.obj8 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    default:
                        break;
                }
            }

            // ILoyaltyCustomers_Bindings

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

            // LoyaltyCustomers_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Customer.LoyaltyCustomers newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Customer.LoyaltyCustomers obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_LoyaltyCustomersScreenVM(obj.LoyaltyCustomersScreenVM, phase);
                    }
                }
            }
            private void Update_LoyaltyCustomersScreenVM(global::Infonet.CStoreCommander.UI.ViewModel.Customer.LoyaltyCustomersScreenVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_LoyaltyCustomersScreenVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_LoyaltyCustomersScreenVM_LoadAllCustomersCommand(obj.LoadAllCustomersCommand, phase);
                        this.Update_LoyaltyCustomersScreenVM_SelectCustomerForSaleCommand(obj.SelectCustomerForSaleCommand, phase);
                        this.Update_LoyaltyCustomersScreenVM_IsSelectCustomerEnabled(obj.IsSelectCustomerEnabled, phase);
                        this.Update_LoyaltyCustomersScreenVM_SelectedCustomer(obj.SelectedCustomer, phase);
                        this.Update_LoyaltyCustomersScreenVM_CustomerSelectedCommand(obj.CustomerSelectedCommand, phase);
                        this.Update_LoyaltyCustomersScreenVM_RefreshCommand(obj.RefreshCommand, phase);
                        this.Update_LoyaltyCustomersScreenVM_SearchCommand(obj.SearchCommand, phase);
                    }
                }
            }
            private void Update_LoyaltyCustomersScreenVM_LoadAllCustomersCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_LoyaltyCustomersScreenVM_SelectCustomerForSaleCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                }
            }
            private void Update_LoyaltyCustomersScreenVM_IsSelectCustomerEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_LoyaltyCustomersScreenVM_SelectedCustomer(global::Infonet.CStoreCommander.EntityLayer.Entities.Customer.Customer obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_SelectedItem(this.obj5, (global::System.Object)this.LookupConverter("SelectedCustomerConverter").Convert(obj, typeof(global::System.Object), null, null), null);
                }
            }
            private void Update_LoyaltyCustomersScreenVM_CustomerSelectedCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj6, obj, null);
                }
            }
            private void Update_LoyaltyCustomersScreenVM_RefreshCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj7, obj, null);
                }
            }
            private void Update_LoyaltyCustomersScreenVM_SearchCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj8, obj, null);
                }
            }

            private class LoyaltyCustomers_obj1_BindingsTracking
            {
                global::System.WeakReference<LoyaltyCustomers_obj1_Bindings> WeakRefToBindingObj; 

                public LoyaltyCustomers_obj1_BindingsTracking(LoyaltyCustomers_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<LoyaltyCustomers_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_LoyaltyCustomersScreenVM(null);
                }

                public void PropertyChanged_LoyaltyCustomersScreenVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    LoyaltyCustomers_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Customer.LoyaltyCustomersScreenVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Customer.LoyaltyCustomersScreenVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_LoyaltyCustomersScreenVM_LoadAllCustomersCommand(obj.LoadAllCustomersCommand, DATA_CHANGED);
                                    bindings.Update_LoyaltyCustomersScreenVM_SelectCustomerForSaleCommand(obj.SelectCustomerForSaleCommand, DATA_CHANGED);
                                    bindings.Update_LoyaltyCustomersScreenVM_IsSelectCustomerEnabled(obj.IsSelectCustomerEnabled, DATA_CHANGED);
                                    bindings.Update_LoyaltyCustomersScreenVM_SelectedCustomer(obj.SelectedCustomer, DATA_CHANGED);
                                    bindings.Update_LoyaltyCustomersScreenVM_CustomerSelectedCommand(obj.CustomerSelectedCommand, DATA_CHANGED);
                                    bindings.Update_LoyaltyCustomersScreenVM_RefreshCommand(obj.RefreshCommand, DATA_CHANGED);
                                    bindings.Update_LoyaltyCustomersScreenVM_SearchCommand(obj.SearchCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "LoadAllCustomersCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_LoyaltyCustomersScreenVM_LoadAllCustomersCommand(obj.LoadAllCustomersCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectCustomerForSaleCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_LoyaltyCustomersScreenVM_SelectCustomerForSaleCommand(obj.SelectCustomerForSaleCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsSelectCustomerEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_LoyaltyCustomersScreenVM_IsSelectCustomerEnabled(obj.IsSelectCustomerEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedCustomer":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_LoyaltyCustomersScreenVM_SelectedCustomer(obj.SelectedCustomer, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CustomerSelectedCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_LoyaltyCustomersScreenVM_CustomerSelectedCommand(obj.CustomerSelectedCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "RefreshCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_LoyaltyCustomersScreenVM_RefreshCommand(obj.RefreshCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SearchCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_LoyaltyCustomersScreenVM_SearchCommand(obj.SearchCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Customer.LoyaltyCustomersScreenVM cache_LoyaltyCustomersScreenVM = null;
                public void UpdateChildListeners_LoyaltyCustomersScreenVM(global::Infonet.CStoreCommander.UI.ViewModel.Customer.LoyaltyCustomersScreenVM obj)
                {
                    if (obj != cache_LoyaltyCustomersScreenVM)
                    {
                        if (cache_LoyaltyCustomersScreenVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_LoyaltyCustomersScreenVM).PropertyChanged -= PropertyChanged_LoyaltyCustomersScreenVM;
                            cache_LoyaltyCustomersScreenVM = null;
                        }
                        if (obj != null)
                        {
                            cache_LoyaltyCustomersScreenVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_LoyaltyCustomersScreenVM;
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
            case 3:
                {
                    this.GenericButtonStyle = (global::Windows.UI.Xaml.Style)(target);
                }
                break;
            case 8:
                {
                    this.txtSearch = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
                    LoyaltyCustomers_obj1_Bindings bindings = new LoyaltyCustomers_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
