﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\PumpOptions\Fuel Pricing\Increments.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A0D161A34E4729BCE809AF0F120704A9"
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
    partial class Increments : 
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
            public static void Set_MyToolkit_Controls_DataGridTextColumn_KeyUpCommand(global::MyToolkit.Controls.DataGridTextColumn obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.KeyUpCommand = value;
            }
            public static void Set_MyToolkit_Controls_DataGridTextColumn_IsEdit(global::MyToolkit.Controls.DataGridTextColumn obj, global::System.Boolean value)
            {
                obj.IsEdit = value;
            }
        };

        private class Increments_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IIncrements_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.PumpOptions.Fuel_Pricing.Increments dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::MyToolkit.Controls.DataGrid obj3;
            private global::MyToolkit.Controls.DataGridTextColumn obj4;
            private global::MyToolkit.Controls.DataGridTextColumn obj5;

            private Increments_obj1_BindingsTracking bindingsTracking;

            public Increments_obj1_Bindings()
            {
                this.bindingsTracking = new Increments_obj1_BindingsTracking(this);
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
                        this.obj3 = (global::MyToolkit.Controls.DataGrid)target;
                        (this.obj3).RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedItemProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.PriceIncrementsVM.SelectedIncrement = (global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel)this.LookupConverter("NothingConverter").ConvertBack((this.obj3).SelectedItem, typeof(global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel), null, null);
                                }
                            });
                        break;
                    case 4:
                        this.obj4 = (global::MyToolkit.Controls.DataGridTextColumn)target;
                        break;
                    case 5:
                        this.obj5 = (global::MyToolkit.Controls.DataGridTextColumn)target;
                        break;
                    default:
                        break;
                }
            }

            // IIncrements_Bindings

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

            // Increments_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.PumpOptions.Fuel_Pricing.Increments newDataRoot)
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
            private void Update_(global::Infonet.CStoreCommander.UI.View.PumpOptions.Fuel_Pricing.Increments obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PriceIncrementsVM(obj.PriceIncrementsVM, phase);
                    }
                }
            }
            private void Update_PriceIncrementsVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.PriceIncrementsVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PriceIncrementsVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PriceIncrementsVM_LoadPricesCommand(obj.LoadPricesCommand, phase);
                        this.Update_PriceIncrementsVM_Increments(obj.Increments, phase);
                        this.Update_PriceIncrementsVM_SelectedIncrement(obj.SelectedIncrement, phase);
                        this.Update_PriceIncrementsVM_SetIncrementCommand(obj.SetIncrementCommand, phase);
                        this.Update_PriceIncrementsVM_IsCreditEnabled(obj.IsCreditEnabled, phase);
                    }
                }
            }
            private void Update_PriceIncrementsVM_LoadPricesCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_PriceIncrementsVM_Increments(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemsSource(this.obj3, obj, null);
                }
            }
            private void Update_PriceIncrementsVM_SelectedIncrement(global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_SelectedItem(this.obj3, (global::System.Object)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Object), null, null), null);
                }
            }
            private void Update_PriceIncrementsVM_SetIncrementCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGridTextColumn_KeyUpCommand(this.obj4, obj, null);
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGridTextColumn_KeyUpCommand(this.obj5, obj, null);
                }
            }
            private void Update_PriceIncrementsVM_IsCreditEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGridTextColumn_IsEdit(this.obj5, obj);
                }
            }

            private class Increments_obj1_BindingsTracking
            {
                global::System.WeakReference<Increments_obj1_Bindings> WeakRefToBindingObj; 

                public Increments_obj1_BindingsTracking(Increments_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<Increments_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_PriceIncrementsVM(null);
                }

                public void PropertyChanged_PriceIncrementsVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Increments_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.PriceIncrementsVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.PriceIncrementsVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_PriceIncrementsVM_LoadPricesCommand(obj.LoadPricesCommand, DATA_CHANGED);
                                    bindings.Update_PriceIncrementsVM_Increments(obj.Increments, DATA_CHANGED);
                                    bindings.Update_PriceIncrementsVM_SelectedIncrement(obj.SelectedIncrement, DATA_CHANGED);
                                    bindings.Update_PriceIncrementsVM_SetIncrementCommand(obj.SetIncrementCommand, DATA_CHANGED);
                                    bindings.Update_PriceIncrementsVM_IsCreditEnabled(obj.IsCreditEnabled, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "LoadPricesCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PriceIncrementsVM_LoadPricesCommand(obj.LoadPricesCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Increments":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PriceIncrementsVM_Increments(obj.Increments, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedIncrement":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PriceIncrementsVM_SelectedIncrement(obj.SelectedIncrement, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SetIncrementCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PriceIncrementsVM_SetIncrementCommand(obj.SetIncrementCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsCreditEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PriceIncrementsVM_IsCreditEnabled(obj.IsCreditEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.PriceIncrementsVM cache_PriceIncrementsVM = null;
                public void UpdateChildListeners_PriceIncrementsVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FuelPricing.PriceIncrementsVM obj)
                {
                    if (obj != cache_PriceIncrementsVM)
                    {
                        if (cache_PriceIncrementsVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_PriceIncrementsVM).PropertyChanged -= PropertyChanged_PriceIncrementsVM;
                            cache_PriceIncrementsVM = null;
                        }
                        if (obj != null)
                        {
                            cache_PriceIncrementsVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_PriceIncrementsVM;
                        }
                    }
                }
                public void PropertyChanged_PriceIncrementsVM_Increments(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Increments_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel>;
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
                public void CollectionChanged_PriceIncrementsVM_Increments(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    Increments_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel>;
                    }
                }
                public void PropertyChanged_PriceIncrementsVM_SelectedIncrement(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Increments_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel obj = sender as global::Infonet.CStoreCommander.UI.Model.FuelPrice.IncrementModel;
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
                    Increments_obj1_Bindings bindings = new Increments_obj1_Bindings();
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

