﻿using System;
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
    /// Lógica de interacción para IngresarCodigo.xaml
    /// </summary>
    public partial class IngresarCodigo : Window {

        private readonly ServidorSE.Cuenta cuenta;

        public IngresarCodigo(ServidorSE.Cuenta cuentaRecibida) {
            cuenta = cuentaRecibida;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            RegistroUsuario ventanaRegsitro = new RegistroUsuario();
            ventanaRegsitro.Show();
            this.Close();
        }

        private void ButtonValidarCuenta(object sender, RoutedEventArgs e) {
            if (textBoxCodigo.Text !="") {
                ServidorSE.AdministradorCuentaClient cliente = new ServidorSE.AdministradorCuentaClient();
                if (cliente.ActivarCuentaJugador(cuenta, textBoxCodigo.Text)) {
                    MainWindow vetanaPrincipal = new MainWindow();
                    vetanaPrincipal.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Codigo no válido");
                }
            } else {
                MessageBox.Show("Ingresa el código de activación");
            }
        }

        private void ButtonReenviarCorreo(object sender, RoutedEventArgs e) {
            ServidorSE.AdministradorCuentaClient cliente = new ServidorSE.AdministradorCuentaClient();
            cliente.EnviarCorreo(cuenta);
        }
    }
}
