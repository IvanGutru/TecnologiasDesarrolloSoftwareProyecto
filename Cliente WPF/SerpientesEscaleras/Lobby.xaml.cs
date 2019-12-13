using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace SerpientesEscaleras
{

    public partial class Lobby : Window
    {
        private ServidorJuegoSE.Jugador jugador;
        InstanceContext contexto;
        private ServidorJuegoSE.AdministradorMultijugadorClient clienteMultijugador;
        private CallbackMultijugador regresoMensaje;
        private ServidorJuegoSE.Sala sala;

        public List<string> Chat { get; set; } = new List<string>();
        public List<string> JugadoresConectados { get; set; } = new List<String>();

        /// <summary>
        /// Constructor de la ventana Lobby donde se muestan los jugadores
        /// para la partida, inicializa el chat
        /// </summary>
        /// <param name="jugadorRecibido"></param>
        public Lobby(ServidorJuegoSE.Jugador jugadorRecibido)
        {
            jugador = jugadorRecibido;
            InitializeComponent();
            listBox_Chat.ItemsSource = Chat;
            listBox_JugadoresConectados.ItemsSource = JugadoresConectados;
            regresoMensaje = new CallbackMultijugador
            {
                Lobby = this
            };
            contexto = new InstanceContext(regresoMensaje);
            clienteMultijugador = new ServidorJuegoSE.AdministradorMultijugadorClient(contexto);
        }
        /// <summary>
        /// Recibe la sala que se creo en la ventana crear partida, la manda al servidor y 
        /// une al jugador a dicha sala
        /// </summary>
        /// <param name="salaRecibida"> sala configurada</param>
        public void CrearPartida(ServidorJuegoSE.Sala salaRecibida)
        {
            sala = salaRecibida;
            sala.IdSala = clienteMultijugador.CrearSala(sala);
            clienteMultijugador.UnirseSala(sala.IdSala, jugador);
        }
        /// <summary>
        /// Metodo que valida que haya lugares en la sala, y mete la 
        /// lista de los jugadores a la partida.
        /// </summary>
        /// <param name="salaRecibida"> sala que se configuró en la pantalla crear partida "</param>
        /// <returns>true si se metieron a la partida, false si la sala está llena</returns>
        public Boolean EntrarPartida(ServidorJuegoSE.Sala salaRecibida)
        {
            sala = salaRecibida;
            if (clienteMultijugador.ValidarSala(sala.IdSala))
            {
                JugadoresConectados = clienteMultijugador.ConsultarJugadoresSala(sala.IdSala).ToList();
                listBox_JugadoresConectados.ItemsSource = JugadoresConectados;
                clienteMultijugador.UnirseSala(sala.IdSala, jugador);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Metodo que consulta las salas que se encuentran disponibles y la regresa
        /// a la ventana de buscar partida
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Recibe las casillas y los portales, llama a inicializar el tablero 
        /// muestra la ventana de juego y cierra el lobby
        /// </summary>
        /// <param name="casillas">casillas implementadas en el tablero</param>
        /// <param name="portales">portales implementados en el tablero</param>
        public void EntrarJuego(ServidorJuegoSE.Casilla[] casillas, ServidorJuegoSE.Portal[] portales)
        {
            Juego juego = new Juego(jugador, sala, regresoMensaje);
            juego.RecibirListaJugadores(JugadoresConectados);
            juego.Casillas = casillas.ToList();
            juego.Portales = portales.ToList();
            juego.InicializarTablero();
            juego.Show();
            this.Close();
            juego.Entrar();
        }

        private void ValidarTexto(object sender, RoutedEventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                return;
            }
            if (!Regex.IsMatch(textbox.Text, @"[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show(Properties.Resources.camposInvalidos);
                textbox.Clear();
            }
        }

    }
}
