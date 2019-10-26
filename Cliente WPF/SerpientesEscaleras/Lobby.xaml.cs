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
    public partial class RegresoMensaje : ServidorSE.IAdministradorChatCallback
    {
        private Lobby lobby;

        public Lobby Lobby { get => lobby; set => lobby = value; }

        public void RecibirMensaje(string mensaje)
        {
            lobby.chat.Add(mensaje);
            lobby.listBox_Chat.Items.Refresh();
        }

        public void RecibirMensajeMiembro(Boolean entrada, String apodo)
        {
            if (entrada)
            {
                lobby.chat.Add(apodo + " " + Properties.Resources.mensajeEntrada);
                lobby.jugadoresConectados.Add(apodo);
                lobby.label_JugadoresConectados.Content = lobby.jugadoresConectados.Count + Properties.Resources.jugadoresConectados;
            }
            else
            {
                lobby.chat.Add(apodo + " " + Properties.Resources.mensajeSalida);
                lobby.jugadoresConectados.Remove(apodo);
                lobby.label_JugadoresConectados.Content = lobby.jugadoresConectados.Count + Properties.Resources.jugadoresConectados;
            }
            lobby.listBox_Chat.Items.Refresh();
            lobby.listBox_JugadoresConectados.Items.Refresh();
        }
    }

    public partial class Lobby : Window
    {
        private int indiceSala;
        private ServidorSE.Jugador jugador;
        public List<String> chat = new List<string>();
        InstanceContext contexto;
        private ServidorSE.AdministradorChatClient servidorChat;
        public List<String> jugadoresConectados = new List<String>();

        public Lobby(ServidorSE.Jugador jugadorRecibido)
        {
            jugador = jugadorRecibido;
            InitializeComponent();
            listBox_Chat.ItemsSource = chat;
            listBox_JugadoresConectados.ItemsSource = jugadoresConectados;
            RegresoMensaje regresoMensaje = new RegresoMensaje
            {
                Lobby = this
            };
            contexto = new InstanceContext(regresoMensaje);
            servidorChat = new ServidorSE.AdministradorChatClient(contexto);
            //servidorChat.Entrar(jugador, Properties.Resources.mensajeEntrada);
        }

        public void CrearPartida(ServidorSE.Sala sala)
        {
            indiceSala = servidorChat.CrearSala(sala);
            servidorChat.UnirseSala(indiceSala, jugador);
        }

        public void EntrarPartida(int indice)
        {
            indiceSala = indice;
            servidorChat.UnirseSala(indiceSala, jugador);
        }

        public List<ServidorSE.Sala> ConsultarPartidasDisponibles()
        {
            return servidorChat.ConsultarSalasDisponibles().ToList();
        }

        private void Button_Enviar(object sender, RoutedEventArgs e)
        {
            if (textBox_Mensaje.Text != "")
            {
                servidorChat.EnviarMensaje(indiceSala, textBox_Mensaje.Text);
                textBox_Mensaje.Clear();
            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            servidorChat.SalirChat(indiceSala);
        }

        private void Button_Regresar(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal(jugador);
            menuPrincipal.Show();
            this.Close();
        }
    }
}
