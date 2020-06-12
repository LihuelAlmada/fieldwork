using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cRemito
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cRemito instancia { get; set; }
        public static cRemito obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cRemito();
            return instancia;
        }

        public cRemito()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarRemito(MODELO.Remito oRemito)
        {
            oMODELO_SEGURIDAD.REMITOS.Add(oRemito);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void eliminarRemito(MODELO.Remito oRemito)
        {
            oMODELO_SEGURIDAD.REMITOS.Remove(oRemito);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarRemito(MODELO.Remito oRemito)
        {
            oMODELO_SEGURIDAD.Entry(oRemito).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerRemito(string nombre)
        {
            var remitos = from remito in oMODELO_SEGURIDAD.REMITOS.Include("Proveedor").Include("OrdenDeCompra").ToList()
                          where remito.NroRemito.ToLower().Contains(nombre.ToLower())
                          select remito;
            return remitos.ToList();
        }

        
    }
}
