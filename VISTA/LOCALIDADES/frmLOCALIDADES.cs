using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmLOCALIDADES : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cLocalidad cLocalidad;
        MODELO.Localidad oLOCALIDAD;
        public MODELO.Localidad LocalidadSelect
        {
            get { return oLOCALIDAD; }
        }
        public frmLOCALIDADES()
        {
            InitializeComponent();
            cLocalidad = CONTROLADORA.cLocalidad.obtener_instancia();
            grilla_localidades();
            //btnLupa.Visible = false;
        }
        public frmLOCALIDADES(string accion)
        {
            InitializeComponent();
            cLocalidad = CONTROLADORA.cLocalidad.obtener_instancia();
            grilla_localidades();
            
        }

       

        public void grilla_localidades()
        {
            dgvCIUDADES.DataSource = null;
            dgvCIUDADES.DataSource = cLocalidad.obtenerLocalidadNombre(txtLOCALIDAD.Text);
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            
        }

        private void txtLOCALIDAD_TextChanged(object sender, EventArgs e)
        {
            if (txtLOCALIDAD.TextLength > 0 || txtLOCALIDAD.TextLength == 0) grilla_localidades();
        }

        private void frmLOCALIDADES_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*FRM frm = new Form1();
            frm.Show();*/
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un rubro");
                return;
            }
            MODELO.Localidad oLOCALIDAD = (MODELO.Localidad)dgvCIUDADES.CurrentRow.DataBoundItem;

            frmLOCALIDAD frm = new frmLOCALIDAD(oLOCALIDAD, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                grilla_localidades();
        }

        private void BtnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un rubro");
                return;
            }
            MODELO.Localidad oLOCALIDAD = (MODELO.Localidad)dgvCIUDADES.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar " + oLOCALIDAD.nombre + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cLocalidad.eliminarLocalidad(oLOCALIDAD);
                grilla_localidades();
            }

        }

        private void BtnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un rubro");
                return;
            }
            MODELO.Localidad oLOCALIDAD = (MODELO.Localidad)dgvCIUDADES.CurrentRow.DataBoundItem;

            frmLOCALIDAD frm = new frmLOCALIDAD(oLOCALIDAD, "C");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                grilla_localidades();
        }

        private void BtnAGREGAR_Click_1(object sender, EventArgs e)
        {
            frmLOCALIDAD frm = new frmLOCALIDAD(new MODELO.Localidad(), "A");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                grilla_localidades();
        }

        private void btnLupa_Click(object sender, EventArgs e)
        {
           
        }

        private void DgvCIUDADES_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad");
                return;
            }
            oLOCALIDAD = (MODELO.Localidad)dgvCIUDADES.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }

        private void dgvCIUDADES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad");
                return;
            }
            oLOCALIDAD = (MODELO.Localidad)dgvCIUDADES.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }
    }
}
