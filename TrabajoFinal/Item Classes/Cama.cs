using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class Cama : IItem
    {
        public string descripcion { get; }

        public Cama()
        {
            descripcion = "La cama sigue hecha a pesar de que he dormido ahí...";
        }

        public void VerBajoAlmohada(ref Jugador jugador)
        {
            if (jugador.tieneLlaveMesita)
            {
                Console.WriteLine("No hay nada más debajo de la almohada.");
            } else
            {
            Console.WriteLine("Has encontrado una llave! Debe ser de alguna puerta cercana.");
            jugador.tieneLlaveMesita = true;
            }
        }

        public void VerBajoLaCama()
        {
            Console.WriteLine("Un ratón. Parece estar mordisqueando algo blanco, parecido a un diente.");
        }
    }
}
