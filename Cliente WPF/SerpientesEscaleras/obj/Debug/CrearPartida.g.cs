﻿#pragma checksum "..\..\CrearPartida.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EBCB503AC3B6BD8484EB5D967F6DC3AFCFBFF026355DA5AB64182C37DE6CAA70"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SerpientesEscaleras;
using SerpientesEscaleras.Properties;
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


namespace SerpientesEscaleras {
    
    
    /// <summary>
    /// CrearPartida
    /// </summary>
    public partial class CrearPartida : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\CrearPartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Regresar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CrearPartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Nombre;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\CrearPartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CrearPartida;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\CrearPartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox_DobleDado;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\CrearPartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox_DobleFicha;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\CrearPartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox_CasillasEspeciales;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\CrearPartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Nombre;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\CrearPartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_Fondos;
        
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
            System.Uri resourceLocater = new System.Uri("/SerpientesEscaleras;component/crearpartida.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CrearPartida.xaml"
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
            this.button_Regresar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\CrearPartida.xaml"
            this.button_Regresar.Click += new System.Windows.RoutedEventHandler(this.Button_Regresar);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBox_Nombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\CrearPartida.xaml"
            this.textBox_Nombre.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_Nombre_LostFocus);
            
            #line default
            #line hidden
            
            #line 26 "..\..\CrearPartida.xaml"
            this.textBox_Nombre.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_Nombre_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_CrearPartida = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\CrearPartida.xaml"
            this.button_CrearPartida.Click += new System.Windows.RoutedEventHandler(this.Button_CrearPartida);
            
            #line default
            #line hidden
            return;
            case 4:
            this.checkBox_DobleDado = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.checkBox_DobleFicha = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.checkBox_CasillasEspeciales = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.label_Nombre = ((System.Windows.Controls.Label)(target));
            
            #line 50 "..\..\CrearPartida.xaml"
            this.label_Nombre.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_Nombre_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.grid_Fondos = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            
            #line 84 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 86 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 88 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 90 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 92 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 94 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 96 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 98 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 100 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 102 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 104 "..\..\CrearPartida.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_Clic);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

