using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.GRUPO
{
    public partial class FrmGestionarG : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.GRUPO oGrupo;
        MODELO.USUARIO oUsuario;

        public FrmGestionarG()
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            armar_grilla();
            
        }

        public FrmGestionarG(MODELO.USUARIO unUsuario)
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            armar_grilla();
            btnAGREGAR.Enabled = false;
            btnELIMINAR.Enabled = false;
            btnCONSULTAR.Enabled = false;
            btnCONSULTAR.Enabled = false;

            oUsuario = unUsuario;

            for (int i = 0; i < oUsuario.Grupos.Count(); i++)
            {
                oGrupo = oUsuario.Grupos[i];

                if (oGrupo.Permisos.Count() > 0)
                {
                    for (int z = 0; z < oGrupo.Permisos.Count(); z++)
                    {
                        if (oGrupo.Permisos[z].Descripcion == "Agregar Grupo")
                        {
                            btnAGREGAR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Modificar Grupo")
                        {
                            btnMODIFICARR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Eliminar Grupo")
                        {
                            btnELIMINAR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Consultar Grupo")
                        {
                            btnCONSULTAR.Enabled = true;
                        }
                    }

                }

            }

        }

        public void armar_grilla()
        {
            dgvGRUPO.DataSource = null;
            dgvGRUPO.DataSource = cSeguridad.GRUPOS.OBTENER_GRUPOS(txtNOMBRE.Text);
            dgvGRUPO.Columns["Estado"].ReadOnly = true;
            dgvGRUPO.Columns["Nombre"].ReadOnly = true;
            dgvGRUPO.Columns["Codigo"].Visible = false;
        }

        public void armar_grilla_estadoactivo()
        {
            dgvGRUPO.DataSource = null;
            dgvGRUPO.DataSource = cSeguridad.GRUPOS.OBTENER_GRUPOS_ESTADO(true, txtNOMBRE.Text);
            dgvGRUPO.Columns["Estado"].ReadOnly = true;
            dgvGRUPO.Columns["Nombre"].ReadOnly = true;
            dgvGRUPO.Columns["Codigo"].Visible = false;

        }

        public void armar_grilla_estadoinactivo()
        {
            dgvGRUPO.DataSource = null;
            dgvGRUPO.DataSource = cSeguridad.GRUPOS.OBTENER_GRUPOS_ESTADO(false, txtNOMBRE.Text);
            dgvGRUPO.Columns["Estado"].ReadOnly = true;
            dgvGRUPO.Columns["Nombre"].ReadOnly = true;
            dgvGRUPO.Columns["Codigo"].Visible = false;

        }


        private void txtNOMBRE_TextChanged(object sender, EventArgs e)
        {
            if (cmbESTADO.SelectedItem.ToString() == "Activo")
            {
                armar_grilla_estadoactivo();
            }
            if (cmbESTADO.SelectedItem.ToString() == "Inactivo")
            {
                armar_grilla_estadoinactivo();
            }
            if (cmbESTADO.SelectedItem.ToString() == "Todos")
            {
                armar_grilla();
            }

            dgvGRUPO.Columns["Codigo"].Visible = false;
        }

        private void cmbESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbESTADO.SelectedItem.ToString() == "Activo")
            {
                armar_grilla_estadoactivo();
            }
            if (cmbESTADO.SelectedItem.ToString() == "Inactivo")
            {
                armar_grilla_estadoinactivo();
            }
            if (cmbESTADO.SelectedItem.ToString() == "Todos")
            {
                armar_grilla();
            }

            dgvGRUPO.Columns["Codigo"].Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GRUPO.FrmAgregarGr frm = new GRUPO.FrmAgregarGr(new MODELO.GRUPO(), oUsuario);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvGRUPO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo");
                return;
            }
            oGrupo = (MODELO.GRUPO)dgvGRUPO.CurrentRow.DataBoundItem;
            GRUPO.FrmModificarGr frm = new GRUPO.FrmModificarGr(oGrupo);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                armar_grilla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvGRUPO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo");
                return;
            }
            MODELO.GRUPO oGRUPO = (MODELO.GRUPO)dgvGRUPO.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Desea eliminar el grupo " + oGRUPO.Nombre + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cSeguridad.GRUPOS.ELIMINAR_GRUPO(oGRUPO);
                armar_grilla();
            }
        }

        private void btnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            if (dgvGRUPO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo");
                return;
            }
            oGrupo = (MODELO.GRUPO)dgvGRUPO.CurrentRow.DataBoundItem;
            GRUPO.FrmConsultaG frm = new GRUPO.FrmConsultaG(oGrupo);
            DialogResult dr = frm.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
