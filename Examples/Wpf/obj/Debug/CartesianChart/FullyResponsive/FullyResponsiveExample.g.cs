﻿#pragma checksum "..\..\..\..\CartesianChart\FullyResponsive\FullyResponsiveExample.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E9F4E84317CA1AF45820EB45B028C3B0261C24360D7612F857EF4C8413020E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
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
using Wpf.CartesianChart;
using Wpf.CartesianChart.FullyResponsive;


namespace Wpf.CartesianChart.FullyResponsive {
    
    
    /// <summary>
    /// FullyResponsiveExample
    /// </summary>
    public partial class FullyResponsiveExample : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf;component/cartesianchart/fullyresponsive/fullyresponsiveexample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\CartesianChart\FullyResponsive\FullyResponsiveExample.xaml"
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
            
            #line 22 "..\..\..\..\CartesianChart\FullyResponsive\FullyResponsiveExample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddPointOnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 23 "..\..\..\..\CartesianChart\FullyResponsive\FullyResponsiveExample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.InsertPointOnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 24 "..\..\..\..\CartesianChart\FullyResponsive\FullyResponsiveExample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemovePointOnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 25 "..\..\..\..\CartesianChart\FullyResponsive\FullyResponsiveExample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveAllOnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 27 "..\..\..\..\CartesianChart\FullyResponsive\FullyResponsiveExample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddSeriesOnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 28 "..\..\..\..\CartesianChart\FullyResponsive\FullyResponsiveExample.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveSeriesOnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

