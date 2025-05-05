using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Barcos1._0
{
    internal class Barco
    {
        public int Cargamento { get; set; }
        public int Tripulacion { get; set; }

        public Barco(int cargamento, int tripulacion)
        {
            Cargamento = cargamento;
            Tripulacion = tripulacion;
        }

        public bool ValeLaPenaSaquear()
        {
            int cargamentoFinal = Cargamento - Tripulacion;
            return cargamentoFinal > 20;
        }
    }
}
