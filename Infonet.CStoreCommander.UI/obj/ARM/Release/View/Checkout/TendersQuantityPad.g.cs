﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Checkout\TendersQuantityPad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F821FA7ACDEB4C4213010336A3A7C9F9"
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
    partial class TendersQuantityPad : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Infonet_CStoreCommander_UI_Controls_NumberPad_CashButtonItemSource(global::Infonet.CStoreCommander.UI.Controls.NumberPad obj, global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel>), targetNullValue);
                }
                obj.CashButtonItemSource = value;
            }
            public static void Set_Infonet_CStoreCommander_UI_Controls_NumberPad_BackNavigation(global::Infonet.CStoreCommander.UI.Controls.NumberPad obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.BackNavigation = value;
            }
            public static void Set_Infonet_CStoreCommander_UI_Controls_NumberPad_EnterTappedCommand(global::Infonet.CStoreCommander.UI.Controls.NumberPad obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.EnterTappedCommand = value;
            }
        };

        private class TendersQuantityPad_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITendersQuantityPad_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Checkout.TendersQuantityPad dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.UI.Controls.NumberPad obj2;

            private TendersQuantityPad_obj1_BindingsTracking bindingsTracking;

            public TendersQuantityPad_obj1_Bindings()
            {
                this.bindingsTracking = new TendersQuantityPad_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Infonet.CStoreCommander.UI.Controls.NumberPad)target;
                        break;
                    default:
                        break;
                }
            }

            // ITendersQuantityPad_Bindings

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

            // TendersQuantityPad_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Checkout.TendersQuantityPad newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Checkout.TendersQuantityPad obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SaleSummaryVM(obj.SaleSummaryVM, phase);
                    }
                }
            }
            private void Update_SaleSummaryVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.SaleSummaryVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SaleSummaryVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SaleSummaryVM_CashButtons(obj.CashButtons, phase);
                        this.Update_SaleSummaryVM_SecondFrameBackNavigationCommand(obj.SecondFrameBackNavigationCommand, phase);
                        this.Update_SaleSummaryVM_SetTenderAmountCommand(obj.SetTenderAmountCommand, phase);
                    }
                }
            }
            private void Update_SaleSummaryVM_CashButtons(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_NumberPad_CashButtonItemSource(this.obj2, obj, null);
                }
            }
            private void Update_SaleSummaryVM_SecondFrameBackNavigationCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_NumberPad_BackNavigation(this.obj2, obj, null);
                }
            }
            private void Update_SaleSummaryVM_SetTenderAmountCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_NumberPad_EnterTappedCommand(this.obj2, obj, null);
                }
            }

            private class TendersQuantityPad_obj1_BindingsTracking
            {
                global::System.WeakReference<TendersQuantityPad_obj1_Bindings> WeakRefToBindingObj; 

                public TendersQuantityPad_obj1_BindingsTracking(TendersQuantityPad_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<TendersQuantityPad_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_SaleSummaryVM(null);
                }

                public void PropertyChanged_SaleSummaryVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TendersQuantityPad_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Checkout.SaleSummaryVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Checkout.SaleSummaryVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_SaleSummaryVM_CashButtons(obj.CashButtons, DATA_CHANGED);
                                    bindings.Update_SaleSummaryVM_SecondFrameBackNavigationCommand(obj.SecondFrameBackNavigationCommand, DATA_CHANGED);
                                    bindings.Update_SaleSummaryVM_SetTenderAmountCommand(obj.SetTenderAmountCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CashButtons":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleSummaryVM_CashButtons(obj.CashButtons, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SecondFrameBackNavigationCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleSummaryVM_SecondFrameBackNavigationCommand(obj.SecondFrameBackNavigationCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SetTenderAmountCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleSummaryVM_SetTenderAmountCommand(obj.SetTenderAmountCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Checkout.SaleSummaryVM cache_SaleSummaryVM = null;
                public void UpdateChildListeners_SaleSummaryVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.SaleSummaryVM obj)
                {
                    if (obj != cache_SaleSummaryVM)
                    {
                        if (cache_SaleSummaryVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_SaleSummaryVM).PropertyChanged -= PropertyChanged_SaleSummaryVM;
                            cache_SaleSummaryVM = null;
                        }
                        if (obj != null)
                        {
                            cache_SaleSummaryVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_SaleSummaryVM;
                        }
                    }
                }
                public void PropertyChanged_SaleSummaryVM_CashButtons(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TendersQuantityPad_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel>;
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
                public void CollectionChanged_SaleSummaryVM_CashButtons(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    TendersQuantityPad_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel>;
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
                    TendersQuantityPad_obj1_Bindings bindings = new TendersQuantityPad_obj1_Bindings();
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

