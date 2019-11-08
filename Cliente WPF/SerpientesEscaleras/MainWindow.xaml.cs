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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SerpientesEscaleras
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            textBox_Usuario.Focus();
        }

        private void Button_IniciarSesion(object sender, RoutedEventArgs e)
        {
            String correoIngresado = textBox_Usuario.Text;
            String contraseñaIngresada = passwordBox_contraseña.Password;
            if (!ValidarCampos())
            {
                return;
            }
            ServidorSE.AdministradorCuentaClient cliente = new ServidorSE.AdministradorCuentaClient();
            ServidorSE.Cuenta cuenta = new ServidorSE.Cuenta() { Correo = correoIngresado, Contraseña = contraseñaIngresada };
            ServidorSE.Jugador jugador = cliente.IniciarSesion(cuenta);
            if (jugador != null)
            {
                if (cliente.VerificarCuenta(cuenta))
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
                string datosErroneos = Properties.Resources.usuarioContraseñaInvalidas;
                MessageBox.Show(datosErroneos);
            }
        }

        private void Button_Registrarse(object sender, RoutedEventArgs e)
        {
            RegistroUsuario ventanaRegistro = new RegistroUsuario();
            ventanaRegistro.Show();
            this.Close();
        }

        private void CambiarIdiomaEspañol(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("");
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void CambiarIdiomaIngles(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }
        public bool ValidarCampos()
        {
            if (textBox_Usuario.Text == "")
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

        private void TextBox_Usuario_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_Usuario.Text == "")
            {
                label_Usuario.Visibility = Visibility.Visible;
            }
        }

        private void PasswordBox_Contraseña_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passwordBox_contraseña.Password == "")
            {
                label_Contraseña.Visibility = Visibility.Visible;
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            label_Contraseña.Visibility = Visibility.Hidden;
        }

        private void TextBox_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            label_Usuario.Visibility = Visibility.Hidden;
        }

        private void Label_Contraseña_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordBox_contraseña.Focus();
        }

        private void Label_Usuario_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox_Usuario.Focus();
        }
    }

}
