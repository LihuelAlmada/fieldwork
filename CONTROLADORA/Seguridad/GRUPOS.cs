using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class GRUPOS
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;
 
        private static GRUPOS INSTANCIA { get; set; }
        public static GRUPOS Singleton()
        {
            if (INSTANCIA == null) INSTANCIA = new CONTROLADORA.GRUPOS();
            return INSTANCIA;
        }

        public GRUPOS()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void AGREGAR_GRUPO(MODELO.GRUPO oGRUPO)
        {

            oMODELO_SEGURIDAD.GRUPOS.Add(oGRUPO);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void ELIMINAR_GRUPO(MODELO.GRUPO oGRUPO)
        {
            oMODELO_SEGURIDAD.GRUPOS.Remove(oGRUPO);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void MODIFICAR_GRUPO(MODELO.GRUPO oGRUPO)
        {
            oMODELO_SEGURIDAD.Entry(oGRUPO).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable OBTENER_GRUPOS(string NOMBRE)
        {
            var grupos = from GRUPO in oMODELO_SEGURIDAD.GRUPOS.Include("USUARIOS").Include("PERMISOS").ToList()
                         where GRUPO.Nombre.ToLower().Contains(NOMBRE.ToLower())
                         select GRUPO;

            return grupos.ToList();
        }

        public System.Collections.IEnumerable OBTENER_GRUPOS()
        {
            var grupos = from GRUPO in oMODELO_SEGURIDAD.GRUPOS.ToList()
                         select GRUPO;

            return grupos.ToList();
        }

        public System.Collections.IEnumerable OBTENER_GRUPOS_ESTADO(bool valor, string NOMBRE)
        {
            var grupos = from grupo in oMODELO_SEGURIDAD.GRUPOS.ToList()
                           where (grupo.Nombre.ToLower().Contains(NOMBRE.ToLower()) && grupo.Estado == valor)
                           select grupo;


            return grupos.ToList();
        }
        public List<MODELO.GRUPO> AGREGAR_TODOS_GRUPOS(bool TODOS = false)
        {

            List<MODELO.GRUPO> grupos = oMODELO_SEGURIDAD.GRUPOS.ToList();
            if (TODOS)
                grupos.Add(new MODELO.GRUPO(0, "Todos"));

            return grupos.ToList();

        }

        public List<MODELO.GRUPO> OBTENER_GRUPOS_USUARIOS(MODELO.USUARIO oUsuario)
        {
            var grupos = from grupo in oMODELO_SEGURIDAD.GRUPOS.Include("USUARIOS").Include("PERMISOS").ToList()
                           where grupo.Usuarios.Contains(oUsuario)
                           select grupo;

            return grupos.ToList();
        }



    }
}
