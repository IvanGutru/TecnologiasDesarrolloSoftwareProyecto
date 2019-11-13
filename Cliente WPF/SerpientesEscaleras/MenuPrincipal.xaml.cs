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

    public partial class MenuPrincipal : Window {

        private ServidorJuegoSE.Jugador jugador;

        public MenuPrincipal(ServidorJuegoSE.Jugador jugadorRecibido) {
            jugador = jugadorRecibido;
            InitializeComponent();
        }

    
        private void Button_ConsultarPuntajes(object sender, RoutedEventArgs e) {
            ConsultarPuntajes ventanaPuntajes = new ConsultarPuntajes(jugador);
            ventanaPuntajes.Show();
            this.Close();
        }

        private void Button_CerrarSesion(object sender, RoutedEventArgs e) {
            MainWindow ventanaIncio = new MainWindow();
            ventanaIncio.Show();
            this.Close();
        }

        private void Button_NuevaPartida(object sender, RoutedEventArgs e)
        {
            CrearPartida ventanaCrearPartida = new CrearPartida(jugador);
            ventanaCrearPartida.Show();
            this.Close();
        }

        private void Button_BuscarPartida(object sender, RoutedEventArgs e)
        {
            BuscarPartida ventanaBuscarPartida = new BuscarPartida(jugador);
            ventanaBuscarPartida.Show();
            this.Close();
        }
    }
}
