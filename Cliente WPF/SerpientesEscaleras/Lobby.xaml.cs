using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows;


namespace SerpientesEscaleras
{

    public partial class Lobby : Window
    {
        private ServidorJuegoSE.Jugador jugador;
        public List<String> chat = new List<string>();
        InstanceContext contexto;
        private ServidorJuegoSE.AdministradorMultijugadorClient clienteMultijugador;
        public List<String> jugadoresConectados = new List<String>();
        private CallbackMultijugador regresoMensaje;
        private ServidorJuegoSE.Sala sala;

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

        public void CrearPartida(ServidorJuegoSE.Sala salaRecibida)
        {
            sala = salaRecibida;
            sala.IdSala = clienteMultijugador.CrearSala(sala);
            clienteMultijugador.UnirseSala(sala.IdSala, jugador);
        }

        public Boolean EntrarPartida(ServidorJuegoSE.Sala salaRecibida)
        {
            sala = salaRecibida;
            if (clienteMultijugador.ValidarSala(sala.IdSala))
            {
                jugadoresConectados = clienteMultijugador.ConsultarJugadoresSala(sala.IdSala).ToList();
                listBox_JugadoresConectados.ItemsSource = jugadoresConectados;
                clienteMultijugador.UnirseSala(sala.IdSala, jugador);
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
                clienteMultijugador.EnviarMensaje(sala.IdSala, textBox_Mensaje.Text);
                textBox_Mensaje.Clear();
            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clienteMultijugador.SalirChat(sala.IdSala);
        }

        private void Button_Regresar(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(jugador);
            menuPrincipal.Show();
            this.Close();
        }

        private void Button_Jugar(object sender, RoutedEventArgs e)
        {
            clienteMultijugador.IniciarJuego(sala.IdSala);
        }

        public void EntrarJuego()
        {
            Juego juego = new Juego(jugador, sala, regresoMensaje);
            juego.RecibirListaJugadores(jugadoresConectados);
            juego.Show();
            this.Close();
            juego.Entrar();
        }

    }
}
