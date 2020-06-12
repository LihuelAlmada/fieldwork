using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.OC
{
    public partial class frmORDEN_COMPRA : MetroFramework.Forms.MetroForm
    {
        string accion;
        CONTROLADORA.cOrdenCompra cOrden;
        CONTROLADORA.cMateriales cMateriales;
        CONTROLADORA.cProveedor cProveedor;
        CONTROLADORA.cCantMat cCantMat;
        CONTROLADORA.cOccantmat cOccantmat;
        CONTROLADORA.cAuditoria cAuditoria;
        MODELO.CantidadMat oCANTMAT;
        MODELO.Proveedor provedoransiovich;
        MODELO.Proveedor oPROVEEDOR;
        MODELO.Materiales oMATERIAL;
        MODELO.Factura oORDEN;
        MODELO.CantidadMat oPEPE;
        double totalivadesc;
        List<MODELO.Materiales> listaMateriales;
        List<MODELO.CantidadMat> listaCantMateriales;
        List<double> listaImportes;
        List<double> listaDescuentos;
        List<double> listaIva;
        List<double> listaPrecioTotal;
        double puc;
        int cantidad;
        double totalfinal = 0;
        double totaliva = 0;
        double totaldescuento = 0;
        string proveedorglobal;
        public frmORDEN_COMPRA()
        {
            InitializeComponent();
            cOrden = CONTROLADORA.cOrdenCompra.obtener_instancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cCantMat = CONTROLADORA.cCantMat.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            cOccantmat = CONTROLADORA.cOccantmat.obtener_instancia();
            listaMateriales = new List<MODELO.Materiales>();
            listaCantMateriales = new List<MODELO.CantidadMat>();
            listaImportes = new List<double>();
            listaIva = new List<double>();
            listaDescuentos = new List<double>();
            listaPrecioTotal = new List<double>();
            txtNROORDEN.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            txtNROORDEN.Enabled = false;
            txtCANTIDAD.Enabled = false;
            txtPUC.Enabled = false;
            txtCANTIDAD.Enabled = false;
            txtUNIDADMEDIDA.Enabled = false;
            txtIVATOTAL.Enabled = false;
            txtIMPORTE_TOTAL.Enabled = false;
            //btnAGREGAR.Enabled = false;
            txtDESCUENTO.Enabled = false;
            txtIMPORTE.Enabled = false;
            txtIVA.Enabled = false;
            txtDTOTOTAL.Enabled = false;
            txtPROVEEDOR.Enabled = false;
            oORDEN = new MODELO.Factura();
            



        }
        
        public frmORDEN_COMPRA(MODELO.Factura unaOrden, string unaaccion)
        {
            InitializeComponent();
            cOrden = CONTROLADORA.cOrdenCompra.obtener_instancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cCantMat = CONTROLADORA.cCantMat.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            cOccantmat = CONTROLADORA.cOccantmat.obtener_instancia();
            //oORDEN = new MODELO.OrdenCompra();
            oORDEN = unaOrden;
            accion = unaaccion;
            txtNROORDEN.Enabled = false;
            txtPROVEEDOR.Enabled = false;
            dtpFECHARECEPCION.Enabled = false;
            txtIMPORTE.Enabled = false;
            txtIVATOTAL.Enabled = false;
            txtDESCUENTO.Enabled = false;
            txtIMPORTE_TOTAL.Enabled = false;
            txtMATERIAL.Enabled = false;
            txtDTOTOTAL.Enabled = false;
            btnLUPA.Enabled = false;
            txtCANTIDAD.Enabled = false;
            txtPUC.Enabled = false;
            txtIVA.Enabled = false;
            txtUNIDADMEDIDA.Enabled = false;
            txtDESCUENTO.Enabled = false;
            //btnAGREGAR.Enabled = false;
            button2.Enabled = false;

            if (accion == "M")
            {
                txtNROORDEN.Text = oORDEN.NroOrden.ToString();
                txtPROVEEDOR.Text = oORDEN.Proveedor.ToString();
                dtpFECHARECEPCION.Value = oORDEN.Fecha_Recepcion;
                txtIMPORTE.Text = oORDEN.Importe.ToString();
                txtIVATOTAL.Text = oORDEN.IvaTotal.ToString();
                txtIMPORTE_TOTAL.Text = oORDEN.Importe.ToString();
                txtDESCUENTO.Text = oORDEN.Descuento.ToString();
                txtDTOTOTAL.Text = oORDEN.DescuentoTotal.ToString();
                txtCANTIDAD.Text = oORDEN.Cantidad.ToString();
                txtPUC.Text = oORDEN.Puc.ToString();
                //txtIVA.Text = oORDEN.Iva.ToString();
                //txtUNIDADMEDIDA.Text = oORDEN.UnidadMedida.ToString();
                txtDESCUENTO.Text = oORDEN.Descuento.ToString();
                dgvOCM.DataSource = null;
                dgvOCM.DataSource = cOccantmat.obtenerOccantmat(oORDEN);
            }
        }
        public void ARMO_GRILLA()
        {
            dgvMATERIALES.DataSource = null;
            dgvMATERIALES.DataSource = cMateriales.obtenerMaterialNombreProveedor(txtMATERIAL.Text,proveedorglobal);     
        }
        public void ARMO_GRILLAFILTRADAPAPU()
        {
            dgvMATERIALES.DataSource = null;
            dgvMATERIALES.DataSource = cMateriales.obtenerMaterialProveedor(txtPROVEEDOR.Text);
        }

        private void btnLUPA_Click(object sender, EventArgs e)
        {
            PROVEEDORES.PROVEEDORES frm = new PROVEEDORES.PROVEEDORES("Buscar");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oPROVEEDOR = frm.ProveedorSelect;
                txtPROVEEDOR.Text = oPROVEEDOR.razonSocial;
                provedoransiovich = oPROVEEDOR;
                txtIVA.Text = "";

                string proveedor = oPROVEEDOR.razonSocial;
                proveedorglobal = proveedor;
                totalfinal = 0;
                totaliva = 0;
                totaldescuento = 0;
                //listaMateriales = new List<MODELO.Materiales>();

                dgvOCM.DataSource = null;
                dgvOCM.DataSource = listaCantMateriales;


                txtIMPORTE.Text = "";
                txtIVATOTAL.Text = "";
                txtDTOTOTAL.Text = "";
                txtIMPORTE_TOTAL.Text = "";


                txtCANTIDAD.Text = "";
                txtPUC.Text = "";
                txtDESCUENTO.Text = "";
                ARMO_GRILLAFILTRADAPAPU();
                //cmbPROVEEDOR.SelectedItem = oPROVEEDOR;
            }
        }
        public void button2_Click(object sender, EventArgs e) // boton +
        {
            if (txtCANTIDAD.Text== "" || Convert.ToInt32(txtCANTIDAD.Text) < 0 )
            {
                MessageBox.Show("Debe ingresar una cantidad correcta");
                return;
            }
            try
            {
                Int32.Parse(txtPUC.Text);
            }
            catch
            {
                MessageBox.Show("El PUC es invalido");
                return;
            }
            if (txtPUC.Text== "" || Convert.ToInt32(txtPUC.Text) < 0)
            {
                MessageBox.Show("Debe ingresar un puc correcto");
                return;
            }
            if (txtDESCUENTO.Text == "" || Convert.ToInt32(txtDESCUENTO.Text) < 0 || Convert.ToInt32(txtDESCUENTO.Text) >= 100)
            {
                MessageBox.Show("Debe ingresar un descuento correcto");
                return;
            }

            Int32 cantidad;
            cantidad = (Convert.ToInt32(txtCANTIDAD.Text));
            totalivadesc = 0;
            puc = double.Parse(txtPUC.Text);
            cantidad = Convert.ToInt16(txtCANTIDAD.Text);
            double total = (puc * cantidad);

            double ivaParcial = (oMATERIAL.IVA * total) / 100;
            ///descuento
            ///
            if (Convert.ToInt32(txtDESCUENTO.Text) < 0 || (Convert.ToInt32(txtDESCUENTO.Text) > 100))
            {
                MessageBox.Show("El numero de descuento ingresado es incorrecto");
                return;

            }
            if (DateTime.Now > dtpFECHARECEPCION.Value)
            {
                MessageBox.Show("La fecha de entrega no puede ser anterior a la fecha de hoy. Pongase en contacto con soporte");
                return;
            }

            double descuentoparcial = (Convert.ToDouble(txtDESCUENTO.Text) * total) / 100;
            /*if ((cantidad + oMATERIAL.STOCK) > oMATERIAL.MAXIMO)
            {
                MessageBox.Show("La cantidad ingresada supera el MAXIMO de ese material, ponganse en contacto con el soporte");
                return;
            }*/

            if (string.IsNullOrEmpty(txtCANTIDAD.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a 0");
                return;
            }
            if (string.IsNullOrEmpty(txtPUC.Text))
            {
                MessageBox.Show("Debe ingresar un PUC valido");
                return;
            }
            if (string.IsNullOrEmpty(txtDESCUENTO.Text))
            {
                MessageBox.Show("Debe ingresar un descuento valido");
                return;
            }
            int count = 0;

            //oORDEN = new MODELO.OrdenCompra();
            //oCANTMAT = new MODELO.CantidadMat();

            //oMATERIAL = (MODELO.Materiales)dgvMATERIALES.CurrentRow.DataBoundItem;

            //oCANTMAT.Material = oMATERIAL;
            //oCANTMAT.Cantidad_mat = Convert.ToInt32(txtCANTIDAD.Text);

            //cCantMat.agregarCantMat(oCANTMAT);




            for (int i = 0; i < listaMateriales.LongCount(); i++)
            {
                if (listaMateriales[i] == oMATERIAL)
                {
                    MessageBox.Show("El material ya existe");

                    return;
                }
                count++;
            }



            if (count == listaMateriales.LongCount())
            {
                listaMateriales.Add(oMATERIAL);
                ////listaCantMateriales.Add(oCANTMAT);
                listaImportes.Add(total);
                listaIva.Add(ivaParcial);
                listaDescuentos.Add(descuentoparcial);
            }

            for (int i = 0; i < listaImportes.LongCount(); i++)
            {
                totalfinal += total;
                totaliva += ivaParcial;
                totaldescuento += descuentoparcial;
            }

            /////total + iva con el desc

            double totalivadescparcial = ((total + ivaParcial) - descuentoparcial);

            if (count == listaPrecioTotal.LongCount())
            {
                listaPrecioTotal.Add(totalivadescparcial);
            }
            totalivadesc = 0;
            for (int i = 0; i < listaPrecioTotal.LongCount(); i++)
            {
                totalivadesc += totalivadescparcial;
            }
            MODELO.CantidadMat mat = new MODELO.CantidadMat();
            mat.Material = oMATERIAL;
            mat.Cantidad_mat = Convert.ToInt32(txtCANTIDAD.Text);
            mat.cantidad_base = mat.Cantidad_mat;
            cCantMat.agregarCantMat(mat);
            listaCantMateriales.Add(mat);

            oMATERIAL.PUC = Convert.ToInt32(txtPUC.Text);
            cMateriales.modificarMateriales(oMATERIAL);

            dgvOCM.DataSource = null;
            dgvOCM.DataSource = listaCantMateriales;


            txtCANTIDAD.Enabled = false;
            txtPUC.Enabled = false;
            txtDESCUENTO.Enabled = false;
            txtCANTIDAD.Text = "";
            txtPUC.Text = "";
            txtDESCUENTO.Text = "";

            txtIMPORTE_TOTAL.Text = totalivadesc.ToString();
            txtDTOTOTAL.Text = totaldescuento.ToString();
            txtIMPORTE.Text = totalfinal.ToString();
            txtIVATOTAL.Text = totaliva.ToString();
            //double total = myList.Sum(item => item.Amount);



            //txtIMPORTE.Text = Convert.ToInt32(txtCANTIDAD.Text * txtPUC.Text);
        }

        private void dgvMATERIALES_Click_1(object sender, EventArgs e)
        {
            oMATERIAL = (MODELO.Materiales)dgvMATERIALES.CurrentRow.DataBoundItem;
            txtUNIDADMEDIDA.Text = oMATERIAL.MEDIDA;
            txtIVA.Text = oMATERIAL.IVA.ToString();
            txtCANTIDAD.Enabled = true;
            txtPUC.Enabled = true;
            txtDESCUENTO.Enabled = true;
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {

            if (dgvOCM.Rows.Count == 0)
            {
                MessageBox.Show("La orden de Compra se encuentra vacia, por favor ingrese un material");
                return;
            }
            if (DateTime.Now >= dtpFECHARECEPCION.Value)
            {
                MessageBox.Show("La fecha de Recepcion debe ser posterior a la fecha actual");
                return;
            }

            if (string.IsNullOrEmpty(txtNROORDEN.Text))
            {
                MessageBox.Show("Debe ingresar un numero de orden");
                return;
            }
            if (string.IsNullOrEmpty(txtPROVEEDOR.Text))
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }
            if (string.IsNullOrEmpty(dtpFECHARECEPCION.Text))
            {
                MessageBox.Show("Debe ingresar una fecha de recepcion");
                return;
            }



            oORDEN.NroOrden = txtNROORDEN.Text;
            //oORDEN.Proveedor = oPROVEEDOR.razonSocial;
            oORDEN.Proveedor = provedoransiovich;
            oORDEN.Localidad = oPROVEEDOR.Localidad.ToString();
            //oORDEN.Proveedor =;
            //oORDEN.Proveedor = (MODELO.Proveedor)ToString();
            //  oORDEN.Proveedor = txtPROVEEDOR.Text; /////////////////////////////////////////////////////////////////////////////////
            oORDEN.Fecha = DateTime.Now;
            oORDEN.Fecha_Recepcion = dtpFECHARECEPCION.Value;
            oORDEN.Importe = Convert.ToDecimal(totalivadesc);
            //  oORDEN.CantidadesMat.Add(oCANTMAT);



            //foreach (MODELO.CantidadMat item in listaCantMateriales.ToList())
            //{


            //    MODELO.CantidadMat mat = new MODELO.CantidadMat();
            //    mat.Material = item.Material;
            //    mat.Cantidad_mat = item.Cantidad_mat;
            //    cCantMat.agregarCantMat(mat);
            //    listaCantMateriales.Add(mat);
            //    //oORDEN.CantidadesMat.Add(mat);



            //    // item.OrdenCompra.Add(oORDEN);             
            //    // cCantMat.modificarCantMat(item);
            //    //oORDEN.CantidadesMat.Add(item);
            //    // cOrden.modificarOrden(oORDEN);


            //}
            oORDEN.visibily = true;
            cOrden.agregarOrden(oORDEN);
            MODELO.Occantmat Occantmat = new MODELO.Occantmat();
            foreach( MODELO.CantidadMat item in listaCantMateriales)
            {
                Occantmat.cantidadmat = item;
                Occantmat.cantidadmat.cantidad_base = item.cantidad_base;
                Occantmat.ordercompra = oORDEN;
                Occantmat.material = item.Material.DESCRIPCION_CORTA;
                cOccantmat.agregarOccantmat(Occantmat);
            }
            


            AGREGAR_AUDITORIA("Alta",oORDEN);


            this.DialogResult = DialogResult.OK;
        }
        public void AGREGAR_AUDITORIA(string movimiento, MODELO.Factura oORDEN)
        {
            MODELO.AuditoriaOC oAuditoria = new MODELO.AuditoriaOC();
            oAuditoria.FechayHora = System.DateTime.Now;
            oAuditoria.Movimiento = movimiento;
            oAuditoria.Username = "SuperUsuario";

            oAuditoria.NroOrden = oORDEN.NroOrden;
            oAuditoria.Proveedor = oORDEN.Proveedor;


            cAuditoria.AGREGAR_AUDITORIA(oAuditoria);
        }

        private void txtMATERIAL_TextChanged(object sender, EventArgs e)
        {
            if (txtMATERIAL.TextLength > 0 || txtMATERIAL.TextLength == 0) ARMO_GRILLA();
        }

        private void txtCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void txtPUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void txtDESCUENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void dgvOCM_DoubleClick(object sender, EventArgs e)
        {
            oPEPE = (MODELO.CantidadMat)dgvOCM.CurrentRow.DataBoundItem;
            listaCantMateriales.Remove(oPEPE);


            dgvOCM.DataSource = null;
            dgvOCM.DataSource = listaCantMateriales;
        }

        private void txtIMPORTE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//object sender, DataGridViewCellEventArgs e

