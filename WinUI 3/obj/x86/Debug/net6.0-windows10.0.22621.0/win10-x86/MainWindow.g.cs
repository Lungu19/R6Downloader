﻿#pragma checksum "C:\Users\Krisz\source\repos\WinUI 3\WinUI 3\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74DF3A70948CEB5D9B08DBF27BBBE2C7C5579F06DABEFFB55E67E123D30D759A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinUI_3
{
    partial class MainWindow : 
        global::Microsoft.UI.Xaml.Window, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2306")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainWindow.xaml line 17
                {
                    this.rootFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 3: // MainWindow.xaml line 18
                {
                    this.NavigationViewControl = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.NavigationViewControl).SelectionChanged += this.NavigationView_SelectionChanged;
                }
                break;
            case 4: // MainWindow.xaml line 32
                {
                    this.SettingsButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 5: // MainWindow.xaml line 36
                {
                    this.ContentFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2306")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

