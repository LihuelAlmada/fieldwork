namespace VISTA.USUARIO
{
    partial class FrmAgregarU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarU));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbESTADO = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cblGRUPOS = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSALIIR = new System.Windows.Forms.Button();
            this.btnGUARDARR = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(660, 235);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(274, 36);
            this.txtNOMBRE.TabIndex = 3;
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(660, 296);
            this.txtAPELLIDO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(274, 36);
            this.txtAPELLIDO.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(660, 354);
            this.txtEMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(274, 36);
            this.txtEMAIL.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // cbESTADO
            // 
            this.cbESTADO.AutoSize = true;
            this.cbESTADO.Checked = true;
            this.cbESTADO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbESTADO.Location = new System.Drawing.Point(660, 411);
            this.cbESTADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(113, 34);
            this.cbESTADO.TabIndex = 9;
            this.cbESTADO.Text = "Activo";
            this.cbESTADO.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado";
            // 
            // cblGRUPOS
            // 
            this.cblGRUPOS.FormattingEnabled = true;
            this.cblGRUPOS.Location = new System.Drawing.Point(5, 0);
            this.cblGRUPOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblGRUPOS.Name = "cblGRUPOS";
            this.cblGRUPOS.Size = new System.Drawing.Size(1326, 593);
            this.cblGRUPOS.TabIndex = 11;
            this.cblGRUPOS.SelectedIndexChanged += new System.EventHandler(this.CblGRUPOS_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 82);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1349, 630);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblUSUARIO);
            this.tabPage1.Controls.Add(this.txtUSUARIO);
            this.tabPage1.Controls.Add(this.txtDNI);
            this.tabPage1.Controls.Add(this.lblDNI);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNOMBRE);
            this.tabPage1.Controls.Add(this.txtAPELLIDO);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEMAIL);
            this.tabPage1.Controls.Add(this.cbESTADO);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1341, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Location = new System.Drawing.Point(482, 115);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(106, 30);
            this.lblUSUARIO.TabIndex = 11;
            this.lblUSUARIO.Text = "Usuario:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(660, 115);
            this.txtUSUARIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(274, 36);
            this.txtUSUARIO.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(660, 181);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(274, 36);
            this.txtDNI.TabIndex = 2;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(482, 181);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 30);
            this.lblDNI.TabIndex = 14;
            this.lblDNI.Text = "DNI:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cblGRUPOS);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1341, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grupos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSALIIR
            // 
            this.btnSALIIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSALIIR.FlatAppearance.BorderSize = 0;
            this.btnSALIIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSALIIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIIR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSALIIR.Image = ((System.Drawing.Image)(resources.GetObject("btnSALIIR.Image")));
            this.btnSALIIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSALIIR.Location = new System.Drawing.Point(1138, 37);
            this.btnSALIIR.Name = "btnSALIIR";
            this.btnSALIIR.Size = new System.Drawing.Size(215, 60);
            this.btnSALIIR.TabIndex = 55;
            this.btnSALIIR.Text = "Salir";
            this.btnSALIIR.UseVisualStyleBackColor = false;
            this.btnSALIIR.Click += new System.EventHandler(this.btnSALIIR_Click);
            // 
            // btnGUARDARR
            // 
            this.btnGUARDARR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGUARDARR.FlatAppearance.BorderSize = 0;
            this.btnGUARDARR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGUARDARR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDARR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDARR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGUARDARR.Image = ((System.Drawing.Image)(resources.GetObject("btnGUARDARR.Image")));
            this.btnGUARDARR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGUARDARR.Location = new System.Drawing.Point(916, 38);
            this.btnGUARDARR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGUARDARR.Name = "btnGUARDARR";
            this.btnGUARDARR.Size = new System.Drawing.Size(215, 60);
            this.btnGUARDARR.TabIndex = 54;
            this.btnGUARDARR.Text = "Guardar";
            this.btnGUARDARR.UseVisualStyleBackColor = false;
            this.btnGUARDARR.Click += new System.EventHandler(this.btnGUARDARR_Click);
            // 
            // FrmAgregarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btnSALIIR);
            this.Controls.Add(this.btnGUARDARR);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarU";
            this.Text = "AGREGAR";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbESTADO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox cblGRUPOS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnSALIIR;
        private System.Windows.Forms.Button btnGUARDARR;
    }
}