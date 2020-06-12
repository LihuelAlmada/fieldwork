using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.USUARIO
{
    public partial class FrmAgregarU : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.USUARIO oUsuario;
        string clave;
        //string usuario;
        string username;

        public FrmAgregarU(MODELO.USUARIO miusuario)
        {
            InitializeComponent();
            oUsuario = miusuario;
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            ArmarGrupo();
        }

        public void ArmarGrupo()
        {
            cblGRUPOS.DataSource = null;
            cblGRUPOS.DataSource = cSeguridad.GRUPOS.OBTENER_GRUPOS(); 
            
        }
        

        

        private void CblGRUPOS_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnGUARDARR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES            
            if (string.IsNullOrEmpty(txtUSUARIO.Text))
            {
                MessageBox.Show("El campo Usuario esta vacio");
                return;
            }

            if (string.IsNullOrEmpty(txtAPELLIDO.Text))
            {
                MessageBox.Show("El campo Apellido esta vacio");
                return;
            }
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("El campo Nombre esta vacio");
                return;
            }
            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("El campo Email esta vacio");
                return;
            }
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                MessageBox.Show("El campo DNI esta vacio");
                return;
            }


            #endregion

            //if (!cantproceed && CONTROLADORA.USUARIOS.Singleton().EXISTE_DNI(int.Parse(txtDNI.Text)) && Accion == "A")
            //{
            //    MessageBox.Show("Este usuario ya existe");

            //    cantproceed = false;
            //    return;
            //}


            oUsuario.Dni = Convert.ToInt32(txtDNI.Text);
            oUsuario.Usuario = txtUSUARIO.Text;
            oUsuario.Apellido = txtAPELLIDO.Text;
            oUsuario.Nombre = txtNOMBRE.Text;
            oUsuario.Email = txtEMAIL.Text;
            oUsuario.Estado = cbESTADO.Checked;
            username = oUsuario.Usuario;
            int dni = oUsuario.Dni;
            //ESTO TMB.

            //ESTO AGREGE
            // username = cSeguridad.USUARIOS.Username(oUsuario);
            //usuario = txtUSUARIO.Text;
            int i = 1;

            if (cSeguridad.USUARIOS.EXISTE_DOC(dni)==true)
            {
                MessageBox.Show("El usuario con el dni: " + " " + dni + "ya existe");
                return;
            }

            if (cSeguridad.USUARIOS.EXISTE_USERNAME(username)==true)
            {
                MessageBox.Show("El usuario con el usuario: " + " " + username + "ya existe");
                return;
            }
            oUsuario.Username = username;
            //  clave = cSeguridad.USUARIOS.Contraseña_azar();
            clave = txtDNI.Text;

            oUsuario.Contraseña = cSeguridad.USUARIOS.EncriptarClave(clave);


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("uaitcampo@gmail.com", "uaiseguridad");

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(cSeguridad.USUARIOS.Enviar_Mail(oUsuario, clave, true));
                oUsuario.EstadoContraseña = "nueva";
                MessageBox.Show("Mail enviado!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar el mail");
                return;
            }


            oUsuario.Grupos = new List<MODELO.GRUPO>();
            foreach (var item in cblGRUPOS.CheckedItems)
            {
                oUsuario.Grupos.Add((MODELO.GRUPO)item);
            }
            cSeguridad.Agregar(oUsuario);

            this.DialogResult = DialogResult.OK;







        }

        private void btnSALIIR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
