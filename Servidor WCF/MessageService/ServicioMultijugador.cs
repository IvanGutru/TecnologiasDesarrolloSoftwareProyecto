using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

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
        }

        public Boolean ValidarSala(int idSala)
        {
            int indice = BuscarSala(idSala);
            if(indice == -1)
            {
                return false;
            }
            if (salasAbiertas[indice].NumJugadores >= 4)
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
                if (sala.NumJugadores <= 4)
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
                miembro.RecibirMensajeLobby(jugador.Apodo + ": " + mensaje);
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
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadoresLobby.Keys)
            {
                miembro.EntrarJuego();
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
            salasAbiertas[indice].NumJugadores--;
            if (salasAbiertas[indice].NumJugadores == 0)
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
            if (ficha.Posicion > 70)
            {
                ficha.Posicion = 70 - (ficha.Posicion - 70);
            }
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.MostrarTiro(ficha);
            }
            SiguienteTurno(indice);
            var jugador = salasAbiertas[indice].JugadorEnTurno;
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.Tirar(salasAbiertas[indice].JugadorEnTurno);
            }
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
    }

}
