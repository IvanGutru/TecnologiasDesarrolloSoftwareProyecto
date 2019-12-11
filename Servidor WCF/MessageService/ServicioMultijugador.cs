using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using DAO;


namespace MessageService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioSistema : IAdministradorMultijugador
    {
        List<Sala> salasAbiertas = new List<Sala>();
        private int idsSalas = 1;

        private int BuscarSala(int idSala)
        {
            return salasAbiertas.FindIndex(x => x.IdSala == idSala);
        }

        public int CrearSala(Sala sala)
        {
            sala.DiccionarioJugadoresLobby = new Dictionary<IJugador, Jugador>();
            sala.IdSala = idsSalas;
            sala.Jugando = false;
            idsSalas++;
            salasAbiertas.Add(sala);
            return sala.IdSala;
        }

        public List<String> ConsultarJugadoresSala(int idSala)
        {
            int indice = BuscarSala(idSala);
            List<String> listaApodos = new List<String>();
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadoresLobby)
            {
                listaApodos.Add(miembro.Value.Apodo);
            }
            return listaApodos;
        }

        public void UnirseSala(int idSala, Jugador jugador)
        {
            int indice = BuscarSala(idSala);
            var conexion = OperationContext.Current.GetCallbackChannel<IJugador>();
            salasAbiertas[indice].DiccionarioJugadoresLobby[conexion] = jugador;
            salasAbiertas[indice].NumJugadores++;
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadoresLobby.Keys)
            {
                miembro.RecibirMensajeMiembroLobby(true, jugador.Apodo);
            }
            if(salasAbiertas[indice].NumJugadores == 4)
            {
                IniciarJuego(idSala);
            }
        }

        public Boolean ValidarSala(int idSala)
        {
            int indice = BuscarSala(idSala);
            if(indice == -1)
            {
                return false;
            }
            if (salasAbiertas[indice].NumJugadores >= 4 || salasAbiertas[indice].Jugando)
            {
                return false;
            }
            return true;
        }

        public List<Sala> ConsultarSalasDisponibles()
        {
            List<Sala> salasDisponibles = new List<Sala>();
            foreach (var sala in salasAbiertas)
            {
                if (sala.NumJugadores < 4 && !sala.Jugando)
                {
                    salasDisponibles.Add(new Sala()
                    {
                        IdSala = sala.IdSala,
                        Nombre = sala.Nombre,
                        DobleDado = sala.DobleDado,
                        DobleFicha = sala.DobleFicha,
                        CasillasEspeciales = sala.CasillasEspeciales,
                        NumJugadores = sala.NumJugadores,
                        UriFondoTablero = sala.UriFondoTablero
                    });
                }
            }
            return salasDisponibles;
        }

        public void EnviarMensaje(int idSala, string mensaje)
        {
            int indice = BuscarSala(idSala);
            var conexion = OperationContext.Current.GetCallbackChannel<IJugador>();
            Jugador jugador;
            if (!salasAbiertas[indice].DiccionarioJugadoresLobby.TryGetValue(conexion, out jugador))
            {
                return;
            }
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadoresLobby.Keys)
            {
                try
                {
                    miembro.RecibirMensajeLobby(jugador.Apodo + ": " + mensaje);
                }
                catch (System.ServiceModel.CommunicationObjectAbortedException)
                {
                   
                }
                
            }
        }

        private void SacarDelLobby(int indiceSala, IJugador conexion)
        {
            Jugador jugador;
            salasAbiertas[indiceSala].DiccionarioJugadoresLobby.TryGetValue(conexion, out jugador);
            salasAbiertas[indiceSala].DiccionarioJugadoresLobby.Remove(conexion);
            salasAbiertas[indiceSala].NumJugadores--;
            if (salasAbiertas[indiceSala].NumJugadores == 0)
            {
                salasAbiertas.RemoveAt(indiceSala);
                return;
            }
            foreach (var miembro in salasAbiertas[indiceSala].DiccionarioJugadoresLobby.Keys)
            {
                try
                {
                    miembro.RecibirMensajeMiembroLobby(false, jugador.Apodo);
                }
                catch (Exception)
                {
                    SacarDelLobby(indiceSala, conexion);
                }
                
            }
        }

        public void SalirChat(int idSala)
        {
            int indice = BuscarSala(idSala);
            if (salasAbiertas[indice].Jugando)
            {
                return;
            }
            var conexion = OperationContext.Current.GetCallbackChannel<IJugador>();
            Jugador jugador;
            if (!salasAbiertas[indice].DiccionarioJugadoresLobby.TryGetValue(conexion, out jugador))
            {
                return;
            }
            salasAbiertas[indice].DiccionarioJugadoresLobby.Remove(conexion);
            salasAbiertas[indice].NumJugadores--;
            if (salasAbiertas[indice].NumJugadores == 0)
            {
                salasAbiertas.RemoveAt(indice);
                return;
            }
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadoresLobby.Keys)
            {
                miembro.RecibirMensajeMiembroLobby(false, jugador.Apodo);
            }
        }

        public void IniciarJuego(int idSala)
        {
            int indice = BuscarSala(idSala);
            salasAbiertas[indice].Jugando = true;
            salasAbiertas[indice].DiccionarioJugadores = new Dictionary<IJugador, Jugador>();
            salasAbiertas[indice].Fichas = new List<Ficha>();
            List<Casilla> casillas = CrearCasillas(7, 10);
            if (salasAbiertas[indice].CasillasEspeciales)
            {
                casillas = AnñadirCasillasEspeciales(casillas);
            }
            List<Portal> portales = CrearPortales(casillas);
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadoresLobby.Keys)
            {
                miembro.EntrarJuego( casillas.ToArray(), portales.ToArray());
            }
        }

        public void UnirseJuego(int idSala, Jugador jugador)
        {
            int indice = BuscarSala(idSala);
            var conexion = OperationContext.Current.GetCallbackChannel<IJugador>();
            salasAbiertas[indice].DiccionarioJugadores[conexion] = jugador;
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.RecibirMensajeMiembro(true, jugador.Apodo);
            }
            if(salasAbiertas[indice].DiccionarioJugadores.Count == salasAbiertas[indice].NumJugadores)
            {
                EmpezarElegirFichas(indice);
            }
        }

        public void EnviarMensajeJuego(int idSala, string mensaje)
        {
            int indice = BuscarSala(idSala);
            var conexion = OperationContext.Current.GetCallbackChannel<IJugador>();
            Jugador jugador;
            if (!salasAbiertas[indice].DiccionarioJugadores.TryGetValue(conexion, out jugador))
            {
                return;
            }
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.RecibirMensaje(jugador.Apodo + ": " + mensaje);
            }
        }

        public void SalirJuego(int idSala)
        {
            int indice = BuscarSala(idSala);
            var conexion = OperationContext.Current.GetCallbackChannel<IJugador>();
            Jugador jugador;
            if (!salasAbiertas[indice].DiccionarioJugadores.TryGetValue(conexion, out jugador))
            {
                return;
            }
            salasAbiertas[indice].DiccionarioJugadores.Remove(conexion);
            salasAbiertas[indice].JugadoresJugando.Remove(jugador.Apodo);
            salasAbiertas[indice].NumJugadores--;
            if (salasAbiertas[indice].NumJugadores == 1)
            {
                var ultimoJugador = salasAbiertas[indice].DiccionarioJugadores.First().Key;
               
                salasAbiertas.RemoveAt(indice);
                return;
            }
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.RecibirMensajeMiembro(false, jugador.Apodo);
            }
        }
  
        private void EmpezarElegirFichas(int indice)
        {
            salasAbiertas[indice].JugadoresJugando = new List<string>();
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Values)
            {
                salasAbiertas[indice].JugadoresJugando.Add(miembro.Apodo);
            }
            salasAbiertas[indice].JugadorEnTurno = salasAbiertas[indice].JugadoresJugando.First();
          
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.ElegirFicha(salasAbiertas[indice].JugadorEnTurno, salasAbiertas[indice].Fichas.ToArray());
            }
        }

        public void AsignarFicha(int idSala, Ficha ficha)
        {
            int indice = BuscarSala(idSala);
            salasAbiertas[indice].Fichas.Add(ficha);
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.MostrarFichaElegida(ficha);
            }
            SiguienteTurno(indice);
            var jugador = salasAbiertas[indice].JugadorEnTurno;
            var fichaTemporal = salasAbiertas[indice].Fichas.Find(x => x.ApodoJugador.Equals(jugador));
            if (fichaTemporal == null)
            {
                foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
                {
                    miembro.ElegirFicha(salasAbiertas[indice].JugadorEnTurno, salasAbiertas[indice].Fichas.ToArray());
                }
            }
            else
            {
                foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
                {
                    miembro.Tirar(salasAbiertas[indice].JugadorEnTurno);
                }
            }
        }

        public void RecibirTiro(int idSala, int numDado)
        {
            int indice = BuscarSala(idSala);
            var ficha = salasAbiertas[indice].Fichas.Find(x => x.ApodoJugador == salasAbiertas[indice].JugadorEnTurno);
            ficha.Posicion = ficha.Posicion + numDado;
            ficha.Movimientos++;
            if (ficha.Posicion > 70)
            {
                ficha.Posicion = 70 - (ficha.Posicion - 70);
            }
            if (ficha.Posicion == 70)
            {
                foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
                {
                    RegistrarPuntaje(indice, ficha);
                    miembro.MostrarGanador(ficha);
                }
                return;
            }
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.MostrarTiro(ficha);
            }
            SiguienteTurno(indice);
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.Tirar(salasAbiertas[indice].JugadorEnTurno);
            }
        }

        public void CambiarPosicionFicha(int idSala, Ficha ficha)
        {
            int indice = BuscarSala(idSala);
            var fichaACambiar = salasAbiertas[indice].Fichas.Find(x => x.ApodoJugador == ficha.ApodoJugador);
            fichaACambiar.Posicion = ficha.Posicion;
        }

        private void SiguienteTurno(int indice)
        {
            int indiceJugador = salasAbiertas[indice].JugadoresJugando.FindIndex(x => x.Equals(salasAbiertas[indice].JugadorEnTurno));
            if(indiceJugador < salasAbiertas[indice].JugadoresJugando.Count-1)
            {
                salasAbiertas[indice].JugadorEnTurno = salasAbiertas[indice].JugadoresJugando.ElementAt(indiceJugador + 1);
            }
            else
            {
                salasAbiertas[indice].JugadorEnTurno = salasAbiertas[indice].JugadoresJugando.ElementAt(0);
            }
        }

        private List<Casilla> CrearCasillas(int filas, int columnas)
        {
            List<Casilla> casillas = new List<Casilla>();
            int id = 1;
            int columna;
            for (int fila = filas - 1; fila >= 0; fila--)
            {
                if (fila % 2 == 0)
                {
                    for (columna = 0; columna < columnas; columna++)
                    {
                        casillas.Add(new Casilla(id, fila, columna));
                        id++;
                    }
                }
                else
                {
                    for (columna = 9; columna >= 0; columna--)
                    {
                        casillas.Add(new Casilla(id, fila, columna));
                        id++;
                    }
                }
            }
            return casillas;
        }

        private List<Casilla> AnñadirCasillasEspeciales(List<Casilla> casillas)
        {
            Random aleatorio = new Random();
            int indiceCasilla;
            int columna;
            for (int i = 0; i < 7; i++)
            {
                do
                {
                    columna = aleatorio.Next(0, 10);
                    indiceCasilla = casillas.FindIndex(x => x.Columna == columna && x.Fila == i);
                } while (casillas[indiceCasilla].Id == 70 || casillas[indiceCasilla].Id == 1);
                casillas[indiceCasilla].Especial = true;
            }
            return casillas;
        }

        private List<Portal> CrearPortales(List<Casilla> casillas)
        {
            List<Portal> portales = new Portal().CrearPortales();
            Random aleatorio = new Random();
            Casilla casilla;
            int portalEnCasilla;
            int fila;
            int columna;
            for (int i = 0; i < portales.Count; i++)
            {
                do
                {
                    if (portales[i].ZonaTablero.Equals("abajo"))
                    {
                        fila = aleatorio.Next(4, 7);
                    }
                    else
                    {
                        fila = aleatorio.Next(0, 4);
                    }
                    columna = aleatorio.Next(0, 10);
                    casilla = casillas.Find(x => x.Columna == columna && x.Fila == fila);
                    portalEnCasilla = portales.FindIndex(x => x.IdCasilla == casilla.Id);
                } while (casilla.Especial || portalEnCasilla != -1 || casilla.Id == 70 || casilla.Id == 1);
                portales[i].IdCasilla = casilla.Id;
            }
            return portales;
        }

        public void CambiarPortales(int idSala, Casilla[] casillasRecibidas, Portal[] portalesRecibidos)
        {
            List<Casilla> casillas = casillasRecibidas.ToList();
            List<Portal> portales = portalesRecibidos.ToList();
            Random aleatorio = new Random();
            Casilla casilla;
            int portalEnCasilla;
            int fila;
            int columna;
            for (int i = 0; i < portales.Count; i++)
            {
                do
                {
                    if (portales[i].ZonaTablero.Equals("abajo"))
                    {
                        fila = aleatorio.Next(4, 7);
                    }
                    else
                    {
                        fila = aleatorio.Next(0, 4);
                    }
                    columna = aleatorio.Next(0, 10);
                    casilla = casillas.Find(x => x.Columna == columna && x.Fila == fila);
                    portalEnCasilla = portales.FindIndex(x => x.IdCasilla == casilla.Id);
                } while (casilla.Especial || casilla.Id == 70 || casilla.Id == 1 || (portalEnCasilla < i && portalEnCasilla >= 0));
                portales[i].IdCasilla = casilla.Id;
            }
            int indice = BuscarSala(idSala);
            var nuevosPortales = portales.ToArray();
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.MostrarNuevosPortales(nuevosPortales);
            }
        }

    }
}
