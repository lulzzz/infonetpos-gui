﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\View\Settings\MaintenanceOptions\Banking.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2441A806840DF2E0401E060D15915CCA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Settings.MaintenanceOptions
{
    partial class Banking : 
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
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Banking_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IBanking_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Settings.MaintenanceOptions.Banking dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj2;
            private global::Windows.UI.Xaml.Controls.Button obj3;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2CommandDisabled = false;
            private static bool isobj3CommandDisabled = false;

            private Banking_obj1_BindingsTracking bindingsTracking;

            public Banking_obj1_Bindings()
            {
                this.bindingsTracking = new Banking_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 23 && columnNumber == 17)
                {
                    isobj2CommandDisabled = true;
                }
                else if (lineNumber == 26 && columnNumber == 17)
                {
                    isobj3CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\Settings\MaintenanceOptions\Banking.xaml line 22
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 3: // View\Settings\MaintenanceOptions\Banking.xaml line 25
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Button)target;
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

            // IBanking_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.Settings.MaintenanceOptions.Banking)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Settings.MaintenanceOptions.Banking obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MaintenanceVM(obj.MaintenanceVM, phase);
                    }
                }
            }
            private void Update_MaintenanceVM(global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.MaintenanceVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MaintenanceVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MaintenanceVM_InitializeCommand(obj.InitializeCommand, phase);
                        this.Update_MaintenanceVM_CloseBatchCommand(obj.CloseBatchCommand, phase);
                    }
                }
            }
            private void Update_MaintenanceVM_InitializeCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Settings\MaintenanceOptions\Banking.xaml line 22
                    if (!isobj2CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                    }
                }
            }
            private void Update_MaintenanceVM_CloseBatchCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Settings\MaintenanceOptions\Banking.xaml line 25
                    if (!isobj3CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class Banking_obj1_BindingsTracking
            {
                private global::System.WeakReference<Banking_obj1_Bindings> weakRefToBindingObj; 

                public Banking_obj1_BindingsTracking(Banking_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<Banking_obj1_Bindings>(obj);
                }

                public Banking_obj1_Bindings TryGetBindingObject()
                {
                    Banking_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_MaintenanceVM(null);
                }

                public void PropertyChanged_MaintenanceVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Banking_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.MaintenanceVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.MaintenanceVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_MaintenanceVM_InitializeCommand(obj.InitializeCommand, DATA_CHANGED);
                                bindings.Update_MaintenanceVM_CloseBatchCommand(obj.CloseBatchCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "InitializeCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MaintenanceVM_InitializeCommand(obj.InitializeCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CloseBatchCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MaintenanceVM_CloseBatchCommand(obj.CloseBatchCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.MaintenanceVM cache_MaintenanceVM = null;
                public void UpdateChildListeners_MaintenanceVM(global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.MaintenanceVM obj)
                {
                    if (obj != cache_MaintenanceVM)
                    {
                        if (cache_MaintenanceVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_MaintenanceVM).PropertyChanged -= PropertyChanged_MaintenanceVM;
                            cache_MaintenanceVM = null;
                        }
                        if (obj != null)
                        {
                            cache_MaintenanceVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_MaintenanceVM;
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
            case 1: // View\Settings\MaintenanceOptions\Banking.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Banking_obj1_Bindings bindings = new Banking_obj1_Bindings();
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
