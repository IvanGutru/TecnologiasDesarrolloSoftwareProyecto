using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace SerpientesEscaleras
{
    /// <summary>
    /// Lógica de interacción para la ventana MainWindow.
    /// Es la ventana de inicio de sesión y la primer ventana en abrir.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor de la ventana.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            textBox_Usuario.Focus();
        }

        /// <summary>
        /// Llama al servidor para iniciar sesión con el correo y la contraseña y abre el menú principal.
        /// Abre la ventana de ingresar código de activación de cuenta si la cuenta no está activada.
        /// </summary>
        /// <param name="sender">Botón de iniciar sesión.</param>
        /// <param name="e">Evento Click.</param>
        /// <exception cref="System.ServiceModel.EndpointNotFoundException">
        /// Arrojada cuando no hay conexión con el servidor.
        /// </exception>
        private void Button_IniciarSesion(object sender, RoutedEventArgs e)
        {
            String correoIngresado = textBox_Usuario.Text;
            String contraseñaIngresada = passwordBox_contraseña.Password;
            if (!ValidarCamposVacios() || !ValidarFormatoCorreo())
            {
                return;
            }
            ServidorJuegoSE.AdministradorCuentaClient cliente = new ServidorJuegoSE.AdministradorCuentaClient();
            ServidorJuegoSE.Cuenta cuenta = new ServidorJuegoSE.Cuenta() { Correo = correoIngresado, Contraseña = contraseñaIngresada };
            ServidorJuegoSE.Jugador jugador = new ServidorJuegoSE.Jugador();
            try
            {
                jugador = cliente.IniciarSesion(cuenta);
                cuenta = cliente.VerificarCuenta(cuenta);
            }
            catch (System.ServiceModel.EndpointNotFoundException)
            {
                MessageBox.Show(Properties.Resources.errorConexionServidor, Properties.Resources.tituloErrorConexion, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (jugador != null && cuenta !=null)
            {
                if (cuenta.Correo.Equals("ErrorConexionBaseDatos") || jugador.Apodo.Equals("ErrorConexionBaseDatos"))
                {
                    MessageBox.Show(Properties.Resources.errorConexionBaseDatos, Properties.Resources.tituloErrorConexion, MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (cuenta.Validada)
                {
                    MenuPrincipal ventanaPrincipal = new MenuPrincipal(jugador);
                    ventanaPrincipal.Show();
                    this.Close();
                }
                else
                {
                    IngresarCodigo ventanaIngresarCodigo = new IngresarCodigo(cuenta);
                    ventanaIngresarCodigo.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.usuarioContraseñaInvalidas);
            }
        }

        /// <summary>
        /// Abre la ventana del registro para nuevos usuarios.
        /// </summary>
        /// <param name="sender">Botón de registrarse.</param>
        /// <param name="e">Evento de Click.</param>
        private void Button_Registrarse(object sender, RoutedEventArgs e)
        {
            RegistroUsuario ventanaRegistro = new RegistroUsuario();
            ventanaRegistro.Show();
            this.Close();
        }

        /// <summary>
        /// Cambia el idioma del juego a Español.
        /// </summary>
        /// <param name="sender">Idioma español del menú.</param>
        /// <param name="e">Evento de Click.</param>
        private void CambiarIdiomaEspañol(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("");
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        /// <summary>
        /// Cambia el idioma del juego a Inglés.
        /// </summary>
        /// <param name="sender">Idioma inglés del menú.</param>
        /// <param name="e">Evento de Click.</param>
        private void CambiarIdiomaIngles(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        /// <summary>
        /// Valida que los campos de correo y contraseña no estén vacíos y de ser el caso avisa al usuario. 
        /// </summary>
        /// <returns>Verdadero si los dos no están vacíos o falso si alguno lo está.</returns>
        public bool ValidarCamposVacios()
        {
            
            if (textBox_Usuario.Text == "" )
            {
                string ingresaUsuario = Properties.Resources.ingresaUsuario;
                MessageBox.Show(ingresaUsuario);
                return false;
            }
            else if (passwordBox_contraseña.SecurePassword.Length == 0)
            {
                string ingresaContraseña = Properties.Resources.ingresaContraseña;
                MessageBox.Show(ingresaContraseña);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Si el campo del correo del usuario esta vació hace visible el label del usuario.
        /// </summary>
        /// <param name="sender">Textbox del correo.</param>
        /// <param name="e">Evento de perder foco.</param>
        private void TextBox_Usuario_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_Usuario.Text == "")
            {
                label_Usuario.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Si el campo de la contraseña del usuario esta vació hace visible el label de la contraseña.
        /// </summary>
        /// <param name="sender">Passwordbox de la contraseña.</param>
        /// <param name="e">Evento de perder foco.</param>
        private void PasswordBox_Contraseña_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passwordBox_contraseña.Password == "")
            {
                label_Contraseña.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Oculta el label de la contraseña si se escribe en el campo de la contraseña.
        /// </summary>
        /// <param name="sender">Passwordbox de la contraseña.</param>
        /// <param name="e">Evento de letra presionada.</param>
        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            label_Contraseña.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Oculta el label del usuario si se escribe en el campo del correo del usuario.
        /// </summary>
        /// <param name="sender">Textbox del correo del usuario.</param>
        /// <param name="e">Evento de letra presionada.</param>
        private void TextBox_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            label_Usuario.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Pone el focus en el campo de la contraseña.
        /// </summary>
        /// <param name="sender">Label de la contraseña.</param>
        /// <param name="e">Evento de Click presionado.</param>
        private void Label_Contraseña_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordBox_contraseña.Focus();
        }

        /// <summary>
        /// Pone el focus en el campo del correo del usuario.
        /// </summary>
        /// <param name="sender">Label del correo del usuario.</param>
        /// <param name="e">Evento de Click presionado.</param>
        private void Label_Usuario_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox_Usuario.Focus();
        }

        /// <summary>
        /// Valida que el correo ingresado tenga el formato correspondiente de un correo verdadero.
        /// </summary>
        /// <returns>Verdadero si el correo tiene un formato válido o falso en caso contrario.</returns>
        private Boolean ValidarFormatoCorreo()
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(textBox_Usuario.Text, expresion))
            {
                if (Regex.Replace(textBox_Usuario.Text, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
            }
            MessageBox.Show(Properties.Resources.correoInvalido);
            return false;
        }

    }
}
