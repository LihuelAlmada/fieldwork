using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA.Seguridad
{
    public class AUDITORIA
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;
        private static AUDITORIA instancia;
        public static AUDITORIA obtenerInstancia()
        {
            if (instancia == null)
                instancia = new AUDITORIA();
            return instancia;
        }

        public AUDITORIA()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void AGREGAR_AUDITORIA(MODELO.SEGURIDAD.AUDITORIA oAUDITORIA)
        {

            oMODELO_SEGURIDAD.AUDITORIA.Add(oAUDITORIA);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void ELIMINAR_AUDITORIA(MODELO.SEGURIDAD.AUDITORIA oAUDITORIA)
        {
            oMODELO_SEGURIDAD.AUDITORIA.Remove(oAUDITORIA);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void MODIFICAR_AUDITORIA(MODELO.SEGURIDAD.AUDITORIA oAUDITORIA)
        {
            oMODELO_SEGURIDAD.Entry(oAUDITORIA).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

    }
}
