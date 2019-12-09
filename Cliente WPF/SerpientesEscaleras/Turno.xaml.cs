using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfAnimatedGif;

namespace SerpientesEscaleras
{
    public partial class Turno : Window
    {
        private Juego juego;
        public ServidorJuegoSE.Ficha ficha;
        private ImageAnimationController controladorGif;
        private ImageAnimationController controladorGif2;
        private Random aleatorio = new Random();
        private int numeroDado1;
        private int numeroDado2 = 0;
        private bool cerrar = false;
        /// <summary>
        /// Constructor de la ventana tuno
        /// </summary>
        /// <param name="juegoReferencia"> la configuracion del juego</param>
        public Turno(Juego juegoReferencia)
        {
            juego = juegoReferencia;
            InitializeComponent();
        }
        /// <summary>
        /// Muestra la ventana con las fichas a elegir
        /// </summary>
        /// <param name="fichasEscogidas">lista de fichas disponibles</param>
        public void ElegirFicha(List<ServidorJuegoSE.Ficha> fichasEscogidas)
        {
            label_Instruccion.Content = "Elija su ficha:";
            ColumnDefinition columna;
            String uri;
            Image imagenFicha;
            Rectangle rectangulo;
            for (int i = 1; i <= 8; i++)
            {
                uri = "/Resources/Tablero/Fichas/ficha" + i + ".ico";
                if (fichasEscogidas.Find(x => x.UriFicha.Equals(uri)) == null)
                {
                    columna = new ColumnDefinition();
                    columna.Width = new GridLength(110);
                    grid_Fichas.ColumnDefinitions.Add(columna);
                    imagenFicha = new Image();
                    imagenFicha.Source = new BitmapImage(new Uri(uri, UriKind.Relative));
                    imagenFicha.Name = "ficha"+i;
                    rectangulo = new Rectangle();
                    rectangulo.Stretch = Stretch.Fill;
                    rectangulo.Stroke = new SolidColorBrush(Colors.Azure);
                    rectangulo.StrokeThickness = 5;
                    rectangulo.Opacity = 0;
                    rectangulo.Fill = new SolidColorBrush(Colors.Transparent);
                    rectangulo.MouseDown += Rectangle_Clic;
                    Grid.SetColumn(imagenFicha, i - 1);
                    Grid.SetColumn(rectangulo, i - 1);
                    grid_Fichas.Children.Add(imagenFicha);
                    grid_Fichas.Children.Add(rectangulo);
                }
            }
            scrollViewer_Fichas.Visibility = Visibility.Visible;
            button_Elegir.Visibility = Visibility.Visible;
            button_Elegir.Content = "Elegir";
        }

        private void Rectangle_Clic(object sender, MouseButtonEventArgs e)
        {
            Rectangle rectangulo = sender as Rectangle;
            var rectanguloSeleccionado = grid_Fichas.Children.Cast<UIElement>().FirstOrDefault(i => i is Rectangle && i.Opacity == 1);
            if (rectanguloSeleccionado != null)
            {
                rectanguloSeleccionado.Opacity = 0;
            }
            rectangulo.Opacity = 1;
        }

        private void Button_Elegir(object sender, RoutedEventArgs e)
        {
            var rectangulo = grid_Fichas.Children.Cast<UIElement>().FirstOrDefault(i => i is Rectangle && i.Opacity == 1);
            if (rectangulo == null)
            {
                MessageBox.Show("Debe elegir una ficha");
                return;
            }
            var direccionFicha = (Image)grid_Fichas.Children.Cast<UIElement>().First(i => i is Image && Grid.GetColumn(i) == Grid.GetColumn(rectangulo));
            ficha = new ServidorJuegoSE.Ficha()
            {
                NombreFicha = direccionFicha.Name,
                UriFicha = ((BitmapImage)direccionFicha.Source).UriSource.OriginalString,
                ApodoJugador = juego.jugador.Apodo,
                Posicion = 1
            };
            cerrar = true;
            this.Close();
            juego.clienteMultijugador.AsignarFicha(juego.sala.IdSala, ficha);
        }

        public void Tirar()
        {
            label_Instruccion.Content = "Tira el dado:";
            button_Tirar.Content = "Tirar";
            grid_Dados.Visibility = Visibility.Visible;
            if (juego.sala.DobleDado)
            {
                MostrarDados(2);
                image_Dado2.Visibility = Visibility.Visible;
            }
            else
            {
                MostrarDados(1);
            }
            image_Dado.Visibility = Visibility.Visible;
        }

