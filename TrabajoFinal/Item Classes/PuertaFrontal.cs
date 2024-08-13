using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class PuertaFrontal : IPuerta<bool>, IItem
    {
        public string descripcion { get; set; }
        public bool estaAbierta { get; set; }
        public PuertaFrontal()
        {
            descripcion = "Una puerta blanca, fuerte.\n" +
                "La puerta está cerrada con un candado muy grande, y las bisagras están oxidadas." +
                "Aún así, conserva su blancura\n." +
                "Hay una llave colgada a su lado.";
            estaAbierta = false;
        }

        public void AbrirPuerta(bool jugadorTieneLlave)
        {
            if (jugadorTieneLlave)
            {
                estaAbierta = true;
                Console.WriteLine("Has salido de la casa! Ahora eres libre, pero... el misterio sigue sin resolverse.");
            }
            else
            {
                Console.WriteLine("La llave no parece entrar. Tal vez no es la correcta...");
            }
        }

        public void InteraccionConPuerta(ref Jugador jugador)
        {
            bool jugadorInteractuandoConPuerta = true;
            int eleccionJugador = 0;
            while (jugadorInteractuandoConPuerta)
            {
                Console.WriteLine(descripcion);
                Console.WriteLine("Acciones:");
                Console.WriteLine("Introduce 1 para abrir la puerta.");
                Console.WriteLine("Introduce 2 para regresar al pasillo.");
                eleccionJugador = Utils.EleccionJugador();
                if(eleccionJugador == 1)
                {
                    AbrirPuerta(jugador.tieneLlaveSalida);
                    break;
                } else if (eleccionJugador == 2)
                {
                    break;
                } else
                {
                    Console.WriteLine("Introduce una opción válida.");
                }
            }
        }

    }
}
