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
    public partial class FrmCambiar_Clavee : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.USUARIO oUsuario;
        string contraseña_actual;
        string menu;



        public FrmCambiar_Clavee(MODELO.USUARIO unUsuario)
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            oUsuario = unUsuario;

            if (oUsuario.EstadoContraseña=="nueva")
            {
                btnNOACEPTA.Visible = false;
                
            }

        }

        public FrmCambiar_Clavee(MODELO.USUARIO unUsuario, string condicion)
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            oUsuario = unUsuario;
            menu = condicion;

            if (oUsuario.EstadoContraseña == "nueva")
            {
                btnNOACEPTA.Visible = false;

            }

        }



        private void btnACEPTA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNOACEPTA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnACEPTA_Click_1(object sender, EventArgs e)
        {
            contraseña_actual = cSeguridad.USUARIOS.EncriptarClave(txtCLAVE_ACTUAL.Text);


            if (oUsuario.Contraseña != contraseña_actual)
            {
                MessageBox.Show("Contraseña actual invalida");
                return;
            }
            if (oUsuario.Contraseña == contraseña_actual)
            {
                if (txtCLAVE_NUEVA.Text != txtCLAVE_NUEVA_CONFIRM.Text)
                {
                    MessageBox.Show("Contraseña nueva invalida");
                    txtCLAVE_NUEVA.Text = "";
                    txtCLAVE_NUEVA_CONFIRM.Text = "";
                    return;
                }
                else
                {
                    oUsuario.Contraseña = cSeguridad.USUARIOS.EncriptarClave(txtCLAVE_NUEVA.Text);
                    System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                    cliente.Credentials = new System.Net.NetworkCredential("uaitcampo@gmail.com", "uaiseguridad");

                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";
                    try
                    {
                        cliente.Send(cSeguridad.USUARIOS.Enviar_Mail(oUsuario, txtCLAVE_NUEVA.Text, false));
                        oUsuario.EstadoContraseña = "registrada";
                        MessageBox.Show("Mail enviado con los datos!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al enviar el mail con los datos, contactarse con administracion!");
                        return;
                    }
                    cSeguridad.USUARIOS.MODIFICAR_USUARIO(oUsuario);

                    if (menu == "menu")
                    {
                        this.Hide();
                        FrmMenu frm = new FrmMenu(oUsuario);
                        frm.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        FRM_LOGIN frm = new FRM_LOGIN();
                        frm.ShowDialog();

                    }
                }


            }
        }

        private void btnNOACEPTA_Click_1(object sender, EventArgs e)
        {
            if (menu == "menu")
            {
                this.Hide();
                FrmMenu frm = new FrmMenu(oUsuario);
                frm.ShowDialog();
            }
            else
            {
                this.Hide();
                FRM_LOGIN frm = new FRM_LOGIN();
                frm.ShowDialog();

            }
        }
    }
}