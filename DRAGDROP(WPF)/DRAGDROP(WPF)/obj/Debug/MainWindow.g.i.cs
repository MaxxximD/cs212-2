﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "189EB6B4A2EFC766BBB83052BEDC36D56CAE254300981A76CA6DFE8B367D3E3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DRAGDROP_WPF_;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace DRAGDROP_WPF_ {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding exit0;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox richTextBox1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox richTextBox2;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox richTextBox3;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem clear;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem exit1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DRAGDROP(WPF);component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.exit0 = ((System.Windows.Input.CommandBinding)(target));
            
            #line 10 "..\..\MainWindow.xaml"
            this.exit0.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Exit0_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.richTextBox1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.richTextBox1.DragEnter += new System.Windows.DragEventHandler(this.RichTextBox1_DragEnter);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainWindow.xaml"
            this.richTextBox1.Drop += new System.Windows.DragEventHandler(this.RichTextBox1_Drop);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainWindow.xaml"
            this.richTextBox1.PreviewDragOver += new System.Windows.DragEventHandler(this.RichTextBox1_PreviewDragOver);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainWindow.xaml"
            this.richTextBox1.KeyDown += new System.Windows.Input.KeyEventHandler(this.RichTextBox1_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.richTextBox2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.richTextBox2.DragEnter += new System.Windows.DragEventHandler(this.RichTextBox2_DragEnter);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.richTextBox2.Drop += new System.Windows.DragEventHandler(this.RichTextBox2_Drop);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.richTextBox2.PreviewDragOver += new System.Windows.DragEventHandler(this.RichTextBox2_PreviewDragOver);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.richTextBox2.KeyDown += new System.Windows.Input.KeyEventHandler(this.RichTextBox1_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.richTextBox3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.richTextBox3.DragEnter += new System.Windows.DragEventHandler(this.RichTextBox3_DragEnter);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.richTextBox3.Drop += new System.Windows.DragEventHandler(this.RichTextBox3_Drop);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.richTextBox3.PreviewDragOver += new System.Windows.DragEventHandler(this.RichTextBox3_PreviewDragOver);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.richTextBox3.KeyDown += new System.Windows.Input.KeyEventHandler(this.RichTextBox1_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.clear = ((System.Windows.Controls.MenuItem)(target));
            
            #line 37 "..\..\MainWindow.xaml"
            this.clear.Click += new System.Windows.RoutedEventHandler(this.Clear_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.exit1 = ((System.Windows.Controls.MenuItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

