using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace MessageService
{
    [DataContract]
    public class Portal
    {
        [DataMember]
        public String ZonaTablero { get; set; }
        [DataMember]
        public String Color { get; set; }
        [DataMember]
        public String UriPortal { get; set; }
        [DataMember]
        public int IdCasilla { get; set; }

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
