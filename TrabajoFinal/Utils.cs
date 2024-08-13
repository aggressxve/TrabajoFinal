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
                eleccionJugador = LeerNumero();
                eleccionValida = true;
            }
            Console.Clear();
            return eleccionJugador;
        }

        public static int LeerNumero()
        {
            int numero = 0;
            bool eleccionValida = false;
            while (eleccionValida == false)
            {
                try
                {
                    numero = Int32.Parse(Console.ReadLine());
                    eleccionValida = true;
                }
                catch (IOException)
                {
                    MensajeError();
                }
                catch (FormatException)
                {
                    MensajeError();
                }
                catch (OutOfMemoryException)
                {
                    MensajeError();
                }
                catch (ArgumentException)
                {
                    MensajeError();
                }
                catch (OverflowException)
                {
                    MensajeError();
                }
            }
            Console.Clear();
            return numero;
        }

        public static void MensajeError()
        {
            Console.WriteLine("Por favor introduce una opción válida.");
            Console.ReadKey();
        }
    }
}