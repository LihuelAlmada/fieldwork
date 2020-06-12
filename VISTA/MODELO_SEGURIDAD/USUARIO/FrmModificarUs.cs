using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.USUARIO
{
    public partial class FrmModificarUs : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.USUARIO oUsuario;


        public FrmModificarUs(MODELO.USUARIO miusuario)
        {
            InitializeComponent();
            oUsuario = miusuario;
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            txtUSUARIO.Enabled = false;
            txtDNI.Enabled = false;
            txtUSUARIO.Text = oUsuario.Username;
            txtNOMBRE.Text = oUsuario.Nombre;
            txtAPELLIDO.Text = oUsuario.Apellido;
            txtEMAIL.Text = oUsuario.Email;
            txtDNI.Text = oUsuario.Dni.ToString();
            cbESTADO.Checked = oUsuario.Estado;


            ArmarGrupo();

        }

        public void ArmarGrupo()
        {

            cblGRUPOS.DataSource = null;
            cblGRUPOS.DataSource = cSeguridad.GRUPOS.OBTENER_GRUPOS();

            if (oUsuario.Grupos != null)
            {
                for (int z = 0; z < cblGRUPOS.Items.Count; z++)
                {
                    for (int i = 0; i < oUsuario.Grupos.Count(); i++)
                    {
                        if (oUsuario.Grupos[i].Nombre.ToString() == ((MODELO.GRUPO)cblGRUPOS.Items[z]).Nombre.ToString())
                        {
                            cblGRUPOS.SetItemChecked(z, true);
                        }
                    }

                }
            }


        }
        

        

        private void btnGUARDARR_Click(object sender, EventArgs e)
        {
            oUsuario.Username = txtUSUARIO.Text;
            oUsuario.Nombre = txtNOMBRE.Text;
            oUsuario.Apellido = txtAPELLIDO.Text;
            oUsuario.Email = txtEMAIL.Text;
            oUsuario.Estado = cbESTADO.Checked;
            oUsuario.Grupos = new List<MODELO.GRUPO>();
            foreach (var item in cblGRUPOS.CheckedItems)
            {
                oUsuario.Grupos.Add((MODELO.GRUPO)item);
            }

            cSeguridad.Modificar(oUsuario);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSALIIR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

