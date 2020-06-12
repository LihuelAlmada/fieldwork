using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.REMITO
{
    public partial class frm_REMITO : MetroFramework.Forms.MetroForm
    {

        CONTROLADORA.cRemito cREMITO;
        CONTROLADORA.cProveedor cProveedor;
        CONTROLADORA.cMateriales cMateriales;
        CONTROLADORA.cRemitoUpdated cRemitoUpdated;
        CONTROLADORA.cOccantmat cOccantmat;
        CONTROLADORA.cLocalidad cLocalidad;
        CONTROLADORA.cAuditoria cAuditoria;

        string ACCION;
        int cantidadIngresada = 0;
        int cantidadRequerida = 0;
        CONTROLADORA.cCliente cCLIENTE;
        CONTROLADORA.cOrdenCompra cORDEN;
        CONTROLADORA.cCantMat cCANTMAT;
        List<MODELO.CantidadMat> listaCANTMATERIALES;
        List<MODELO.RemitoUpdated> listaMaterialesUpdated;
        MODELO.Remito oRemito;
        MODELO.Factura oOrden;
        MODELO.Cliente oCliente;
        MODELO.RemitoUpdated oUpdated;
        MODELO.Occantmat oPEPE;
        MODELO.Materiales oMaterial;
        MODELO.Proveedor oProveedor;
        MODELO.Localidad oLocalidad;
        MODELO.CantidadMat oCantMat;
        List<MODELO.Materiales> listanuevax2;
        List<Int32> listanuevax3;
        Int32 cantidad;
        List<MODELO.Occantmat> ocantmat;
        MODELO.Proveedor oProvedorNew;
        MODELO.Factura orderC;


        public frm_REMITO()
        {
            InitializeComponent();
            oProvedorNew = new MODELO.Proveedor();
            orderC = new MODELO.Factura();
            cREMITO = CONTROLADORA.cRemito.obtener_instancia();
            cRemitoUpdated = CONTROLADORA.cRemitoUpdated.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            cLocalidad = CONTROLADORA.cLocalidad.obtener_instancia();
            cCANTMAT = CONTROLADORA.cCantMat.obtener_instancia();
            cOccantmat = CONTROLADORA.cOccantmat.obtener_instancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cCLIENTE = CONTROLADORA.cCliente.obtener_instancia();
            cORDEN = CONTROLADORA.cOrdenCompra.obtener_instancia();
            oMaterial = new MODELO.Materiales();
            listaCANTMATERIALES = new List<MODELO.CantidadMat>();
            listanuevax2 = new List<MODELO.Materiales>();
            listaMaterialesUpdated = new List<MODELO.RemitoUpdated>();
            txtNROREMITO.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            oRemito = new MODELO.Remito();
            dgvUPDATED.Enabled = false;
            //ocantmat = new List<MODELO.CantidadMat>();
            txtCANTIDAD.Enabled = false;


            //dtpFECHARECEPCION.Enabled = false;

            /*dgvMATERIALES.Columns["codigo"].Visible = false;
            dgvMATERIALES.Columns["ordercompra"].Visible = false;

            dgvUPDATED.Columns["codigo"].Visible = false;
            dgvUPDATED.Columns["nroOrden"].Visible = false;*/

        }

        public frm_REMITO(MODELO.Remito unREMITO, string unaACCION)
        {
            InitializeComponent();
            oProvedorNew = new MODELO.Proveedor();
            orderC = new MODELO.Factura();
            cREMITO = CONTROLADORA.cRemito.obtener_instancia();
            oMaterial = new MODELO.Materiales();
            cCANTMAT = CONTROLADORA.cCantMat.obtener_instancia();
            cRemitoUpdated = CONTROLADORA.cRemitoUpdated.obtener_instancia();
            cOccantmat = CONTROLADORA.cOccantmat.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cCLIENTE = CONTROLADORA.cCliente.obtener_instancia();
            cORDEN = CONTROLADORA.cOrdenCompra.obtener_instancia();


            //dgvMATERIALES.Columns["codigo"].Visible = false;
            //dgvMATERIALES.Columns["ordercompra"].Visible = false;

            //dgvUPDATED.Columns["codigo"].Visible = false;
            //dgvUPDATED.Columns["nroOrden"].Visible = false;

            oRemito = unREMITO;
            ACCION = unaACCION;

            txtNROREMITO.Enabled = false;
            //txtCLIENTE.Enabled = false;
            txtLOCALIDAD_PROV.Enabled = false;
            //txtDIRECCION_CLIENTE.Enabled = false;
            //txtDNI_CLIENTE.Enabled = false;
            txtORDENCOMPRA.Enabled = false;
            dtpFECHARECEPCION.Enabled = false;
            txtMATERIAL.Enabled = false;
            txtCANTIDAD.Enabled = false;
            //cmbCANTIDADCALIF.Enabled = false;
            //cmbTIEMPOCALIF.Enabled = false;
            btnVERIFCANT.Enabled = false;
            txtNROREMITO.Text = oRemito.NroRemito.ToString();
            //txtCLIENTE.Text = oRemito.Proveedor.ToString();
            txtPROVEEDOR.Text = oRemito.Proveedor.ToString();
            txtDIRECCION_PROV.Text = oRemito.Proveedor.direccion;
            txtLOCALIDAD_PROV.Text = oRemito.Localidad;
            //txtLOCALIDAD_PROV.Text = oOrden.Localidad.ToString();
            txtCANTIDAD.Text = oRemito.Cantidad.ToString();
            txtORDENCOMPRA.Text = oRemito.OrdenDeCompra.ToString();
            btnLUPA_OC.Enabled = false;
            dtpFECHARECEPCION.Text = oRemito.Fecha.ToString();

            dgvUPDATED.Enabled = false;
            dgvUPDATED.DataSource = null;
            dgvUPDATED.DataSource = cRemitoUpdated.obtenerPorRemito(txtNROREMITO.Text);

            dgvUPDATED.Columns["codigo"].Visible = false;
            dgvUPDATED.Columns["nroOrden"].Visible = false;
            //cmbCANTIDADCALIF.Text = oRemito.CalifCantidad.ToString();
            //cmbTIEMPOCALIF.Text = oRemito.CalifTiempo.ToString();
        }

        public void ARMO_GRILLA()
        {
            //dgvMATERIALES.Columns["Proveedor"].Visible = false;
            //dgvMATERIALES.Columns["Cantidad"].Visible = true;
            //*/

            //dgvMATERIALES.DataSource = null;
            //dgvMATERIALES.DataSource = cORDEN.obtenerOrden2("");



            dgvMATERIALES.DataSource = null;
            dgvMATERIALES.DataSource = cOccantmat.obtenerOccantmat(oOrden);
            ocantmat = cOccantmat.obtenerOccantmat1(oOrden);

            dgvMATERIALES.Columns["codigo"].Visible = false;
            dgvMATERIALES.Columns["ordercompra"].Visible = false;



        }

        public void btnLUPA_OC_Click(object sender, EventArgs e)
        {
            OC.frmORDENESCOMPRA frm = new OC.frmORDENESCOMPRA();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oOrden = frm.OrdenSelec;
                orderC = oOrden;

                //oProveedor = frm.ProveedorSelect;
                oProvedorNew = oOrden.Proveedor;



                //string proveedor = oOrden.Proveedor.ToString();

                ARMO_GRILLA();
            }
            //orderC = new MODELO.Factura();
            if (oOrden == null)
            {
                return;
            }
            txtORDENCOMPRA.Text = oOrden.NroOrden.ToString();
            txtPROVEEDOR.Text = orderC.Proveedor.razonSocial.ToString();
            txtDIRECCION_PROV.Text = oOrden.Proveedor.direccion.ToString();
            txtLOCALIDAD_PROV.Text = oOrden.Localidad;

            // txtLOCALIDAD_PROV.Text = oProvedorNew.direccion;
            //txtLOCALIDAD_PROV.Text = oOrden.Proveedor.Localidad.ToString();
            //txtLOCALIDAD_PROV.Text = oOrden.Proveedor.Localidad.ToString();

            //txtLOCALIDAD_PROV.Text = oOrden.Proveedor.Localidad.nombre;

        }

        private void BtnLUPA_CLIENTE_Click(object sender, EventArgs e)
        {
            PROVEEDORES.PROVEEDORES frm = new PROVEEDORES.PROVEEDORES();
            //CLIENTES.frmCLIENTES frm = new CLIENTES.frmCLIENTES();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {

                //oCliente = frm.ClienteSelect;
                //txtCLIENTE.Text = oProveedor.razonSocial;
                //txtDIRECCION_CLIENTE.Text = oProveedor.direccion;
                //txtDNI_CLIENTE.Text = oProveedor.documento.ToString();
                /*txtDIRECCION_PROV.Text = oProveedor.direccion.ToString();
                txtPROVEEDOR.Text = oProveedor.nombre;*/
                txtLOCALIDAD_PROV.Text = oProveedor.Localidad.ToString();

            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (listaMaterialesUpdated.Count == 0)
            {
                MessageBox.Show("Debe agregar por lo menos un material");
                return;
            }


            listanuevax2 = new List<MODELO.Materiales>();
            listanuevax3 = new List<Int32>();
            listanuevax2 = cOccantmat.obtenerNuevax2(oOrden);
            listanuevax3 = cOccantmat.obtenerCantidadxD(oOrden);
            oRemito.NroRemito = txtNROREMITO.Text;
            oRemito.Proveedor = oProvedorNew;
            oRemito.OrdenDeCompra = orderC;
            oRemito.Fecha = DateTime.Now;
            oRemito.Localidad = oOrden.Localidad;

            #region eval. prov 

            //A = FECHA Y CANTIDAD OK, B = CANTIDAD OK Y FECHA MAL, C = CANTIDAD MAL O CANTIDAD Y FECHA MAL

            for (int i = 0; i < ocantmat.LongCount(); i++)
            {
                cantidadRequerida += ocantmat[i].cantidadmat.Cantidad_mat;

            }

            if (cantidadRequerida == cantidadIngresada)
            {
                if (oOrden.Fecha_Recepcion.Date >= dtpFECHARECEPCION.Value.Date)
                {
                    oProvedorNew.tipo = "A";
                }
                else if (oOrden.Fecha_Recepcion.Date < dtpFECHARECEPCION.Value.Date)
                {
                    oProvedorNew.tipo = "B";
                }

            }
            else if (cantidadRequerida > cantidadIngresada)
            {
                if (oOrden.Fecha_Recepcion.Date >= dtpFECHARECEPCION.Value.Date || oOrden.Fecha_Recepcion.Date <= dtpFECHARECEPCION.Value.Date)
                {
                    oProvedorNew.tipo = "C";
                }
            }

            #endregion

            foreach (var item in listaMaterialesUpdated)
            {
                oUpdated = item;

                for (int i = 0; i < ocantmat.LongCount(); i++)
                {
                    if (ocantmat[i].cantidadmat.Cantidad_mat == oUpdated.Cantidad_Ingresada)
                    {
                        oRemito.CalifCantidad = "A";
                        if (oOrden.Fecha_Recepcion.Date == dtpFECHARECEPCION.Value.Date)
                        {

                            oRemito.CalifTiempo = "A tiempo";
                        }

                    }
                    else if (ocantmat[i].cantidadmat.Cantidad_mat != oUpdated.Cantidad_Ingresada)
                    {
                        oRemito.CalifCantidad = "B";
                        if (oOrden.Fecha_Recepcion.Date == dtpFECHARECEPCION.Value.Date)
                        {

                            oRemito.CalifTiempo = "A tiempo";
                        }
                        else if (oOrden.Fecha_Recepcion.Date < dtpFECHARECEPCION.Value.Date)
                        {

                            oRemito.CalifTiempo = "Tarde";
                        }

                    }
                }

            }
            //oMaterial

            int count = 0;
            foreach (var item in listaMaterialesUpdated)
            {
                oUpdated = item;
                cRemitoUpdated.agregarRemitoUpdated(oUpdated);

                for (int i = 0; i < ocantmat.LongCount(); i++)
                {

                    if (ocantmat[i].material == oUpdated.material)
                    {

                        ocantmat[i].cantidadmat.Cantidad_mat -= oUpdated.Cantidad_Ingresada;
                        cCANTMAT.modificarCantMat(ocantmat[i].cantidadmat);
                        oMaterial = (MODELO.Materiales)cMateriales.obtenerMaterialNombree(ocantmat[i].material)[0];

                        oMaterial.STOCK += oUpdated.Cantidad_Ingresada;
                        cMateriales.modificarMateriales(oMaterial);
                    }

                }

            }
            for (int i = 0; i < ocantmat.LongCount(); i++)
            {
                if (ocantmat[i].cantidadmat.Cantidad_mat == 0)
                {
                    count++;
                }
            }
            if (count == ocantmat.LongCount())
            {
                oOrden.visibily = false;
            }


            cREMITO.agregarRemito(oRemito);

            AGREGAR_AUDITORIA("Alta", oRemito);
            this.DialogResult = DialogResult.OK;
        }
        public void AGREGAR_AUDITORIA(string movimiento, MODELO.Remito oRemito)
        {
            MODELO.AuditoriaRemito oAuditoria = new MODELO.AuditoriaRemito();

            oAuditoria.FechayHora = System.DateTime.Now;
            oAuditoria.Movimiento = movimiento;
            oAuditoria.Username = "SuperUsuario";
            oAuditoria.NroRemito = oRemito.NroRemito;
            //oAuditoria.codigo = oRemito.codigo;
            oAuditoria.Proveedor = oRemito.Proveedor;
            oAuditoria.Localidad = oRemito.Localidad;
            oAuditoria.OrdenDeCompra = oRemito.OrdenDeCompra;
            oAuditoria.Fecha = oRemito.Fecha;
            oAuditoria.Cantidad = oRemito.Cantidad;
            oAuditoria.CalifCantidad = oRemito.CalifCantidad;
            oAuditoria.CalifTiempo = oRemito.CalifTiempo;
            cAuditoria.AGREGAR_AUDITORIAREMITO(oAuditoria);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvMATERIALES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUPDATED.Enabled = true;
        }

        private void dgvMATERIALES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUPDATED.Enabled = true;
            oPEPE = (MODELO.Occantmat)dgvMATERIALES.CurrentRow.DataBoundItem;



            oUpdated = new MODELO.RemitoUpdated();
            oUpdated.nroOrden = oPEPE.ordercompra;
            oUpdated.material = oPEPE.material;

            oUpdated.remito = txtNROREMITO.Text;
            //oUpdated.material.DESCRIPCION_CORTA = oPEPE.material;

            //oUpdated.Material = oPEPE.cantidadmat.Material.DESCRIPCION_CORTA;


            txtCANTIDAD.Enabled = true;


        }
        public void ARMA_GRILLA_BAJA()
        {
            //dgvUPDATED.DataSource = null;
            //dgvUPDATED.DataSource= cRemitoUpdated.//



            dgvUPDATED.DataSource = null;
            dgvUPDATED.DataSource = cOccantmat.obtenerOccantmat(oOrden);




        }

        private void btnVERIFCANT_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(txtCANTIDAD.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad valida");
                return;
            }
            if (string.IsNullOrEmpty(txtCANTIDAD.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a 0");
                return;
            }
            int count = 0;

            for (int i = 0; i < listaMaterialesUpdated.LongCount(); i++)
            {
                if (listaMaterialesUpdated[i].material == oPEPE.material)
                {
                    MessageBox.Show("Hola capo, este material ya existe");

                    return;
                }
                count++;
            }

            int txtcant = int.Parse(txtCANTIDAD.Text.ToString());

            cantidadIngresada += txtcant;

            int cantidadd = Convert.ToInt32(txtCANTIDAD.Text);
            //oUpdated.Cantidad_mat = oPEPE.cantidadmat.Cantidad_mat - cantidad;
            oUpdated.Cantidad_Ingresada = Convert.ToInt32(txtCANTIDAD.Text);

            if (count == listaMaterialesUpdated.Count)
            {
                listaMaterialesUpdated.Add(oUpdated);
                txtCANTIDAD.Text = "";
            }




            dgvUPDATED.DataSource = null;
            dgvUPDATED.DataSource = listaMaterialesUpdated;






            dgvUPDATED.Columns["codigo"].Visible = false;
            dgvUPDATED.Columns["nroOrden"].Visible = false;
        }

        private void dgvMATERIALES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvUPDATED.Enabled = true;
        }

        private void dgvUPDATED_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUPDATED_DoubleClick(object sender, EventArgs e)
        {
            oUpdated = (MODELO.RemitoUpdated)dgvUPDATED.CurrentRow.DataBoundItem;
            listaMaterialesUpdated.Remove(oUpdated);


            dgvUPDATED.DataSource = null;
            dgvUPDATED.DataSource = listaMaterialesUpdated;

            dgvUPDATED.Columns["codigo"].Visible = false;
            dgvUPDATED.Columns["nroOrden"].Visible = false;
        }

        private void txtCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }
    }
}
