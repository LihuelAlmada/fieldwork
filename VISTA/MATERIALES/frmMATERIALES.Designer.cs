namespace VISTA.MATERIALES
{
    partial class frmMATERIALES
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
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.lblMODIFICAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.lbldDESCRIPCION = new System.Windows.Forms.Label();
            this.txtDESCRIPCIONCORTA = new System.Windows.Forms.TextBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.lblCODIGO = new System.Windows.Forms.Label();
            this.txtCLASES = new System.Windows.Forms.TextBox();
            this.lblCLASE = new System.Windows.Forms.Label();
            this.txtSUBCLASE = new System.Windows.Forms.TextBox();
            this.lblSUBCLASE = new System.Windows.Forms.Label();
            this.lblPROVEEDOR = new System.Windows.Forms.Label();
            this.cmbPROVEEDOR = new System.Windows.Forms.ComboBox();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMATERIALES = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATERIALES)).BeginInit();
            this.SuspendLayout();
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
            this.btnAGREGAR.Size = new System.Drawing.Size(315, 35);
            this.btnAGREGAR.TabIndex = 1;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // lblMODIFICAR
            // 
            this.lblMODIFICAR.BackColor = System.Drawing.SystemColors.Control;
            this.lblMODIFICAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMODIFICAR.FlatAppearance.BorderSize = 0;
            this.lblMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMODIFICAR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMODIFICAR.ForeColor = System.Drawing.Color.DimGray;
            this.lblMODIFICAR.Location = new System.Drawing.Point(315, 0);
            this.lblMODIFICAR.Margin = new System.Windows.Forms.Padding(2);
            this.lblMODIFICAR.Name = "lblMODIFICAR";
            this.lblMODIFICAR.Size = new System.Drawing.Size(315, 35);
            this.lblMODIFICAR.TabIndex = 2;
            this.lblMODIFICAR.Text = "Modificar";
            this.lblMODIFICAR.UseVisualStyleBackColor = false;
            this.lblMODIFICAR.Click += new System.EventHandler(this.lblMODIFICAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnELIMINAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnELIMINAR.FlatAppearance.BorderSize = 0;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnELIMINAR.ForeColor = System.Drawing.Color.DimGray;
            this.btnELIMINAR.Location = new System.Drawing.Point(630, 0);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(315, 35);
            this.btnELIMINAR.TabIndex = 3;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // lbldDESCRIPCION
            // 
            this.lbldDESCRIPCION.AutoSize = true;
            this.lbldDESCRIPCION.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbldDESCRIPCION.ForeColor = System.Drawing.Color.DimGray;
            this.lbldDESCRIPCION.Location = new System.Drawing.Point(10, 10);
            this.lbldDESCRIPCION.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldDESCRIPCION.Name = "lbldDESCRIPCION";
            this.lbldDESCRIPCION.Size = new System.Drawing.Size(115, 17);
            this.lbldDESCRIPCION.TabIndex = 4;
            this.lbldDESCRIPCION.Text = "Descripcion Corta:";
            // 
            // txtDESCRIPCIONCORTA
            // 
            this.txtDESCRIPCIONCORTA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDESCRIPCIONCORTA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDESCRIPCIONCORTA.Location = new System.Drawing.Point(126, 11);
            this.txtDESCRIPCIONCORTA.Margin = new System.Windows.Forms.Padding(2);
            this.txtDESCRIPCIONCORTA.Name = "txtDESCRIPCIONCORTA";
            this.txtDESCRIPCIONCORTA.Size = new System.Drawing.Size(320, 18);
            this.txtDESCRIPCIONCORTA.TabIndex = 5;
            this.txtDESCRIPCIONCORTA.TextChanged += new System.EventHandler(this.txtDESCRIPCIONCORTA_TextChanged);
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCODIGO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCODIGO.Location = new System.Drawing.Point(126, 40);
            this.txtCODIGO.Margin = new System.Windows.Forms.Padding(2);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(320, 18);
            this.txtCODIGO.TabIndex = 7;
            this.txtCODIGO.TextChanged += new System.EventHandler(this.txtCODIGO_TextChanged);
            // 
            // lblCODIGO
            // 
            this.lblCODIGO.AutoSize = true;
            this.lblCODIGO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCODIGO.ForeColor = System.Drawing.Color.DimGray;
            this.lblCODIGO.Location = new System.Drawing.Point(70, 39);
            this.lblCODIGO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCODIGO.Name = "lblCODIGO";
            this.lblCODIGO.Size = new System.Drawing.Size(54, 17);
            this.lblCODIGO.TabIndex = 6;
            this.lblCODIGO.Text = "Codigo:";
            // 
            // txtCLASES
            // 
            this.txtCLASES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCLASES.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCLASES.Location = new System.Drawing.Point(518, 11);
            this.txtCLASES.Margin = new System.Windows.Forms.Padding(2);
            this.txtCLASES.Name = "txtCLASES";
            this.txtCLASES.Size = new System.Drawing.Size(320, 18);
            this.txtCLASES.TabIndex = 9;
            this.txtCLASES.TextChanged += new System.EventHandler(this.txtCLASES_TextChanged);
            // 
            // lblCLASE
            // 
            this.lblCLASE.AutoSize = true;
            this.lblCLASE.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCLASE.ForeColor = System.Drawing.Color.DimGray;
            this.lblCLASE.Location = new System.Drawing.Point(473, 10);
            this.lblCLASE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCLASE.Name = "lblCLASE";
            this.lblCLASE.Size = new System.Drawing.Size(42, 17);
            this.lblCLASE.TabIndex = 8;
            this.lblCLASE.Text = "Clase:";
            // 
            // txtSUBCLASE
            // 
            this.txtSUBCLASE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSUBCLASE.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSUBCLASE.Location = new System.Drawing.Point(518, 42);
            this.txtSUBCLASE.Margin = new System.Windows.Forms.Padding(2);
            this.txtSUBCLASE.Name = "txtSUBCLASE";
            this.txtSUBCLASE.Size = new System.Drawing.Size(320, 18);
            this.txtSUBCLASE.TabIndex = 11;
            this.txtSUBCLASE.TextChanged += new System.EventHandler(this.txtSUBCLASE_TextChanged);
            // 
            // lblSUBCLASE
            // 
            this.lblSUBCLASE.AutoSize = true;
            this.lblSUBCLASE.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSUBCLASE.ForeColor = System.Drawing.Color.DimGray;
            this.lblSUBCLASE.Location = new System.Drawing.Point(454, 40);
            this.lblSUBCLASE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSUBCLASE.Name = "lblSUBCLASE";
            this.lblSUBCLASE.Size = new System.Drawing.Size(62, 17);
            this.lblSUBCLASE.TabIndex = 10;
            this.lblSUBCLASE.Text = "Subclase:";
            // 
            // lblPROVEEDOR
            // 
            this.lblPROVEEDOR.AutoSize = true;
            this.lblPROVEEDOR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPROVEEDOR.ForeColor = System.Drawing.Color.DimGray;
            this.lblPROVEEDOR.Location = new System.Drawing.Point(852, 12);
            this.lblPROVEEDOR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPROVEEDOR.Name = "lblPROVEEDOR";
            this.lblPROVEEDOR.Size = new System.Drawing.Size(72, 17);
            this.lblPROVEEDOR.TabIndex = 12;
            this.lblPROVEEDOR.Text = "Proveedor:";
            // 
            // cmbPROVEEDOR
            // 
            this.cmbPROVEEDOR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbPROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPROVEEDOR.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmbPROVEEDOR.FormattingEnabled = true;
            this.cmbPROVEEDOR.Location = new System.Drawing.Point(928, 11);
            this.cmbPROVEEDOR.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPROVEEDOR.Name = "cmbPROVEEDOR";
            this.cmbPROVEEDOR.Size = new System.Drawing.Size(320, 21);
            this.cmbPROVEEDOR.TabIndex = 13;
            this.cmbPROVEEDOR.SelectedIndexChanged += new System.EventHandler(this.cmbPROVEEDOR_SelectedIndexChanged);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnCONSULTAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCONSULTAR.FlatAppearance.BorderSize = 0;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONSULTAR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCONSULTAR.ForeColor = System.Drawing.Color.DimGray;
            this.btnCONSULTAR.Location = new System.Drawing.Point(945, 0);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(315, 35);
            this.btnCONSULTAR.TabIndex = 14;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnCONSULTAR);
            this.panel2.Controls.Add(this.btnELIMINAR);
            this.panel2.Controls.Add(this.lblMODIFICAR);
            this.panel2.Controls.Add(this.btnAGREGAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 35);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtDESCRIPCIONCORTA);
            this.panel1.Controls.Add(this.lbldDESCRIPCION);
            this.panel1.Controls.Add(this.cmbPROVEEDOR);
            this.panel1.Controls.Add(this.lblPROVEEDOR);
            this.panel1.Controls.Add(this.txtCODIGO);
            this.panel1.Controls.Add(this.lblCODIGO);
            this.panel1.Controls.Add(this.txtSUBCLASE);
            this.panel1.Controls.Add(this.lblSUBCLASE);
            this.panel1.Controls.Add(this.txtCLASES);
            this.panel1.Controls.Add(this.lblCLASE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 69);
            this.panel1.TabIndex = 17;
            // 
            // dgvMATERIALES
            // 
            this.dgvMATERIALES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMATERIALES.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMATERIALES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMATERIALES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMATERIALES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMATERIALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMATERIALES.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMATERIALES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMATERIALES.EnableHeadersVisualStyles = false;
            this.dgvMATERIALES.Location = new System.Drawing.Point(20, 134);
            this.dgvMATERIALES.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMATERIALES.Name = "dgvMATERIALES";
            this.dgvMATERIALES.RowHeadersVisible = false;
            this.dgvMATERIALES.RowHeadersWidth = 51;
            this.dgvMATERIALES.RowTemplate.Height = 24;
            this.dgvMATERIALES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMATERIALES.Size = new System.Drawing.Size(1263, 409);
            this.dgvMATERIALES.TabIndex = 18;
            this.dgvMATERIALES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMATERIALES_CellContentClick);
            // 
            // frmMATERIALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 605);
            this.Controls.Add(this.dgvMATERIALES);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMATERIALES";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Materiales";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATERIALES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button lblMODIFICAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Label lbldDESCRIPCION;
        private System.Windows.Forms.TextBox txtDESCRIPCIONCORTA;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label lblCODIGO;
        private System.Windows.Forms.TextBox txtCLASES;
        private System.Windows.Forms.Label lblCLASE;
        private System.Windows.Forms.TextBox txtSUBCLASE;
        private System.Windows.Forms.Label lblSUBCLASE;
        private System.Windows.Forms.Label lblPROVEEDOR;
        private System.Windows.Forms.ComboBox cmbPROVEEDOR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMATERIALES;
    }
}