﻿#pragma checksum "..\..\SearchGame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "34CE79A422D82DD60274ABA00C2A4428"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace SimplyGames {
    
    
    /// <summary>
    /// SearchGame
    /// </summary>
    public partial class SearchGame : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\SearchGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchName;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\SearchGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchCode;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\SearchGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\SearchGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Grid1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\SearchGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewAll;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\SearchGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchGenre;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\SearchGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/SimplyGames;component/searchgame.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchGame.xaml"
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
            this.searchName = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\SearchGame.xaml"
            this.searchName.Click += new System.Windows.RoutedEventHandler(this.searchName_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchCode = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\SearchGame.xaml"
            this.searchCode.Click += new System.Windows.RoutedEventHandler(this.searchCode_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Grid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btnViewAll = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\SearchGame.xaml"
            this.btnViewAll.Click += new System.Windows.RoutedEventHandler(this.btnViewAll_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.searchGenre = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\SearchGame.xaml"
            this.searchGenre.Click += new System.Windows.RoutedEventHandler(this.searchGenre_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\SearchGame.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

