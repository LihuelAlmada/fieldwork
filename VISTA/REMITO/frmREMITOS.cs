using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.REMITO
{
    public partial class frmREMITOS : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cOccantmat cOccantmat;
        CONTROLADORA.cRemito cREMITO;
        CONTROLADORA.cAuditoria cAuditoria;
        public frmREMITOS()
        {
            InitializeComponent();
            cREMITO = CONTROLADORA.cRemito.obtener_instancia();
            cOccantmat = CONTROLADORA.cOccantmat.obtener_instancia();
            ARMA_GRILLA();
            btnELIMINAR.Enabled = false;
        }

        public void ARMA_GRILLA()
        {
            dgvREMITOS.DataSource = null;
            dgvREMITOS.DataSource = cREMITO.obtenerRemito("");
            dgvREMITOS.Columns["codigo"].Visible = false;
            dgvREMITOS.Columns["OrdenDeCompra"].Visible = false;
            dgvREMITOS.Columns["Fecha"].Visible = false;
            dgvREMITOS.Columns["Localidad"].Visible = false;
            dgvREMITOS.Columns["Cantidad"].Visible = false;
            //dgvREMITOS.Columns[i].Visible = true;

            // dgvREMITOS.Columns["Cantidad"].Visible = false;
            dgvREMITOS.Columns["Proveedor"].Visible = true;
            //dgvREMITOS.Columns["Cliente"].Visible = false;

        }
        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            REMITO.frm_REMITO frm = new frm_REMITO();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvREMITOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un remito");
                return;
            }
            MODELO.Remito oREMITO = (MODELO.Remito)dgvREMITOS.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar " + oREMITO.NroRemito + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cREMITO.eliminarRemito(oREMITO);
                ARMA_GRILLA();


            MODELO.AuditoriaRemito oAuditoria = new MODELO.AuditoriaRemito();
            oAuditoria.FechayHora = System.DateTime.Now;
            oAuditoria.Movimiento = "Baja";
            oAuditoria.Username = "SuperUsuario";
            /*oAuditoria.NroRemito = oREMITO.NroRemito;
            oAuditoria.codigo = oREMITO.codigo;
            oAuditoria.Proveedor = oREMITO.Proveedor;
            oAuditoria.Localidad = oREMITO.Localidad;
            oAuditoria.OrdenDeCompra = oREMITO.OrdenDeCompra;
            oAuditoria.Fecha = oREMITO.Fecha;
            oAuditoria.Cantidad = oREMITO.Cantidad;
            oAuditoria.CalifCantidad = oREMITO.CalifCantidad;
            oAuditoria.CalifTiempo = oREMITO.CalifTiempo;
            cAuditoria.AGREGAR_AUDITORIAREMITO(oAuditoria);*/
        

    }


        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvREMITOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un remito");
                return;
            }
            MODELO.Remito oREMITO = (MODELO.Remito)dgvREMITOS.CurrentRow.DataBoundItem;
            REMITO.frm_REMITO frm = new REMITO.frm_REMITO(oREMITO, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_GRILLA();
        }

        private void txtPROVEEDOR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
