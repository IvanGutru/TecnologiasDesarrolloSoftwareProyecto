using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using SerpientesEscaleras.ServidorJuegoSE;

namespace SerpientesEscaleras
{

    public partial class Juego : Window
    {
        InstanceContext contexto;
        private CallbackMultijugador regresoJuego;
        private MediaPlayer musicaFondo = new MediaPlayer();
        /// <summary>
        /// Constructor de la ventana de juego que inicializa las configuraciones y jugadores 
        /// para el comienzo de la partida.
        /// </summary>
        /// <param name="jugadorRecibido"></param>
        /// <param name="salaRecibida"></param>
        /// <param name="regresoMensaje"></param>
        public Juego(ServidorJuegoSE.Jugador jugadorRecibido, ServidorJuegoSE.Sala salaRecibida, CallbackMultijugador regresoMensaje)
        {
            Jugador = jugadorRecibido;
            Sala = salaRecibida;
            regresoJuego = regresoMensaje;
            InitializeComponent();
            listBox_Chat.ItemsSource = Chat;
            listBox_JugadoresConectados.ItemsSource = JugadoresConectados;
            regresoJuego.Juego = this;
            contexto = new InstanceContext(regresoJuego);
            ClienteMultijugador = new ServidorJuegoSE.AdministradorMultijugadorClient(contexto);
            ImageBrush brushGrid = new ImageBrush();
            brushGrid.ImageSource = new BitmapImage(new Uri(Sala.UriFondoTablero));
            grid_Tablero.Background = brushGrid;
            musicaFondo.MediaOpened += SoundTrackCargado;
            musicaFondo.MediaEnded += SoundTrackFinalizado;
            musicaFondo.Open(new Uri("pack://siteoforigin:,,,/SoundTracks/track1.mp3"));
        }

        public List<ServidorJuegoSE.Casilla> Casillas { get; set; }
        public List<ServidorJuegoSE.Portal> Portales { get; set; }
        public Jugador Jugador { get; set; }
        public List<string> Chat { get; set; } = new List<string>();
        public AdministradorMultijugadorClient ClienteMultijugador { get; set; }
        public Sala Sala { get; set; }
        public Ficha JugadorEnTurno { get; set; } = new ServidorJuegoSE.Ficha();
        public List<string> JugadoresConectados { get; set; } = new List<String>();

        /// <summary>
        /// Metodo que coloca las casillas y portales en el tablero
        /// </summary>
        public void InicializarTablero()
        {
            ColocarCasillasEspeciales();
            ColocarPortales();
        }

        private void SoundTrackCargado(object sender, EventArgs e)
        {
            musicaFondo.Play();
        }

        private void SoundTrackFinalizado(object sender, EventArgs e)
        {
            musicaFondo.Play();
        }
        /// <summary>
        /// Coloca las casillas especiales en el tablero
        /// </summary>
        private void ColocarCasillasEspeciales()
        {
            Image casillaEspecial;
            var casillasEspeciales = Casillas.Where(x => x.Especial).ToList();
            for (int i = 0; i < casillasEspeciales.Count; i++)
            {
                casillaEspecial = new Image();
                casillaEspecial.Source = new BitmapImage(new Uri("Resources/Tablero/casillaEspecial.png", UriKind.Relative));
                casillaEspecial.HorizontalAlignment = HorizontalAlignment.Left;
                casillaEspecial.VerticalAlignment = VerticalAlignment.Bottom;
                casillaEspecial.Height = 70;
                Grid.SetColumn(casillaEspecial, casillasEspeciales[i].Columna);
                Grid.SetRow(casillaEspecial, casillasEspeciales[i].Fila);
                grid_Tablero.Children.Add(casillaEspecial);
            }
        }
        /// <summary>
        /// Coloca los portales
        /// </summary>
        private void ColocarPortales()
        {
            ServidorJuegoSE.Casilla casilla;
            Image imagenPortal;
            for (int i = 0; i < Portales.Count; i++)
            {
                casilla = Casillas.Find(x => x.Id == Portales[i].IdCasilla);
                imagenPortal = new Image();
                imagenPortal.Source = new BitmapImage(new Uri(Portales[i].UriPortal, UriKind.Relative));
                imagenPortal.HorizontalAlignment = HorizontalAlignment.Left;
                imagenPortal.VerticalAlignment = VerticalAlignment.Bottom;
                imagenPortal.Height = 90;
                imagenPortal.Name = Portales[i].Color + Portales[i].ZonaTablero;
                Grid.SetRow(imagenPortal, casilla.Fila);
                Grid.SetColumn(imagenPortal, casilla.Columna);
                grid_Tablero.Children.Add(imagenPortal);
            }
        }

