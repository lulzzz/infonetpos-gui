﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Checkout\VendorCoupon.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F2AEF0CA672365BB21FB5177E460D2E4"
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
    partial class VendorCoupon : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
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
            public static void Set_MyToolkit_Controls_DataGrid_SelectedItem(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_MyToolkit_Controls_DataGrid_ItemsSource(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_WinRT_Triggers_InvokeCommandAction_Command(global::WinRT.Triggers.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        private class VendorCoupon_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IVendorCoupon_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Checkout.VendorCoupon dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;
            private global::MyToolkit.Controls.DataGrid obj6;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj7;
            private global::WinRT.Triggers.InvokeCommandAction obj9;

            private VendorCoupon_obj1_BindingsTracking bindingsTracking;

            public VendorCoupon_obj1_Bindings()
            {
                this.bindingsTracking = new VendorCoupon_obj1_BindingsTracking(this);
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
                        this.dataRoot.VendorCouponLoaded(param0, param1);
                        };
                        break;
                    case 3:
                        this.obj3 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::MyToolkit.Controls.DataGrid)target;
                        (this.obj6).RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedItemProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.VendorCouponVM.SelectedVendorCoupon = (global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel)this.LookupConverter("NothingConverter").ConvertBack((this.obj6).SelectedItem, typeof(global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel), null, null);
                                }
                            });
                        break;
                    case 7:
                        this.obj7 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        ((global::MyToolkit.Extended.Controls.CustomTextBox)target).KeyUp += (global::System.Object param0, global::Windows.UI.Xaml.Input.KeyRoutedEventArgs param1) =>
                        {
                        this.dataRoot.VendorCouponNumberKeyUp(param0, param1);
                        };
                        break;
                    case 9:
                        this.obj9 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IVendorCoupon_Bindings

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

            // VendorCoupon_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Checkout.VendorCoupon newDataRoot)
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
            private void Update_(global::Infonet.CStoreCommander.UI.View.Checkout.VendorCoupon obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_VendorCouponVM(obj.VendorCouponVM, phase);
                    }
                }
            }
            private void Update_VendorCouponVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.VendorCouponVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_VendorCouponVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_VendorCouponVM_IsDoneButtonEnable(obj.IsDoneButtonEnable, phase);
                        this.Update_VendorCouponVM_CompleteVendorCouponCommand(obj.CompleteVendorCouponCommand, phase);
                        this.Update_VendorCouponVM_IsAddButtonEnable(obj.IsAddButtonEnable, phase);
                        this.Update_VendorCouponVM_AddVendorCouponCommand(obj.AddVendorCouponCommand, phase);
                        this.Update_VendorCouponVM_IsDeleteButtonEnable(obj.IsDeleteButtonEnable, phase);
                        this.Update_VendorCouponVM_DeleteVendorCouponCommand(obj.DeleteVendorCouponCommand, phase);
                        this.Update_VendorCouponVM_SelectedVendorCoupon(obj.SelectedVendorCoupon, phase);
                        this.Update_VendorCouponVM_VendorCoupons(obj.VendorCoupons, phase);
                        this.Update_VendorCouponVM_IsCouponNumberEnabled(obj.IsCouponNumberEnabled, phase);
                        this.Update_VendorCouponVM_EnterPressedOnVendorSerialNumberCommand(obj.EnterPressedOnVendorSerialNumberCommand, phase);
                    }
                }
            }
            private void Update_VendorCouponVM_IsDoneButtonEnable(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj3, obj);
                }
            }
            private void Update_VendorCouponVM_CompleteVendorCouponCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                }
            }
            private void Update_VendorCouponVM_IsAddButtonEnable(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_VendorCouponVM_AddVendorCouponCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                }
            }
            private void Update_VendorCouponVM_IsDeleteButtonEnable(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj5, obj);
                }
            }
            private void Update_VendorCouponVM_DeleteVendorCouponCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_VendorCouponVM_SelectedVendorCoupon(global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_SelectedItem(this.obj6, (global::System.Object)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Object), null, null), null);
                }
            }
            private void Update_VendorCouponVM_VendorCoupons(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemsSource(this.obj6, obj, null);
                }
            }
            private void Update_VendorCouponVM_IsCouponNumberEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj7, obj);
                }
            }
            private void Update_VendorCouponVM_EnterPressedOnVendorSerialNumberCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj9, obj, null);
                }
            }

            private class VendorCoupon_obj1_BindingsTracking
            {
                global::System.WeakReference<VendorCoupon_obj1_Bindings> WeakRefToBindingObj; 

                public VendorCoupon_obj1_BindingsTracking(VendorCoupon_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<VendorCoupon_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_VendorCouponVM(null);
                }

                public void PropertyChanged_VendorCouponVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    VendorCoupon_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Checkout.VendorCouponVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Checkout.VendorCouponVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_VendorCouponVM_IsDoneButtonEnable(obj.IsDoneButtonEnable, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_CompleteVendorCouponCommand(obj.CompleteVendorCouponCommand, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_IsAddButtonEnable(obj.IsAddButtonEnable, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_AddVendorCouponCommand(obj.AddVendorCouponCommand, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_IsDeleteButtonEnable(obj.IsDeleteButtonEnable, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_DeleteVendorCouponCommand(obj.DeleteVendorCouponCommand, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_SelectedVendorCoupon(obj.SelectedVendorCoupon, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_VendorCoupons(obj.VendorCoupons, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_IsCouponNumberEnabled(obj.IsCouponNumberEnabled, DATA_CHANGED);
                                    bindings.Update_VendorCouponVM_EnterPressedOnVendorSerialNumberCommand(obj.EnterPressedOnVendorSerialNumberCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsDoneButtonEnable":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_IsDoneButtonEnable(obj.IsDoneButtonEnable, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CompleteVendorCouponCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_CompleteVendorCouponCommand(obj.CompleteVendorCouponCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsAddButtonEnable":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_IsAddButtonEnable(obj.IsAddButtonEnable, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AddVendorCouponCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_AddVendorCouponCommand(obj.AddVendorCouponCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsDeleteButtonEnable":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_IsDeleteButtonEnable(obj.IsDeleteButtonEnable, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "DeleteVendorCouponCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_DeleteVendorCouponCommand(obj.DeleteVendorCouponCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedVendorCoupon":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_SelectedVendorCoupon(obj.SelectedVendorCoupon, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "VendorCoupons":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_VendorCoupons(obj.VendorCoupons, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsCouponNumberEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_IsCouponNumberEnabled(obj.IsCouponNumberEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EnterPressedOnVendorSerialNumberCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VendorCouponVM_EnterPressedOnVendorSerialNumberCommand(obj.EnterPressedOnVendorSerialNumberCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Checkout.VendorCouponVM cache_VendorCouponVM = null;
                public void UpdateChildListeners_VendorCouponVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.VendorCouponVM obj)
                {
                    if (obj != cache_VendorCouponVM)
                    {
                        if (cache_VendorCouponVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_VendorCouponVM).PropertyChanged -= PropertyChanged_VendorCouponVM;
                            cache_VendorCouponVM = null;
                        }
                        if (obj != null)
                        {
                            cache_VendorCouponVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_VendorCouponVM;
                        }
                    }
                }
                public void PropertyChanged_VendorCouponVM_SelectedVendorCoupon(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    VendorCoupon_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel obj = sender as global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void PropertyChanged_VendorCouponVM_VendorCoupons(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    VendorCoupon_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_VendorCouponVM_VendorCoupons(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    VendorCoupon_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.VendorCouponModel>;
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
            case 6:
                {
                    this.DataGrid = (global::MyToolkit.Controls.DataGrid)(target);
                }
                break;
            case 7:
                {
                    this.txtVendorCouponNumber = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
                }
                break;
            case 8:
                {
                    this.txtVendorSerialNumber = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
                    VendorCoupon_obj1_Bindings bindings = new VendorCoupon_obj1_Bindings();
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

