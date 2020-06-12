using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
        public class cRemitoUpdated
        {
            DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

            private static cRemitoUpdated instancia { get; set; }
            public static cRemitoUpdated obtener_instancia()
            {
                if (instancia == null) instancia = new CONTROLADORA.cRemitoUpdated();
                return instancia;
            }

            public cRemitoUpdated()
            {
                oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
            }

            public void agregarRemitoUpdated(MODELO.RemitoUpdated oRemitoUpdated)
            {
                oMODELO_SEGURIDAD.RemitoUpdated.Add(oRemitoUpdated);
                oMODELO_SEGURIDAD.SaveChanges();
            }



        public System.Collections.IEnumerable obtenerPorRemito(string remito) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.RemitoUpdated.ToList()
                         where clase.remito == remito
                         select clase;

            return clases.ToList();
        }

        /*public List<MODELO.Materiales> obtenerNuevax2(MODELO.OrdenCompra oOrden) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
                         where clase.ordercompra == oOrden
                         select clase.cantidadmat.Material;

            return clases.ToList();
        }*/

        /*public List<Int32> obtenerCantidadxD(MODELO.OrdenCompra oOrden) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
                         where clase.ordercompra == oOrden
                         select clase.cantidadmat.Cantidad_mat;

            return clases.ToList();
        }*/



    }

}

