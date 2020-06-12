using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class magiafinal
    {
        public string Fecha { get; set; }
        public Int32 cantCompra { get; set; }
        public Int32 cantVenta { get; set; }
        public Int32 diferencia { get { return cantCompra - cantVenta; } }

    }
}
