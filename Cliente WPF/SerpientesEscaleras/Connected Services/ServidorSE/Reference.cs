﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SerpientesEscaleras.ServidorSE {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cuenta", Namespace="http://schemas.datacontract.org/2004/07/MessageService")]
    [System.SerializableAttribute()]
    public partial class Cuenta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contraseña {
            get {
                return this.ContraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContraseñaField, value) != true)) {
                    this.ContraseñaField = value;
                    this.RaisePropertyChanged("Contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Jugador", Namespace="http://schemas.datacontract.org/2004/07/MessageService")]
    [System.SerializableAttribute()]
    public partial class Jugador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApodoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apodo {
            get {
                return this.ApodoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApodoField, value) != true)) {
                    this.ApodoField = value;
                    this.RaisePropertyChanged("Apodo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilaTablaPuntajes", Namespace="http://schemas.datacontract.org/2004/07/MessageService")]
    [System.SerializableAttribute()]
    public partial class FilaTablaPuntajes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApodoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PuntosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TurnosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apodo {
            get {
                return this.ApodoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApodoField, value) != true)) {
                    this.ApodoField = value;
                    this.RaisePropertyChanged("Apodo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Puntos {
            get {
                return this.PuntosField;
            }
            set {
                if ((this.PuntosField.Equals(value) != true)) {
                    this.PuntosField = value;
                    this.RaisePropertyChanged("Puntos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Turnos {
            get {
                return this.TurnosField;
            }
            set {
                if ((this.TurnosField.Equals(value) != true)) {
                    this.TurnosField = value;
                    this.RaisePropertyChanged("Turnos");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sala", Namespace="http://schemas.datacontract.org/2004/07/MessageService")]
    [System.SerializableAttribute()]
    public partial class Sala : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CasillasEspecialesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<object, SerpientesEscaleras.ServidorSE.Jugador> DiccionarioJugadoresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DobleDadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DobleFichaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumJugadoresField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CasillasEspeciales {
            get {
                return this.CasillasEspecialesField;
            }
            set {
                if ((this.CasillasEspecialesField.Equals(value) != true)) {
                    this.CasillasEspecialesField = value;
                    this.RaisePropertyChanged("CasillasEspeciales");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<object, SerpientesEscaleras.ServidorSE.Jugador> DiccionarioJugadores {
            get {
                return this.DiccionarioJugadoresField;
            }
            set {
                if ((object.ReferenceEquals(this.DiccionarioJugadoresField, value) != true)) {
                    this.DiccionarioJugadoresField = value;
                    this.RaisePropertyChanged("DiccionarioJugadores");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DobleDado {
            get {
                return this.DobleDadoField;
            }
            set {
                if ((this.DobleDadoField.Equals(value) != true)) {
                    this.DobleDadoField = value;
                    this.RaisePropertyChanged("DobleDado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DobleFicha {
            get {
                return this.DobleFichaField;
            }
            set {
                if ((this.DobleFichaField.Equals(value) != true)) {
                    this.DobleFichaField = value;
                    this.RaisePropertyChanged("DobleFicha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumJugadores {
            get {
                return this.NumJugadoresField;
            }
            set {
                if ((this.NumJugadoresField.Equals(value) != true)) {
                    this.NumJugadoresField = value;
                    this.RaisePropertyChanged("NumJugadores");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServidorSE.IAdministradorCuenta")]
    public interface IAdministradorCuenta {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/IniciarSesion", ReplyAction="http://tempuri.org/IAdministradorCuenta/IniciarSesionResponse")]
        SerpientesEscaleras.ServidorSE.Jugador IniciarSesion(SerpientesEscaleras.ServidorSE.Cuenta cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/IniciarSesion", ReplyAction="http://tempuri.org/IAdministradorCuenta/IniciarSesionResponse")]
        System.Threading.Tasks.Task<SerpientesEscaleras.ServidorSE.Jugador> IniciarSesionAsync(SerpientesEscaleras.ServidorSE.Cuenta cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/RegistrarJugador", ReplyAction="http://tempuri.org/IAdministradorCuenta/RegistrarJugadorResponse")]
        bool RegistrarJugador(SerpientesEscaleras.ServidorSE.Jugador jugador, SerpientesEscaleras.ServidorSE.Cuenta cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/RegistrarJugador", ReplyAction="http://tempuri.org/IAdministradorCuenta/RegistrarJugadorResponse")]
        System.Threading.Tasks.Task<bool> RegistrarJugadorAsync(SerpientesEscaleras.ServidorSE.Jugador jugador, SerpientesEscaleras.ServidorSE.Cuenta cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/ActivarCuentaJugador", ReplyAction="http://tempuri.org/IAdministradorCuenta/ActivarCuentaJugadorResponse")]
        bool ActivarCuentaJugador(SerpientesEscaleras.ServidorSE.Cuenta cuenta, string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/ActivarCuentaJugador", ReplyAction="http://tempuri.org/IAdministradorCuenta/ActivarCuentaJugadorResponse")]
        System.Threading.Tasks.Task<bool> ActivarCuentaJugadorAsync(SerpientesEscaleras.ServidorSE.Cuenta cuenta, string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/VerificarCuenta", ReplyAction="http://tempuri.org/IAdministradorCuenta/VerificarCuentaResponse")]
        bool VerificarCuenta(SerpientesEscaleras.ServidorSE.Cuenta cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/VerificarCuenta", ReplyAction="http://tempuri.org/IAdministradorCuenta/VerificarCuentaResponse")]
        System.Threading.Tasks.Task<bool> VerificarCuentaAsync(SerpientesEscaleras.ServidorSE.Cuenta cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/VerificarApodo", ReplyAction="http://tempuri.org/IAdministradorCuenta/VerificarApodoResponse")]
        bool VerificarApodo(SerpientesEscaleras.ServidorSE.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/VerificarApodo", ReplyAction="http://tempuri.org/IAdministradorCuenta/VerificarApodoResponse")]
        System.Threading.Tasks.Task<bool> VerificarApodoAsync(SerpientesEscaleras.ServidorSE.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/EnviarCorreo", ReplyAction="http://tempuri.org/IAdministradorCuenta/EnviarCorreoResponse")]
        bool EnviarCorreo(SerpientesEscaleras.ServidorSE.Cuenta cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/EnviarCorreo", ReplyAction="http://tempuri.org/IAdministradorCuenta/EnviarCorreoResponse")]
        System.Threading.Tasks.Task<bool> EnviarCorreoAsync(SerpientesEscaleras.ServidorSE.Cuenta cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/ConsultarPuntajesPropios", ReplyAction="http://tempuri.org/IAdministradorCuenta/ConsultarPuntajesPropiosResponse")]
        SerpientesEscaleras.ServidorSE.FilaTablaPuntajes[] ConsultarPuntajesPropios(SerpientesEscaleras.ServidorSE.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/ConsultarPuntajesPropios", ReplyAction="http://tempuri.org/IAdministradorCuenta/ConsultarPuntajesPropiosResponse")]
        System.Threading.Tasks.Task<SerpientesEscaleras.ServidorSE.FilaTablaPuntajes[]> ConsultarPuntajesPropiosAsync(SerpientesEscaleras.ServidorSE.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/ConsultarMejoresPuntajes", ReplyAction="http://tempuri.org/IAdministradorCuenta/ConsultarMejoresPuntajesResponse")]
        SerpientesEscaleras.ServidorSE.FilaTablaPuntajes[] ConsultarMejoresPuntajes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorCuenta/ConsultarMejoresPuntajes", ReplyAction="http://tempuri.org/IAdministradorCuenta/ConsultarMejoresPuntajesResponse")]
        System.Threading.Tasks.Task<SerpientesEscaleras.ServidorSE.FilaTablaPuntajes[]> ConsultarMejoresPuntajesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministradorCuentaChannel : SerpientesEscaleras.ServidorSE.IAdministradorCuenta, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdministradorCuentaClient : System.ServiceModel.ClientBase<SerpientesEscaleras.ServidorSE.IAdministradorCuenta>, SerpientesEscaleras.ServidorSE.IAdministradorCuenta {
        
        public AdministradorCuentaClient() {
        }
        
        public AdministradorCuentaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdministradorCuentaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministradorCuentaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministradorCuentaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SerpientesEscaleras.ServidorSE.Jugador IniciarSesion(SerpientesEscaleras.ServidorSE.Cuenta cuenta) {
            return base.Channel.IniciarSesion(cuenta);
        }
        
        public System.Threading.Tasks.Task<SerpientesEscaleras.ServidorSE.Jugador> IniciarSesionAsync(SerpientesEscaleras.ServidorSE.Cuenta cuenta) {
            return base.Channel.IniciarSesionAsync(cuenta);
        }
        
        public bool RegistrarJugador(SerpientesEscaleras.ServidorSE.Jugador jugador, SerpientesEscaleras.ServidorSE.Cuenta cuenta) {
            return base.Channel.RegistrarJugador(jugador, cuenta);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrarJugadorAsync(SerpientesEscaleras.ServidorSE.Jugador jugador, SerpientesEscaleras.ServidorSE.Cuenta cuenta) {
            return base.Channel.RegistrarJugadorAsync(jugador, cuenta);
        }
        
        public bool ActivarCuentaJugador(SerpientesEscaleras.ServidorSE.Cuenta cuenta, string codigo) {
            return base.Channel.ActivarCuentaJugador(cuenta, codigo);
        }
        
        public System.Threading.Tasks.Task<bool> ActivarCuentaJugadorAsync(SerpientesEscaleras.ServidorSE.Cuenta cuenta, string codigo) {
            return base.Channel.ActivarCuentaJugadorAsync(cuenta, codigo);
        }
        
        public bool VerificarCuenta(SerpientesEscaleras.ServidorSE.Cuenta cuenta) {
            return base.Channel.VerificarCuenta(cuenta);
        }
        
        public System.Threading.Tasks.Task<bool> VerificarCuentaAsync(SerpientesEscaleras.ServidorSE.Cuenta cuenta) {
            return base.Channel.VerificarCuentaAsync(cuenta);
        }
        
        public bool VerificarApodo(SerpientesEscaleras.ServidorSE.Jugador jugador) {
            return base.Channel.VerificarApodo(jugador);
        }
        
        public System.Threading.Tasks.Task<bool> VerificarApodoAsync(SerpientesEscaleras.ServidorSE.Jugador jugador) {
            return base.Channel.VerificarApodoAsync(jugador);
        }
        
        public bool EnviarCorreo(SerpientesEscaleras.ServidorSE.Cuenta cuenta) {
            return base.Channel.EnviarCorreo(cuenta);
        }
        
        public System.Threading.Tasks.Task<bool> EnviarCorreoAsync(SerpientesEscaleras.ServidorSE.Cuenta cuenta) {
            return base.Channel.EnviarCorreoAsync(cuenta);
        }
        
        public SerpientesEscaleras.ServidorSE.FilaTablaPuntajes[] ConsultarPuntajesPropios(SerpientesEscaleras.ServidorSE.Jugador jugador) {
            return base.Channel.ConsultarPuntajesPropios(jugador);
        }
        
        public System.Threading.Tasks.Task<SerpientesEscaleras.ServidorSE.FilaTablaPuntajes[]> ConsultarPuntajesPropiosAsync(SerpientesEscaleras.ServidorSE.Jugador jugador) {
            return base.Channel.ConsultarPuntajesPropiosAsync(jugador);
        }
        
        public SerpientesEscaleras.ServidorSE.FilaTablaPuntajes[] ConsultarMejoresPuntajes() {
            return base.Channel.ConsultarMejoresPuntajes();
        }
        
        public System.Threading.Tasks.Task<SerpientesEscaleras.ServidorSE.FilaTablaPuntajes[]> ConsultarMejoresPuntajesAsync() {
            return base.Channel.ConsultarMejoresPuntajesAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServidorSE.IAdministradorChat", CallbackContract=typeof(SerpientesEscaleras.ServidorSE.IAdministradorChatCallback))]
    public interface IAdministradorChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorChat/CrearSala", ReplyAction="http://tempuri.org/IAdministradorChat/CrearSalaResponse")]
        int CrearSala(SerpientesEscaleras.ServidorSE.Sala sala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorChat/CrearSala", ReplyAction="http://tempuri.org/IAdministradorChat/CrearSalaResponse")]
        System.Threading.Tasks.Task<int> CrearSalaAsync(SerpientesEscaleras.ServidorSE.Sala sala);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorChat/ConsultarSalasDisponibles", ReplyAction="http://tempuri.org/IAdministradorChat/ConsultarSalasDisponiblesResponse")]
        SerpientesEscaleras.ServidorSE.Sala[] ConsultarSalasDisponibles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorChat/ConsultarSalasDisponibles", ReplyAction="http://tempuri.org/IAdministradorChat/ConsultarSalasDisponiblesResponse")]
        System.Threading.Tasks.Task<SerpientesEscaleras.ServidorSE.Sala[]> ConsultarSalasDisponiblesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorChat/ConsultarJugadoresSala", ReplyAction="http://tempuri.org/IAdministradorChat/ConsultarJugadoresSalaResponse")]
        string[] ConsultarJugadoresSala(int indice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorChat/ConsultarJugadoresSala", ReplyAction="http://tempuri.org/IAdministradorChat/ConsultarJugadoresSalaResponse")]
        System.Threading.Tasks.Task<string[]> ConsultarJugadoresSalaAsync(int indice);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministradorChat/UnirseSala")]
        void UnirseSala(int indice, SerpientesEscaleras.ServidorSE.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministradorChat/UnirseSala")]
        System.Threading.Tasks.Task UnirseSalaAsync(int indice, SerpientesEscaleras.ServidorSE.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorChat/ValidarCupoSala", ReplyAction="http://tempuri.org/IAdministradorChat/ValidarCupoSalaResponse")]
        bool ValidarCupoSala(int indice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorChat/ValidarCupoSala", ReplyAction="http://tempuri.org/IAdministradorChat/ValidarCupoSalaResponse")]
        System.Threading.Tasks.Task<bool> ValidarCupoSalaAsync(int indice);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministradorChat/EnviarMensaje")]
        void EnviarMensaje(int indice, string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministradorChat/EnviarMensaje")]
        System.Threading.Tasks.Task EnviarMensajeAsync(int indice, string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministradorChat/SalirChat")]
        void SalirChat(int indice);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministradorChat/SalirChat")]
        System.Threading.Tasks.Task SalirChatAsync(int indice);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministradorChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministradorChat/RecibirMensaje")]
        void RecibirMensaje(string mensaje);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministradorChat/RecibirMensajeMiembro")]
        void RecibirMensajeMiembro(bool entrada, string apodo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministradorChatChannel : SerpientesEscaleras.ServidorSE.IAdministradorChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdministradorChatClient : System.ServiceModel.DuplexClientBase<SerpientesEscaleras.ServidorSE.IAdministradorChat>, SerpientesEscaleras.ServidorSE.IAdministradorChat {
        
        public AdministradorChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public AdministradorChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public AdministradorChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AdministradorChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AdministradorChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int CrearSala(SerpientesEscaleras.ServidorSE.Sala sala) {
            return base.Channel.CrearSala(sala);
        }
        
        public System.Threading.Tasks.Task<int> CrearSalaAsync(SerpientesEscaleras.ServidorSE.Sala sala) {
            return base.Channel.CrearSalaAsync(sala);
        }
        
        public SerpientesEscaleras.ServidorSE.Sala[] ConsultarSalasDisponibles() {
            return base.Channel.ConsultarSalasDisponibles();
        }
        
        public System.Threading.Tasks.Task<SerpientesEscaleras.ServidorSE.Sala[]> ConsultarSalasDisponiblesAsync() {
            return base.Channel.ConsultarSalasDisponiblesAsync();
        }
        
        public string[] ConsultarJugadoresSala(int indice) {
            return base.Channel.ConsultarJugadoresSala(indice);
        }
        
        public System.Threading.Tasks.Task<string[]> ConsultarJugadoresSalaAsync(int indice) {
            return base.Channel.ConsultarJugadoresSalaAsync(indice);
        }
        
        public void UnirseSala(int indice, SerpientesEscaleras.ServidorSE.Jugador jugador) {
            base.Channel.UnirseSala(indice, jugador);
        }
        
        public System.Threading.Tasks.Task UnirseSalaAsync(int indice, SerpientesEscaleras.ServidorSE.Jugador jugador) {
            return base.Channel.UnirseSalaAsync(indice, jugador);
        }
        
        public bool ValidarCupoSala(int indice) {
            return base.Channel.ValidarCupoSala(indice);
        }
        
        public System.Threading.Tasks.Task<bool> ValidarCupoSalaAsync(int indice) {
            return base.Channel.ValidarCupoSalaAsync(indice);
        }
        
        public void EnviarMensaje(int indice, string mensaje) {
            base.Channel.EnviarMensaje(indice, mensaje);
        }
        
        public System.Threading.Tasks.Task EnviarMensajeAsync(int indice, string mensaje) {
            return base.Channel.EnviarMensajeAsync(indice, mensaje);
        }
        
        public void SalirChat(int indice) {
            base.Channel.SalirChat(indice);
        }
        
        public System.Threading.Tasks.Task SalirChatAsync(int indice) {
            return base.Channel.SalirChatAsync(indice);
        }
    }
}
