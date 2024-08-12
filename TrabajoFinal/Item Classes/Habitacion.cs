using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class Habitacion
    {
        public MesitaDeNoche mesitaDeNoche;
        public PuertaCombinacion puertaHabitacion;
        public Cama cama;
        public Ventana ventana;
        public Habitacion()
        {
            puertaHabitacion = new PuertaCombinacion("Una puerta vieja, robusta. Parece que aún las termitas no le han devorado las entrañas. Tiene una cerradura de combinación.");
            mesitaDeNoche = new MesitaDeNoche(puertaHabitacion.combinacion);
            cama = new Cama();
            ventana = new Ventana();
        }

        public void InteractuarConLaCama(ref Jugador jugador)
        {
            bool interaccionJugador = true;
            int eleccionJugador;
            Console.Clear();
            while (interaccionJugador)
            {
                Console.WriteLine(cama.descripcion);
                Console.WriteLine("Acciones:");
                Console.WriteLine("La cama tiene una almohada. Introduce 1 para ver debajo de ella.");
                Console.WriteLine("Introduce 2 para ver debajo de la cama.");
                Console.WriteLine("Introduce 3 para regresar.");
                eleccionJugador = Utils.EleccionJugador();
                switch (eleccionJugador)
                {
                    case 1: cama.VerBajoAlmohada(ref jugador); break;
                    case 2: cama.VerBajoLaCama(); break;
                    case 3: interaccionJugador = false; break;
                }
            }
            Console.Clear();
        }

        public void InteractuarConLaMesita(ref Jugador jugador)
        {
            bool interaccionJugador = true;
            int eleccionJugador;
            Console.Clear();
            while (interaccionJugador)
            {
                Console.WriteLine(mesitaDeNoche.descripcion);
                Console.WriteLine("Acciones:");
                Console.WriteLine("La cama tiene un cajón. Introduce 1 para abrirlo.");
                Console.WriteLine("Introduce 2 para regresar.");
                eleccionJugador = Utils.EleccionJugador();
                if (eleccionJugador == 1)
                {
                    if (mesitaDeNoche.abrirCajonMesita(jugador))
                    {
                        jugador.JugadorObtuvoFoto(mesitaDeNoche.foto);
                    }
                   
                }
                else if (eleccionJugador == 2)
                {
                    interaccionJugador = false;
                }
                Console.Clear();
            }
        }

        public void InteractuarConLaVentana()
        {
            Console.WriteLine(ventana.descripcion);
            Console.ReadKey();
            Console.Clear();
        }

        public void InteractuarConLaPuerta(ref Jugador jugador)
        {
            int eleccionJugador;
            bool interaccionJugador = true;

            while (interaccionJugador)
            {

            }
        }
    }
}
