﻿#pragma checksum "..\..\Study.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "31410F6817D12C7A5B6FDA30A7C01B6F2848AA9420EAD6AD174B0749C6CCD70F"
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
    /// Study
    /// </summary>
    public partial class Study : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text3;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text4;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text5;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo2;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker data;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Study.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo3;
        
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
            System.Uri resourceLocater = new System.Uri("/Work;component/study.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Study.xaml"
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
            
            #line 10 "..\..\Study.xaml"
            this.datagrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.datagrid_LoadingRow_1);
            
            #line default
            #line hidden
            
            #line 10 "..\..\Study.xaml"
            this.datagrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.datagrid_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\Study.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 13 "..\..\Study.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\Study.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\Study.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_2);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 16 "..\..\Study.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_3);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 17 "..\..\Study.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_4);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 18 "..\..\Study.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_5);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 19 "..\..\Study.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_6);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 21 "..\..\Study.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 22 "..\..\Study.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 13:
            this.text1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\Study.xaml"
            this.text1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.text2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\Study.xaml"
            this.text2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text2_TextChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.text3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\Study.xaml"
            this.text3.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text3_TextChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.text4 = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\Study.xaml"
            this.text4.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text4_TextChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.text5 = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\Study.xaml"
            this.text5.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.text5_TextChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.combo1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 19:
            this.combo2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 20:
            this.data = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 21:
            this.combo3 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 22:
            
            #line 32 "..\..\Study.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
