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
    public partial class frmMATERIALES : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cAuditoria cAuditoria;
        CONTROLADORA.cProveedor cProveedor;
        CONTROLADORA.cClase cClase;
        CONTROLADORA.cSubclase cSubClase;
        CONTROLADORA.cMateriales cMateriales;
        MODELO.Materiales oMaterial;
        string accionaux;


        public frmMATERIALES(string accion)
        {
            InitializeComponent();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cClase = CONTROLADORA.cClase.obtener_instancia();
            cSubClase = CONTROLADORA.cSubclase.obtener_instancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            accionaux = accion;
           ARMO_COMBO_PROVEEDOR();
            //ARMO_COMBO2();
            ARMO_GRILLA();
        }

        public void ARMO_COMBO_PROVEEDOR()
        {
            cmbPROVEEDOR.DataSource = null;
            cmbPROVEEDOR.DataSource = cMateriales.obtenerProveedores(true);

            foreach (MODELO.Proveedor Proveedor in cmbPROVEEDOR.Items)
            {
                if (Proveedor.ToString() == "Todos") cmbPROVEEDOR.SelectedItem = Proveedor;
            }

        }

        public void ARMO_GRILLA()
        {
            dgvMATERIALES.DataSource = null;
            dgvMATERIALES.DataSource = cMateriales.obtenerMaterialNombre(txtDESCRIPCIONCORTA.Text);
            if (((MODELO.Proveedor)cmbPROVEEDOR.SelectedItem).razonSocial == "Todos")
            {
                //dgvMATERIALES.DataSource = cMateriales.obtenerMaterialesAll(txtDESCRIPCIONCORTA.Text, txtCODIGO.Text, txtCLASES.Text, txtSUBCLASE.Text);
            }
            else
            {
                //dgvMATERIALES.DataSource = cMateriales.obtenerMateriales(txtDESCRIPCIONCORTA.Text, txtCODIGO.Text, txtCLASES.Text, txtSUBCLASE.Text, (MODELO.Proveedor)cmbPROVEEDOR.SelectedItem);
            }

        }

        public void ARMO_GRILLA_CODIGO()
        {
            //cmbPROVEEDOR.DataSource = null;
            //cmbPROVEEDOR.DataSource = cMateriales.obtener(txtCODIGO.Text);

        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            MATERIALES.frmMATERIAL frm = new MATERIALES.frmMATERIAL(new MODELO.Materiales(), "A");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvMATERIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un material");
                return;
            }
            MODELO.Materiales oMATERIAL = (MODELO.Materiales)dgvMATERIALES.CurrentRow.DataBoundItem;
            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar " + oMATERIAL.DESCRIPCION_LARGA + "?", "CONFIRMA", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MODELO.AuditoriaMateriales oAuditoria = new MODELO.AuditoriaMateriales();
                oAuditoria.FechayHora = System.DateTime.Now;
                oAuditoria.Movimiento = "Baja";
                oAuditoria.Username = "SuperUsuario";
                oAuditoria.COD_MATERIAL = oMATERIAL.COD_MATERIAL;
                oAuditoria.DESCRIPCION_CORTA = oMATERIAL.DESCRIPCION_CORTA;
                oAuditoria.DESCRIPCION_LARGA = oMATERIAL.DESCRIPCION_LARGA;
                oAuditoria.ULTIMA_MODIFICACION = oMATERIAL.ULTIMA_MODIFICACION;
                oAuditoria.PUC = oMATERIAL.PUC;
                oAuditoria.MAXIMO = oMATERIAL.MAXIMO;
                oAuditoria.MINIMO = oMATERIAL.MINIMO;
                //oAuditoria.CLASE = oMATERIAL.CLASE;
             //   oAuditoria.SUBCLASE = oMATERIAL.SUBCLASE;
            //    oAuditoria.PROVEEDOR = oMATERIAL.PROVEEDOR;
                oAuditoria.GANANCIA = oMATERIAL.GANANCIA;
       ////         oAuditoria.IVA = oMATERIAL.IVA;
                oAuditoria.STOCK = oMATERIAL.STOCK;
                cAuditoria.AGREGAR_AUDITORIA(oAuditoria);
                cMateriales.eliminarMateriales(oMATERIAL);
                ARMO_GRILLA();
            }
        }

        private void lblMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvMATERIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo");
                return;
            }
            MODELO.Materiales oMateriales = (MODELO.Materiales)dgvMATERIALES.CurrentRow.DataBoundItem;
            MATERIALES.frmMATERIAL frm = new MATERIALES.frmMATERIAL(oMateriales, "M");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvMATERIALES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo");
                return;
            }
            MODELO.Materiales oPROVEEDOR = (MODELO.Materiales)dgvMATERIALES.CurrentRow.DataBoundItem;
            MATERIALES.frmMATERIAL frm = new MATERIALES.frmMATERIAL(oPROVEEDOR, "C");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
                ARMO_GRILLA();
        }

        private void cmbPROVEEDOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ARMO_GRILLA();
        }

        private void txtDESCRIPCIONCORTA_TextChanged(object sender, EventArgs e)
        {
            if (txtDESCRIPCIONCORTA.TextLength > 0 || txtDESCRIPCIONCORTA.TextLength == 0) ARMO_GRILLA();
        }

        private void txtCODIGO_TextChanged(object sender, EventArgs e)
        {
            if (txtCODIGO.TextLength > 0 || txtCODIGO.TextLength == 0) ARMO_GRILLA();
        }

        private void txtCLASES_TextChanged(object sender, EventArgs e)
        {
            if (txtCLASES.TextLength > 0 || txtCLASES.TextLength == 0) ARMO_GRILLA();
        }

        private void txtSUBCLASE_TextChanged(object sender, EventArgs e)
        {
            if (txtSUBCLASE.TextLength > 0 || txtSUBCLASE.TextLength == 0) ARMO_GRILLA();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Lupa materiales
        private void dgvMATERIALES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accionaux == "Buscar")
            {
                if (dgvMATERIALES.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un material");
                    return;
                }
                 oMaterial = (MODELO.Materiales)dgvMATERIALES.CurrentRow.DataBoundItem;

                this.DialogResult = DialogResult.OK;
            }
            
        }

        public MODELO.Materiales MaterialSelect
        {
            get { return oMaterial; }
        }
        #endregion
    }
}
