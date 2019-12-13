using System;
using System.Security.Cryptography;
using System.Text;

namespace MessageService
{/// <summary>
/// Clase utilizada para encriptar y desencriptar
/// </summary>
    public class Encriptador
    {
        private readonly String llave;
        /// <summary>
        /// Constructor de la clase Encriptador que inicializa la llave
        /// </summary>
        public Encriptador()
        {
            llave = "/llave-Correo-SerpientesEscaleras/";
        }
        /// <summary>
        /// Encripta el texto recibido 
        /// </summary>
        /// <param name="texto">Es el texto que se va a encriptar</param>
        /// <returns> el texto enrptado</returns>
        public String Encriptar(string texto)
        {

            byte[] arregoLlave;
            byte[] arregloACifrar = UTF8Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            arregoLlave = hashMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(llave));
            hashMD5.Clear();
            AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
            aesCryptoServiceProvider.Key = arregoLlave;
            aesCryptoServiceProvider.Mode = CipherMode.ECB;
            aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform transformador = aesCryptoServiceProvider.CreateEncryptor();
            byte[] arregloResultado = transformador.TransformFinalBlock(arregloACifrar, 0, arregloACifrar.Length);
            aesCryptoServiceProvider.Clear();
            texto = Convert.ToBase64String(arregloResultado, 0, arregloResultado.Length);
            return texto;
        }
        /// <summary>
        /// Desencripa el texto encriptado recibido
        /// </summary>
        /// <param name="textoEncriptado">texto encriptado para desincriptar</param>
        /// <returns> Texto desencriptado</returns>
        public String Desencriptar(string textoEncriptado)
        {

            byte[] arregoLlave;
            byte[] arregloACifrar = Convert.FromBase64String(textoEncriptado);
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            arregoLlave = hashMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(llave));
            hashMD5.Clear();
            AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
            aesCryptoServiceProvider.Key = arregoLlave;
            aesCryptoServiceProvider.Mode = CipherMode.ECB;
            aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform transformador = aesCryptoServiceProvider.CreateDecryptor();
            byte[] arregloResultado = transformador.TransformFinalBlock(arregloACifrar, 0, arregloACifrar.Length);
            aesCryptoServiceProvider.Clear();
            textoEncriptado = UTF8Encoding.UTF8.GetString(arregloResultado);
            return textoEncriptado;
        }
    }
}
