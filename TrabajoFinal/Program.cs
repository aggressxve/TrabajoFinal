using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinal.Escenarios;
using TrabajoFinal.Item_Classes;

namespace TrabajoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuPrincipal = new Menu();
            int eleccionJugador;
            bool juegoActivo = true;
            while (juegoActivo)
            {
                menuPrincipal.MostrarMenu();
                eleccionJugador = Utils.EleccionJugador();
                switch (eleccionJugador)
                {
                    case 1: Juego(); break;
                    case 2: juegoActivo = false; break;
                    default: Console.WriteLine("Por favor elige una opción válida."); break;
                }
            }
        }



        public static void Juego()
        {
            /* Hay que crear un metodo para manejar el flujo de la habitacion */
            Jugador jugador = new Jugador();
            int eleccionDelJugador;
            Habitacion habitacion = new Habitacion();
            Pasillo pasillo = new Pasillo();
            Console.WriteLine("Despiertas en una habitación extraña, todo alrededor te parece desconocido.");
            while (habitacion.jugadorEnHabitacion)
            {
                Console.WriteLine("En la habitación hay una cama, una mesita y una puerta.");
                Console.WriteLine("Introduce 1 para ver la cama.");
                Console.WriteLine("Introduce 2 para ver la mesita.");
                Console.WriteLine("Introduce 3 para ver la puerta.");
                eleccionDelJugador = Utils.EleccionJugador();
                switch (eleccionDelJugador)
                {
                    case 1: habitacion.InteractuarConLaCama(ref jugador); break;
                    case 2: habitacion.InteractuarConLaMesita(ref jugador); break;
                    case 3: habitacion.InteractuarConLaPuerta(ref jugador); break;
                }
            }
            while (pasillo.jugadorEnPasillo)
            {
                pasillo.ElegirDireccion(ref jugador);
            }
            Console.WriteLine("Felicidades! Has ganado.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
