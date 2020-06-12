namespace VISTA.USUARIO
{
    partial class FrmGestionarU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarU));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbESTADO = new System.Windows.Forms.ComboBox();
            this.cmbGRUPO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.dgvUSUARIO = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRESETEAR_CLAVE = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnELIMINARR = new System.Windows.Forms.Button();
            this.btnMODIFICARR = new System.Windows.Forms.Button();
            this.btnAGREGARR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Estado";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Grupo";
            this.label2.Visible = false;
            // 
            // cmbESTADO
            // 
            this.cmbESTADO.DisplayMember = "Niguno";
            this.cmbESTADO.Enabled = false;
            this.cmbESTADO.FormattingEnabled = true;
            this.cmbESTADO.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Todos"});
            this.cmbESTADO.Location = new System.Drawing.Point(531, 247);
            this.cmbESTADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbESTADO.Name = "cmbESTADO";
            this.cmbESTADO.Size = new System.Drawing.Size(399, 24);
            this.cmbESTADO.TabIndex = 19;
            this.cmbESTADO.Tag = "";
            this.cmbESTADO.Text = "Todos";
            this.cmbESTADO.Visible = false;
            this.cmbESTADO.SelectedIndexChanged += new System.EventHandler(this.CmbESTADO_SelectedIndexChanged);
            // 
            // cmbGRUPO
            // 
            this.cmbGRUPO.FormattingEnabled = true;
            this.cmbGRUPO.Location = new System.Drawing.Point(181, 247);
            this.cmbGRUPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGRUPO.Name = "cmbGRUPO";
            this.cmbGRUPO.Size = new System.Drawing.Size(201, 24);
            this.cmbGRUPO.TabIndex = 18;
            this.cmbGRUPO.Visible = false;
            this.cmbGRUPO.SelectedIndexChanged += new System.EventHandler(this.cmbGRUPO_SelectedIndexChanged);
            this.cmbGRUPO.SelectionChangeCommitted += new System.EventHandler(this.cmbGRUPO_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Apellido y/o Nombre";
            this.label1.Visible = false;
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(181, 210);
            this.txtAPELLIDO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(749, 22);
            this.txtAPELLIDO.TabIndex = 16;
            this.txtAPELLIDO.Visible = false;
            this.txtAPELLIDO.TextChanged += new System.EventHandler(this.TxtAPELLIDO_TextChanged);
            // 
            // dgvUSUARIO
            // 
            this.dgvUSUARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSUARIO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Usuario,
            this.Apellido,
            this.Nombre,
            this.Email,
            this.Estado});
            this.dgvUSUARIO.Location = new System.Drawing.Point(5, 128);
            this.dgvUSUARIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUSUARIO.Name = "dgvUSUARIO";
            this.dgvUSUARIO.RowHeadersWidth = 51;
            this.dgvUSUARIO.RowTemplate.Height = 24;
            this.dgvUSUARIO.Size = new System.Drawing.Size(1349, 575);
            this.dgvUSUARIO.TabIndex = 11;
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dni.DataPropertyName = "Dni";
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // btnRESETEAR_CLAVE
            // 
            this.btnRESETEAR_CLAVE.Location = new System.Drawing.Point(1004, 214);
            this.btnRESETEAR_CLAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRESETEAR_CLAVE.Name = "btnRESETEAR_CLAVE";
            this.btnRESETEAR_CLAVE.Size = new System.Drawing.Size(168, 57);
            this.btnRESETEAR_CLAVE.TabIndex = 25;
            this.btnRESETEAR_CLAVE.Text = "Resetear Clave";
            this.btnRESETEAR_CLAVE.UseVisualStyleBackColor = true;
            this.btnRESETEAR_CLAVE.Visible = false;
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
            this.btnCONSULTAR.Location = new System.Drawing.Point(748, 325);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(215, 69);
            this.btnCONSULTAR.TabIndex = 40;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Visible = false;
            // 
            // btnELIMINARR
            // 
            this.btnELIMINARR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnELIMINARR.FlatAppearance.BorderSize = 0;
            this.btnELIMINARR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnELIMINARR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINARR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINARR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnELIMINARR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINARR.Image")));
            this.btnELIMINARR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnELIMINARR.Location = new System.Drawing.Point(447, 63);
            this.btnELIMINARR.Name = "btnELIMINARR";
            this.btnELIMINARR.Size = new System.Drawing.Size(215, 60);
            this.btnELIMINARR.TabIndex = 39;
            this.btnELIMINARR.Text = "Eliminar";
            this.btnELIMINARR.UseVisualStyleBackColor = false;
            this.btnELIMINARR.Click += new System.EventHandler(this.btnELIMINARR_Click);
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
            this.btnMODIFICARR.Location = new System.Drawing.Point(226, 63);
            this.btnMODIFICARR.Name = "btnMODIFICARR";
            this.btnMODIFICARR.Size = new System.Drawing.Size(215, 60);
            this.btnMODIFICARR.TabIndex = 38;
            this.btnMODIFICARR.Text = "Modificar";
            this.btnMODIFICARR.UseVisualStyleBackColor = false;
            this.btnMODIFICARR.Click += new System.EventHandler(this.btnMODIFICARR_Click);
            // 
            // btnAGREGARR
            // 
            this.btnAGREGARR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAGREGARR.FlatAppearance.BorderSize = 0;
            this.btnAGREGARR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAGREGARR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGARR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGARR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAGREGARR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGARR.Image")));
            this.btnAGREGARR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAGREGARR.Location = new System.Drawing.Point(5, 63);
            this.btnAGREGARR.Name = "btnAGREGARR";
            this.btnAGREGARR.Size = new System.Drawing.Size(215, 60);
            this.btnAGREGARR.TabIndex = 37;
            this.btnAGREGARR.Text = "Agregar";
            this.btnAGREGARR.UseVisualStyleBackColor = false;
            this.btnAGREGARR.Click += new System.EventHandler(this.btnAGREGARR_Click);
            // 
            // FrmGestionarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnELIMINARR);
            this.Controls.Add(this.btnMODIFICARR);
            this.Controls.Add(this.btnAGREGARR);
            this.Controls.Add(this.btnRESETEAR_CLAVE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbESTADO);
            this.Controls.Add(this.cmbGRUPO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAPELLIDO);
            this.Controls.Add(this.dgvUSUARIO);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionarU";
            this.Text = "FrmGestionar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbESTADO;
        private System.Windows.Forms.ComboBox cmbGRUPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.DataGridView dgvUSUARIO;
        private System.Windows.Forms.Button btnRESETEAR_CLAVE;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnELIMINARR;
        private System.Windows.Forms.Button btnMODIFICARR;
        private System.Windows.Forms.Button btnAGREGARR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}