using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.VENTAS
{
    public partial class frmVENTAS : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cOrdenVenta cVENTA;
        CONTROLADORA.cAuditoria cAUDITORIA;
        public frmVENTAS()
        {
            InitializeComponent();
            cVENTA = CONTROLADORA.cOrdenVenta.obtener_instancia();
            cAUDITORIA = CONTROLADORA.cAuditoria.obtenerInstancia();
            ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            dgvVENTAS.DataSource = null;
            dgvVENTAS.DataSource = cVENTA.obtenerOrdenVenta("");


            dgvVENTAS.Columns["IvaTotal"].Visible = false;
            dgvVENTAS.Columns["DescuentoTotal"].Visible = false;
            dgvVENTAS.Columns["codigo"].Visible = false;
            dgvVENTAS.Columns["visibily"].Visible = false;
            //dgvVENTAS.Columns["Cantidad"].Visible = false;
            //dgvVENTAS.Columns["PUC"].Visible = false;
            //dgvVENTAS.Columns["Iva"].Visible = false;
            //dgvVENTAS.Columns["UnidadMedida"].Visible = false;
            //dgvORDENESCOMPRA.Columns["Proveedor"].Visible = true;
            //dgvORDENESCOMPRA.Columns["Fecha"].Visible = true;
            //dgvORDENESCOMPRA.Columns["Fecha_Recepcion"].Visible = true;
            //dgvORDENESCOMPRA.Columns["Importe"].Visible = true;
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            VENTAS.frmVENTA frm = new frmVENTA();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) ;
            ARMA_GRILLA();

           
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvVENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una venta");
                return;
            }
            MODELO.Venta oVENTA = (MODELO.Venta)dgvVENTAS.CurrentRow.DataBoundItem;
            VENTAS.frmVENTA frm = new VENTAS.frmVENTA(oVENTA, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {

            if (dgvVENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una venta");
                return;
            }
            MODELO.Venta oVENTA = (MODELO.Venta)dgvVENTAS.CurrentRow.DataBoundItem;
            cVENTA.eliminarOrdenVenta(oVENTA);

            MODELO.AuditoriaVenta oAuditoria = new MODELO.AuditoriaVenta();
            oAuditoria.FechayHora = System.DateTime.Now;
            oAuditoria.Movimiento = "Baja";
            oAuditoria.Username = "SuperUsuario";
            oAuditoria.codigo = oVENTA.codigo;
            oAuditoria.nroFactura = oVENTA.nroFactura;
            oAuditoria.Cliente = oVENTA.Cliente;
            oAuditoria.Fecha = oVENTA.Fecha;
            oAuditoria.Importe = oVENTA.Importe;
            oAuditoria.IvaTotal = oVENTA.IvaTotal;
            oAuditoria.DescuentoTotal = oVENTA.DescuentoTotal;
            cAUDITORIA.AGREGAR_AUDITORIA(oAuditoria);
        }
    }
}
