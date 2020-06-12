using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Factura
    {
        public Int32 codigo { get; set; }
        public string NroOrden { get; set; }
        public Proveedor Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fecha_Recepcion { get; set; }
        public decimal Importe { get; set; }
        public decimal IvaTotal { get; set; }
        public string Localidad { get; set; }
        public decimal DescuentoTotal { get; set; }
        public bool visibily { get; set;  }
        public virtual List<Materiales> Materiales { get; set; }
        public virtual List<CantidadMat> CantidadesMat { get; set; }

        public Factura()
        {
            Materiales = new List<Materiales>();
            CantidadesMat = new List<CantidadMat>();
        }
        
        public int Cantidad { get; set; }
        public float Puc { get; set; }
        public Materiales Iva { get; set; }
        public Materiales UnidadMedida { get; set; }
        public float Descuento { get; set; }

        public override string ToString()
        {
            return NroOrden.ToString();
        }
    }
}
