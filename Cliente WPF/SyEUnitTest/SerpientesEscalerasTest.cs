using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerpientesEscaleras.ServidorJuegoSE;

namespace SyEUnitTest
{
    [TestClass]
    public class SerpientesEscalerasTest
    {
        [TestMethod]
        public void RegistrarseTest()
        {
            ReferenciaServidor.
             cliente = new AdministradorCuentaClient();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            var esperado = cliente.RegistrarJugador(jugador, cuenta);
            Assert.AreEqual(true, esperado );

        }
    }
}
