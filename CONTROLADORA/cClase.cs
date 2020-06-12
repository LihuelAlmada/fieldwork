using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cClase
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cClase instancia { get; set; }
        public static cClase obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cClase();
            return instancia;
        }

        public cClase()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarClase(MODELO.Clase oClase)
        {
            oMODELO_SEGURIDAD.CLASES.Add(oClase);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void eliminarClase(MODELO.Clase oClase)
        {
            oMODELO_SEGURIDAD.CLASES.Remove(oClase);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarClase(MODELO.Clase oClase)
        {
            oMODELO_SEGURIDAD.Entry(oClase).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerClaseNombre(string nombre) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.CLASES.ToList()
                              where clase.NOMBRE.ToLower().Contains(nombre.ToLower())
                              select clase;

            return clases.ToList();
        }
        public System.Collections.IEnumerable obtenerClaseNombre() //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.CLASES.ToList()
                              select clase;

            return clases.ToList();
        }
        
    }
}
