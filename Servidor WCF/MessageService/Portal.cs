using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessageService
{
    [DataContract]
    public class Portal
    {
        private String zonaTablero;
        private String color;
        private String uriPortal;
        private int idCasilla;

        [DataMember]
        public String ZonaTablero { get { return zonaTablero; } set { zonaTablero = value; } }
        [DataMember]
        public String Color { get { return color; } set { color = value; } }
        [DataMember]
        public String UriPortal { get { return uriPortal; } set { uriPortal = value; } }
        [DataMember]
        public int IdCasilla { get { return idCasilla; } set { idCasilla = value; } }

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
