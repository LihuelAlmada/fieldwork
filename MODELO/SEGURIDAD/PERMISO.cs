using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PERMISO
    {

        public Int32 Codigo { get; set; }
        public string Accion { get; set; }
        public string Formulario { get; set; }
        public string Descripcion { get; set; }

        public virtual List<GRUPO> Grupos { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
