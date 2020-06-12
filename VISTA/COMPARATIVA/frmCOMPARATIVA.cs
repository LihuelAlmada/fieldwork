using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel﻿;
using OfficeOpenXml;
using System.Windows.Forms.DataVisualization.Charting;


namespace VISTA
{
    public partial class frmCOMPARATIVA : MetroFramework.Forms.MetroForm
    {
        
        CONTROLADORA.cMateriales cMateriales;
        CONTROLADORA.cOccantmat cOccantmat;
        CONTROLADORA.cOccantmatVenta cOccantmatVenta;
        List<MODELO.magiafinal> listFinal;
        List<MODELO.magiafinal> listFinality;
        List<MODELO.magiafinal> listDefinitiva;
        List<MODELO.magiafinal> listDefinitivaSuperSaiain;
        List<MODELO.magiafinal> listDefinitivaSuperSaiain2;

        string ubicacionExport = "";
        MODELO.magiafinal omagic;
        bool grafico=false;
        bool exportar = false;
        bool noexportasmas = false;
        List<MODELO.oCanmatVenta> listVenta;

        List<MODELO.oCanmatVenta> listVentaCargada;

        List<MODELO.Occantmat> listCompra;

        List<DateTime> FechasChart;

        MODELO.Materiales oMaterial;
        //MODELO.Occantmat oOccantmat;
        public frmCOMPARATIVA()
        {
            InitializeComponent();
            dtpDESDE.Value = DateTime.Now.AddDays(-30);
            dtpHASTA.Value = DateTime.Now;
            ubicacionExport = txtUBICACION.Text;
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            cOccantmat = CONTROLADORA.cOccantmat.obtener_instancia();
            cOccantmatVenta = CONTROLADORA.cOccantmatVenta.obtener_instancia();
            listFinal = new List<MODELO.magiafinal>();
            listVentaCargada = new List<MODELO.oCanmatVenta>();
            listVenta = new List<MODELO.oCanmatVenta>();
            listFinality = new List<MODELO.magiafinal>();
            listDefinitiva = new List<MODELO.magiafinal>();
            listDefinitivaSuperSaiain = new List<MODELO.magiafinal>();
            listDefinitivaSuperSaiain2 = new List<MODELO.magiafinal>();
            FechasChart = new List<DateTime>();
            dtpDESDE.Value = DateTime.Today;
            dtpHASTA.Value = DateTime.Today;

            
        }

        #region Lupa Materiales
        public void btnLUPA_Click(object sender, EventArgs e)
        {
            MATERIALES.frmMATERIALES frm = new MATERIALES.frmMATERIALES("Buscar");
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                oMaterial = frm.MaterialSelect;
                txtMATERIAL.Text = oMaterial.DESCRIPCION_CORTA;
            }
        }
        #endregion

        public void armo_grilla()
        {
            //dgvPRIMERA.DataSource = null;
            //dgvPRIMERA.DataSource = cOccantmat.SuperFiltro(dtpDESDE.Value, dtpHASTA.Value, txtMATERIAL.Text);
        }

        public void armo_grilla_venta()
        {
            dgvORDENESVENTA.DataSource = null;
            dgvORDENESVENTA.DataSource = cOccantmatVenta.SuperFiltroVenta(dtpDESDE.Value, dtpHASTA.Value, txtMATERIAL.Text);
 

        }

        public void limpiar_grafica()
        {
            dgvORDENESVENTA.DataSource = null;
            grafico = false;
            exportar= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMATERIAL.Text == "")
            {
                MessageBox.Show("Debe seleccionar un material para poder graficar");
                return;
            }
            if (dtpDESDE.Value == dtpHASTA.Value)
            {
                MessageBox.Show("No se puede graficar si las fechas comparadas son la misma");
                return;
            }
            if (grafico==true)
            {
                MessageBox.Show("Ya hay una grafica con este material");
                return;
            }
            exportar = true;
            grafico = true;
            dgvORDENESVENTA.DataSource = null;
            listCompra = cOccantmat.SuperFiltro(dtpDESDE.Value, dtpHASTA.Value, txtMATERIAL.Text);
           // istVentaCargada = cOccantmatVenta.SuperFiltroVenta(dtpDESDE.Value, dtpHASTA.Value, txtMATERIAL.Text);
            listVenta = cOccantmatVenta.SuperFiltroVenta(dtpDESDE.Value, dtpHASTA.Value, txtMATERIAL.Text);

            


