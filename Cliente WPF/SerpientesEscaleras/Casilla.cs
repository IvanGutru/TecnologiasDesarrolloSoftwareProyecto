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

        public Casilla(int idRecibido, int filaRecibida, int columnaRecibida)
        {
            id = idRecibido;
            fila = filaRecibida;
            columna = columnaRecibida;
        }

        public int Id { get { return id; } set { id = value; } }
        public int Fila { get { return fila; } set { fila = value; } }
        public int Columna { get { return columna; } set { columna = value; } }
    }
}
