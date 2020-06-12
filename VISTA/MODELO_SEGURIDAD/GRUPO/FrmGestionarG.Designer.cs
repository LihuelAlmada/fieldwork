namespace VISTA.GRUPO
{
    partial class FrmGestionarG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarG));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbESTADO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.dgvGRUPO = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICARR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRUPO)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Estado";
            this.label3.Visible = false;
            // 
            // cmbESTADO
            // 
            this.cmbESTADO.FormattingEnabled = true;
            this.cmbESTADO.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Todos"});
            this.cmbESTADO.Location = new System.Drawing.Point(12, 216);
            this.cmbESTADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbESTADO.Name = "cmbESTADO";
            this.cmbESTADO.Size = new System.Drawing.Size(604, 24);
            this.cmbESTADO.TabIndex = 19;
            this.cmbESTADO.Text = "Todos";
            this.cmbESTADO.Visible = false;
            this.cmbESTADO.SelectedIndexChanged += new System.EventHandler(this.cmbESTADO_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            this.label1.Visible = false;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(12, 190);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(605, 22);
            this.txtNOMBRE.TabIndex = 16;
            this.txtNOMBRE.Visible = false;
            this.txtNOMBRE.TextChanged += new System.EventHandler(this.txtNOMBRE_TextChanged);
            // 
            // dgvGRUPO
            // 
            this.dgvGRUPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRUPO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Estado});
            this.dgvGRUPO.Location = new System.Drawing.Point(2, 128);
            this.dgvGRUPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGRUPO.Name = "dgvGRUPO";
            this.dgvGRUPO.RowTemplate.Height = 24;
            this.dgvGRUPO.Size = new System.Drawing.Size(1352, 573);
            this.dgvGRUPO.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSALIR.FlatAppearance.BorderSize = 0;
            this.btnSALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSALIR.Image = ((System.Drawing.Image)(resources.GetObject("btnSALIR.Image")));
            this.btnSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSALIR.Location = new System.Drawing.Point(1139, 63);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(215, 60);
            this.btnSALIR.TabIndex = 86;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCONSULTAR.FlatAppearance.BorderSize = 0;
            this.btnCONSULTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONSULTAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCONSULTAR.Location = new System.Drawing.Point(12, 245);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(215, 69);
            this.btnCONSULTAR.TabIndex = 36;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Visible = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnMODIFICAR_Click_1);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnELIMINAR.FlatAppearance.BorderSize = 0;
            this.btnELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnELIMINAR.Location = new System.Drawing.Point(444, 63);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(215, 60);
            this.btnELIMINAR.TabIndex = 35;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMODIFICARR
            // 
            this.btnMODIFICARR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMODIFICARR.FlatAppearance.BorderSize = 0;
            this.btnMODIFICARR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMODIFICARR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMODIFICARR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMODIFICARR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMODIFICARR.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICARR.Image")));
            this.btnMODIFICARR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMODIFICARR.Location = new System.Drawing.Point(223, 63);
            this.btnMODIFICARR.Name = "btnMODIFICARR";
            this.btnMODIFICARR.Size = new System.Drawing.Size(215, 60);
            this.btnMODIFICARR.TabIndex = 34;
            this.btnMODIFICARR.Text = "Modificar";
            this.btnMODIFICARR.UseVisualStyleBackColor = false;
            this.btnMODIFICARR.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAGREGAR.FlatAppearance.BorderSize = 0;
            this.btnAGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAGREGAR.Location = new System.Drawing.Point(2, 63);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(215, 60);
            this.btnAGREGAR.TabIndex = 33;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGestionarG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnMODIFICARR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbESTADO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.dgvGRUPO);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionarG";
            this.Text = "GESTIONAR GRUPOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRUPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbESTADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.DataGridView dgvGRUPO;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICARR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnCONSULTAR;
    }
}