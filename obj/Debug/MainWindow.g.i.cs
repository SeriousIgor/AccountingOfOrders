﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E35680AAD447C89CE7F8C96050D91128487F77EAB574070588AE6641A75C2AF5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AccountingOfOrders;
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


namespace AccountingOfOrders {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Toolbar;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MinButton;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ExitButton;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LogoContainer;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBLogin;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPassword;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LoginButtonBorder;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountingOfOrders;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 9 "..\..\MainWindow.xaml"
            ((AccountingOfOrders.MainWindow)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Toolbar = ((System.Windows.Controls.Grid)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.Toolbar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Toolbar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MinButton = ((System.Windows.Controls.Image)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.MinButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MinButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ExitButton = ((System.Windows.Controls.Image)(target));
            
            #line 80 "..\..\MainWindow.xaml"
            this.ExitButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ExitButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LogoContainer = ((System.Windows.Controls.Grid)(target));
            
            #line 98 "..\..\MainWindow.xaml"
            this.LogoContainer.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.LogoContainer_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.LoginButtonBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\MainWindow.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
