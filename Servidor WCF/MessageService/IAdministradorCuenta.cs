using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace MessageService {
    /// <summary>
    /// Operaciones que estaran disponibles para el cliente enfocados a 
    /// la administracion de las funcionalidades de la cuenta del mismo
    /// </summary>
    [ServiceContract]
    public interface IAdministradorCuenta
    {
        /// <summary>
        /// Permite al cliente iniciar sesion con su cuenta
        /// </summary>
        /// <param name="cuenta">Cuenta registrada del jugador</param>
        /// <returns> Al jugador que tiene asociada esa cuenta</returns>
        [OperationContract]
        Jugador IniciarSesion(Cuenta cuenta);
        /// <summary>
        /// Permite al cliente registrarse al juego
        /// </summary>
        /// <param name="jugador"> Datos del jugador</param>
        /// <param name="cuenta">Datos de la cuenta </param>
        /// <returns>Regresa 1 si se registro correctamente</returns>
        [OperationContract]
        int RegistrarJugador(Jugador jugador, Cuenta cuenta);
        /// <summary>
        /// Permite al cliente validar su cuenta
        /// </summary>
        /// <param name="cuenta"> Cuenta del cliente</param>
        /// <param name="codigo"> Codigo enviado a su correo</param>
        /// <returns>Regresa 1 si se activó la cuenta</returns>
        [OperationContract]
        int ActivarCuentaJugador(Cuenta cuenta, String codigo);
        /// <summary>
        /// Permite consultar si la cuenta está verificada o no
        /// </summary>
        /// <param name="cuenta"> cuenta ingresada por le cliente</param>
        /// <returns>Retorna la cuenta verificada, null si no lo está</returns>
        [OperationContract]
        Cuenta VerificarCuenta(Cuenta cuenta);
        /// <summary>
        /// Permite enviar un correo con el código de activación para la cuenta
        /// </summary>
        /// <param name="cuenta"> Datos de cuenta ingresados por el cliente</param>
        /// <returns></returns>
        [OperationContract]
        int EnviarCorreo(Cuenta cuenta);
        /// <summary>
        /// Permite consultar los puntajes del jugador
        /// </summary>
        /// <param name="jugador"> Jugador a consultar</param>
        /// <returns>Lista de los puntajes del jugador</returns>
        [OperationContract]
        List<FilaTablaPuntajes> ConsultarPuntajesPropios(Jugador jugador);
        /// <summary>
        /// Permite consultar los puntajes globales
        /// </summary>
        /// <returns>Lista de los puntajes</returns>
        [OperationContract]
        List<FilaTablaPuntajes> ConsultarMejoresPuntajes();
    }
    /// <summary>
    /// Permite exponer los datos del Jugador
    /// </summary>
    [DataContract]
    public class Jugador
    {
        /// <summary>
        /// Propiedad apodo del jugador para serializar y deserializar
        /// </summary>
        [DataMember]
        public String Apodo { get; set; }
        /// <summary>
        /// Propiedad nombre del jugador para serializar y deserializar
        /// </summary>
        [DataMember]
        public String Nombre { get; set; }
        /// <summary>
        /// Propiedad apellidos del jugador para serializar y deserializar
        /// </summary>
        [DataMember]
        public String Apellidos { get; set; }
    }
    /// <summary>
    /// Permite exponer los datos de la cuenta
    /// </summary>
    [DataContract]
    public class Cuenta
    {
        /// <summary>
        /// Propiedad correo de la Cuenta para serializar y deserializar
        /// </summary>
        [DataMember]
        public String Correo { get; set; }
        /// <summary>
        ///  Propiedad contraseña de la Cuenta para serializar y deserializar
        /// </summary>
        [DataMember]
        public String Contraseña { get; set; }
        /// <summary>
        ///  Propiedad validad de la Cuenta para serializar y deserializar
        ///  permite saber si está validad o no
        /// </summary>
        [DataMember]
        public Boolean Validada { get; set; }
    }
    /// <summary>
    /// Permite exponer los datos de la puntuación
    /// </summary>
    [DataContract]
    public class Puntuacion
    {
        /// <summary>
        ///  Propiedad puntos que permite saber los puntos del jugador
        /// </summary>
        [DataMember]
        public int Puntos { get; set; }
        /// <summary>
        ///  Propiedad turnos que permite saber cuantos turnos utilizo el jugador para
        ///  ganar la partida
        /// </summary>
        [DataMember]
        public int Turnos { get; set; }
    }

}
