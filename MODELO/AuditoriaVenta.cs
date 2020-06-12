using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class AuditoriaVenta
    {
        public int IDAuditoria { get; set; }
        public DateTime FechayHora { get; set; }
        public string Movimiento { get; set; }
        public string Username { get; set; }


        public Int32 codigo { get; set; }
        public string nroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public decimal IvaTotal { get; set; }

        public decimal DescuentoTotal { get; set; }

    }
}
