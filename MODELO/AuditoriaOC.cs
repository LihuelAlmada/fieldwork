using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class AuditoriaOC
    {
        public int IDAuditoria { get; set; }
        public DateTime FechayHora { get; set; }
        public string Movimiento { get; set; }
        public string Username { get; set; }


        public string NroOrden { get; set; }
        public Proveedor Proveedor { get; set; }
        //public DateTime Fecha { get; set; }
        //public DateTime Fecha_Recepcion { get; set; }
       // public decimal Importe { get; set; }
    }
}
