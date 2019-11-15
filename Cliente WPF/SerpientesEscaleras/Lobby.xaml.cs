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

    public partial class Lobby : Window
    {
        private int idSala;
        private ServidorJuegoSE.Jugador jugador;
        public List<String> chat = new List<string>();
        InstanceContext contexto;
        private ServidorJuegoSE.AdministradorMultijugadorClient clienteMultijugador;
        public List<String> jugadoresConectados = new List<String>();
        private CallbackMultijugador regresoMensaje;

        public Lobby(ServidorJuegoSE.Jugador jugadorRecibido)
        {
            jugador = jugadorRecibido;
            InitializeComponent();
            listBox_Chat.ItemsSource = chat;
            listBox_JugadoresConectados.ItemsSource = jugadoresConectados;
            regresoMensaje = new CallbackMultijugador
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
            Juego juego = new Juego(jugador, idSala, regresoMensaje);
            juego.RecibirListaJugadores(jugadoresConectados);
            juego.Show();
            this.Close();
            juego.Entrar();
        }

    }
}
