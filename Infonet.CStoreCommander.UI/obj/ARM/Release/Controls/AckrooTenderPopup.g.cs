﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\Controls\AckrooTenderPopup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "49544CA6FC67E07AAD1A09C4C9DF2262"
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
    partial class AckrooTenderPopup : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Border_Background(global::Windows.UI.Xaml.Controls.Border obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(global::MyToolkit.Extended.Controls.CustomTextBox obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.EnterPressedCommand = value;
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

        private class AckrooTenderPopup_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAckrooTenderPopup_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.AckrooTenderPopup dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Border obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj6;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj7;

            private AckrooTenderPopup_obj1_BindingsTracking bindingsTracking;

            public AckrooTenderPopup_obj1_Bindings()
            {
                this.bindingsTracking = new AckrooTenderPopup_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4:
                        this.obj4 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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

            // IAckrooTenderPopup_Bindings

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

            // AckrooTenderPopup_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.Controls.AckrooTenderPopup newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.AckrooTenderPopup obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BackgroundOverlay(obj.BackgroundOverlay, phase);
                        this.Update_AckrooTenderVM(obj.AckrooTenderVM, phase);
                    }
                }
            }
            private void Update_BackgroundOverlay(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj2, obj, null);
                }
            }
            private void Update_AckrooTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooTenderVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_AckrooTenderVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AckrooTenderVM_REWARD_Message(obj.REWARD_Message, phase);
                        this.Update_AckrooTenderVM_CardNumberCommand(obj.CardNumberCommand, phase);
                        this.Update_AckrooTenderVM_NotifyInfo(obj.NotifyInfo, phase);
                        this.Update_AckrooTenderVM_ClosePopupCommand(obj.ClosePopupCommand, phase);
                        this.Update_AckrooTenderVM_IsEnabled(obj.IsEnabled, phase);
                        this.Update_AckrooTenderVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, phase);
                    }
                }
            }
            private void Update_AckrooTenderVM_REWARD_Message(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_AckrooTenderVM_CardNumberCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj4, obj, null);
                }
            }
            private void Update_AckrooTenderVM_NotifyInfo(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                }
            }
            private void Update_AckrooTenderVM_ClosePopupCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void Update_AckrooTenderVM_IsEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj6, obj);
                }
            }
            private void Update_AckrooTenderVM_InvokeKeyboardCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj7, obj, null);
                }
            }

            private class AckrooTenderPopup_obj1_BindingsTracking
            {
                global::System.WeakReference<AckrooTenderPopup_obj1_Bindings> WeakRefToBindingObj; 

                public AckrooTenderPopup_obj1_BindingsTracking(AckrooTenderPopup_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<AckrooTenderPopup_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                    UpdateChildListeners_AckrooTenderVM(null);
                }

                public void DependencyPropertyChanged_BackgroundOverlay(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    AckrooTenderPopup_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Infonet.CStoreCommander.UI.Controls.AckrooTenderPopup obj = sender as global::Infonet.CStoreCommander.UI.Controls.AckrooTenderPopup;
        if (obj != null)
        {
            bindings.Update_BackgroundOverlay(obj.BackgroundOverlay, DATA_CHANGED);
        }
                    }
                }
                private long tokenDPC_BackgroundOverlay = 0;
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Controls.AckrooTenderPopup obj)
                {
                    AckrooTenderPopup_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.AckrooTenderPopup.BackgroundOverlayProperty, tokenDPC_BackgroundOverlay);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_BackgroundOverlay = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.AckrooTenderPopup.BackgroundOverlayProperty, DependencyPropertyChanged_BackgroundOverlay);
                        }
                    }
                }
                public void PropertyChanged_AckrooTenderVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AckrooTenderPopup_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooTenderVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooTenderVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_AckrooTenderVM_REWARD_Message(obj.REWARD_Message, DATA_CHANGED);
                                    bindings.Update_AckrooTenderVM_CardNumberCommand(obj.CardNumberCommand, DATA_CHANGED);
                                    bindings.Update_AckrooTenderVM_NotifyInfo(obj.NotifyInfo, DATA_CHANGED);
                                    bindings.Update_AckrooTenderVM_ClosePopupCommand(obj.ClosePopupCommand, DATA_CHANGED);
                                    bindings.Update_AckrooTenderVM_IsEnabled(obj.IsEnabled, DATA_CHANGED);
                                    bindings.Update_AckrooTenderVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "REWARD_Message":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AckrooTenderVM_REWARD_Message(obj.REWARD_Message, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CardNumberCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AckrooTenderVM_CardNumberCommand(obj.CardNumberCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "NotifyInfo":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AckrooTenderVM_NotifyInfo(obj.NotifyInfo, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ClosePopupCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AckrooTenderVM_ClosePopupCommand(obj.ClosePopupCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AckrooTenderVM_IsEnabled(obj.IsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "InvokeKeyboardCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AckrooTenderVM_InvokeKeyboardCommand(obj.InvokeKeyboardCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooTenderVM cache_AckrooTenderVM = null;
                public void UpdateChildListeners_AckrooTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooTenderVM obj)
                {
                    if (obj != cache_AckrooTenderVM)
                    {
                        if (cache_AckrooTenderVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_AckrooTenderVM).PropertyChanged -= PropertyChanged_AckrooTenderVM;
                            cache_AckrooTenderVM = null;
                        }
                        if (obj != null)
                        {
                            cache_AckrooTenderVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_AckrooTenderVM;
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
            case 4:
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
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    AckrooTenderPopup_obj1_Bindings bindings = new AckrooTenderPopup_obj1_Bindings();
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
