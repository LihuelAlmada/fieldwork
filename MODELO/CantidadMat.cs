using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class CantidadMat
    {
        public Int32 codigo { get; set; }
        public virtual List<Factura> OrdenCompra { get; set; }

        public virtual List<Venta> OrdenVenta { get; set; }

        public Materiales Material { get; set; }
        public Int32 Cantidad_mat { get; set; }

        public Int32 cantidad_base { get; set; }

        public Int32 cantidad_base_venta { get; set; }


        //public string material { get { return Material.DESCRIPCION_CORTA; } }

        public override string ToString()
        {
            return  Cantidad_mat + "" ;
        }
      
    }
}
