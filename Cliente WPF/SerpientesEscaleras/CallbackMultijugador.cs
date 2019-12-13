using System;
using System.Collections.Generic;
using System.Linq;

namespace SerpientesEscaleras
{
    public class CallbackMultijugador : ServidorJuegoSE.IAdministradorMultijugadorCallback
    {
        public Juego Juego { get; set; }

        public Lobby Lobby { get; set; }
        /// <summary>
        /// Muestra los mensajes en el chat
        /// </summary>
        /// <param name="mensaje">mensaje enviado por el jugador</param>
        public void RecibirMensajeLobby(string mensaje)
        {
            Lobby.Chat.Add(mensaje);
            Lobby.listBox_Chat.Items.Refresh();
        }
        /// <summary>
        /// Muestra mensaje del jugador que ingreso a la partida
        /// </summary>
        /// <param name="entrada">Indica true si el jugador entro a la partida y falso si salio</param>
        /// <param name="apodo">apodo del  jugador</param>
        public void RecibirMensajeMiembroLobby(Boolean entrada, String apodo)
        {
            if (entrada)
            {
                Lobby.Chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                Lobby.JugadoresConectados.Add(apodo);
                Lobby.label_JugadoresConectados.Content = Lobby.JugadoresConectados.Count + Properties.Resources.jugadoresConectados;
            }
            else
            {
                Lobby.Chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                Lobby.JugadoresConectados.Remove(apodo);
                Lobby.label_JugadoresConectados.Content = Lobby.JugadoresConectados.Count + Properties.Resources.jugadoresConectados;
            }
            Lobby.listBox_Chat.Items.Refresh();
            Lobby.listBox_JugadoresConectados.Items.Refresh();
        }
        /// <summary>
        /// Muestra la pantalla de juego y carga los configuraciones
        /// </summary>
        /// <param name="casillas"> casillas implementadas en el tablero</param>
        /// <param name="portales">portales implementados en el tablero</param>
        public void EntrarJuego(ServidorJuegoSE.Casilla[] casillas, ServidorJuegoSE.Portal[] portales)
        {
            Lobby.EntrarJuego(casillas, portales);
        }
        /// <summary>
        /// Muestra los mensajes en el chat
        /// </summary>
        /// <param name="mensaje">mensaje enviado por el jugador</param>
        public void RecibirMensaje(string mensaje)
        {
            Juego.Chat.Add(mensaje);
            Juego.listBox_Chat.Items.Refresh();
        }
        /// <summary>
        /// Muestra los mensajes de entrada y salida de los jugadores
        /// </summary>
        /// <param name="entrada">Indica true si el jugador entro a la partida y falso si salio</param>
        /// <param name="apodo">apodo del jugador</param>
        public void RecibirMensajeMiembro(Boolean entrada, String apodo)
        {
            if (entrada)
            {
                int indiceApodo = Juego.JugadoresConectados.FindIndex(x => x.Contains(apodo));
                if (indiceApodo != -1)
                {
                    return;
                }
                Juego.Chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                Juego.JugadoresConectados.Add(apodo);
            }
            else
            {
                Juego.Chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                Juego.JugadoresConectados.Remove(apodo);
            }
            Juego.listBox_Chat.Items.Refresh();
            Juego.listBox_JugadoresConectados.Items.Refresh();
        }

        /// <summary>
        /// Prepara la ventana de turno con las fichas para que un jugador
        /// pueda elegir alguna
        /// </summary>
        /// <param name="apodo"> apodo del jugador que eligió la ficha</param>
        /// <param name="fichasEscogidas">ficha elegida por el jugador</param>
        public void ElegirFicha(String apodo, ServidorJuegoSE.Ficha[] fichasEscogidas)
        {
            Turno turno = new Turno(Juego);
            Juego.label_Aviso.Content = apodo + " está eligiendo su ficha...";
            if (apodo.Equals(Juego.Jugador.Apodo))
            {
                turno.ElegirFicha(fichasEscogidas.ToList());
                turno.ShowDialog();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void SolicitarCrearTablero()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Muestra la ficha elegida por el jugador
        /// </summary>
        /// <param name="ficha"> es la ficha elegida por el jugador</param>
        public void MostrarFichaElegida(ServidorJuegoSE.Ficha ficha)
        {
            Juego.JugadorEnTurno = ficha;
            Juego.MostrarFichaEnTablero();
        }
        /// <summary>
        /// Muestra la ventana Turno con el dado 
        /// </summary>
        /// <param name="apodo">apodo del jugador que realiza el tiro</param>
        public void Tirar(String apodo)
        {
            Turno turno = new Turno(Juego);
            Juego.label_Aviso.Content = apodo + " está tirando...";
            if (apodo.Equals(Juego.Jugador.Apodo))
            {
                turno.Tirar();
                turno.ShowDialog();
            }
        }
        /// <summary>
        /// Muestra la posicion en la que se movio la fiucha
        /// </summary>
        /// <param name="ficha">Ficha que se mueve</param>
        public void MostrarTiro(ServidorJuegoSE.Ficha ficha)
        {
            Juego.JugadorEnTurno = ficha;
            Juego.MoverFicha(false);
        }
  
        /// <summary>
        /// Recibe la lista de los nuevos portales y llama al juego para
        /// coloacarlos
        /// </summary>
        /// <param name="portales">lista de los portales</param>
        public void MostrarNuevosPortales(ServidorJuegoSE.Portal[] portales)
        {
            Juego.CambiarPortales(portales);
        }
        /// <summary>
        /// Muestra la ventana con el jugador que gano la partida
        /// </summary>
        /// <param name="ficha">ficha del jugador quegano</param>
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
