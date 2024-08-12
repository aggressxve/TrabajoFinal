using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            menuPrincipal.MostrarMenu();
            eleccionJugador = Utils.EleccionJugador();
            switch(eleccionJugador){
                case 1: Juego(); break;
                case 2: juegoActivo=false; break;
                default: Console.WriteLine("Por favor elige una opción válida."); break;
            }
        }



        public static void Juego()
        {
            Jugador jugador = new Jugador();

        }
    }
}
