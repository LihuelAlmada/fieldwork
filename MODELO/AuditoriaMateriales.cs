using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class AuditoriaMateriales
    {
        public int IDAuditoria { get; set; }
        public DateTime FechayHora { get; set; }
        public string Movimiento { get; set; }
        public string Username { get; set; }
        public string COD_MATERIAL { get; set; }
        public string DESCRIPCION_CORTA { get; set; }
        public string DESCRIPCION_LARGA { get; set; }
        public DateTime ULTIMA_MODIFICACION { get; set; }
        public double PUC { get; set; }
        public Int32 MINIMO { get; set; }
        public Int32 MAXIMO { get; set; }
        public Clase CLASE { get; set; }
        public Subclase SUBCLASE { get; set; }
        public Proveedor PROVEEDOR { get; set; }
        public double GANANCIA { get; set; }
        public string IVA { get; set; }
        public Int32 STOCK { get; set; }

    }
}
