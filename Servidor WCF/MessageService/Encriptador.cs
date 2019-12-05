using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MessageService
{
    public class Encriptador
    {
        private String llave;

        public Encriptador()
        {
            llave = "/llave-Correo-SerpientesEscaleras/";
        }

        public String Encriptar(string texto)
        {
            byte[] arregoLlave;
            byte[] arregloACifrar = UTF8Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            arregoLlave = hashMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(llave));
            hashMD5.Clear();
            TripleDESCryptoServiceProvider algoritmo3DAS = new TripleDESCryptoServiceProvider();
            algoritmo3DAS.Key = arregoLlave;
            algoritmo3DAS.Mode = CipherMode.ECB;
            algoritmo3DAS.Padding = PaddingMode.PKCS7;
            ICryptoTransform transformador = algoritmo3DAS.CreateEncryptor();
            byte[] arregloResultado = transformador.TransformFinalBlock(arregloACifrar, 0, arregloACifrar.Length);
            algoritmo3DAS.Clear();
            return Convert.ToBase64String(arregloResultado, 0, arregloResultado.Length);
        }

        public String Desencriptar(string textoEncriptado)
        {
            byte[] arregoLlave;
            byte[] arregloACifrar = Convert.FromBase64String(textoEncriptado);
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            arregoLlave = hashMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(llave));
            hashMD5.Clear();
            TripleDESCryptoServiceProvider algoritmo3DAS = new TripleDESCryptoServiceProvider();
            algoritmo3DAS.Key = arregoLlave;
            algoritmo3DAS.Mode = CipherMode.ECB;
            algoritmo3DAS.Padding = PaddingMode.PKCS7;
            ICryptoTransform transformador = algoritmo3DAS.CreateDecryptor();
            byte[] arregloResultado = transformador.TransformFinalBlock(arregloACifrar, 0, arregloACifrar.Length);
            algoritmo3DAS.Clear();
            return UTF8Encoding.UTF8.GetString(arregloResultado);
        }
    }
}
