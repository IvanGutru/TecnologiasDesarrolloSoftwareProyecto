using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MessageService {
    [ServiceContract]
    public interface IAdministradorCuenta
    {
        [OperationContract]
        Jugador IniciarSesion(Cuenta cuenta);
        [OperationContract]
        int RegistrarJugador(Jugador jugador, Cuenta cuenta);
        [OperationContract]
        int ActivarCuentaJugador(Cuenta cuenta, String codigo);
        [OperationContract]
        Cuenta VerificarCuenta(Cuenta cuenta);
        [OperationContract]
        int EnviarCorreo(Cuenta cuenta);
        [OperationContract]
        List<FilaTablaPuntajes> ConsultarPuntajesPropios(Jugador jugador);
        [OperationContract]
        List<FilaTablaPuntajes> ConsultarMejoresPuntajes();
    }

    [DataContract]
    public class Jugador
    {
        private String apodo;
        private String nombre;
        private string apellidos;

        [DataMember]
        public String Apodo
        {
            get { return apodo; }
            set { apodo = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
    }

    [DataContract]
    public class Cuenta
    {
        private String correo;
        private String contraseña;
        private Boolean validada;

        [DataMember]
        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [DataMember]
        public String Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        [DataMember]
        public Boolean Validada
        {
            get { return validada; }
            set { validada = value; }
        }
    }

    [DataContract]
    public class Puntuacion
    {
        private int puntos;
        private int turnos;

        [DataMember]
        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        [DataMember]
        public int Turnos
        {
            get { return turnos; }
            set { turnos = value; }
        }
    }

}
