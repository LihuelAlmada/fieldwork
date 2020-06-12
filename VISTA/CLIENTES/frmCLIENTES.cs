using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.CLIENTES
{
    public partial class frmCLIENTES : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cCliente cCliente;
        MODELO.Cliente oCLIENTE;
        public MODELO.Cliente ClienteSelect
        {
            get{ return oCLIENTE; }
        }
        public frmCLIENTES()
        {
            InitializeComponent();
            cCliente = CONTROLADORA.cCliente.obtener_instancia();
            ARMO_COMBO();
            ARMO_GRILLA();
        }

       
        public void ARMO_COMBO()
        {
            cmbLOCALIDAD.DataSource = null;
            cmbLOCALIDAD.DataSource = cCliente.obtenerLocalidades(true);
            foreach (MODELO.Localidad Localidad in cmbLOCALIDAD.Items)
            {
                if (Localidad.ToString() == "Todos") cmbLOCALIDAD.SelectedItem = Localidad;
            }
        }
        public void ARMO_GRILLA()
        {
            dgvCLIENTES.DataSource = null;

            if (((MODELO.Localidad)cmbLOCALIDAD.SelectedItem).nombre == "Todos")
            {
                dgvCLIENTES.DataSource = cCliente.obtenerClientesAll(txtAPELLIDO.Text, txtRAZONSOCIAL.Text);
            }
            else
            {
                dgvCLIENTES.DataSource = cCliente.obtenerClientes(txtAPELLIDO.Text, txtRAZONSOCIAL.Text, (MODELO.Localidad)cmbLOCALIDAD.SelectedItem);
            }

        }

        private void BtnAGREGAR_Click(object sender, EventArgs e)
        {
            frmCLIENTE frm = new frmCLIENTE(new MODELO.Cliente(), "A");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void TxtRAZONSOCIAL_TextChanged(object sender, EventArgs e)
        {
            if (txtRAZONSOCIAL.TextLength > 0 || txtRAZONSOCIAL.TextLength == 0) ARMO_GRILLA();
        }

        private void CmbLOCALIDAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ARMO_GRILLA();
            txtRAZONSOCIAL.Text = "";
            txtAPELLIDO.Text = "";
        }

        private void TxtAPELLIDO_TextChanged(object sender, EventArgs e)
        {
            if (txtAPELLIDO.TextLength > 0 || txtAPELLIDO.TextLength == 0) ARMO_GRILLA();
        }

        private void BtnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo");
                return;
            }
            MODELO.Cliente oCliente = (MODELO.Cliente)dgvCLIENTES.CurrentRow.DataBoundItem;
            frmCLIENTE frm = new frmCLIENTE(oCliente, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void BtnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo");
                return;
            }
            MODELO.Cliente oCliente = (MODELO.Cliente)dgvCLIENTES.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar " + oCliente.nombre + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cCliente.eliminarCliente(oCliente);
                ARMO_GRILLA();
            }
        }

        private void BtnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo");
                return;
            }
            MODELO.Cliente oCliente = (MODELO.Cliente)dgvCLIENTES.CurrentRow.DataBoundItem;
            frmCLIENTE frm = new frmCLIENTE(oCliente, "C");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void TxtRAZONSOCIAL_TextChanged_1(object sender, EventArgs e)
        {
            if (txtRAZONSOCIAL.TextLength > 0 || txtRAZONSOCIAL.TextLength == 0) ARMO_GRILLA();
        }

        private void dgvCLIENTES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Cliente");
                return;
            }
            oCLIENTE = (MODELO.Cliente)dgvCLIENTES.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }
    }
}
