using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SerpientesEscaleras
{
    public class RegresoMensaje : ServidorJuegoSE.IAdministradorMultijugadorCallback
    {
        private Lobby lobby;

        public Lobby Lobby { get => lobby; set => lobby = value; }

        public void RecibirMensaje(string mensaje)
        {
            lobby.chat.Add(mensaje);
            lobby.listBox_Chat.Items.Refresh();
        }

        public void RecibirMensajeMiembro(Boolean entrada, String apodo)
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
    }

    public partial class Lobby : Window
    {
        private int idSala;
        private ServidorJuegoSE.Jugador jugador;
        public List<String> chat = new List<string>();
        InstanceContext contexto;
        private ServidorJuegoSE.AdministradorMultijugadorClient clienteMultijugador;
        public List<String> jugadoresConectados = new List<String>();

        public Lobby(ServidorJuegoSE.Jugador jugadorRecibido)
        {
            jugador = jugadorRecibido;
            InitializeComponent();
            listBox_Chat.ItemsSource = chat;
            listBox_JugadoresConectados.ItemsSource = jugadoresConectados;
            RegresoMensaje regresoMensaje = new RegresoMensaje
            {
                Lobby = this
            };
            contexto = new InstanceContext(regresoMensaje);
            clienteMultijugador = new ServidorJuegoSE.AdministradorMultijugadorClient(contexto);
        }

        public void CrearPartida(ServidorJuegoSE.Sala sala)
        {
            idSala = clienteMultijugador.CrearSala(sala);
            clienteMultijugador.UnirseSala(idSala, jugador);
        }

        public Boolean EntrarPartida(int idSalaRecibido)
        {
            idSala = idSalaRecibido;
            if (clienteMultijugador.ValidarSala(idSala))
            {
                jugadoresConectados = clienteMultijugador.ConsultarJugadoresSala(idSala).ToList();
                listBox_JugadoresConectados.ItemsSource = jugadoresConectados;
                clienteMultijugador.UnirseSala(idSala, jugador);
                return true;
            }
            return false;
        }

        public List<ServidorJuegoSE.Sala> ConsultarPartidasDisponibles()
        {
            return clienteMultijugador.ConsultarSalasDisponibles().ToList();
        }

        private void Button_Enviar(object sender, RoutedEventArgs e)
        {
            if (textBox_Mensaje.Text != "")
            {
                clienteMultijugador.EnviarMensaje(idSala, textBox_Mensaje.Text);
                textBox_Mensaje.Clear();
            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clienteMultijugador.SalirChat(idSala);
        }

        private void Button_Regresar(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(jugador);
            menuPrincipal.Show();
            this.Close();
        }

        private void Button_Jugar(object sender, RoutedEventArgs e)
        {
            clienteMultijugador.IniciarJuego(idSala);
        }

        public void EntrarJuego()
        {
            Juego juego = new Juego(jugador, idSala);
            juego.Show();
            this.Close();
            juego.RecibirListaJugadores(jugadoresConectados);
            juego.Entrar();
        }
    }
}
