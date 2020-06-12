namespace VISTA.GRUPO
{
    partial class FrmConsultaG
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
            this.cbxPERMISO = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cblUSUARIOS = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cbxPERMISO
            // 
            this.cbxPERMISO.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPERMISO.FormattingEnabled = true;
            this.cbxPERMISO.Location = new System.Drawing.Point(753, 137);
            this.cbxPERMISO.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbxPERMISO.Name = "cbxPERMISO";
            this.cbxPERMISO.Size = new System.Drawing.Size(276, 400);
            this.cbxPERMISO.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Permisos";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.Location = new System.Drawing.Point(554, 579);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(267, 48);
            this.btnCANCELAR.TabIndex = 57;
            this.btnCANCELAR.Text = "Volver";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(323, 74);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 30);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Usuarios";
            // 
            // cblUSUARIOS
            // 
            this.cblUSUARIOS.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblUSUARIOS.FormattingEnabled = true;
            this.cblUSUARIOS.Location = new System.Drawing.Point(327, 137);
            this.cblUSUARIOS.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cblUSUARIOS.Name = "cblUSUARIOS";
            this.cblUSUARIOS.Size = new System.Drawing.Size(276, 400);
            this.cblUSUARIOS.TabIndex = 55;
            // 
            // FrmConsultaG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.cbxPERMISO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cblUSUARIOS);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmConsultaG";
            this.Padding = new System.Windows.Forms.Padding(35, 101, 35, 34);
            this.Text = "FrmConsultarUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbxPERMISO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckedListBox cblUSUARIOS;
    }
}