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
    public partial class IngresarCodigo : Window {

        private readonly ServidorSE.Cuenta cuenta;

        public IngresarCodigo(ServidorSE.Cuenta cuentaRecibida) {
            cuenta = cuentaRecibida;
            InitializeComponent();
        }

        private void Button_Salir(object sender, RoutedEventArgs e) {
            MainWindow vetanaPrincipal = new MainWindow();
            vetanaPrincipal.Show();
            this.Close();
        }

        private void Button_ValidarCuenta(object sender, RoutedEventArgs e) {
            if (textBox_Codigo.Text !="") {
                ServidorSE.AdministradorCuentaClient cliente = new ServidorSE.AdministradorCuentaClient();
                if (cliente.ActivarCuentaJugador(cuenta, textBox_Codigo.Text)) 
                {
                    var cuentaActivada = Properties.Resources.cuentaActivada;
                    MessageBox.Show(cuentaActivada);
                    MainWindow vetanaPrincipal = new MainWindow();
                    vetanaPrincipal.Show();
                    this.Close();
                }
                else
                {
                    string codigoInvalido = Properties.Resources.codigoInvalido;
                    MessageBox.Show(codigoInvalido);
                }
            } else {
                string ingresarCodigo = Properties.Resources.ingresarCodigoActivacion;
                MessageBox.Show(ingresarCodigo);
            }
        }

        private void Button_ReenviarCorreo(object sender, RoutedEventArgs e) {
            ServidorSE.AdministradorCuentaClient cliente = new ServidorSE.AdministradorCuentaClient();
            cliente.EnviarCorreo(cuenta);
        }
    }
}
