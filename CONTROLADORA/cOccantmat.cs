using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cOccantmat
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cOccantmat instancia { get; set; }
        public static cOccantmat obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cOccantmat();
            return instancia;
        }

        public cOccantmat()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarOccantmat(MODELO.Occantmat oOccantmat)
        {
            oMODELO_SEGURIDAD.OccantmatS.Add(oOccantmat);
            oMODELO_SEGURIDAD.SaveChanges();
        }
        public void modificarOcanmat(MODELO.Occantmat oOccantmat)
        {
            oMODELO_SEGURIDAD.Entry(oOccantmat).State = System.Data.Entity.EntityState.Modified;
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

        //public System.Collections.IEnumerable listar_orden_compra(DateTime fechastart, DateTime fechafinish, string oMATERIAL)
        //{
        //    var materiales = from material in oMODELO_SEGURIDAD.OccantmatS.Include("OrdenCompra").ToList()
        //                     where (material.ordercompra.Fecha >= fechastart && material.ordercompra.Fecha <= fechafinish) && (oMATERIAL == material.material)
        //                     select new { FECHAA = material.ordercompra.Fecha, CANTIDAD = material.cantidadmat.Cantidad_mat};
        //    return materiales.ToList();
        //}



        public List<MODELO.Occantmat> SuperFiltro(DateTime fechastart, DateTime fechafinish, string MATERIAL)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.OccantmatS.Include("ordercompra").Include("cantidadmat").ToList()
                          where (orden.ordercompra.Fecha >= fechastart && orden.ordercompra.Fecha <= fechafinish) && (MATERIAL == orden.material) && (orden.cantidadmat.cantidad_base != 0)
                          //select new { FECHA = orden.ordercompra.Fecha.ToString("yy/MM"), CANTIDAD_COMPRA = orden.cantidadmat.cantidad_base };
                          select orden;


            return ordenes.ToList();
        }

    }
}
