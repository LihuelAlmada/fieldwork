using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cSubclase
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cSubclase instancia { get; set; }
        public static cSubclase obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cSubclase();
            return instancia;
        }

        public cSubclase()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarSubClase(MODELO.Subclase oSubClase)
        {
            oMODELO_SEGURIDAD.SUBCLASES.Add(oSubClase);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void eliminarSubClase(MODELO.Subclase oSubClase)
        {
            oMODELO_SEGURIDAD.SUBCLASES.Remove(oSubClase);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarSubClase(MODELO.Subclase oSubClase)
        {
            oMODELO_SEGURIDAD.Entry(oSubClase).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerSubClaseNombre(string nombre) //Obtiene por nombre
        {
            var Subclases = from Subclase in oMODELO_SEGURIDAD.SUBCLASES.ToList()
                         where Subclase.NOMBRE.ToLower().Contains(nombre.ToLower())
                         select Subclase;

            return Subclases.ToList();
        }
        public System.Collections.IEnumerable obtenerSubClaseNombre() //Obtiene por nombre
        {
            var Subclases = from clase in oMODELO_SEGURIDAD.SUBCLASES.ToList()
                         select clase;

            return Subclases.ToList();
        }

    }
}
