﻿#pragma checksum "C:\Users\lina\Documents\Visual Studio 2013\HealthApp\HealthApp\HealthApp.Windows\bmi.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1AD04CDEAFCD26F1FC87816BDF1FB34C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthApp
{
    partial class bmi : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.pageRoot = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 62 "..\..\..\bmi.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element2).SelectionChanged += this.TextBlock_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.pageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 53 "..\..\..\bmi.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element5).SelectionChanged += this.TextBlock_SelectionChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.txtb2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.txtb1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\bmi.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.Button_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.bleep = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
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
            return returnValue;
        }
    }
}
