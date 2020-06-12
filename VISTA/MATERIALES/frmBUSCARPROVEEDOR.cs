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
    public partial class frmBUSCARPROVEEDOR : MetroFramework.Forms.MetroForm
    {
        string nombreproveedor;
        MODELO.Proveedor oPROVEEDOR;
        public MODELO.Proveedor ProveedorSelect {
            get { return oPROVEEDOR; }
        }
        CONTROLADORA.cProveedor cProveedor;
        public frmBUSCARPROVEEDOR()
        {
            InitializeComponent();
            cProveedor = CONTROLADORA.cProveedor.obtener_instancia();
            
            ARMO_GRILLA();
        }

        public void ARMO_GRILLA()
        {
            dgvPROVEEDORES.DataSource = null;
            dgvPROVEEDORES.DataSource = cProveedor.obtenerProveedorNombre(txtNOMBREPROVEEDOR.Text); 
        }

        private void txtNOMBREPROVEEDOR_TextChanged(object sender, EventArgs e)
        {
            if (txtNOMBREPROVEEDOR.TextLength > 0 || txtNOMBREPROVEEDOR.TextLength == 0) ARMO_GRILLA();
        }

        

        private void btnGUARDAR_Click(object sender, EventArgs e)
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
