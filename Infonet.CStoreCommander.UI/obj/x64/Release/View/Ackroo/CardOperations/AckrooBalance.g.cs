﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Ackroo\CardOperations\AckrooBalance.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8F7D3601402BE5A16B5A66E962503208"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Ackroo
{
    partial class AckrooBalance : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(global::MyToolkit.Extended.Controls.CustomTextBox obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.EnterPressedCommand = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
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
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        private class AckrooBalance_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAckrooBalance_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Ackroo.AckrooBalance dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::MyToolkit.Extended.Controls.CustomTextBox obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj6;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj7;

            private AckrooBalance_obj1_BindingsTracking bindingsTracking;

            public AckrooBalance_obj1_Bindings()
            {
                this.bindingsTracking = new AckrooBalance_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 7:
                        this.obj7 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IAckrooBalance_Bindings

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

            // AckrooBalance_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Ackroo.AckrooBalance newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Ackroo.AckrooBalance obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AKVM(obj.AKVM, phase);
                    }
                }
            }
            private void Update_AKVM(global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_AKVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AKVM_CardNumberCommand(obj.CardNumberCommand, phase);
                        this.Update_AKVM_BalanceInfo(obj.BalanceInfo, phase);
                        this.Update_AKVM_AckrooBalanceCommand(obj.AckrooBalanceCommand, phase);
                        this.Update_AKVM_EnableCommand(obj.EnableCommand, phase);
                        this.Update_AKVM_BackToAckrooMainCommand(obj.BackToAckrooMainCommand, phase);
                        this.Update_AKVM_AckrooPrintCommand(obj.AckrooPrintCommand, phase);
                        this.Update_AKVM_EnablePrint(obj.EnablePrint, phase);
                        this.Update_AKVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, phase);
                    }
                }
            }
            private void Update_AKVM_CardNumberCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj2, obj, null);
                }
            }
            private void Update_AKVM_BalanceInfo(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_AKVM_AckrooBalanceCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                }
            }
            private void Update_AKVM_EnableCommand(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_AKVM_BackToAckrooMainCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_AKVM_AckrooPrintCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void Update_AKVM_EnablePrint(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj6, obj);
                }
            }
            private void Update_AKVM_InvokeKeyboardCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj7, obj, null);
                }
            }

            private class AckrooBalance_obj1_BindingsTracking
            {
                global::System.WeakReference<AckrooBalance_obj1_Bindings> WeakRefToBindingObj; 

                public AckrooBalance_obj1_BindingsTracking(AckrooBalance_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<AckrooBalance_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_AKVM(null);
                }

                public void PropertyChanged_AKVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AckrooBalance_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_AKVM_CardNumberCommand(obj.CardNumberCommand, DATA_CHANGED);
                                    bindings.Update_AKVM_BalanceInfo(obj.BalanceInfo, DATA_CHANGED);
                                    bindings.Update_AKVM_AckrooBalanceCommand(obj.AckrooBalanceCommand, DATA_CHANGED);
                                    bindings.Update_AKVM_EnableCommand(obj.EnableCommand, DATA_CHANGED);
                                    bindings.Update_AKVM_BackToAckrooMainCommand(obj.BackToAckrooMainCommand, DATA_CHANGED);
                                    bindings.Update_AKVM_AckrooPrintCommand(obj.AckrooPrintCommand, DATA_CHANGED);
                                    bindings.Update_AKVM_EnablePrint(obj.EnablePrint, DATA_CHANGED);
                                    bindings.Update_AKVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CardNumberCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_CardNumberCommand(obj.CardNumberCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BalanceInfo":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_BalanceInfo(obj.BalanceInfo, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AckrooBalanceCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_AckrooBalanceCommand(obj.AckrooBalanceCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EnableCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_EnableCommand(obj.EnableCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BackToAckrooMainCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_BackToAckrooMainCommand(obj.BackToAckrooMainCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AckrooPrintCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_AckrooPrintCommand(obj.AckrooPrintCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EnablePrint":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_EnablePrint(obj.EnablePrint, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "InvokeKeyboardCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM cache_AKVM = null;
                public void UpdateChildListeners_AKVM(global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM obj)
                {
                    if (obj != cache_AKVM)
                    {
                        if (cache_AKVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_AKVM).PropertyChanged -= PropertyChanged_AKVM;
                            cache_AKVM = null;
                        }
                        if (obj != null)
                        {
                            cache_AKVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_AKVM;
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
            switch(connectionId)
            {
            case 2:
                {
                    this.CardNumberBox = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
                    AckrooBalance_obj1_Bindings bindings = new AckrooBalance_obj1_Bindings();
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
