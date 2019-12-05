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
        Boolean RegistrarJugador(Jugador jugador, Cuenta cuenta);
        [OperationContract]
        Boolean ActivarCuentaJugador(Cuenta cuenta, String codigo);
        [OperationContract]
        Boolean VerificarCuenta(Cuenta cuenta);
        [OperationContract]
        Boolean VerificarApodo(Jugador jugador);
        [OperationContract]
        Boolean EnviarCorreo(Cuenta cuenta);
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

        public Jugador()
        {

        }

        public Jugador(string apodo, string nombre, string apellidos)
        {
            this.Apodo = apodo;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

    }

    [DataContract]
    public class Cuenta
    {
        [DataMember]
        public String Correo { get; set; }

        [DataMember]
        public String Contraseña { get; set; }

   
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
