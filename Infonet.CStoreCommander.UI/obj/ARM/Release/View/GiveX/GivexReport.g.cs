﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\GiveX\GivexReport.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02CF5BDCED938F91DCC47CD0A2D67D51"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.GiveX
{
    partial class GivexReport : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
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

        private class GivexReport_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGivexReport_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.GiveX.GivexReport dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;

            private GivexReport_obj1_BindingsTracking bindingsTracking;

            public GivexReport_obj1_Bindings()
            {
                this.bindingsTracking = new GivexReport_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IGivexReport_Bindings

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

            // GivexReport_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.GiveX.GivexReport newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.GiveX.GivexReport obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_GiveXReportVM(obj.GiveXReportVM, phase);
                    }
                }
            }
            private void Update_GiveXReportVM(global::Infonet.CStoreCommander.UI.ViewModel.GiveX.GiveXReportVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_GiveXReportVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_GiveXReportVM_PrintReportCommand(obj.PrintReportCommand, phase);
                        this.Update_GiveXReportVM_ReportText(obj.ReportText, phase);
                    }
                }
            }
            private void Update_GiveXReportVM_PrintReportCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                }
            }
            private void Update_GiveXReportVM_ReportText(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }

            private class GivexReport_obj1_BindingsTracking
            {
                global::System.WeakReference<GivexReport_obj1_Bindings> WeakRefToBindingObj; 

                public GivexReport_obj1_BindingsTracking(GivexReport_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<GivexReport_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_GiveXReportVM(null);
                }

                public void PropertyChanged_GiveXReportVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    GivexReport_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.GiveX.GiveXReportVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.GiveX.GiveXReportVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_GiveXReportVM_PrintReportCommand(obj.PrintReportCommand, DATA_CHANGED);
                                    bindings.Update_GiveXReportVM_ReportText(obj.ReportText, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "PrintReportCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_GiveXReportVM_PrintReportCommand(obj.PrintReportCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ReportText":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_GiveXReportVM_ReportText(obj.ReportText, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.GiveX.GiveXReportVM cache_GiveXReportVM = null;
                public void UpdateChildListeners_GiveXReportVM(global::Infonet.CStoreCommander.UI.ViewModel.GiveX.GiveXReportVM obj)
                {
                    if (obj != cache_GiveXReportVM)
                    {
                        if (cache_GiveXReportVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_GiveXReportVM).PropertyChanged -= PropertyChanged_GiveXReportVM;
                            cache_GiveXReportVM = null;
                        }
                        if (obj != null)
                        {
                            cache_GiveXReportVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_GiveXReportVM;
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
                    GivexReport_obj1_Bindings bindings = new GivexReport_obj1_Bindings();
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

