using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

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
        private int idSala;
        private String nombre;
        private Boolean dobleDado;
        private Boolean dobleFicha;
        private Boolean casillasEspeciales;
        private int numJugadores;
        private Boolean jugando;
        private Dictionary<IJugador, Jugador> diccionarioJugadoresLobby;
        private Dictionary<IJugador, Jugador> diccionarioJugadores;
        private String uriFondoTablero;
        private List<Ficha> fichas;
        private String jugadorEnTurno;
        private List<String> jugadoresJugando;

        [DataMember]
        public int IdSala
        {
            get { return idSala; }
            set { idSala = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public Boolean DobleDado
        {
            get { return dobleDado; }
            set { dobleDado = value; }
        }

        [DataMember]
        public Boolean DobleFicha
        {
            get { return dobleFicha; }
            set { dobleFicha = value; }
        }

        [DataMember]
        public Boolean CasillasEspeciales
        {
            get { return casillasEspeciales; }
            set { casillasEspeciales = value; }
        }

        [DataMember]
        public int NumJugadores
        {
            get { return numJugadores; }
            set { numJugadores = value; }
        }

        [DataMember]
        public Boolean Jugando
        {
            get { return jugando; }
            set { jugando = value; }
        }

        [DataMember]
        public Dictionary<IJugador, Jugador> DiccionarioJugadoresLobby
        {
            get { return diccionarioJugadoresLobby; }
            set { diccionarioJugadoresLobby = value; }
        }

        [DataMember]
        public Dictionary<IJugador, Jugador> DiccionarioJugadores
        {
            get { return diccionarioJugadores; }
            set { diccionarioJugadores = value; }
        }

        [DataMember]
        public String UriFondoTablero
        {
            get { return uriFondoTablero; }
            set { uriFondoTablero = value; }
        }

        [DataMember]
        public List<Ficha> Fichas
        {
            get { return fichas; }
            set { fichas = value; }
        }

        [DataMember]
        public String JugadorEnTurno
        {
            get { return jugadorEnTurno; }
            set { jugadorEnTurno = value; }
        }

        [DataMember]
        public List<String> JugadoresJugando
        {
            get { return jugadoresJugando; }
            set { jugadoresJugando = value; }
        }
        public Sala(int idSala2)
        {
            idSala = idSala2;
        }
        public Sala()
        {

        }
    }

    [DataContract]
    public class Ficha
    {
        private String nombreFicha;
        private String uriFicha;
        private String apodoJugador;
        private int posicion;

        [DataMember]
        public String NombreFicha
        {
            get { return nombreFicha; }
            set { nombreFicha = value; }
        }

        [DataMember]
        public String UriFicha
        {
            get { return uriFicha; }
            set { uriFicha = value; }
        }

        [DataMember]
        public String ApodoJugador
        {
            get { return apodoJugador; }
            set { apodoJugador = value; }
        }

        [DataMember]
        public int Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

    }

}
