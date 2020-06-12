using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.CLAVE
{
    public partial class FrmOlvide_Clave : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.USUARIO oUsuario;
        string clave;

        public FrmOlvide_Clave()
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
        }



        

        private void btnACEPTA_Click_1(object sender, EventArgs e)
        {
            if (cSeguridad.USUARIOS.EXISTE_USERNAME_Y_MAIL(txtusername.Text, txtEMAIL.Text) == false)
            {
                MessageBox.Show("Usuario y/o mail no existe");
                return;
            }
            if (cSeguridad.USUARIOS.EXISTE_USERNAME_Y_MAIL(txtusername.Text, txtEMAIL.Text) == true)
            {
                oUsuario = cSeguridad.USUARIOS.OBTENER_USUARIO_USERNAME(txtusername.Text);
                cSeguridad.USUARIOS.RESETEAR_CLAVE(oUsuario);
                //clave = cSeguridad.USUARIOS.Contraseña_azar();
                clave = oUsuario.Dni.ToString();
                oUsuario.Contraseña = cSeguridad.USUARIOS.EncriptarClave(clave);


                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("uaitcampo@gmail.com", "uaiseguridad");

                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";
                try
                {
                    cliente.Send(cSeguridad.USUARIOS.Enviar_Mail_Reseteo(oUsuario, clave));
                    oUsuario.EstadoContraseña = "nueva";
                    MessageBox.Show("Mail enviado!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al enviar el mail");
                    return;
                }
                cSeguridad.USUARIOS.MODIFICAR_USUARIO(oUsuario);

                this.Hide();
                FRM_LOGIN frm = new FRM_LOGIN();
                frm.ShowDialog();
            }
        }

        private void btnNOACEPTA_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }
    }
}
