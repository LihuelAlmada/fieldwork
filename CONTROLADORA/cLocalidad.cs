using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cLocalidad
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cLocalidad instancia { get; set; }
        public static cLocalidad obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cLocalidad();
            return instancia;
        }

        public cLocalidad()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarLocalidad(MODELO.Localidad oLocalidad)
        {
            oMODELO_SEGURIDAD.LOCALIDADES.Add(oLocalidad);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void eliminarLocalidad(MODELO.Localidad oLocalidad)
        {
            oMODELO_SEGURIDAD.LOCALIDADES.Remove(oLocalidad);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarLocalidad(MODELO.Localidad oLocalidad)
        {
            oMODELO_SEGURIDAD.Entry(oLocalidad).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerLocalidadNombre(string nombre) //Obtiene por nombre
        {
            var localidades = from localidad in oMODELO_SEGURIDAD.LOCALIDADES.ToList()
                              where localidad.nombre.ToLower().Contains(nombre.ToLower())
                              select localidad;

            return localidades.ToList();
        }
        public System.Collections.IEnumerable obtenerLocalidadNombre( ) //Obtiene por nombre
        {
            var localidades = from localidad in oMODELO_SEGURIDAD.LOCALIDADES.ToList()                       
                              select localidad;

            return localidades.ToList();
        }
        public System.Collections.IEnumerable obtenerLocalidadCodigoPostal(Int32 codigoPostal) //Obtiene por codigo postal
        {
            var localidades = from localidad in oMODELO_SEGURIDAD.LOCALIDADES.ToList()
                              where localidad.codigoPostal == codigoPostal
                              select localidad;

            return localidades.ToList();
        }
    }
}
