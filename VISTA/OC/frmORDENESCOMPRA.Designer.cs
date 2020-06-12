namespace VISTA.OC
{
    partial class frmORDENESCOMPRA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvORDENESCOMPRA = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.txtPROVEEDOR = new System.Windows.Forms.TextBox();
            this.dtpRecepcion = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENESCOMPRA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvORDENESCOMPRA
            // 
            this.dgvORDENESCOMPRA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvORDENESCOMPRA.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvORDENESCOMPRA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvORDENESCOMPRA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvORDENESCOMPRA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvORDENESCOMPRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvORDENESCOMPRA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvORDENESCOMPRA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvORDENESCOMPRA.EnableHeadersVisualStyles = false;
            this.dgvORDENESCOMPRA.Location = new System.Drawing.Point(20, 104);
            this.dgvORDENESCOMPRA.Margin = new System.Windows.Forms.Padding(2);
            this.dgvORDENESCOMPRA.Name = "dgvORDENESCOMPRA";
            this.dgvORDENESCOMPRA.RowHeadersVisible = false;
            this.dgvORDENESCOMPRA.RowHeadersWidth = 51;
            this.dgvORDENESCOMPRA.RowTemplate.Height = 24;
            this.dgvORDENESCOMPRA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvORDENESCOMPRA.Size = new System.Drawing.Size(856, 334);
            this.dgvORDENESCOMPRA.TabIndex = 20;
            this.dgvORDENESCOMPRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvORDENESCOMPRA_CellContentClick);
            this.dgvORDENESCOMPRA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvORDENESCOMPRA_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnELIMINAR);
            this.panel1.Controls.Add(this.btnCONSULTAR);
            this.panel1.Controls.Add(this.btnAGREGAR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 35);
            this.panel1.TabIndex = 23;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnELIMINAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnELIMINAR.FlatAppearance.BorderSize = 0;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnELIMINAR.ForeColor = System.Drawing.Color.DimGray;
            this.btnELIMINAR.Location = new System.Drawing.Point(856, 0);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(285, 35);
            this.btnELIMINAR.TabIndex = 21;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Visible = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click_1);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnCONSULTAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCONSULTAR.FlatAppearance.BorderSize = 0;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONSULTAR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.DimGray;
            this.btnCONSULTAR.Location = new System.Drawing.Point(428, 0);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(428, 35);
            this.btnCONSULTAR.TabIndex = 22;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnAGREGAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAGREGAR.FlatAppearance.BorderSize = 0;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAGREGAR.ForeColor = System.Drawing.Color.DimGray;
            this.btnAGREGAR.Location = new System.Drawing.Point(0, 0);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(428, 35);
            this.btnAGREGAR.TabIndex = 20;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click_1);
            // 
            // txtPROVEEDOR
            // 
            this.txtPROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPROVEEDOR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPROVEEDOR.Location = new System.Drawing.Point(86, 8);
            this.txtPROVEEDOR.Margin = new System.Windows.Forms.Padding(2);
            this.txtPROVEEDOR.Name = "txtPROVEEDOR";
            this.txtPROVEEDOR.Size = new System.Drawing.Size(438, 18);
            this.txtPROVEEDOR.TabIndex = 25;
            this.txtPROVEEDOR.TextChanged += new System.EventHandler(this.txtPROVEEDOR_TextChanged);
            // 
            // dtpRecepcion
            // 
            this.dtpRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecepcion.Location = new System.Drawing.Point(743, 7);
            this.dtpRecepcion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRecepcion.Name = "dtpRecepcion";
            this.dtpRecepcion.Size = new System.Drawing.Size(99, 20);
            this.dtpRecepcion.TabIndex = 30;
            this.dtpRecepcion.Value = new System.DateTime(2019, 11, 10, 0, 0, 0, 0);
            this.dtpRecepcion.ValueChanged += new System.EventHandler(this.dtpRecepcion_ValueChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(583, 7);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(99, 20);
            this.dtpInicio.TabIndex = 32;
            this.dtpInicio.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpInicio);
            this.panel2.Controls.Add(this.dtpRecepcion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPROVEEDOR);
            this.panel2.Location = new System.Drawing.Point(20, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 36);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(693, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(531, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Proovedor:";
            // 
            // frmORDENESCOMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvORDENESCOMPRA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmORDENESCOMPRA";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Ordenes de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENESCOMPRA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvORDENESCOMPRA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.TextBox txtPROVEEDOR;
        private System.Windows.Forms.DateTimePicker dtpRecepcion;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}