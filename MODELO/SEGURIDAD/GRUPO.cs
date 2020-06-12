using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class GRUPO
    {
        public GRUPO(Int32 unCodigo, string unaDescripcion)
        {
            Codigo = unCodigo;
            Nombre = unaDescripcion;
        }
        public GRUPO() { }

        public Int32 Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public virtual List<USUARIO> Usuarios { get; set; }
        public virtual List<PERMISO> Permisos { get; set; }

        public override string ToString()
        {
            return Nombre;
        }


    }
}
