using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cProveedor
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cProveedor instancia { get; set; }
        public static cProveedor obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cProveedor();
            return instancia;
        }

        public cProveedor()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarProveedor(MODELO.Proveedor oProveedor)
        {
            oMODELO_SEGURIDAD.PROVEEDORES.Add(oProveedor);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void eliminarProveedor(MODELO.Proveedor oProveedor)
        {
            oMODELO_SEGURIDAD.PROVEEDORES.Remove(oProveedor);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarProveedor(MODELO.Proveedor oProveedor)
        {
            oMODELO_SEGURIDAD.Entry(oProveedor).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerProveedorNombre(string nombre) //Obtiene por nombre
        {
            var proveedores = from proveedor in oMODELO_SEGURIDAD.PROVEEDORES.ToList()
                             where proveedor.nombre.ToLower().Contains(nombre.ToLower())
                             select proveedor;

            return proveedores.ToList();
        }


        public System.Collections.IEnumerable obtenerProveedores(string apellido, string razonsocial, MODELO.Localidad localidad)
        {
            var proveedores = from proveedor in oMODELO_SEGURIDAD.PROVEEDORES.Include("Localidad").ToList()
                              where (proveedor.razonSocial.ToLower().Contains(razonsocial.ToLower())
                              && proveedor.apellido.ToLower().Contains(apellido.ToLower())
                              && proveedor.Localidad.nombre == localidad.nombre)
                              select proveedor;

            return proveedores.ToList();
        }

        public System.Collections.IEnumerable obtenerProveedoresAll(string apellido, string razonsocial)
        {
            var proveedores = from proveedor in oMODELO_SEGURIDAD.PROVEEDORES.Include("Localidad").ToList()
                              where (proveedor.razonSocial.ToLower().Contains(razonsocial.ToLower())
                              && proveedor.apellido.ToLower().Contains(apellido.ToLower()))
                              select proveedor;

            return proveedores.ToList();
        }

        public System.Collections.IEnumerable obtenerProveedores()
        {
            var proveedores = from proveedor in oMODELO_SEGURIDAD.PROVEEDORES.Include("Localidad").ToList()
                              select proveedor;

            return proveedores.ToList();
        }

        public List<MODELO.Localidad> obtenerLocalidades(bool todos = false)
        {
            List<MODELO.Localidad> Localidades = oMODELO_SEGURIDAD.LOCALIDADES.ToList();
            if (todos)
                Localidades.Add(new MODELO.Localidad(0, "Todos"));
            return Localidades.ToList();
        }

    }
}