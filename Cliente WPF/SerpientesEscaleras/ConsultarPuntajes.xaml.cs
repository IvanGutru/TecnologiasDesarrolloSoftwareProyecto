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

namespace SerpientesEscaleras {
    /// <summary>
    /// Lógica de interacción para ConsultarPuntajes.xaml
    /// </summary>
    public partial class ConsultarPuntajes : Window {

        private ServidorSE.Jugador jugador;

        public ConsultarPuntajes(ServidorSE.Jugador jugadorRecibido) {
            jugador = jugadorRecibido;
            InitializeComponent();
            ServidorSE.AdministradorCuentaClient cliente = new ServidorSE.AdministradorCuentaClient();
            DataGrid_MisPuntajes.ItemsSource = cliente.ConsultarPuntajesPropios(jugador);
            DataGrid_MejoresPuntajes.ItemsSource = cliente.ConsultarMejoresPuntajes();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MenuPrincipal ventanaPrincipal = new MenuPrincipal(jugador);
            ventanaPrincipal.Show();
            this.Close();
        }
    }
}
