﻿#pragma checksum "F:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Sale\ReturnSale.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "53695E4425425E78D005EC956E9336BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Sale
{
    partial class ReturnSale : 
        global::Windows.UI.Xaml.Controls.Page, 
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
            public static void Set_MyToolkit_Controls_DataGrid_SelectedItem(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
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
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ReturnSale_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IReturnSale_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Sale.ReturnSale dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::MyToolkit.Controls.DataGrid obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj6;
            private global::WinRT.Triggers.InvokeCommandAction obj7;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj8;
            private global::WinRT.Triggers.InvokeCommandAction obj9;

            private ReturnSale_obj1_BindingsTracking bindingsTracking;

            public ReturnSale_obj1_Bindings()
            {
                this.bindingsTracking = new ReturnSale_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\Sale\ReturnSale.xaml line 19
                        this.obj2 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 3: // View\Sale\ReturnSale.xaml line 97
                        this.obj3 = (global::MyToolkit.Controls.DataGrid)target;
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    case 4: // View\Sale\ReturnSale.xaml line 188
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5: // View\Sale\ReturnSale.xaml line 194
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6: // View\Sale\ReturnSale.xaml line 200
                        this.obj6 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 7: // View\Sale\ReturnSale.xaml line 108
                        this.obj7 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 8: // View\Sale\ReturnSale.xaml line 71
                        this.obj8 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 9: // View\Sale\ReturnSale.xaml line 87
                        this.obj9 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IReturnSale_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.Sale.ReturnSale)newDataRoot;
                    return true;
                }
                return false;
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
            private void Update_(global::Infonet.CStoreCommander.UI.View.Sale.ReturnSale obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ReturnSaleVM(obj.ReturnSaleVM, phase);
                    }
                }
            }
            private void Update_ReturnSaleVM(global::Infonet.CStoreCommander.UI.ViewModel.Sale.ReturnSaleVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ReturnSaleVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ReturnSaleVM_GetAllSaleListCommand(obj.GetAllSaleListCommand, phase);
                        this.Update_ReturnSaleVM_SelectedSaleModel(obj.SelectedSaleModel, phase);
                        this.Update_ReturnSaleVM_IsReturnSaleEnabled(obj.IsReturnSaleEnabled, phase);
                        this.Update_ReturnSaleVM_ReturnSaleCommand(obj.ReturnSaleCommand, phase);
                        this.Update_ReturnSaleVM_ReturnSaleItemCommand(obj.ReturnSaleItemCommand, phase);
                        this.Update_ReturnSaleVM_AllowCorrection(obj.AllowCorrection, phase);
                        this.Update_ReturnSaleVM_RefreshCommand(obj.RefreshCommand, phase);
                        this.Update_ReturnSaleVM_SearchBySaleNumberCommand(obj.SearchBySaleNumberCommand, phase);
                        this.Update_ReturnSaleVM_SaleDateSelectedCommand(obj.SaleDateSelectedCommand, phase);
                    }
                }
            }
            private void Update_ReturnSaleVM_GetAllSaleListCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 19
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_ReturnSaleVM_SelectedSaleModel(global::Infonet.CStoreCommander.EntityLayer.Entities.Sale.SaleList obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 97
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_SelectedItem(this.obj3, (global::System.Object)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Object), null, null), null);
                }
            }
            private void Update_ReturnSaleVM_IsReturnSaleEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 188
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                    // View\Sale\ReturnSale.xaml line 194
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj5, obj);
                }
            }
            private void Update_ReturnSaleVM_ReturnSaleCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 188
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                    // View\Sale\ReturnSale.xaml line 200
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void Update_ReturnSaleVM_ReturnSaleItemCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 194
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_ReturnSaleVM_AllowCorrection(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 200
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj6, obj);
                }
            }
            private void Update_ReturnSaleVM_RefreshCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 108
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj7, obj, null);
                }
            }
            private void Update_ReturnSaleVM_SearchBySaleNumberCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 71
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj8, obj, null);
                }
            }
            private void Update_ReturnSaleVM_SaleDateSelectedCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Sale\ReturnSale.xaml line 87
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj9, obj, null);
                }
            }
            private void UpdateTwoWay_3_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ReturnSaleVM != null)
                        {
                            this.dataRoot.ReturnSaleVM.SelectedSaleModel = (global::Infonet.CStoreCommander.EntityLayer.Entities.Sale.SaleList)this.LookupConverter("NothingConverter").ConvertBack(this.obj3.SelectedItem, typeof(global::Infonet.CStoreCommander.EntityLayer.Entities.Sale.SaleList), null, null);
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ReturnSale_obj1_BindingsTracking
            {
                private global::System.WeakReference<ReturnSale_obj1_Bindings> weakRefToBindingObj; 

                public ReturnSale_obj1_BindingsTracking(ReturnSale_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ReturnSale_obj1_Bindings>(obj);
                }

                public ReturnSale_obj1_Bindings TryGetBindingObject()
                {
                    ReturnSale_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ReturnSaleVM(null);
                }

                public void PropertyChanged_ReturnSaleVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ReturnSale_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Sale.ReturnSaleVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Sale.ReturnSaleVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ReturnSaleVM_GetAllSaleListCommand(obj.GetAllSaleListCommand, DATA_CHANGED);
                                bindings.Update_ReturnSaleVM_SelectedSaleModel(obj.SelectedSaleModel, DATA_CHANGED);
                                bindings.Update_ReturnSaleVM_IsReturnSaleEnabled(obj.IsReturnSaleEnabled, DATA_CHANGED);
                                bindings.Update_ReturnSaleVM_ReturnSaleCommand(obj.ReturnSaleCommand, DATA_CHANGED);
                                bindings.Update_ReturnSaleVM_ReturnSaleItemCommand(obj.ReturnSaleItemCommand, DATA_CHANGED);
                                bindings.Update_ReturnSaleVM_AllowCorrection(obj.AllowCorrection, DATA_CHANGED);
                                bindings.Update_ReturnSaleVM_RefreshCommand(obj.RefreshCommand, DATA_CHANGED);
                                bindings.Update_ReturnSaleVM_SearchBySaleNumberCommand(obj.SearchBySaleNumberCommand, DATA_CHANGED);
                                bindings.Update_ReturnSaleVM_SaleDateSelectedCommand(obj.SaleDateSelectedCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "GetAllSaleListCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_GetAllSaleListCommand(obj.GetAllSaleListCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedSaleModel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_SelectedSaleModel(obj.SelectedSaleModel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsReturnSaleEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_IsReturnSaleEnabled(obj.IsReturnSaleEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ReturnSaleCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_ReturnSaleCommand(obj.ReturnSaleCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ReturnSaleItemCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_ReturnSaleItemCommand(obj.ReturnSaleItemCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AllowCorrection":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_AllowCorrection(obj.AllowCorrection, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "RefreshCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_RefreshCommand(obj.RefreshCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SearchBySaleNumberCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_SearchBySaleNumberCommand(obj.SearchBySaleNumberCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SaleDateSelectedCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReturnSaleVM_SaleDateSelectedCommand(obj.SaleDateSelectedCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Sale.ReturnSaleVM cache_ReturnSaleVM = null;
                public void UpdateChildListeners_ReturnSaleVM(global::Infonet.CStoreCommander.UI.ViewModel.Sale.ReturnSaleVM obj)
                {
                    if (obj != cache_ReturnSaleVM)
                    {
                        if (cache_ReturnSaleVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ReturnSaleVM).PropertyChanged -= PropertyChanged_ReturnSaleVM;
                            cache_ReturnSaleVM = null;
                        }
                        if (obj != null)
                        {
                            cache_ReturnSaleVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ReturnSaleVM;
                        }
                    }
                }
                public void RegisterTwoWayListener_3(global::MyToolkit.Controls.DataGrid sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_SelectedItem();
                        }
                    });
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
            case 8: // View\Sale\ReturnSale.xaml line 71
                {
                    this.txtbSearchSale = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
            case 1: // View\Sale\ReturnSale.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ReturnSale_obj1_Bindings bindings = new ReturnSale_obj1_Bindings();
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
