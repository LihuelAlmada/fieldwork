namespace VISTA
{
    partial class frmLOCALIDAD
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
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtCODIGO_POSTAL = new System.Windows.Forms.TextBox();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.cmbPROVINCIA = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPROVINCIA = new System.Windows.Forms.Label();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNOMBRE.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNOMBRE.Location = new System.Drawing.Point(104, 11);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(366, 18);
            this.txtNOMBRE.TabIndex = 1;
            this.txtNOMBRE.Text = "\r\n";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGUARDAR.FlatAppearance.BorderSize = 0;
            this.btnGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnGUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnGUARDAR.Location = new System.Drawing.Point(0, 0);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(244, 30);
            this.btnGUARDAR.TabIndex = 4;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.BtnGUARDAR_Click_1);
            // 
            // txtCODIGO_POSTAL
            // 
            this.txtCODIGO_POSTAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCODIGO_POSTAL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCODIGO_POSTAL.Location = new System.Drawing.Point(104, 58);
            this.txtCODIGO_POSTAL.Margin = new System.Windows.Forms.Padding(2);
            this.txtCODIGO_POSTAL.Name = "txtCODIGO_POSTAL";
            this.txtCODIGO_POSTAL.Size = new System.Drawing.Size(366, 18);
            this.txtCODIGO_POSTAL.TabIndex = 3;
            this.txtCODIGO_POSTAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCODIGO_POSTAL_KeyPress);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSALIR.FlatAppearance.BorderSize = 0;
            this.btnSALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnSALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSALIR.Location = new System.Drawing.Point(244, 0);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(244, 30);
            this.btnSALIR.TabIndex = 5;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.BtnSALIR_Click_1);
            // 
            // cmbPROVINCIA
            // 
            this.cmbPROVINCIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPROVINCIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPROVINCIA.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPROVINCIA.FormattingEnabled = true;
            this.cmbPROVINCIA.Items.AddRange(new object[] {
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"});
            this.cmbPROVINCIA.Location = new System.Drawing.Point(104, 33);
            this.cmbPROVINCIA.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPROVINCIA.Name = "cmbPROVINCIA";
            this.cmbPROVINCIA.Size = new System.Drawing.Size(366, 21);
            this.cmbPROVINCIA.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblPROVINCIA);
            this.panel1.Controls.Add(this.lblNOMBRE);
            this.panel1.Controls.Add(this.lblCP);
            this.panel1.Controls.Add(this.cmbPROVINCIA);
            this.panel1.Controls.Add(this.txtCODIGO_POSTAL);
            this.panel1.Controls.Add(this.txtNOMBRE);
            this.panel1.Location = new System.Drawing.Point(20, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 93);
            this.panel1.TabIndex = 16;
            // 
            // lblPROVINCIA
            // 
            this.lblPROVINCIA.AutoSize = true;
            this.lblPROVINCIA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPROVINCIA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPROVINCIA.Location = new System.Drawing.Point(37, 35);
            this.lblPROVINCIA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPROVINCIA.Name = "lblPROVINCIA";
            this.lblPROVINCIA.Size = new System.Drawing.Size(63, 17);
            this.lblPROVINCIA.TabIndex = 10;
            this.lblPROVINCIA.Text = "Provincia:";
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNOMBRE.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNOMBRE.Location = new System.Drawing.Point(40, 11);
            this.lblNOMBRE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(60, 17);
            this.lblNOMBRE.TabIndex = 8;
            this.lblNOMBRE.Text = "Nombre:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCP.Location = new System.Drawing.Point(7, 58);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(93, 17);
            this.lblCP.TabIndex = 9;
            this.lblCP.Text = "Codigo Postal:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnSALIR);
            this.panel2.Controls.Add(this.btnGUARDAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 30);
            this.panel2.TabIndex = 17;
            // 
            // frmLOCALIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 212);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmLOCALIDAD";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "LOCALIDAD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtCODIGO_POSTAL;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.ComboBox cmbPROVINCIA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPROVINCIA;
        private System.Windows.Forms.Label lblNOMBRE;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Panel panel2;
    }
}