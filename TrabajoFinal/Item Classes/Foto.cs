using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class Foto : IItem
    {
        public string descripcion { get; }
        int[] combinacion;

        public Foto(int[] combinacion)
        {
            this.descripcion = "Una foto de una montaña, con un lago en la base. \nLa nieve parece caer y derretirse en el lago, mientras que en la montaña la nieve se acumula.";
            this.combinacion = combinacion;
        }

        public void Examinar()
        {
            Console.WriteLine($"Al verla por detrás, la foto dice:\nLos inviernos ahora son muy fríos. Ojalá nunca te hubieras marchado.\n{combinacion[0]} / {combinacion[1]} / {combinacion[2]}");
        }
    }
}
