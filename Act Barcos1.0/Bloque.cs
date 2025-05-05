using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Barcos1._0
{
    internal class Bloque
    {
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Bloque(int largo, int ancho, int alto)
        {
            Largo = largo;
            Ancho = ancho;
            Alto = alto;
        }

        public int ObtenerLargo()
        {
            return Largo;
        }

        public int ObtenerAncho()
        {
            return Ancho;
        }

        public int ObtenerAlto()
        {
            return Alto;
        }

        public int ObtenerVolumen()
        {
            return Largo * Ancho * Alto;
        }

        public int ObtenerAreaSuperficie()
        {
            return 2 * (Largo * Ancho + Largo * Alto + Ancho * Alto);
        }
    }
}
