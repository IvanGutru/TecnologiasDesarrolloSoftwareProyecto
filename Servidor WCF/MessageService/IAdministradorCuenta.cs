using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

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
        [DataMember]
        public String Apodo { get; set; }

        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public String Apellidos { get; set; }
    }

    [DataContract]
    public class Cuenta
    {
        [DataMember]
        public String Correo { get; set; }

        [DataMember]
        public String Contraseña { get; set; }

        [DataMember]
        public Boolean Validada { get; set; }
    }

    [DataContract]
    public class Puntuacion
    {
        [DataMember]
        public int Puntos { get; set; }

        [DataMember]
        public int Turnos { get; set; }
    }

}
