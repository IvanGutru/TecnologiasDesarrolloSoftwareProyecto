﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ServidorSE : DbContext
    {
        public ServidorSE()
            : base("name=ServidorSE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ficha> FichaSet { get; set; }
        public virtual DbSet<Partida> PartidaSet { get; set; }
        public virtual DbSet<Tablero> TableroSet { get; set; }
        public virtual DbSet<Casilla> CasillaSet { get; set; }
        public virtual DbSet<Puntuacion> PuntuacionSet { get; set; }
        public virtual DbSet<Cuenta> CuentaSet { get; set; }
        public virtual DbSet<Jugador> JugadorSet { get; set; }
        public virtual DbSet<Portal> PortalSet { get; set; }
        public virtual DbSet<FondoTablero> FondoTableroSet { get; set; }
    }
}
