using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace MessageService
{
    [ServiceContract(CallbackContract = typeof(IJugador))]
    interface IAdministradorMultijugador
    {
        [OperationContract]
        int CrearSala(Sala sala);
        [OperationContract]
        List<Sala> ConsultarSalasDisponibles();
        [OperationContract]
        List<String> ConsultarJugadoresSala(int idSala);
        [OperationContract(IsOneWay =true)]
        void UnirseSala(int idSala, Jugador jugador);
        [OperationContract]
        Boolean ValidarSala(int idSala);
        [OperationContract(IsOneWay = true)]
        void EnviarMensaje(int idSala, String mensaje);
        [OperationContract(IsOneWay = true)]
        void SalirChat(int idSala);
        
        [OperationContract(IsOneWay = true)]
        void IniciarJuego(int idSala);
        [OperationContract(IsOneWay = true)]
        void UnirseJuego(int idSala, Jugador jugador);
        [OperationContract(IsOneWay = true)]
        void EnviarMensajeJuego(int idSala, String mensaje);
        [OperationContract(IsOneWay = true)]
        void SalirJuego(int idSala);
        [OperationContract(IsOneWay = true)]
        void AsignarFicha(int idSala, Ficha ficha);
        [OperationContract(IsOneWay = true)]
        void RecibirTiro(int idSala, int numDado);
        [OperationContract(IsOneWay = true)]
        void CambiarPosicionFicha(int idSala, Ficha ficha);
        [OperationContract(IsOneWay = true)]
        void CambiarPortales(int idSala, Casilla[] casillasRecibidas, Portal[] portalesRecibidos);
        
    }
    /// <summary>
    /// Interfaz con operaciones que estaran dipsonibles para le cliente 
    /// relacionadas con el juego
    /// </summary>
    [ServiceContract]
    public interface IJugador
    {
        /// <summary>
        /// Permite al cliente recibir mensajes en el chat del lobby
        /// </summary>
        /// <param name="mensaje">mensaje que es recibido</param>
        [OperationContract(IsOneWay = true)]
        void RecibirMensajeLobby(String mensaje);
        /// <summary>
        ///  Muestra mensaje del jugador que ingreso a la partida
        /// </summary>
        /// <param name="entrada">Permite saber si el jugador entró o salió</param>
        /// <param name="apodo"> Apodo del jugador que realiza la accion</param>
        [OperationContract(IsOneWay = true)]
        void RecibirMensajeMiembroLobby(Boolean entrada, String apodo);
        /// <summary>
        /// Muestra la pantalla de juego y carga las configuraciones
        /// de los portales y las casillas
        /// </summary>
        /// <param name="casillas"> Casillas implementadas en el tablero</param>
        /// <param name="portales">Portales implementados en el tablero</param>
        [OperationContract(IsOneWay = true)]
        void EntrarJuego(Casilla[] casillas, Portal[] portales);
        /// <summary>
        /// Muestra los mensajes en el chat del juego
        /// </summary>
        /// <param name="mensaje"></param>
        [OperationContract(IsOneWay = true)]
        void RecibirMensaje(String mensaje);
        /// <summary>
        /// Muestra los mensajes de entrada y salida de los jugadores
        /// </summary>
        /// <param name="entrada">Indica true si el jugador entro a la partida y falso si salio</param>
        /// <param name="apodo">apodo del jugador</param>
        [OperationContract(IsOneWay = true)]
        void RecibirMensajeMiembro(Boolean entrada, String apodo);
        /// <summary>
        ///  Prepara la ventana de turno con las fichas para que un jugador
        /// </summary>
        /// <param name="apodo">apodo del jugador que eligió la ficha</param>
        /// <param name="fichasEscogidas">ficha elegida por el jugador</param>
        [OperationContract(IsOneWay = true)]
        void ElegirFicha(String apodo, Ficha[] fichasEscogidas);
        /// <summary>
        ///  Muestra la ficha elegida por el jugador
        /// </summary>
        /// <param name="ficha">ficha que fue elegida por el jugador</param>
        [OperationContract(IsOneWay = true)]
        void MostrarFichaElegida(Ficha ficha);
        /// <summary>
        /// Muestra la ventana Turno con el dado 
        /// </summary>
        /// <param name="apodo">apodo del jugador que realiza el tiro</param>
        [OperationContract(IsOneWay = true)]
        void Tirar(String apodo);
        /// <summary>
        /// Muestra la posicion en la que se movio la fiucha
        /// </summary>
        /// <param name="ficha">ficha que se mueve</param>
        [OperationContract(IsOneWay = true)]
        void MostrarTiro(Ficha ficha);
        /// <summary>
        /// Recibe la lista de los nuevos portales y llama al juego para
        /// coloacarlos
        /// </summary>
        /// <param name="portales">lista de portales</param>
        [OperationContract(IsOneWay = true)]
        void MostrarNuevosPortales(Portal[] portales);
        /// <summary>
        /// Muestra la ventana con el jugador que gano la partida
        /// </summary>
        /// <param name="ficha">ficha del jugador que ganó</param>
        [OperationContract(IsOneWay = true)]
        void MostrarGanador(Ficha ficha);
       
    }
    /// <summary>
    /// Perimite exponer los datos de la Sala
    /// </summary>
    [DataContract]
    public class Sala
    {
        /// <summary>
        /// Permite acceder al identificador de la sala
        /// </summary>
        [DataMember]
        public int IdSala { get; set; }
        /// <summary>
        /// Permite acceder al nombre de la sala
        /// </summary>
        [DataMember]
        public String Nombre { get; set; }
        /// <summary>
        /// Permite configurar si la partida será con 
        /// doble dado
        /// </summary>
        [DataMember]
        public Boolean DobleDado { get; set; }
        /// <summary>
        /// Permite configurar si la partida 
        /// tendrá doble ficha
        /// </summary>
        [DataMember]
        public Boolean DobleFicha { get; set; }
        /// <summary>
        /// Permite configurar si la partida tendrá
        /// casillas especiales
        /// </summary>
        [DataMember]
        public Boolean CasillasEspeciales { get; set; }
        /// <summary>
        /// Permite obtener el numero de jugadores
        /// </summary>
        [DataMember]
        public int NumJugadores { get; set; }
        /// <summary>
        /// Permite conocer si se está jugando en la partida
        /// </summary>
        [DataMember]
        public Boolean Jugando { get; set; }
      
        [DataMember]
        public Dictionary<IJugador, Jugador> DiccionarioJugadoresLobby { get; set; }

        [DataMember]
        public Dictionary<IJugador, Jugador> DiccionarioJugadores { get; set; }
        /// <summary>
        /// Permite obtener las imagenes de fondo del tablero
        /// </summary>
        [DataMember]
        public String UriFondoTablero { get; set; }
        /// <summary>
        /// Permite obtener las fichas
        /// </summary>
        [DataMember]
        public List<Ficha> Fichas { get; set; }
        /// <summary>
        /// Permite obtener al jugador en turno
        /// </summary>
        [DataMember]
        public String JugadorEnTurno { get; set; }
        /// <summary>
        /// Permite obtener a los jugarores que se encuentran jugando
        /// </summary>
        [DataMember]
        public List<String> JugadoresJugando { get; set; }
        /// <summary>
        /// Constructor de sala que recibe solo un ID
        /// </summary>
        /// <param name="idSala2">identificador de la sala</param>
        public Sala(int idSala2)
        {
            IdSala = idSala2;
        }
        /// <summary>
        /// Constructor vacio del cliente
        /// </summary>
        public Sala()
        {

        }
    }
    /// <summary>
    /// Permite exponer los datos de la Ficha
    /// </summary>
    [DataContract]
    public class Ficha
    {
        /// <summary>
        /// Propiedad para acceder al nombre de la ficha
        /// </summary>
        [DataMember]
        public String NombreFicha { get; set; }
        /// <summary>
        /// Propiedad para acceder a la imagen de la ficha
        /// </summary>
        [DataMember]
        public String UriFicha { get; set; }
        /// <summary>
        /// Propiedad para acceder al apodo del jugador
        /// que tiene esa ficha
        /// </summary>
        [DataMember]
        public String ApodoJugador { get; set; }
        /// <summary>
        /// Propiedad que permite acceder a la posición de
        /// la ficha dentro del tablero
        /// </summary>
        [DataMember]
        public int Posicion { get; set; }
        /// <summary>
        /// Propiedada que permite contabilizar
        /// los movimientos realizados por la ficha
        /// </summary>
        [DataMember]
        public int Movimientos { get; set; }

    }

}
