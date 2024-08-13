using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinal.Item_Classes;

namespace TrabajoFinal.Escenarios
{
    public class Pasillo
    {
        public string descripcion { get; set; }
        public MesaDeTrabajo mesaDeTrabajo;
        public PuertaFrontal puertaFrontal;
        public bool jugadorEnPasillo {  get; set; }
        public Pasillo()
        {
            descripcion = "Un pasillo solitario.\nEn la pared cuelga un retrato cuyo rostro ha sido quemado, con un manchado fondo verde… Verlo fijamente te da la sensación de que te está observando, a pesar de ya no poseer rostro alguno.";
            mesaDeTrabajo = new MesaDeTrabajo();
            puertaFrontal = new PuertaFrontal();
            jugadorEnPasillo = true;
        }

        public void ElegirDireccion(ref Jugador jugador)
        {
            int eleccionJugador;
            while (jugadorEnPasillo)
            {
                Console.WriteLine(descripcion);
                Console.WriteLine("Acciones:");
                Console.WriteLine("Introduce 1 para ir a la izquierda.");
                Console.WriteLine("Introduce 2 para ir a la derecha.");
                eleccionJugador = Utils.EleccionJugador();
                if (eleccionJugador == 1)
                {
                    puertaFrontal.InteraccionConPuerta(ref jugador);
                    if (puertaFrontal.estaAbierta == true)
                    {
                        
                        jugadorEnPasillo = false;
                    }
                }
                else if (eleccionJugador == 2)
                {
                    mesaDeTrabajo.InteraccionConCaja(ref jugador);
                }
            }
        }
    }
}
