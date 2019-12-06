using MessageService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace MessageService.Tests
{
    [TestClass]
    public class ServicioSistemaTests
    {
        [TestMethod]
        public void RegistrarJugadorTest()
        {
            int resultadoEsperado = 1;
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            cuenta.Correo = "Ivacdscdsng@hotmail.com";
            cuenta.Contraseña = "12334";
            jugador.Nombre = "Jose luis";
            jugador.Apellidos = "Lopez";
            jugador.Apodo = "El destructxzor";
            int resultadoActual = servicioSistema.RegistrarJugador(jugador, cuenta);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }
        [TestMethod]
        public void RegistrarJugadorExistentePorApodoTest()
        {
            int resultadoEsperado = -1;
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            cuenta.Correo = "Ivang@hotmail.com";
            cuenta.Contraseña = "12334";
            jugador.Nombre = "Jose luis";
            jugador.Apellidos = "Lopez";
            jugador.Apodo = "El destructor";
            int resultadoActual = servicioSistema.RegistrarJugador(jugador, cuenta);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }
        [TestMethod]
        public void RegistrarJugadorExistentePorCorreoTest()
        {
            int resultadoEsperado = -2;
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "12334";
            jugador.Nombre = "Jose luis";
            jugador.Apellidos = "Lopez";
            jugador.Apodo = "El czxc";
            int resultadoActual = servicioSistema.RegistrarJugador(jugador, cuenta);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [TestMethod()]
        public void CrearSalaTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Sala sala = new Sala();
            sala.IdSala = 1;
            int resultadoActual = servicioSistema.CrearSala(sala);
            Assert.AreEqual(1, resultadoActual);
        }

        [TestMethod]
        public void EnviarCorreoTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            int resultadoEsperado = 1;
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";
            int resultadoActual = servicioSistema.EnviarCorreo(cuenta);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }
        [TestMethod]
        public void EnviarCorreosDiferentesTest()
        {
            int resultadoEsperado = -1;
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena22@hotmail.com";
            cuenta.Contraseña = "administrador";
            int resultadoActual = servicioSistema.EnviarCorreo(cuenta);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [TestMethod]
        public void IniciarSesionTest()
        {
            Jugador resultadoEsperado = new Jugador();
            resultadoEsperado.Apodo = "IvanGutru";
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";

            Assert.AreNotEqual(resultadoEsperado, servicioSistema.IniciarSesion(cuenta));

        }

        [TestMethod()]
        public void VerificarCuentaNoExisteTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena2hsdasotmail.com";
            cuenta.Contraseña = "administrador";
            Assert.AreEqual(null, servicioSistema.VerificarCuenta(cuenta));

        }
        [TestMethod()]
        public void VerificarCuentaTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";
            Cuenta resultadoEsperado = servicioSistema.VerificarCuenta(cuenta);
            Assert.AreNotEqual(cuenta, resultadoEsperado);

        }

        [TestMethod()]
        public void ActivarCuentaJugadorTest()
        {
            int resultadoEsperado = 1;
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";
            int resultadoActual = servicioSistema.ActivarCuentaJugador(cuenta, "dsgdK8fr/CQVY9jLtyop2w==");
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }
        [TestMethod()]
        public void ActivarCuentaJugadorNOExistenteTest()
        {
            int resultadoEsperado = -1;
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena34@hotmail.com";
            cuenta.Contraseña = "administrador";
            int resultadoActual = servicioSistema.ActivarCuentaJugador(cuenta, "dsgdK8fr/CQVY9jLtyop2w==");
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }
        [TestMethod()]
        public void ActivarCuentaJugadorCodigoNoValidoTest()
        {
            int resultadoEsperado = 0;
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";
            int resultadoActual = servicioSistema.ActivarCuentaJugador(cuenta, "dsg");
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [TestMethod()]
        public void ConsultarPuntajesPropiosTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Jugador jugador = new Jugador();
            jugador.Nombre = "Irving";
            jugador.Apellidos = "Gumesindo Trujillo";
            jugador.Apodo = "IvanGutru";
            List<FilaTablaPuntajes> ListaFilas = new List<FilaTablaPuntajes>();
            var resultadoActual = servicioSistema.ConsultarPuntajesPropios(jugador);
            Assert.AreNotEqual(ListaFilas, resultadoActual);
        }

        [TestMethod()]
        public void ValidarSalaTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Sala sala = new Sala();
            sala.NumJugadores = 1;
            bool resultadoActual = servicioSistema.ValidarSala(sala.IdSala);
            Assert.AreEqual(false, resultadoActual);
        }

    }
}