        private void Button_Enviar(object sender, RoutedEventArgs e)
        {
            if (textBox_Mensaje.Text != "")
            {
                ClienteMultijugador.EnviarMensajeJuego(Sala.IdSala, textBox_Mensaje.Text);
                textBox_Mensaje.Clear();
            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            musicaFondo.Stop();
            ClienteMultijugador.SalirJuego(Sala.IdSala);
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(Jugador);
            menuPrincipal.Show();
            this.Close();
        }

        public void RecibirListaJugadores(List<String> jugadores)
        {
            JugadoresConectados.AddRange(jugadores);
            listBox_JugadoresConectados.Items.Refresh();
        }

        public void Entrar()
        {
            ClienteMultijugador.UnirseJuego(Sala.IdSala, Jugador);
        }
        /// <summary>
        /// Mueve la casilla a traves de los portales, cambiandola de posicion
        /// </summary>
        /// <param name="cayoPortal"> verifica si cayó en un portal o no</param>
        public void MoverFicha(bool cayoPortal)
        {
            ServidorJuegoSE.Casilla casillaTemporal = Casillas.ElementAt(JugadorEnTurno.Posicion - 1);
            var imagenesTablero = grid_Tablero.Children.Cast<UIElement>().Where(i => i is Image).Cast<Image>();
            var fichaAMover = imagenesTablero.FirstOrDefault(i => i.Name == JugadorEnTurno.NombreFicha);
            Grid.SetColumn(fichaAMover, casillaTemporal.Columna);
            Grid.SetRow(fichaAMover, casillaTemporal.Fila);
            var portal = Portales.Find(x => x.IdCasilla == casillaTemporal.Id);
            if (portal != null && !cayoPortal)
            {
                var otroPortal = Portales.Find(x => x.Color == portal.Color && x.ZonaTablero != portal.ZonaTablero);
                JugadorEnTurno.Posicion = otroPortal.IdCasilla;
                if (JugadorEnTurno.ApodoJugador == Jugador.Apodo)
                {
                    ClienteMultijugador.CambiarPosicionFicha(Sala.IdSala, JugadorEnTurno);
                }
                DispatcherTimer temporizador = new DispatcherTimer();
                temporizador.Interval = TimeSpan.FromSeconds(2d);
                temporizador.Tick += TemporizadorDetenido;
                temporizador.Start();
            }
            if (casillaTemporal.Especial && JugadorEnTurno.ApodoJugador == Jugador.Apodo)
            {
                ClienteMultijugador.CambiarPortales(Sala.IdSala, Casillas.ToArray(), Portales.ToArray());
            }
        }

        private void TemporizadorDetenido(object sender, EventArgs e)
        {
            var temporizador = sender as DispatcherTimer;
            temporizador.Stop();
            MoverFicha(true);
        }
        /// <summary>
        /// Muestra la ficha en el tablero
        /// </summary>
        public void MostrarFichaEnTablero()
        {
            Image imagenFicha = new Image();
            imagenFicha.Source = new BitmapImage(new Uri(JugadorEnTurno.UriFicha, UriKind.Relative));
            imagenFicha.Name = JugadorEnTurno.NombreFicha;
            imagenFicha.Width = 70;
            imagenFicha.Height = 70;
            grid_Tablero.Children.Add(imagenFicha);
            Grid.SetColumn(imagenFicha, 0);
            Grid.SetRow(imagenFicha, 6);
        }
        /// <summary>
        /// Cambia los portales de casilla cuando cae en una casilla especial
        /// </summary>
        /// <param name="portalesRecibidos">lista de portales creados</param>
        public void CambiarPortales(ServidorJuegoSE.Portal[] portalesRecibidos)
        {
            for (int i = 0; i < Portales.Count; i++)
            {
                var casillaDelPortal = Casillas.Find(x => x.Id == Portales[i].IdCasilla);
                var imagenesEnCasilla = grid_Tablero.Children.Cast<UIElement>().Where
                    (x => x is Image && Grid.GetColumn(x) == casillaDelPortal.Columna
                    && Grid.GetRow(x) == casillaDelPortal.Fila).Cast<Image>();
                var portal = imagenesEnCasilla.FirstOrDefault(x => x.Name.Equals(Portales[i].Color + Portales[i].ZonaTablero));
                var nuevaCasilla = Casillas.Find(x => x.Id == portalesRecibidos[i].IdCasilla);
                Grid.SetRow(portal, nuevaCasilla.Fila);
                Grid.SetColumn(portal, nuevaCasilla.Columna);
            }
            Portales = portalesRecibidos.ToList();
        }
        /// <summary>
        /// Valida las entradas dentro de los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
