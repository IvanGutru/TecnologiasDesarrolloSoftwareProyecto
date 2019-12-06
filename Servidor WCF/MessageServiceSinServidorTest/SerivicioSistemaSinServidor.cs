using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageService;

namespace MessageServiceSinServidorTest
{
    [TestClass]
    public class SerivicioSistemaSinServidor
    {
        [TestMethod]
        public void RegistrarJugadorExcepcionEntityTest()
        {
            int resultadoEsperado = -11;
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
        [TestMethod()]
        public void ActivarCuentaJugadorExcepcionTest()
        {
            int resultadoEsperado = -11;
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";
            int resultadoActual = servicioSistema.ActivarCuentaJugador(cuenta, "dsgdK8fr/CQVY9jLtyop2w==");
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }
        [TestMethod()]
        public void ConsultarPuntajesPropiosTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Jugador jugador = new Jugador();
            jugador.Nombre = "Irving";
            jugador.Apellidos = "Gumesindo Trujillo";
            jugador.Apodo = "IvanG";
            var resultadoActual = servicioSistema.ConsultarPuntajesPropios(jugador);
            Assert.AreEqual(null, resultadoActual);
        }
        [TestMethod()]
        public void ConsultarMejoresPuntajesTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            var resultadoActual = servicioSistema.ConsultarMejoresPuntajes();
            Assert.AreEqual(null, resultadoActual);
        }
    }
}
