﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\View\Checkout\FleetCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "159940F832ED5DA7F145C438B97B2651"
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
    partial class FleetCard : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
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
            public static void Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(global::MyToolkit.Extended.Controls.CustomTextBox obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.EnterPressedCommand = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class FleetCard_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IFleetCard_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Checkout.FleetCard dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;
            private global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj5;
            private global::Windows.UI.Xaml.Controls.ComboBox obj6;
            private global::Windows.UI.Xaml.Controls.ComboBox obj7;
            private global::Windows.UI.Xaml.Controls.ComboBox obj8;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj2Loaded;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3PreviousFrameDisabled = false;
            private static bool isobj4IsEnabledDisabled = false;
            private static bool isobj4CommandDisabled = false;
            private static bool isobj5EnterPressedCommandDisabled = false;
            private static bool isobj6ItemsSourceDisabled = false;
            private static bool isobj6SelectedIndexDisabled = false;
            private static bool isobj7ItemsSourceDisabled = false;
            private static bool isobj8ItemsSourceDisabled = false;

            private FleetCard_obj1_BindingsTracking bindingsTracking;

            public FleetCard_obj1_Bindings()
            {
                this.bindingsTracking = new FleetCard_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 36 && columnNumber == 11)
                {
                    this.obj2.Loaded -= obj2Loaded;
                }
                else if (lineNumber == 47 && columnNumber == 38)
                {
                    isobj3PreviousFrameDisabled = true;
                }
                else if (lineNumber == 147 && columnNumber == 35)
                {
                    isobj4IsEnabledDisabled = true;
                }
                else if (lineNumber == 148 && columnNumber == 35)
                {
                    isobj4CommandDisabled = true;
                }
                else if (lineNumber == 84 && columnNumber == 37)
                {
                    isobj5EnterPressedCommandDisabled = true;
                }
                else if (lineNumber == 128 && columnNumber == 27)
                {
                    isobj6ItemsSourceDisabled = true;
                }
                else if (lineNumber == 129 && columnNumber == 27)
                {
                    isobj6SelectedIndexDisabled = true;
                }
                else if (lineNumber == 111 && columnNumber == 31)
                {
                    isobj7ItemsSourceDisabled = true;
                }
                else if (lineNumber == 120 && columnNumber == 31)
                {
                    isobj8ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\Checkout\FleetCard.xaml line 35
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        this.obj2Loaded = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.GridLoaded(p0, p1);
                        };
                        ((global::Windows.UI.Xaml.Controls.Grid)target).Loaded += obj2Loaded;
                        break;
                    case 3: // View\Checkout\FleetCard.xaml line 45
                        this.obj3 = (global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading)target;
                        break;
                    case 4: // View\Checkout\FleetCard.xaml line 143
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5: // View\Checkout\FleetCard.xaml line 80
                        this.obj5 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 6: // View\Checkout\FleetCard.xaml line 125
                        this.obj6 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_6(this.obj6);
                        break;
                    case 7: // View\Checkout\FleetCard.xaml line 106
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 8: // View\Checkout\FleetCard.xaml line 113
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
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

            // IFleetCard_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.Checkout.FleetCard)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Checkout.FleetCard obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FleetTenderVM(obj.FleetTenderVM, phase);
                    }
                }
            }
            private void Update_FleetTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_FleetTenderVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FleetTenderVM_BackCommand(obj.BackCommand, phase);
                        this.Update_FleetTenderVM_IsAcceptButtonEnabled(obj.IsAcceptButtonEnabled, phase);
                        this.Update_FleetTenderVM_CompleteFleetPaymentCommand(obj.CompleteFleetPaymentCommand, phase);
                        this.Update_FleetTenderVM_CardNumberEnteredCommand(obj.CardNumberEnteredCommand, phase);
                        this.Update_FleetTenderVM_Languages(obj.Languages, phase);
                        this.Update_FleetTenderVM_SelectedLanguageIndex(obj.SelectedLanguageIndex, phase);
                        this.Update_FleetTenderVM_Month(obj.Month, phase);
                        this.Update_FleetTenderVM_Year(obj.Year, phase);
                    }
                }
            }
            private void Update_FleetTenderVM_BackCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Checkout\FleetCard.xaml line 45
                    if (!isobj3PreviousFrameDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SecondFrameHeading_PreviousFrame(this.obj3, obj, null);
                    }
                }
            }
            private void Update_FleetTenderVM_IsAcceptButtonEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Checkout\FleetCard.xaml line 143
                    if (!isobj4IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                    }
                }
            }
            private void Update_FleetTenderVM_CompleteFleetPaymentCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Checkout\FleetCard.xaml line 143
                    if (!isobj4CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                    }
                }
            }
            private void Update_FleetTenderVM_CardNumberEnteredCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Checkout\FleetCard.xaml line 80
                    if (!isobj5EnterPressedCommandDisabled)
                    {
                        XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj5, obj, null);
                    }
                }
            }
            private void Update_FleetTenderVM_Languages(global::System.Collections.Generic.List<global::System.String> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Checkout\FleetCard.xaml line 125
                    if (!isobj6ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                    }
                }
            }
            private void Update_FleetTenderVM_SelectedLanguageIndex(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Checkout\FleetCard.xaml line 125
                    if (!isobj6SelectedIndexDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj6, obj);
                    }
                }
            }
            private void Update_FleetTenderVM_Month(global::System.Collections.Generic.List<global::System.Int32> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Checkout\FleetCard.xaml line 106
                    if (!isobj7ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                    }
                }
            }
            private void Update_FleetTenderVM_Year(global::System.Collections.Generic.List<global::System.Int32> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Checkout\FleetCard.xaml line 113
                    if (!isobj8ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_6_SelectedIndex()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.FleetTenderVM != null)
                        {
                            this.dataRoot.FleetTenderVM.SelectedLanguageIndex = this.obj6.SelectedIndex;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class FleetCard_obj1_BindingsTracking
            {
                private global::System.WeakReference<FleetCard_obj1_Bindings> weakRefToBindingObj; 

                public FleetCard_obj1_BindingsTracking(FleetCard_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<FleetCard_obj1_Bindings>(obj);
                }

                public FleetCard_obj1_Bindings TryGetBindingObject()
                {
                    FleetCard_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_FleetTenderVM(null);
                }

                public void PropertyChanged_FleetTenderVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    FleetCard_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_FleetTenderVM_BackCommand(obj.BackCommand, DATA_CHANGED);
                                bindings.Update_FleetTenderVM_IsAcceptButtonEnabled(obj.IsAcceptButtonEnabled, DATA_CHANGED);
                                bindings.Update_FleetTenderVM_CompleteFleetPaymentCommand(obj.CompleteFleetPaymentCommand, DATA_CHANGED);
                                bindings.Update_FleetTenderVM_CardNumberEnteredCommand(obj.CardNumberEnteredCommand, DATA_CHANGED);
                                bindings.Update_FleetTenderVM_Languages(obj.Languages, DATA_CHANGED);
                                bindings.Update_FleetTenderVM_SelectedLanguageIndex(obj.SelectedLanguageIndex, DATA_CHANGED);
                                bindings.Update_FleetTenderVM_Month(obj.Month, DATA_CHANGED);
                                bindings.Update_FleetTenderVM_Year(obj.Year, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "BackCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_BackCommand(obj.BackCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsAcceptButtonEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_IsAcceptButtonEnabled(obj.IsAcceptButtonEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CompleteFleetPaymentCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_CompleteFleetPaymentCommand(obj.CompleteFleetPaymentCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CardNumberEnteredCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_CardNumberEnteredCommand(obj.CardNumberEnteredCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Languages":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_Languages(obj.Languages, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedLanguageIndex":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_SelectedLanguageIndex(obj.SelectedLanguageIndex, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Month":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_Month(obj.Month, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Year":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_Year(obj.Year, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM cache_FleetTenderVM = null;
                public void UpdateChildListeners_FleetTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM obj)
                {
                    if (obj != cache_FleetTenderVM)
                    {
                        if (cache_FleetTenderVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_FleetTenderVM).PropertyChanged -= PropertyChanged_FleetTenderVM;
                            cache_FleetTenderVM = null;
                        }
                        if (obj != null)
                        {
                            cache_FleetTenderVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_FleetTenderVM;
                        }
                    }
                }
                public void RegisterTwoWayListener_6(global::Windows.UI.Xaml.Controls.ComboBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_6_SelectedIndex();
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
            case 5: // View\Checkout\FleetCard.xaml line 80
                {
                    this.txtCard = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
            case 1: // View\Checkout\FleetCard.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    FleetCard_obj1_Bindings bindings = new FleetCard_obj1_Bindings();
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

