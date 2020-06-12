namespace VISTA.MATERIALES
{
    partial class frmBUSCARPROVEEDOR
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
            this.txtNOMBREPROVEEDOR = new System.Windows.Forms.TextBox();
            this.lblNOBMRE = new System.Windows.Forms.Label();
            this.dgvPROVEEDORES = new System.Windows.Forms.DataGridView();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROVEEDORES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNOMBREPROVEEDOR
            // 
            this.txtNOMBREPROVEEDOR.Location = new System.Drawing.Point(96, 27);
            this.txtNOMBREPROVEEDOR.Name = "txtNOMBREPROVEEDOR";
            this.txtNOMBREPROVEEDOR.Size = new System.Drawing.Size(605, 22);
            this.txtNOMBREPROVEEDOR.TabIndex = 0;
            this.txtNOMBREPROVEEDOR.TextChanged += new System.EventHandler(this.txtNOMBREPROVEEDOR_TextChanged);
            // 
            // lblNOBMRE
            // 
            this.lblNOBMRE.AutoSize = true;
            this.lblNOBMRE.Location = new System.Drawing.Point(639, 76);
            this.lblNOBMRE.Name = "lblNOBMRE";
            this.lblNOBMRE.Size = new System.Drawing.Size(128, 17);
            this.lblNOBMRE.TabIndex = 1;
            this.lblNOBMRE.Text = "Nombre Proveedor";
            // 
            // dgvPROVEEDORES
            // 
            this.dgvPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPROVEEDORES.Location = new System.Drawing.Point(27, 203);
            this.dgvPROVEEDORES.Name = "dgvPROVEEDORES";
            this.dgvPROVEEDORES.RowHeadersWidth = 51;
            this.dgvPROVEEDORES.RowTemplate.Height = 24;
            this.dgvPROVEEDORES.Size = new System.Drawing.Size(1367, 592);
            this.dgvPROVEEDORES.TabIndex = 2;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(31, 801);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(631, 41);
            this.btnGUARDAR.TabIndex = 3;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(757, 801);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(641, 41);
            this.btnSALIR.TabIndex = 4;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtNOMBREPROVEEDOR);
            this.panel1.Location = new System.Drawing.Point(27, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 123);
            this.panel1.TabIndex = 5;
            // 
            // frmBUSCARPROVEEDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.dgvPROVEEDORES);
            this.Controls.Add(this.lblNOBMRE);
            this.Name = "frmBUSCARPROVEEDOR";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Buscar Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROVEEDORES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNOMBREPROVEEDOR;
        private System.Windows.Forms.Label lblNOBMRE;
        private System.Windows.Forms.DataGridView dgvPROVEEDORES;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Panel panel1;
    }
}