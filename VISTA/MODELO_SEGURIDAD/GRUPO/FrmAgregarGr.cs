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
    public partial class FrmAgregarGr : MetroFramework.Forms.MetroForm
    {
           
        CONTROLADORA.SEGURIDAD cSeguridad;
        MODELO.GRUPO oGrupo;
        MODELO.SEGURIDAD.AUDITORIA oAuditoria;
        CONTROLADORA.Seguridad.AUDITORIA cAuditoria;
        MODELO.USUARIO oUsuario;
        

        public FrmAgregarGr(MODELO.GRUPO miGrupo, MODELO.USUARIO unUsuario)
        {
            InitializeComponent();

            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            oGrupo = miGrupo;
            oUsuario = unUsuario;
            ArmarUsuarios();
            ArmarPermisos();
            cAuditoria = new CONTROLADORA.Seguridad.AUDITORIA();
            oAuditoria = new MODELO.SEGURIDAD.AUDITORIA();


        }

        public void ArmarUsuarios()
        {
            cblUSUARIOS.DataSource = null;
            cblUSUARIOS.DataSource = cSeguridad.USUARIOS.OBTENER_USUARIOS();
        }
        public void ArmarPermisos()
        {
            cbxPERMISOS.DataSource = null;
            cbxPERMISOS.DataSource = cSeguridad.PERMISOS.OBTENER_PERMISOS();
        }



        private void btnSALIIR_Click_2(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGUARDARR_Click_2(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("El campo NOMBRE esta vacio");
                return;
            }

            

            oGrupo.Nombre = txtNOMBRE.Text;
            oGrupo.Estado = cbESTADO.Checked;
            oGrupo.Usuarios = new List<MODELO.USUARIO>();
            oGrupo.Permisos = new List<MODELO.PERMISO>();


            foreach (var item in cblUSUARIOS.CheckedItems)
            {
                oGrupo.Usuarios.Add((MODELO.USUARIO)item);
            }
            foreach (var item in cbxPERMISOS.CheckedItems)
            {
                //fausto
                



                
                
                if (oUsuario != null)
                {
                    oAuditoria.Movimiento = "ALTA";
                    oAuditoria.FechayHora = DateTime.Now;
                    oAuditoria.Permiso = ((MODELO.PERMISO)item).Descripcion;
                    oAuditoria.Descripcion = oGrupo.Nombre;
                    cAuditoria.AGREGAR_AUDITORIA(oAuditoria);
                    oGrupo.Permisos.Add((MODELO.PERMISO)item);
                    oAuditoria.Username = oUsuario.Username;
                    //oUsuario.Username = "Superusuario";
                }
                else
                {
                    oAuditoria.Movimiento = "ALTA";
                    oAuditoria.FechayHora = DateTime.Now;
                    oAuditoria.Permiso = ((MODELO.PERMISO)item).Descripcion;
                    oAuditoria.Descripcion = oGrupo.Nombre;
                    cAuditoria.AGREGAR_AUDITORIA(oAuditoria);
                    oGrupo.Permisos.Add((MODELO.PERMISO)item);
                    oAuditoria.Username = "SUPERUSUARIO";
                }
                

                
            }

            
            cSeguridad.Agregar(oGrupo);



            this.DialogResult = DialogResult.OK;
        }
    }
}
