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
    public partial class BuscarPartida : Window
    {
        private ServidorSE.Jugador jugador;
        private Lobby lobby;
        private List<ServidorSE.Sala> listaSalas;

        public BuscarPartida(ServidorSE.Jugador jugadorRecibido)
        {
            jugador = jugadorRecibido;
            InitializeComponent();
            lobby = new Lobby(jugadorRecibido);
            listaSalas = lobby.ConsultarPartidasDisponibles();
            dataGrid_Partidas.ItemsSource = listaSalas;
        }

        private void Button_Entrar(object sender, RoutedEventArgs e)
        {
            if (dataGrid_Partidas.SelectedItem == null)
            {
                MessageBox.Show("Elige una partida primero");
                return;
            }
            if (!lobby.EntrarPartida(dataGrid_Partidas.SelectedIndex))
            {
                ServidorSE.Sala partida = (ServidorSE.Sala)dataGrid_Partidas.SelectedItem;
                MessageBox.Show("La partida " + partida.Nombre + " ya esta llena");
                listaSalas = lobby.ConsultarPartidasDisponibles();
                dataGrid_Partidas.Items.Refresh();
                return;
            }
            lobby.Show();
            this.Close();
        }

        private void Button_Regresar(object sender, RoutedEventArgs e)
        {
            MenuPrincipal ventanaMenuPrincipal = new MenuPrincipal(jugador);
            ventanaMenuPrincipal.Show();
            this.Close();
        }

        private void DataGrid_Partidas_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string titulo = e.Column.Header.ToString();
            if(titulo == "ExtensionData" || titulo == "DiccionarioJugadores")
            {
                e.Cancel = true;
            }
            if (titulo == "Nombre")
            {
                e.Column.DisplayIndex=0;
            }
            if (titulo == "NumJugadores")
            {
                e.Column.Header = "No. de jugadores conectados";
                e.Column.DisplayIndex = 1;
            }
            if (titulo == "DobleDado")
            {
                e.Column.Header = "Doble dado";
                e.Column.DisplayIndex = 2;
            }
            if (titulo == "DobleFicha")
            {
                e.Column.Header = "Doble ficha";
                e.Column.DisplayIndex = 3;
            }
            if (titulo == "CasillasEspeciales")
            {
                e.Column.Header = "Casillas especiales";
                e.Column.DisplayIndex = 4;
            }
        }
    }
}
