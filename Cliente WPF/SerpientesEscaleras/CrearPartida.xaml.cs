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
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class CrearPartida : Window
    {
        private ServidorSE.Jugador jugador = new ServidorSE.Jugador();

        public CrearPartida(ServidorSE.Jugador jugadorRecibido)
        {
            jugador = jugadorRecibido;
            InitializeComponent();
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
            ServidorSE.Sala sala = new ServidorSE.Sala()
            {
                Nombre = textBox_Nombre.Text,
                DobleDado = checkBox_DobleDado.IsChecked.Value,
                DobleFicha = checkBox_DobleFicha.IsChecked.Value,
                CasillasEspeciales = checkBox_CasillasEspeciales.IsChecked.Value
            };
            Lobby lobby = new Lobby(jugador);
            lobby.CrearPartida(sala);
            lobby.Show();
            this.Close();
        }
    }
}
