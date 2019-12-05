using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageService;

namespace MessageServiceTests2
{
    partial class TestCallBackHandler : IJugador
    {
        public void ElegirFicha(string apodo, Ficha[] fichasEscogidas)
        {
            throw new NotImplementedException();
        }

        public void EntrarJuego(Casilla[] casillas, Portal[] portales)
        {
            throw new NotImplementedException();
        }

        public void MostrarFichaElegida(Ficha ficha)
        {
            throw new NotImplementedException();
        }

        public void MostrarGanador(Ficha ficha)
        {
            throw new NotImplementedException();
        }

        public void MostrarNuevosPortales(Portal[] portales)
        {
            throw new NotImplementedException();
        }

        public void MostrarTiro(Ficha ficha)
        {
            throw new NotImplementedException();
        }

        public void RecibirMensaje(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void RecibirMensajeLobby(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void RecibirMensajeMiembro(bool entrada, string apodo)
        {
            throw new NotImplementedException();
        }

        public void RecibirMensajeMiembroLobby(bool entrada, string apodo)
        {
            throw new NotImplementedException();
        }

        public void SolicitarCrearTablero()
        {
            throw new NotImplementedException();
        }

        public void Tirar(string apodo)
        {
            throw new NotImplementedException();
        }
    }

    partial class TestCallBackHandler : IAdministradorMultijugador
    {
        private String response;

        internal TestCallBackHandler()
        {
            response = "";
        }

        internal String Response {
            get { return response; }
        }

        public void AsignarFicha(int idSala, Ficha ficha)
        {
            throw new NotImplementedException();
        }

        public void CambiarPortales(int idSala, Casilla[] casillasRecibidas, Portal[] portalesRecibidos)
        {
            throw new NotImplementedException();
        }

        public void CambiarPosicionFicha(int idSala, Ficha ficha)
        {
            throw new NotImplementedException();
        }

        public List<string> ConsultarJugadoresSala(int idSala)
        {
            throw new NotImplementedException();
        }

        public List<Sala> ConsultarSalasDisponibles()
        {
            throw new NotImplementedException();
        }

        public int CrearSala(Sala sala)
        {
            throw new NotImplementedException();
        }

        public void EnviarMensaje(int idSala, string mensaje)
        {
            throw new NotImplementedException();
        }

        public void EnviarMensajeJuego(int idSala, string mensaje)
        {
            throw new NotImplementedException();
        }

        public void IniciarJuego(int idSala)
        {
            throw new NotImplementedException();
        }

        public void RecibirTiro(int idSala, int numDado)
        {
            throw new NotImplementedException();
        }

        public void SalirChat(int idSala)
        {
            throw new NotImplementedException();
        }

        public void SalirJuego(int idSala)
        {
            throw new NotImplementedException();
        }

        public void UnirseJuego(int idSala, Jugador jugador)
        {
            throw new NotImplementedException();
        }

        public void UnirseSala(int idSala, Jugador jugador)
        {
            
        }

        public bool ValidarSala(int idSala)
        {
            throw new NotImplementedException();
        }
    }

}
