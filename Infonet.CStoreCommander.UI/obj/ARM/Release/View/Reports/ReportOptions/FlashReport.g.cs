﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Reports\ReportOptions\FlashReport.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "51EB9786FDB36B94328B8A1258C18609"
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
    partial class FlashReport : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_WinRT_Triggers_InvokeCommandAction_Command(global::WinRT.Triggers.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_MyToolkit_Controls_DataGrid_ItemsSource(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Documents_Run_Text(global::Windows.UI.Xaml.Documents.Run obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class FlashReport_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IFlashReport_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.FlashReport dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::MyToolkit.Controls.DataGrid obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;
            private global::Windows.UI.Xaml.Documents.Run obj6;

            private FlashReport_obj1_BindingsTracking bindingsTracking;

            public FlashReport_obj1_Bindings()
            {
                this.bindingsTracking = new FlashReport_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 4:
                        this.obj4 = (global::MyToolkit.Controls.DataGrid)target;
                        break;
                    case 5:
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    default:
                        break;
                }
            }

            // IFlashReport_Bindings

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

            // FlashReport_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.FlashReport newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.FlashReport obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FlashReportVM(obj.FlashReportVM, phase);
                    }
                }
            }
            private void Update_FlashReportVM(global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.FlashReportVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_FlashReportVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FlashReportVM_GetReportCommand(obj.GetReportCommand, phase);
                        this.Update_FlashReportVM_FlashReport(obj.FlashReport, phase);
                        this.Update_FlashReportVM_PrintReportCommand(obj.PrintReportCommand, phase);
                        this.Update_FlashReportVM_TillNumber(obj.TillNumber, phase);
                    }
                }
            }
            private void Update_FlashReportVM_GetReportCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_FlashReportVM_FlashReport(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Reports.FlashReportModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemsSource(this.obj4, obj, null);
                }
            }
            private void Update_FlashReportVM_PrintReportCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_FlashReportVM_TillNumber(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj6, obj, null);
                }
            }

            private class FlashReport_obj1_BindingsTracking
            {
                global::System.WeakReference<FlashReport_obj1_Bindings> WeakRefToBindingObj; 

                public FlashReport_obj1_BindingsTracking(FlashReport_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<FlashReport_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_FlashReportVM(null);
                }

                public void PropertyChanged_FlashReportVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    FlashReport_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.FlashReportVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.FlashReportVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_FlashReportVM_GetReportCommand(obj.GetReportCommand, DATA_CHANGED);
                                    bindings.Update_FlashReportVM_FlashReport(obj.FlashReport, DATA_CHANGED);
                                    bindings.Update_FlashReportVM_PrintReportCommand(obj.PrintReportCommand, DATA_CHANGED);
                                    bindings.Update_FlashReportVM_TillNumber(obj.TillNumber, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "GetReportCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FlashReportVM_GetReportCommand(obj.GetReportCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "FlashReport":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FlashReportVM_FlashReport(obj.FlashReport, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "PrintReportCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FlashReportVM_PrintReportCommand(obj.PrintReportCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "TillNumber":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FlashReportVM_TillNumber(obj.TillNumber, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.FlashReportVM cache_FlashReportVM = null;
                public void UpdateChildListeners_FlashReportVM(global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.FlashReportVM obj)
                {
                    if (obj != cache_FlashReportVM)
                    {
                        if (cache_FlashReportVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_FlashReportVM).PropertyChanged -= PropertyChanged_FlashReportVM;
                            cache_FlashReportVM = null;
                        }
                        if (obj != null)
                        {
                            cache_FlashReportVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_FlashReportVM;
                        }
                    }
                }
                public void PropertyChanged_FlashReportVM_FlashReport(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    FlashReport_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Reports.FlashReportModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Reports.FlashReportModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_FlashReportVM_FlashReport(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    FlashReport_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Reports.FlashReportModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Reports.FlashReportModel>;
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
            case 3:
                {
                    this.GenericButtonStyle = (global::Windows.UI.Xaml.Style)(target);
                }
                break;
            case 4:
                {
                    this.DataGrid = (global::MyToolkit.Controls.DataGrid)(target);
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
                    FlashReport_obj1_Bindings bindings = new FlashReport_obj1_Bindings();
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

