using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinal.Item_Classes;

namespace TrabajoFinal.Escenarios
{
    public class Habitacion
    {
        public MesitaDeNoche mesitaDeNoche;
        public PuertaCombinacion puertaHabitacion;
        public Cama cama;
        public Ventana ventana;
        public bool jugadorEnHabitacion;
        public Habitacion()
        {
            puertaHabitacion = new PuertaCombinacion("Una puerta vieja, robusta. Parece que aún las termitas no le han devorado las entrañas. Tiene una cerradura de combinación.");
            mesitaDeNoche = new MesitaDeNoche(puertaHabitacion.combinacion);
            cama = new Cama();
            ventana = new Ventana();
            jugadorEnHabitacion = true;
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
                Console.WriteLine("La mesita tiene un cajón. Introduce 1 para abrirlo.");
                Console.WriteLine("Introduce 2 para regresar.");
                eleccionJugador = Utils.EleccionJugador();

                if (eleccionJugador == 1)
                {
                    if (mesitaDeNoche.abrirCajonMesita(jugador))
                    {
                        jugador.JugadorObtuvoFoto(mesitaDeNoche.foto);
                        mesitaDeNoche.VerFoto();
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (eleccionJugador == 2)
                {
                    interaccionJugador = false;

                }
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
            int[] combinacionJugador = new int[3];
            bool pistas = false;

            while (interaccionJugador)
            {
                Console.WriteLine(puertaHabitacion.descripcion);
                Console.WriteLine("Acciones:");
                Console.WriteLine("Para intentar abrir la cerradura, introduce 1.");
                Console.WriteLine("Para regresar, introduce 2.");
                eleccionJugador = Utils.EleccionJugador();
                if (eleccionJugador == 1)
                {
                    Console.WriteLine("Introduce la combinación, un número a la vez.");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Número {i}: ");
                        combinacionJugador[i] = Utils.LeerNumero();
                    }

                    puertaHabitacion.AbrirPuerta(combinacionJugador);
                    if (pistas)
                    {
                        Console.WriteLine("Tal vez la respuesta se encuentre en la foto.");
                    }
                    if (puertaHabitacion.estaAbierta)
                    {
                        Console.WriteLine("La puerta se abre. Sales al pasillo.");
                        jugadorEnHabitacion = false;
                        interaccionJugador = false;
                    }
                    else
                    {
                        pistas = true;
                    }
                }
                else if (eleccionJugador == 2)
                {
                    interaccionJugador = false;
                    Console.Clear();
                }
            }
        }
    }
}
