using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class USUARIO
    {

        public Int32 Codigo { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }
        public string EstadoContraseña { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public int Dni { get; set; }
        public string Usuario { get; set; }

        public virtual List<GRUPO> Grupos { get; set; }

        public string GruposUsuario
        {
            get
            {
                string List = "";
                foreach (GRUPO oGrupo in this.Grupos)
                {
                    List += " " + "(" + oGrupo.Nombre + ")";
                }
                return List;

            }
        }

        public override string ToString()
        {
            return Apellido+" "+Nombre+" "+ "("+Username+")";
        }



    }
}
