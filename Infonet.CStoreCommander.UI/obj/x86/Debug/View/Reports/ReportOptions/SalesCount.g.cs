﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\View\Reports\ReportOptions\SalesCount.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "756A75E5A1C30D1A05ED9FDF3A64AC19"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Reports.ReportOptions
{
    partial class SalesCount : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_WinRT_Triggers_InvokeCommandAction_Command(global::WinRT.Triggers.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SalesCount_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISalesCount_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.SalesCount dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj3;
            private global::Windows.UI.Xaml.Controls.ComboBox obj4;
            private global::Windows.UI.Xaml.Controls.ComboBox obj5;
            private global::Windows.UI.Xaml.Controls.ComboBox obj6;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2CommandDisabled = false;
            private static bool isobj3CommandDisabled = false;
            private static bool isobj4SelectedIndexDisabled = false;
            private static bool isobj4ItemsSourceDisabled = false;
            private static bool isobj5SelectedIndexDisabled = false;
            private static bool isobj5ItemsSourceDisabled = false;
            private static bool isobj6ItemsSourceDisabled = false;
            private static bool isobj6SelectedIndexDisabled = false;

            private SalesCount_obj1_BindingsTracking bindingsTracking;

            public SalesCount_obj1_Bindings()
            {
                this.bindingsTracking = new SalesCount_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 16 && columnNumber == 43)
                {
                    isobj2CommandDisabled = true;
                }
                else if (lineNumber == 88 && columnNumber == 39)
                {
                    isobj3CommandDisabled = true;
                }
                else if (lineNumber == 55 && columnNumber == 23)
                {
                    isobj4SelectedIndexDisabled = true;
                }
                else if (lineNumber == 57 && columnNumber == 23)
                {
                    isobj4ItemsSourceDisabled = true;
                }
                else if (lineNumber == 66 && columnNumber == 23)
                {
                    isobj5SelectedIndexDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 23)
                {
                    isobj5ItemsSourceDisabled = true;
                }
                else if (lineNumber == 76 && columnNumber == 23)
                {
                    isobj6ItemsSourceDisabled = true;
                }
                else if (lineNumber == 77 && columnNumber == 23)
                {
                    isobj6SelectedIndexDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\Reports\ReportOptions\SalesCount.xaml line 16
                        this.obj2 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 3: // View\Reports\ReportOptions\SalesCount.xaml line 85
                        this.obj3 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 4: // View\Reports\ReportOptions\SalesCount.xaml line 52
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // View\Reports\ReportOptions\SalesCount.xaml line 62
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    case 6: // View\Reports\ReportOptions\SalesCount.xaml line 72
                        this.obj6 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_6(this.obj6);
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

            // ISalesCount_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.SalesCount)newDataRoot;
                    return true;
                }
                return false;
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
            private void Update_(global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.SalesCount obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SalesCountVM(obj.SalesCountVM, phase);
                    }
                }
            }
            private void Update_SalesCountVM(global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.SalesCountVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SalesCountVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SalesCountVM_LoadAllDataCommand(obj.LoadAllDataCommand, phase);
                        this.Update_SalesCountVM_RunReportCommand(obj.RunReportCommand, phase);
                        this.Update_SalesCountVM_SelectedDepartmentIndex(obj.SelectedDepartmentIndex, phase);
                        this.Update_SalesCountVM_Departments(obj.Departments, phase);
                        this.Update_SalesCountVM_SelectedTillIndex(obj.SelectedTillIndex, phase);
                        this.Update_SalesCountVM_Tills(obj.Tills, phase);
                        this.Update_SalesCountVM_Shifts(obj.Shifts, phase);
                        this.Update_SalesCountVM_SelectedShiftIndex(obj.SelectedShiftIndex, phase);
                    }
                }
            }
            private void Update_SalesCountVM_LoadAllDataCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Reports\ReportOptions\SalesCount.xaml line 16
                    if (!isobj2CommandDisabled)
                    {
                        XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                    }
                }
            }
            private void Update_SalesCountVM_RunReportCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Reports\ReportOptions\SalesCount.xaml line 85
                    if (!isobj3CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                    }
                }
            }
            private void Update_SalesCountVM_SelectedDepartmentIndex(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Reports\ReportOptions\SalesCount.xaml line 52
                    if (!isobj4SelectedIndexDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj4, (global::System.Int32)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Int32), null, null));
                    }
                }
            }
            private void Update_SalesCountVM_Departments(global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Reports\ReportOptions\SalesCount.xaml line 52
                    if (!isobj4ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                    }
                }
            }
            private void Update_SalesCountVM_SelectedTillIndex(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Reports\ReportOptions\SalesCount.xaml line 62
                    if (!isobj5SelectedIndexDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj5, (global::System.Int32)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Int32), null, null));
                    }
                }
            }
            private void Update_SalesCountVM_Tills(global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Reports\ReportOptions\SalesCount.xaml line 62
                    if (!isobj5ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                    }
                }
            }
            private void Update_SalesCountVM_Shifts(global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Reports\ReportOptions\SalesCount.xaml line 72
                    if (!isobj6ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                    }
                }
            }
            private void Update_SalesCountVM_SelectedShiftIndex(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Reports\ReportOptions\SalesCount.xaml line 72
                    if (!isobj6SelectedIndexDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj6, (global::System.Int32)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Int32), null, null));
                    }
                }
            }
            private void UpdateTwoWay_4_SelectedIndex()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.SalesCountVM != null)
                        {
                            this.dataRoot.SalesCountVM.SelectedDepartmentIndex = (global::System.Int32)this.LookupConverter("NothingConverter").ConvertBack(this.obj4.SelectedIndex, typeof(global::System.Int32), null, null);
                        }
                    }
                }
            }
            private void UpdateTwoWay_5_SelectedIndex()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.SalesCountVM != null)
                        {
                            this.dataRoot.SalesCountVM.SelectedTillIndex = (global::System.Int32)this.LookupConverter("NothingConverter").ConvertBack(this.obj5.SelectedIndex, typeof(global::System.Int32), null, null);
                        }
                    }
                }
            }
            private void UpdateTwoWay_6_SelectedIndex()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.SalesCountVM != null)
                        {
                            this.dataRoot.SalesCountVM.SelectedShiftIndex = (global::System.Int32)this.LookupConverter("NothingConverter").ConvertBack(this.obj6.SelectedIndex, typeof(global::System.Int32), null, null);
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SalesCount_obj1_BindingsTracking
            {
                private global::System.WeakReference<SalesCount_obj1_Bindings> weakRefToBindingObj; 

                public SalesCount_obj1_BindingsTracking(SalesCount_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SalesCount_obj1_Bindings>(obj);
                }

                public SalesCount_obj1_Bindings TryGetBindingObject()
                {
                    SalesCount_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_SalesCountVM(null);
                }

                public void PropertyChanged_SalesCountVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SalesCount_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.SalesCountVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.SalesCountVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_SalesCountVM_LoadAllDataCommand(obj.LoadAllDataCommand, DATA_CHANGED);
                                bindings.Update_SalesCountVM_RunReportCommand(obj.RunReportCommand, DATA_CHANGED);
                                bindings.Update_SalesCountVM_SelectedDepartmentIndex(obj.SelectedDepartmentIndex, DATA_CHANGED);
                                bindings.Update_SalesCountVM_Departments(obj.Departments, DATA_CHANGED);
                                bindings.Update_SalesCountVM_SelectedTillIndex(obj.SelectedTillIndex, DATA_CHANGED);
                                bindings.Update_SalesCountVM_Tills(obj.Tills, DATA_CHANGED);
                                bindings.Update_SalesCountVM_Shifts(obj.Shifts, DATA_CHANGED);
                                bindings.Update_SalesCountVM_SelectedShiftIndex(obj.SelectedShiftIndex, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "LoadAllDataCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SalesCountVM_LoadAllDataCommand(obj.LoadAllDataCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "RunReportCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SalesCountVM_RunReportCommand(obj.RunReportCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedDepartmentIndex":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SalesCountVM_SelectedDepartmentIndex(obj.SelectedDepartmentIndex, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Departments":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SalesCountVM_Departments(obj.Departments, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedTillIndex":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SalesCountVM_SelectedTillIndex(obj.SelectedTillIndex, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Tills":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SalesCountVM_Tills(obj.Tills, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Shifts":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SalesCountVM_Shifts(obj.Shifts, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedShiftIndex":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SalesCountVM_SelectedShiftIndex(obj.SelectedShiftIndex, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.SalesCountVM cache_SalesCountVM = null;
                public void UpdateChildListeners_SalesCountVM(global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.SalesCountVM obj)
                {
                    if (obj != cache_SalesCountVM)
                    {
                        if (cache_SalesCountVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_SalesCountVM).PropertyChanged -= PropertyChanged_SalesCountVM;
                            cache_SalesCountVM = null;
                        }
                        if (obj != null)
                        {
                            cache_SalesCountVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_SalesCountVM;
                        }
                    }
                }
                public void RegisterTwoWayListener_4(global::Windows.UI.Xaml.Controls.ComboBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_SelectedIndex();
                        }
                    });
                }
                public void RegisterTwoWayListener_5(global::Windows.UI.Xaml.Controls.ComboBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_SelectedIndex();
                        }
                    });
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
            case 4: // View\Reports\ReportOptions\SalesCount.xaml line 52
                {
                    this.department = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 5: // View\Reports\ReportOptions\SalesCount.xaml line 62
                {
                    this.cbTill = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 6: // View\Reports\ReportOptions\SalesCount.xaml line 72
                {
                    this.cbShift = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
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
            case 1: // View\Reports\ReportOptions\SalesCount.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SalesCount_obj1_Bindings bindings = new SalesCount_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
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

