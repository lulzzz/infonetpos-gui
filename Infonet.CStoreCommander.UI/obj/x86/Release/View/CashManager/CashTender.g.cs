﻿#pragma checksum "F:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\CashManager\CashTender.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0BB717B6D347E91255F50EB05ED2AC1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.CashManager
{
    partial class CashTender : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.CommandParameter = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(global::Windows.UI.Xaml.Media.ImageBrush obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.ImageSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CashTender_obj8_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICashTender_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj8;
            private global::Windows.UI.Xaml.Controls.Button obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;
            private global::Windows.UI.Xaml.Media.ImageBrush obj11;

            private CashTender_obj8_BindingsTracking bindingsTracking;

            public CashTender_obj8_Bindings()
            {
                this.bindingsTracking = new CashTender_obj8_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // View\CashManager\CashTender.xaml line 99
                        this.obj8 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 9: // View\CashManager\CashTender.xaml line 105
                        this.obj9 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 10: // View\CashManager\CashTender.xaml line 138
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11: // View\CashManager\CashTender.xaml line 115
                        this.obj11 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj8.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // ICashTender_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_TenderCode(obj.TenderCode, phase);
                        this.Update_TenderName(obj.TenderName, phase);
                        this.Update_Image(obj.Image, phase);
                    }
                }
            }
            private void Update_TenderCode(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\CashManager\CashTender.xaml line 105
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj9, obj, null);
                }
            }
            private void Update_TenderName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\CashManager\CashTender.xaml line 138
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                }
            }
            private void Update_Image(global::Windows.UI.Xaml.Media.ImageSource obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\CashManager\CashTender.xaml line 115
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj11, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CashTender_obj8_BindingsTracking
            {
                private global::System.WeakReference<CashTender_obj8_Bindings> weakRefToBindingObj; 

                public CashTender_obj8_BindingsTracking(CashTender_obj8_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CashTender_obj8_Bindings>(obj);
                }

                public CashTender_obj8_Bindings TryGetBindingObject()
                {
                    CashTender_obj8_Bindings bindingObject = null;
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
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CashTender_obj8_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel obj = sender as global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_TenderCode(obj.TenderCode, DATA_CHANGED);
                                bindings.Update_TenderName(obj.TenderName, DATA_CHANGED);
                                bindings.Update_Image(obj.Image, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "TenderCode":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_TenderCode(obj.TenderCode, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "TenderName":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_TenderName(obj.TenderName, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Image":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Image(obj.Image, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel obj)
                {
                    CashTender_obj8_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CashTender_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICashTender_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.CashManager.CashTender dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj6;

            private CashTender_obj1_BindingsTracking bindingsTracking;

            public CashTender_obj1_Bindings()
            {
                this.bindingsTracking = new CashTender_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // View\CashManager\CashTender.xaml line 86
                        this.obj6 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // ICashTender_Bindings

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
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.CashManager.CashTender)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.CashManager.CashTender obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CashDropVM(obj.CashDropVM, phase);
                    }
                }
            }
            private void Update_CashDropVM(global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_CashDropVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CashDropVM_TenderList(obj.TenderList, phase);
                    }
                }
            }
            private void Update_CashDropVM_TenderList(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_CashDropVM_TenderList(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\CashManager\CashTender.xaml line 86
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CashTender_obj1_BindingsTracking
            {
                private global::System.WeakReference<CashTender_obj1_Bindings> weakRefToBindingObj; 

                public CashTender_obj1_BindingsTracking(CashTender_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CashTender_obj1_Bindings>(obj);
                }

                public CashTender_obj1_Bindings TryGetBindingObject()
                {
                    CashTender_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_CashDropVM(null);
                    UpdateChildListeners_CashDropVM_TenderList(null);
                }

                public void PropertyChanged_CashDropVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CashTender_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_CashDropVM_TenderList(obj.TenderList, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "TenderList":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CashDropVM_TenderList(obj.TenderList, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM cache_CashDropVM = null;
                public void UpdateChildListeners_CashDropVM(global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM obj)
                {
                    if (obj != cache_CashDropVM)
                    {
                        if (cache_CashDropVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_CashDropVM).PropertyChanged -= PropertyChanged_CashDropVM;
                            cache_CashDropVM = null;
                        }
                        if (obj != null)
                        {
                            cache_CashDropVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_CashDropVM;
                        }
                    }
                }
                public void PropertyChanged_CashDropVM_TenderList(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CashTender_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel>;
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
                public void CollectionChanged_CashDropVM_TenderList(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    CashTender_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel> cache_CashDropVM_TenderList = null;
                public void UpdateChildListeners_CashDropVM_TenderList(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel> obj)
                {
                    if (obj != cache_CashDropVM_TenderList)
                    {
                        if (cache_CashDropVM_TenderList != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_CashDropVM_TenderList).PropertyChanged -= PropertyChanged_CashDropVM_TenderList;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_CashDropVM_TenderList).CollectionChanged -= CollectionChanged_CashDropVM_TenderList;
                            cache_CashDropVM_TenderList = null;
                        }
                        if (obj != null)
                        {
                            cache_CashDropVM_TenderList = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_CashDropVM_TenderList;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_CashDropVM_TenderList;
                        }
                    }
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
            case 2: // View\CashManager\CashTender.xaml line 39
                {
                    this.QuantityButtonStyle = (global::Windows.UI.Xaml.Style)(target);
                }
                break;
            case 5: // View\CashManager\CashTender.xaml line 69
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // View\CashManager\CashTender.xaml line 86
                {
                    this.cashTenders = (global::Windows.UI.Xaml.Controls.GridView)(target);
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
            case 1: // View\CashManager\CashTender.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    CashTender_obj1_Bindings bindings = new CashTender_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 8: // View\CashManager\CashTender.xaml line 99
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element8 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    CashTender_obj8_Bindings bindings = new CashTender_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element8.DataContext);
                    element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element8, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

