using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Clase
    {
        public Int32 CODIGO { get; set; }
        public string NOMBRE { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }
        public Clase()
        {
        }
        public Clase(Int32 codigo, string nombre)
        {
            CODIGO = codigo;
            NOMBRE = nombre;
        }



    }
}
