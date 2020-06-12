using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace CONTROLADORA
{
    public class USUARIOS
    {
        DATOS.MODELO_SEGURIDAD oMODELO_SEGURIDAD;

        private static USUARIOS INSTANCIA { get; set; }
        public static USUARIOS Singleton()
        {
            if (INSTANCIA == null) INSTANCIA = new CONTROLADORA.USUARIOS();
            return INSTANCIA;
        }

        public USUARIOS()
        {
            oMODELO_SEGURIDAD = DATOS.MODELO_SEGURIDAD.Singleton();
        }

        public void AGREGAR_USUARIO(MODELO.USUARIO oUSUARIO)
        {
            oMODELO_SEGURIDAD.USUARIOS.Add(oUSUARIO);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void ELIMINAR_USUARIO(MODELO.USUARIO oUSUARIO)
        {
            oMODELO_SEGURIDAD.USUARIOS.Remove(oUSUARIO);
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public void MODIFICAR_USUARIO(MODELO.USUARIO oUSUARIO)
        {
            oMODELO_SEGURIDAD.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Modified;
            oMODELO_SEGURIDAD.SaveChanges();
        }

        public System.Collections.IEnumerable OBTENER_USUARIOS(string APELLIDO)
        {
            var usuarios = from usuario in oMODELO_SEGURIDAD.USUARIOS.Include("GRUPOS").ToList()
                              where usuario.Apellido.ToLower().Contains(APELLIDO.ToLower())
                              select usuario;

            return usuarios.ToList();
        }

        public System.Collections.IEnumerable OBTENER_USUARIOS_GRUPOS(MODELO.GRUPO oGrupo)
        {
            var usuarios = from usuario in oMODELO_SEGURIDAD.USUARIOS.Include("GRUPOS").ToList()
                           where usuario.Grupos.Contains(oGrupo)
                           select usuario;

            return usuarios.ToList();
        }


        public System.Collections.IEnumerable OBTENER_USUARIOS_ESTADOS_STRING_TODOS(bool valor, string APELLIDO)
        {
            var usuarios = from usuario in oMODELO_SEGURIDAD.USUARIOS.Include("GRUPOS").ToList()
                           where (usuario.Apellido.ToLower().Contains(APELLIDO.ToLower()) && usuario.Estado == valor)
                           select usuario;

            return usuarios.ToList();
        }

        public System.Collections.IEnumerable OBTENER_USUARIOS_ESTADOS_STRING_GRUPOS(bool valor, string APELLIDO, MODELO.GRUPO oGrupo)
        {
            var usuarios = from usuario in oMODELO_SEGURIDAD.USUARIOS.Include("GRUPOS").ToList()
                           where (usuario.Apellido.ToLower().Contains(APELLIDO.ToLower()) && usuario.Estado == valor && usuario.Grupos.Contains(oGrupo))
                           select usuario;

            return usuarios.ToList();
        }

        public System.Collections.IEnumerable OBTENER_USUARIOS_GRUPOS_STRING(MODELO.GRUPO oGrupo, string APELLIDO)
        {
            var usuarios = from usuario in oMODELO_SEGURIDAD.USUARIOS.Include("GRUPOS").ToList()
                           where (usuario.Apellido.ToLower().Contains(APELLIDO.ToLower()) && usuario.Grupos.Contains(oGrupo))
                           select usuario;

            return usuarios.ToList();
        }

        public System.Collections.IEnumerable OBTENER_USUARIOS()
        {
            var usuarios = from usuario in oMODELO_SEGURIDAD.USUARIOS.Include("GRUPOS").ToList() 
                           select usuario;

            return usuarios.ToList();
        }

        public bool EXISTE_USERNAME(string username)
        {
            var query = from usuario in oMODELO_SEGURIDAD.USUARIOS
                        where usuario.Username == username
                        select usuario;
            return (bool)(query.ToList().Count() > 0) ? true : false;
        }

        public MODELO.USUARIO OBTENER_USUARIO_USERNAME(string username)
        {
            return oMODELO_SEGURIDAD.USUARIOS.FirstOrDefault(c => c.Username == username);
        }

        public void RESETEAR_CLAVE(MODELO.USUARIO oUsuario)
        {
            oUsuario.Contraseña = null;
        }
       
        public string EncriptarClave(string clave)
        {
                byte[] passBytes = Encoding.Unicode.GetBytes(clave);
                SHA1 sha = SHA1.Create();
                byte[] hash = sha.ComputeHash(passBytes);
                string hashString = Encoding.Unicode.GetString(hash);
                return hashString;
        }

        public System.Net.Mail.MailMessage Enviar_Mail(MODELO.USUARIO oUsuario, string clave, bool condicion)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(oUsuario.Email);
            mmsg.Subject =  "Buenos dias " + oUsuario.Nombre +"!";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            if (condicion)
            {
                mmsg.Body = "Para registrate, entra al sistema con este usuario: " + oUsuario.Usuario + " y contraseña: " + clave + ". Luego podras crear una nueva contraseña!!";
            }
            else
            {
                mmsg.Body = "Registro completo, tu usuario: " + oUsuario.Username + " y contraseña: " + clave ;
            }
            //mmsg.Bcc.Add(mail de persona) aqui enviamos este mail como copia
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("uaitcampo@gmail.com");
            return mmsg;

        }

        public System.Net.Mail.MailMessage Enviar_Mail_Reseteo(MODELO.USUARIO oUsuario, string clave)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(oUsuario.Email);
            mmsg.Subject = " " + oUsuario.Nombre + "tu contraseña fue RESETEADA!";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = "Buenos dias! Tu contraseña fue reseteada a : " + clave + " Al loguearte con tu usuario:  " + oUsuario.Username + " podras cambiar tu contraseña. Saludos!";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("uaitcampo@gmail.com");
            return mmsg;

        }

        public string Contraseña_azar()
        {
            string lista_numero;

            Random num = new Random();

            string num1 = num.Next(9).ToString();
            string num2 = num.Next(9).ToString();
            string num3 = num.Next(9).ToString();
            string num4 = num.Next(9).ToString();

            lista_numero = num1 + num2 + num3 + num4;

            return lista_numero;


        }

        public string Username(MODELO.USUARIO oUsuario)
        {
            string username;
            string nombre_mayuscula;
            nombre_mayuscula = oUsuario.Nombre.ToUpper();
            return username = nombre_mayuscula[0] + oUsuario.Apellido;
        }

        public bool EXISTE_DNI(int DNI)
        {
            var query = from usuario in oMODELO_SEGURIDAD.USUARIOS
                        where usuario.Dni == DNI
                        select usuario;
            return (bool)(query.ToList().Count() > 0) ? true : false;
        }

        public bool EXISTE_DOC(int Dni)
        {
            var query = from usuario in oMODELO_SEGURIDAD.USUARIOS
                        where usuario.Dni == Dni
                        select usuario;
            return (bool)(query.ToList().Count() > 0) ? true : false;
        }

        public bool EXISTE_USERNAME_Y_MAIL(string username,string mail)
        {
            var query = from usuario in oMODELO_SEGURIDAD.USUARIOS
                        where usuario.Username == username && usuario.Email==mail
                        select usuario;
            return (bool)(query.ToList().Count() > 0) ? true : false;
        }

    }
}



