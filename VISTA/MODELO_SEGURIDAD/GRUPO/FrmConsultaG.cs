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
    public partial class FrmConsultaG : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.GRUPO oGrupo;
       

        public FrmConsultaG(MODELO.GRUPO miGrupo)
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            oGrupo = miGrupo;


            ArmarUsuario();
            cblUSUARIOS.Enabled = false;
            cbxPERMISO.Enabled = false;
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

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
