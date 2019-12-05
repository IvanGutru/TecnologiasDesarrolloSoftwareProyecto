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

        private readonly ServidorJuegoSE.Cuenta cuenta;

        public IngresarCodigo (ServidorJuegoSE.Cuenta cuentaRecibida) {
            cuenta = cuentaRecibida;
            InitializeComponent();
        }

        private void Button_Salir(object sender, RoutedEventArgs e) {
            MainWindow vetanaPrincipal = new MainWindow();
            vetanaPrincipal.Show();
            this.Close();
        }

        private void Button_ValidarCuenta(object sender, RoutedEventArgs e) {
            if (textBox_Codigo.Text == "") {
                string ingresarCodigo = Properties.Resources.ingresarCodigoActivacion;
                MessageBox.Show(ingresarCodigo);
                return;
            }
            ServidorJuegoSE.AdministradorCuentaClient cliente = new ServidorJuegoSE.AdministradorCuentaClient();
            try
            {
                int respuesta = cliente.ActivarCuentaJugador(cuenta, textBox_Codigo.Text);
                if (respuesta == 1)
                {
                    var cuentaActivada = Properties.Resources.cuentaActivada;
                    MessageBox.Show(cuentaActivada);
                    MainWindow vetanaPrincipal = new MainWindow();
                    vetanaPrincipal.Show();
                    this.Close();
                }
                else if (respuesta == 0)
                {
                    MessageBox.Show(Properties.Resources.codigoInvalido);
                }
                else if (respuesta == -10 || respuesta == -11)
                {
                    MessageBox.Show(Properties.Resources.errorConexionBaseDatos, Properties.Resources.tituloErrorConexion, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException)
            {
                MessageBox.Show(Properties.Resources.errorConexionServidor, Properties.Resources.tituloErrorConexion, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_ReenviarCorreo(object sender, RoutedEventArgs e) {
            ServidorJuegoSE.AdministradorCuentaClient cliente = new ServidorJuegoSE.AdministradorCuentaClient();
            int respuesta;
            try
            {
                respuesta = cliente.EnviarCorreo(cuenta);
                if (respuesta == 1)
                {
                    MessageBox.Show(Properties.Resources.correoEnviado);
                }
                if (respuesta == -10)
                {
                    MessageBox.Show(Properties.Resources.errorConexionBaseDatos, Properties.Resources.tituloErrorConexion, MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (respuesta == 0)
                {
                    MessageBox.Show(Properties.Resources.errorMandarCorreo);
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException)
            {
                MessageBox.Show(Properties.Resources.errorConexionServidor, Properties.Resources.tituloErrorConexion, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

    }
}
