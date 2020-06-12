using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.PROVEEDORES
{
    public partial class PROVEEDORES : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cProveedor cProveedor;
        MODELO.Proveedor oPROVEEDOR;
        public MODELO.Proveedor ProveedorSelect
        {
            get { return oPROVEEDOR; }
        }

        public PROVEEDORES()
        {
            InitializeComponent();
            cProveedor = CONTROLADORA.cProveedor.obtener_instancia();
            ARMO_COMBO();
            ARMO_GRILLA();
            
        }
        public PROVEEDORES(string accion)
        {
            InitializeComponent();
            cProveedor = CONTROLADORA.cProveedor.obtener_instancia();
            ARMO_COMBO();
            ARMO_GRILLA();
            
        }



        public void ARMO_COMBO()
        {
            cmbLOCALIDAD.DataSource = null;
            cmbLOCALIDAD.DataSource = cProveedor.obtenerLocalidades(true);
            foreach (MODELO.Localidad Localidad in cmbLOCALIDAD.Items)
            {
                if (Localidad.ToString() == "Todos") cmbLOCALIDAD.SelectedItem = Localidad;
            }
        }

        public void ARMO_GRILLA()
        {
            dgvPROVEEDORES.DataSource = null;

            if (((MODELO.Localidad)cmbLOCALIDAD.SelectedItem).nombre == "Todos")
            {
                dgvPROVEEDORES.DataSource = cProveedor.obtenerProveedoresAll(txtPROVEEDOR.Text, txtRAZONSOCIAL.Text);
            }
            else
            {
                dgvPROVEEDORES.DataSource = cProveedor.obtenerProveedores(txtPROVEEDOR.Text, txtRAZONSOCIAL.Text, (MODELO.Localidad)cmbLOCALIDAD.SelectedItem);
            }

        }

        //private void btnAGREGAR_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void btnMODIFICAR_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void btnELIMINAR_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void txtPROVEEDOR_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void btnCONSULTAR_Click(object sender, EventArgs e)
        //{
           
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtRAZONSOCIAL.TextLength > 0 || txtRAZONSOCIAL.TextLength == 0) ARMO_GRILLA();

        }

        private void cmbLOCALIDAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ARMO_GRILLA();
            txtRAZONSOCIAL.Text = "";
            txtPROVEEDOR.Text = "";
        }

        private void btnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtRAZONSOCIAL_TextChanged(object sender, EventArgs e)
        {
            if (txtRAZONSOCIAL.TextLength > 0 || txtRAZONSOCIAL.TextLength == 0) ARMO_GRILLA();
        }

        private void cmbLOCALIDAD_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ARMO_GRILLA();
            txtRAZONSOCIAL.Text = "";
            txtPROVEEDOR.Text = "";
        }

        private void BtnAGREGAR_Click_1(object sender, EventArgs e)
        {
            PROVEEDOR frm = new PROVEEDOR(new MODELO.Proveedor(), "A");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void BtnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo");
                return;
            }
            MODELO.Proveedor oPROVEEDOR = (MODELO.Proveedor)dgvPROVEEDORES.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar " + oPROVEEDOR.nombre + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cProveedor.eliminarProveedor(oPROVEEDOR);
                ARMO_GRILLA();
            }
        }

        private void BtnCONSULTAR_Click_2(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo");
                return;
            }
            MODELO.Proveedor oPROVEEDOR = (MODELO.Proveedor)dgvPROVEEDORES.CurrentRow.DataBoundItem;
            PROVEEDOR frm = new PROVEEDOR(oPROVEEDOR, "C");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void BtnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo");
                return;
            }
            MODELO.Proveedor oPROVEEDOR = (MODELO.Proveedor)dgvPROVEEDORES.CurrentRow.DataBoundItem;
            PROVEEDOR frm = new PROVEEDOR(oPROVEEDOR, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void TxtRAZONSOCIAL_TextChanged_1(object sender, EventArgs e)
        {
            if (txtRAZONSOCIAL.TextLength > 0 || txtRAZONSOCIAL.TextLength == 0) ARMO_GRILLA();
        }

        private void TxtPROVEEDOR_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPROVEEDOR.TextLength > 0 || txtPROVEEDOR.TextLength == 0) ARMO_GRILLA();
        }

        private void CmbLOCALIDAD_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            ARMO_GRILLA();
            txtRAZONSOCIAL.Text = "";
            txtPROVEEDOR.Text = "";
        }

        private void DgvPROVEEDORES_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }
            oPROVEEDOR = (MODELO.Proveedor)dgvPROVEEDORES.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }

        private void dgvPROVEEDORES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPROVEEDORES_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPROVEEDORES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }
            oPROVEEDOR = (MODELO.Proveedor)dgvPROVEEDORES.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }
    }
}
