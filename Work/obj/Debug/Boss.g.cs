﻿#pragma checksum "..\..\Boss.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1175B967B5D3EA6C67DBE1A70683DF334C37503D0438C0CE468DB1F7B5848ADB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using Work;


namespace Work {
    
    
    /// <summary>
    /// Boss
    /// </summary>
    public partial class Boss : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Boss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Boss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Boss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Boss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text2;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Boss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text3;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Boss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text4;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Boss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Boss.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text5;
        
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
            System.Uri resourceLocater = new System.Uri("/Work;component/boss.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Boss.xaml"
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
            this.datagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\Boss.xaml"
            this.datagrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.datagrid_LoadingRow_1);
            
            #line default
            #line hidden
            
            #line 11 "..\..\Boss.xaml"
            this.datagrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.datagrid_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\Boss.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 14 "..\..\Boss.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 15 "..\..\Boss.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_7);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 17 "..\..\Boss.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 18 "..\..\Boss.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            this.text1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\Boss.xaml"
            this.text1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.text2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\Boss.xaml"
            this.text2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text2_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.text3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\Boss.xaml"
            this.text3.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text3_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.text4 = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\Boss.xaml"
            this.text4.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text4_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.combo1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            
            #line 26 "..\..\Boss.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 14:
            this.text5 = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\Boss.xaml"
            this.text5.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text5_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

