using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Cliente
    {
        public Int32 codigo { get; set; }
        public string razonSocial { get; set; } //Es para empresas, sino hay poner ""
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public string tipoDocumento {get; set;}
        public Int32 telefono { get; set; }
        public string mail { get; set; }
        public string direccion { get; set; }
        public Localidad Localidad { get; set;}
        public string tipo { get; set; } //Podria ser proveedor favorito u otro
        public string estado { get; set; } //Podria ser bool y tocarlo en el form

        public override string ToString()
        {
            return razonSocial + "(" + nombre + apellido + ")";
        }
    }
}
