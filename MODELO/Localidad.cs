using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Localidad
    {
        public Int32 codigo { get; set; }
        public string nombre { get; set; }
        public string provincia { get; set; }
        public Int32 codigoPostal { get; set; }


        //constructor de localidades
        public Localidad(Int32 Codigo, string Nombre)
        {
            codigo = Codigo;
            nombre = Nombre;
        }



        public Localidad()
        {
        }
       
        public override string ToString()
        {
            return nombre;
        }
    }
}