        private void Button_Tirar(object sender, RoutedEventArgs e)
        {
            button_Tirar.Visibility = Visibility.Hidden;
            numeroDado1 = aleatorio.Next(1, 7);
            if (juego.sala.DobleDado)
            {
                numeroDado2 = aleatorio.Next(1, 7);
                controladorGif2.Play();
            }
            controladorGif.Play();
        }

        private void gif_Cargado(object sender, RoutedEventArgs e)
        {
            controladorGif = ImageBehavior.GetAnimationController(image_Dado);
            button_Tirar.Visibility = Visibility.Visible;
        }

        private void gif2_Cargado(object sender, RoutedEventArgs e)
        {
            controladorGif2 = ImageBehavior.GetAnimationController(image_Dado2);
        }

        private void gif_Terminado(object sender, RoutedEventArgs e)
        {
            image_Dado.Visibility = Visibility.Collapsed;
            Image caraDado = new Image();
            String uri = "/Resources/Tablero/Dado/cara" + numeroDado1 + ".png";
            caraDado.Source = new BitmapImage(new Uri(uri, UriKind.Relative));
            Grid.SetColumn(caraDado, 0);
            grid_Dados.Children.Add(caraDado);
            DispatcherTimer temporizador = new DispatcherTimer();
            temporizador.Interval = TimeSpan.FromSeconds(3d);
            temporizador.Tick += temporizadorDetenido;
            temporizador.Start();
        }

        private void gif2_Terminado(object sender, RoutedEventArgs e)
        {
            image_Dado2.Visibility = Visibility.Collapsed;
            Image caraDado = new Image();
            String uri = "/Resources/Tablero/Dado/cara" + numeroDado2 + ".png";
            caraDado.Source = new BitmapImage(new Uri(uri, UriKind.Relative));
            Grid.SetColumn(caraDado, 1);
            grid_Dados.Children.Add(caraDado);
        }

        private void temporizadorDetenido(object sender, EventArgs e)
        {
            var temporizador = sender as DispatcherTimer;
            temporizador.Stop();
            cerrar = true;
            this.Close();
            juego.clienteMultijugador.RecibirTiro(juego.sala.IdSala, numeroDado1 + numeroDado2);
        }

        private void MostrarDados(int numDados)
        {
            ColumnDefinition columna;
            for (int i = 0; i < numDados; i++)
            {
                var gifDado = new BitmapImage();
                gifDado.BeginInit();
                gifDado.UriSource = new Uri("/Resources/Tablero/Dado/dado.gif", UriKind.Relative);
                gifDado.EndInit();
                columna = new ColumnDefinition();
                columna.Width = new GridLength(110);
                grid_Dados.ColumnDefinitions.Add(columna);
                if (i == 0)
                {
                    ImageBehavior.SetAnimatedSource(image_Dado, gifDado);
                    Grid.SetColumn(image_Dado, i);
                }
                else
                {
                    ImageBehavior.SetAnimatedSource(image_Dado2, gifDado);
                    Grid.SetColumn(image_Dado, i);
                }
            }
        }

        public void MostrarGanador(ServidorJuegoSE.Ficha fichaGanador)
        {
            label_Instruccion.Content = "El ganador es: " + fichaGanador.ApodoJugador;
            ColumnDefinition columna = new ColumnDefinition();
            columna.Width = new GridLength(110);
            grid_Dados.ColumnDefinitions.Add(columna);
            Image imagenGanador = new Image();
            imagenGanador.Source = new BitmapImage(new Uri(fichaGanador.UriFicha, UriKind.Relative));
            imagenGanador.Width = 100;
            grid_Dados.Children.Add(imagenGanador);
            Grid.SetColumn(imagenGanador, 0);
            Grid.SetRow(imagenGanador, 0);
            button_Salir.Content = "Salir";
            button_Salir.Visibility = Visibility.Visible;
            grid_Dados.Visibility = Visibility.Visible;
        }

        private void Cerrando(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!cerrar)
            {
                e.Cancel = true;
            }
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {
            cerrar = true;
            MenuPrincipal menuPrincipal = new MenuPrincipal(juego.jugador);
            menuPrincipal.Show();
            this.Close();
        }
    }
}
