﻿using System;
using System.ServiceModel;


namespace Host {
    class Program {
        static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(MessageService.ServicioSistema)))
            {
                host.Open();
                Console.WriteLine("Server is running");
                Console.ReadLine();
            }
        }
    }
}
