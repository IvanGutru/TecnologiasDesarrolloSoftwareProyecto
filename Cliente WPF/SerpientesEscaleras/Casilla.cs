

namespace SerpientesEscaleras
{
    class Casilla
    {
        public Casilla(int idRecibido, int filaRecibida, int columnaRecibida)
        {
            Id = idRecibido;
            Fila = filaRecibida;
            Columna = columnaRecibida;
        }

        public int Id { get; set; }
        public int Fila { get; set; }
        public int Columna { get; set; }
        public bool Especial { get; set; }
        public Portal Portal { get; set; }
    }
}
