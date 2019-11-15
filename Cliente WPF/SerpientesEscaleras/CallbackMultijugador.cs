using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SerpientesEscaleras
{
    public class CallbackMultijugador : ServidorJuegoSE.IAdministradorMultijugadorCallback
    {
        private Lobby lobby;
        private Juego juego;

        public Juego Juego { get => juego; set => juego = value; }

        public Lobby Lobby { get => lobby; set => lobby = value; }

        public void RecibirMensajeLobby(string mensaje)
        {
            lobby.chat.Add(mensaje);
            lobby.listBox_Chat.Items.Refresh();
        }

        public void RecibirMensajeMiembroLobby(Boolean entrada, String apodo)
        {
            if (entrada)
            {
                lobby.chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                lobby.jugadoresConectados.Add(apodo);
                lobby.label_JugadoresConectados.Content = lobby.jugadoresConectados.Count + Properties.Resources.jugadoresConectados;
            }
            else
            {
                lobby.chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                lobby.jugadoresConectados.Remove(apodo);
                lobby.label_JugadoresConectados.Content = lobby.jugadoresConectados.Count + Properties.Resources.jugadoresConectados;
            }
            lobby.listBox_Chat.Items.Refresh();
            lobby.listBox_JugadoresConectados.Items.Refresh();
        }

        public void EntrarJuego()
        {
            lobby.EntrarJuego();
        }

        public void RecibirMensaje(string mensaje)
        {
            juego.chat.Add(mensaje);
            juego.listBox_Chat.Items.Refresh();
        }

        public void RecibirMensajeMiembro(Boolean entrada, String apodo)
        {
            if (entrada)
            {
                int indiceApodo = juego.jugadoresConectados.FindIndex(x => x.Contains(apodo));
                if (indiceApodo != -1)
                {
                    return;
                }
                juego.chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                juego.jugadoresConectados.Add(apodo);
            }
            else
            {
                juego.chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                juego.jugadoresConectados.Remove(apodo);
            }
            juego.listBox_Chat.Items.Refresh();
            juego.listBox_JugadoresConectados.Items.Refresh();
        }

        public void ElegirFicha(String apodo)
        {
            Turno turno = new Turno(juego);
            if (apodo.Equals(juego.jugador.Apodo))
            {
                turno.ElegirFicha();
            }
            else
            {
                turno.EligiendoFicha(apodo);
            }
            turno.ShowDialog();
        }

        public void MostrarFichaElegida(ServidorJuegoSE.Ficha ficha, int ordenJugador)
        {
            juego.OrdenTurno = ordenJugador;
            switch (ordenJugador)
            {
                case 0:
                    juego.image_Token1.Source = new BitmapImage(new Uri(ficha.UriFicha, UriKind.Relative));
                    break;
                case 1:
                    juego.image_Token2.Source = new BitmapImage(new Uri(ficha.UriFicha, UriKind.Relative));
                    break;
                case 2:
                    juego.image_Token3.Source = new BitmapImage(new Uri(ficha.UriFicha, UriKind.Relative));
                    break;
                case 3:
                    juego.image_Token4.Source = new BitmapImage(new Uri(ficha.UriFicha, UriKind.Relative));
                    break;
            }
        }

        public void Tirar(String apodo)
        {
            Turno turno = new Turno(juego);
            if (apodo.Equals(juego.jugador.Apodo))
            {
                turno.Tirar();
            }
            else
            {
                turno.Tirando(apodo);
            }
            turno.ShowDialog();
        }

        public void MostrarTiro(int ordenJugador, int posicion)
        {
            juego.OrdenTurno = ordenJugador;
            juego.label_Dado.Content = posicion;
            juego.posicion = posicion;
            juego.MoverFicha(ordenJugador);
        }
    }
}
