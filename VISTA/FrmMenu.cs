//using MetroFramework.Properties;

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
    public partial class FrmMenu : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.SEGURIDAD cSeguridad;
        //CONTROLADORA.cAcceso cAcceso = CONTROLADORA.cAcceso.obtenerInstancia();
        MODELO.USUARIO oUsuario;
        MODELO.GRUPO oGrupo;
        bool accion1;
        bool accion2;
        bool accion3;
        bool accion4;
        bool accion5;
        bool accion6;
        bool isCollapsed;
        bool isCollapsed2;
        CONTROLADORA.Seguridad.ACCESO oAccesos;
        MODELO.SEGURIDAD.ACCESO oAcceso;

        public FrmMenu()
        {
            InitializeComponent();
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            /*UsuariosMenu.Enabled = true;
            Cambiar_Clavebtn.Enabled = false;
            GruposMenu.Enabled = true;*/
            btnUSUARIOS.Enabled = true;
            //btnSEGURIDAD.Enabled = true;
            btnGRUPOS.Enabled = true;
            accion1 = false;
            accion2 = false;
            accion3 = false;
            accion4 = false;
            accion5 = false;
            accion6 = false;
            lblUSUARIO.Text = "Superusuario";
            //btnSEGURIDAD.Enabled = false;
           



        }

        public FrmMenu(MODELO.USUARIO unUsuario)
        {
            InitializeComponent();
            btnUSUARIOS.Enabled = false;
            btnGRUPOS.Enabled = false;
            btnVENTA.Enabled = false;
            //btnSEGURIDAD.Enabled = false;
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            oUsuario = unUsuario;
            //Cambiar_Clavebtn.Enabled = true;
            armarDatosUsuario();
            oAcceso = new MODELO.SEGURIDAD.ACCESO();
            oAccesos = CONTROLADORA.Seguridad.ACCESO.obtenerInstancia();


            for (int i = 0; i < oUsuario.Grupos.Count(); i++)
            {
                oGrupo = oUsuario.Grupos[i];

                if (oGrupo.Permisos.Count() > 0)
                {
                    for (int z = 0; z < oGrupo.Permisos.Count(); z++)
                    {
                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Usuario") || (oGrupo.Permisos[z].Descripcion == "Modificar Usuario") || (oGrupo.Permisos[z].Descripcion == "Eliminar Usuario"))
                        {
                            btnUSUARIOS.Enabled = true;
                            accion1 = true;

                        }

                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Grupo") || (oGrupo.Permisos[z].Descripcion == "Modificar Grupo") || (oGrupo.Permisos[z].Descripcion == "Eliminar Grupo") || (oGrupo.Permisos[z].Descripcion == "Consultar Grupo"))
                        {
                            btnGRUPOS.Enabled = true;
                            accion2 = true;
                        }
                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Venta") || (oGrupo.Permisos[z].Descripcion == "Modificar Venta") || (oGrupo.Permisos[z].Descripcion == "Eliminar Venta") || (oGrupo.Permisos[z].Descripcion == "Consultar Venta") || (oGrupo.Permisos[z].Descripcion == "Exportar Venta"))
                        {
                            btnVENTA.Enabled = true;
                            accion3 = true;
                        }
                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Compra") || (oGrupo.Permisos[z].Descripcion == "Modificar Compra") || (oGrupo.Permisos[z].Descripcion == "Eliminar Compra") || (oGrupo.Permisos[z].Descripcion == "Consultar Compra") || (oGrupo.Permisos[z].Descripcion == "Exportar Compra"))
                        {
                            accion4 = true;
                        }
                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Stock") || (oGrupo.Permisos[z].Descripcion == "Modificar Stock") || (oGrupo.Permisos[z].Descripcion == "Eliminar Stock") || (oGrupo.Permisos[z].Descripcion == "Consultar Stock") || (oGrupo.Permisos[z].Descripcion == "Exportar Stock"))
                        {
                            accion5 = true;
                        }
                        if ((oGrupo.Permisos[z].Descripcion == "Resetear Clave"))
                        {
                            //btnSEGURIDAD.Enabled = true;
                            //btnCAMBIARPASS.Enabled = true;
                            accion6 = true;
                        }
                    }

                }


            }


        }


        public FrmMenu(MODELO.USUARIO unUsuario, MODELO.SEGURIDAD.ACCESO unAcceso)
        {
            InitializeComponent();           
            btnUSUARIOS.Enabled = false;
            btnGRUPOS.Enabled = false;
            btnVENTA.Enabled = false;
            //btnSEGURIDAD.Enabled = false;
            cSeguridad = CONTROLADORA.SEGURIDAD.Singleton();
            oUsuario = unUsuario;
            oAcceso = unAcceso;
            //Cambiar_Clavebtn.Enabled = true;
            armarDatosUsuario();
            oAcceso = new MODELO.SEGURIDAD.ACCESO();
            oAccesos = CONTROLADORA.Seguridad.ACCESO.obtenerInstancia();


            for (int i=0; i < oUsuario.Grupos.Count(); i++)
            {
                oGrupo = oUsuario.Grupos[i];
                
                if(oGrupo.Permisos.Count() > 0)
                {
                    for(int z=0; z< oGrupo.Permisos.Count(); z++)
                    {
                        if( (oGrupo.Permisos[z].Descripcion == "Agregar Usuario") || (oGrupo.Permisos[z].Descripcion == "Modificar Usuario") || (oGrupo.Permisos[z].Descripcion == "Eliminar Usuario"))
                        {
                            btnUSUARIOS.Enabled = true;
                            accion1 = true;

                        }

                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Grupo") || (oGrupo.Permisos[z].Descripcion == "Modificar Grupo") || (oGrupo.Permisos[z].Descripcion == "Eliminar Grupo") || (oGrupo.Permisos[z].Descripcion == "Consultar Grupo"))
                        {
                            btnGRUPOS.Enabled = true;
                            accion2 = true;
                        }
                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Venta") || (oGrupo.Permisos[z].Descripcion == "Modificar Venta") || (oGrupo.Permisos[z].Descripcion == "Eliminar Venta") || (oGrupo.Permisos[z].Descripcion == "Consultar Venta") || (oGrupo.Permisos[z].Descripcion == "Exportar Venta"))
                        {
                            btnVENTA.Enabled = true;
                            accion3 = true;
                        }
                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Compra") || (oGrupo.Permisos[z].Descripcion == "Modificar Compra") || (oGrupo.Permisos[z].Descripcion == "Eliminar Compra") || (oGrupo.Permisos[z].Descripcion == "Consultar Compra") || (oGrupo.Permisos[z].Descripcion == "Exportar Compra"))
                        {
                            accion4 = true;
                        }
                        if ((oGrupo.Permisos[z].Descripcion == "Agregar Stock") || (oGrupo.Permisos[z].Descripcion == "Modificar Stock") || (oGrupo.Permisos[z].Descripcion == "Eliminar Stock") || (oGrupo.Permisos[z].Descripcion == "Consultar Stock") || (oGrupo.Permisos[z].Descripcion == "Exportar Stock"))
                        {
                            accion5 = true;
                        }
                        if ((oGrupo.Permisos[z].Descripcion == "Resetear Clave"))
                        {
                            //btnSEGURIDAD.Enabled = true;
                          //  btnCAMBIARPASS.Enabled = true;
                            accion6 = true;
                        }
                    }

                }
               

            }


        }

        

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void cambiarClaveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHORA.Text = DateTime.Now.ToLongTimeString();            
        }

        public void armarDatosUsuario()
        {
            lblUSUARIO.Text = oUsuario.Nombre + " " + oUsuario.Apellido;
        }



        private void btnUSUARIOS_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGRUPOS_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCOMPRA_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVENTA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSTOCK_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHORA.Text = DateTime.Now.ToLongTimeString();
            //lblFECHA.Text = DateTime.Now.ToLongDateString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(lblUSUARIO.Text != "Superusuario")
            {
                oAcceso.FechayHoraEntrada = oAcceso.FechayHoraEntrada;
                oAcceso.Logout = oAcceso.Logout;
                oAcceso.Username = oUsuario.Username;
                oAcceso.Logout = "LOGOUT";
                oAcceso.FechayHoraEntrada = DateTime.Now;
                oAcceso.FechayHoraSalida = DateTime.Now;
                oAccesos.AGREGAR_ACCESO(oAcceso);
            }
            this.Hide();
            FRM_LOGIN form = new FRM_LOGIN();
            form.ShowDialog();
            
            //Application.Exit();
        }
        //Image myImage = Resources.myImage;
        //using panelDrop
        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCLIENTES_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPROVEEDORES_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLOCALIDAD_Click(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {


        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            PROVEEDORES.PROVEEDORES frm = new PROVEEDORES.PROVEEDORES();
            frm.ShowDialog();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            frmLOCALIDADES frm = new frmLOCALIDADES();
            frm.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (accion4 == true)
            {
                Iteracion_II.FrmGestionarC form = new Iteracion_II.FrmGestionarC(oUsuario);
                form.ShowDialog();
            }
            else
            {

                Iteracion_II.FrmGestionarC form = new Iteracion_II.FrmGestionarC();
                form.ShowDialog();
            }
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            VENTAS.frmVENTAS form = new VENTAS.frmVENTAS();
            form.ShowDialog();
        }

        private void Button10_Click_2(object sender, EventArgs e)
        {
            if (accion5 == true)
            {
                Iteracion_II.FrmGestionarS form = new Iteracion_II.FrmGestionarS(oUsuario);
                form.ShowDialog();
            }
            else
            {

                Iteracion_II.FrmGestionarS form = new Iteracion_II.FrmGestionarS();
                form.ShowDialog();
            }
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {

            if (accion2 == true)
            {
                GRUPO.FrmGestionarG form = new GRUPO.FrmGestionarG(oUsuario);
                form.ShowDialog();
            }
            else
            {

                GRUPO.FrmGestionarG form = new GRUPO.FrmGestionarG();
                form.ShowDialog();
            }
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            if (accion1 == true)
            {
                USUARIO.FrmGestionarU form = new USUARIO.FrmGestionarU(oUsuario);
                form.ShowDialog();
            }
            else
            {
                USUARIO.FrmGestionarU form = new USUARIO.FrmGestionarU();
                form.ShowDialog();
            }

        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            CLIENTES.frmCLIENTES frm = new CLIENTES.frmCLIENTES();
            frm.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_4(object sender, EventArgs e)
        {
            this.Hide();
            CLAVE.FrmCambiar_Clavee frm = new CLAVE.FrmCambiar_Clavee(oUsuario, "menu");
            frm.ShowDialog();
        }

        private void btnMATERIALES_Click(object sender, EventArgs e)
        {
            MATERIALES.frmMATERIALES frm = new MATERIALES.frmMATERIALES("menu");
            frm.ShowDialog();
        }

        private void lblCLASE_Click(object sender, EventArgs e)
        {
            MATERIALES.Clase frm = new MATERIALES.Clase();
            frm.ShowDialog();
        }

        private void lblSUBCLASE_Click(object sender, EventArgs e)
        {
            MATERIALES.Subclase frm = new MATERIALES.Subclase();
            frm.ShowDialog();
        }

        private void btnCERRARSESION_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void btnORDENCOMPRA_Click(object sender, EventArgs e)
        {
            OC.frmORDENESCOMPRA frm = new OC.frmORDENESCOMPRA();
            frm.ShowDialog();
        }

        private void btnREMITO_Click(object sender, EventArgs e)
        {
            REMITO.frmREMITOS frm = new REMITO.frmREMITOS();
            frm.ShowDialog();
        }

        private void btnWStock_Click(object sender, EventArgs e)
        {
            STOCK.frmWSTOCK frm = new STOCK.frmWSTOCK();
            frm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmCOMPARATIVA frm = new frmCOMPARATIVA();
            frm.ShowDialog();
        }
    }
}
