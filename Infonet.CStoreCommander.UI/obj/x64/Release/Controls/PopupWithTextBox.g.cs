﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\Controls\PopupWithTextBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "189E07E3E4F686397EC7E484771A4BE6"
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
    partial class PopupWithTextBox : 
        global::Windows.UI.Xaml.Controls.Page, 
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
            public static void Set_MyToolkit_Extended_Controls_CustomTextBox_NumericKeyType(global::MyToolkit.Extended.Controls.CustomTextBox obj, global::MyToolkit.Extended.Controls.NumericKeyType value)
            {
                obj.NumericKeyType = value;
            }
        };

        private class PopupWithTextBox_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPopupWithTextBox_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox dataRoot;
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
            private global::MyToolkit.Extended.Controls.CustomTextBox obj10;
            private global::WinRT.Triggers.InvokeCommandAction obj11;

            private PopupWithTextBox_obj1_BindingsTracking bindingsTracking;

            public PopupWithTextBox_obj1_Bindings()
            {
                this.bindingsTracking = new PopupWithTextBox_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        ((global::Windows.UI.Xaml.Controls.Grid)target).Loaded += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.GridLoaded(param0, param1);
                        };
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)target;
                        break;
                    case 5:
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9:
                        this.obj9 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 10:
                        this.obj10 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    case 11:
                        this.obj11 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IPopupWithTextBox_Bindings

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

            // PopupWithTextBox_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BackgroundOverlay(obj.BackgroundOverlay, phase);
                        this.Update_VMBase(obj.VMBase, phase);
                        this.Update_FleetTenderVM(obj.FleetTenderVM, phase);
                        this.Update_NumericKeyType(obj.NumericKeyType, phase);
                    }
                }
            }
            private void Update_BackgroundOverlay(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj3, obj, null);
                }
            }
            private void Update_VMBase(global::Infonet.CStoreCommander.UI.ViewModel.VMBase obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_VMBase(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_VMBase_PopupService(obj.PopupService, phase);
                    }
                }
            }
            private void Update_VMBase_PopupService(global::Infonet.CStoreCommander.UI.Utility.PopupService obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_VMBase_PopupService(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_VMBase_PopupService_NoCommandOfPoNumberPopup(obj.NoCommandOfPoNumberPopup, phase);
                        this.Update_VMBase_PopupService_YesCommandOfPoNumberPopup(obj.YesCommandOfPoNumberPopup, phase);
                        this.Update_VMBase_PopupService_Title(obj.Title, phase);
                    }
                }
            }
            private void Update_VMBase_PopupService_NoCommandOfPoNumberPopup(global::System.Windows.Input.ICommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(this.obj4, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void Update_VMBase_PopupService_YesCommandOfPoNumberPopup(global::System.Windows.Input.ICommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_VMBase_PopupService_Title(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                }
            }
            private void Update_FleetTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_FleetTenderVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FleetTenderVM_EnterPressedOnTextBoxCommand(obj.EnterPressedOnTextBoxCommand, phase);
                    }
                }
            }
            private void Update_FleetTenderVM_EnterPressedOnTextBoxCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj9, obj, null);
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj11, obj, null);
                }
            }
            private void Update_NumericKeyType(global::MyToolkit.Extended.Controls.NumericKeyType obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_NumericKeyType(this.obj10, obj);
                }
            }

            private class PopupWithTextBox_obj1_BindingsTracking
            {
                global::System.WeakReference<PopupWithTextBox_obj1_Bindings> WeakRefToBindingObj; 

                public PopupWithTextBox_obj1_BindingsTracking(PopupWithTextBox_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<PopupWithTextBox_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                    UpdateChildListeners_VMBase(null);
                    UpdateChildListeners_VMBase_PopupService(null);
                    UpdateChildListeners_FleetTenderVM(null);
                }

                public void DependencyPropertyChanged_BackgroundOverlay(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    PopupWithTextBox_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox obj = sender as global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox;
        if (obj != null)
        {
            bindings.Update_BackgroundOverlay(obj.BackgroundOverlay, DATA_CHANGED);
        }
                    }
                }
                public void DependencyPropertyChanged_NumericKeyType(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    PopupWithTextBox_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox obj = sender as global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox;
        if (obj != null)
        {
            bindings.Update_NumericKeyType(obj.NumericKeyType, DATA_CHANGED);
        }
                    }
                }
                private long tokenDPC_BackgroundOverlay = 0;
                private long tokenDPC_NumericKeyType = 0;
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox obj)
                {
                    PopupWithTextBox_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox.BackgroundOverlayProperty, tokenDPC_BackgroundOverlay);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox.NumericKeyTypeProperty, tokenDPC_NumericKeyType);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_BackgroundOverlay = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox.BackgroundOverlayProperty, DependencyPropertyChanged_BackgroundOverlay);
                            tokenDPC_NumericKeyType = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.PopupWithTextBox.NumericKeyTypeProperty, DependencyPropertyChanged_NumericKeyType);
                        }
                    }
                }
                public void PropertyChanged_VMBase(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    PopupWithTextBox_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.VMBase obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.VMBase;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_VMBase_PopupService(obj.PopupService, DATA_CHANGED);
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
                                        bindings.Update_VMBase_PopupService(obj.PopupService, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.VMBase cache_VMBase = null;
                public void UpdateChildListeners_VMBase(global::Infonet.CStoreCommander.UI.ViewModel.VMBase obj)
                {
                    if (obj != cache_VMBase)
                    {
                        if (cache_VMBase != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_VMBase).PropertyChanged -= PropertyChanged_VMBase;
                            cache_VMBase = null;
                        }
                        if (obj != null)
                        {
                            cache_VMBase = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_VMBase;
                        }
                    }
                }
                public void PropertyChanged_VMBase_PopupService(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    PopupWithTextBox_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Utility.PopupService obj = sender as global::Infonet.CStoreCommander.UI.Utility.PopupService;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_VMBase_PopupService_NoCommandOfPoNumberPopup(obj.NoCommandOfPoNumberPopup, DATA_CHANGED);
                                    bindings.Update_VMBase_PopupService_YesCommandOfPoNumberPopup(obj.YesCommandOfPoNumberPopup, DATA_CHANGED);
                                    bindings.Update_VMBase_PopupService_Title(obj.Title, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "NoCommandOfPoNumberPopup":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_NoCommandOfPoNumberPopup(obj.NoCommandOfPoNumberPopup, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "YesCommandOfPoNumberPopup":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_YesCommandOfPoNumberPopup(obj.YesCommandOfPoNumberPopup, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Title":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_Title(obj.Title, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.Utility.PopupService cache_VMBase_PopupService = null;
                public void UpdateChildListeners_VMBase_PopupService(global::Infonet.CStoreCommander.UI.Utility.PopupService obj)
                {
                    if (obj != cache_VMBase_PopupService)
                    {
                        if (cache_VMBase_PopupService != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_VMBase_PopupService).PropertyChanged -= PropertyChanged_VMBase_PopupService;
                            cache_VMBase_PopupService = null;
                        }
                        if (obj != null)
                        {
                            cache_VMBase_PopupService = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_VMBase_PopupService;
                        }
                    }
                }
                public void PropertyChanged_FleetTenderVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    PopupWithTextBox_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Checkout.FleetTenderVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_FleetTenderVM_EnterPressedOnTextBoxCommand(obj.EnterPressedOnTextBoxCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "EnterPressedOnTextBoxCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FleetTenderVM_EnterPressedOnTextBoxCommand(obj.EnterPressedOnTextBoxCommand, DATA_CHANGED);
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
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.TitleText = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)(target);
                }
                break;
            case 8:
                {
                    this.pwdText = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 10:
                {
                    this.pbText = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
                    PopupWithTextBox_obj1_Bindings bindings = new PopupWithTextBox_obj1_Bindings();
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
