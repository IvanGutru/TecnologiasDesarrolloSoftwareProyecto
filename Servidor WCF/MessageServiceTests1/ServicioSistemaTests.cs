using MessageService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MessageService.Tests
{
    [TestClass]
    public class ServicioSistemaTests
    {
        [TestMethod]
        public void RegistrarJugadorTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Cuenta cuenta = new Cuenta();
            Jugador jugador = new Jugador();
            bool resultadoActual = servicioSistema.RegistrarJugador(jugador, cuenta);

            Assert.AreEqual(true, resultadoActual);
        }

        [TestMethod()]
        public void CrearSalaTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            Sala sala = new Sala(1);
            int resultadoActual = servicioSistema.CrearSala(sala);
            Assert.AreEqual(1, resultadoActual);
        }

        [TestMethod()]
        public void ObtenerCuentaJugadorTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            DAO.Cuenta cuenta = new DAO.Cuenta();
            DAO.Cuenta resultadoActual = servicioSistema.ObtenerCuentaJugador("irving_cena2@hotmail.com");
            Assert.AreEqual(cuenta, resultadoActual);

        }

        [TestMethod()]
        public void ConsultarJugadoresSalaTest()
        {
            ServicioSistema servicioSistema = new ServicioSistema();
            List<String> resultadoEsperado = new List<string> {"ha","sda" };
            
            List<String> resultadoActual= servicioSistema.ConsultarJugadoresSala(2);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }
    }
}