using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
    public class RegresoJuego : ServidorJuegoSE.IAdministradorMultijugadorCallback
    {
        private Juego juego;

        public Juego Juego { get => juego; set => juego = value; }

        public void RecibirMensaje(string mensaje)
        {
            juego.chat.Add(mensaje);
            juego.listBox_Chat.Items.Refresh();
        }

        public void RecibirMensajeMiembro(Boolean entrada, String apodo)
        {
            if (entrada)
            {
                int indiceApodo = juego.jugadoresConectados.FindIndex(x => x.Contains(apodo));
                if (indiceApodo != -1)
                {
                    return;
                }
                juego.chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                juego.jugadoresConectados.Add(apodo);
            }
            else
            {
                juego.chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                juego.jugadoresConectados.Remove(apodo);
            }
            juego.listBox_Chat.Items.Refresh();
            juego.listBox_JugadoresConectados.Items.Refresh();
        }

        public void EntrarJuego() { }
    }

    public partial class Juego : Window
    {
        private int idSala;
        private ServidorJuegoSE.Jugador jugador;
        public List<String> chat = new List<string>();
        InstanceContext contexto;
        private ServidorJuegoSE.AdministradorMultijugadorClient clienteMultijugador;
        public List<String> jugadoresConectados = new List<String>();
        private List<Casilla> casillas = new List<Casilla>();
        private int posicion = 1;

        public Juego(ServidorJuegoSE.Jugador jugadorRecibido, int indiceSalaRecibido)
        {
            jugador = jugadorRecibido;
            idSala = indiceSalaRecibido;
            InitializeComponent();
            listBox_Chat.ItemsSource = chat;
            listBox_JugadoresConectados.ItemsSource = jugadoresConectados;
            RegresoJuego regresoJuego = new RegresoJuego()
            {
                Juego = this
            };
            contexto = new InstanceContext(regresoJuego);
            clienteMultijugador = new ServidorJuegoSE.AdministradorMultijugadorClient(contexto);
            CrearCasillas(7, 10);
            ImageBrush brushGrid = new ImageBrush();
            brushGrid.ImageSource = new BitmapImage(new Uri(clienteMultijugador.ObtenerFondo(idSala)));
            grid_Tablero.Background = brushGrid;
        }

        private void CrearCasillas(int filas, int columnas)
        {
            for (int fila = filas-1; fila >= 0; fila--)
            {
                int id = 1;
                int columna;
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

        private void Button_Enviar(object sender, RoutedEventArgs e)
        {
            if (textBox_Mensaje.Text != "")
            {
                clienteMultijugador.EnviarMensaje(idSala, textBox_Mensaje.Text);
                textBox_Mensaje.Clear();
            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clienteMultijugador.SalirJuego(idSala);
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
            label_Dado.Content = numDado;
            posicion = posicion + numDado;
            if (posicion > 70)
            {
                posicion = 70 - (posicion-70);
            }
            Casilla casillaTemporal = casillas.ElementAt(posicion-1);
            Grid.SetColumn(image_Token1, casillaTemporal.Columna);
            Grid.SetRow(image_Token1, casillaTemporal.Fila);
            Turno turno = new Turno();
            turno.Show();
        }

        public void RecibirListaJugadores(List<String> jugadores)
        {
            jugadoresConectados.AddRange(jugadores);
            listBox_JugadoresConectados.Items.Refresh();
        }

        public void Entrar()
        {
            clienteMultijugador.UnirseSala(idSala, jugador);
        }

    }
}
