﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Checkout\GiveXTender.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D3AEC651654EA74FC90F581C5DC7780F"
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
    partial class GiveXTender : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Infonet_CStoreCommander_UI_Controls_SecondFrameHeading_PreviousFrame(global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.PreviousFrame = value;
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
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
        };

        private class GiveXTender_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGiveXTender_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Checkout.GiveXTender dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;
            private global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBox obj6;
            private global::MyToolkit.Extended.Controls.CustomTextBox obj7;

            private GiveXTender_obj1_BindingsTracking bindingsTracking;

            public GiveXTender_obj1_Bindings()
            {
                this.bindingsTracking = new GiveXTender_obj1_BindingsTracking(this);
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
                        this.obj3 = (global::Infonet.CStoreCommander.UI.Controls.SecondFrameHeading)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 7:
                        this.obj7 = (global::MyToolkit.Extended.Controls.CustomTextBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IGiveXTender_Bindings

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

            // GiveXTender_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Checkout.GiveXTender newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Checkout.GiveXTender obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_GiveXTenderVM(obj.GiveXTenderVM, phase);
                    }
                }
            }
            private void Update_GiveXTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.GiveXTenderVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_GiveXTenderVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_GiveXTenderVM_GetSaleSummaryCommand(obj.GetSaleSummaryCommand, phase);
                        this.Update_GiveXTenderVM_AcceptCommand(obj.AcceptCommand, phase);
                        this.Update_GiveXTenderVM_AskPin(obj.AskPin, phase);
                        this.Update_GiveXTenderVM_IsCardNumberEnabled(obj.IsCardNumberEnabled, phase);
                    }
                }
            }
            private void Update_GiveXTenderVM_GetSaleSummaryCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_SecondFrameHeading_PreviousFrame(this.obj3, obj, null);
                }
            }
            private void Update_GiveXTenderVM_AcceptCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                    XamlBindingSetters.Set_MyToolkit_Extended_Controls_CustomTextBox_EnterPressedCommand(this.obj7, obj, null);
                }
            }
            private void Update_GiveXTenderVM_AskPin(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj5, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("VisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("VisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }
            private void Update_GiveXTenderVM_IsCardNumberEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj7, obj);
                }
            }

            private class GiveXTender_obj1_BindingsTracking
            {
                global::System.WeakReference<GiveXTender_obj1_Bindings> WeakRefToBindingObj; 

                public GiveXTender_obj1_BindingsTracking(GiveXTender_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<GiveXTender_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_GiveXTenderVM(null);
                }

                public void PropertyChanged_GiveXTenderVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    GiveXTender_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Checkout.GiveXTenderVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Checkout.GiveXTenderVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_GiveXTenderVM_GetSaleSummaryCommand(obj.GetSaleSummaryCommand, DATA_CHANGED);
                                    bindings.Update_GiveXTenderVM_AcceptCommand(obj.AcceptCommand, DATA_CHANGED);
                                    bindings.Update_GiveXTenderVM_AskPin(obj.AskPin, DATA_CHANGED);
                                    bindings.Update_GiveXTenderVM_IsCardNumberEnabled(obj.IsCardNumberEnabled, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "GetSaleSummaryCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_GiveXTenderVM_GetSaleSummaryCommand(obj.GetSaleSummaryCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AcceptCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_GiveXTenderVM_AcceptCommand(obj.AcceptCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AskPin":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_GiveXTenderVM_AskPin(obj.AskPin, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsCardNumberEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_GiveXTenderVM_IsCardNumberEnabled(obj.IsCardNumberEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Checkout.GiveXTenderVM cache_GiveXTenderVM = null;
                public void UpdateChildListeners_GiveXTenderVM(global::Infonet.CStoreCommander.UI.ViewModel.Checkout.GiveXTenderVM obj)
                {
                    if (obj != cache_GiveXTenderVM)
                    {
                        if (cache_GiveXTenderVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_GiveXTenderVM).PropertyChanged -= PropertyChanged_GiveXTenderVM;
                            cache_GiveXTenderVM = null;
                        }
                        if (obj != null)
                        {
                            cache_GiveXTenderVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_GiveXTenderVM;
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
            case 7:
                {
                    this.TextBox = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
                    GiveXTender_obj1_Bindings bindings = new GiveXTender_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

