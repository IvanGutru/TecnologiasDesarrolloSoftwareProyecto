﻿#pragma checksum "..\..\RegistroUsuario.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "955A0B2753E70FDCA68710CB5E5343A4A669D0E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// RegistroUsuario
    /// </summary>
    public partial class RegistroUsuario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\RegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_NombreUsuario;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\RegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Apellidos;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\RegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Apodo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\RegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_CorreoElectronico;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox_Contraseña;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox_ConfirmarContraseña;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_RegistroVentanaRegistrarse;
        
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
            System.Uri resourceLocater = new System.Uri("/SerpientesEscaleras;component/registrousuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegistroUsuario.xaml"
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
            this.textBox_NombreUsuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textBox_Apellidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textBox_Apodo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textBox_CorreoElectronico = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.passwordBox_Contraseña = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.passwordBox_ConfirmarContraseña = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.button_RegistroVentanaRegistrarse = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\RegistroUsuario.xaml"
            this.button_RegistroVentanaRegistrarse.Click += new System.Windows.RoutedEventHandler(this.Button_Registrarse);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 33 "..\..\RegistroUsuario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Regresar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

