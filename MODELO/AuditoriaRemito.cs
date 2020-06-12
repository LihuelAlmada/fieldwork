using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class AuditoriaRemito
    {
        public int IDAuditoria { get; set; }
        public DateTime FechayHora { get; set; }
        public string Movimiento { get; set; }
        public string Username { get; set; }

       public string NroRemito { get; set; }
       // public Int32 codigo { get; set; }

        public Proveedor Proveedor { get; set; }
        public Factura OrdenDeCompra { get; set; }
        public DateTime Fecha { get; set; }
        public string Localidad { get; set; }

        public Int32 Cantidad { get; set; }

        public string CalifCantidad { get; set; }
        public string CalifTiempo { get; set; }

    }
}
