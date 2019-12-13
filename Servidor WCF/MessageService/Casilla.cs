using System.Runtime.Serialization;


namespace MessageService
{
    /// <summary>
    /// Contrato que describe los datos que se van a intercambiar de la Casilla
    /// </summary>
    [DataContract]
    public class Casilla
    {
        /// <summary>
        /// Constructor de la clase casilla
        /// </summary>
        /// <param name="idRecibido"> id de la casilla</param>
        /// <param name="filaRecibida"> fila en la que se encuentra la casilla</param>
        /// <param name="columnaRecibida"> columna en la que se encuentra la casilla</param>
        public Casilla(int idRecibido, int filaRecibida, int columnaRecibida)
        {
            Id = idRecibido;
            Fila = filaRecibida;
            Columna = columnaRecibida;
        }
        /// <summary>
        /// Propiedad para obtener y modificar el id
        /// </summary>
        [DataMember]
        public int Id { get; set; }
        /// <summary>
        /// Propiedad para obetner y modificar la fila
        /// </summary>
        [DataMember]
        public int Fila { get; set; }
        /// <summary>
        /// propiedad para modificar y obtener la columna
        /// </summary>
        [DataMember]
        public int Columna { get; set; }
        /// <summary>
        /// Propiedad para obtener y modificar casillas especiales
        /// </summary>
        [DataMember]
        public bool Especial { get; set; }
    }
}
