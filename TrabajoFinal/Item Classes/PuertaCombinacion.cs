using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinal.Item_Classes;

namespace TrabajoFinal
{
    public class PuertaCombinacion : IPuerta<int[]>, IItem
    {
        public string descripcion {  get; }
        public int[] combinacion { get; }
        public bool estaAbierta { get; set; }
        public PuertaCombinacion(string descripcion)
        {
            this.descripcion = descripcion;
            combinacion = GenerarCombinacion();
            estaAbierta = false;
        }

        public int[] GenerarCombinacion()
        {
            Random rnd = new Random();
            int[] generadorCombinacion = new int[3];
            generadorCombinacion[0] = rnd.Next(-30, 30);

            for (int i = 1; i < generadorCombinacion.Length; i++)
            {
                if (generadorCombinacion[i - 1] < 0)
                {
                    generadorCombinacion[i] = rnd.Next(0, 30);
                }
                else if (generadorCombinacion[i - 1] > 0)
                {
                    generadorCombinacion[i] = rnd.Next(-30, 0);
                }
                else
                {
                    generadorCombinacion[i] = rnd.Next(-30, 30);
                }
            }

            return generadorCombinacion;
        }

        public void AbrirPuerta(int[] combinacionJugador)
        {
            bool combinacionCorrecta = Enumerable.SequenceEqual(combinacionJugador, combinacion);
            estaAbierta = combinacionCorrecta == true ? true : false;
            if (estaAbierta)
            {
                Console.WriteLine("Has descubierto la combinación!");
            }
            else
            {
                Console.WriteLine("La combinacion no es la correcta!");
            }
        }

    }
}
