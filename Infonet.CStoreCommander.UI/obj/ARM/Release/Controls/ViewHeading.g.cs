﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\Controls\ViewHeading.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4FAB20A33A458AC3F1F10B9953A3FFD6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.Controls
{
    partial class ViewHeading : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_FontSize(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.Double value)
            {
                obj.FontSize = value;
            }
        };

        private class ViewHeading_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IViewHeading_Bindings
        {
            private global::Infonet.CStoreCommander.UI.Controls.ViewHeading dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;

            private ViewHeading_obj1_BindingsTracking bindingsTracking;

            public ViewHeading_obj1_Bindings()
            {
                this.bindingsTracking = new ViewHeading_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IViewHeading_Bindings

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

            // ViewHeading_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.Controls.ViewHeading newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_BackCommand(obj.BackCommand, phase);
                        this.Update_Text(obj.Text, phase);
                        this.Update_FontSize(obj.FontSize, phase);
                    }
                }
            }
            private void Update_BackCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                }
            }
            private void Update_Text(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_FontSize(global::System.Double obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_FontSize(this.obj3, obj);
                }
            }

            private class ViewHeading_obj1_BindingsTracking
            {
                global::System.WeakReference<ViewHeading_obj1_Bindings> WeakRefToBindingObj; 

                public ViewHeading_obj1_BindingsTracking(ViewHeading_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<ViewHeading_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_BackCommand(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    ViewHeading_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj = sender as global::Infonet.CStoreCommander.UI.Controls.ViewHeading;
        if (obj != null)
        {
            bindings.Update_BackCommand(obj.BackCommand, DATA_CHANGED);
        }
                    }
                }
                public void DependencyPropertyChanged_Text(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    ViewHeading_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj = sender as global::Infonet.CStoreCommander.UI.Controls.ViewHeading;
        if (obj != null)
        {
            bindings.Update_Text(obj.Text, DATA_CHANGED);
        }
                    }
                }
                public void DependencyPropertyChanged_FontSize(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    ViewHeading_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj = sender as global::Infonet.CStoreCommander.UI.Controls.ViewHeading;
        if (obj != null)
        {
            bindings.Update_FontSize(obj.FontSize, DATA_CHANGED);
        }
                    }
                }
                private long tokenDPC_BackCommand = 0;
                private long tokenDPC_Text = 0;
                private long tokenDPC_FontSize = 0;
                public void UpdateChildListeners_(global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj)
                {
                    ViewHeading_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.ViewHeading.BackCommandProperty, tokenDPC_BackCommand);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.ViewHeading.TextProperty, tokenDPC_Text);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.ViewHeading.FontSizeProperty, tokenDPC_FontSize);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_BackCommand = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.ViewHeading.BackCommandProperty, DependencyPropertyChanged_BackCommand);
                            tokenDPC_Text = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.ViewHeading.TextProperty, DependencyPropertyChanged_Text);
                            tokenDPC_FontSize = obj.RegisterPropertyChangedCallback(global::Infonet.CStoreCommander.UI.Controls.ViewHeading.FontSizeProperty, DependencyPropertyChanged_FontSize);
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
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    ViewHeading_obj1_Bindings bindings = new ViewHeading_obj1_Bindings();
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
