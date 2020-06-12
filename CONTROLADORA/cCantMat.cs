using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cCantMat
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cCantMat instancia { get; set; }
        public static cCantMat obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cCantMat();
            return instancia;
        }

        public cCantMat()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarCantMat(MODELO.CantidadMat oCantMat)
        {
            oMODELO_SEGURIDAD.CANTIDADESMAT.Add(oCantMat);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerCantMat(string nombre)
        {
            var cantmateriales = from cantmat in oMODELO_SEGURIDAD.CANTIDADESMAT.ToList()
                          where cantmat.Material.ToString().ToLower().Contains(nombre.ToLower())
                          select cantmat;
            return cantmateriales.ToList();
        }

        public void modificarCantMat(MODELO.CantidadMat oCantMat)
        {
            oMODELO_SEGURIDAD.Entry(oCantMat).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }





 


    }
}
