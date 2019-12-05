using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
