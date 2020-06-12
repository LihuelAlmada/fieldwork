using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cOrdenVenta
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;
        
        private static cOrdenVenta instancia { get; set; }
        public static cOrdenVenta obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cOrdenVenta();
            return instancia;
        }

        public cOrdenVenta()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarOrdenVenta(MODELO.Venta oVenta)
        {
            oMODELO_SEGURIDAD.ORDENESDEVENTAS.Add(oVenta);
            oMODELO_SEGURIDAD.SaveChanges();
        }




        


        public void eliminarOrdenVenta(MODELO.Venta oVenta)
        {
            oMODELO_SEGURIDAD.ORDENESDEVENTAS.Remove(oVenta);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarOrdenVenta(MODELO.Venta oVenta)
        {
            oMODELO_SEGURIDAD.Entry(oVenta).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerOrdenVenta(string nombre) 
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDEVENTAS.Include("Cliente").ToList()
                              where (orden.nroFactura.ToLower().Contains(nombre.ToLower()))
                              select orden;

            return ordenes.ToList();
        }

        public System.Collections.IEnumerable obtenerOrdenVenta2(string nombre)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDEVENTAS.Include("Proveedor").ToList()
                          where (orden.nroFactura.ToLower().Contains(nombre.ToLower())) && orden.visibily != false
                          select orden;

            return ordenes.ToList();
        }


        public System.Collections.IEnumerable obtenerPorVenta(string factura) //Obtiene por nombre
        {
            var clases = from clase in oMODELO_SEGURIDAD.ORDENESDEVENTAS.ToList()
                         where clase.nroFactura == factura
                         select clase;

            return clases.ToList();
        }

        







        /*
            public System.Collections.IEnumerable obtenerMaterialProveedor(string oProveedor) //Obtiene por nombre
        {
            var materiales = from material in oMODELO_SEGURIDAD.MATERIALES.ToList()
                             where material.PROVEEDOR == oProveedor

                             select material;

            return materiales.ToList();
        }
         */


        //public System.Collections.IEnumerable obtenerLocalidadNombre() //Obtiene por nombre
        //{
        //    var localidades = from localidad in oMODELO_SEGURIDAD.LOCALIDADES.ToList()
        //                      select localidad;

        //    return localidades.ToList();
        //}
        //public System.Collections.IEnumerable obtenerLocalidadCodigoPostal(Int32 codigoPostal) //Obtiene por codigo postal
        //{
        //    var localidades = from localidad in oMODELO_SEGURIDAD.LOCALIDADES.ToList()
        //                      where localidad.codigoPostal == codigoPostal
        //                      select localidad;

        //    return localidades.ToList();
        //}
    }
}
