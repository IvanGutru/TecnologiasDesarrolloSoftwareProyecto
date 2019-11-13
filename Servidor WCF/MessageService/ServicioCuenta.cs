using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using DAO;
using System.Net.Mail;

namespace MessageService {

    public partial class ServicioSistema : IAdministradorCuenta {

        private ServidorSE conexionBaseDatos;

        private String ObtenerSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        private String ObtenerHash(string contraseña, string salt)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: contraseña,
                salt: Convert.FromBase64String(salt),
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
        }

        private DAO.Cuenta ObtenerCuentaJugador(String correo)
        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                var cuentaRecuperada = conexionBaseDatos.CuentaSet.Where(c => c.correo == correo).FirstOrDefault();
                if (cuentaRecuperada != null)
                {
                    if (cuentaRecuperada.correo.Equals(correo))
                    {
                        return cuentaRecuperada;
                    }
                }
            }
            return null;
        }

        public Boolean EnviarCorreo(Cuenta cuenta)
        {
            var cuentaRecuperada = ObtenerCuentaJugador(cuenta.Correo);
            if (cuentaRecuperada == null)
            {
                return false;
            }
            MailMessage correo = new MailMessage("serpientesyescalerasportalitos@gmail.com", cuenta.Correo, "Activación de la cuenta",
            "<p>Código para la activación de la cuenta: " + cuentaRecuperada.salt + "</p><br>");
            correo.IsBodyHtml = true;
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
            clienteSmtp.EnableSsl = true;
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.Port = 587;
            clienteSmtp.Credentials = new System.Net.NetworkCredential("serpientesyescalerasportalitos@gmail.com", "portalitos99");
            try
            {
                clienteSmtp.Send(correo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            clienteSmtp.Dispose();
            return true;
        }

        public Jugador IniciarSesion(Cuenta cuenta)
        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                var cuentaRecuperada = conexionBaseDatos.CuentaSet.Where(c => c.correo == cuenta.Correo).FirstOrDefault();
                if (cuentaRecuperada != null && cuentaRecuperada.correo.Equals(cuenta.Correo))
                {
                    String contreseñaHasheada = ObtenerHash(cuenta.Contraseña, cuentaRecuperada.salt);
                    if (contreseñaHasheada.Equals(cuentaRecuperada.password))
                    {
                        return new Jugador() { Apodo = cuentaRecuperada.Jugador.apodo };
                    }
                }
                
            }
            return null;
        }

        public Boolean VerificarCuenta(Cuenta cuenta)
        {
            var cuentaRecuperada = ObtenerCuentaJugador(cuenta.Correo);
            if (cuentaRecuperada != null && cuentaRecuperada.validada)
            {
                return true;
            }
            return false;
        }

        public Boolean VerificarApodo(Jugador jugador)
        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                var jugadorRecuperado = conexionBaseDatos.JugadorSet.Where(j => j.apodo == jugador.Apodo).FirstOrDefault();
                if (jugadorRecuperado != null)
                {
                    if (jugadorRecuperado.apodo.Equals(jugador.Apodo))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public Boolean RegistrarJugador(Jugador jugador, Cuenta cuenta)
        {
            var cuentaExistente = ObtenerCuentaJugador(cuenta.Correo);
            if (cuentaExistente != null)
            {
                return false;
            }
            String nuevoSalt;
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                DAO.Jugador nuevoJugador = new DAO.Jugador() { apodo = jugador.Apodo, nombre = jugador.Nombre, apellidos = jugador.Apellidos };
                nuevoSalt = ObtenerSalt();
                conexionBaseDatos.CuentaSet.Add(new DAO.Cuenta()
                {
                    correo = cuenta.Correo,
                    password = ObtenerHash(cuenta.Contraseña, nuevoSalt),
                    salt = nuevoSalt,
                    validada = false,
                    Jugador = nuevoJugador,
                });
                try
                {
                    conexionBaseDatos.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return true;
        }

        public bool ActivarCuentaJugador(Cuenta cuenta, String codigo)
        {
            var cuentaRecuperada = ObtenerCuentaJugador(cuenta.Correo);
            if (cuentaRecuperada != null && cuentaRecuperada.salt.Equals(codigo))
            {
                conexionBaseDatos = new ServidorSE();
                using (conexionBaseDatos)
                {
                    cuentaRecuperada.validada = true;
                    conexionBaseDatos.Entry(cuentaRecuperada).State = System.Data.Entity.EntityState.Modified;
                    conexionBaseDatos.SaveChanges(); Consultar();
                }
                return true;
            }
            return false;
        }

        public List<FilaTablaPuntajes> ConsultarPuntajesPropios(Jugador jugador)
        {
            List<FilaTablaPuntajes> ListaFilas = new List<FilaTablaPuntajes>();
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                var listaPuntajes = conexionBaseDatos.PuntuacionSet.Where(p => p.Jugador.apodo == jugador.Apodo).ToList();
                foreach (var puntaje in listaPuntajes)
                {
                    ListaFilas.Add(new FilaTablaPuntajes(){
                        Apodo = puntaje.Jugador.apodo,
                        Fecha = puntaje.Partida.tiempo_fin,
                        Turnos = puntaje.turnos,
                        Puntos = puntaje.puntos
                    });
                }
            }
            return ListaFilas;
        }

        public List<FilaTablaPuntajes> ConsultarMejoresPuntajes()
        {
            List<FilaTablaPuntajes> ListaFilas = new List<FilaTablaPuntajes>();
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                var listaPuntajes = conexionBaseDatos.PuntuacionSet.OrderByDescending(p => p.puntos).Take(10).ToList();
                foreach (var puntaje in listaPuntajes)
                {
                    ListaFilas.Add(new FilaTablaPuntajes()
                    {
                        Apodo = puntaje.Jugador.apodo,
                        Fecha = puntaje.Partida.tiempo_fin,
                        Turnos = puntaje.turnos,
                        Puntos = puntaje.puntos
                    });
                }
            }
            return ListaFilas;
        }

        public void Consultar()
        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                var lista = conexionBaseDatos.JugadorSet.ToList();
                var lista2 = conexionBaseDatos.CuentaSet.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine(item.Id + item.apodo + item.Cuenta.correo);
                }
                foreach (var item in lista2)
                {
                    Console.WriteLine(item.Id + item.correo + item.password + item.validada);
                }
            }
        }

    }

}


