namespace VISTA.STOCK
{
    partial class frmWSTOCK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWSTOCK));
            this.btnEXPORTAREXCEL = new System.Windows.Forms.Button();
            this.dgvMATERIALESPP = new System.Windows.Forms.DataGridView();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.txtUBICACION = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATERIALESPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEXPORTAREXCEL
            // 
            this.btnEXPORTAREXCEL.BackColor = System.Drawing.SystemColors.Control;
            this.btnEXPORTAREXCEL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEXPORTAREXCEL.FlatAppearance.BorderSize = 0;
            this.btnEXPORTAREXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXPORTAREXCEL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEXPORTAREXCEL.ForeColor = System.Drawing.Color.DimGray;
            this.btnEXPORTAREXCEL.Location = new System.Drawing.Point(20, 570);
            this.btnEXPORTAREXCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEXPORTAREXCEL.Name = "btnEXPORTAREXCEL";
            this.btnEXPORTAREXCEL.Size = new System.Drawing.Size(971, 43);
            this.btnEXPORTAREXCEL.TabIndex = 10;
            this.btnEXPORTAREXCEL.Text = "Exportar";
            this.btnEXPORTAREXCEL.UseVisualStyleBackColor = false;
            this.btnEXPORTAREXCEL.Click += new System.EventHandler(this.btnEXPORTAREXCEL_Click);
            // 
            // dgvMATERIALESPP
            // 
            this.dgvMATERIALESPP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMATERIALESPP.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMATERIALESPP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMATERIALESPP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMATERIALESPP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMATERIALESPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMATERIALESPP.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMATERIALESPP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMATERIALESPP.EnableHeadersVisualStyles = false;
            this.dgvMATERIALESPP.Location = new System.Drawing.Point(20, 76);
            this.dgvMATERIALESPP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMATERIALESPP.Name = "dgvMATERIALESPP";
            this.dgvMATERIALESPP.RowHeadersVisible = false;
            this.dgvMATERIALESPP.RowHeadersWidth = 51;
            this.dgvMATERIALESPP.RowTemplate.Height = 24;
            this.dgvMATERIALESPP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMATERIALESPP.Size = new System.Drawing.Size(968, 484);
            this.dgvMATERIALESPP.TabIndex = 19;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(261, 29);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(34, 37);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings.TabIndex = 27;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // txtUBICACION
            // 
            this.txtUBICACION.Location = new System.Drawing.Point(656, 49);
            this.txtUBICACION.Name = "txtUBICACION";
            this.txtUBICACION.Size = new System.Drawing.Size(332, 22);
            this.txtUBICACION.TabIndex = 28;
            this.txtUBICACION.Visible = false;
            // 
            // frmWSTOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 633);
            this.Controls.Add(this.txtUBICACION);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.dgvMATERIALESPP);
            this.Controls.Add(this.btnEXPORTAREXCEL);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmWSTOCK";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Punto de Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWSTOCK_FormClosing);
            this.Load += new System.EventHandler(this.frmWSTOCK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATERIALESPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEXPORTAREXCEL;
        private System.Windows.Forms.DataGridView dgvMATERIALESPP;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.TextBox txtUBICACION;
    }
}