            //foreach (var item in listVentaCargada)
            //{
            //    if (listVentaCargada.LongCount()==0)
            //    {
            //        listVenta.Add(item);
            //    }
            //    foreach (var item2 in listVenta)
            //    {
            //        if (item.venta.Fecha.ToString("yy/MM/dd") == item2.venta.Fecha.ToString("yy/MM/dd"))
            //        {
            //            item.cantidadmat.cantidad_base_venta += item2.cantidadmat.cantidad_base_venta;

            //        }
            //        if (item.venta.Fecha.ToString("yy/MM/dd") != item2.venta.Fecha.ToString("yy/MM/dd"))
            //        {
            //            listVenta.Add(item);

            //        }
            //    }


            //}



            if (listCompra.Count()>= listVenta.Count())
            {
                foreach (var item in listCompra)
                {
                    omagic = new MODELO.magiafinal();
                    //omagic.Fecha = "";
                    //omagic.cantVenta = 0;
                    //omagic.cantCompra = 0;
                    omagic.Fecha = item.ordercompra.Fecha.ToString("yy/MM/dd");
                    omagic.cantCompra = item.cantidadmat.cantidad_base;
                    foreach (var itemV in listVenta)
                    {
                       
                        if (itemV.venta.Fecha.ToString("yy/MM/dd") == omagic.Fecha)
                        {
                            omagic.cantVenta += itemV.cantidadmat.cantidad_base_venta;
                            //omagic.diferencia = omagic.cantVenta - omagic.cantCompra;

                        }

                        else
                        {
                            //omagic.cantVenta = 0;
                        }
                    }

                    listFinal.Add(omagic);

                }
            }
            else
            {
                foreach (var item in listVenta)
                {
                    omagic = new MODELO.magiafinal();
                    //omagic.Fecha = "";
                    //omagic.cantVenta = 0;
                    //omagic.cantCompra = 0;
                    omagic.Fecha = item.venta.Fecha.ToString("yy/MM/dd");
                    omagic.cantVenta = item.cantidadmat.cantidad_base_venta;
                    foreach (var itemV in listCompra)
                    {
                        if (itemV.ordercompra.Fecha.ToString("yy/MM/dd") == omagic.Fecha)
                        {
                            omagic.cantCompra += itemV.cantidadmat.cantidad_base;
                            //omagic.diferencia = omagic.cantCompra - omagic.cantVenta;

                        }
                        else
                        {
                            //omagic.cantCompra = 0;
                        }
                    }
                    listFinal.Add(omagic);

                }
            }//CREO QUE LO AGREGAMSO MUCHAS VECES.
            foreach (var item in listFinal)
            {

                int count = 0;
                if (listFinality.LongCount() < 1)
                {
                    listFinality.Add(item);
                }
                foreach (var item2 in listFinality)
                {
                    if (item.Fecha != item2.Fecha)
                    {
                        count++;
                    }
                }

                if (listFinality.LongCount() == count)
                {
                    listFinality.Add(item);
                }
                else
                {
                    //listFinality.Remove(item);
                    foreach (var item2 in listFinality)
                    {
                        if (item.Fecha == item2.Fecha)
                        {
                            item.cantVenta += item2.cantVenta;
                            
                        }
                    }
                    listFinality.Add(item);


                }


            }

            foreach (var item in listFinality)
            {
                omagic=item;
                foreach (var item2 in listFinality)
                {
                    
                    if (item.Fecha == item2.Fecha && item.cantVenta<item2.cantVenta)
                    {
                        omagic = item2;
                    }
                }
                listDefinitiva.Add(omagic);

            }
            foreach (var item in listDefinitiva)
            {
                omagic = item;
                foreach (var item2 in listDefinitiva)
                {

                    if (item.Fecha == item2.Fecha && item.cantCompra < item2.cantCompra)
                    {
                        omagic = item2;
                    }
                }
                listDefinitivaSuperSaiain2.Add(omagic);

            }

            foreach (var item in listDefinitivaSuperSaiain2)
            {
                if (!listDefinitivaSuperSaiain.Contains(item))
                {
                    listDefinitivaSuperSaiain.Add(item);
                }
            }

            dgvORDENESVENTA.DataSource = listDefinitivaSuperSaiain;

