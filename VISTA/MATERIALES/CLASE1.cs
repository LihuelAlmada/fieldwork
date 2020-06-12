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
    public partial class CLASE1 : MetroFramework.Forms.MetroForm
    {
        MODELO.Clase oClase;
        CONTROLADORA.cClase cClase;
        string accion;

        public CLASE1(string unaaccion)
        {
            InitializeComponent();       
            cClase = CONTROLADORA.cClase.obtener_instancia();
            accion = unaaccion;
        }
        public CLASE1(MODELO.Clase unaClase, string unaaccion)
        {
            InitializeComponent();        
            cClase = CONTROLADORA.cClase.obtener_instancia();
            oClase = unaClase;
            accion = unaaccion;
            if (accion != "A")
            {

                txtNOMBRE.Text = oClase.NOMBRE;

                if (accion == "C")
                {
                    txtNOMBRE.Enabled = false;
                }

            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nomvre");
                return;
            }

            oClase.NOMBRE = txtNOMBRE.Text;

            if (accion == "A")
                cClase.agregarClase(oClase);
            else
                cClase.modificarClase(oClase);

            this.DialogResult = DialogResult.OK;
        }

        private void CLASE1_Load(object sender, EventArgs e)
        {

        }
    }
}
