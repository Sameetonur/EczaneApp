﻿#pragma checksum "..\..\..\..\Views\IlacViews\IlacWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "28E835836DB55EC7A1B82CE1D9058FC83201E50B124F895CD64EF74B800EDA37"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EczaneApp.Wpf.Views.IlacViews;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace EczaneApp.Wpf.Views.IlacViews {
    
    
    /// <summary>
    /// IlacWindow
    /// </summary>
    public partial class IlacWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAd;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFiyat;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdet;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAciklama;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker sonKullanmaTarihi;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox kategori;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIptal;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTamam;
        
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
            System.Uri resourceLocater = new System.Uri("/EczaneApp.Wpf;component/views/ilacviews/ilacwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
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
            
            #line 27 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtAd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtFiyat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtAdet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtAciklama = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.sonKullanmaTarihi = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.kategori = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnIptal = ((System.Windows.Controls.Button)(target));
            
            #line 197 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
            this.btnIptal.Click += new System.Windows.RoutedEventHandler(this.btnIptal_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnTamam = ((System.Windows.Controls.Button)(target));
            
            #line 198 "..\..\..\..\Views\IlacViews\IlacWindow.xaml"
            this.btnTamam.Click += new System.Windows.RoutedEventHandler(this.btnTamam_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
