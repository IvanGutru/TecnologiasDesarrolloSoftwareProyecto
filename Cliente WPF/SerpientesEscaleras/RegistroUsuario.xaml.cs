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
    /// <summary>
    /// Lógica de interacción para RegistroUsuario.xaml
    /// </summary>
    public partial class RegistroUsuario : Window
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MainWindow ventanaPrincipal = new MainWindow();
            ventanaPrincipal.Show();
            this.Close();
        }

        private void ButtonRegistrarse(object sender, RoutedEventArgs e) {
            if (CamposVacios() ==false) {
                ServidorSE.AdministradorCuentaClient cliente = new ServidorSE.AdministradorCuentaClient();
                ServidorSE.Cuenta cuenta = new ServidorSE.Cuenta() { Correo = TextBoxCorreoElectronico.Text, Contraseña = TextBoxContraseña.Text };
                ServidorSE.Jugador jugador = new ServidorSE.Jugador() { Apodo = TextBoxApodo.Text, Nombre = TextBoxNombreUsuario.Text, Apellidos = TextBoxContraseña.Text };
                if (cliente.RegistrarJugador(jugador, cuenta))
                {
                    cliente.EnviarCorreo(cuenta);
                    IngresarCodigo ventanaCodigo = new IngresarCodigo(cuenta);
                    ventanaCodigo.Show();
                    this.Close();
                } else
                {
                    MessageBox.Show("El correo o apodo ya se encuentra registrado en el sistema");
                }
                
            }

        }
        private Boolean CamposVacios() {
            var mensaje = Properties.Resources.mensajeValidacion;
            if (TextBoxNombreUsuario.Text == "" || TextBoxApellidos.Text =="" || TextBoxApodo.Text== "" || TextBoxCorreoElectronico.Text ==""
                || TextBoxContraseña.Text =="" || TextBoxConfirmarContraseña.Text=="") {
                MessageBox.Show(mensaje,"",MessageBoxButton.OK,MessageBoxImage.Information);
                return true;
            }
            return false;
        }
    }
}
