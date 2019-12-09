using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using DAO;
using System.Net.Mail;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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


        public int EnviarCorreo(Cuenta cuenta)

        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                DAO.Cuenta cuentaRecuperada;
                try
                {
                    cuentaRecuperada = conexionBaseDatos.CuentaSet.Where(c => c.correo.Equals(cuenta.Correo)).FirstOrDefault();
                    if (cuentaRecuperada == null)
                    {
                        return -1;
                    }
                    if (!cuentaRecuperada.correo.Equals(cuenta.Correo))
                    {
                        return -1;
                    }
                }
                catch (System.Data.Entity.Core.EntityException)
                {
                    return -10;
                }
                MessageService.Encriptador encriptador = new MessageService.Encriptador();
                Stream openFileStream = File.OpenRead("CuentaCorreo.txt");
                BinaryFormatter deserializer = new BinaryFormatter();
                String correoJuego = (String)deserializer.Deserialize(openFileStream);
                String contraseñaJuego = (String)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
                MailAddress direccionJuego = new MailAddress(encriptador.Desencriptar(correoJuego), "LIRI Games");
                MailAddress direccionJugador = new MailAddress(cuenta.Correo, cuentaRecuperada.Jugador.apodo);
                MailMessage correo = new MailMessage(direccionJuego, direccionJugador);
                correo.Subject = "Activación de la cuenta de Serpientes y Escaleras";
                correo.Body = "<p>Código para la activación de la cuenta: " + cuentaRecuperada.salt + " </p><br>";
                correo.IsBodyHtml = true;
                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
                clienteSmtp.EnableSsl = true;
                clienteSmtp.UseDefaultCredentials = false;
                clienteSmtp.Port = 587;
                clienteSmtp.Credentials = new System.Net.NetworkCredential(direccionJuego.Address, encriptador.Desencriptar(contraseñaJuego));
                try
                {
                    clienteSmtp.Send(correo);
                }
                catch (Exception)
                {
                    return 0;
                }
                clienteSmtp.Dispose();
                return 1;
            }
        }

        public Jugador IniciarSesion(Cuenta cuenta)
        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                DAO.Cuenta cuentaRecuperada;
                try
                {
                    cuentaRecuperada = conexionBaseDatos.CuentaSet.Where(c => c.correo.Equals(cuenta.Correo)).FirstOrDefault();
                    if (cuentaRecuperada != null && cuentaRecuperada.correo.Equals(cuenta.Correo))
                    {
                        
                        
                            String contreseñaHasheada = ObtenerHash(cuenta.Contraseña, cuentaRecuperada.salt);
                            if (contreseñaHasheada.Equals(cuentaRecuperada.password ))
                            {
                          
                                cuentaRecuperada.secionIniciada = true;
                                conexionBaseDatos.Entry(cuentaRecuperada).State = System.Data.Entity.EntityState.Modified;
                                conexionBaseDatos.SaveChanges();
                                return new Jugador() { Apodo = cuentaRecuperada.Jugador.apodo };
                          
                            }
                        
                    }
                }
                catch (Exception)
                {
                    return new Jugador { Apodo = "ErrorConexionBaseDatos"};
                }
            }
            return null;
        }

        public Cuenta VerificarCuenta(Cuenta cuenta)
        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                DAO.Cuenta cuentaRecuperada;
                try
                {
                    cuentaRecuperada = conexionBaseDatos.CuentaSet.Where(c => c.correo.Equals(cuenta.Correo)).FirstOrDefault();
                    if (cuentaRecuperada != null && cuentaRecuperada.correo.Equals(cuenta.Correo))
                    {
                            return new Cuenta { Correo = cuentaRecuperada.correo, Validada = cuentaRecuperada.validada };
                    }
                }
                catch (System.Data.Entity.Core.EntityException)
                {
                    return new Cuenta { Correo = "ErrorConexionBaseDatos" };
                }
            }
            return null;
        }

        public int RegistrarJugador(Jugador jugador, Cuenta cuenta)
        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                DAO.Jugador jugadorRecuperado;
                DAO.Cuenta cuentaRecuperada;
                try
                {
                    jugadorRecuperado = conexionBaseDatos.JugadorSet.Where(j => j.apodo.Equals(jugador.Apodo)).FirstOrDefault();
                    cuentaRecuperada = conexionBaseDatos.CuentaSet.Where(c => c.correo.Equals(cuenta.Correo)).FirstOrDefault();
                    if (jugadorRecuperado != null && jugadorRecuperado.apodo.Equals(jugador.Apodo))
                    {
                            return -1;
                    }
                    if (cuentaRecuperada != null && cuentaRecuperada.correo.Equals(cuenta.Correo))
                    {
                            return -2;   
                    }
                    String nuevoSalt;
                    nuevoSalt = ObtenerSalt();
                    DAO.Jugador nuevoJugador = new DAO.Jugador() { 
                        apodo = jugador.Apodo, 
                        nombre = jugador.Nombre, 
                        apellidos = jugador.Apellidos };
                    conexionBaseDatos.CuentaSet.Add(new DAO.Cuenta()
                    {
                        correo = cuenta.Correo,
                        password = ObtenerHash(cuenta.Contraseña, nuevoSalt),
                        salt = nuevoSalt,
                        validada = false,
                        secionIniciada = false,
                        Jugador = nuevoJugador,
                    });
                    conexionBaseDatos.SaveChanges();
                }
                catch (System.Data.Entity.Core.EntityException)
                {
                    return -10;
                }
                catch (Exception)
                {
                    return -11;
                }
            }
            return 1;
        }

        public int ActivarCuentaJugador(Cuenta cuenta, String codigo)
        {
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                DAO.Cuenta cuentaRecuperada;
                try
                {
                    cuentaRecuperada = conexionBaseDatos.CuentaSet.Where(c => c.correo.Equals(cuenta.Correo)).FirstOrDefault();
                    if (cuentaRecuperada != null && !cuentaRecuperada.correo.Equals(cuenta.Correo))
                    {
                            return -1;
                    }
                    if (cuentaRecuperada == null)
                    {
                        return -1;
                    }
                    if (!cuentaRecuperada.salt.Equals(codigo))
                    {
                        return 0;
                    }
                    cuentaRecuperada.validada = true;
                    conexionBaseDatos.Entry(cuentaRecuperada).State = System.Data.Entity.EntityState.Modified;
                    conexionBaseDatos.SaveChanges();
                }
                catch (System.Data.Entity.Core.EntityException)
                {
                    return -10;
                }
                catch (Exception)
                {
                    return -11;
                }
            }
            return 1;
        }

        public List<FilaTablaPuntajes> ConsultarPuntajesPropios(Jugador jugador)
        {
            List<FilaTablaPuntajes> ListaFilas = new List<FilaTablaPuntajes>();
            conexionBaseDatos = new ServidorSE();
            using (conexionBaseDatos)
            {
                List<DAO.Puntuacion> listaPuntajes;
                try
                {
                    listaPuntajes = conexionBaseDatos.PuntuacionSet.Where(p => p.Jugador.apodo.Equals(jugador.Apodo)).ToList();
                }
                catch (System.Data.Entity.Core.EntityException)
                {
                    return null;
                } catch (Exception) 
                {
                    return null;
                }
                foreach (var puntaje in listaPuntajes)
                {
                    ListaFilas.Add(new FilaTablaPuntajes(){
                        Apodo = puntaje.Jugador.apodo,
                        Turnos = puntaje.turnos,
                        Puntos = 10000 / puntaje.turnos
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
                List<DAO.Puntuacion> listaPuntajes;
                try
                {
                    listaPuntajes = conexionBaseDatos.PuntuacionSet.OrderByDescending(x => x.turnos).Take(10).ToList();
                }
                catch (System.Data.Entity.Core.EntityException)
                {
                    return null;
                } catch (Exception)
                {
                    return null;
                }
                foreach (var puntaje in listaPuntajes)
                {
                    ListaFilas.Add(new FilaTablaPuntajes()
                    {
                        Apodo = puntaje.Jugador.apodo,
                        Turnos = puntaje.turnos,
                        Puntos = 10000 / puntaje.turnos
                    });
                }
            }
            return ListaFilas;
        }

    }

}


