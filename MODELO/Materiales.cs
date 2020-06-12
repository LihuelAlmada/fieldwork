using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Materiales
    {
        public Int32 CODIGO { get; set; }
        public string COD_MATERIAL { get; set; }
        public string DESCRIPCION_CORTA { get; set; }
        public string PROVEEDOR { get; set; }
        public decimal PP { get { return MAXIMO - STOCK; } }
        public Int32 STOCK { get; set; }


        public string DESCRIPCION_LARGA { get; set; }
        public DateTime ULTIMA_MODIFICACION { get; set; }

        public virtual List<Factura> OrdenesCompras { get; set; }

        public virtual List<Venta> OrdenesVentas { get; set; }
        public double PUC { get; set; }
        public Int32 MINIMO { get; set; }
        public Int32 MAXIMO { get; set; }
        public string CLASE { get; set; }
        
        public string SUBCLASE { get; set; }
        public int GANANCIA { get; set; }
        public double IVA { get; set; }
        
        public string MEDIDA { get; set; }

        //public virtual List<Clase> CLASE { get; set; }
        //public virtual List<Subclase> SUBCLASE { get; set; }

        public override string ToString()
        {
            return DESCRIPCION_CORTA + "(" + COD_MATERIAL + ")";
        }
    }
}
