using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cOccantmatVenta
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cOccantmatVenta instancia { get; set; }
        public static cOccantmatVenta obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cOccantmatVenta();
            return instancia;
        }

        public cOccantmatVenta()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarOccantmatVenta(MODELO.oCanmatVenta oOccantmatVenta)
        {
            oMODELO_SEGURIDAD.OccantmatSVenta.Add(oOccantmatVenta);
            oMODELO_SEGURIDAD.SaveChanges();
        }
        public void modificarOcanmat(MODELO.oCanmatVenta oOccantmatVenta)
        {
            oMODELO_SEGURIDAD.Entry(oOccantmatVenta).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }


        public System.Collections.IEnumerable obtenerOccantmat(MODELO.Factura oOrden) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
                         where (clase.ordercompra == oOrden) && oOrden.visibily != false
                         select clase;

            return clases.ToList();
        }

       


        public List<MODELO.Occantmat> obtenerOccantmat1(MODELO.Factura oOrden) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
                         where clase.ordercompra == oOrden
                         select clase;

            return clases.ToList();
        }

        /*public MODELO.Occantmat obtenerOccantmatUnico(string material) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
                         where clase.material == material
                         select clase;

            return clases;
        }*/



        public List<MODELO.Materiales> obtenerNuevax2(MODELO.Factura oOrden) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
                         where clase.ordercompra == oOrden
                         select clase.cantidadmat.Material;

            return clases.ToList();
        }

        public List<Int32> obtenerCantidadxD(MODELO.Factura oOrden) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
                         where clase.ordercompra == oOrden
                         select clase.cantidadmat.Cantidad_mat;

            return clases.ToList();
        }

        //public List<> obtenerCantidadxD(MODELO.OrdenCompra oOrden) //Obtiene por nombre
        //{
        //    var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
        //                 where clase.ordercompra == oOrden
        //                 select clase.cantidadmat.Cantidad_mat;

        //    return clases.ToList();
        //}
        public System.Collections.IEnumerable obtenerOccantmatNew(string Material) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.OccantmatS.Include("CantidadMat").ToList()
                         where clase.cantidadmat.Material.DESCRIPCION_CORTA == Material 
                         select clase;

            return clases.ToList();
        }

        public List<MODELO.oCanmatVenta> SuperFiltroVenta(DateTime fechastart, DateTime fechafinish, string MATERIAL)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.OccantmatSVenta.Include("venta").Include("cantidadmat").ToList()
                          where (orden.venta.Fecha >= fechastart && orden.venta.Fecha <= fechafinish) && (MATERIAL == orden.material) && (orden.cantidadmat.cantidad_base_venta != 0)
                          //select new { FECHA = orden.venta.Fecha.ToString("yy/MM"), CANTIDAD_VENTA = orden.cantidadmat.cantidad_base_venta };
                          select orden;


            return ordenes.ToList();
        }



    }
}
