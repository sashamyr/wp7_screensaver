﻿#pragma checksum "C:\Users\sasha\documents\visual studio 2010\Projects\SashaScreensaver\SashaScreensaver\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8EEA772DEF1E615B8B60F5FDC776D9DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SashaScreensaver {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock myDateBox;
        
        internal System.Windows.Controls.TextBlock myTimeBox;
        
        internal System.Windows.Controls.Canvas settingsCanvas;
        
        internal System.Windows.Controls.TextBlock settingsTextBlock;
        
        internal System.Windows.Controls.TextBlock bgChangeTextBlock;
        
        internal System.Windows.Controls.Button myBgButton;
        
        internal System.Windows.Controls.Button canvasCloseButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SashaScreensaver;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.myDateBox = ((System.Windows.Controls.TextBlock)(this.FindName("myDateBox")));
            this.myTimeBox = ((System.Windows.Controls.TextBlock)(this.FindName("myTimeBox")));
            this.settingsCanvas = ((System.Windows.Controls.Canvas)(this.FindName("settingsCanvas")));
            this.settingsTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("settingsTextBlock")));
            this.bgChangeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("bgChangeTextBlock")));
            this.myBgButton = ((System.Windows.Controls.Button)(this.FindName("myBgButton")));
            this.canvasCloseButton = ((System.Windows.Controls.Button)(this.FindName("canvasCloseButton")));
        }
    }
}

