using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Item_Classes
{
    public class Jugador
    {
        public bool tieneLlaveMesita;
        public bool tieneLlaveSalida;
        public bool haTomadoLlave;
        public bool tieneFoto;
        public Foto foto;

        public Jugador() 
        {
            tieneLlaveMesita = false;
            tieneLlaveSalida = false;
            haTomadoLlave = false;
            tieneFoto = false;
        }

        public void JugadorObtuvoFoto(Foto fotoMnt)
        {
            foto = fotoMnt;
        }

        public void MostrarInformacionFoto()
        {
            foto.Examinar();
        }

        public void JugadorTomoLlave()
        {
            haTomadoLlave = true;
        }
    }
}
