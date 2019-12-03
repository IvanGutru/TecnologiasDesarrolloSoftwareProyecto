using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace SerpientesEscaleras
{

    public partial class Juego : Window
    {
        public ServidorJuegoSE.Jugador jugador;
        public List<String> chat = new List<string>();
        InstanceContext contexto;
        public ServidorJuegoSE.AdministradorMultijugadorClient clienteMultijugador;
        public List<String> jugadoresConectados = new List<String>();
        private List<ServidorJuegoSE.Casilla> casillas;
        private List<ServidorJuegoSE.Portal> portales;
        private CallbackMultijugador regresoJuego;
        public ServidorJuegoSE.Sala sala;
        public ServidorJuegoSE.Ficha jugadorEnTurno = new ServidorJuegoSE.Ficha();

        public Juego(ServidorJuegoSE.Jugador jugadorRecibido, ServidorJuegoSE.Sala salaRecibida, CallbackMultijugador regresoMensaje)
        {
            jugador = jugadorRecibido;
            sala = salaRecibida;
            regresoJuego = regresoMensaje;
            InitializeComponent();
            listBox_Chat.ItemsSource = chat;
            listBox_JugadoresConectados.ItemsSource = jugadoresConectados;
            regresoJuego.Juego = this;
            contexto = new InstanceContext(regresoJuego);
            clienteMultijugador = new ServidorJuegoSE.AdministradorMultijugadorClient(contexto);
            ImageBrush brushGrid = new ImageBrush();
            brushGrid.ImageSource = new BitmapImage(new Uri(sala.UriFondoTablero));
            grid_Tablero.Background = brushGrid;
            //CrearCasillas(7, 10);
            //Portal portal = new Portal();
            //portales = portal.CrearPortales();
        }

        public List<ServidorJuegoSE.Casilla> Casillas { get { return casillas; } set { casillas = value; } }
        public List<ServidorJuegoSE.Portal> Portales { get { return portales; } set { portales = value; } }

        public void InicializarTablero()
        {
            ColocarCasillasEspeciales();
            ColocarPortales();
        }

        //private void CrearCasillas(int filas, int columnas)
        //{
        //    int id = 1;
        //    int columna;
        //    for (int fila = filas-1; fila >= 0; fila--)
        //    {
        //        if (fila % 2 == 0)
        //        {
        //            for (columna = 0; columna < columnas; columna++)
        //            {
        //                casillas.Add(new Casilla(id, fila, columna));
        //                id++;
        //            }
        //        }
        //        else
        //        {
        //            for (columna = 9; columna >= 0; columna--)
        //            {
        //                casillas.Add(new Casilla(id, fila, columna));
        //                id++;
        //            }
        //        }
        //    }
        //}

        //private void CrearCasillasEspeciales()
        //{

        //}

        private void ColocarCasillasEspeciales()
        {
            //Random aleatorio = new Random();
            //int columna;
            //int indiceCasilla;
            Image casillaEspecial;
            var casillasEspeciales = casillas.Where(x => x.Especial).ToList();
            for (int i = 0; i < casillasEspeciales.Count(); i++)
            {
                //do
                //{
                //    columna = aleatorio.Next(0, 10);
                //    indiceCasilla = casillas.FindIndex(x => x.Columna == columna && x.Fila == i);
                //} while (casillas[indiceCasilla].Id == 70 || casillas[indiceCasilla].Id == 1);
                //casillas[indiceCasilla].Especial = true;
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

        private void ColocarPortales()
        {
            //Random aleatorio = new Random();
            ServidorJuegoSE.Casilla casilla;
            Image imagenPortal;
            //int portalEnCasilla;
            for (int i = 0; i < portales.Count; i++)
            {
                //do
                //{
                //    casilla = ObtenerCasillaAleatoria(i, aleatorio);
                //    portalEnCasilla = portales.FindIndex(x => x.IdCasilla == casilla.Id);
                //} while (casilla.Especial || portalEnCasilla != -1 || casilla.Id == 70 || casilla.Id == 1);
                //portales[i].IdCasilla = casilla.Id;
                casilla = casillas.Find(x => x.Id == portales[i].IdCasilla);
                imagenPortal = new Image();
                imagenPortal.Source = new BitmapImage(new Uri(portales[i].UriPortal, UriKind.Relative));
                imagenPortal.HorizontalAlignment = HorizontalAlignment.Left;
                imagenPortal.VerticalAlignment = VerticalAlignment.Bottom;
                imagenPortal.Height = 90;
                imagenPortal.Name = portales[i].Color + portales[i].ZonaTablero;
                Grid.SetRow(imagenPortal, casilla.Fila);
                Grid.SetColumn(imagenPortal, casilla.Columna);
                grid_Tablero.Children.Add(imagenPortal);
            }
        }

        private void Button_Enviar(object sender, RoutedEventArgs e)
        {
            if (textBox_Mensaje.Text != "")
            {
                clienteMultijugador.EnviarMensajeJuego(sala.IdSala, textBox_Mensaje.Text);
                textBox_Mensaje.Clear();
            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clienteMultijugador.SalirJuego(sala.IdSala);
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(jugador);
            menuPrincipal.Show();
            this.Close();
        }

        public void RecibirListaJugadores(List<String> jugadores)
        {
            jugadoresConectados.AddRange(jugadores);
            listBox_JugadoresConectados.Items.Refresh();
        }

        public void Entrar()
        {
            clienteMultijugador.UnirseJuego(sala.IdSala, jugador);
        }

        public void MoverFicha(bool cayoPortal)
        {
            ServidorJuegoSE.Casilla casillaTemporal = casillas.ElementAt(jugadorEnTurno.Posicion - 1);
            ImageSource fuenteFicha = new BitmapImage(new Uri(jugadorEnTurno.UriFicha, UriKind.Relative));
            var imagenesTablero = grid_Tablero.Children.Cast<UIElement>().Where(i => i is Image).Cast<Image>();
            var fichaAMover = imagenesTablero.FirstOrDefault(i => i.Name == jugadorEnTurno.NombreFicha);
            Grid.SetColumn(fichaAMover, casillaTemporal.Columna);
            Grid.SetRow(fichaAMover, casillaTemporal.Fila);
            var portal = portales.Find(x => x.IdCasilla == casillaTemporal.Id);
            if (portal != null && !cayoPortal)
            {
                var otroPortal = portales.Find(x => x.Color == portal.Color && x.ZonaTablero != portal.ZonaTablero);
                jugadorEnTurno.Posicion = otroPortal.IdCasilla;
                if (jugadorEnTurno.ApodoJugador == jugador.Apodo)
                {
                    clienteMultijugador.CambiarPosicionFicha(sala.IdSala, jugadorEnTurno);
                }
                DispatcherTimer temporizador = new DispatcherTimer();
                temporizador.Interval = TimeSpan.FromSeconds(2d);
                temporizador.Tick += TemporizadorDetenido;
                temporizador.Start();
            }
            if (casillaTemporal.Especial && jugadorEnTurno.ApodoJugador == jugador.Apodo)
            {
                clienteMultijugador.CambiarPortales(sala.IdSala, casillas.ToArray(), portales.ToArray());
            }
        }

        private void TemporizadorDetenido(object sender, EventArgs e)
        {
            var temporizador = sender as DispatcherTimer;
            temporizador.Stop();
            MoverFicha(true);
        }

        public void MostrarFichaEnTablero()
        {
            Image imagenFicha = new Image();
            imagenFicha.Source = new BitmapImage(new Uri(jugadorEnTurno.UriFicha, UriKind.Relative));
            imagenFicha.Name = jugadorEnTurno.NombreFicha;
            imagenFicha.Width = 70;
            imagenFicha.Height = 70;
            grid_Tablero.Children.Add(imagenFicha);
            Grid.SetColumn(imagenFicha, 0);
            Grid.SetRow(imagenFicha, 6);
        }

        public void CambiarPortales(ServidorJuegoSE.Portal[] portalesRecibidos)
        {
            //Random aleatorio = new Random();
            //int portalEnCasilla;
            for (int i = 0; i < portales.Count; i++)
            {
                //do
                //{
                //    casilla = ObtenerCasillaAleatoria(i, aleatorio);
                //    portalEnCasilla = portales.FindIndex(x => x.IdCasilla == casilla.Id);
                //} while (casilla.Especial || casilla.Id == 70 || casilla.Id == 1 || (portalEnCasilla < i && portalEnCasilla >= 0));
                var casillaDelPortal = casillas.Find(x => x.Id == portales[i].IdCasilla);
                var imagenesEnCasilla = grid_Tablero.Children.Cast<UIElement>().Where
                    (x => x is Image && Grid.GetColumn(x) == casillaDelPortal.Columna
                    && Grid.GetRow(x) == casillaDelPortal.Fila).Cast<Image>();
                var portal = imagenesEnCasilla.FirstOrDefault(x => x.Name.Equals(portales[i].Color + portales[i].ZonaTablero));
                var nuevaCasilla = casillas.Find(x => x.Id == portalesRecibidos[i].IdCasilla);
                //portales[i].IdCasilla = casilla.Id;
                Grid.SetRow(portal, nuevaCasilla.Fila);
                Grid.SetColumn(portal, nuevaCasilla.Columna);
            }
            portales = portalesRecibidos.ToList();
        }

        //private Casilla ObtenerCasillaAleatoria(int indice, Random aleatorio)
        //{
        //    int fila;
        //    int columna;
        //    if (portales[indice].ZonaTablero.Equals("abajo"))
        //    {
        //        fila = aleatorio.Next(4, 7);
        //    }
        //    else
        //    {
        //        fila = aleatorio.Next(0, 4);
        //    }
        //    columna = aleatorio.Next(0, 10);
        //    return casillas.Find(x => x.Columna == columna && x.Fila == fila);
        //}

        //public void CrearTablero()
        //{

        //}

    }
}
