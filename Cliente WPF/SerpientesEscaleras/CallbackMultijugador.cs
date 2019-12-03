using System;
using System.Collections.Generic;
using System.Linq;

namespace SerpientesEscaleras
{
    public class CallbackMultijugador : ServidorJuegoSE.IAdministradorMultijugadorCallback
    {

        public Juego Juego { get; set; }

        public Lobby Lobby { get; set; }

        public void RecibirMensajeLobby(string mensaje)
        {
            Lobby.chat.Add(mensaje);
            Lobby.listBox_Chat.Items.Refresh();
        }

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

        public void EntrarJuego()
        {
            Lobby.EntrarJuego();
        }

        public void RecibirMensaje(string mensaje)
        {
            Juego.Chat.Add(mensaje);
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
                Juego.Chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                Juego.jugadoresConectados.Add(apodo);
            }
            else
            {
                Juego.Chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                Juego.jugadoresConectados.Remove(apodo);
            }
            Juego.listBox_Chat.Items.Refresh();
            Juego.listBox_JugadoresConectados.Items.Refresh();
        }

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

        public void MostrarFichaElegida(ServidorJuegoSE.Ficha ficha)
        {
            Juego.JugadorEnTurno = ficha;
            Juego.MostrarFichaEnTablero();
        }

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

        public void MostrarTiro(ServidorJuegoSE.Ficha ficha)
        {
            Juego.JugadorEnTurno = ficha;
            Juego.MoverFicha(false);
        }
    }
}
