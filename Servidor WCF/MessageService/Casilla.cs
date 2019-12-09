using System.Runtime.Serialization;


namespace MessageService
{
    [DataContract]
    public class Casilla
    {
        public Casilla(int idRecibido, int filaRecibida, int columnaRecibida)
        {
            Id = idRecibido;
            Fila = filaRecibida;
            Columna = columnaRecibida;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Fila { get; set; }
        [DataMember]
        public int Columna { get; set; }
        [DataMember]
        public bool Especial { get; set; }
    }
}
