﻿#pragma checksum "..\..\addbranch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF72DFB467861DC7F189BE5B650124F264AF3F3271DA6662CADB46DFC4BDD870"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Entry;
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


namespace Entry {
    
    
    /// <summary>
    /// addbranch
    /// </summary>
    public partial class addbranch : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combocountry;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combocity;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combostart;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboend;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtaddress;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblcityid;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblcontryid;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnemp;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\addbranch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtphone;
        
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
            System.Uri resourceLocater = new System.Uri("/Entry;component/addbranch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addbranch.xaml"
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
            this.combocountry = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\addbranch.xaml"
            this.combocountry.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combocountry_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.combocity = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\addbranch.xaml"
            this.combocity.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combocity_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.combostart = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\addbranch.xaml"
            this.combostart.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ComboBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.comboend = ((System.Windows.Controls.ComboBox)(target));
            
            #line 63 "..\..\addbranch.xaml"
            this.comboend.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ComboBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtaddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 120 "..\..\addbranch.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblcityid = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblcontryid = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 125 "..\..\addbranch.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnemp = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\addbranch.xaml"
            this.btnemp.Click += new System.Windows.RoutedEventHandler(this.btnemp_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtphone = ((System.Windows.Controls.TextBox)(target));
            
            #line 138 "..\..\addbranch.xaml"
            this.txtphone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtaddress_Copy_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

