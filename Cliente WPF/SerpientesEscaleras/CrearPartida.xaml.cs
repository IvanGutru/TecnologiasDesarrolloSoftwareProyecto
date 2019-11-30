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

namespace SerpientesEscaleras
{
    public partial class CrearPartida : Window
    {
        private ServidorJuegoSE.Jugador jugador = new ServidorJuegoSE.Jugador();

        public CrearPartida(ServidorJuegoSE.Jugador jugadorRecibido)
        {
            jugador = jugadorRecibido;
            InitializeComponent();
            textBox_Nombre.Focus();
        }

        private void TextBox_Nombre_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_Nombre.Text == "")
            {
                label_Nombre.Visibility = Visibility.Visible;
            }
        }

        private void TextBox_Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            label_Nombre.Visibility = Visibility.Hidden;
        }

        private void Label_Nombre_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox_Nombre.Focus();
        }

        private void Button_Regresar(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(jugador);
            menuPrincipal.Show();
            this.Close();
        }

        private void Button_CrearPartida(object sender, RoutedEventArgs e)
        {
            if (!VerificarCampos())
            {
                return;
            }
            var rectangulo = grid_Fondos.Children.Cast<UIElement>().FirstOrDefault(i => i is Rectangle && i.Opacity == 1);
            var fondo = (Image)grid_Fondos.Children.Cast<UIElement>().First(i => i is Image && Grid.GetColumn(i) == Grid.GetColumn(rectangulo));
            ServidorJuegoSE.Sala sala = new ServidorJuegoSE.Sala()
            {
                Nombre = textBox_Nombre.Text,
                DobleDado = checkBox_DobleDado.IsChecked.Value,
                DobleFicha = checkBox_DobleFicha.IsChecked.Value,
                CasillasEspeciales = checkBox_CasillasEspeciales.IsChecked.Value,
                UriFondoTablero = ((BitmapFrame)fondo.Source).Decoder.ToString()
            };
            Lobby lobby = new Lobby(jugador);
            lobby.CrearPartida(sala);
            lobby.Show();
            this.Close();
        }

        private void Rectangle_Clic(object sender, MouseButtonEventArgs e)
        {
            Rectangle rectangulo = sender as Rectangle;
            var rectanguloSeleccionado = grid_Fondos.Children.Cast<UIElement>().FirstOrDefault(i => i is Rectangle && i.Opacity == 1);
            if (rectanguloSeleccionado != null)
            {
                rectanguloSeleccionado.Opacity = 0;
            }
            rectangulo.Opacity = 1;
        }

        private bool VerificarCampos()
        {
            if (textBox_Nombre.Text.Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return false;
            }
            var rectanguloSeleccionado = grid_Fondos.Children.Cast<UIElement>().FirstOrDefault(i => i is Rectangle && i.Opacity == 1);
            if (rectanguloSeleccionado == null)
            {
                MessageBox.Show("Debe elegir un fondo de escenario");
                return false;
            }
            return true;
        }
    }
}
