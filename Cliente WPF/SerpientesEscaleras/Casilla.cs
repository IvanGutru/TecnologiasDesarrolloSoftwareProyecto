using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesEscaleras
{
    class Casilla
    {
        private int id;
        private int fila;
        private int columna;
        private bool especial;
        private Portal portal;

        public Casilla(int idRecibido, int filaRecibida, int columnaRecibida)
        {
            id = idRecibido;
            fila = filaRecibida;
            columna = columnaRecibida;
        }

        public int Id { get { return id; } set { id = value; } }
        public int Fila { get { return fila; } set { fila = value; } }
        public int Columna { get { return columna; } set { columna = value; } }
        public bool Especial { get { return especial; } set { especial = value; } }
        public Portal Portal { get { return portal; } set { portal = value; } }
    }
}
