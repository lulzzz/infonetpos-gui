﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Reports\ReportOptions\TillAuditReport.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "73ECB184FC3A2CBCC2B475BDB472D86F"
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
    partial class TillAuditReport : 
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

        private class TillAuditReport_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITillAuditReport_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.TillAuditReport dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::WinRT.Triggers.InvokeCommandAction obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;

            private TillAuditReport_obj1_BindingsTracking bindingsTracking;

            public TillAuditReport_obj1_Bindings()
            {
                this.bindingsTracking = new TillAuditReport_obj1_BindingsTracking(this);
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

            // ITillAuditReport_Bindings

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

            // TillAuditReport_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.TillAuditReport newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Reports.ReportOptions.TillAuditReport obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_TillAuditReportVM(obj.TillAuditReportVM, phase);
                    }
                }
            }
            private void Update_TillAuditReportVM(global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.TillAuditReportVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_TillAuditReportVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_TillAuditReportVM_GetTillAuditReportCommand(obj.GetTillAuditReportCommand, phase);
                        this.Update_TillAuditReportVM_PrintReportCommand(obj.PrintReportCommand, phase);
                        this.Update_TillAuditReportVM_ReportText(obj.ReportText, phase);
                    }
                }
            }
            private void Update_TillAuditReportVM_GetTillAuditReportCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_TillAuditReportVM_PrintReportCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                }
            }
            private void Update_TillAuditReportVM_ReportText(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }

            private class TillAuditReport_obj1_BindingsTracking
            {
                global::System.WeakReference<TillAuditReport_obj1_Bindings> WeakRefToBindingObj; 

                public TillAuditReport_obj1_BindingsTracking(TillAuditReport_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<TillAuditReport_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_TillAuditReportVM(null);
                }

                public void PropertyChanged_TillAuditReportVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TillAuditReport_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.TillAuditReportVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.TillAuditReportVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_TillAuditReportVM_GetTillAuditReportCommand(obj.GetTillAuditReportCommand, DATA_CHANGED);
                                    bindings.Update_TillAuditReportVM_PrintReportCommand(obj.PrintReportCommand, DATA_CHANGED);
                                    bindings.Update_TillAuditReportVM_ReportText(obj.ReportText, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "GetTillAuditReportCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_TillAuditReportVM_GetTillAuditReportCommand(obj.GetTillAuditReportCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "PrintReportCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_TillAuditReportVM_PrintReportCommand(obj.PrintReportCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ReportText":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_TillAuditReportVM_ReportText(obj.ReportText, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.TillAuditReportVM cache_TillAuditReportVM = null;
                public void UpdateChildListeners_TillAuditReportVM(global::Infonet.CStoreCommander.UI.ViewModel.Reports.ReportOptions.TillAuditReportVM obj)
                {
                    if (obj != cache_TillAuditReportVM)
                    {
                        if (cache_TillAuditReportVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_TillAuditReportVM).PropertyChanged -= PropertyChanged_TillAuditReportVM;
                            cache_TillAuditReportVM = null;
                        }
                        if (obj != null)
                        {
                            cache_TillAuditReportVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_TillAuditReportVM;
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
                    TillAuditReport_obj1_Bindings bindings = new TillAuditReport_obj1_Bindings();
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
