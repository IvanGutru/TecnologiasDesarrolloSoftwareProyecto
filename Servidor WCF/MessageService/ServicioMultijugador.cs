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
            sala.DiccionarioJugadores = new Dictionary<IJugador, Jugador>();
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
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores)
            {
                listaApodos.Add(miembro.Value.Apodo);
            }
            return listaApodos;
        }

        public void UnirseSala(int idSala, Jugador jugador)
        {
            int indice = BuscarSala(idSala);
            var conexion = OperationContext.Current.GetCallbackChannel<IJugador>();
            salasAbiertas[indice].DiccionarioJugadores[conexion] = jugador;
            salasAbiertas[indice].NumJugadores++;
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.RecibirMensajeMiembro(true, jugador.Apodo);
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
                        NumJugadores = sala.NumJugadores
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
            if (!salasAbiertas[indice].DiccionarioJugadores.TryGetValue(conexion, out jugador))
            {
                return;
            }
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.RecibirMensaje(jugador.Apodo + ": " + mensaje);
            }
        }

        public void SalirChat(int idSala)
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
            if (!salasAbiertas[indice].Jugando)
            {
                foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
                {
                    miembro.RecibirMensajeMiembro(false, jugador.Apodo);
                }
            }
            if (salasAbiertas[indice].NumJugadores == 0 && !salasAbiertas[indice].Jugando)
            {
                salasAbiertas.RemoveAt(indice);
            }
        }

        public void IniciarJuego(int idSala)
        {
            int indice = BuscarSala(idSala);
            salasAbiertas[indice].Jugando = true;
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.EntrarJuego();
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
            foreach (var miembro in salasAbiertas[indice].DiccionarioJugadores.Keys)
            {
                miembro.RecibirMensajeMiembro(false, jugador.Apodo);
            }
            if (salasAbiertas[indice].NumJugadores == 0)
            {
                salasAbiertas.RemoveAt(indice);
            }
        }

        public String ObtenerFondo(int idSala)
        {
            int indice = BuscarSala(idSala);
            return salasAbiertas[indice].UriFondoTablero;
        }

    }

}