            for (int i = 0; i < dgvORDENESVENTA.Rows.Count; i++)
            {
                this.chart1.Series["Compras"].Points.AddXY(dgvORDENESVENTA.Rows[i].Cells[0].Value.ToString(), Convert.ToDecimal(dgvORDENESVENTA.Rows[i].Cells[1].Value.ToString()));
                this.chart1.Series["Ventas"].Points.AddXY(dgvORDENESVENTA.Rows[i].Cells[0].Value.ToString(), Convert.ToDecimal(dgvORDENESVENTA.Rows[i].Cells[2].Value.ToString()));
                //chart1.Update();
            }
        }

        private void btnEXPORTAR_Click(object sender, EventArgs e)
        {
            if (noexportasmas==true)
            {
                MessageBox.Show("Ya has exportado esta comparativa");
                return;
            }
            if (exportar == false)
            {
                MessageBox.Show("Debe generar una grafica, por favor haga clic en graficar.");
                return;
            }

                StreamWriter sw = new StreamWriter(ubicacionExport + "\\COMPRAS_VS_VENTAS.csv");

                for (int i = 0; i < dgvORDENESVENTA.Columns.Count; i++)
                {
                    sw.Write(dgvORDENESVENTA.Columns[i].HeaderText);
                    if (i != dgvORDENESVENTA.Columns.Count)
                    {
                        sw.Write(",");
                    }

                }

                sw.Write(sw.NewLine);

                foreach (DataGridViewRow dr in dgvORDENESVENTA.Rows)
                {
                    for (int i = 0; i < dgvORDENESVENTA.Columns.Count; i++)
                    {
                        sw.Write(dr.Cells[i].Value);
                        if (i != dgvORDENESVENTA.Columns.Count)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.Write(sw.NewLine);
                }
                sw.Flush();

                sw.Close();

                /////// csv a xls
                ///

                string csvFileName = ubicacionExport + "\\COMPRAS_VS_VENTAS.csv";
                string excelFileName = ubicacionExport + "\\COMPRAS_VS_VENTAS.xls";

                string worksheetsName = oMaterial.COD_MATERIAL + " - " + DateTime.Now.ToString();

                bool firstRowIsHeader = false;

                var format = new ExcelTextFormat();
                format.Delimiter = ',';
                format.EOL = "\r";              // DEFAULT IS "\r\n";
                                                // format.TextQualifier = '"';

                using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFileName)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(worksheetsName);
                    worksheet.Cells["A1"].LoadFromText(new FileInfo(csvFileName), format, OfficeOpenXml.Table.TableStyles.Medium27, firstRowIsHeader);
                    package.Save();
                }

                Console.WriteLine("Finished!");
                Console.ReadLine();
                MessageBox.Show("Exportado con éxito en: " + ubicacionExport, "Notificación", MessageBoxButtons.OK);

                noexportasmas = true;
                //this.Close();
            



        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void btngrafica_Click(object sender, EventArgs e)
        {

            
        }

        private void dtpHASTA_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHASTA.Value < dtpDESDE.Value)
            {
                MessageBox.Show("La fecha debe de ser mayor a la fecha comparada");
                dtpHASTA.Value = DateTime.Today;
                return;
            }
            
        }

        private void dtpDESDE_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDESDE.Value > dtpHASTA.Value)
            {
                MessageBox.Show("La fecha debe de ser menor a la fecha comparada");
                dtpDESDE.Value = DateTime.Today;

                return;
            }
            

        }

        private void dtpDESDE_Enter(object sender, EventArgs e)
        {
            
        }

        private void Settings_Click(object sender, EventArgs e) ///cambiar directorio
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = ("Seleccione un directorio" + Environment.NewLine + "Directorio actual: " + ubicacionExport);
            if (fbd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Directorio seleccionado: " + fbd.SelectedPath);
                txtUBICACION.Text = fbd.SelectedPath.ToString();
                ubicacionExport = txtUBICACION.Text;
            }
        }

        private void frmCOMPARATIVA_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void frmCOMPARATIVA_Load(object sender, EventArgs e)
        {
            txtUBICACION.Text = Properties.Settings.Default.TextBox;
            ubicacionExport = txtUBICACION.Text;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            this.chart1.Series["Compras"].BorderWidth = 7;
            this.chart1.Series["Ventas"].BorderWidth = 7;
            dtpDESDE.Value = DateTime.Now.AddDays(-30);
            dtpHASTA.Value = DateTime.Now;
        }

        private void frmCOMPARATIVA_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TextBox = txtUBICACION.Text;
            Properties.Settings.Default.Save();
        }

       
    }
}
/*foreach (var item in listFinal)
            {
                int count = 0;
                
                bool grande = true;
                omagic = new MODELO.magiafinal();
                omagic = item;
                foreach (var item2 in listFinal)
                { 
                    if (item.Fecha==item2.Fecha)
                    {
                        count++;
                        if (item.cantVenta < item2.cantVenta)
                        {
                            grande = false;
                        }
                    }
                }
                if (count>=2 || grande==true)
                {
                    listFinality.Add(omagic);
                    //BANCAME 1 I
                }
*/

                /*Foreach 
                Omagic
                foreach 
                If fechas iguales y cantidad 2>cantidad 1
                Omagic =2

                Add(Omagic)
                */