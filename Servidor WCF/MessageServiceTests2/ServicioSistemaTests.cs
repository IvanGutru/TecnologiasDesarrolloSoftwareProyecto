using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageService;
using System.Collections.Generic;

namespace MessageService.Tests
{
    [TestClass()]
    public class ServicioSistemaTests
    {
        [TestMethod()]
        public void RegistrarJugadorExistenteTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";
            jugador.Apodo = "IvanGutru";
            jugador.Nombre = "Irving Iván";
            jugador.Apellidos = "Gumesindo Trujillo";

            bool resultadoActual = servicioSistema.RegistrarJugador(jugador, cuenta);
            Assert.AreEqual(false, resultadoActual);

        }
        [TestMethod]
        public void RegistrarJugadorNuevoTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            cuenta.Correo = "irving@hotmail.com";
            cuenta.Contraseña = "administrador";
            jugador.Apodo = "EL destructor";
            jugador.Nombre = "Juan ";
            jugador.Apellidos = "Perez";

            bool resultadoActual = servicioSistema.RegistrarJugador(jugador, cuenta);
            Assert.AreEqual(true, resultadoActual);

        }

        [TestMethod()]
        public void ObtenerCuentaJugadorTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            DAO.Cuenta cuentaEsperada = new DAO.Cuenta();
            string correo = "irving_cena2@hotmail.com";
            DAO.Cuenta resultadoActual = servicioSistema.ObtenerCuentaJugador(correo);
            Assert.AreEqual(correo, resultadoActual.correo);

        }
        [TestMethod]
        public void ObtenerCuentaJugadorNullTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            DAO.Cuenta cuentaEsperada = new DAO.Cuenta();
            string correo = "ivan@hotmail.com";
            DAO.Cuenta resultadoActual = servicioSistema.ObtenerCuentaJugador(correo);
            Assert.AreEqual(null, resultadoActual);
        }

        //[TestMethod()]
        //public void UnirseASalaTest()
        //{
        //    Sala sala = new Sala();
        //    sala.DiccionarioJugadoresLobby = new Dictionary<IJugador, Jugador>();
        //    Jugador jugador = new Jugador();
        //    jugador.Apodo = "Ivansillo";
        //    jugador.Nombre = "Ivan";
        //    jugador.Apellidos = "Gumesindo";

        //}

        [TestMethod]
        public void EnviarCorreoTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";
            bool resultadoActual = servicioSistema.EnviarCorreo(cuenta);
            Assert.AreEqual(true, resultadoActual);
        }
        [TestMethod]
        public void EnviarCorreoNullTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "Arturo23@hotmail.com";
            cuenta.Contraseña = "quieropasar";
            bool resultadoActual = servicioSistema.EnviarCorreo(cuenta);
            Assert.AreEqual(false, resultadoActual);
        }
    }
}
