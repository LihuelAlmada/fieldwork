using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Venta
    {
        public Int32 codigo { get; set; }
        public string nroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public decimal IvaTotal { get; set; }
        
        public decimal DescuentoTotal { get; set; }
        public bool visibily { get; set; }
        public virtual List<Materiales> Materiales { get; set; }
        public virtual List<CantidadMat> CantidadesMat { get; set; }

        public Venta()
        {
            Materiales = new List<Materiales>();
            CantidadesMat = new List<CantidadMat>();
        }             
        public override string ToString()
        {
            return nroFactura.ToString();
        }

    }
}
