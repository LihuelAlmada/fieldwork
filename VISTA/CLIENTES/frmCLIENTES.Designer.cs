namespace VISTA.CLIENTES
{
    partial class frmCLIENTES
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
            this.cmbLOCALIDAD = new System.Windows.Forms.ComboBox();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRAZONSOCIAL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.dgvCLIENTES = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLOCALIDAD
            // 
            this.cmbLOCALIDAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbLOCALIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLOCALIDAD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLOCALIDAD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLOCALIDAD.FormattingEnabled = true;
            this.cmbLOCALIDAD.Location = new System.Drawing.Point(129, 58);
            this.cmbLOCALIDAD.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLOCALIDAD.Name = "cmbLOCALIDAD";
            this.cmbLOCALIDAD.Size = new System.Drawing.Size(879, 21);
            this.cmbLOCALIDAD.TabIndex = 10;
            this.cmbLOCALIDAD.SelectedIndexChanged += new System.EventHandler(this.CmbLOCALIDAD_SelectedIndexChanged);
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAPELLIDO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPELLIDO.Location = new System.Drawing.Point(129, 10);
            this.txtAPELLIDO.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(879, 18);
            this.txtAPELLIDO.TabIndex = 5;
            this.txtAPELLIDO.TextChanged += new System.EventHandler(this.TxtAPELLIDO_TextChanged);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnAGREGAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAGREGAR.FlatAppearance.BorderSize = 0;
            this.btnAGREGAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnAGREGAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAGREGAR.Location = new System.Drawing.Point(0, 0);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(256, 35);
            this.btnAGREGAR.TabIndex = 1;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.BtnAGREGAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Localidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtRAZONSOCIAL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbLOCALIDAD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAPELLIDO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 92);
            this.panel1.TabIndex = 14;
            // 
            // txtRAZONSOCIAL
            // 
            this.txtRAZONSOCIAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRAZONSOCIAL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAZONSOCIAL.Location = new System.Drawing.Point(129, 34);
            this.txtRAZONSOCIAL.Margin = new System.Windows.Forms.Padding(2);
            this.txtRAZONSOCIAL.Name = "txtRAZONSOCIAL";
            this.txtRAZONSOCIAL.Size = new System.Drawing.Size(879, 18);
            this.txtRAZONSOCIAL.TabIndex = 14;
            this.txtRAZONSOCIAL.TextChanged += new System.EventHandler(this.TxtRAZONSOCIAL_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnCONSULTAR);
            this.panel2.Controls.Add(this.btnELIMINAR);
            this.panel2.Controls.Add(this.btnMODIFICAR);
            this.panel2.Controls.Add(this.btnAGREGAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 35);
            this.panel2.TabIndex = 15;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnCONSULTAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCONSULTAR.FlatAppearance.BorderSize = 0;
            this.btnCONSULTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnCONSULTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONSULTAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTAR.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCONSULTAR.Location = new System.Drawing.Point(768, 0);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(256, 35);
            this.btnCONSULTAR.TabIndex = 17;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.BtnCONSULTAR_Click_1);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnELIMINAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnELIMINAR.FlatAppearance.BorderSize = 0;
            this.btnELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnELIMINAR.Location = new System.Drawing.Point(512, 0);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(256, 35);
            this.btnELIMINAR.TabIndex = 16;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.BtnELIMINAR_Click_1);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.BackColor = System.Drawing.SystemColors.Control;
            this.btnMODIFICAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMODIFICAR.FlatAppearance.BorderSize = 0;
            this.btnMODIFICAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnMODIFICAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMODIFICAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMODIFICAR.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnMODIFICAR.Location = new System.Drawing.Point(256, 0);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(256, 35);
            this.btnMODIFICAR.TabIndex = 7;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = false;
            this.btnMODIFICAR.Click += new System.EventHandler(this.BtnMODIFICAR_Click_1);
            // 
            // dgvCLIENTES
            // 
            this.dgvCLIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCLIENTES.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCLIENTES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCLIENTES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCLIENTES.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCLIENTES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCLIENTES.EnableHeadersVisualStyles = false;
            this.dgvCLIENTES.Location = new System.Drawing.Point(20, 157);
            this.dgvCLIENTES.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCLIENTES.Name = "dgvCLIENTES";
            this.dgvCLIENTES.RowHeadersVisible = false;
            this.dgvCLIENTES.RowHeadersWidth = 51;
            this.dgvCLIENTES.RowTemplate.Height = 24;
            this.dgvCLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCLIENTES.Size = new System.Drawing.Size(1026, 400);
            this.dgvCLIENTES.TabIndex = 64;
            this.dgvCLIENTES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCLIENTES_CellClick);
            // 
            // frmCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 617);
            this.Controls.Add(this.dgvCLIENTES);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmCLIENTES";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "CLIENTES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbLOCALIDAD;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.TextBox txtRAZONSOCIAL;
        private System.Windows.Forms.DataGridView dgvCLIENTES;
    }
}