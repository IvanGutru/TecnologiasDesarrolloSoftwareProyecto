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
        private ServidorJuegoSE.Jugador jugador;
        private Lobby lobby;
        private List<ServidorJuegoSE.Sala> listaSalas;

        public BuscarPartida(ServidorJuegoSE.Jugador jugadorRecibido)
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
                string elegir = Properties.Resources.elegirPartida;
                MessageBox.Show(elegir);
                return;
            }
            ServidorJuegoSE.Sala partida = (ServidorJuegoSE.Sala)dataGrid_Partidas.SelectedItem;
            if (!lobby.EntrarPartida(partida))
            {
                listaSalas.Clear();
                string partidaRecurso = Properties.Resources.partida;
                string llena = Properties.Resources.llena;
                MessageBox.Show(partidaRecurso + " " + partida.Nombre + " " + llena);
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
            if(titulo == "ExtensionData" || titulo == "UriFondoTablero" || titulo == "DiccionarioJugadores")
            {
                e.Cancel = true;
            }
            if (titulo == "Nombre")
            {
                e.Column.DisplayIndex=0;
            }
            if (titulo == "NumJugadores")
            {
                string numJugadores = Properties.Resources.numJugadores;
                e.Column.Header = numJugadores;
                e.Column.DisplayIndex = 1;
            }
            if (titulo == "DobleDado")
            {
                string dobleDado = Properties.Resources.dobleDado;
                e.Column.Header = dobleDado;
                e.Column.DisplayIndex = 2;
            }
            if (titulo == "DobleFicha")
            {
                string dobleFicha = Properties.Resources.dobleFicha;
                e.Column.Header = dobleFicha;
                e.Column.DisplayIndex = 3;
            }
            if (titulo == "CasillasEspeciales")
            {
                string casillaEspecial = Properties.Resources.casillaEspecial;
                e.Column.Header = casillaEspecial;
                e.Column.DisplayIndex = 4;
            }
            if (titulo == "Jugando")
            {
                e.Column.Header = "Empezó la partida";
                e.Column.DisplayIndex = 5;
            }
        }
    }
}
