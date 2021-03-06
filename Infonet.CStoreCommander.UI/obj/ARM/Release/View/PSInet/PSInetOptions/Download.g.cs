﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\PSInet\PSInetOptions\Download.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "743BD322B0D8025300E92B91B69E30E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions
{
    partial class Download : 
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
        };

        private class Download_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IDownload_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.Download dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj2;

            private Download_obj1_BindingsTracking bindingsTracking;

            public Download_obj1_Bindings()
            {
                this.bindingsTracking = new Download_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            // IDownload_Bindings

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

            // Download_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.Download newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.PSInet.PSInetOptions.Download obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PaymentSourceVM(obj.PaymentSourceVM, phase);
                    }
                }
            }
            private void Update_PaymentSourceVM(global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PaymentSourceVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PaymentSourceVM_FileDownloadCommand(obj.FileDownloadCommand, phase);
                    }
                }
            }
            private void Update_PaymentSourceVM_FileDownloadCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                }
            }

            private class Download_obj1_BindingsTracking
            {
                global::System.WeakReference<Download_obj1_Bindings> WeakRefToBindingObj; 

                public Download_obj1_BindingsTracking(Download_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<Download_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_PaymentSourceVM(null);
                }

                public void PropertyChanged_PaymentSourceVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Download_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_PaymentSourceVM_FileDownloadCommand(obj.FileDownloadCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "FileDownloadCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PaymentSourceVM_FileDownloadCommand(obj.FileDownloadCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM cache_PaymentSourceVM = null;
                public void UpdateChildListeners_PaymentSourceVM(global::Infonet.CStoreCommander.UI.ViewModel.PSInet.PaymentSourceVM obj)
                {
                    if (obj != cache_PaymentSourceVM)
                    {
                        if (cache_PaymentSourceVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_PaymentSourceVM).PropertyChanged -= PropertyChanged_PaymentSourceVM;
                            cache_PaymentSourceVM = null;
                        }
                        if (obj != null)
                        {
                            cache_PaymentSourceVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_PaymentSourceVM;
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
                    Download_obj1_Bindings bindings = new Download_obj1_Bindings();
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

