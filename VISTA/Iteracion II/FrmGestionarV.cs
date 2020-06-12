using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Iteracion_II
{
    public partial class FrmGestionarV : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.GRUPO oGrupo;
        MODELO.USUARIO oUsuario;
        public FrmGestionarV()
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
        }
        public FrmGestionarV(MODELO.USUARIO unUsuario)
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            btnAGREGAR.Enabled = false;
            btnELIMINAR.Enabled = false;
            btnMODIFICAR.Enabled = false;
            btnCONSULTAR.Enabled = false;
            btnEXPORTAR.Enabled = false;


            oUsuario = unUsuario;

            for (int i = 0; i < oUsuario.Grupos.Count(); i++)
            {
                oGrupo = oUsuario.Grupos[i];

                if (oGrupo.Permisos.Count() > 0)
                {
                    for (int z = 0; z < oGrupo.Permisos.Count(); z++)
                    {
                        if (oGrupo.Permisos[z].Descripcion == "Agregar Venta")
                        {
                            btnAGREGAR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Modificar Venta")
                        {
                            btnMODIFICAR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Eliminar Venta")
                        {
                            btnELIMINAR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Consultar Venta")
                        {
                            btnCONSULTAR.Enabled = true;
                        }
                        if (oGrupo.Permisos[z].Descripcion == "Exportar Venta")
                        {
                            btnEXPORTAR.Enabled = true;
                        }

                    }

                }

            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
