﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Checkout\StoreCredit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "594DCE31D8EFCD5253A3C4B7F7758612"
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
    partial class StoreCredit : 
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
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.CommandParameter = value;
            }
            public static void Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(global::MyToolkit.Extended.Controls.CustomTextBox obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.EnterPressedCommand = value;
            }
            public static void Set_MyToolkit_Controls_DataGrid_ItemToAdd(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemToAdd = value;
            }
            public static void Set_MyToolkit_Controls_DataGrid_ItemsSource(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_MyToolkit_Controls_DataGrid_SelectedValues(global::MyToolkit.Controls.DataGrid obj, global::System.Collections.Generic.List<global::System.Object> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.Generic.List<global::System.Object>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.Generic.List<global::System.Object>), targetNullValue);
                }
                obj.SelectedValues = value;
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

        private class StoreCredit_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IStoreCredit_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Checkout.StoreCredit dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj3;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj4;
            private global::MyToolkit.Controls.DataGrid obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;

            private StoreCredit_obj1_BindingsTracking bindingsTracking;

            public StoreCredit_obj1_Bindings()
            {
                this.bindingsTracking = new StoreCredit_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading)target;
                        break;
                    case 3:
                        this.obj3 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 4:
                        this.obj4 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 5:
                        this.obj5 = (global::MyToolkit.Controls.DataGrid)target;
                        (this.obj5).RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedValuesProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.StoreCreditVM.SelectedStoreCredit = (global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel>)this.LookupConverter("StoreCreditListConverter").ConvertBack((this.obj5).SelectedValues, typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel>), null, null);
                                }
                            });
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IStoreCredit_Bindings

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

            // StoreCredit_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Checkout.StoreCredit newDataRoot)
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
            private void Update_(global::Infonet.CStoreCommander.UI.View.Checkout.StoreCredit obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_StoreCreditVM(obj.StoreCreditVM, phase);
                        this.Update_storeCreditGrid(obj.storeCreditGrid, phase);
                    }
                }
            }
            private void Update_StoreCreditVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.StoreCreditVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_StoreCreditVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_StoreCreditVM_GetSaleSummaryCommand(obj.GetSaleSummaryCommand, phase);
                        this.Update_StoreCreditVM_IsAcceptButtonEnable(obj.IsAcceptButtonEnable, phase);
                        this.Update_StoreCreditVM_SaveStoreCreditCommand(obj.SaveStoreCreditCommand, phase);
                        this.Update_StoreCreditVM_SearchStoreCreditCommand(obj.SearchStoreCreditCommand, phase);
                        this.Update_StoreCreditVM_StoreCreditToAdd(obj.StoreCreditToAdd, phase);
                        this.Update_StoreCreditVM_StoreCredits(obj.StoreCredits, phase);
                        this.Update_StoreCreditVM_SelectedStoreCredit(obj.SelectedStoreCredit, phase);
                        this.Update_StoreCreditVM_TotalAmount(obj.TotalAmount, phase);
                    }
                }
            }
            private void Update_StoreCreditVM_GetSaleSummaryCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SecondFrameHeading_PreviousFrame(this.obj2, obj, null);
                }
            }
            private void Update_StoreCreditVM_IsAcceptButtonEnable(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj3, obj);
                }
            }
            private void Update_StoreCreditVM_SaveStoreCreditCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                }
            }
            private void Update_storeCreditGrid(global::MyToolkit.Controls.DataGrid obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_storeCreditGrid(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_storeCreditGrid_SelectedRows(obj.SelectedRows, phase);
                    }
                }
            }
            private void Update_storeCreditGrid_SelectedRows(global::System.Collections.Generic.IList<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj3, obj, null);
                }
            }
            private void Update_StoreCreditVM_SearchStoreCreditCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj4, obj, null);
                }
            }
            private void Update_StoreCreditVM_StoreCreditToAdd(global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemToAdd(this.obj5, (global::System.Object)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Object), null, null), null);
                }
            }
            private void Update_StoreCreditVM_StoreCredits(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemsSource(this.obj5, obj, null);
                }
            }
            private void Update_StoreCreditVM_SelectedStoreCredit(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_SelectedValues(this.obj5, (global::System.Collections.Generic.List<global::System.Object>)this.LookupConverter("StoreCreditListConverter").Convert(obj, typeof(global::System.Collections.Generic.List<global::System.Object>), null, null), null);
                }
            }
            private void Update_StoreCreditVM_TotalAmount(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                }
            }

            private class StoreCredit_obj1_BindingsTracking
            {
                global::System.WeakReference<StoreCredit_obj1_Bindings> WeakRefToBindingObj; 

                public StoreCredit_obj1_BindingsTracking(StoreCredit_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<StoreCredit_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_StoreCreditVM(null);
                    UpdateChildListeners_storeCreditGrid(null);
                }

                public void PropertyChanged_StoreCreditVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    StoreCredit_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Checkout.StoreCreditVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Checkout.StoreCreditVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_StoreCreditVM_GetSaleSummaryCommand(obj.GetSaleSummaryCommand, DATA_CHANGED);
                                    bindings.Update_StoreCreditVM_IsAcceptButtonEnable(obj.IsAcceptButtonEnable, DATA_CHANGED);
                                    bindings.Update_StoreCreditVM_SaveStoreCreditCommand(obj.SaveStoreCreditCommand, DATA_CHANGED);
                                    bindings.Update_StoreCreditVM_SearchStoreCreditCommand(obj.SearchStoreCreditCommand, DATA_CHANGED);
                                    bindings.Update_StoreCreditVM_StoreCreditToAdd(obj.StoreCreditToAdd, DATA_CHANGED);
                                    bindings.Update_StoreCreditVM_StoreCredits(obj.StoreCredits, DATA_CHANGED);
                                    bindings.Update_StoreCreditVM_SelectedStoreCredit(obj.SelectedStoreCredit, DATA_CHANGED);
                                    bindings.Update_StoreCreditVM_TotalAmount(obj.TotalAmount, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "GetSaleSummaryCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StoreCreditVM_GetSaleSummaryCommand(obj.GetSaleSummaryCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsAcceptButtonEnable":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StoreCreditVM_IsAcceptButtonEnable(obj.IsAcceptButtonEnable, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SaveStoreCreditCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StoreCreditVM_SaveStoreCreditCommand(obj.SaveStoreCreditCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SearchStoreCreditCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StoreCreditVM_SearchStoreCreditCommand(obj.SearchStoreCreditCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "StoreCreditToAdd":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StoreCreditVM_StoreCreditToAdd(obj.StoreCreditToAdd, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "StoreCredits":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StoreCreditVM_StoreCredits(obj.StoreCredits, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedStoreCredit":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StoreCreditVM_SelectedStoreCredit(obj.SelectedStoreCredit, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "TotalAmount":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StoreCreditVM_TotalAmount(obj.TotalAmount, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Checkout.StoreCreditVM cache_StoreCreditVM = null;
                public void UpdateChildListeners_StoreCreditVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.StoreCreditVM obj)
                {
                    if (obj != cache_StoreCreditVM)
                    {
                        if (cache_StoreCreditVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_StoreCreditVM).PropertyChanged -= PropertyChanged_StoreCreditVM;
                            cache_StoreCreditVM = null;
                        }
                        if (obj != null)
                        {
                            cache_StoreCreditVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_StoreCreditVM;
                        }
                    }
                }
                public void DependencyPropertyChanged_storeCreditGrid_SelectedRows(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    StoreCredit_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::MyToolkit.Controls.DataGrid obj = sender as global::MyToolkit.Controls.DataGrid;
        if (obj != null)
        {
            bindings.Update_storeCreditGrid_SelectedRows(obj.SelectedRows, DATA_CHANGED);
        }
                    }
                }
                private global::MyToolkit.Controls.DataGrid cache_storeCreditGrid = null;
                private long tokenDPC_storeCreditGrid_SelectedRows = 0;
                public void UpdateChildListeners_storeCreditGrid(global::MyToolkit.Controls.DataGrid obj)
                {
                    if (obj != cache_storeCreditGrid)
                    {
                        if (cache_storeCreditGrid != null)
                        {
                            cache_storeCreditGrid.UnregisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedRowsProperty, tokenDPC_storeCreditGrid_SelectedRows);
                            cache_storeCreditGrid = null;
                        }
                        if (obj != null)
                        {
                            cache_storeCreditGrid = obj;
                            tokenDPC_storeCreditGrid_SelectedRows = obj.RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedRowsProperty, DependencyPropertyChanged_storeCreditGrid_SelectedRows);
                        }
                    }
                }
                public void PropertyChanged_StoreCreditVM_StoreCredits(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    StoreCredit_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel>;
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
                public void CollectionChanged_StoreCreditVM_StoreCredits(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    StoreCredit_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel>;
                    }
                }
                public void PropertyChanged_StoreCreditVM_SelectedStoreCredit(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    StoreCredit_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel>;
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
                public void CollectionChanged_StoreCreditVM_SelectedStoreCredit(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    StoreCredit_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Checkout.StoreCreditModel>;
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
            case 4:
                {
                    this.txtStoreCredit = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
                }
                break;
            case 5:
                {
                    this.storeCreditGrid = (global::MyToolkit.Controls.DataGrid)(target);
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
                    StoreCredit_obj1_Bindings bindings = new StoreCredit_obj1_Bindings();
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

