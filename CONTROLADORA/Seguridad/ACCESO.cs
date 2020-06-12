using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA.Seguridad
{
    public class ACCESO
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;
        private static ACCESO instancia;
        public static ACCESO obtenerInstancia()
        {
            if (instancia == null)
                instancia = new ACCESO();
            return instancia;
        }

       public ACCESO()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void AGREGAR_ACCESO(MODELO.SEGURIDAD.ACCESO oACCESO)
        {

            oMODELO_SEGURIDAD.ACCESO.Add(oACCESO);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void ELIMINAR_ACCESO(MODELO.SEGURIDAD.ACCESO oACCESO)
        {
            oMODELO_SEGURIDAD.ACCESO.Remove(oACCESO);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void MODIFICAR_ACCESO(MODELO.SEGURIDAD.ACCESO oACCESO)
        {
            oMODELO_SEGURIDAD.Entry(oACCESO).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }


    }
}
