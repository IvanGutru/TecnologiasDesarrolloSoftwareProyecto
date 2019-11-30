using System;
using System.Windows;
using System.Windows.Controls;


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
                ServidorJuegoSE.AdministradorCuentaClient cliente = new ServidorJuegoSE.AdministradorCuentaClient();
                ServidorJuegoSE.Cuenta cuenta = new ServidorJuegoSE.Cuenta() { Correo = textBox_CorreoElectronico.Text, Contraseña = passwordBox_Contraseña.Password };
                ServidorJuegoSE.Jugador jugador = new ServidorJuegoSE.Jugador() { Apodo = textBox_Apodo.Text, Nombre = textBox_NombreUsuario.Text, Apellidos = textBox_Apellidos.Text };
                if (!cliente.VerificarApodo(jugador))
                {
                    string usuarioRepetido = Properties.Resources.usuarioRepetido;
                    MessageBox.Show(usuarioRepetido);
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
                    string correoRepetido = Properties.Resources.correoRepetido;
                    MessageBox.Show(correoRepetido);
                }
            }

        }
        private Boolean ValidarCampos() {
            var mensaje = Properties.Resources.mensajeValidacion;
            if (textBox_NombreUsuario.Text == "" || textBox_Apellidos.Text =="" || textBox_Apodo.Text== "" || textBox_CorreoElectronico.Text ==""
                || passwordBox_Contraseña.SecurePassword.Length == 0 || passwordBox_ConfirmarContraseña.SecurePassword.Length == 0) {
                string camposObligatorios = Properties.Resources.camposObligatorios;
                MessageBox.Show(camposObligatorios);
                return false;
            }
            else if (!passwordBox_Contraseña.Password.Equals(passwordBox_ConfirmarContraseña.Password))
            {
                string contraseñaInvalida = Properties.Resources.contraseñaNoCoincide;
                MessageBox.Show(contraseñaInvalida);
                return false;
            }
            return true;
        }
    }
}
