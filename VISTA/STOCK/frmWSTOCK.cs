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
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using OfficeOpenXml;


namespace VISTA.STOCK
{
    public partial class frmWSTOCK : MetroFramework.Forms.MetroForm
    {
        CONTROLADORA.cMateriales cMateriales;
        List<DataGridViewColumn> listVisible = new List<DataGridViewColumn>();
        string ubicacionExport = "";
        Microsoft.Office.Interop.Excel.Application ExApp;

        public frmWSTOCK()
        {
            InitializeComponent();
            cMateriales = CONTROLADORA.cMateriales.obtener_instancia();
            armo_grilla();
        }

        public void armo_grilla()
        {
            dgvMATERIALESPP.DataSource = null;
            dgvMATERIALESPP.DataSource = cMateriales.obtenerMaterialPP();
            dgvMATERIALESPP.AutoGenerateColumns = false;

            for (int i = 0; i < dgvMATERIALESPP.Columns.Count; i++)
            {
                dgvMATERIALESPP.Columns[i].Visible = false;
            }

            dgvMATERIALESPP.Columns[0].Visible = true;
            dgvMATERIALESPP.Columns[1].Visible = true;
            dgvMATERIALESPP.Columns[2].Visible = true;
            dgvMATERIALESPP.Columns[3].Visible = true;
            dgvMATERIALESPP.Columns[4].Visible = true;
            dgvMATERIALESPP.Columns[5].Visible = true;


            listVisible.Add(dgvMATERIALESPP.Columns[0]);
            listVisible.Add(dgvMATERIALESPP.Columns[1]);
            listVisible.Add(dgvMATERIALESPP.Columns[2]);
            listVisible.Add(dgvMATERIALESPP.Columns[3]);
            listVisible.Add(dgvMATERIALESPP.Columns[4]);
            listVisible.Add(dgvMATERIALESPP.Columns[5]);

        }

        private void btnEXPORTAREXCEL_Click(object sender, EventArgs e)
        {
           
                StreamWriter sw = new StreamWriter(ubicacionExport + "\\PP.csv");

                for (int i = 0; i < listVisible.Count; i++)
                {
                    sw.Write(listVisible[i].HeaderText);
                    if (i != listVisible.Count)
                    {
                        sw.Write(",");
                    }

                }

                sw.Write(sw.NewLine);

                foreach (DataGridViewRow dr in dgvMATERIALESPP.Rows)
                {
                    for (int i = 0; i < listVisible.Count; i++)
                    {
                        sw.Write(dr.Cells[i].Value);
                        if (i != listVisible.Count)
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
                string csvFileName = @ubicacionExport + "\\PP.csv";
                string excelFileName = @ubicacionExport + "\\PP.xls";

                string worksheetsName = "PP_" + DateTime.Now.ToString();

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
                MessageBox.Show("Exportado con exito en: " + ubicacionExport, "Notificación", MessageBoxButtons.OK);
            
           
        }

        private void frmWSTOCK_Load(object sender, EventArgs e)
        {
            txtUBICACION.Text = Properties.Settings.Default.TextBox;
            ubicacionExport = txtUBICACION.Text;
        }

        private void frmWSTOCK_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TextBox = txtUBICACION.Text;
            Properties.Settings.Default.Save();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = ("Seleccione un directorio" + Environment.NewLine + "Directorio actual: " + ubicacionExport);
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Directorio seleccionado: " + fbd.SelectedPath);
                txtUBICACION.Text = fbd.SelectedPath.ToString();
                ubicacionExport = txtUBICACION.Text;
            }
        }

       
    }
}

