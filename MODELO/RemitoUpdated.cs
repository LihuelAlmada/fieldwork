using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class RemitoUpdated
    {
        public Int32 codigo { get; set; }

        public Factura nroOrden { get; set; }
        public string remito { get; set; }
        public String material { get; set; }
        public Int32 Cantidad_Ingresada { get; set; }

        



        //public Occantmat cantidadMat { get; set; }



        /*  public Int32 codigo { get; set; }
        public virtual List<OrdenCompra> OrdenCompra { get; set; }
        public Materiales Material { get; set; }
        public Int32 Cantidad_mat { get; set; }
        //public string material { get { return Material.DESCRIPCION_CORTA; } }

        public override string ToString()
        {
            return  Cantidad_mat + "" ;
        }*/

    }
}
