using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cAuditoria
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;
        private static cAuditoria instancia;
        public static cAuditoria obtenerInstancia()
        {
            if (instancia == null)
                instancia = new cAuditoria();
            return instancia;
        }

        public cAuditoria()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void AGREGAR_AUDITORIA(MODELO.AuditoriaMateriales oAUDITORIA)
        {
            oMODELO_SEGURIDAD.AUDITORIAMATERIALES.Add(oAUDITORIA);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void ELIMINAR_AUDITORIA(MODELO.AuditoriaMateriales oAUDITORIA)
        {
            oMODELO_SEGURIDAD.AUDITORIAMATERIALES.Remove(oAUDITORIA);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void MODIFICAR_AUDITORIA(MODELO.AuditoriaMateriales oAUDITORIA)
        {
            oMODELO_SEGURIDAD.Entry(oAUDITORIA).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void AGREGAR_AUDITORIA(MODELO.AuditoriaOC oAUDITORIA)
        {
            oMODELO_SEGURIDAD.AuditoriaOC.Add(oAUDITORIA);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void ELIMINAR_AUDITORIA(MODELO.AuditoriaOC oAUDITORIA)
        {
            oMODELO_SEGURIDAD.AuditoriaOC.Remove(oAUDITORIA);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void AGREGAR_AUDITORIA(MODELO.AuditoriaVenta oAUDITORIA)
        {
            oMODELO_SEGURIDAD.AUDITORIAVENTAS.Add(oAUDITORIA);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void AGREGAR_AUDITORIAREMITO(MODELO.AuditoriaRemito oAUDITORIA)
        {
            oMODELO_SEGURIDAD.AUDITORIAREMITO.Add(oAUDITORIA);
            oMODELO_SEGURIDAD.SaveChanges();
        }



    }
}
