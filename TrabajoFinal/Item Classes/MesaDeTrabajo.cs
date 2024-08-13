using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class MesaDeTrabajo : IItem
    {
        public string descripcion { get; set; }
        public CajaDeHerramientas cajaDeHerramientas;

        public MesaDeTrabajo()
        {
            descripcion = "Una mesa de trabajo robusta.";
            cajaDeHerramientas = new CajaDeHerramientas();
        }

        public void Examinar()
        {
            Console.WriteLine("Una mesa de trabajo cualquiera. Sobre ella hay una caja de herramientas.");
        }

        public void TomarCaja(ref Jugador jugador)
        {
            bool jugadorInteractuando = true;
            int eleccionJugador = 0;
            while (jugadorInteractuando)
            {
                Console.WriteLine(cajaDeHerramientas.descripcion);
                Console.WriteLine("Acciones: ");
                Console.WriteLine("Introduce 1 para examinar la cajita.");
                Console.WriteLine("Introduce 2 para abrir la cajita.");
                Console.WriteLine("Introduce 3 para regresar.");
                eleccionJugador = Utils.EleccionJugador();
                switch (eleccionJugador)
                {
                    case 1: cajaDeHerramientas.ExaminarCajita(); break;
                    case 2: cajaDeHerramientas.AbrirCajita(ref jugador); break;
                    case 3: jugadorInteractuando = false; break;
                    case 4:
                        Console.WriteLine("Ingresa una opcion válida.");
                        continue;
                }
            }
        }

        public void InteraccionConCaja(ref Jugador jugador)
        {
            int eleccionJugador;
            bool jugadorEnPasillo = true;
            while (jugadorEnPasillo)
            {
                Console.WriteLine(descripcion);
                Console.WriteLine("Acciones:");
                Console.WriteLine("Introduce 1 para examinar la caja.");
                Console.WriteLine("Introduce 2 para abrir la caja.");
                Console.WriteLine("Introduce 3 para regresar.");
                eleccionJugador = Utils.EleccionJugador();
                if (eleccionJugador == 1)
                {
                    cajaDeHerramientas.ExaminarCajita();
                }
                else if (eleccionJugador == 2)
                {
                    cajaDeHerramientas.AbrirCajita(ref jugador);
                }
                else
                {
                    jugadorEnPasillo = false;
                }
            }

        }
    }
}