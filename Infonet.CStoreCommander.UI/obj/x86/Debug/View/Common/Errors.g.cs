﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\View\Common\Errors.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "556A0E1DC40C6C92F3F4E79CF32F8953"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Common
{
    partial class Errors : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Infonet_CStoreCommander_UI_Controls_ViewHeading_BackCommand(global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.BackCommand = value;
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
        private class Errors_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IErrors_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Common.Errors dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2BackCommandDisabled = false;
            private static bool isobj3IsEnabledDisabled = false;
            private static bool isobj3CommandDisabled = false;
            private static bool isobj4IsEnabledDisabled = false;
            private static bool isobj4CommandDisabled = false;
            private static bool isobj5TextDisabled = false;

            private Errors_obj1_BindingsTracking bindingsTracking;

            public Errors_obj1_Bindings()
            {
                this.bindingsTracking = new Errors_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 19 && columnNumber == 31)
                {
                    isobj2BackCommandDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 39)
                {
                    isobj3IsEnabledDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 39)
                {
                    isobj3CommandDisabled = true;
                }
                else if (lineNumber == 45 && columnNumber == 39)
                {
                    isobj4IsEnabledDisabled = true;
                }
                else if (lineNumber == 46 && columnNumber == 39)
                {
                    isobj4CommandDisabled = true;
                }
                else if (lineNumber == 29 && columnNumber == 28)
                {
                    isobj5TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\Common\Errors.xaml line 18
                        this.obj2 = (global::Infonet.CStoreCommander.UI.Controls.ViewHeading)target;
                        break;
                    case 3: // View\Common\Errors.xaml line 38
                        this.obj3 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 4: // View\Common\Errors.xaml line 44
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5: // View\Common\Errors.xaml line 26
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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

            // IErrors_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.Common.Errors)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Common.Errors obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ErrorsVM(obj.ErrorsVM, phase);
                    }
                }
            }
            private void Update_ErrorsVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.ErrorsVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ErrorsVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ErrorsVM_BackPageCommand(obj.BackPageCommand, phase);
                        this.Update_ErrorsVM_IsClearButtonEnable(obj.IsClearButtonEnable, phase);
                        this.Update_ErrorsVM_ClearErrorCommand(obj.ClearErrorCommand, phase);
                        this.Update_ErrorsVM_PrintCommand(obj.PrintCommand, phase);
                        this.Update_ErrorsVM_ErrorString(obj.ErrorString, phase);
                    }
                }
            }
            private void Update_ErrorsVM_BackPageCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\Errors.xaml line 18
                    if (!isobj2BackCommandDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_ViewHeading_BackCommand(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ErrorsVM_IsClearButtonEnable(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\Errors.xaml line 38
                    if (!isobj3IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj3, obj);
                    }
                    // View\Common\Errors.xaml line 44
                    if (!isobj4IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                    }
                }
            }
            private void Update_ErrorsVM_ClearErrorCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\Errors.xaml line 38
                    if (!isobj3CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                    }
                }
            }
            private void Update_ErrorsVM_PrintCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\Errors.xaml line 44
                    if (!isobj4CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ErrorsVM_ErrorString(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\Errors.xaml line 26
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class Errors_obj1_BindingsTracking
            {
                private global::System.WeakReference<Errors_obj1_Bindings> weakRefToBindingObj; 

                public Errors_obj1_BindingsTracking(Errors_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<Errors_obj1_Bindings>(obj);
                }

                public Errors_obj1_Bindings TryGetBindingObject()
                {
                    Errors_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ErrorsVM(null);
                }

                public void PropertyChanged_ErrorsVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Errors_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.ErrorsVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.ErrorsVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ErrorsVM_BackPageCommand(obj.BackPageCommand, DATA_CHANGED);
                                bindings.Update_ErrorsVM_IsClearButtonEnable(obj.IsClearButtonEnable, DATA_CHANGED);
                                bindings.Update_ErrorsVM_ClearErrorCommand(obj.ClearErrorCommand, DATA_CHANGED);
                                bindings.Update_ErrorsVM_PrintCommand(obj.PrintCommand, DATA_CHANGED);
                                bindings.Update_ErrorsVM_ErrorString(obj.ErrorString, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "BackPageCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ErrorsVM_BackPageCommand(obj.BackPageCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsClearButtonEnable":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ErrorsVM_IsClearButtonEnable(obj.IsClearButtonEnable, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ClearErrorCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ErrorsVM_ClearErrorCommand(obj.ClearErrorCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "PrintCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ErrorsVM_PrintCommand(obj.PrintCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ErrorString":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ErrorsVM_ErrorString(obj.ErrorString, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.ErrorsVM cache_ErrorsVM = null;
                public void UpdateChildListeners_ErrorsVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.ErrorsVM obj)
                {
                    if (obj != cache_ErrorsVM)
                    {
                        if (cache_ErrorsVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ErrorsVM).PropertyChanged -= PropertyChanged_ErrorsVM;
                            cache_ErrorsVM = null;
                        }
                        if (obj != null)
                        {
                            cache_ErrorsVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ErrorsVM;
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
            case 1: // View\Common\Errors.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Errors_obj1_Bindings bindings = new Errors_obj1_Bindings();
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

