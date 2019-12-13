using System;
using System.Runtime.Serialization;

namespace MessageService
{
    /// <summary>
    /// Contrato que expondra los datos de los puntajes de
    /// los jugadores
    /// </summary>
    [DataContract]
    public class FilaTablaPuntajes
    {
        /// <summary>
        /// Propiedad Apodo del jugador que será serializado
        /// </summary>
        [DataMember]
        public String Apodo { get; set; }
        /// <summary>
        /// Proiedada a serializar 
        /// </summary>
        [DataMember]
        public DateTime Fecha { get; set; }
        /// <summary>
        /// Propiedad a serializar
        /// </summary>
        [DataMember]
        public int Turnos { get; set; }
        /// <summary>
        /// Propiedad a serializar
        /// </summary>
        [DataMember]
        public int Puntos { get; set; }
    }
}
