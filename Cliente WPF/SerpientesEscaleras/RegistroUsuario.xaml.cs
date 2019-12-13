using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace SerpientesEscaleras
{
    /// <summary>
    /// Lógica de interacción para la ventana RegistroUsuario.
    /// En esta ventana se registra el nuevo usuario.
    /// </summary>
    public partial class RegistroUsuario : Window
    {
        /// <summary>
        /// Constructor de la ventana.
        /// </summary>
        public RegistroUsuario()
        {
            InitializeComponent();
        }
        enum EstadoDeOperacion
        {
            OperacionExitosa = 1,
            ErrorConexionBD = -10,
            Excepcion = -11,
            JugadorEncontrado = -3,
            CuentaEncontrada = -4,

        }
        /// <summary>
        /// Cierra esta ventana y regresa a la ventana de inicio de sesión.
        /// </summary>
        /// <param name="sender">Botón de regresar.</param>
        /// <param name="e">Evento de click.</param>
        private void Button_Regresar(object sender, RoutedEventArgs e) {
            MainWindow ventanaPrincipal = new MainWindow();
            ventanaPrincipal.Show();
            this.Close();
        }

        /// <summary>
        /// Envia los datos del nuevo usuario verificados al servidor para ser registrado.
        /// </summary>
        /// <param name="sender">Botón de reistrarse.</param>
        /// <param name="e">Evento de click.</param>
        /// <exception cref="System.ServiceModel.EndpointNotFoundException">
        /// Arrojada cuando no hay conexión con el servidor.
        /// </exception>
        private void Button_Registrarse(object sender, RoutedEventArgs e) {
            if (!ValidarCampos() || !ValidarFormatoCorreo())
            {
                return;
            }
            ServidorJuegoSE.AdministradorCuentaClient cliente = new ServidorJuegoSE.AdministradorCuentaClient();
            ServidorJuegoSE.Cuenta cuenta = new ServidorJuegoSE.Cuenta() { Correo = textBox_CorreoElectronico.Text, Contraseña = passwordBox_Contraseña.Password };
            ServidorJuegoSE.Jugador jugador = new ServidorJuegoSE.Jugador() { Apodo = textBox_Apodo.Text, Nombre = textBox_NombreUsuario.Text, Apellidos = textBox_Apellidos.Text };
            int respuesta;
            try
            {
                respuesta = cliente.RegistrarJugador(jugador, cuenta);
                if (respuesta == (int)EstadoDeOperacion.OperacionExitosa)
                {
                    cliente.EnviarCorreo(cuenta);
                    IngresarCodigo ingresarCodigo = new IngresarCodigo(cuenta);
                    ingresarCodigo.Show();
                    this.Close();
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException)
            {
                MessageBox.Show(Properties.Resources.errorConexionServidor, Properties.Resources.tituloErrorConexion, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (respuesta == (int)EstadoDeOperacion.JugadorEncontrado)
            {
                string usuarioRepetido = Properties.Resources.usuarioRepetido;
                MessageBox.Show(usuarioRepetido);
                return;
            }
            if (respuesta == (int)EstadoDeOperacion.CuentaEncontrada)
            {
                string correoRepetido = Properties.Resources.correoRepetido;
                MessageBox.Show(correoRepetido);
                return;
            }
            if (respuesta == (int)EstadoDeOperacion.ErrorConexionBD || respuesta == (int)EstadoDeOperacion.Excepcion)
            {
                MessageBox.Show(Properties.Resources.errorConexionBaseDatos, Properties.Resources.tituloErrorConexion, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Valida que todos los campos no estén vacíos y que las contraseñas coincidan y de ser el caso avisa al usuario.
        /// </summary>
        /// <returns>
        /// Verdadero si los campos no están vacíos y falso si alguno lo está o si las contraseñas no coinciden.
        /// </returns>
        private Boolean ValidarCampos() {
           
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

        /// <summary>
        /// Valida que el correo ingresado tenga el formato correspondiente de un correo verdadero.
        /// </summary>
        /// <returns>Verdadero si el correo tiene un formato válido o falso en caso contrario.</returns>
        private Boolean ValidarFormatoCorreo()
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(textBox_CorreoElectronico.Text, expresion)&& Regex.Replace(textBox_CorreoElectronico.Text, expresion, String.Empty).Length == 0)
            {
                return true;
            }
            MessageBox.Show(Properties.Resources.correoInvalido);
            return false;
        }

        private void ValidarTexto(object sender, RoutedEventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                return;
            }
                if (!Regex.IsMatch(textbox.Text, @"[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show(Properties.Resources.camposInvalidos);
                textbox.Clear();
            }
        }
    }
}
