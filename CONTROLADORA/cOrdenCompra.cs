using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cOrdenCompra
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;
        
        private static cOrdenCompra instancia { get; set; }
        public static cOrdenCompra obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cOrdenCompra();
            return instancia;
        }

        public cOrdenCompra()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarOrden(MODELO.Factura oOrden)
        {
            oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Add(oOrden);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        


        public void eliminarOrden(MODELO.Factura oOrden)
        {
            oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Remove(oOrden);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarOrden(MODELO.Factura oOrden)
        {
            oMODELO_SEGURIDAD.Entry(oOrden).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerOrden(string nombre) 
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Include("Proveedor").ToList()
                              where (orden.NroOrden.ToLower().Contains(nombre.ToLower()))
                              select orden;

            return ordenes.ToList();
        }

        public System.Collections.IEnumerable obtenerOrden2(string nombre)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Include("Proveedor").ToList()
                          where (orden.NroOrden.ToLower().Contains(nombre.ToLower())) && orden.visibily != false
                          select orden;

            return ordenes.ToList();
        }



        public System.Collections.IEnumerable obtenerOrdenMateriales(string nombre)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.ToList()
                          where orden.CantidadesMat.ToString().ToLower().Contains(nombre.ToLower())
                          select orden;

            return ordenes.ToList();
        }


        public System.Collections.IEnumerable obtenerOrdenProveedores(string razonSocial)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Include("Proveedor").ToList()                     
                          where orden.Proveedor.razonSocial.ToLower().Contains(razonSocial.ToLower())
                          select orden;

            return ordenes.ToList();
        }

        public System.Collections.IEnumerable obtenerOrdenLocalidad(string localidad)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Include("Proveedor").ToList()
                          where orden.Localidad.ToLower().Contains(localidad.ToLower())
                          select orden;

            return ordenes.ToList();
        }

        public System.Collections.IEnumerable obtenerOrdenFecha(DateTime fechastart, DateTime fechafinish)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Include("Proveedor").ToList()
                          where (orden.Fecha_Recepcion >= fechastart && orden.Fecha_Recepcion <= fechafinish)
                          select orden;

            return ordenes.ToList();
        }

        public System.Collections.IEnumerable SuperFiltro(DateTime fechastart, DateTime fechafinish,string razonSocial)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Include("Proveedor").ToList()
                          where (orden.Fecha_Recepcion >= fechastart && orden.Fecha_Recepcion <= fechafinish) &&
                          orden.Proveedor.razonSocial.ToLower().Contains(razonSocial.ToLower())
                          select orden;

            return ordenes.ToList();
        }

      







        //public System.Collections.IEnumerable obtenerOrdenProveedores()
        //{
        //    var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.Include("Proveedor").ToList()
        //                  //where orden.Proveedor.razonSocial.ToLower() == razonSocial.ToLower()
        //                  select orden;

        //    return ordenes.ToList();
        //}






        public System.Collections.IEnumerable obtenerOrdenMats(string nombre)
        {
            var ordenes = from orden in oMODELO_SEGURIDAD.ORDENESDECOMPRAS.ToList()
                          where orden.CantidadesMat.ToString() == nombre
                          select orden;

            return ordenes.ToList();
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
