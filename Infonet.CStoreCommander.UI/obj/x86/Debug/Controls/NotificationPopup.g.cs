﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\Controls\NotificationPopup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9DA9A13CFBCD5926188DFCCEF57C6B19"
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
    partial class NotificationPopup : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
            public static void Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_Text(global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.CancelCommand = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Infonet_CStoreCommander_ControlLib_GenericButton_BottomBackGroundColor(global::Infonet.CStoreCommander.ControlLib.GenericButton obj, global::Windows.UI.Xaml.Media.SolidColorBrush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.SolidColorBrush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.SolidColorBrush), targetNullValue);
                }
                obj.BottomBackGroundColor = value;
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
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class NotificationPopup_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            INotificationPopup_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.NotificationPopup dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Border obj2;
            private global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2BackgroundDisabled = false;
            private static bool isobj3TextDisabled = false;
            private static bool isobj3CancelCommandDisabled = false;
            private static bool isobj4TextDisabled = false;
            private static bool isobj5BottomBackGroundColorDisabled = false;
            private static bool isobj5CommandDisabled = false;
            private static bool isobj5IsEnabledDisabled = false;
            private static bool isobj5ContentDisabled = false;

            private NotificationPopup_obj1_BindingsTracking bindingsTracking;

            public NotificationPopup_obj1_Bindings()
            {
                this.bindingsTracking = new NotificationPopup_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 17 && columnNumber == 17)
                {
                    isobj2BackgroundDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 37)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 32 && columnNumber == 37)
                {
                    isobj3CancelCommandDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 28)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 49 && columnNumber == 43)
                {
                    isobj5BottomBackGroundColorDisabled = true;
                }
                else if (lineNumber == 50 && columnNumber == 43)
                {
                    isobj5CommandDisabled = true;
                }
                else if (lineNumber == 56 && columnNumber == 43)
                {
                    isobj5IsEnabledDisabled = true;
                }
                else if (lineNumber == 57 && columnNumber == 43)
                {
                    isobj5ContentDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\NotificationPopup.xaml line 15
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 3: // Controls\NotificationPopup.xaml line 30
                        this.obj3 = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)target;
                        break;
                    case 4: // Controls\NotificationPopup.xaml line 39
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5: // Controls\NotificationPopup.xaml line 49
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

            // INotificationPopup_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.Controls.NotificationPopup)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.NotificationPopup obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BackgroundOverlay(obj.BackgroundOverlay, phase);
                        this.Update_VMBase(obj.VMBase, phase);
                        this.Update_ButtonBackgroundColor(obj.ButtonBackgroundColor, phase);
                    }
                }
            }
            private void Update_BackgroundOverlay(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\NotificationPopup.xaml line 15
                    if (!isobj2BackgroundDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj2, obj, null);
                    }
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
                        this.Update_VMBase_PopupService_Title(obj.Title, phase);
                        this.Update_VMBase_PopupService_CloseCommand(obj.CloseCommand, phase);
                        this.Update_VMBase_PopupService_Message(obj.Message, phase);
                        this.Update_VMBase_PopupService_OkCommand(obj.OkCommand, phase);
                        this.Update_VMBase_PopupService_IsOkButtonEnabled(obj.IsOkButtonEnabled, phase);
                        this.Update_VMBase_PopupService_Continue(obj.Continue, phase);
                    }
                }
            }
            private void Update_VMBase_PopupService_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\NotificationPopup.xaml line 30
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_Text(this.obj3, obj, null);
                    }
                }
            }
            private void Update_VMBase_PopupService_CloseCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\NotificationPopup.xaml line 30
                    if (!isobj3CancelCommandDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SmallPopupHeader_CancelCommand(this.obj3, obj, null);
                    }
                }
            }
            private void Update_VMBase_PopupService_Message(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\NotificationPopup.xaml line 39
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ButtonBackgroundColor(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\NotificationPopup.xaml line 49
                    if (!isobj5BottomBackGroundColorDisabled)
                    {
                        XamlBindingSetters.Set_Infonet_CStoreCommander_ControlLib_GenericButton_BottomBackGroundColor(this.obj5, obj, null);
                    }
                }
            }
            private void Update_VMBase_PopupService_OkCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\NotificationPopup.xaml line 49
                    if (!isobj5CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                    }
                }
            }
            private void Update_VMBase_PopupService_IsOkButtonEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\NotificationPopup.xaml line 49
                    if (!isobj5IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj5, obj);
                    }
                }
            }
            private void Update_VMBase_PopupService_Continue(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\NotificationPopup.xaml line 49
                    if (!isobj5ContentDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj5, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class NotificationPopup_obj1_BindingsTracking
            {
                private global::System.WeakReference<NotificationPopup_obj1_Bindings> weakRefToBindingObj; 

                public NotificationPopup_obj1_BindingsTracking(NotificationPopup_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<NotificationPopup_obj1_Bindings>(obj);
                }

                public NotificationPopup_obj1_Bindings TryGetBindingObject()
                {
                    NotificationPopup_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_VMBase(null);
                    UpdateChildListeners_VMBase_PopupService(null);
                }

                public void DependencyPropertyChanged_BackgroundOverlay(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    NotificationPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.NotificationPopup obj = sender as global::Infonet.CStoreCommander.UI.Controls.NotificationPopup;
                        if (obj != null)
                        {
                            bindings.Update_BackgroundOverlay(obj.BackgroundOverlay, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ButtonBackgroundColor(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    NotificationPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Infonet.CStoreCommander.UI.Controls.NotificationPopup obj = sender as global::Infonet.CStoreCommander.UI.Controls.NotificationPopup;
                        if (obj != null)
                        {
                            bindings.Update_ButtonBackgroundColor(obj.ButtonBackgroundColor, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_BackgroundOverlay = 0;
                private long tokenDPC_ButtonBackgroundColor = 0;
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Controls.NotificationPopup obj)
                {
                    NotificationPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.NotificationPopup.BackgroundOverlayProperty, tokenDPC_BackgroundOverlay);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.NotificationPopup.ButtonBackgroundColorProperty, tokenDPC_ButtonBackgroundColor);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_BackgroundOverlay = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.NotificationPopup.BackgroundOverlayProperty, DependencyPropertyChanged_BackgroundOverlay);
                            tokenDPC_ButtonBackgroundColor = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.NotificationPopup.ButtonBackgroundColorProperty, DependencyPropertyChanged_ButtonBackgroundColor);
                        }
                    }
                }
                public void PropertyChanged_VMBase(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    NotificationPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
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
                    NotificationPopup_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Utility.PopupService obj = sender as global::Infonet.CStoreCommander.UI.Utility.PopupService;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_VMBase_PopupService_Title(obj.Title, DATA_CHANGED);
                                bindings.Update_VMBase_PopupService_CloseCommand(obj.CloseCommand, DATA_CHANGED);
                                bindings.Update_VMBase_PopupService_Message(obj.Message, DATA_CHANGED);
                                bindings.Update_VMBase_PopupService_OkCommand(obj.OkCommand, DATA_CHANGED);
                                bindings.Update_VMBase_PopupService_IsOkButtonEnabled(obj.IsOkButtonEnabled, DATA_CHANGED);
                                bindings.Update_VMBase_PopupService_Continue(obj.Continue, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Title":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_Title(obj.Title, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CloseCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_CloseCommand(obj.CloseCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Message":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_Message(obj.Message, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "OkCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_OkCommand(obj.OkCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsOkButtonEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_IsOkButtonEnabled(obj.IsOkButtonEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Continue":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_VMBase_PopupService_Continue(obj.Continue, DATA_CHANGED);
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
            case 3: // Controls\NotificationPopup.xaml line 30
                {
                    this.TitleText = (global::Infonet.CStoreCommander.UI.Controls.SmallPopupHeader)(target);
                }
                break;
            case 5: // Controls\NotificationPopup.xaml line 49
                {
                    this.OkButton = (global::Infonet.CStoreCommander.ControlLib.GenericButton)(target);
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
            case 1: // Controls\NotificationPopup.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    NotificationPopup_obj1_Bindings bindings = new NotificationPopup_obj1_Bindings();
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

