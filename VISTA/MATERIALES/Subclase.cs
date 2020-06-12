using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.MATERIALES
{
    public partial class Subclase : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cSubclase cSubclase;
        MODELO.Subclase oSUBCLASE;
        public MODELO.Subclase SubClaseSelect
        {
            get { return oSUBCLASE; }
        }
        public Subclase()
        {
            InitializeComponent();
            cSubclase = CONTROLADORA.cSubclase.obtener_instancia();
            ARMO_GRILLA();
        }
        public Subclase(string accion)
        {
            InitializeComponent();
            cSubclase = CONTROLADORA.cSubclase.obtener_instancia();
            //ARMO_COMBO();
            ARMO_GRILLA();

        }
        public void ARMO_GRILLA()
        {
            dgvSUBCLASE.DataSource = null;
            dgvSUBCLASE.DataSource = cSubclase.obtenerSubClaseNombre(txtSUBCLASE.Text);

        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            MATERIALES.CLASE2 frm = new MATERIALES.CLASE2(new MODELO.Subclase(), "A");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvSUBCLASE.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una subclase");
                return;
            }
            MODELO.Subclase oClase = (MODELO.Subclase)dgvSUBCLASE.CurrentRow.DataBoundItem;
            MATERIALES.CLASE2 frm = new MATERIALES.CLASE2(oClase, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvSUBCLASE.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una subclase");
                return;
            }
            MODELO.Subclase oClase = (MODELO.Subclase)dgvSUBCLASE.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar " + oClase.NOMBRE + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cSubclase.eliminarSubClase(oClase);
                ARMO_GRILLA();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvSUBCLASE.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una subclase");
                return;
            }
            MODELO.Subclase oClase = (MODELO.Subclase)dgvSUBCLASE.CurrentRow.DataBoundItem;
            MATERIALES.CLASE2 frm = new MATERIALES.CLASE2(oClase, "C");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void txtSUBCLASE_TextChanged(object sender, EventArgs e)
        {
            if (txtSUBCLASE.TextLength > 0 || txtSUBCLASE.TextLength == 0) ARMO_GRILLA();
        }

        private void dgvSUBCLASE_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSUBCLASE.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad");
                return;
            }
            oSUBCLASE = (MODELO.Subclase)dgvSUBCLASE.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }

        private void Subclase_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
