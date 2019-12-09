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
    
    [ServiceContract]
    public interface IJugador
    {
        [OperationContract(IsOneWay = true)]
        void RecibirMensajeLobby(String mensaje);
        [OperationContract(IsOneWay = true)]
        void RecibirMensajeMiembroLobby(Boolean entrada, String apodo);
        [OperationContract(IsOneWay = true)]
        void EntrarJuego(Casilla[] casillas, Portal[] portales);
        [OperationContract(IsOneWay = true)]
        void SolicitarCrearTablero();
        [OperationContract(IsOneWay = true)]
        void RecibirMensaje(String mensaje);
        [OperationContract(IsOneWay = true)]
        void RecibirMensajeMiembro(Boolean entrada, String apodo);
        [OperationContract(IsOneWay = true)]
        void ElegirFicha(String apodo, Ficha[] fichasEscogidas);
        [OperationContract(IsOneWay = true)]
        void MostrarFichaElegida(Ficha ficha);
        [OperationContract(IsOneWay = true)]
        void Tirar(String apodo);
        [OperationContract(IsOneWay = true)]
        void MostrarTiro(Ficha ficha);
        [OperationContract(IsOneWay = true)]
        void MostrarNuevosPortales(Portal[] portales);
        [OperationContract(IsOneWay = true)]
        void MostrarGanador(Ficha ficha);
    }

    [DataContract]
    public class Sala
    {
        [DataMember]
        public int IdSala { get; set; }

        [DataMember]
        public String Nombre { get; set; }

        [DataMember]
        public Boolean DobleDado { get; set; }

        [DataMember]
        public Boolean DobleFicha { get; set; }

        [DataMember]
        public Boolean CasillasEspeciales { get; set; }

        [DataMember]
        public int NumJugadores { get; set; }

        [DataMember]
        public Boolean Jugando { get; set; }

        [DataMember]
        public Dictionary<IJugador, Jugador> DiccionarioJugadoresLobby { get; set; }

        [DataMember]
        public Dictionary<IJugador, Jugador> DiccionarioJugadores { get; set; }

        [DataMember]
        public String UriFondoTablero { get; set; }

        [DataMember]
        public List<Ficha> Fichas { get; set; }

        [DataMember]
        public String JugadorEnTurno { get; set; }

        [DataMember]
        public List<String> JugadoresJugando { get; set; }
        public Sala(int idSala2)
        {
            IdSala = idSala2;
        }
        public Sala()
        {

        }
    }

    [DataContract]
    public class Ficha
    {
        [DataMember]
        public String NombreFicha { get; set; }

        [DataMember]
        public String UriFicha { get; set; }

        [DataMember]
        public String ApodoJugador { get; set; }

        [DataMember]
        public int Posicion { get; set; }

        [DataMember]
        public int Movimientos { get; set; }

    }

}
