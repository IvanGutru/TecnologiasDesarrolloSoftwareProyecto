using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageService
{
    [DataContract]
    public class Casilla
    {
        private int id;
        private int fila;
        private int columna;
        private bool especial;

        public Casilla(int idRecibido, int filaRecibida, int columnaRecibida)
        {
            id = idRecibido;
            fila = filaRecibida;
            columna = columnaRecibida;
        }

        [DataMember]
        public int Id { get { return id; } set { id = value; } }
        [DataMember]
        public int Fila { get { return fila; } set { fila = value; } }
        [DataMember]
        public int Columna { get { return columna; } set { columna = value; } }
        [DataMember]
        public bool Especial { get { return especial; } set { especial = value; } }
    }
}
