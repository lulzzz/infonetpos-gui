﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\Sale\BottleItems.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47D5BFCD57E3D3C5A8A0E97A14EA0A3E"
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
    partial class BottleItems : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        private class BottleItems_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IBottleItems_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Sale.BottleItems dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Pivot obj3;

            private BottleItems_obj1_BindingsTracking bindingsTracking;

            public BottleItems_obj1_Bindings()
            {
                this.bindingsTracking = new BottleItems_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Pivot)target;
                        break;
                    default:
                        break;
                }
            }

            // IBottleItems_Bindings

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

            // BottleItems_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.Sale.BottleItems newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Sale.BottleItems obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BottleReturnsScreenVM(obj.BottleReturnsScreenVM, phase);
                    }
                }
            }
            private void Update_BottleReturnsScreenVM(global::Infonet.CStoreCommander.UI.ViewModel.Sale.BottleReturnsScreenVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_BottleReturnsScreenVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BottleReturnsScreenVM_Bottles(obj.Bottles, phase);
                    }
                }
            }
            private void Update_BottleReturnsScreenVM_Bottles(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Sale.BottleModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                }
            }

            private class BottleItems_obj1_BindingsTracking
            {
                global::System.WeakReference<BottleItems_obj1_Bindings> WeakRefToBindingObj; 

                public BottleItems_obj1_BindingsTracking(BottleItems_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<BottleItems_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_BottleReturnsScreenVM(null);
                }

                public void PropertyChanged_BottleReturnsScreenVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    BottleItems_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Sale.BottleReturnsScreenVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Sale.BottleReturnsScreenVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_BottleReturnsScreenVM_Bottles(obj.Bottles, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Bottles":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_BottleReturnsScreenVM_Bottles(obj.Bottles, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Sale.BottleReturnsScreenVM cache_BottleReturnsScreenVM = null;
                public void UpdateChildListeners_BottleReturnsScreenVM(global::Infonet.CStoreCommander.UI.ViewModel.Sale.BottleReturnsScreenVM obj)
                {
                    if (obj != cache_BottleReturnsScreenVM)
                    {
                        if (cache_BottleReturnsScreenVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_BottleReturnsScreenVM).PropertyChanged -= PropertyChanged_BottleReturnsScreenVM;
                            cache_BottleReturnsScreenVM = null;
                        }
                        if (obj != null)
                        {
                            cache_BottleReturnsScreenVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_BottleReturnsScreenVM;
                        }
                    }
                }
                public void PropertyChanged_BottleReturnsScreenVM_Bottles(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    BottleItems_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Sale.BottleModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Sale.BottleModel>;
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
                public void CollectionChanged_BottleReturnsScreenVM_Bottles(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    BottleItems_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Sale.BottleModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Sale.BottleModel>;
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
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
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
                    BottleItems_obj1_Bindings bindings = new BottleItems_obj1_Bindings();
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

