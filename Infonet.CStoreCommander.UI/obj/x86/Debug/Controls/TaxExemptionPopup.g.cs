﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\Controls\TaxExemptionPopup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5EFE3287584BDE0EB1FB234AEDE773C3"
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
    partial class TaxExemptionPopup : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Border_Background(global::Windows.UI.Xaml.Controls.Border obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.CancelCommand = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
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

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TaxExemptionPopup_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITaxExemptionPopup_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.TaxExemptionPopup dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;
            private global::Windows.UI.Xaml.Controls.Border obj3;
            private global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::WinRT.Triggers.InvokeCommandAction obj9;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj2Loaded;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3BackgroundDisabled = false;
            private static bool isobj4CancelCommandDisabled = false;
            private static bool isobj5CommandDisabled = false;
            private static bool isobj6CommandDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj9CommandDisabled = false;

            private TaxExemptionPopup_obj1_BindingsTracking bindingsTracking;

            public TaxExemptionPopup_obj1_Bindings()
            {
                this.bindingsTracking = new TaxExemptionPopup_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 11 && columnNumber == 11)
                {
                    this.obj2.Loaded -= obj2Loaded;
                }
                else if (lineNumber == 15 && columnNumber == 17)
                {
                    isobj3BackgroundDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 41)
                {
                    isobj4CancelCommandDisabled = true;
                }
                else if (lineNumber == 80 && columnNumber == 51)
                {
                    isobj5CommandDisabled = true;
                }
                else if (lineNumber == 88 && columnNumber == 51)
                {
                    isobj6CommandDisabled = true;
                }
                else if (lineNumber == 50 && columnNumber == 36)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 62 && columnNumber == 67)
                {
                    isobj9CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\TaxExemptionPopup.xaml line 11
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        this.obj2Loaded = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.GridLoaded(p0, p1);
                        };
                        ((global::Windows.UI.Xaml.Controls.Grid)target).Loaded += obj2Loaded;
                        break;
                    case 3: // Controls\TaxExemptionPopup.xaml line 13
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 4: // Controls\TaxExemptionPopup.xaml line 34
                        this.obj4 = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)target;
                        break;
                    case 5: // Controls\TaxExemptionPopup.xaml line 76
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6: // Controls\TaxExemptionPopup.xaml line 84
                        this.obj6 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 7: // Controls\TaxExemptionPopup.xaml line 50
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9: // Controls\TaxExemptionPopup.xaml line 62
                        this.obj9 = (global::WinRT.Triggers.InvokeCommandAction)target;
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

            // ITaxExemptionPopup_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.Controls.TaxExemptionPopup)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.TaxExemptionPopup obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BackgroundOverlay(obj.BackgroundOverlay, phase);
                        this.Update_CustomersScreenVM(obj.CustomersScreenVM, phase);
                    }
                }
            }
            private void Update_BackgroundOverlay(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\TaxExemptionPopup.xaml line 13
                    if (!isobj3BackgroundDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj3, obj, null);
                    }
                }
            }
            private void Update_CustomersScreenVM(global::Infonet.CStoreCommander.UI.ViewModel.Customer.CustomersScreenVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_CustomersScreenVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CustomersScreenVM_PopupService(obj.PopupService, phase);
                        this.Update_CustomersScreenVM_SetTaxExemptionCommand(obj.SetTaxExemptionCommand, phase);
                        this.Update_CustomersScreenVM_EnterPressedOnTaxExemptionNumberCommand(obj.EnterPressedOnTaxExemptionNumberCommand, phase);
                    }
                }
            }
            private void Update_CustomersScreenVM_PopupService(global::Infonet.CStoreCommander.UI.Utility.PopupService obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_CustomersScreenVM_PopupService(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CustomersScreenVM_PopupService_CloseCommand(obj.CloseCommand, phase);
                        this.Update_CustomersScreenVM_PopupService_Title(obj.Title, phase);
                    }
                }
            }
            private void Update_CustomersScreenVM_PopupService_CloseCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\TaxExemptionPopup.xaml line 34
                    if (!isobj4CancelCommandDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(this.obj4, obj, null);
                    }
                    // Controls\TaxExemptionPopup.xaml line 84
                    if (!isobj6CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                    }
                }
            }
            private void Update_CustomersScreenVM_SetTaxExemptionCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\TaxExemptionPopup.xaml line 76
                    if (!isobj5CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                    }
                }
            }
            private void Update_CustomersScreenVM_PopupService_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\TaxExemptionPopup.xaml line 50
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_CustomersScreenVM_EnterPressedOnTaxExemptionNumberCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\TaxExemptionPopup.xaml line 62
                    if (!isobj9CommandDisabled)
                    {
                        XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj9, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class TaxExemptionPopup_obj1_BindingsTracking
            {
                private global::System.WeakReference<TaxExemptionPopup_obj1_Bindings> weakRefToBindingObj; 

                public TaxExemptionPopup_obj1_BindingsTracking(TaxExemptionPopup_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<TaxExemptionPopup_obj1_Bindings>(obj);
                }

                public TaxExemptionPopup_obj1_Bindings TryGetBindingObject()
                {
                    TaxExemptionPopup_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_(null);
                    UpdateChildListeners_CustomersScreenVM(null);
                    UpdateChildListeners_CustomersScreenVM_PopupService(null);
                }

                public void DependencyPropertyChanged_BackgroundOverlay(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    TaxExemptionPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.TaxExemptionPopup obj = sender as global::Infonet.CStoreCommander.UI.Controls.TaxExemptionPopup;
                        if (obj != null)
                        {
                            bindings.Update_BackgroundOverlay(obj.BackgroundOverlay, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_BackgroundOverlay = 0;
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Controls.TaxExemptionPopup obj)
                {
                    TaxExemptionPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.TaxExemptionPopup.BackgroundOverlayProperty, tokenDPC_BackgroundOverlay);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_BackgroundOverlay = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.TaxExemptionPopup.BackgroundOverlayProperty, DependencyPropertyChanged_BackgroundOverlay);
                        }
                    }
                }
                public void PropertyChanged_CustomersScreenVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TaxExemptionPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Customer.CustomersScreenVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Customer.CustomersScreenVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_CustomersScreenVM_PopupService(obj.PopupService, DATA_CHANGED);
                                bindings.Update_CustomersScreenVM_SetTaxExemptionCommand(obj.SetTaxExemptionCommand, DATA_CHANGED);
                                bindings.Update_CustomersScreenVM_EnterPressedOnTaxExemptionNumberCommand(obj.EnterPressedOnTaxExemptionNumberCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "PopupService":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CustomersScreenVM_PopupService(obj.PopupService, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SetTaxExemptionCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CustomersScreenVM_SetTaxExemptionCommand(obj.SetTaxExemptionCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EnterPressedOnTaxExemptionNumberCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CustomersScreenVM_EnterPressedOnTaxExemptionNumberCommand(obj.EnterPressedOnTaxExemptionNumberCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Customer.CustomersScreenVM cache_CustomersScreenVM = null;
                public void UpdateChildListeners_CustomersScreenVM(global::Infonet.CStoreCommander.UI.ViewModel.Customer.CustomersScreenVM obj)
                {
                    if (obj != cache_CustomersScreenVM)
                    {
                        if (cache_CustomersScreenVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_CustomersScreenVM).PropertyChanged -= PropertyChanged_CustomersScreenVM;
                            cache_CustomersScreenVM = null;
                        }
                        if (obj != null)
                        {
                            cache_CustomersScreenVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_CustomersScreenVM;
                        }
                    }
                }
                public void PropertyChanged_CustomersScreenVM_PopupService(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TaxExemptionPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Utility.PopupService obj = sender as global::Infonet.CStoreCommander.UI.Utility.PopupService;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_CustomersScreenVM_PopupService_CloseCommand(obj.CloseCommand, DATA_CHANGED);
                                bindings.Update_CustomersScreenVM_PopupService_Title(obj.Title, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CloseCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CustomersScreenVM_PopupService_CloseCommand(obj.CloseCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Title":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CustomersScreenVM_PopupService_Title(obj.Title, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.Utility.PopupService cache_CustomersScreenVM_PopupService = null;
                public void UpdateChildListeners_CustomersScreenVM_PopupService(global::Infonet.CStoreCommander.UI.Utility.PopupService obj)
                {
                    if (obj != cache_CustomersScreenVM_PopupService)
                    {
                        if (cache_CustomersScreenVM_PopupService != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_CustomersScreenVM_PopupService).PropertyChanged -= PropertyChanged_CustomersScreenVM_PopupService;
                            cache_CustomersScreenVM_PopupService = null;
                        }
                        if (obj != null)
                        {
                            cache_CustomersScreenVM_PopupService = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_CustomersScreenVM_PopupService;
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
            switch(connectionId)
            {
            case 4: // Controls\TaxExemptionPopup.xaml line 34
                {
                    this.TitleText = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)(target);
                }
                break;
            case 8: // Controls\TaxExemptionPopup.xaml line 53
                {
                    this.taxTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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
            case 1: // Controls\TaxExemptionPopup.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TaxExemptionPopup_obj1_Bindings bindings = new TaxExemptionPopup_obj1_Bindings();
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

