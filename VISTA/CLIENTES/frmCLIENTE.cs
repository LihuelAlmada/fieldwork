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
namespace VISTA.CLIENTES
{
    public partial class frmCLIENTE : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cCliente cCliente;
        CONTROLADORA.cLocalidad cLocalidad;
        MODELO.Localidad oLOCALIDAD;
        MODELO.Cliente oCliente;
        string accion;
        public frmCLIENTE(string unaaccion)
        {
            InitializeComponent();
            cCliente = CONTROLADORA.cCliente.obtener_instancia();
            accion = unaaccion;
            cmbTIPOD.SelectedIndex = 1;
            cmbTIPO.SelectedIndex = 1;
            ARMO_LOCALIDAD();
        }
        public frmCLIENTE(MODELO.Cliente unCliente, string unaaccion)
        {
            InitializeComponent();
            cCliente = CONTROLADORA.cCliente.obtener_instancia();
            oCliente = unCliente;
            accion = unaaccion;
            ARMO_LOCALIDAD();
            if (accion != "A")
            {
                cmbTIPOD.Text = oCliente.tipoDocumento;
                txtRAZONSOCIAL.Text = oCliente.razonSocial;
                txtNOMBRE.Text = oCliente.nombre;
                txtAPELLIDO.Text = oCliente.apellido;
                txtDOCUMENTO.Text = oCliente.documento.ToString();
                txtTELEFONO.Text = oCliente.telefono.ToString();
                txtMAIL.Text = oCliente.mail;
                txtDIRECCION.Text = oCliente.direccion;
                cmbTIPO.Text = oCliente.tipo;
                cmbESTADO.Text = oCliente.estado;

                if (accion == "C")
                {
                    txtAPELLIDO.Enabled = false;
                    txtDIRECCION.Enabled = false;
                    txtDOCUMENTO.Enabled = false;
                    txtMAIL.Enabled = false;
                    txtNOMBRE.Enabled = false;
                    txtRAZONSOCIAL.Enabled = false;
                    txtTELEFONO.Enabled = false;
                    cmbESTADO.Enabled = false;
                    cmbLOCALIDAD.Enabled = false;
                    cmbTIPO.Enabled = false;
                    btnGUARDAR.Visible = false;
                    cmbTIPOD.Enabled = false;
                    btnLupa.Enabled = false;
                }

            }
        }
        public void ARMO_LOCALIDAD()
        {
            cmbLOCALIDAD.DataSource = null;
            cmbLOCALIDAD.DataSource = cCliente.obtenerLocalidades();
        }

        private void BtnGUARDAR_Click_1(object sender, EventArgs e)
        {

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

            if (txtDOCUMENTO.Text == "")
            {
                MessageBox.Show("El formato del documento es incorrecto");
                return;
            }
            if (string.IsNullOrEmpty(cmbTIPOD.Text))
            {
                MessageBox.Show("El tipo de documento es incorrecto");
                return;
            }
            if (!Int32.TryParse(txtTELEFONO.Text, out TELEFONO))
            {
                MessageBox.Show("El formato del telefono es incorrecto");
                return;
            }
            /*if (!CONTROLADORA.cFunBasic.validar_mail(txtMAIL.Text))
            {
                MessageBox.Show("Formato de mail incorrecto");
                return;
            }*/
            if (string.IsNullOrEmpty(txtDIRECCION.Text))
            {
                MessageBox.Show("Debe ingresar direccion");
                return;
            }
            if (string.IsNullOrEmpty(cmbTIPO.Text))
            {
                MessageBox.Show("Debe ingresar un Tipo");
                return;
            }
            if (string.IsNullOrEmpty(cmbESTADO.Text))
            {
                MessageBox.Show("Debe ingresar un Estado");
                return;
            }

            oCliente.razonSocial = txtRAZONSOCIAL.Text;
            oCliente.nombre = txtNOMBRE.Text;
            oCliente.apellido = txtAPELLIDO.Text;
            oCliente.documento = txtDOCUMENTO.Text;
            oCliente.tipoDocumento = cmbTIPOD.SelectedItem.ToString();
            oCliente.telefono = Int32.Parse(txtTELEFONO.Text);
            oCliente.mail = txtMAIL.Text;
            oCliente.Localidad = (MODELO.Localidad)cmbLOCALIDAD.SelectedItem;
            oCliente.direccion = txtDIRECCION.Text;
            oCliente.tipo = cmbTIPO.Text;
            oCliente.estado = cmbESTADO.Text;

            if (accion == "A")
                cCliente.agregarCliente(oCliente);
            else
                cCliente.modificarCliente(oCliente);

            this.DialogResult = DialogResult.OK;
        }

        private void BtnSALIR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloLetras(e, oCliente.nombre);
        }

        private void txtAPELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloLetras(e, oCliente.apellido);
        }

        private void txtTELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
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
    }
}
