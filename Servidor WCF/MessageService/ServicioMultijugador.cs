using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;


namespace MessageService
{
    /// <summary>
    /// Contexto para el multijugador en un canal
    /// </summary>
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioSistema : IAdministradorMultijugador
    {
        const int CASILLAFINAL = 70;
        const int TOTALJUGADORESPARTIDA = 4;
        const int FILAS = 7;
        const int COLUMNAS = 10;
        List<Sala> salasAbiertas = new List<Sala>();
        private int idsSalas = 1;

        private int BuscarSala(int idSala)
        {
            return salasAbiertas.FindIndex(x => x.IdSala == idSala);
        }
        /// <summary>
        /// Recibe la sala para registrar y la mete en el arreglo de salas abiertas
        /// </summary>
        /// <param name="sala"> Sala a registrar en el arreglo</param>
        /// <returns></returns>
        public int CrearSala(Sala sala)
        {
            sala.DiccionarioJugadoresLobby = new Dictionary<IJugador, Jugador>();
            sala.IdSala = idsSalas;
            sala.Jugando = false;
            idsSalas++;
            salasAbiertas.Add(sala);
            return sala.IdSala;
        }
        /// <summary>
        /// Consulta los jugadores que se encuentran en la sala
        /// </summary>
        /// <param name="idSala">Sala abierta de jugadores</param>
        /// <returns>Lista de jugadores en el lobby</returns>
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
        /// <summary>
        /// Agrega al jugador de la sala correspondiente al lobby
        /// </summary>
        /// <param name="idSala">Sala abierta de jugadores</param>
        /// <param name="jugador"> Jugador que se une</param>
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
            if(salasAbiertas[indice].NumJugadores == TOTALJUGADORESPARTIDA)
            {
                IniciarJuego(idSala);
            }
        }
        /// <summary>
        /// Verifica que la sala tenga menos de 3 jugadores y que no estén jugando
        /// </summary>
        /// <param name="idSala"></param>
        /// <returns></returns>
        public Boolean ValidarSala(int idSala)
        {
            int indice = BuscarSala(idSala);
            if(indice == -1)
            {
                return false;
            }
            if (salasAbiertas[indice].NumJugadores >= TOTALJUGADORESPARTIDA || salasAbiertas[indice].Jugando)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Muestra las salas que están disponibles que tengan
        /// cupo y que no esten jugando
        /// </summary>
        /// <returns>Lista de salas disponibles</returns>
        public List<Sala> ConsultarSalasDisponibles()
        {
            List<Sala> salasDisponibles = new List<Sala>();
            foreach (var sala in salasAbiertas)
            {
                if (sala.NumJugadores < TOTALJUGADORESPARTIDA && !sala.Jugando)
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
        /// <summary>
        /// Muestra los mensajes en el chat dentro del lobby
        /// para todos los miembros
        /// </summary>
        /// <param name="idSala"></param>
        /// <param name="mensaje"></param>
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
                    return;
                }
                
            }
        }
        /// <summary>
        /// Saca algún especifico del lobby
        /// </summary>
        /// <param name="indiceSala">Sala con los jugadores</param>
        /// <param name="conexion"> La interfaz de callback del jugador </param>
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
        /// <summary>
        /// Te saca del lobby
        /// </summary>
        /// <param name="idSala">sala del lobby en la que se encuentra</param>
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
        /// <summary>
        /// Inicializa los atributos de la sala, crea el dicionario de jugadores, crea las casillas,
        /// crea los portales, a todos los jugadores les manda la configuración
        /// </summary>
        /// <param name="idSala">Sala de l apartida</param>
        public void IniciarJuego(int idSala)
        {
            int indice = BuscarSala(idSala);
            salasAbiertas[indice].Jugando = true;
            salasAbiertas[indice].DiccionarioJugadores = new Dictionary<IJugador, Jugador>();
            salasAbiertas[indice].Fichas = new List<Ficha>();
            List<Casilla> casillas = CrearCasillas(FILAS, COLUMNAS);
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
        /// <summary>
        /// Se une al diccionario de jugadores dentro del juego
        /// </summary>
        /// <param name="idSala">Sala a la que se unieron</param>
        /// <param name="jugador">Jugador que se unió</param>
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
        /// <summary>
        /// Muestra los mensajes en el  chat del juego
        /// </summary>
        /// <param name="idSala">Sala del juego</param>
        /// <param name="mensaje">Mensjae enviado por un Jugador</param>
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
        /// <summary>
        /// Saca al jugador de la partida (diccionario de juego)
        /// </summary>
        /// <param name="idSala">Sala en la que ocurre la partida</param>
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
        /// <summary>
        /// Recibe la ficha que elegió el jugador y la añade a la lista de 
        /// fichas, si no todos han elegido fichas se vuelve a llamar al callback para elegir ficha,
        /// si todos eligieron ficha llama al calback para tirar
        /// </summary>
        /// <param name="idSala">Sala del juego</param>
        /// <param name="ficha">Ficha elegida por el Jugador</param>
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
        /// <summary>
        /// Recibe el nuemro del dado que haya diso tirado y regresa la ficha con la 
        /// nueva posicion, si cae en la casilla 70 muestra el ganador.
        /// </summary>
        /// <param name="idSala"></param>
        /// <param name="numDado"></param>
        public void RecibirTiro(int idSala, int numDado)
        {
            int indice = BuscarSala(idSala);
            var ficha = salasAbiertas[indice].Fichas.Find(x => x.ApodoJugador == salasAbiertas[indice].JugadorEnTurno);
            ficha.Posicion = ficha.Posicion + numDado;
            ficha.Movimientos++;
            if (ficha.Posicion > CASILLAFINAL)
            {
                ficha.Posicion = CASILLAFINAL - (ficha.Posicion - CASILLAFINAL);
            }
            if (ficha.Posicion == CASILLAFINAL)
            {
                foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
                {
                    RegistrarPuntaje(indice);
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
        /// <summary>
        /// Cambia la posicion de la ficha cuando cae en un portal
        /// </summary>
        /// <param name="idSala">Sala de la partida</param>
        /// <param name="ficha">ficah que cambiará de posición</param>
        public void CambiarPosicionFicha(int idSala, Ficha ficha)
        {
            int indice = BuscarSala(idSala);
            var fichaACambiar = salasAbiertas[indice].Fichas.Find(x => x.ApodoJugador == ficha.ApodoJugador);
            fichaACambiar.Posicion = ficha.Posicion;
        }
        /// <summary>
        /// Asigna el apdodo del jugador al atributo de Jugador en turno de la sala
        /// </summary>
        /// <param name="indice">Indice de la sala</param>
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
        /// <summary>
        /// Crea las 70 casillas en una lista
        /// </summary>
        /// <param name="filas">7 filas</param>
        /// <param name="columnas">10 columnas</param>
        /// <returns></returns>
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
        /// <summary>
        /// Al azar fila por fila elegie una columna y la cambia el atributo
        /// "casilla especial" a true
        /// </summary>
        /// <param name="casillas">Lista de casillas creadas</param>
        /// <returns></returns>
        private List<Casilla> AnñadirCasillasEspeciales(List<Casilla> casillas)
        {
            Random aleatorio = new Random();
            int indiceCasilla;
            int columna;
            for (int i = 0; i < FILAS; i++)
            {
                do
                {
                    columna = aleatorio.Next(0, COLUMNAS);
                    indiceCasilla = casillas.FindIndex(x => x.Columna == columna && x.Fila == i);
                } while (casillas[indiceCasilla].Id == CASILLAFINAL || casillas[indiceCasilla].Id == 1);
                casillas[indiceCasilla].Especial = true;
            }
            return casillas;
        }
        /// <summary>
        /// Crea la lista de portales y les asigna una casilla al azar
        /// cada portal tiene un atributo de la casilla en donde está
        /// </summary>
        /// <param name="casillas">Lista de casillas creadas</param>
        /// <returns>Lista de portalaes</returns>
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
                        fila = aleatorio.Next(4, FILAS);
                    }
                    else
                    {
                        fila = aleatorio.Next(0, 4);
                    }
                    columna = aleatorio.Next(0, COLUMNAS);
                    casilla = casillas.Find(x => x.Columna == columna && x.Fila == fila);
                    portalEnCasilla = portales.FindIndex(x => x.IdCasilla == casilla.Id);
                } while (casilla.Especial || portalEnCasilla != -1 || casilla.Id == CASILLAFINAL || casilla.Id == 1);
                portales[i].IdCasilla = casilla.Id;
            }
            return portales;
        }
        /// <summary>
        /// Cambia de posicion los portales cuando la ficha cae en una casilla especial
        /// </summary>
        /// <param name="idSala">Sala de la partida</param>
        /// <param name="casillasRecibidas">Lista de las casillas</param>
        /// <param name="portalesRecibidos">lista de portales</param>
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
                        fila = aleatorio.Next(4, FILAS);
                    }
                    else
                    {
                        fila = aleatorio.Next(0, 4);
                    }
                    columna = aleatorio.Next(0, COLUMNAS);
                    casilla = casillas.Find(x => x.Columna == columna && x.Fila == fila);
                    portalEnCasilla = portales.FindIndex(x => x.IdCasilla == casilla.Id);
                } while (casilla.Especial || casilla.Id == CASILLAFINAL || casilla.Id == 1 || (portalEnCasilla < i && portalEnCasilla >= 0));
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
