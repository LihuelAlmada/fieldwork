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
    public partial class PROVEEDOR : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cProveedor cProveedor;
        MODELO.Proveedor oPROVEEDOR;
        CONTROLADORA.cLocalidad cLocalidad;
        MODELO.Localidad oLOCALIDAD;
        string accion;

        public PROVEEDOR(string unaaccion)
        {
            InitializeComponent();
            cProveedor = CONTROLADORA.cProveedor.obtener_instancia();
            cLocalidad = CONTROLADORA.cLocalidad.obtener_instancia();
            accion = unaaccion;
            cmbTIPO.SelectedIndex = 1;
            cmbTIPOD.SelectedIndex = 1;
            ARMO_LOCALIDAD();
        }

        public PROVEEDOR(MODELO.Proveedor unProveedor, string unaaccion)
        {
            InitializeComponent();
            cProveedor = CONTROLADORA.cProveedor.obtener_instancia();
            cLocalidad = CONTROLADORA.cLocalidad.obtener_instancia();
            oPROVEEDOR = unProveedor;
            accion = unaaccion;
            ARMO_LOCALIDAD();
            if (accion != "A")
            {
                
                txtRAZONSOCIAL.Text = oPROVEEDOR.razonSocial;
                txtNOMBRE.Text = oPROVEEDOR.nombre;
                txtAPELLIDO.Text = oPROVEEDOR.apellido;
                cmbTIPOD.Text = oPROVEEDOR.tipoDocumento;
                txtDOCUMENTO.Text = oPROVEEDOR.documento.ToString();
                txtTELEFONO.Text = oPROVEEDOR.telefono.ToString();
                txtMAIL.Text = oPROVEEDOR.mail;
                txtDIRECCION.Text = oPROVEEDOR.direccion;
                cmbTIPO.Text = oPROVEEDOR.tipo;
                cmbESTADO.Text = oPROVEEDOR.estado;

                if (accion == "C")
                {
                    lblRAZONSOCIAL.Enabled = false;
                    txtNOMBRE.Enabled = false;
                    lblAPELLIDO.Enabled = false;
                    txtDOCUMENTO.Enabled = false;
                    cmbESTADO.Enabled = false;
                    cmbLOCALIDAD.Enabled = false;
                    cmbTIPO.Enabled = false;
                    cmbTIPOD.Enabled = false;
                    txtTELEFONO.Enabled = false;
                    txtMAIL.Enabled = false;
                    btnGUARDAR.Visible = false;
                    txtRAZONSOCIAL.Enabled = false;
                    txtAPELLIDO.Enabled = false;
                    txtDIRECCION.Enabled = false;
                    btnLupa.Enabled = false;
                }

            }
        }

        public void ARMO_LOCALIDAD()
        {
            cmbLOCALIDAD.DataSource = null;
            cmbLOCALIDAD.DataSource = cLocalidad.obtenerLocalidadNombre("");
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGUARDAR_Click_1(object sender, EventArgs e)
        {
            #region VALIDACIONES 
            Int32 DNI;
            Int32 TELEFONO;

            bool email = COMUN.MetodosComunes.ValidacionEMAIL(e, txtMAIL.Text);
            if (email == false)
            {
                MessageBox.Show("Debe ingresar un formato de email correcto");
                return;
            }

            if (string.IsNullOrEmpty(txtRAZONSOCIAL.Text))
            {
                MessageBox.Show("Debe ingresar una Razon Social");
                return;
            }

            if (string.IsNullOrEmpty(cmbLOCALIDAD.Text))
            {
                MessageBox.Show("Debe ingresar una Localidad");
                return;
            }

            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre de contacto");
                return;
            }
            if (string.IsNullOrEmpty(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar un Apellido de contacto");
                return;
            }

            if (!Int32.TryParse(txtDOCUMENTO.Text, out DNI))
            {
                MessageBox.Show("El formato del DNI es incorrecto");
                return;
            }
            if (!Int32.TryParse(txtTELEFONO.Text, out TELEFONO))
            {
                MessageBox.Show("El formato del telefono es incorrecto");
                return;
            }
           
            //if (!CONTROLADORA.cFunBasic.validar_mail(txtMAIL.Text))
            //{
            //    MessageBox.Show("Formato de mail incorrecto");
            //    return;
            //}

            if (string.IsNullOrEmpty(txtDIRECCION.Text))
            {
                MessageBox.Show("Debe ingresar direccion");
                return;
            }
           /* if (string.IsNullOrEmpty(cmbTIPO.Text))
            {
                MessageBox.Show("Debe ingresar un Tipo");
                return;
            } */
            if (string.IsNullOrEmpty(cmbESTADO.Text))
            {
                MessageBox.Show("Debe ingresar un Estado");
                return;
            }
            #endregion
            oPROVEEDOR.razonSocial = txtRAZONSOCIAL.Text;
            oPROVEEDOR.nombre = txtNOMBRE.Text;
            oPROVEEDOR.apellido = txtAPELLIDO.Text;
            oPROVEEDOR.tipoDocumento = cmbTIPOD.SelectedItem.ToString();
            oPROVEEDOR.documento = txtDOCUMENTO.Text;
            oPROVEEDOR.telefono = Int32.Parse(txtTELEFONO.Text);
            oPROVEEDOR.mail = txtMAIL.Text;
            oPROVEEDOR.Localidad = (MODELO.Localidad)cmbLOCALIDAD.SelectedItem;
            oPROVEEDOR.direccion = txtDIRECCION.Text;
            oPROVEEDOR.estado = cmbESTADO.Text;


            if (accion == "A")
            {
                oPROVEEDOR.tipo = "Nuevo";
                cProveedor.agregarProveedor(oPROVEEDOR);
            }
            else
            {
                cProveedor.modificarProveedor(oPROVEEDOR);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void BtnSALIR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnLupa_Click(object sender, EventArgs e)
        {
            frmLOCALIDADES frm = new frmLOCALIDADES("Buscar");
            DialogResult dr = frm.ShowDialog();
           /* if (dr == DialogResult.OK)
            {
                oLOCALIDAD = frm.LocalidadSelect;
                cmbLOCALIDAD.SelectedItem = oLOCALIDAD;
                cLocalidad = CONTROLADORA.cLocalidad.obtener_instancia();
            }*/

            ARMO_LOCALIDAD();


        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloLetras(e, oPROVEEDOR.nombre);
        }

        private void txtAPELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloLetras(e, oPROVEEDOR.apellido);
        }

        private void TxtTELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void TxtDOCUMENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void txtMAIL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
