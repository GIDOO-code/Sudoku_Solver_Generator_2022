﻿#pragma checksum "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FC1304A1438D77103FFC586D690E8B912A8EEB2F"
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


namespace VisualPrint {
    
    
    /// <summary>
    /// PreviewWindow
    /// </summary>
    public partial class PreviewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu PrintMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel DocumentPanel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentReader Viewer;
        
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
            System.Uri resourceLocater = new System.Uri("/SUDOKU_Regular;V1.0.0.0;component/10%20graphics/11%20wpfcolorpickerlib/30%20visu" +
                    "alprint/previewwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
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
            
            #line 4 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
            ((VisualPrint.PreviewWindow)(target)).Closed += new System.EventHandler(this.OnClosed);
            
            #line default
            #line hidden
            
            #line 4 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
            ((VisualPrint.PreviewWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PrintMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            
            #line 19 "..\..\..\..\..\..\10 Graphics\11 WPFColorPickerLib\30 VisualPrint\PreviewWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnPrintClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DocumentPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 5:
            this.Viewer = ((System.Windows.Controls.FlowDocumentReader)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

