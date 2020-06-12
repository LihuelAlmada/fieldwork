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
    public partial class Clase : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cClase cClase;
        MODELO.Clase oCLASE;
        public MODELO.Clase ClaseSelect
        {
            get { return oCLASE; }
        }
        public Clase()
        {
            InitializeComponent();
            cClase = CONTROLADORA.cClase.obtener_instancia();
            ARMO_GRILLA();
            
        }

        public Clase(string accion)
        {
            InitializeComponent();
            cClase = CONTROLADORA.cClase.obtener_instancia();
            //ARMO_COMBO();
            ARMO_GRILLA();
            
        }


        public void ARMO_GRILLA()
        {
            dgvCIUDADES.DataSource = null;
            dgvCIUDADES.DataSource = cClase.obtenerClaseNombre(txtNOMBRE.Text);
        }

        

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una clase");
                return;
            }
            MODELO.Clase oClase = (MODELO.Clase)dgvCIUDADES.CurrentRow.DataBoundItem;
            MATERIALES.CLASE1 frm = new MATERIALES.CLASE1(oClase, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una clase");
                return;
            }
            MODELO.Clase oClase = (MODELO.Clase)dgvCIUDADES.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar " + oClase.NOMBRE + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cClase.eliminarClase(oClase);
                ARMO_GRILLA();
            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una clase");
                return;
            }
            MODELO.Clase oClase = (MODELO.Clase)dgvCIUDADES.CurrentRow.DataBoundItem;
            MATERIALES.CLASE1 frm = new MATERIALES.CLASE1(oClase, "C");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void btnAGREGAR2_Click(object sender, EventArgs e)
        {
            MATERIALES.CLASE1 frm = new MATERIALES.CLASE1(new MODELO.Clase(), "A");

            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void txtNOMBRE_TextChanged(object sender, EventArgs e)
        {
            if (txtNOMBRE.TextLength > 0 || txtNOMBRE.TextLength == 0) ARMO_GRILLA();
        }

        private void dgvCIUDADES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCIUDADES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad");
                return;
            }
            oCLASE = (MODELO.Clase)dgvCIUDADES.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }
    }
}
