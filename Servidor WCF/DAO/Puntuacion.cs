//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Puntuacion
    {
        public int Id { get; set; }
        public short puntos { get; set; }
        public short turnos { get; set; }
    
        public virtual Jugador Jugador { get; set; }
        public virtual Partida Partida { get; set; }
    }
}
