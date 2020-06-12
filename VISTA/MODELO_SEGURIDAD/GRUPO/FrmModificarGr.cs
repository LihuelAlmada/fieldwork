using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.GRUPO
{
    public partial class FrmModificarGr : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.GRUPO oGrupo;

        public FrmModificarGr(MODELO.GRUPO miGrupo)
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            oGrupo = miGrupo;
            txtNOMBRE.Text = oGrupo.Nombre;
            cbESTADO.Checked = oGrupo.Estado;
            ArmarUsuario();
            ArmarPermiso();

        }


        public void ArmarUsuario()
        {
            cblUSUARIOS.DataSource = null;
            cblUSUARIOS.DataSource = cSeguridad.USUARIOS.OBTENER_USUARIOS();
            if (oGrupo.Usuarios != null)
            {
                for (int z = 0; z < cblUSUARIOS.Items.Count; z++)
                {
                    for (int i = 0; i < oGrupo.Usuarios.Count(); i++)
                    {
                        if (oGrupo.Usuarios[i].Nombre.ToString() == ((MODELO.USUARIO)cblUSUARIOS.Items[z]).Nombre.ToString())
                        {
                            cblUSUARIOS.SetItemChecked(z, true);
                        }
                    }
                }
            }

        }

        public void ArmarPermiso()
        {
            cbxPERMISO.DataSource = null;
            cbxPERMISO.DataSource = cSeguridad.PERMISOS.OBTENER_PERMISOS();
            if (oGrupo.Permisos != null)
            {
                for (int z = 0; z < cbxPERMISO.Items.Count; z++)
                {
                    for (int i = 0; i < oGrupo.Permisos.Count(); i++)
                    {
                        if (oGrupo.Permisos[i].Descripcion.ToString() == ((MODELO.PERMISO)cbxPERMISO.Items[z]).Descripcion.ToString())
                        {
                            cbxPERMISO.SetItemChecked(z, true);
                        }
                    }
                }
            }

        }





        private void btnGUARDARR_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSALIRR_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGUARDARR_Click_1(object sender, EventArgs e)
        {
            oGrupo.Nombre = txtNOMBRE.Text;
            oGrupo.Estado = cbESTADO.Checked;
            oGrupo.Usuarios = new List<MODELO.USUARIO>();
            oGrupo.Permisos = new List<MODELO.PERMISO>();

            foreach (var item in cblUSUARIOS.CheckedItems)
            {
                oGrupo.Usuarios.Add((MODELO.USUARIO)item);
            }

            foreach (var item in cbxPERMISO.CheckedItems)
            {
                oGrupo.Permisos.Add((MODELO.PERMISO)item);
            }

            cSeguridad.Modificar(oGrupo);

            this.DialogResult = DialogResult.OK;
        }

        private void btnSALIRR_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

