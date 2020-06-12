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
    public partial class FrmGestionarU : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.GRUPO oGrupo;
        MODELO.USUARIO oUsuario;
        string clave;

        public FrmGestionarU()
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();

           

            cmbGRUPO.DataSource = cSeguridad.GRUPOS.AGREGAR_TODOS_GRUPOS(true);
            cmbGRUPO.Text = "Todos";
            armar_grilla_todos();


        }

        public FrmGestionarU(MODELO.USUARIO unUsuario)
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            btnAGREGARR.Enabled = false;
            btnELIMINARR.Enabled = false;
            btnMODIFICARR.Enabled = false;
            btnRESETEAR_CLAVE.Enabled = false;



            cmbGRUPO.DataSource = cSeguridad.GRUPOS.AGREGAR_TODOS_GRUPOS(true);
            cmbGRUPO.Text = "Todos";
            armar_grilla_todos();

            oUsuario = unUsuario;

            for (int i = 0; i < oUsuario.Grupos.Count(); i++)
            {
                oGrupo = oUsuario.Grupos[i];

                if (oGrupo.Permisos.Count() > 0)
                {
                    for (int z = 0; z < oGrupo.Permisos.Count(); z++)
                    {
                        if (oGrupo.Permisos[z].Descripcion == "Agregar Usuario")
                        {
                            btnAGREGARR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Modificar Usuario")
                        {
                            btnMODIFICARR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Eliminar Usuario")
                        {
                            btnELIMINARR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "ResetearClave Usuario")
                        {
                            btnRESETEAR_CLAVE.Enabled = true;
                        }     
                    }

                }

            }
        }

        public void armar_grilla_todos()
        {
            dgvUSUARIO.DataSource = null;
            dgvUSUARIO.DataSource = cSeguridad.USUARIOS.OBTENER_USUARIOS(txtAPELLIDO.Text);
            dgvUSUARIO.AutoGenerateColumns = true;
            dgvUSUARIO.Columns["Contraseña"].Visible = false;
            dgvUSUARIO.Columns["EstadoContraseña"].Visible = false;
            dgvUSUARIO.Columns["Codigo"].Visible = false;
            dgvUSUARIO.Columns["Username"].Visible = false;
            dgvUSUARIO.Columns["Estado"].ReadOnly = true;
            dgvUSUARIO.Columns["Nombre"].ReadOnly = true;
            dgvUSUARIO.Columns["Apellido"].ReadOnly = true;
            dgvUSUARIO.Columns["Email"].ReadOnly = true;
            dgvUSUARIO.Columns["GruposUsuario"].Visible = false;
            dgvUSUARIO.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        public void armar_grilla_estadoactivo_grupo()
        {
            dgvUSUARIO.DataSource = null;
            dgvUSUARIO.DataSource = cSeguridad.USUARIOS.OBTENER_USUARIOS_ESTADOS_STRING_GRUPOS(true, txtAPELLIDO.Text, oGrupo);
            dgvUSUARIO.Columns["Contraseña"].Visible = false;
            dgvUSUARIO.Columns["EstadoContraseña"].Visible = false;
            dgvUSUARIO.Columns["Codigo"].Visible = false;
            dgvUSUARIO.Columns["Username"].Visible = false;
            dgvUSUARIO.Columns["Estado"].ReadOnly = true;
            dgvUSUARIO.Columns["Nombre"].ReadOnly = true;
            dgvUSUARIO.Columns["Apellido"].ReadOnly = true;
            dgvUSUARIO.Columns["Email"].ReadOnly = true;
        }

        public void armar_grilla_estadodesactivo_grupo()
        {
            dgvUSUARIO.DataSource = null;
            dgvUSUARIO.DataSource = cSeguridad.USUARIOS.OBTENER_USUARIOS_ESTADOS_STRING_GRUPOS(false, txtAPELLIDO.Text, oGrupo);
            dgvUSUARIO.Columns["Contraseña"].Visible = false;
            dgvUSUARIO.Columns["EstadoContraseña"].Visible = false;
            dgvUSUARIO.Columns["Codigo"].Visible = false;
            dgvUSUARIO.Columns["Username"].Visible = false;
            dgvUSUARIO.Columns["Estado"].ReadOnly = true;
            dgvUSUARIO.Columns["Nombre"].ReadOnly = true;
            dgvUSUARIO.Columns["Apellido"].ReadOnly = true;
            dgvUSUARIO.Columns["Email"].ReadOnly = true;
        }

        public void armar_grilla_estadoactivo_todo()
        {
            dgvUSUARIO.DataSource = null;
            dgvUSUARIO.DataSource = cSeguridad.USUARIOS.OBTENER_USUARIOS_ESTADOS_STRING_TODOS(true, txtAPELLIDO.Text);
            dgvUSUARIO.Columns["Contraseña"].Visible = false;
            dgvUSUARIO.Columns["EstadoContraseña"].Visible = false;
            dgvUSUARIO.Columns["Codigo"].Visible = false;
            dgvUSUARIO.Columns["Username"].Visible = false;
            dgvUSUARIO.Columns["Estado"].ReadOnly = true;
            dgvUSUARIO.Columns["Nombre"].ReadOnly = true;
            dgvUSUARIO.Columns["Apellido"].ReadOnly = true;
            dgvUSUARIO.Columns["Email"].ReadOnly = true;
        }

        public void armar_grilla_estadodesactivo_todo()
        {
            dgvUSUARIO.DataSource = null;
            dgvUSUARIO.DataSource = cSeguridad.USUARIOS.OBTENER_USUARIOS_ESTADOS_STRING_TODOS(false, txtAPELLIDO.Text);
            dgvUSUARIO.Columns["Contraseña"].Visible = false;
            dgvUSUARIO.Columns["EstadoContraseña"].Visible = false;
            dgvUSUARIO.Columns["Codigo"].Visible = false;
            dgvUSUARIO.Columns["Username"].Visible = false;
            dgvUSUARIO.Columns["Estado"].ReadOnly = true;
            dgvUSUARIO.Columns["Nombre"].ReadOnly = true;
            dgvUSUARIO.Columns["Apellido"].ReadOnly = true;
            dgvUSUARIO.Columns["Email"].ReadOnly = true;
        }

        public void armar_grilla_grupos()
        {
            dgvUSUARIO.DataSource = null;
            dgvUSUARIO.DataSource = cSeguridad.USUARIOS.OBTENER_USUARIOS_GRUPOS_STRING(oGrupo ,txtAPELLIDO.Text);
            dgvUSUARIO.Columns["Contraseña"].Visible = false;
            dgvUSUARIO.Columns["EstadoContraseña"].Visible = false;
            dgvUSUARIO.Columns["Codigo"].Visible = false;
            dgvUSUARIO.Columns["Username"].Visible = false;
            dgvUSUARIO.Columns["Estado"].ReadOnly = true;
            dgvUSUARIO.Columns["Nombre"].ReadOnly = true;
            dgvUSUARIO.Columns["Apellido"].ReadOnly = true;
            dgvUSUARIO.Columns["Email"].ReadOnly = true;
        }

        

        

        

        private void BtnRESETEAR_CLAVE_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }
            MODELO.USUARIO oUsuario = (MODELO.USUARIO)dgvUSUARIO.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Desea resetear la clave de " + oUsuario.Nombre + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                oUsuario = (MODELO.USUARIO)dgvUSUARIO.CurrentRow.DataBoundItem;
                cSeguridad.USUARIOS.RESETEAR_CLAVE(oUsuario);
                clave = oUsuario.Dni.ToString();
                //clave = cSeguridad.USUARIOS.Contraseña_azar();
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
                cSeguridad.USUARIOS.MODIFICAR_USUARIO(oUsuario);
            }
            
        }

        private void TxtAPELLIDO_TextChanged(object sender, EventArgs e)
        {
            if (oGrupo.Nombre == "Todos")
            {
                if (cmbESTADO.SelectedItem.ToString() == "Activo")
                {
                    armar_grilla_estadoactivo_todo();

                }
                if (cmbESTADO.SelectedItem.ToString() == "Inactivo")
                {
                    armar_grilla_estadodesactivo_todo();
                }
                if (cmbESTADO.SelectedItem.ToString() == "Todos")
                {
                    armar_grilla_todos();
                }
            }

            else
            {
                if (cmbESTADO.SelectedItem.ToString() == "Activo")
                {
                    armar_grilla_estadoactivo_grupo();
                }
                if (cmbESTADO.SelectedItem.ToString() == "Inactivo")
                {
                    armar_grilla_estadodesactivo_grupo();
                }
                if (cmbESTADO.SelectedItem.ToString() == "Todos")
                {
                    armar_grilla_grupos();
                }
            }



        }

        private void CmbESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oGrupo.Nombre == "Todos")
            {
                if (cmbESTADO.SelectedItem.ToString() == "Activo")
                {
                    armar_grilla_estadoactivo_todo();

                }
                if (cmbESTADO.SelectedItem.ToString() == "Inactivo")
                {
                    armar_grilla_estadodesactivo_todo();
                }
                if (cmbESTADO.SelectedItem.ToString() == "Todos")
                {
                    armar_grilla_todos();
                }
            }

            else
            {
                if (cmbESTADO.SelectedItem.ToString() == "Activo")
                {
                    armar_grilla_estadoactivo_grupo();
                }
                if (cmbESTADO.SelectedItem.ToString() == "Inactivo")
                {
                    armar_grilla_estadodesactivo_grupo();
                }
                if (cmbESTADO.SelectedItem.ToString() == "Todos")
                {
                    armar_grilla_grupos();
                }
            }



        }

        private void cmbGRUPO_SelectedIndexChanged(object sender, EventArgs e)
        {


            oGrupo = (MODELO.GRUPO)cmbGRUPO.SelectedItem;

            cmbESTADO.Text = "Todos";
            if(oGrupo.Nombre == "Todos")
            {
                
                armar_grilla_todos();
            }

            else
            {
               
                armar_grilla_grupos();
            }
            



        }

        private void cmbGRUPO_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbESTADO.Enabled = true;
        }

        private void btnAGREGARR_Click(object sender, EventArgs e)
        {
            USUARIO.FrmAgregarU frm = new USUARIO.FrmAgregarU(new MODELO.USUARIO());
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla_todos();
        }

        private void btnMODIFICARR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }
            oUsuario = (MODELO.USUARIO)dgvUSUARIO.CurrentRow.DataBoundItem;
            USUARIO.FrmModificarUs frm = new USUARIO.FrmModificarUs(oUsuario);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla_todos();
        }

        private void btnELIMINARR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIO.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el Usuario que desea eliminar");
                return;
            }
            MODELO.USUARIO oUsuario = (MODELO.USUARIO)dgvUSUARIO.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Desea eliminar el usuario " + oUsuario.Nombre + " " +  oUsuario.Apellido + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cSeguridad.USUARIOS.ELIMINAR_USUARIO(oUsuario);
                armar_grilla_todos();
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
