using System;
using System.ServiceModel;


namespace Host {
    public static class Program {
       public static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(MessageService.ServicioSistema)))
            {
                host.Open();
                Console.WriteLine("Server is running");
                Console.ReadLine();
            }
        }
    }
}
