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
    public partial class CLASE2 : MetroFramework.Forms.MetroForm
    {
        MODELO.Subclase oClase;
        CONTROLADORA.cSubclase cClase;
        string accion;
        public CLASE2(string unaaccion)
        {
            InitializeComponent();

            InitializeComponent();
            cClase = CONTROLADORA.cSubclase.obtener_instancia();
            accion = unaaccion;
           
        }
        public CLASE2(MODELO.Subclase unaClase, string unaaccion)
        {
            InitializeComponent();
            cClase = CONTROLADORA.cSubclase.obtener_instancia();
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

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nomvre");
                return;
            }

            oClase.NOMBRE = txtNOMBRE.Text;

            if (accion == "A")
                cClase.agregarSubClase(oClase);
            else
                cClase.modificarSubClase(oClase);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
