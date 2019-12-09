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
        /// <summary>
        /// Constructor de la ventana lobby, implementa el servicio al callback para el multijugador
        /// </summary>
        /// <param name="jugadorRecibido"></param>
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
        /// <summary>
        /// Metodo que recibe la sala creada en la ventana crear partida y la añade al servidor para despues
        /// unirse a ella
        /// </summary>
        /// <param name="salaRecibida">Sala creada en la ventana crear partida</param>
        public void CrearPartida(ServidorJuegoSE.Sala salaRecibida)
        {
            sala = salaRecibida;
            sala.IdSala = clienteMultijugador.CrearSala(sala);
            clienteMultijugador.UnirseSala(sala.IdSala, jugador);
        }
        /// <summary>
        /// Verifica que si la sala está dispobible y que no haya empezado, de cumplirse
        /// añade a los jugadores a la partida
        /// </summary>
        /// <param name="salaRecibida">sala creada en la ventana crear partida</param>
        /// <returns>true si el jugador entró a la partida, false sino se pudo</returns>
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

        public void EntrarJuego(ServidorJuegoSE.Casilla[] casillas, ServidorJuegoSE.Portal[] portales)
        {
            Juego juego = new Juego(jugador, sala, regresoMensaje);
            juego.RecibirListaJugadores(jugadoresConectados);
            juego.Casillas = casillas.ToList();
            juego.Portales = portales.ToList();
            juego.InicializarTablero();
            juego.Show();
            this.Close();
            juego.Entrar();
        }

    }
}
