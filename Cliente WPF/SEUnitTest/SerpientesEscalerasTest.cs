using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEUnitTest.ServiceReference;

namespace SEUnitTest
{
    [TestClass]
    public class SerpientesEscalerasTest
    {
        [TestMethod]
        public void RegistrarJugadorExistenteTest()
        {
            AdministradorCuentaClient cliente = new AdministradorCuentaClient();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            cuenta.Correo = "irving_cena2@hotmail.com";
            cuenta.Contraseña = "administrador";
            jugador.Apodo = "IvanGutru";
            jugador.Apellidos = "Gumesindo";
            jugador.Nombre = "Irving ivan";
            bool resultadoActual = cliente.RegistrarJugador(jugador, cuenta);

            Assert.AreEqual(false, resultadoActual,"la cuenta ya existe");
        }

        [TestMethod]
        public void RegistrarJugadorNuevoTest()
        {
            AdministradorCuentaClient cliente = new AdministradorCuentaClient();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            cuenta.Correo = "irving@hotmail.com";
            cuenta.Contraseña = "administrador";
            jugador.Apodo = "IvanGutru";
            jugador.Apellidos = "Gumesindo";
            jugador.Nombre = "Irving ivan";
            bool resultadoActual = cliente.RegistrarJugador(jugador, cuenta);

            Assert.AreEqual(true, resultadoActual);
        }

    }
}
