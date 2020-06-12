using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace VISTA
{
    public partial class FRM_LOGIN : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.USUARIO oUsuario;
        string contraseña;
        List<MODELO.PERMISO> listapermiso;
        CONTROLADORA.Seguridad.ACCESO oAccesos;
        MODELO.SEGURIDAD.ACCESO oAcceso;

        public FRM_LOGIN()
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            listapermiso = new List<MODELO.PERMISO>();
            lblError.Visible = false;
            oAcceso = new MODELO.SEGURIDAD.ACCESO();
            oAccesos = CONTROLADORA.Seguridad.ACCESO.obtenerInstancia();
           
          

        }
  

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CLAVE.FrmOlvide_Clave frm = new CLAVE.FrmOlvide_Clave();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnLOGIN_Click(object sender, EventArgs e)
        {

            lblError.Text = "";
            if (string.IsNullOrEmpty(txtUSUARIO.Text))
            {
                lblError.Text = "Debe ingresar el nombre de usuario";
                lblError.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(txtCONTRASEÑA.Text))
            {
                lblError.Text = "Debe ingresar la contraseña del usuario";
                lblError.Visible = true;
                return;
            }
            lblError.Text = "";

            if (txtUSUARIO.Text == "admin")
            {
                if (txtCONTRASEÑA.Text == "admin")
                {

                    this.Hide();
                    FrmMenu frm = new FrmMenu();
                    frm.ShowDialog();
                }




            }
            else
            {

                if (cSeguridad.USUARIOS.EXISTE_USERNAME(txtUSUARIO.Text) == false)
                {
                    lblError.Text = "Usuario y/o contraseña incorrecta";
                    lblError.Visible = true;
                    return;
                }

                if (cSeguridad.USUARIOS.EXISTE_USERNAME(txtUSUARIO.Text))
                {
                    oUsuario = cSeguridad.USUARIOS.OBTENER_USUARIO_USERNAME(txtUSUARIO.Text);
                    contraseña = cSeguridad.USUARIOS.EncriptarClave(txtCONTRASEÑA.Text); //AKI=)=)(?
                    if (oUsuario.Estado == true)
                    {


                        if (oUsuario.Contraseña != contraseña)
                        {
                            lblError.Text = "Usuario y/o contraseña incorrecta";
                            lblError.Visible = true;
                            return;
                        }
                        if (oUsuario.Contraseña == contraseña)
                        {
                            if (oUsuario.EstadoContraseña == "nueva")
                            {
                                this.Hide();

                                CLAVE.FrmCambiar_Clavee frm = new CLAVE.FrmCambiar_Clavee(oUsuario);
                                frm.ShowDialog();
                            }
                            else
                            {

                                this.Hide();
                                oAcceso.Username = oUsuario.Username;
                                oAcceso.Login = "LOGIN";
                                //oAcceso.Movimiento = "LOGIN";
                                oAcceso.FechayHoraEntrada = DateTime.Now;
                                //oAccesos.AGREGAR_ACCESO(oAcceso);
                                oUsuario.Grupos = cSeguridad.GRUPOS.OBTENER_GRUPOS_USUARIOS(oUsuario);
                                FrmMenu frm = new FrmMenu(oUsuario, oAcceso);
                                frm.ShowDialog();
                            }


                        }
                    }
                    else
                    {
                        lblError.Text = "El usuario ingresado se encuentra inactivo, consultar al administrador";
                        lblError.Visible = true;
                        return;
                    }


                }

            }
        }

        private void BtnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

      