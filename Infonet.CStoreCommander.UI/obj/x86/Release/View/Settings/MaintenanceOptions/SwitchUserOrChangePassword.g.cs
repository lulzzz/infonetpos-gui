﻿#pragma checksum "F:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3066BC10F107704BD86F6AFE57A7C9FF"
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
    partial class SwitchUserOrChangePassword : 
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
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_PasswordBox_Password(global::Windows.UI.Xaml.Controls.PasswordBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Password = value ?? global::System.String.Empty;
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
        private class SwitchUserOrChangePassword_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISwitchUserOrChangePassword_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Settings.MaintenanceOptions.SwitchUserOrChangePassword dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj2;
            private global::Windows.UI.Xaml.Controls.PasswordBox obj3;
            private global::Windows.UI.Xaml.Controls.PasswordBox obj4;
            private global::WinRT.Triggers.InvokeCommandAction obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;

            private SwitchUserOrChangePassword_obj1_BindingsTracking bindingsTracking;

            public SwitchUserOrChangePassword_obj1_Bindings()
            {
                this.bindingsTracking = new SwitchUserOrChangePassword_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 95
                        this.obj2 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 3: // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 77
                        this.obj3 = (global::Windows.UI.Xaml.Controls.PasswordBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    case 4: // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 83
                        this.obj4 = (global::Windows.UI.Xaml.Controls.PasswordBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 88
                        this.obj5 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 6: // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 67
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            // ISwitchUserOrChangePassword_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.Settings.MaintenanceOptions.SwitchUserOrChangePassword)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Settings.MaintenanceOptions.SwitchUserOrChangePassword obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SwitchUserVM(obj.SwitchUserVM, phase);
                    }
                }
            }
            private void Update_SwitchUserVM(global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.Maintenance.SwitchUserVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SwitchUserVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SwitchUserVM_ChangePasswordCommand(obj.ChangePasswordCommand, phase);
                        this.Update_SwitchUserVM_UserCanChangePassword(obj.UserCanChangePassword, phase);
                        this.Update_SwitchUserVM_ChangePassword(obj.ChangePassword, phase);
                        this.Update_SwitchUserVM_ConfirmPasswordCompletedCommand(obj.ConfirmPasswordCompletedCommand, phase);
                        this.Update_SwitchUserVM_SwitchUserCommand(obj.SwitchUserCommand, phase);
                    }
                }
            }
            private void Update_SwitchUserVM_ChangePasswordCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 95
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                }
            }
            private void Update_SwitchUserVM_UserCanChangePassword(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 95
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj2, obj);
                    // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 77
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj3, obj);
                    // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 83
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_SwitchUserVM_ChangePassword(global::Infonet.CStoreCommander.UI.Model.Settings.Maintenance.ChangePassword obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SwitchUserVM_ChangePassword(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SwitchUserVM_ChangePassword_Password(obj.Password, phase);
                        this.Update_SwitchUserVM_ChangePassword_ConfirmNewPassword(obj.ConfirmNewPassword, phase);
                    }
                }
            }
            private void Update_SwitchUserVM_ChangePassword_Password(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 77
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_PasswordBox_Password(this.obj3, obj, null);
                }
            }
            private void Update_SwitchUserVM_ChangePassword_ConfirmNewPassword(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 83
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_PasswordBox_Password(this.obj4, obj, null);
                }
            }
            private void Update_SwitchUserVM_ConfirmPasswordCompletedCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 88
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj5, obj, null);
                }
            }
            private void Update_SwitchUserVM_SwitchUserCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 67
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void UpdateTwoWay_3_Password()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.SwitchUserVM != null)
                        {
                            if (this.dataRoot.SwitchUserVM.ChangePassword != null)
                            {
                                this.dataRoot.SwitchUserVM.ChangePassword.Password = this.obj3.Password;
                            }
                        }
                    }
                }
            }
            private void UpdateTwoWay_4_Password()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.SwitchUserVM != null)
                        {
                            if (this.dataRoot.SwitchUserVM.ChangePassword != null)
                            {
                                this.dataRoot.SwitchUserVM.ChangePassword.ConfirmNewPassword = this.obj4.Password;
                            }
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SwitchUserOrChangePassword_obj1_BindingsTracking
            {
                private global::System.WeakReference<SwitchUserOrChangePassword_obj1_Bindings> weakRefToBindingObj; 

                public SwitchUserOrChangePassword_obj1_BindingsTracking(SwitchUserOrChangePassword_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SwitchUserOrChangePassword_obj1_Bindings>(obj);
                }

                public SwitchUserOrChangePassword_obj1_Bindings TryGetBindingObject()
                {
                    SwitchUserOrChangePassword_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_SwitchUserVM(null);
                    UpdateChildListeners_SwitchUserVM_ChangePassword(null);
                }

                public void PropertyChanged_SwitchUserVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SwitchUserOrChangePassword_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.Maintenance.SwitchUserVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.Maintenance.SwitchUserVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_SwitchUserVM_ChangePasswordCommand(obj.ChangePasswordCommand, DATA_CHANGED);
                                bindings.Update_SwitchUserVM_UserCanChangePassword(obj.UserCanChangePassword, DATA_CHANGED);
                                bindings.Update_SwitchUserVM_ChangePassword(obj.ChangePassword, DATA_CHANGED);
                                bindings.Update_SwitchUserVM_ConfirmPasswordCompletedCommand(obj.ConfirmPasswordCompletedCommand, DATA_CHANGED);
                                bindings.Update_SwitchUserVM_SwitchUserCommand(obj.SwitchUserCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "ChangePasswordCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SwitchUserVM_ChangePasswordCommand(obj.ChangePasswordCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "UserCanChangePassword":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SwitchUserVM_UserCanChangePassword(obj.UserCanChangePassword, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ChangePassword":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SwitchUserVM_ChangePassword(obj.ChangePassword, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ConfirmPasswordCompletedCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SwitchUserVM_ConfirmPasswordCompletedCommand(obj.ConfirmPasswordCompletedCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SwitchUserCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SwitchUserVM_SwitchUserCommand(obj.SwitchUserCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.Maintenance.SwitchUserVM cache_SwitchUserVM = null;
                public void UpdateChildListeners_SwitchUserVM(global::Infonet.CStoreCommander.UI.ViewModel.SettingsMenu.Maintenance.SwitchUserVM obj)
                {
                    if (obj != cache_SwitchUserVM)
                    {
                        if (cache_SwitchUserVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_SwitchUserVM).PropertyChanged -= PropertyChanged_SwitchUserVM;
                            cache_SwitchUserVM = null;
                        }
                        if (obj != null)
                        {
                            cache_SwitchUserVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_SwitchUserVM;
                        }
                    }
                }
                public void PropertyChanged_SwitchUserVM_ChangePassword(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SwitchUserOrChangePassword_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Model.Settings.Maintenance.ChangePassword obj = sender as global::Infonet.CStoreCommander.UI.Model.Settings.Maintenance.ChangePassword;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_SwitchUserVM_ChangePassword_Password(obj.Password, DATA_CHANGED);
                                bindings.Update_SwitchUserVM_ChangePassword_ConfirmNewPassword(obj.ConfirmNewPassword, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Password":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SwitchUserVM_ChangePassword_Password(obj.Password, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ConfirmNewPassword":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SwitchUserVM_ChangePassword_ConfirmNewPassword(obj.ConfirmNewPassword, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.Model.Settings.Maintenance.ChangePassword cache_SwitchUserVM_ChangePassword = null;
                public void UpdateChildListeners_SwitchUserVM_ChangePassword(global::Infonet.CStoreCommander.UI.Model.Settings.Maintenance.ChangePassword obj)
                {
                    if (obj != cache_SwitchUserVM_ChangePassword)
                    {
                        if (cache_SwitchUserVM_ChangePassword != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_SwitchUserVM_ChangePassword).PropertyChanged -= PropertyChanged_SwitchUserVM_ChangePassword;
                            cache_SwitchUserVM_ChangePassword = null;
                        }
                        if (obj != null)
                        {
                            cache_SwitchUserVM_ChangePassword = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_SwitchUserVM_ChangePassword;
                        }
                    }
                }
                public void RegisterTwoWayListener_3(global::Windows.UI.Xaml.Controls.PasswordBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.PasswordBox.PasswordProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_Password();
                        }
                    });
                }
                public void RegisterTwoWayListener_4(global::Windows.UI.Xaml.Controls.PasswordBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.PasswordBox.PasswordProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_Password();
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
            case 3: // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 77
                {
                    this.pwbNewPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4: // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 83
                {
                    this.pwbConfirmPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
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
            case 1: // View\Settings\MaintenanceOptions\SwitchUserOrChangePassword.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SwitchUserOrChangePassword_obj1_Bindings bindings = new SwitchUserOrChangePassword_obj1_Bindings();
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

