﻿using System;
using System.Media;
using System.Windows;
using System.Windows.Media;


namespace SerpientesEscaleras {

    public partial class MenuPrincipal : Window {

        private ServidorJuegoSE.Jugador jugador;
        private SoundPlayer sonidoBoton = new SoundPlayer("SystemSounds/button.wav");
        /// <summary>
        /// Constructor de la ventana el menu principal conforme al usuairo qu erecibe
        /// como 
        /// </summary>
        /// <param name="jugadorRecibido"></param>
        public MenuPrincipal(ServidorJuegoSE.Jugador jugadorRecibido) {
            jugador = jugadorRecibido;
            InitializeComponent();
        }

        private void Button_ConsultarPuntajes(object sender, RoutedEventArgs e) {
            sonidoBoton.Play();
            ConsultarPuntajes ventanaPuntajes = new ConsultarPuntajes(jugador);
            ventanaPuntajes.Show();
            this.Close();
        }

        private void Button_CerrarSesion(object sender, RoutedEventArgs e) {
            sonidoBoton.Play();
            MainWindow ventanaIncio = new MainWindow();
            ventanaIncio.Show();
            this.Close();
        }

        private void Button_NuevaPartida(object sender, RoutedEventArgs e)
        {
            sonidoBoton.Play();
            CrearPartida ventanaCrearPartida = new CrearPartida(jugador);
            ventanaCrearPartida.Show();
            this.Close();
        }

        private void Button_BuscarPartida(object sender, RoutedEventArgs e)
        {
            sonidoBoton.Play();
            BuscarPartida ventanaBuscarPartida = new BuscarPartida(jugador);
            ventanaBuscarPartida.Show();
            this.Close();
        }

    }
}
