﻿#pragma checksum "E:\projects\Windows Phone\CrazyParty\CrazyParty\Bin.WP7Common\MetroTile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB8EE408C8BC2DB034E381A35AD9537F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace CrazyParty.Bin.WP7Common {
    
    
    public partial class MetroTile : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock tileTitle;
        
        internal System.Windows.Controls.TextBlock tileInfo;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/CrazyParty;component/Bin.WP7Common/MetroTile.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.tileTitle = ((System.Windows.Controls.TextBlock)(this.FindName("tileTitle")));
            this.tileInfo = ((System.Windows.Controls.TextBlock)(this.FindName("tileInfo")));
        }
    }
}

