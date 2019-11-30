using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
        private List<Casilla> casillas = new List<Casilla>();
        private CallbackMultijugador regresoJuego;
        public ServidorJuegoSE.Sala sala;
        public ServidorJuegoSE.Ficha jugadorEnTurno = new ServidorJuegoSE.Ficha();
        private Portal portalCaido;

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
            CrearCasillas(7, 10);
            ColocarPortales();
        }

        private void CrearCasillas(int filas, int columnas)
        {
            int id = 1;
            int columna;
            for (int fila = filas-1; fila >= 0; fila--)
            {
                if (fila % 2 == 0)
                {
                    for (columna = 0; columna < columnas; columna++)
                    {
                        casillas.Add(new Casilla(id, fila, columna));
                        id++;
                    }
                }
                else
                {
                    for (columna = 9; columna >= 0; columna--)
                    {
                        casillas.Add(new Casilla(id, fila, columna));
                        id++;
                    }
                }
            }
        }

        private void ColocarPortales()
        {
            Portal portal = new Portal();
            List<Portal> portales = portal.CrearPortales();
            Random aleatorio = new Random();
            int fila;
            int columna;
            Casilla casilla;
            Image imagenPortal;
            for (int i = 0; i < 12; i++)
            {
                do
                {
                    if ((i + 1) % 2 == 0)
                    {
                        fila = aleatorio.Next(4, 7);
                    }
                    else
                    {
                        fila = aleatorio.Next(0, 4);
                    }
                    columna = aleatorio.Next(0, 10);
                    casilla = casillas.Find(x => x.Columna == columna && x.Fila == fila);
                } while (casilla.Especial || casilla.Portal != null || casilla.Id == 70 || casilla.Id == 1);
                casilla.Portal = portales[i];
                imagenPortal = new Image();
                imagenPortal.Source = new BitmapImage(new Uri(portales[i].UriPortal, UriKind.Relative));
                imagenPortal.HorizontalAlignment = HorizontalAlignment.Left;
                imagenPortal.VerticalAlignment = VerticalAlignment.Bottom;
                imagenPortal.Height = 90;
                Grid.SetRow(imagenPortal, fila);
                Grid.SetColumn(imagenPortal, columna);
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

        private void Button_Tirar(object sender, RoutedEventArgs e)
        {
            Random dado = new Random();
            int numDado = dado.Next(1, 7);
            int posicion = 1;
            posicion = posicion + numDado;
            if (posicion > 70)
            {
                posicion = 70 - (posicion-70);
            }
            Casilla casillaTemporal = casillas.ElementAt(posicion-1);
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
            Casilla casillaTemporal = casillas.ElementAt(jugadorEnTurno.Posicion - 1);
            ImageSource fuenteFicha = new BitmapImage(new Uri(jugadorEnTurno.UriFicha, UriKind.Relative));
            var imagenesTablero = grid_Tablero.Children.Cast<UIElement>().Where(i => i is Image).Cast<Image>();
            var fichaAMover = imagenesTablero.FirstOrDefault(i => i.Name == jugadorEnTurno.NombreFicha);
            Grid.SetColumn(fichaAMover, casillaTemporal.Columna);
            Grid.SetRow(fichaAMover, casillaTemporal.Fila);
            if (casillaTemporal.Portal != null && !cayoPortal)
            {
                portalCaido = casillaTemporal.Portal;
                DispatcherTimer temporizador = new DispatcherTimer();
                temporizador.Interval = TimeSpan.FromSeconds(2d);
                temporizador.Tick += TemporizadorDetenido;
                temporizador.Start();
            }
        }

        private void TemporizadorDetenido(object sender, EventArgs e)
        {
            var temporizador = sender as DispatcherTimer;
            temporizador.Stop();
            var otroPortal = casillas.Find(
                x => x.Portal !=null && x.Portal.Color == portalCaido.Color && x.Portal.ZonaTablero != portalCaido.ZonaTablero
                );
            jugadorEnTurno.Posicion = otroPortal.Id;
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

    }
}
