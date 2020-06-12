using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.VENTAS
{
    public partial class frmVENTA : MetroFramework.Forms.MetroForm
    {
        string accion;
        CONTROLADORA.cOrdenCompra cOrden;
        CONTROLADORA.cMateriales cMateriales;
        CONTROLADORA.cProveedor cProveedor;
        CONTROLADORA.cCantMat cCantMat;
        CONTROLADORA.cOccantmatVenta cOccantmat;
        CONTROLADORA.cOrdenVenta cOrdenVenta;
        CONTROLADORA.cAuditoria cAuditoria;
        MODELO.CantidadMat oCANTMAT;
        MODELO.Cliente clientesovicj;
        MODELO.Cliente oCliente;
        MODELO.Materiales oMATERIAL;
        MODELO.Venta oORDEN;
        double totalivadesc;
        double totalDescuento;
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


        public frmVENTA()
        {
            InitializeComponent();
            cOrden = CONTROLADORA.cOrdenCompra.obtener_instancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cCantMat = CONTROLADORA.cCantMat.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            cOccantmat = CONTROLADORA.cOccantmatVenta.obtener_instancia();
            cOrdenVenta = CONTROLADORA.cOrdenVenta.obtener_instancia();
            listaMateriales = new List<MODELO.Materiales>();
            listaCantMateriales = new List<MODELO.CantidadMat>();
            listaImportes = new List<double>();
            listaIva = new List<double>();
            listaDescuentos = new List<double>();
            listaPrecioTotal = new List<double>();
            //txtNROORDEN.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            //txtNROORDEN.Enabled = false;
            txtCANTIDAD.Enabled = false;
            txtPUC.Enabled = false;
            txtCANTIDAD.Enabled = false;
            //txtUNIDADMEDIDA.Enabled = false;
            txtIVATOTAL.Enabled = false;
            txtIMPORTE_TOTAL.Enabled = false;
            txtDESCUENTO.Enabled = false;
            txtIMPORTE.Enabled = false;
            txtIVA.Enabled = false;
            txtCANTIDAD.Enabled = false;
            txtDTOTOTAL.Enabled = false;
            txtCANTIDADD.Enabled = false;
            //txtPROVEEDOR.Enabled = false;
            dtpFECHA.Enabled = false;
            oORDEN = new MODELO.Venta();
            txtNROFACTURA.Text= DateTime.Now.ToString("yyyyMMddHHmmss");
            txtCLIENTE.Enabled = false;
            arma_grilla();
        }
        public frmVENTA(MODELO.Venta unaOrden, string unaaccion)
        {
            InitializeComponent();
            cOrden = CONTROLADORA.cOrdenCompra.obtener_instancia();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cCantMat = CONTROLADORA.cCantMat.obtener_instancia();
            cAuditoria = CONTROLADORA.cAuditoria.obtenerInstancia();
            cOccantmat = CONTROLADORA.cOccantmatVenta.obtener_instancia();
            cOrdenVenta = CONTROLADORA.cOrdenVenta.obtener_instancia();
            //oORDEN = new MODELO.OrdenCompra();
            oORDEN = unaOrden;
            accion = unaaccion;
            //txtNROORDEN.Enabled = false;
            //txtPROVEEDOR.Enabled = false;
            dtpFECHA.Enabled = false;
            //dtpFECHARECEPCION.Enabled = false;
            txtNROFACTURA.Text = oORDEN.nroFactura;
            txtCLIENTE.Enabled = false;
            txtCLIENTE.Text = oORDEN.Cliente.ToString();
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
            txtCANTIDADD.Enabled = false;
            //txtUNIDADMEDIDA.Enabled = false;
            txtDESCUENTO.Enabled = false;
            btnAGREGAR.Enabled = false;
            //button2.Enabled = false;
            if (accion == "M")
            {
                //txtNROORDEN.Text = oORDEN.NroOrden.ToString();
                //txtPROVEEDOR.Text = oORDEN.Proveedor.ToString();
                dtpFECHA.Value = oORDEN.Fecha;
                //dtpFECHARECEPCION.Value = oORDEN.Fecha_Recepcion;
                txtIMPORTE.Text = oORDEN.Importe.ToString();
                txtIVATOTAL.Text = oORDEN.IvaTotal.ToString();
                txtIMPORTE_TOTAL.Text = oORDEN.Importe.ToString();
                //txtDESCUENTO.Text = oORDEN.Descuento.ToString();
                txtDTOTOTAL.Text = oORDEN.DescuentoTotal.ToString();
                //txtCANTIDAD.Text = oORDEN.Cantidad.ToString();
                //txtPUC.Text = oORDEN.Puc.ToString();
                //txtIVA.Text = oORDEN.Iva.ToString();
                //txtUNIDADMEDIDA.Text = oORDEN.UnidadMedida.ToString();
                //txtDESCUENTO.Text = oORDEN.Descuento.ToString();
                btnMAS.Enabled = false;

                dgvOCM.Enabled = false;
                dgvOCM.DataSource = null;
                dgvOCM.DataSource = cOrdenVenta.obtenerPorVenta(txtNROFACTURA.Text);


            }
        }


        public void arma_grilla()
        {
            dgvMATERIALES.DataSource = null;
            dgvMATERIALES.DataSource = cMateriales.obtenerMaterialNombre(txtMATERIAL.Text);
        }

        private void btnLUPA_Click(object sender, EventArgs e) // lupa cliente
        {
            CLIENTES.frmCLIENTES frm = new CLIENTES.frmCLIENTES();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oCliente = frm.ClienteSelect;

                clientesovicj = oCliente;

            }
            txtCLIENTE.Text = oCliente.nombre;
        
        }

        private void dgvMATERIALES_Click(object sender, EventArgs e)
        {
            oMATERIAL = (MODELO.Materiales)dgvMATERIALES.CurrentRow.DataBoundItem;
            txtCANTIDADD.Text = oMATERIAL.MEDIDA;
            txtIVA.Text = oMATERIAL.IVA.ToString();
            txtCANTIDAD.Enabled = true;
            txtPUC.Text = oMATERIAL.PUC.ToString();
            txtCANTIDADD.Enabled = true;
            txtDESCUENTO.Enabled = true;
        }

        private void btnMAS_Click(object sender, EventArgs e)
        {
           /* if (oMATERIAL.STOCK < Convert.ToInt32(txtCANTIDAD.Text))
            {
                MessageBox.Show("La cantidad ingresada supera al stock, pongase en contacto con soporte");
                return;
            }*/
            if (string.IsNullOrEmpty(txtCANTIDAD.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a 0");
                return;
            }
            int cantidadd = Convert.ToInt32(txtCANTIDAD.Text);
            if (cantidadd <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad correcta");
                return;
            }
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
            if (Convert.ToInt32(txtDESCUENTO.Text) < 0 || (Convert.ToInt32(txtDESCUENTO.Text) > 100))
            {
                MessageBox.Show("El numero de descuento ingresado es incorrecto");
                return;

            }

            if (string.IsNullOrEmpty(txtCANTIDADD.Text))
            {
                MessageBox.Show("Debe ingresar un descuento valido");
                return;
            }

            Int32 cantidad;
            cantidad = (Convert.ToInt32(txtCANTIDAD.Text));
            totalivadesc = 0;
            puc = double.Parse(txtPUC.Text);
            cantidad = Convert.ToInt16(txtCANTIDAD.Text);
            double total = (puc * cantidad);
            
            ///////iva

            double ivaParcial = (oMATERIAL.IVA * total) / 100;
            ///descuento
            ///
            

            double descuentoparcial = (Convert.ToDouble(txtDESCUENTO.Text) * total) / 100;

            if ((cantidad > oMATERIAL.STOCK))
            {
                MessageBox.Show("La cantidad ingresada supera el stock actual de este material");
                return;
            }

           
            int count = 0;



            //oORDEN = new MODELO.OrdenCompra();
            //oCANTMAT = new MODELO.CantidadMat();

            //oMATERIAL = (MODELO.Materiales)dgvMATERIALES.CurrentRow.DataBoundItem;

            //oCANTMAT.Material = oMATERIAL;
            //oCANTMAT.Cantidad_mat = Convert.ToInt32(txtCANTIDAD.Text);

            //cCantMat.agregarCantMat(oCANTMAT);




            for (int i = 0; i < listaCantMateriales.LongCount(); i++)
            {
                if (listaCantMateriales[i].Material.DESCRIPCION_CORTA == oMATERIAL.DESCRIPCION_CORTA)
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
            mat.cantidad_base_venta = mat.Cantidad_mat;

            oMATERIAL.PUC = Convert.ToInt32(txtPUC.Text);
            //oMATERIAL.STOCK = oMATERIAL.STOCK - Convert.ToInt32(txtCANTIDAD.Text);
            //cMateriales.modificarMateriales(oMATERIAL);

            cCantMat.agregarCantMat(mat);
            listaCantMateriales.Add(mat);
            

            dgvOCM.DataSource = null;
            dgvOCM.DataSource = listaCantMateriales;
            txtCANTIDAD.Enabled = false;
            txtPUC.Enabled = false;
            txtDESCUENTO.Enabled = false;
            txtCANTIDAD.Text = "";
            txtPUC.Text = "";
            txtIVA.Text = "";
            txtDESCUENTO.Text = "";

            txtIMPORTE_TOTAL.Text = totalivadesc.ToString();
            txtDTOTOTAL.Text = totaldescuento.ToString();
            txtIMPORTE.Text = totalfinal.ToString();
            txtIVATOTAL.Text = totaliva.ToString();
            //double total = myList.Sum(item => item.Amount);



            dgvOCM.Enabled = true;
            //txtIMPORTE.Text = Convert.ToInt32(txtCANTIDAD.Text * txtPUC.Text);
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {

            if (dgvOCM.Rows.Count == 0)
            {
                MessageBox.Show("La orden de Compra se encuentra vacia, por favor ingrese un material");
                return;
            }
            

            if (string.IsNullOrEmpty(txtNROFACTURA.Text))
            {
                MessageBox.Show("Debe ingresar un numero de orden");
                return;
            }
            if (string.IsNullOrEmpty(txtCLIENTE.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            if (string.IsNullOrEmpty(dtpFECHA.Text))
            {
                MessageBox.Show("Debe ingresar una fecha");
                return;
            }




            oORDEN.nroFactura = txtNROFACTURA.Text;
            //oORDEN.Proveedor = oPROVEEDOR.razonSocial;
            oORDEN.Cliente = clientesovicj;
            
            //oORDEN.Proveedor =;
            //oORDEN.Proveedor = (MODELO.Proveedor)ToString();
            //oORDEN.Proveedor = txtPROVEEDOR.Text; /////////////////////////////////////////////////////////////////////////////////
            oORDEN.Fecha = dtpFECHA.Value;
            oORDEN.IvaTotal = Convert.ToDecimal(txtIVATOTAL.Text);
            oORDEN.Importe = Convert.ToDecimal(totalivadesc);
            oORDEN.DescuentoTotal = Convert.ToDecimal(totaldescuento);
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
            


            MODELO.oCanmatVenta Occantmat = new MODELO.oCanmatVenta();
            foreach (MODELO.CantidadMat item in listaCantMateriales)
            {
                //int cantidadd = Convert.ToInt32(txtCANTIDAD.Text);
                oMATERIAL = item.Material;
                Occantmat.cantidadmat = item;
                Occantmat.venta = oORDEN;
                Occantmat.material = item.Material.DESCRIPCION_CORTA;
                Occantmat.cantidadmat.cantidad_base_venta = item.cantidad_base_venta;

                oMATERIAL = (MODELO.Materiales)cMateriales.obtenerMaterialNombree(item.Material.DESCRIPCION_CORTA)[0];

                oMATERIAL.STOCK -= item.Cantidad_mat;
                cMateriales.modificarMateriales(oMATERIAL);

                cOccantmat.agregarOccantmatVenta(Occantmat);
            }

            //oMATERIAL.STOCK = oMATERIAL.STOCK - Convert.ToInt32(txtCANTIDAD.Text);

            

            

            

            this.DialogResult = DialogResult.OK;
            AGREGAR_AUDITORIA("Alta", oORDEN);


        }
        public void AGREGAR_AUDITORIA(string movimiento, MODELO.Venta oVENTA)
        {
            MODELO.AuditoriaVenta oAuditoria = new MODELO.AuditoriaVenta();
            oAuditoria.FechayHora = dtpFECHA.Value;
            oAuditoria.Movimiento = movimiento;
            oAuditoria.Username = "SuperUsuario";    
            oAuditoria.codigo = oVENTA.codigo;
            oAuditoria.nroFactura = oVENTA.nroFactura;
            oAuditoria.Cliente = oVENTA.Cliente;
            oAuditoria.Fecha = oVENTA.Fecha;
            oAuditoria.Importe = oVENTA.Importe;
            oAuditoria.IvaTotal = oVENTA.IvaTotal;
            oAuditoria.DescuentoTotal = oVENTA.DescuentoTotal;
            cAuditoria.AGREGAR_AUDITORIA(oAuditoria);
        }



        private void dgvOCM_DoubleClick(object sender, EventArgs e)
        {
            oCANTMAT = (MODELO.CantidadMat)dgvOCM.CurrentRow.DataBoundItem;
            listaCantMateriales.Remove(oCANTMAT);

            dgvOCM.DataSource = null;
            dgvOCM.DataSource = listaCantMateriales;





        }

        
        private void txtMATERIAL_TextChanged(object sender, EventArgs e)
        {
            if (txtMATERIAL.TextLength > 0 || txtMATERIAL.TextLength == 0) ARMO_GRILLA();
        }


        public void ARMO_GRILLA()
        {
            dgvMATERIALES.DataSource = null;
            dgvMATERIALES.DataSource = cMateriales.obtenerMaterialNombre(txtMATERIAL.Text);
            

        }

        private void txtCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void txtDESCUENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            COMUN.MetodosComunes.KeyPressSoloNumeros(e);
        }
    }
}
