using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMUN;

//MODELO.Proveedor unProveedor;
namespace VISTA.MATERIALES
{
    public partial class frmMATERIAL : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cMateriales cMateriales;
        MODELO.Materiales oMateriales;
        CONTROLADORA.cClase cClase;
        CONTROLADORA.cSubclase cSubclase;
        CONTROLADORA.cProveedor cProveedor;
        CONTROLADORA.cAuditoria cAuditoria;
        MODELO.Proveedor oPROVEEDOR;
        MODELO.Clase oCLASE;
        MODELO.Subclase oSUBCLASE;
        
        string accion;

        public frmMATERIAL(string unaaccion)
        {
            InitializeComponent();
            cProveedor = CONTROLADORA.cProveedor.obtener_instancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cClase = CONTROLADORA.cClase.obtener_instancia();
            cSubclase = CONTROLADORA.cSubclase.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            accion = unaaccion;
            txtPROVEEDOR.Enabled = false;
            txtCLASE.Enabled = false;
            txtSUBCLASE.Enabled = false;
            dateTimePicker1.Enabled = false;
            ARMO_PROVEEDOR();
            ARMO_CLASE();
            ARMO_SUBCLASE();
            //cmbPROVEEDOR.Visible = false;
        }
        string nombre;
        public frmMATERIAL(MODELO.Proveedor unProveedor)
        {
            oPROVEEDOR = unProveedor;
            nombre = oPROVEEDOR.nombre;
            txtPROVEEDOR.Text = oPROVEEDOR.nombre;
            //cmbPROVEEDOR.Text= oPROVEEDOR.nombre;
            //cmbPROVEEDOR.Visible = false;
            txtCLASE.Enabled = false;
            txtSUBCLASE.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        public frmMATERIAL(MODELO.Materiales unMaterial, string unaaccion)
        {
            InitializeComponent();
            cProveedor = CONTROLADORA.cProveedor.obtener_instancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cClase = CONTROLADORA.cClase.obtener_instancia();
            cSubclase = CONTROLADORA.cSubclase.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            oMateriales = unMaterial;
            accion = unaaccion;
            //cmbPROVEEDOR.Visible = false;
            txtPROVEEDOR.Enabled = false;
            txtCLASE.Enabled = false;
            txtSUBCLASE.Enabled = false;
            dateTimePicker1.Enabled = false;
            ARMO_PROVEEDOR();
            ARMO_CLASE();
            ARMO_SUBCLASE();
            if (accion != "A")
            {

                txtCODIGO.Text = oMateriales.COD_MATERIAL;
                txtDESCRIPCION_CORTA.Text = oMateriales.DESCRIPCION_CORTA;
                txtDESCRIPCION_LARGA.Text = oMateriales.DESCRIPCION_LARGA;
                txtMAXIMO.Text = oMateriales.MAXIMO.ToString();
                txtPUC.Text = oMateriales.PUC.ToString();
                txtSTOCK.Text = oMateriales.STOCK.ToString();
                txtPROVEEDOR.Text = oMateriales.PROVEEDOR.ToString();
                cmbIVA.Text = oMateriales.IVA.ToString();
                txtGANANCIA.Text = oMateriales.GANANCIA.ToString();
                txtMINIMO.Text = oMateriales.MINIMO.ToString();
                cmbIVA.Text = oMateriales.IVA.ToString();
                txtCLASE.Text = oMateriales.CLASE.ToString();
                cmbMEDIDA.Text = oMateriales.MEDIDA.ToString();
                txtSUBCLASE.Text = oMateriales.SUBCLASE.ToString();
                cmbMEDIDA.Text = oMateriales.MEDIDA;

                if (accion == "C")
                {
                    txtCODIGO.Enabled = false;
                    txtDESCRIPCION_CORTA.Enabled = false;
                    txtDESCRIPCION_LARGA.Enabled = false;
                    txtMAXIMO.Enabled = false;
                    txtPUC.Enabled = false;
                    txtSTOCK.Enabled = false;
                    //cmbCLASE.Enabled = false;
                    //cmbPROVEEDOR.Enabled = false;
                    //cmbSUBCLASE.Enabled = false;
                    txtGANANCIA.Enabled = false;
                    txtMINIMO.Enabled = false;
                    txtPROVEEDOR.Enabled = false;
                    txtCLASE.Enabled = false;
                    txtSUBCLASE.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    cmbIVA.Enabled = false;
                    btnLUPA.Enabled = false;
                    cmbMEDIDA.Enabled = false;
                    btnLUPA.Enabled = false;
                    btnLUPAclase.Enabled = false;
                    btnLUPAsubclase.Enabled = false;
                }

            }
        }

        public void ARMO_CLASE()
        {
            //cmbCLASE.DataSource = null;
           // cmbCLASE.DataSource = cClase.obtenerClaseNombre();
        }
        public void ARMO_SUBCLASE()
        {
            //cmbSUBCLASE.DataSource = null;
            //cmbSUBCLASE.DataSource = cSubclase.obtenerSubClaseNombre();
        }
        public void ARMO_PROVEEDOR()
        {
            //cmbPROVEEDOR.DataSource = null;
            //cmbPROVEEDOR.DataSource = cProveedor.obtenerProveedores();
        }


        private void BtnSALIR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGUARDAR_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCODIGO.Text))
            {
                MessageBox.Show("Debe ingresar un codigo");
                return;
            }

            if (string.IsNullOrEmpty(cmbMEDIDA.Text))
            {
                MessageBox.Show("Debe ingresar una medida");
                return;
            }

            if (string.IsNullOrEmpty(txtDESCRIPCION_CORTA.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion corta");
                return;
            }

            if (string.IsNullOrEmpty(txtPROVEEDOR.Text))
            {
                MessageBox.Show("Debe ingresar un proveedor");
                return;
            }

            if (string.IsNullOrEmpty(txtDESCRIPCION_LARGA.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion larga");
                return;
            }
            if (string.IsNullOrEmpty(txtPUC.Text))
            {
                MessageBox.Show("Debe ingresar un PUC valido");
                return;
            }
            if (string.IsNullOrEmpty(txtSTOCK.Text))
            {
                MessageBox.Show("Debe ingresar un stock valido");
                return;
            }

            if (string.IsNullOrEmpty(txtMAXIMO.Text))
            {
                MessageBox.Show("Debe ingresar un maximo");
                return;
            }
            if (string.IsNullOrEmpty(txtMINIMO.Text))
            {
                MessageBox.Show("Debe ingresar un minimo");
                return;
            }
            if (string.IsNullOrEmpty(txtGANANCIA.Text))
            {
                MessageBox.Show("Debe ingresar una ganancia valida");
                return;
            }
            if (string.IsNullOrEmpty(txtCLASE.Text))
            {
                MessageBox.Show("Debe elegir una clase");
                return;
            }
            if (string.IsNullOrEmpty(txtSUBCLASE.Text))
            {
                MessageBox.Show("Debe elegir una subclase");
                return;
            }
            if (Convert.ToInt32(txtGANANCIA.Text) > 100 || Convert.ToInt32(txtGANANCIA.Text) < 0)
            {
                MessageBox.Show("El numero de porcentaje ingresado es incorrecto");
                return;
            }
            if (Convert.ToInt32(txtMINIMO.Text)>= Convert.ToInt32(txtMAXIMO.Text))
            {
                MessageBox.Show("El stock minimo debe ser mayor o igual que el stock maximo");
                return;
            }
            if (string.IsNullOrEmpty(cmbIVA.Text))
            {
                MessageBox.Show("Debe elegir un iva");
                return;
            }

            oMateriales.COD_MATERIAL = txtCODIGO.Text;
            oMateriales.DESCRIPCION_CORTA = txtDESCRIPCION_CORTA.Text;
            oMateriales.DESCRIPCION_LARGA = txtDESCRIPCION_LARGA.Text;
            oMateriales.MAXIMO = Convert.ToInt32(txtMAXIMO.Text);
            oMateriales.MINIMO = Convert.ToInt32(txtMINIMO.Text);
            oMateriales.STOCK = Convert.ToInt32(txtSTOCK.Text);
            oMateriales.PUC = Convert.ToInt32(txtPUC.Text);
            oMateriales.IVA = double.Parse(cmbIVA.Text);
            //oMateriales.PROVEEDOR = (MODELO.Proveedor)txtPROVEEDOR.Text;
            oMateriales.PROVEEDOR = txtPROVEEDOR.Text;
            oMateriales.MEDIDA = cmbMEDIDA.Text;
            oMateriales.CLASE = txtCLASE.Text;
            oMateriales.SUBCLASE = txtSUBCLASE.Text;
            //oMateriales.PROVEEDOR = (MODELO.Proveedor)cmbPROVEEDOR.SelectedItem;
            //oMateriales.SUBCLASE = (MODELO.Subclase)cmbSUBCLASE.SelectedItem;
            //oMateriales.CLASE = (MODELO.Clase)cmbCLASE.SelectedItem;
            oMateriales.GANANCIA = Convert.ToInt32(txtGANANCIA.Text);
            oMateriales.ULTIMA_MODIFICACION = dateTimePicker1.Value;
            //oAuditoria.Permiso = ((MODELO.PERMISO)item).Descripcion;


            if (accion == "A"){ 
                cMateriales.agregarMateriales(oMateriales);
                AGREGAR_AUDITORIA("Alta",oMateriales);
            }
            else { 
        cMateriales.modificarMateriales(oMateriales);
                AGREGAR_AUDITORIA("Modificacion", oMateriales);
            }
            this.DialogResult = DialogResult.OK;
        }

        public void AGREGAR_AUDITORIA(string movimiento,MODELO.Materiales oMATERIAL)
        {
            MODELO.AuditoriaMateriales oAuditoria = new MODELO.AuditoriaMateriales();
            oAuditoria.FechayHora = System.DateTime.Now;
            oAuditoria.Movimiento = movimiento;
            oAuditoria.Username = "SuperUsuario";
            oAuditoria.COD_MATERIAL = oMATERIAL.COD_MATERIAL;
            oAuditoria.DESCRIPCION_CORTA = oMATERIAL.DESCRIPCION_CORTA;
            oAuditoria.DESCRIPCION_LARGA = oMATERIAL.DESCRIPCION_LARGA;
            oAuditoria.ULTIMA_MODIFICACION = oMATERIAL.ULTIMA_MODIFICACION;
            oAuditoria.PUC = oMATERIAL.PUC;
            oAuditoria.MAXIMO = oMATERIAL.MAXIMO;
            oAuditoria.MINIMO = oMATERIAL.MINIMO;
      //      oAuditoria.CLASE = oMATERIAL.CLASE;
        //    oAuditoria.SUBCLASE = oMATERIAL.SUBCLASE;
        //    oAuditoria.PROVEEDOR = oMATERIAL.PROVEEDOR;
            oAuditoria.GANANCIA = oMATERIAL.GANANCIA;
     /////       oAuditoria.IVA = oMATERIAL.IVA;
            oAuditoria.STOCK = oMATERIAL.STOCK;
            cAuditoria.AGREGAR_AUDITORIA(oAuditoria);
        }

        private void btnLUPA_Click(object sender, EventArgs e)
        {
            PROVEEDORES.PROVEEDORES frm = new PROVEEDORES.PROVEEDORES("Buscar");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oPROVEEDOR = frm.ProveedorSelect;
                txtPROVEEDOR.Text = oPROVEEDOR.razonSocial;
                //cmbPROVEEDOR.SelectedItem = oPROVEEDOR;
            }
        }

        private void txtSTOCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void txtGANANCIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void txtMAXIMO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void txtMINIMO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtDESCRIPCION_CORTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloLetras(e, oMateriales.DESCRIPCION_CORTA);
        }

        private void txtDESCRIPCION_LARGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloLetras(e, oMateriales.DESCRIPCION_LARGA);
        }

        private void txtPUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);

        }

        private void LblPUC_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnLUPAclase_Click(object sender, EventArgs e)
        {
            MATERIALES.Clase frm = new MATERIALES.Clase("Buscar");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oCLASE = frm.ClaseSelect;
                txtCLASE.Text = oCLASE.NOMBRE;
                //cmbPROVEEDOR.SelectedItem = oPROVEEDOR;
            }
        }

        private void btnLUPAsubclase_Click(object sender, EventArgs e)
        {
            MATERIALES.Subclase frm = new MATERIALES.Subclase("Buscar");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oSUBCLASE = frm.SubClaseSelect;
                txtSUBCLASE.Text = oSUBCLASE.NOMBRE;
                //cmbPROVEEDOR.SelectedItem = oPROVEEDOR;
            }
        }
    }

}
