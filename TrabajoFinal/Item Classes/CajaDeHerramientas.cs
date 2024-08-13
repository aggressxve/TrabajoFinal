using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class CajaDeHerramientas : IItem
    {
        public string descripcion { get; set; }
        public bool inspeccionado;
        public CajaDeHerramientas()
        {
            descripcion = "Una cajita de herramientas. Parece estar vacía, ya que se siente muy ligera.";
            inspeccionado = false;
        }

        public void ExaminarCajita()
        {
            if (inspeccionado == false)
            {
                Console.WriteLine("Al agitar la caja, se escuchan unos golpes de metales.");
            }
            else
            {
                Console.WriteLine("La caja no contiene nada más que las llaves.");
            }
        }

        public void AbrirCajita(ref Jugador jugador)
        {
            bool jugadorInteractuando = true;
            int eleccionJugador = 0;
            while (jugadorInteractuando)
            {
                Console.WriteLine("Dentro de la caja hay tres llaves: una roja, una azul y una verde.\nParece ser que al sacar una, las otras dos quedan selladas.");
                Console.WriteLine("Acciones:");
                Console.WriteLine("Introduce 1 para sacar la llave roja.");
                Console.WriteLine("Introduce 2 para sacar la llave azul.");
                Console.WriteLine("Introduce 3 para sacar la llave verde.");
                eleccionJugador = Utils.LeerNumero();
                switch (eleccionJugador)
                {
                    case 1:
                        Console.WriteLine("Has tomado la llave roja.");
                        break;
                    case 2:
                        Console.WriteLine("Has tomado la llave azul.");
                        break;
                    case 3:
                        Console.WriteLine("Has tomado la llave Verde.");
                        jugador.tieneLlaveSalida = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        continue;
                }
                jugador.haTomadoLlave = true;
                inspeccionado = true;
                jugadorInteractuando = false;
            }
        }
    }
}
