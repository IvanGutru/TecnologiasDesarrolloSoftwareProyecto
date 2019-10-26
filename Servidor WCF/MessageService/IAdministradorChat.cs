using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MessageService
{
    [ServiceContract(CallbackContract = typeof(IChatCliente))]
    interface IAdministradorChat
    {
        [OperationContract]
        int CrearSala(Sala sala);
        [OperationContract]
        List<Sala> ConsultarSalasDisponibles();
        [OperationContract(IsOneWay = true)]
        void UnirseSala(int indice, Jugador jugador);
        [OperationContract(IsOneWay = true)]
        void Entrar(Jugador jugador, String mensajeEntrada);
        [OperationContract(IsOneWay = true)]
        void EnviarMensaje(int indice, String mensaje);
        [OperationContract(IsOneWay = true)]
        void SalirChat(int indice);
    }
    
    [ServiceContract]
    public interface IChatCliente
    {
        [OperationContract(IsOneWay = true)]
        void RecibirMensaje(String mensaje);
        [OperationContract(IsOneWay = true)]
        void RecibirMensajeMiembro(Boolean entrada, String apodo);
    }

    [DataContract]
    public class Sala
    {
        private String nombre;
        private Boolean dobleDado;
        private Boolean dobleFicha;
        private Boolean casillasEspeciales;
        private int numJugadores;
        private Dictionary<IChatCliente, Jugador> diccionarioJugadores;

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
        public Dictionary<IChatCliente, Jugador> DiccionarioJugadores { get; set; }
    }
}
