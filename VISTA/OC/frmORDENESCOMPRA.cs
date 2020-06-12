using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.OC
{
    public partial class frmORDENESCOMPRA : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cProveedor cProveedor;
        CONTROLADORA.cOrdenCompra cCOMPRA;
        MODELO.Factura oOcompra;
        CONTROLADORA.cAuditoria cAuditoria;
        public MODELO.Factura OrdenSelec
        {
            get { return oOcompra; }
        }
        public frmORDENESCOMPRA()
        {
            InitializeComponent();
            cCOMPRA = CONTROLADORA.cOrdenCompra.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            cProveedor = CONTROLADORA.cProveedor.obtener_instancia();
            ARMA_GRILLA();
            btnELIMINAR.Enabled = false;
        }
        public void ARMA_GRILLA()
        {
            dgvORDENESCOMPRA.DataSource = null;
            dgvORDENESCOMPRA.DataSource = cCOMPRA.obtenerOrden("");
            for (int i = 0; i < dgvORDENESCOMPRA.Columns.Count; i++)
            {
                dgvORDENESCOMPRA.Columns[i].Visible = false;
            }

            dgvORDENESCOMPRA.Columns["Localidad"].Visible = true;
            dgvORDENESCOMPRA.Columns["NroOrden"].Visible = true;
            dgvORDENESCOMPRA.Columns["Proveedor"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha_Recepcion"].Visible = true;
            dgvORDENESCOMPRA.Columns["Importe"].Visible = true;
        }

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            OC.frmORDEN_COMPRA frm = new frmORDEN_COMPRA();
           
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) 
                ARMA_GRILLA();

            





            //ARMO_GRILLA();new MODELO.OrdenCompra(), "A")
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvORDENESCOMPRA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un rubro");
                return;
            }
            MODELO.Factura oORDEN = (MODELO.Factura)dgvORDENESCOMPRA.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar " + oORDEN.NroOrden + "?", "CONFIRMA", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {

                MODELO.AuditoriaOC oAuditoria = new MODELO.AuditoriaOC();
                oAuditoria.FechayHora = System.DateTime.Now;
                oAuditoria.Movimiento = "Baja";
                oAuditoria.Username = "SuperUsuario";

                oAuditoria.NroOrden = oORDEN.NroOrden;
                oAuditoria.Proveedor = oORDEN.Proveedor;


                cAuditoria.AGREGAR_AUDITORIA(oAuditoria);


                cCOMPRA.eliminarOrden(oORDEN);
                ARMA_GRILLA();
            }
        }

        private void dgvORDENESCOMPRA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void ARMO_GRILLA()
        {
            dgvORDENESCOMPRA.DataSource = null;
            dgvORDENESCOMPRA.DataSource = cCOMPRA.SuperFiltro(dtpInicio.Value, dtpRecepcion.Value, txtPROVEEDOR.Text);

            for (int i = 0; i < dgvORDENESCOMPRA.Columns.Count; i++)
            {
                dgvORDENESCOMPRA.Columns[i].Visible = false;
            }

            dgvORDENESCOMPRA.Columns["Localidad"].Visible = true;
            dgvORDENESCOMPRA.Columns["NroOrden"].Visible = true;
            dgvORDENESCOMPRA.Columns["Proveedor"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha_Recepcion"].Visible = true;
            dgvORDENESCOMPRA.Columns["Importe"].Visible = true;

        }
        public void ARMO_GRILLAA()
        {
            dgvORDENESCOMPRA.DataSource = null;
            dgvORDENESCOMPRA.DataSource = cCOMPRA.SuperFiltro(dtpInicio.Value, dtpRecepcion.Value, txtPROVEEDOR.Text);

            for (int i = 0; i < dgvORDENESCOMPRA.Columns.Count; i++)
            {
                dgvORDENESCOMPRA.Columns[i].Visible = false;
                
            }

            dgvORDENESCOMPRA.Columns["Localidad"].Visible = true;
            dgvORDENESCOMPRA.Columns["NroOrden"].Visible = true;
            dgvORDENESCOMPRA.Columns["Proveedor"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha_Recepcion"].Visible = true;
            dgvORDENESCOMPRA.Columns["Importe"].Visible = true;

        }
        private void dgvORDENESCOMPRA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvORDENESCOMPRA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una OC");
                return;
            }
            oOcompra = (MODELO.Factura)dgvORDENESCOMPRA.CurrentRow.DataBoundItem;

            if (oOcompra.visibily == false)
            {
                MessageBox.Show("Esta orden de compra, ya se encuentra completa, por favor realize una nueva orden de compra");
                return;
            }
            

            this.DialogResult = DialogResult.OK;
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvORDENESCOMPRA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden de compra");
                return;
            }
            MODELO.Factura oORDEN = (MODELO.Factura)dgvORDENESCOMPRA.CurrentRow.DataBoundItem;
            OC.frmORDEN_COMPRA frm = new OC.frmORDEN_COMPRA(oORDEN, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_GRILLA();
        }

        private void txtPROVEEDOR_TextChanged(object sender, EventArgs e)
        {
            if (txtPROVEEDOR.TextLength > 0 || txtPROVEEDOR.TextLength == 0) ARMO_GRILLA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void dtpRecepcion_ValueChanged(object sender, EventArgs e)
        {
            dgvORDENESCOMPRA.DataSource = null;
            dgvORDENESCOMPRA.DataSource = cCOMPRA.SuperFiltro(dtpInicio.Value, dtpRecepcion.Value, txtPROVEEDOR.Text);


            for (int i = 0; i < dgvORDENESCOMPRA.Columns.Count; i++)
            {
                dgvORDENESCOMPRA.Columns[i].Visible = false;
            }

            dgvORDENESCOMPRA.Columns["Localidad"].Visible = true;
            dgvORDENESCOMPRA.Columns["NroOrden"].Visible = true;
            dgvORDENESCOMPRA.Columns["Proveedor"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha_Recepcion"].Visible = true;
            dgvORDENESCOMPRA.Columns["Importe"].Visible = true;
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            dgvORDENESCOMPRA.DataSource = null;
            dgvORDENESCOMPRA.DataSource = cCOMPRA.SuperFiltro(dtpInicio.Value, dtpRecepcion.Value, txtPROVEEDOR.Text);


            for (int i = 0; i < dgvORDENESCOMPRA.Columns.Count; i++)
            {
                dgvORDENESCOMPRA.Columns[i].Visible = false;
            }

            dgvORDENESCOMPRA.Columns["Localidad"].Visible = true;
            dgvORDENESCOMPRA.Columns["NroOrden"].Visible = true;
            dgvORDENESCOMPRA.Columns["Proveedor"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha"].Visible = true;
            dgvORDENESCOMPRA.Columns["Fecha_Recepcion"].Visible = true;
            dgvORDENESCOMPRA.Columns["Importe"].Visible = true;
        }
    }
}
