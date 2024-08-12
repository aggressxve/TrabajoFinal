using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class MesitaDeNoche : IItem
    {
        public string descripcion { get; }
        public Foto foto { get; }
        public bool estaAbierto { get; set; }

        public MesitaDeNoche(int[] combinacion)
        {
            descripcion = "Es una mesita de noche algo veja y cubierta de polvo.\n" +
                "Curiosamente, tiene un florero con agua limpia, con una flor blanca de pétalos cortos.\n" +
                "También tiene un pequeño cajón.";
            foto = new Foto(combinacion);
            estaAbierto = false;
        }

        public void VerFoto()
        {
            Console.WriteLine(foto.descripcion);
            foto.Examinar();
        }
        public bool abrirCajonMesita(Jugador jugador)
        {
            if (jugador.tieneLlaveMesita)
            {
                Console.WriteLine("Usaste la llave de la cama.\nHas abierto el cajón de la mesita!\n");
                estaAbierto = true;
            }
            else
            {
                Console.WriteLine("Parece que está cerrado con llave...\n");
            }
            return estaAbierto;
        }
    }
}