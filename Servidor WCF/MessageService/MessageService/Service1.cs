using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAO;

namespace MessageService {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IUserManager {

        public List<Usuario> lista_usuarios = new List<Usuario>();

        public int AddUser(User user) {
            Model1Container base_datos = new Model1Container();
            using (base_datos)
            {
                User nuevo = new User { ID = 3, UserName = "xdxdxd", LastName = "hernandez", USU="h", PASS="d"};
                base_datos.UsuarioSet.Add(new Usuario { Id=nuevo.ID, nombre=nuevo.UserName, apellido=nuevo.LastName, usuario=nuevo.USU, password=nuevo.PASS});
                base_datos.SaveChanges();
                var query = from u in base_datos.UsuarioSet
                                select u;
                foreach(var item in query)
                {
                    Console.WriteLine(item.Id + item.nombre + item.apellido);
                }
            }
            return -1;
            
        }

        public User GetUserById(String userId) {
            Model1Container base_datos = new Model1Container();
            return new User {
                LastName = "Perez",
                UserName = "Juan"
            };
        }
    }
}


//Copiar el contenido de APP.config de MessageService al de Host desde  <system.serviceModel>