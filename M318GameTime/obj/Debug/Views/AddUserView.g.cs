﻿#pragma checksum "..\..\..\Views\AddUserView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6224204E10D551A49A56D2D765F1A6E98FB2157051E5D3BC2DD857FBC31F8CC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using M318GameTime.ViewModels;
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


namespace M318GameTime.Views {
    
    
    /// <summary>
    /// AddUserView
    /// </summary>
    public partial class AddUserView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\AddUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddGameGrid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\AddUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProfilsPseudoTextBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\AddUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProfilsNomTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\AddUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProfilsPrenomTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\AddUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ProfilsDateNaissanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Views\AddUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProfilsEmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\AddUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProfilsMotPasseTextBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\AddUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addUserBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/M318GameTime;component/views/adduserview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddUserView.xaml"
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
            this.AddGameGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ProfilsPseudoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ProfilsNomTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ProfilsPrenomTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ProfilsDateNaissanceTextBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.ProfilsEmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ProfilsMotPasseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.addUserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\Views\AddUserView.xaml"
            this.addUserBtn.Click += new System.Windows.RoutedEventHandler(this.addUserBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

