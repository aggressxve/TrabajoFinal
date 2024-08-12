using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class Ventana : IItem
    {
        public string descripcion { get; set; }
        public Ventana()
        {
            descripcion = "Una ventana sucia, parece que está cerrada. No se mueve al tratar de abrirla con fuerza, y el vidrio parece ser muy grueso.";
        }
    }
}
