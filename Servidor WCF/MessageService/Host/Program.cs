using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace Host {
    class Program {
        static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(MessageService.Service1)))
            {
                host.Open();
                Console.WriteLine("Server is running");
                Console.ReadLine();
            }
        }
    }
}


/*Permitir inicio de sesión, wpf agregar usuario y desplegar todos los usuairos en la bd y modificar
Agregar dos mas
    wcf con entity
    
     
 /Biblioteca de servicios 

    */