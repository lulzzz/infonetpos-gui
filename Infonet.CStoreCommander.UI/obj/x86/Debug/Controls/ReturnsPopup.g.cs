﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\Controls\ReturnsPopup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6C449BA2199AA135C80C55F2E87C284B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.Controls
{
    partial class ReturnsPopup : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.CancelCommand = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(global::Windows.UI.Xaml.Controls.ToggleSwitch obj, global::System.Boolean value)
            {
                obj.IsOn = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ReturnsPopup_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IReturnsPopup_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.ReturnsPopup dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj2;
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2CancelCommandDisabled = false;
            private static bool isobj3IsEnabledDisabled = false;
            private static bool isobj3IsOnDisabled = false;
            private static bool isobj4CommandDisabled = false;
            private static bool isobj4IsEnabledDisabled = false;
            private static bool isobj5CommandDisabled = false;
            private static bool isobj5IsEnabledDisabled = false;

            private ReturnsPopup_obj1_BindingsTracking bindingsTracking;

            public ReturnsPopup_obj1_Bindings()
            {
                this.bindingsTracking = new ReturnsPopup_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 40 && columnNumber == 41)
                {
                    isobj2CancelCommandDisabled = true;
                }
                else if (lineNumber == 70 && columnNumber == 35)
                {
                    isobj3IsEnabledDisabled = true;
                }
                else if (lineNumber == 71 && columnNumber == 35)
                {
                    isobj3IsOnDisabled = true;
                }
                else if (lineNumber == 50 && columnNumber == 51)
                {
                    isobj4CommandDisabled = true;
                }
                else if (lineNumber == 51 && columnNumber == 51)
                {
                    isobj4IsEnabledDisabled = true;
                }
                else if (lineNumber == 58 && columnNumber == 51)
                {
                    isobj5CommandDisabled = true;
                }
                else if (lineNumber == 59 && columnNumber == 51)
                {
                    isobj5IsEnabledDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\ReturnsPopup.xaml line 39
                        this.obj2 = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)target;
                        break;
                    case 3: // Controls\ReturnsPopup.xaml line 68
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    case 4: // Controls\ReturnsPopup.xaml line 49
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5: // Controls\ReturnsPopup.xaml line 57
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
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

            // IReturnsPopup_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.Controls.ReturnsPopup)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.ReturnsPopup obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SaleGridVM(obj.SaleGridVM, phase);
                    }
                }
            }
            private void Update_SaleGridVM(global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SaleGridVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SaleGridVM_CloseReturnsPopupCommand(obj.CloseReturnsPopupCommand, phase);
                        this.Update_SaleGridVM_OperatorCanReturnSale(obj.OperatorCanReturnSale, phase);
                        this.Update_SaleGridVM_IsReturn(obj.IsReturn, phase);
                        this.Update_SaleGridVM_ReturnSaleCommand(obj.ReturnSaleCommand, phase);
                        this.Update_SaleGridVM_IsSaleReturnEnabled(obj.IsSaleReturnEnabled, phase);
                        this.Update_SaleGridVM_BottleReturnsCommand(obj.BottleReturnsCommand, phase);
                        this.Update_SaleGridVM_IsBottleReturnEnabled(obj.IsBottleReturnEnabled, phase);
                    }
                }
            }
            private void Update_SaleGridVM_CloseReturnsPopupCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ReturnsPopup.xaml line 39
                    if (!isobj2CancelCommandDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(this.obj2, obj, null);
                    }
                }
            }
            private void Update_SaleGridVM_OperatorCanReturnSale(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ReturnsPopup.xaml line 68
                    if (!isobj3IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj3, obj);
                    }
                }
            }
            private void Update_SaleGridVM_IsReturn(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ReturnsPopup.xaml line 68
                    if (!isobj3IsOnDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj3, obj);
                    }
                }
            }
            private void Update_SaleGridVM_ReturnSaleCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ReturnsPopup.xaml line 49
                    if (!isobj4CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                    }
                }
            }
            private void Update_SaleGridVM_IsSaleReturnEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ReturnsPopup.xaml line 49
                    if (!isobj4IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                    }
                }
            }
            private void Update_SaleGridVM_BottleReturnsCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ReturnsPopup.xaml line 57
                    if (!isobj5CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                    }
                }
            }
            private void Update_SaleGridVM_IsBottleReturnEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ReturnsPopup.xaml line 57
                    if (!isobj5IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj5, obj);
                    }
                }
            }
            private void UpdateTwoWay_3_IsOn()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.SaleGridVM != null)
                        {
                            this.dataRoot.SaleGridVM.IsReturn = this.obj3.IsOn;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ReturnsPopup_obj1_BindingsTracking
            {
                private global::System.WeakReference<ReturnsPopup_obj1_Bindings> weakRefToBindingObj; 

                public ReturnsPopup_obj1_BindingsTracking(ReturnsPopup_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ReturnsPopup_obj1_Bindings>(obj);
                }

                public ReturnsPopup_obj1_Bindings TryGetBindingObject()
                {
                    ReturnsPopup_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_SaleGridVM(null);
                }

                public void PropertyChanged_SaleGridVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ReturnsPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_SaleGridVM_CloseReturnsPopupCommand(obj.CloseReturnsPopupCommand, DATA_CHANGED);
                                bindings.Update_SaleGridVM_OperatorCanReturnSale(obj.OperatorCanReturnSale, DATA_CHANGED);
                                bindings.Update_SaleGridVM_IsReturn(obj.IsReturn, DATA_CHANGED);
                                bindings.Update_SaleGridVM_ReturnSaleCommand(obj.ReturnSaleCommand, DATA_CHANGED);
                                bindings.Update_SaleGridVM_IsSaleReturnEnabled(obj.IsSaleReturnEnabled, DATA_CHANGED);
                                bindings.Update_SaleGridVM_BottleReturnsCommand(obj.BottleReturnsCommand, DATA_CHANGED);
                                bindings.Update_SaleGridVM_IsBottleReturnEnabled(obj.IsBottleReturnEnabled, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CloseReturnsPopupCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_CloseReturnsPopupCommand(obj.CloseReturnsPopupCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "OperatorCanReturnSale":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_OperatorCanReturnSale(obj.OperatorCanReturnSale, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsReturn":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_IsReturn(obj.IsReturn, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ReturnSaleCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_ReturnSaleCommand(obj.ReturnSaleCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsSaleReturnEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_IsSaleReturnEnabled(obj.IsSaleReturnEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BottleReturnsCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_BottleReturnsCommand(obj.BottleReturnsCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsBottleReturnEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_IsBottleReturnEnabled(obj.IsBottleReturnEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM cache_SaleGridVM = null;
                public void UpdateChildListeners_SaleGridVM(global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM obj)
                {
                    if (obj != cache_SaleGridVM)
                    {
                        if (cache_SaleGridVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_SaleGridVM).PropertyChanged -= PropertyChanged_SaleGridVM;
                            cache_SaleGridVM = null;
                        }
                        if (obj != null)
                        {
                            cache_SaleGridVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_SaleGridVM;
                        }
                    }
                }
                public void RegisterTwoWayListener_3(global::Windows.UI.Xaml.Controls.ToggleSwitch sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ToggleSwitch.IsOnProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_IsOn();
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
            case 1: // Controls\ReturnsPopup.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    ReturnsPopup_obj1_Bindings bindings = new ReturnsPopup_obj1_Bindings();
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

