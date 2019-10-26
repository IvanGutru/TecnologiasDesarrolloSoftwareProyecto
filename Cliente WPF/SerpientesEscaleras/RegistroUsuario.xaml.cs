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

        private void Button_Regresar(object sender, RoutedEventArgs e) {
            MainWindow ventanaPrincipal = new MainWindow();
            ventanaPrincipal.Show();
            this.Close();
        }

        private void Button_Registrarse(object sender, RoutedEventArgs e) {
            if (ValidarCampos())
            {
                ServidorSE.AdministradorCuentaClient cliente = new ServidorSE.AdministradorCuentaClient();
                ServidorSE.Cuenta cuenta = new ServidorSE.Cuenta() { Correo = textBox_CorreoElectronico.Text, Contraseña = passwordBox_Contraseña.Password };
                ServidorSE.Jugador jugador = new ServidorSE.Jugador() { Apodo = textBox_Apodo.Text, Nombre = textBox_NombreUsuario.Text, Apellidos = textBox_Apellidos.Text };
                if (!cliente.VerificarApodo(jugador))
                {
                    MessageBox.Show("Ya se encuentra registrado un usuario con ese apodo");
                    return;
                }
                if (cliente.RegistrarJugador(jugador, cuenta))
                {
                    cliente.EnviarCorreo(cuenta);
                    IngresarCodigo ventanaCodigo = new IngresarCodigo(cuenta);
                    ventanaCodigo.Show();
                    this.Close();
                } else
                {
                    MessageBox.Show("El correo ya se encuentra registrado");
                }
            }

        }
        private Boolean ValidarCampos() {
            var mensaje = Properties.Resources.mensajeValidacion;
            if (textBox_NombreUsuario.Text == "" || textBox_Apellidos.Text =="" || textBox_Apodo.Text== "" || textBox_CorreoElectronico.Text ==""
                || passwordBox_Contraseña.SecurePassword.Length == 0 || passwordBox_ConfirmarContraseña.SecurePassword.Length == 0) {
                MessageBox.Show("Todos los campos son obligatorios");
                return false;
            }
            else if (!passwordBox_Contraseña.Password.Equals(passwordBox_ConfirmarContraseña.Password))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }
            return true;
        }
    }
}
