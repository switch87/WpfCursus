﻿#pragma checksum "..\..\PizzaWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "338FF6FC7FF7D500CBE8337FEC510308"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace BestelbonPizza {
    
    
    /// <summary>
    /// PizzaWindow
    /// </summary>
    public partial class PizzaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Beleg;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ham;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ananas;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox salami;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ExtraDikkeKorst;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ExtraKaas;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Aantal;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Min;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\PizzaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock bestelling;
        
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
            System.Uri resourceLocater = new System.Uri("/BestelbonPizza;component/pizzawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PizzaWindow.xaml"
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
            
            #line 9 "..\..\PizzaWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Maat_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 10 "..\..\PizzaWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Maat_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 11 "..\..\PizzaWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Maat_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Beleg = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.ham = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.ananas = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.salami = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.ExtraDikkeKorst = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 9:
            this.ExtraKaas = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 10:
            this.Aantal = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            
            #line 28 "..\..\PizzaWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.plus_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Min = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\PizzaWindow.xaml"
            this.Min.Click += new System.Windows.RoutedEventHandler(this.min_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 32 "..\..\PizzaWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.bestelling = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

