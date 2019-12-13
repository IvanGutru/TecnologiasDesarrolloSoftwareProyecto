using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace MessageService
{
    /// <summary>
    /// Expoene los datos de los portales
    /// </summary>
    [DataContract]
    public class Portal
    {
        /// <summary>
        /// Permite acceder a la Propiedad de la zana del tablero donde
        /// se encuentra el portal
        /// </summary>
        [DataMember]
        public String ZonaTablero { get; set; }
        /// <summary>
        /// Permite acceder a la Porpiedad color del portal
        /// </summary>
        [DataMember]
        public String Color { get; set; }
        /// <summary>
        /// Permite acceder a la imagen para el portal
        /// </summary>
        [DataMember]
        public String UriPortal { get; set; }
        /// <summary>
        /// Permite acceder a la casilla en la que se 
        /// encuentra el portal
        /// </summary>
        [DataMember]
        public int IdCasilla { get; set; }
        /// <summary>
        /// Permite crear una lista de los portales para el tablero 
        /// </summary>
        /// <returns>Lista de los portales creados</returns>
        public List<Portal> CrearPortales()
        {
            List<Portal> portales = new List<Portal>();
            portales.Add(new Portal()
            {
                ZonaTablero = "arriba",
                Color = "Amarillo",
                UriPortal = "Resources/Tablero/Portales/portalAmarillo.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "abajo",
                Color = "Amarillo",
                UriPortal = "Resources/Tablero/Portales/portalAmarillo.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "arriba",
                Color = "Azul",
                UriPortal = "Resources/Tablero/Portales/portalAzul.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "abajo",
                Color = "Azul",
                UriPortal = "Resources/Tablero/Portales/portalAzul.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "arriba",
                Color = "BlancoNegro",
                UriPortal = "Resources/Tablero/Portales/portalBlancoNegro.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "abajo",
                Color = "BlancoNegro",
                UriPortal = "Resources/Tablero/Portales/portalBlancoNegro.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "arriba",
                Color = "Brilloso",
                UriPortal = "Resources/Tablero/Portales/portalBrilloso.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "abajo",
                Color = "Brilloso",
                UriPortal = "Resources/Tablero/Portales/portalBrilloso.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "arriba",
                Color = "Colores",
                UriPortal = "Resources/Tablero/Portales/portalColores.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "abajo",
                Color = "Colores",
                UriPortal = "Resources/Tablero/Portales/portalColores.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "arriba",
                Color = "Rojo",
                UriPortal = "Resources/Tablero/Portales/portalRojo.png"
            });
            portales.Add(new Portal()
            {
                ZonaTablero = "abajo",
                Color = "Rojo",
                UriPortal = "Resources/Tablero/Portales/portalRojo.png"
            });
            return portales;
        }
    }
}
