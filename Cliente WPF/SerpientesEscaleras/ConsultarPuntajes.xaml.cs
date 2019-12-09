using System.Windows;
using System.Windows.Controls;


namespace SerpientesEscaleras {
    /// <summary>
    /// Lógica de interacción para ConsultarPuntajes.xaml
    /// </summary>
    public partial class ConsultarPuntajes : Window {

        private ServidorJuegoSE.Jugador jugador;
        /// <summary>
        /// Método que muestra los puntajes del jugador que recibe como parametro, tambien muestra los 
        /// puntajes de todas las partidas.
        /// </summary>
        /// <param name="jugadorRecibido"></param>
        public ConsultarPuntajes(ServidorJuegoSE.Jugador jugadorRecibido) {
            jugador = jugadorRecibido;
            InitializeComponent();
            ServidorJuegoSE.AdministradorCuentaClient cliente = new ServidorJuegoSE.AdministradorCuentaClient();
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
