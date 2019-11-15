using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageService.Tests
{
    [TestClass()]
    public class ServicioSistemaTests
    {
        [TestMethod()]
        public void IniciarSesionTest(Cuenta cuenta)
        {
          //  Cuenta cuenta = new Cuenta();
            cuenta.Contraseña = "";
            cuenta.Correo = "";

            ServicioSistema inicioSesion = new ServicioSistema();

            var resultado = inicioSesion.IniciarSesion( cuenta);
        }
    }
}