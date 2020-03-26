﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Reports\ReportOptions\Report.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6DD13D7C048AC7AD0F0DB02BEFF49020"
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
    partial class Report : 
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

        private class Report_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IReport_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.Report dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;

            private Report_obj1_BindingsTracking bindingsTracking;

            public Report_obj1_Bindings()
            {
                this.bindingsTracking = new Report_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    case 3:
                        this.obj3 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IReport_Bindings

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

            // Report_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.Report newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.Report obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ReportVM(obj.ReportVM, phase);
                    }
                }
            }
            private void Update_ReportVM(global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.ReportVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ReportVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ReportVM_GetReportCommand(obj.GetReportCommand, phase);
                        this.Update_ReportVM_PrintReportCommand(obj.PrintReportCommand, phase);
                        this.Update_ReportVM_ReportText(obj.ReportText, phase);
                    }
                }
            }
            private void Update_ReportVM_GetReportCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_ReportVM_PrintReportCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                }
            }
            private void Update_ReportVM_ReportText(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }

            private class Report_obj1_BindingsTracking
            {
                global::System.WeakReference<Report_obj1_Bindings> WeakRefToBindingObj; 

                public Report_obj1_BindingsTracking(Report_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<Report_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ReportVM(null);
                }

                public void PropertyChanged_ReportVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Report_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.ReportVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.ReportVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_ReportVM_GetReportCommand(obj.GetReportCommand, DATA_CHANGED);
                                    bindings.Update_ReportVM_PrintReportCommand(obj.PrintReportCommand, DATA_CHANGED);
                                    bindings.Update_ReportVM_ReportText(obj.ReportText, DATA_CHANGED);
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
                                        bindings.Update_ReportVM_GetReportCommand(obj.GetReportCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "PrintReportCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReportVM_PrintReportCommand(obj.PrintReportCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ReportText":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReportVM_ReportText(obj.ReportText, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.ReportVM cache_ReportVM = null;
                public void UpdateChildListeners_ReportVM(global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.ReportVM obj)
                {
                    if (obj != cache_ReportVM)
                    {
                        if (cache_ReportVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ReportVM).PropertyChanged -= PropertyChanged_ReportVM;
                            cache_ReportVM = null;
                        }
                        if (obj != null)
                        {
                            cache_ReportVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ReportVM;
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
                    Report_obj1_Bindings bindings = new Report_obj1_Bindings();
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

