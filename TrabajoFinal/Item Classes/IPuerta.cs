using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    internal interface IPuerta<T>
    {
        bool estaAbierta {  get; set; }
        public void AbrirPuerta(T modoDeAbrir) { }
    }
}
