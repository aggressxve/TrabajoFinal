using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Utils
    {
        public static int EleccionJugador()
        {
            int eleccionJugador = 0;
            bool eleccionValida = false;
            while (eleccionValida == false)
            {
                Console.WriteLine("¿Qué quieres hacer?: ");
                try
                {
                    eleccionJugador = Int32.Parse(Console.ReadLine());
                    eleccionValida = true;
                }
                catch (IOException)
                {
                    Console.WriteLine("Por favor introduce una opción válida.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor introduce una opción válida.");
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Por favor introduce una opción válida.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Por favor introduce una opción válida.");
                }
            }
            Console.Clear();
            return eleccionJugador;
        }
    }
}
