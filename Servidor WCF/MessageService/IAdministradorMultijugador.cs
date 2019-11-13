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
        void SalirJuego(int idSala);
        [OperationContract]
        String ObtenerFondo(int idSala);
    }
    
    [ServiceContract]
    public interface IJugador
    {
        [OperationContract(IsOneWay = true)]
        void RecibirMensaje(String mensaje);
        [OperationContract(IsOneWay = true)]
        void RecibirMensajeMiembro(Boolean entrada, String apodo);
        [OperationContract(IsOneWay = true)]
        void EntrarJuego();
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
        private Dictionary<IJugador, Jugador> diccionarioJugadores;
        private String uriFondoTablero;

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
    }
}
