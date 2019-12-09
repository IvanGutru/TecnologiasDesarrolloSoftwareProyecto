using System;
using System.Collections.Generic;
using System.Linq;

namespace SerpientesEscaleras
{
    public class CallbackMultijugador : ServidorJuegoSE.IAdministradorMultijugadorCallback
    {
        /// <summary>
        /// Propiedad que nos sirve para acceder o modificar los valores
        /// del Juego
        /// </summary>
        public Juego Juego { get; set; }
        /// <summary>
        /// Propiedad que nos sirve para acceder o modificar los valores del  Lobby
        /// </summary>
        public Lobby Lobby { get; set; }
        /// <summary>
        /// Metodo que sirve para mostrar los mensajes dentro del contenedor del chat
        /// </summary>
        /// <param name="mensaje"></param>
        public void RecibirMensajeLobby(string mensaje)
        {
            Lobby.chat.Add(mensaje);
            Lobby.listBox_Chat.Items.Refresh();
        }
        /// <summary>
        /// Muestra los mensajes en el apartado del chat
        /// </summary>
        /// <param name="entrada">estado del mensaje</param>
        /// <param name="apodo"> Se refiere al usuario</param>
        public void RecibirMensajeMiembroLobby(Boolean entrada, String apodo)
        {
            if (entrada)
            {
                Lobby.chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                Lobby.jugadoresConectados.Add(apodo);
                Lobby.label_JugadoresConectados.Content = Lobby.jugadoresConectados.Count + Properties.Resources.jugadoresConectados;
            }
            else
            {
                Lobby.chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                Lobby.jugadoresConectados.Remove(apodo);
                Lobby.label_JugadoresConectados.Content = Lobby.jugadoresConectados.Count + Properties.Resources.jugadoresConectados;
            }
            Lobby.listBox_Chat.Items.Refresh();
            Lobby.listBox_JugadoresConectados.Items.Refresh();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="casillas"></param>
        /// <param name="portales"></param>
        public void EntrarJuego(ServidorJuegoSE.Casilla[] casillas, ServidorJuegoSE.Portal[] portales)
        {
            Lobby.EntrarJuego(casillas, portales);
        }

        public void RecibirMensaje(string mensaje)
        {
            Juego.chat.Add(mensaje);
            Juego.listBox_Chat.Items.Refresh();
        }

        public void RecibirMensajeMiembro(Boolean entrada, String apodo)
        {
            if (entrada)
            {
                int indiceApodo = Juego.jugadoresConectados.FindIndex(x => x.Contains(apodo));
                if (indiceApodo != -1)
                {
                    return;
                }
                Juego.chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                Juego.jugadoresConectados.Add(apodo);
            }
            else
            {
                Juego.chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                Juego.jugadoresConectados.Remove(apodo);
            }
            Juego.listBox_Chat.Items.Refresh();
            Juego.listBox_JugadoresConectados.Items.Refresh();
        }

        public void SolicitarCrearTablero()
        {

        }

        public void ElegirFicha(String apodo, ServidorJuegoSE.Ficha[] fichasEscogidas)
        {
            Turno turno = new Turno(Juego);
            Juego.label_Aviso.Content = apodo + " está eligiendo su ficha...";
            if (apodo.Equals(Juego.jugador.Apodo))
            {
                turno.ElegirFicha(fichasEscogidas.ToList());
                turno.ShowDialog();
            }
        }

        public void MostrarFichaElegida(ServidorJuegoSE.Ficha ficha)
        {
            Juego.jugadorEnTurno = ficha;
            Juego.MostrarFichaEnTablero();
        }

        public void Tirar(String apodo)
        {
            Turno turno = new Turno(Juego);
            Juego.label_Aviso.Content = apodo + " está tirando...";
            if (apodo.Equals(Juego.jugador.Apodo))
            {
                turno.Tirar();
                turno.ShowDialog();
            }
        }

        public void MostrarTiro(ServidorJuegoSE.Ficha ficha)
        {
            Juego.jugadorEnTurno = ficha;
            Juego.MoverFicha(false);
        }

        public void MostrarNuevosPortales(ServidorJuegoSE.Portal[] portales)
        {
            Juego.CambiarPortales(portales);
        }

        public void MostrarGanador(ServidorJuegoSE.Ficha ficha)
        {
            Turno turno = new Turno(Juego);
            Juego.label_Aviso.Content = "";
            turno.MostrarGanador(ficha);
            turno.ShowDialog();
            Juego.Close();
        }
    }
}
