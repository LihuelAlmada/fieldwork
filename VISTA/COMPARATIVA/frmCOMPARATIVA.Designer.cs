namespace VISTA
{
    partial class frmCOMPARATIVA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCOMPARATIVA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLUPA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMATERIAL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHASTA = new System.Windows.Forms.DateTimePicker();
            this.dtpDESDE = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEXPORTAR = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvORDENESVENTA = new System.Windows.Forms.DataGridView();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.txtUBICACION = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENESVENTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLUPA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMATERIAL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpHASTA);
            this.panel1.Controls.Add(this.dtpDESDE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(27, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 48);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(1004, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 48);
            this.button1.TabIndex = 39;
            this.button1.Text = "Graficar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLUPA
            // 
            this.btnLUPA.BackColor = System.Drawing.SystemColors.Control;
            this.btnLUPA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLUPA.BackgroundImage")));
            this.btnLUPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLUPA.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLUPA.FlatAppearance.BorderSize = 0;
            this.btnLUPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLUPA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLUPA.Location = new System.Drawing.Point(403, 7);
            this.btnLUPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLUPA.Name = "btnLUPA";
            this.btnLUPA.Size = new System.Drawing.Size(28, 30);
            this.btnLUPA.TabIndex = 22;
            this.btnLUPA.UseVisualStyleBackColor = false;
            this.btnLUPA.Click += new System.EventHandler(this.btnLUPA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Material:";
            // 
            // txtMATERIAL
            // 
            this.txtMATERIAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMATERIAL.Enabled = false;
            this.txtMATERIAL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMATERIAL.Location = new System.Drawing.Point(95, 12);
            this.txtMATERIAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMATERIAL.Name = "txtMATERIAL";
            this.txtMATERIAL.Size = new System.Drawing.Size(302, 22);
            this.txtMATERIAL.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(666, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Hasta:";
            // 
            // dtpHASTA
            // 
            this.dtpHASTA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHASTA.Location = new System.Drawing.Point(733, 11);
            this.dtpHASTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHASTA.Name = "dtpHASTA";
            this.dtpHASTA.Size = new System.Drawing.Size(131, 22);
            this.dtpHASTA.TabIndex = 37;
            this.dtpHASTA.Value = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            this.dtpHASTA.ValueChanged += new System.EventHandler(this.dtpHASTA_ValueChanged);
            // 
            // dtpDESDE
            // 
            this.dtpDESDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDESDE.Location = new System.Drawing.Point(520, 11);
            this.dtpDESDE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDESDE.Name = "dtpDESDE";
            this.dtpDESDE.Size = new System.Drawing.Size(131, 22);
            this.dtpDESDE.TabIndex = 38;
            this.dtpDESDE.Value = new System.DateTime(2019, 11, 19, 0, 0, 0, 0);
            this.dtpDESDE.ValueChanged += new System.EventHandler(this.dtpDESDE_ValueChanged);
            this.dtpDESDE.Enter += new System.EventHandler(this.dtpDESDE_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(450, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Desde:";
            // 
            // btnEXPORTAR
            // 
            this.btnEXPORTAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnEXPORTAR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEXPORTAR.FlatAppearance.BorderSize = 0;
            this.btnEXPORTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXPORTAR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEXPORTAR.ForeColor = System.Drawing.Color.DimGray;
            this.btnEXPORTAR.Location = new System.Drawing.Point(27, 595);
            this.btnEXPORTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEXPORTAR.Name = "btnEXPORTAR";
            this.btnEXPORTAR.Size = new System.Drawing.Size(1203, 35);
            this.btnEXPORTAR.TabIndex = 21;
            this.btnEXPORTAR.Text = "Exportar";
            this.btnEXPORTAR.UseVisualStyleBackColor = false;
            this.btnEXPORTAR.Click += new System.EventHandler(this.btnEXPORTAR_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 130);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Compras";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1203, 459);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // dgvORDENESVENTA
            // 
            this.dgvORDENESVENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORDENESVENTA.Location = new System.Drawing.Point(895, 35);
            this.dgvORDENESVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvORDENESVENTA.Name = "dgvORDENESVENTA";
            this.dgvORDENESVENTA.RowHeadersWidth = 51;
            this.dgvORDENESVENTA.RowTemplate.Height = 24;
            this.dgvORDENESVENTA.Size = new System.Drawing.Size(83, 14);
            this.dgvORDENESVENTA.TabIndex = 24;
            this.dgvORDENESVENTA.Visible = false;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(412, 30);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(34, 37);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings.TabIndex = 26;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // txtUBICACION
            // 
            this.txtUBICACION.Location = new System.Drawing.Point(895, 567);
            this.txtUBICACION.Name = "txtUBICACION";
            this.txtUBICACION.Size = new System.Drawing.Size(332, 22);
            this.txtUBICACION.TabIndex = 27;
            this.txtUBICACION.Visible = false;
            // 
            // frmCOMPARATIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 655);
            this.Controls.Add(this.txtUBICACION);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.dgvORDENESVENTA);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnEXPORTAR);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCOMPARATIVA";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Comparativa compra/venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCOMPARATIVA_FormClosing);
            this.Load += new System.EventHandler(this.frmCOMPARATIVA_Load);
            this.InputLanguageChanging += new System.Windows.Forms.InputLanguageChangingEventHandler(this.frmCOMPARATIVA_InputLanguageChanging);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENESVENTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMATERIAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHASTA;
        private System.Windows.Forms.DateTimePicker dtpDESDE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEXPORTAR;
        private System.Windows.Forms.Button btnLUPA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvORDENESVENTA;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.TextBox txtUBICACION;
    }
}