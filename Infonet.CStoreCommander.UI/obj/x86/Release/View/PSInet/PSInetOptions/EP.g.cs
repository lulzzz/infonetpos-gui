﻿#pragma checksum "F:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\PSInet\PSInetOptions\EP.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4A451361BE06AFEB8F566D8D32CC9B75"
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
    partial class EP : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_MyToolkit_Controls_DataGrid_ItemsSource(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
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
        private class EP_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IEP_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.EP dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj3;
            private global::MyToolkit.Controls.DataGrid obj4;
            private global::MyToolkit.Controls.DataGrid obj5;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj6;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;

            private EP_obj1_BindingsTracking bindingsTracking;

            public EP_obj1_Bindings()
            {
                this.bindingsTracking = new EP_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\PSInet\PSInetOptions\EP.xaml line 224
                        this.obj2 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 3: // View\PSInet\PSInetOptions\EP.xaml line 238
                        this.obj3 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 4: // View\PSInet\PSInetOptions\EP.xaml line 134
                        this.obj4 = (global::MyToolkit.Controls.DataGrid)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // View\PSInet\PSInetOptions\EP.xaml line 99
                        this.obj5 = (global::MyToolkit.Controls.DataGrid)target;
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    case 6: // View\PSInet\PSInetOptions\EP.xaml line 76
                        this.obj6 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 7: // View\PSInet\PSInetOptions\EP.xaml line 88
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 8: // View\PSInet\PSInetOptions\EP.xaml line 64
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IEP_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.EP)newDataRoot;
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
            private void Update_(global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.EP obj, int phase)
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
                        this.Update_PaymentSourceVM_PrintLastReceiptCommand(obj.PrintLastReceiptCommand, phase);
                        this.Update_PaymentSourceVM_AddToSaleCommand(obj.AddToSaleCommand, phase);
                        this.Update_PaymentSourceVM_Products(obj.Products, phase);
                        this.Update_PaymentSourceVM_SelectedProduct(obj.SelectedProduct, phase);
                        this.Update_PaymentSourceVM_Categories(obj.Categories, phase);
                        this.Update_PaymentSourceVM_SelectedCategory(obj.SelectedCategory, phase);
                        this.Update_PaymentSourceVM_SearchCommand(obj.SearchCommand, phase);
                        this.Update_PaymentSourceVM_SearchCommand1(obj.SearchCommand1, phase);
                        this.Update_PaymentSourceVM_Balance(obj.Balance, phase);
                    }
                }
            }
            private void Update_PaymentSourceVM_PrintLastReceiptCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 224
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                }
            }
            private void Update_PaymentSourceVM_AddToSaleCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 238
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                }
            }
            private void Update_PaymentSourceVM_Products(global::System.Collections.Generic.List<global::Infonet.CStoreCommander.EntityLayer.Entities.PaymentSource.PSProduct> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 134
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemsSource(this.obj4, obj, null);
                }
            }
            private void Update_PaymentSourceVM_SelectedProduct(global::Infonet.CStoreCommander.EntityLayer.Entities.PaymentSource.PSProduct obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 134
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_SelectedItem(this.obj4, (global::System.Object)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Object), null, null), null);
                }
            }
            private void Update_PaymentSourceVM_Categories(global::System.Collections.Generic.List<global::System.String> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 99
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemsSource(this.obj5, obj, null);
                }
            }
            private void Update_PaymentSourceVM_SelectedCategory(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 99
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_SelectedItem(this.obj5, (global::System.Object)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Object), null, null), null);
                }
            }
            private void Update_PaymentSourceVM_SearchCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 76
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj6, obj, null);
                }
            }
            private void Update_PaymentSourceVM_SearchCommand1(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 88
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj7, obj, null);
                }
            }
            private void Update_PaymentSourceVM_Balance(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PSInet\PSInetOptions\EP.xaml line 64
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                }
            }
            private void UpdateTwoWay_4_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.PaymentSourceVM != null)
                        {
                            this.dataRoot.PaymentSourceVM.SelectedProduct = (global::Infonet.CStoreCommander.EntityLayer.Entities.PaymentSource.PSProduct)this.LookupConverter("NothingConverter").ConvertBack(this.obj4.SelectedItem, typeof(global::Infonet.CStoreCommander.EntityLayer.Entities.PaymentSource.PSProduct), null, null);
                        }
                    }
                }
            }
            private void UpdateTwoWay_5_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.PaymentSourceVM != null)
                        {
                            this.dataRoot.PaymentSourceVM.SelectedCategory = (global::System.String)this.LookupConverter("NothingConverter").ConvertBack(this.obj5.SelectedItem, typeof(global::System.String), null, null);
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class EP_obj1_BindingsTracking
            {
                private global::System.WeakReference<EP_obj1_Bindings> weakRefToBindingObj; 

                public EP_obj1_BindingsTracking(EP_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<EP_obj1_Bindings>(obj);
                }

                public EP_obj1_Bindings TryGetBindingObject()
                {
                    EP_obj1_Bindings bindingObject = null;
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
                    EP_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_PaymentSourceVM_PrintLastReceiptCommand(obj.PrintLastReceiptCommand, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_AddToSaleCommand(obj.AddToSaleCommand, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_Products(obj.Products, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_SelectedProduct(obj.SelectedProduct, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_Categories(obj.Categories, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_SelectedCategory(obj.SelectedCategory, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_SearchCommand(obj.SearchCommand, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_SearchCommand1(obj.SearchCommand1, DATA_CHANGED);
                                bindings.Update_PaymentSourceVM_Balance(obj.Balance, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "PrintLastReceiptCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_PrintLastReceiptCommand(obj.PrintLastReceiptCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AddToSaleCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_AddToSaleCommand(obj.AddToSaleCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Products":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_Products(obj.Products, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedProduct":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_SelectedProduct(obj.SelectedProduct, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Categories":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_Categories(obj.Categories, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedCategory":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_SelectedCategory(obj.SelectedCategory, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SearchCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_SearchCommand(obj.SearchCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SearchCommand1":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_SearchCommand1(obj.SearchCommand1, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Balance":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_Balance(obj.Balance, DATA_CHANGED);
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
                public void RegisterTwoWayListener_4(global::MyToolkit.Controls.DataGrid sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_SelectedItem();
                        }
                    });
                }
                public void RegisterTwoWayListener_5(global::MyToolkit.Controls.DataGrid sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_SelectedItem();
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
            case 1: // View\PSInet\PSInetOptions\EP.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    EP_obj1_Bindings bindings = new EP_obj1_Bindings();
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

