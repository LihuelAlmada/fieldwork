using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class SEGURIDAD
    {
        public PERMISOS PERMISOS { get; set; }
        public USUARIOS USUARIOS { get; set; }
        public GRUPOS GRUPOS { get; set; }
        //public FORMULARIOS FORMULARIOS { get; set; }
        //public MODULOS MODULOS { get; set; }


        private static SEGURIDAD INSTANCIA { get; set; }
        public static SEGURIDAD Singleton()
        {
            if (INSTANCIA == null) INSTANCIA = new CONTROLADORA.SEGURIDAD();
            return INSTANCIA;
        }
        private SEGURIDAD()
        {
            PERMISOS = new PERMISOS();
            USUARIOS = new USUARIOS();
            GRUPOS = new GRUPOS();
            //FORMULARIOS = new FORMULARIOS();
            //MODULOS = new MODULOS();
        }

        public void Agregar(Object o)
        {
            if (o.GetType().Name == "USUARIO")
            {
                var u = (MODELO.USUARIO)o;
                USUARIOS.AGREGAR_USUARIO(u);
            }

            if (o.GetType().Name == "PERMISO")
            {
                var u = (MODELO.PERMISO)o;
                PERMISOS.AGREGAR_PERMISO(u);
            }

            if (o.GetType().Name == "GRUPO")
            {
                var u = (MODELO.GRUPO)o;
                GRUPOS.AGREGAR_GRUPO(u);
            }
        }

        public void Eliminar(Object o)
        {
            if (o.GetType().Name == "USUARIO")
            {
                var u = (MODELO.USUARIO)o;
                USUARIOS.ELIMINAR_USUARIO(u);
            }

            if (o.GetType().Name == "PERMISO")
            {
                var u = (MODELO.PERMISO)o;
                PERMISOS.ELIMINAR_PERMISO(u);
            }

            if (o.GetType().Name == "GRUPO")
            {
                var u = (MODELO.GRUPO)o;
                GRUPOS.ELIMINAR_GRUPO(u);
            }
        }

        public void Modificar(Object o)
        {
            if (o.GetType().Name == "USUARIO")
            {
                var u = (MODELO.USUARIO)o;
                USUARIOS.MODIFICAR_USUARIO(u);
            }

            if (o.GetType().Name == "PERMISO")
            {
                var u = (MODELO.PERMISO)o;
                PERMISOS.MODIFICAR_PERMISO(u);
            }

            if (o.GetType().Name == "GRUPO")
            {
                var u = (MODELO.GRUPO)o;
                GRUPOS.MODIFICAR_GRUPO(u);
            }
        }

        


    }
}
