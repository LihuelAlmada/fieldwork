using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmLOCALIDAD : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cLocalidad cLocalidad;
        MODELO.Localidad oLOCALIDAD;
        string accion;

        public frmLOCALIDAD(MODELO.Localidad unaLocalidad, string unaaccion)
        {
            InitializeComponent();
            oLOCALIDAD = unaLocalidad;
            accion = unaaccion;
            cLocalidad = CONTROLADORA.cLocalidad.obtener_instancia();

            if (accion != "A")
            {
                txtNOMBRE.Text = oLOCALIDAD.nombre;
                txtCODIGO_POSTAL.Text = oLOCALIDAD.codigoPostal.ToString();
                cmbPROVINCIA.Text = oLOCALIDAD.provincia;
                if (accion == "C")
                {
                    txtCODIGO_POSTAL.Enabled = false;
                    txtNOMBRE.Enabled = false;
                    cmbPROVINCIA.Enabled = false;
                    btnGUARDAR.Visible = false;
                }
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnGUARDAR_Click_1(object sender, EventArgs e)
        {
            bool error = false;
            Int32 CP;
          

            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debes ingresar el nombre de la Localidad");
                return;
            }




            if (string.IsNullOrEmpty(cmbPROVINCIA.Text))
            {
                MessageBox.Show("Debes ingresar el nombre de la provincia");
                return;
            }
            if (!Int32.TryParse(txtCODIGO_POSTAL.Text, out CP))
            {
                MessageBox.Show("Debes ingresar el codigo postal de la Localidad");
                return;
            }

            //Contenido
            if (error == false)
            {
                oLOCALIDAD.nombre = txtNOMBRE.Text;
                oLOCALIDAD.provincia = cmbPROVINCIA.Text;
                oLOCALIDAD.codigoPostal = Convert.ToInt32(txtCODIGO_POSTAL.Text);

                if (accion == "A")
                    cLocalidad.agregarLocalidad(oLOCALIDAD);
                else
                    cLocalidad.modificarLocalidad(oLOCALIDAD);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void BtnSALIR_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TxtCODIGO_POSTAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }
    }
}
