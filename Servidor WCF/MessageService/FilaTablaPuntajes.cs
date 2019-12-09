using System;
using System.Runtime.Serialization;

namespace MessageService
{
    [DataContract]
    public class FilaTablaPuntajes
    {
        [DataMember]
        public String Apodo { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public int Turnos { get; set; }
        [DataMember]
        public int Puntos { get; set; }
    }
}
