﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Ackroo\CardOperations\AckrooMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "565A761287AA878417B2F795F3214F62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Ackroo
{
    partial class AckrooMenu : 
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

        private class AckrooMenu_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAckrooMenu_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Ackroo.AckrooMenu dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj2;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj6;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj7;

            private AckrooMenu_obj1_BindingsTracking bindingsTracking;

            public AckrooMenu_obj1_Bindings()
            {
                this.bindingsTracking = new AckrooMenu_obj1_BindingsTracking(this);
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
                        this.obj3 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 7:
                        this.obj7 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    default:
                        break;
                }
            }

            // IAckrooMenu_Bindings

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

            // AckrooMenu_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Ackroo.AckrooMenu newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Ackroo.AckrooMenu obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AKVM(obj.AKVM, phase);
                    }
                }
            }
            private void Update_AKVM(global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_AKVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AKVM_AckrCheckBalanceCommand(obj.AckrCheckBalanceCommand, phase);
                        this.Update_AKVM_AckrMenuToCarwashCommand(obj.AckrMenuToCarwashCommand, phase);
                        this.Update_AKVM_AckrMenuToActivateCardCommand(obj.AckrMenuToActivateCardCommand, phase);
                        this.Update_AKVM_AckrMenuToIncreasefundCommand(obj.AckrMenuToIncreasefundCommand, phase);
                    }
                }
            }
            private void Update_AKVM_AckrCheckBalanceCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj7, obj, null);
                }
            }
            private void Update_AKVM_AckrMenuToCarwashCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj3, obj, null);
                }
            }
            private void Update_AKVM_AckrMenuToActivateCardCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_AKVM_AckrMenuToIncreasefundCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }

            private class AckrooMenu_obj1_BindingsTracking
            {
                global::System.WeakReference<AckrooMenu_obj1_Bindings> WeakRefToBindingObj; 

                public AckrooMenu_obj1_BindingsTracking(AckrooMenu_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<AckrooMenu_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_AKVM(null);
                }

                public void PropertyChanged_AKVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AckrooMenu_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_AKVM_AckrCheckBalanceCommand(obj.AckrCheckBalanceCommand, DATA_CHANGED);
                                    bindings.Update_AKVM_AckrMenuToCarwashCommand(obj.AckrMenuToCarwashCommand, DATA_CHANGED);
                                    bindings.Update_AKVM_AckrMenuToActivateCardCommand(obj.AckrMenuToActivateCardCommand, DATA_CHANGED);
                                    bindings.Update_AKVM_AckrMenuToIncreasefundCommand(obj.AckrMenuToIncreasefundCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "AckrCheckBalanceCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_AckrCheckBalanceCommand(obj.AckrCheckBalanceCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AckrMenuToCarwashCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_AckrMenuToCarwashCommand(obj.AckrMenuToCarwashCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AckrMenuToActivateCardCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_AckrMenuToActivateCardCommand(obj.AckrMenuToActivateCardCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AckrMenuToIncreasefundCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AKVM_AckrMenuToIncreasefundCommand(obj.AckrMenuToIncreasefundCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM cache_AKVM = null;
                public void UpdateChildListeners_AKVM(global::Infonet.CStoreCommander.UI.ViewModel.Ackroo.AckrooVM obj)
                {
                    if (obj != cache_AKVM)
                    {
                        if (cache_AKVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_AKVM).PropertyChanged -= PropertyChanged_AKVM;
                            cache_AKVM = null;
                        }
                        if (obj != null)
                        {
                            cache_AKVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_AKVM;
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
                    AckrooMenu_obj1_Bindings bindings = new AckrooMenu_obj1_Bindings();
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

