﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Sale\GiftCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "437075B40989EF81FAA3A43EB39DC880"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Sale
{
    partial class GiftCard : 
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
            public static void Set_WinRT_Triggers_InvokeCommandAction_Command(global::WinRT.Triggers.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        private class GiftCard_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGiftCard_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Sale.GiftCard dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj2;
            private global::WinRT.Triggers.InvokeCommandAction obj6;

            private GiftCard_obj1_BindingsTracking bindingsTracking;

            public GiftCard_obj1_Bindings()
            {
                this.bindingsTracking = new GiftCard_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::WinRT.Triggers.InvokeCommandAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IGiftCard_Bindings

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

            // GiftCard_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Sale.GiftCard newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Sale.GiftCard obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SaleGridVM(obj.SaleGridVM, phase);
                    }
                }
            }
            private void Update_SaleGridVM(global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SaleGridVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SaleGridVM_AddStockItemForSaleCommand(obj.AddStockItemForSaleCommand, phase);
                        this.Update_SaleGridVM_EnterPressedOnQuantityCommand(obj.EnterPressedOnQuantityCommand, phase);
                    }
                }
            }
            private void Update_SaleGridVM_AddStockItemForSaleCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                }
            }
            private void Update_SaleGridVM_EnterPressedOnQuantityCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_WinRT_Triggers_InvokeCommandAction_Command(this.obj6, obj, null);
                }
            }

            private class GiftCard_obj1_BindingsTracking
            {
                global::System.WeakReference<GiftCard_obj1_Bindings> WeakRefToBindingObj; 

                public GiftCard_obj1_BindingsTracking(GiftCard_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<GiftCard_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_SaleGridVM(null);
                }

                public void PropertyChanged_SaleGridVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    GiftCard_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_SaleGridVM_AddStockItemForSaleCommand(obj.AddStockItemForSaleCommand, DATA_CHANGED);
                                    bindings.Update_SaleGridVM_EnterPressedOnQuantityCommand(obj.EnterPressedOnQuantityCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "AddStockItemForSaleCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_AddStockItemForSaleCommand(obj.AddStockItemForSaleCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EnterPressedOnQuantityCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_SaleGridVM_EnterPressedOnQuantityCommand(obj.EnterPressedOnQuantityCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM cache_SaleGridVM = null;
                public void UpdateChildListeners_SaleGridVM(global::Infonet.CStoreCommander.UI.ViewModel.Sale.SaleGridVM obj)
                {
                    if (obj != cache_SaleGridVM)
                    {
                        if (cache_SaleGridVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_SaleGridVM).PropertyChanged -= PropertyChanged_SaleGridVM;
                            cache_SaleGridVM = null;
                        }
                        if (obj != null)
                        {
                            cache_SaleGridVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_SaleGridVM;
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
            case 3:
                {
                    this.txtGiftNumber = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
                }
                break;
            case 4:
                {
                    this.txtPrice = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
                }
                break;
            case 5:
                {
                    this.txtQuantity = (global::MyToolkit.Extended.Controls.CustomTextBox)(target);
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
                    GiftCard_obj1_Bindings bindings = new GiftCard_obj1_Bindings();
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

