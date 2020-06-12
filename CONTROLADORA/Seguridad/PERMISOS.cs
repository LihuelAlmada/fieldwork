using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public  class PERMISOS
    {

        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static PERMISOS INSTANCIA { get; set; }
        public static PERMISOS Singleton()
        {
            if (INSTANCIA == null) INSTANCIA = new CONTROLADORA.PERMISOS();
            return INSTANCIA;
        }

        public PERMISOS()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void AGREGAR_PERMISO(MODELO.PERMISO oPERMISO)
        {
            oMODELO_SEGURIDAD.PERMISOS.Add(oPERMISO);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void ELIMINAR_PERMISO(MODELO.PERMISO oPERMISO)
        {
            oMODELO_SEGURIDAD.PERMISOS.Remove(oPERMISO);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void MODIFICAR_PERMISO(MODELO.PERMISO oPERMISO)
        {
            oMODELO_SEGURIDAD.Entry(oPERMISO).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable OBTENER_PERMISOS(string DESCRIPCION)
        {
            var permisos = from PERMISO in oMODELO_SEGURIDAD.PERMISOS.ToList()
                           where PERMISO.Descripcion.ToLower().Contains(DESCRIPCION.ToLower())
                           select PERMISO;

            return permisos.ToList();
        }

        public System.Collections.IEnumerable OBTENER_PERMISOS()
        {
            var permisos = from PERMISO in oMODELO_SEGURIDAD.PERMISOS.ToList()                 
                           select PERMISO;

            return permisos.ToList();
        }

       
    }
}
