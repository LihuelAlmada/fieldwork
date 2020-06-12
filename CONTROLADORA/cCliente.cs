using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cCliente
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static cCliente instancia { get; set; }
        public static cCliente obtener_instancia()
        {
            if (instancia == null) instancia = new CONTROLADORA.cCliente();
            return instancia;
        }

        public cCliente()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void agregarCliente(MODELO.Cliente oCliente)
        {
            oMODELO_SEGURIDAD.CLIENTES.Add(oCliente);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void eliminarCliente(MODELO.Cliente oCliente)
        {
            oMODELO_SEGURIDAD.CLIENTES.Remove(oCliente);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void modificarCliente(MODELO.Cliente oCliente)
        {
            oMODELO_SEGURIDAD.Entry(oCliente).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }


        public System.Collections.IEnumerable obtenerClientes(string apellido, string razonsocial, MODELO.Localidad localidad)
        {
            var Clientes = from Cliente in oMODELO_SEGURIDAD.CLIENTES.Include("Localidad").ToList()
                              where (Cliente.razonSocial.ToLower().Contains(razonsocial.ToLower())
                              && Cliente.apellido.ToLower().Contains(apellido.ToLower())
                              && Cliente.Localidad.nombre == localidad.nombre)
                              select Cliente;

            return Clientes.ToList();
        }

        public System.Collections.IEnumerable obtenerClientesAll(string apellido, string razonsocial)
        {
            var Clientes = from Cliente in oMODELO_SEGURIDAD.CLIENTES.Include("Localidad").ToList()
                              where (Cliente.razonSocial.ToLower().Contains(razonsocial.ToLower())
                              && Cliente.apellido.ToLower().Contains(apellido.ToLower()))                           
                              select Cliente;

            return Clientes.ToList();
        }

        public System.Collections.IEnumerable obtenerClientes()
        {
            var Clientes = from Cliente in oMODELO_SEGURIDAD.CLIENTES.Include("Localidad").ToList()
                              select Cliente;

            return Clientes.ToList();
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
