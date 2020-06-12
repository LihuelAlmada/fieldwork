using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Occantmat
    {
        public Int32 codigo { get; set; }
        public Factura ordercompra { get; set; }
        public string material { get; set; }
        public CantidadMat cantidadmat { get; set; }
        

    }
}
