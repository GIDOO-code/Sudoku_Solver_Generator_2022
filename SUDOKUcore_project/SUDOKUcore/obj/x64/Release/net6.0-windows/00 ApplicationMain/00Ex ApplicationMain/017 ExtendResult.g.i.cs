﻿#pragma checksum "..\..\..\..\..\..\00 ApplicationMain\00Ex ApplicationMain\017 ExtendResult.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6EB13E4EC9B58E2684D4DDFB6268484C5183B1DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GNPXcore {
    
    
    /// <summary>
    /// ExtendResultWin
    /// </summary>
    public partial class ExtendResultWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\..\..\00 ApplicationMain\00Ex ApplicationMain\017 ExtendResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GNPXcore.ExtendResultWin devWin;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\..\..\..\..\00 ApplicationMain\00Ex ApplicationMain\017 ExtendResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GNPXGNPX;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\..\..\00 ApplicationMain\00Ex ApplicationMain\017 ExtendResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button devWinClose;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\00 ApplicationMain\00Ex ApplicationMain\017 ExtendResult.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ExtRes;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SUDOKU_Regular;component/00%20applicationmain/00ex%20applicationmain/017%20exten" +
                    "dresult.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\00 ApplicationMain\00Ex ApplicationMain\017 ExtendResult.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.devWin = ((GNPXcore.ExtendResultWin)(target));
            return;
            case 2:
            this.GNPXGNPX = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.devWinClose = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\..\..\..\00 ApplicationMain\00Ex ApplicationMain\017 ExtendResult.xaml"
            this.devWinClose.Click += new System.Windows.RoutedEventHandler(this.devWinClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ExtRes = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

