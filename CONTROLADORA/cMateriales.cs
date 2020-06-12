using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cMateriales
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cMateriales instancia { get; set; }
        public static cMateriales obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cMateriales();
            return instancia;
        }

        public cMateriales()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarMateriales(MODELO.Materiales oMateriales)
        {
            oMODELO_SEGURIDAD.MATERIALES.Add(oMateriales);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void eliminarMateriales(MODELO.Materiales oMateriales)
        {
            oMODELO_SEGURIDAD.MATERIALES.Remove(oMateriales);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarMateriales(MODELO.Materiales oMateriales)
        {
            oMODELO_SEGURIDAD.Entry(oMateriales).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable obtenerMaterialNombre(string nombre) //Obtiene por nombre
        {
            var materiales = from material in oMODELO_SEGURIDAD.MATERIALES.ToList()
                         where material.DESCRIPCION_LARGA.ToLower().Contains(nombre.ToLower())
                             select material;

            return materiales.ToList();
        }

        public System.Collections.IEnumerable obtenerMaterialNombreProveedor(string nombre, string oProveedor) //Obtiene por nombre
        {
            var materiales = from material in oMODELO_SEGURIDAD.MATERIALES.ToList()
                             where material.DESCRIPCION_LARGA.ToLower().Contains(nombre.ToLower()) && material.PROVEEDOR == oProveedor
                             select material;

            return materiales.ToList();
        }



        public List<MODELO.Materiales> obtenerMaterialNombree(string nombre) //Obtiene por nombre
        {
            var materiales = from material in oMODELO_SEGURIDAD.MATERIALES.ToList()
                             where material.DESCRIPCION_CORTA.ToLower().Contains(nombre.ToLower())
                             select material;

            return materiales.ToList();
        }

        public System.Collections.IEnumerable obtenerMaterialProveedor(string oProveedor) //Obtiene por nombre
        {
            var materiales = from material in oMODELO_SEGURIDAD.MATERIALES.ToList()
                             where material.PROVEEDOR == oProveedor

                             select material;

            return materiales.ToList();
        }

        public System.Collections.IEnumerable obtenerMaterialPP() //Obtiene por nombre
        {
            var materiales = from material in oMODELO_SEGURIDAD.MATERIALES.ToList()
                             where material.STOCK <= material.MINIMO
                             select material;

            return materiales.ToList();
        }
        public List<MODELO.Proveedor> obtenerProveedores(bool todos = false)
        {
            List<MODELO.Proveedor> Proveedores = oMODELO_SEGURIDAD.PROVEEDORES.ToList();
            if (todos)
                Proveedores.Add(new MODELO.Proveedor(0, "Todos"));
            return Proveedores.ToList();
        }

        public System.Collections.IEnumerable LISTAR_MATERIALES(DateTime A, DateTime B)
        {
            var materiales = from material in oMODELO_SEGURIDAD.MATERIALES.Include("OrdenesCompras").Include("OrdenesVentas").ToList()
                              where material.OrdenesCompras.Count(_ => (_.Fecha.Date >= A && _.Fecha_Recepcion.Date <= B)) > 0
                              select new { NOMBRE = material.DESCRIPCION_CORTA, COMPRAS = material.OrdenesCompras.Count(_ => (_.Fecha.Date >= A && _.Fecha_Recepcion.Date <= B)) };
            return materiales.ToList();
        }


        

    }
}
