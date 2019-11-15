using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class Turno : Window
    {
        private Juego juego;
        public ServidorJuegoSE.Ficha ficha;

        public Turno(Juego juegoReferencia)
        {
            juego = juegoReferencia;
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void EligiendoFicha(String apodo)
        {
            label_Instruccion.Content = apodo + "está eligiendo su ficha...";
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5d);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void ElegirFicha()
        {
            label_Instruccion.Content = "Elija su ficha:";
            List<string> uriFichas = new List<string>();
            ColumnDefinition columna;
            String uri;
            Image imagenFicha;
            Rectangle rectangulo;
            for (int i = 1; i < 8; i++)
            {
                uri = "/Resources/Tablero/Fichas/ficha" + i + ".ico";
                uriFichas.Add(uri);
                columna = new ColumnDefinition();
                columna.Width = new GridLength(110);
                grid_Fichas.ColumnDefinitions.Add(columna);
                imagenFicha = new Image();
                imagenFicha.Source = new BitmapImage(new Uri(uri, UriKind.Relative));
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
            button_Elegir.Visibility = Visibility.Visible;
            button_Elegir.Content = "Elegir";
        }

        public void Tirando(String apodo)
        {
            label_Instruccion.Content = apodo + "está tirándo...";
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5d);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void Tirar()
        {
            label_Instruccion.Content = "Tira el dado:";
            button_Tirar.Visibility = Visibility.Visible;
            button_Tirar.Content = "Tirar";
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
            var direccionFicha = (Image)grid_Fichas.Children.Cast<UIElement>().First(i => i is Image && Grid.GetColumn(i) == Grid.GetColumn(rectangulo));
            ficha = new ServidorJuegoSE.Ficha()
            {
                UriFicha = ((BitmapImage)direccionFicha.Source).UriSource.OriginalString,
                ApodoJugador = juego.jugador.Apodo,
                Posicion = 1
            };
            this.Close();
            juego.clienteMultijugador.AsignarFicha(juego.idSala, ficha);
        }

        private void Button_Tirar(object sender, RoutedEventArgs e)
        {
            Random dado = new Random();
            int numDado = dado.Next(1, 7);
            this.Close();
            juego.clienteMultijugador.RecibirTiro(juego.idSala, numDado);
        }
    }
}
