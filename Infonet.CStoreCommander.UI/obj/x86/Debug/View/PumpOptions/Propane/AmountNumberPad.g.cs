﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\View\PumpOptions\Propane\AmountNumberPad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1B16D51459C75761E3E3061DAE5DC397"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.PumpOptions.Propane
{
    partial class AmountNumberPad : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Infonet_CStoreCommander_UI_Controls_NumberPad_BackNavigation(global::Infonet.CStoreCommander.UI.Controls.NumberPad obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.BackNavigation = value;
            }
            public static void Set_Infonet_CStoreCommander_UI_Controls_NumberPad_CashButtonItemSource(global::Infonet.CStoreCommander.UI.Controls.NumberPad obj, global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel>), targetNullValue);
                }
                obj.CashButtonItemSource = value;
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

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AmountNumberPad_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAmountNumberPad_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.PumpOptions.Propane.AmountNumberPad dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.UI.Controls.NumberPad obj2;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2BackNavigationDisabled = false;
            private static bool isobj2CashButtonItemSourceDisabled = false;
            private static bool isobj2EnterTappedCommandDisabled = false;

            private AmountNumberPad_obj1_BindingsTracking bindingsTracking;

            public AmountNumberPad_obj1_Bindings()
            {
                this.bindingsTracking = new AmountNumberPad_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 14 && columnNumber == 25)
                {
                    isobj2BackNavigationDisabled = true;
                }
                else if (lineNumber == 15 && columnNumber == 25)
                {
                    isobj2CashButtonItemSourceDisabled = true;
                }
                else if (lineNumber == 16 && columnNumber == 25)
                {
                    isobj2EnterTappedCommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\PumpOptions\Propane\AmountNumberPad.xaml line 10
                        this.obj2 = (global::Infonet.CStoreCommander.UI.Controls.NumberPad)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IAmountNumberPad_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.PumpOptions.Propane.AmountNumberPad)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.PumpOptions.Propane.AmountNumberPad obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PropaneGradeVM(obj.PropaneGradeVM, phase);
                    }
                }
            }
            private void Update_PropaneGradeVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.PropaneGrade.PropaneGradeVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PropaneGradeVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PropaneGradeVM_NumberPadClearCommand(obj.NumberPadClearCommand, phase);
                        this.Update_PropaneGradeVM_CashButtons(obj.CashButtons, phase);
                        this.Update_PropaneGradeVM_SetAmountCommand(obj.SetAmountCommand, phase);
                    }
                }
            }
            private void Update_PropaneGradeVM_NumberPadClearCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PumpOptions\Propane\AmountNumberPad.xaml line 10
                    if (!isobj2BackNavigationDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_NumberPad_BackNavigation(this.obj2, obj, null);
                    }
                }
            }
            private void Update_PropaneGradeVM_CashButtons(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PropaneGradeVM_CashButtons(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PumpOptions\Propane\AmountNumberPad.xaml line 10
                    if (!isobj2CashButtonItemSourceDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_NumberPad_CashButtonItemSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_PropaneGradeVM_SetAmountCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\PumpOptions\Propane\AmountNumberPad.xaml line 10
                    if (!isobj2EnterTappedCommandDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_NumberPad_EnterTappedCommand(this.obj2, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AmountNumberPad_obj1_BindingsTracking
            {
                private global::System.WeakReference<AmountNumberPad_obj1_Bindings> weakRefToBindingObj; 

                public AmountNumberPad_obj1_BindingsTracking(AmountNumberPad_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AmountNumberPad_obj1_Bindings>(obj);
                }

                public AmountNumberPad_obj1_Bindings TryGetBindingObject()
                {
                    AmountNumberPad_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_PropaneGradeVM(null);
                    UpdateChildListeners_PropaneGradeVM_CashButtons(null);
                }

                public void PropertyChanged_PropaneGradeVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AmountNumberPad_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.PropaneGrade.PropaneGradeVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.PropaneGrade.PropaneGradeVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_PropaneGradeVM_NumberPadClearCommand(obj.NumberPadClearCommand, DATA_CHANGED);
                                bindings.Update_PropaneGradeVM_CashButtons(obj.CashButtons, DATA_CHANGED);
                                bindings.Update_PropaneGradeVM_SetAmountCommand(obj.SetAmountCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "NumberPadClearCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PropaneGradeVM_NumberPadClearCommand(obj.NumberPadClearCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CashButtons":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PropaneGradeVM_CashButtons(obj.CashButtons, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SetAmountCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PropaneGradeVM_SetAmountCommand(obj.SetAmountCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.PropaneGrade.PropaneGradeVM cache_PropaneGradeVM = null;
                public void UpdateChildListeners_PropaneGradeVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.PropaneGrade.PropaneGradeVM obj)
                {
                    if (obj != cache_PropaneGradeVM)
                    {
                        if (cache_PropaneGradeVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_PropaneGradeVM).PropertyChanged -= PropertyChanged_PropaneGradeVM;
                            cache_PropaneGradeVM = null;
                        }
                        if (obj != null)
                        {
                            cache_PropaneGradeVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_PropaneGradeVM;
                        }
                    }
                }
                public void PropertyChanged_PropaneGradeVM_CashButtons(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AmountNumberPad_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
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
                public void CollectionChanged_PropaneGradeVM_CashButtons(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    AmountNumberPad_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> cache_PropaneGradeVM_CashButtons = null;
                public void UpdateChildListeners_PropaneGradeVM_CashButtons(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.CashButtonModel> obj)
                {
                    if (obj != cache_PropaneGradeVM_CashButtons)
                    {
                        if (cache_PropaneGradeVM_CashButtons != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_PropaneGradeVM_CashButtons).PropertyChanged -= PropertyChanged_PropaneGradeVM_CashButtons;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_PropaneGradeVM_CashButtons).CollectionChanged -= CollectionChanged_PropaneGradeVM_CashButtons;
                            cache_PropaneGradeVM_CashButtons = null;
                        }
                        if (obj != null)
                        {
                            cache_PropaneGradeVM_CashButtons = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_PropaneGradeVM_CashButtons;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_PropaneGradeVM_CashButtons;
                        }
                    }
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
            case 1: // View\PumpOptions\Propane\AmountNumberPad.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AmountNumberPad_obj1_Bindings bindings = new AmountNumberPad_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

