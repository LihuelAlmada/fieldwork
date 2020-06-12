namespace VISTA.PROVEEDORES
{
    partial class PROVEEDOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PROVEEDOR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLupa = new System.Windows.Forms.Button();
            this.cmbESTADO = new System.Windows.Forms.ComboBox();
            this.cmbTIPO = new System.Windows.Forms.ComboBox();
            this.lblESTADO = new System.Windows.Forms.Label();
            this.cmbLOCALIDAD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTIPO = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.cmbTIPOD = new System.Windows.Forms.ComboBox();
            this.txtDIRECCION = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.lblLOCALIDAD = new System.Windows.Forms.Label();
            this.lblDIRECCION = new System.Windows.Forms.Label();
            this.txtRAZONSOCIAL = new System.Windows.Forms.TextBox();
            this.lblMAIL = new System.Windows.Forms.Label();
            this.lblRAZONSOCIAL = new System.Windows.Forms.Label();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.lblAPELLIDO = new System.Windows.Forms.Label();
            this.lblTELEFONO = new System.Windows.Forms.Label();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.lblDOCUMENTO = new System.Windows.Forms.Label();
            this.txtDOCUMENTO = new System.Windows.Forms.TextBox();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnLupa);
            this.panel1.Controls.Add(this.cmbESTADO);
            this.panel1.Controls.Add(this.cmbTIPO);
            this.panel1.Controls.Add(this.lblESTADO);
            this.panel1.Controls.Add(this.cmbLOCALIDAD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTIPO);
            this.panel1.Controls.Add(this.txtNOMBRE);
            this.panel1.Controls.Add(this.cmbTIPOD);
            this.panel1.Controls.Add(this.txtDIRECCION);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMAIL);
            this.panel1.Controls.Add(this.lblLOCALIDAD);
            this.panel1.Controls.Add(this.lblDIRECCION);
            this.panel1.Controls.Add(this.txtRAZONSOCIAL);
            this.panel1.Controls.Add(this.lblMAIL);
            this.panel1.Controls.Add(this.lblRAZONSOCIAL);
            this.panel1.Controls.Add(this.txtTELEFONO);
            this.panel1.Controls.Add(this.lblAPELLIDO);
            this.panel1.Controls.Add(this.lblTELEFONO);
            this.panel1.Controls.Add(this.txtAPELLIDO);
            this.panel1.Controls.Add(this.lblDOCUMENTO);
            this.panel1.Controls.Add(this.txtDOCUMENTO);
            this.panel1.Location = new System.Drawing.Point(15, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 274);
            this.panel1.TabIndex = 16;
            // 
            // btnLupa
            // 
            this.btnLupa.BackColor = System.Drawing.SystemColors.Control;
            this.btnLupa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLupa.BackgroundImage")));
            this.btnLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLupa.FlatAppearance.BorderSize = 0;
            this.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa.Location = new System.Drawing.Point(481, 168);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(25, 24);
            this.btnLupa.TabIndex = 27;
            this.btnLupa.UseVisualStyleBackColor = false;
            this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
            // 
            // cmbESTADO
            // 
            this.cmbESTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbESTADO.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmbESTADO.FormattingEnabled = true;
            this.cmbESTADO.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmbESTADO.Location = new System.Drawing.Point(119, 216);
            this.cmbESTADO.Margin = new System.Windows.Forms.Padding(2);
            this.cmbESTADO.Name = "cmbESTADO";
            this.cmbESTADO.Size = new System.Drawing.Size(388, 21);
            this.cmbESTADO.TabIndex = 11;
            // 
            // cmbTIPO
            // 
            this.cmbTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTIPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTIPO.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmbTIPO.FormattingEnabled = true;
            this.cmbTIPO.Items.AddRange(new object[] {
            "MALO",
            "BUENO",
            "MUY BUENO",
            "MUY MALO"});
            this.cmbTIPO.Location = new System.Drawing.Point(118, 241);
            this.cmbTIPO.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTIPO.Name = "cmbTIPO";
            this.cmbTIPO.Size = new System.Drawing.Size(388, 21);
            this.cmbTIPO.TabIndex = 10;
            this.cmbTIPO.Visible = false;
            // 
            // lblESTADO
            // 
            this.lblESTADO.AutoSize = true;
            this.lblESTADO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblESTADO.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblESTADO.Location = new System.Drawing.Point(62, 220);
            this.lblESTADO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblESTADO.Name = "lblESTADO";
            this.lblESTADO.Size = new System.Drawing.Size(51, 17);
            this.lblESTADO.TabIndex = 21;
            this.lblESTADO.Text = "Estado:";
            // 
            // cmbLOCALIDAD
            // 
            this.cmbLOCALIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLOCALIDAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLOCALIDAD.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmbLOCALIDAD.FormattingEnabled = true;
            this.cmbLOCALIDAD.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "RUC",
            "PASAPORTE"});
            this.cmbLOCALIDAD.Location = new System.Drawing.Point(119, 168);
            this.cmbLOCALIDAD.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLOCALIDAD.Name = "cmbLOCALIDAD";
            this.cmbLOCALIDAD.Size = new System.Drawing.Size(357, 21);
            this.cmbLOCALIDAD.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tipo Documento:";
            // 
            // lblTIPO
            // 
            this.lblTIPO.AutoSize = true;
            this.lblTIPO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTIPO.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTIPO.Location = new System.Drawing.Point(76, 245);
            this.lblTIPO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTIPO.Name = "lblTIPO";
            this.lblTIPO.Size = new System.Drawing.Size(37, 17);
            this.lblTIPO.TabIndex = 19;
            this.lblTIPO.Text = "Tipo:";
            this.lblTIPO.Visible = false;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNOMBRE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOMBRE.Location = new System.Drawing.Point(119, 33);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(388, 18);
            this.txtNOMBRE.TabIndex = 2;
            this.txtNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOMBRE_KeyPress);
            // 
            // cmbTIPOD
            // 
            this.cmbTIPOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTIPOD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTIPOD.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmbTIPOD.FormattingEnabled = true;
            this.cmbTIPOD.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "RUC",
            "PASAPORTE"});
            this.cmbTIPOD.Location = new System.Drawing.Point(119, 77);
            this.cmbTIPOD.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTIPOD.Name = "cmbTIPOD";
            this.cmbTIPOD.Size = new System.Drawing.Size(388, 21);
            this.cmbTIPOD.TabIndex = 4;
            // 
            // txtDIRECCION
            // 
            this.txtDIRECCION.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDIRECCION.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDIRECCION.Location = new System.Drawing.Point(119, 193);
            this.txtDIRECCION.Margin = new System.Windows.Forms.Padding(2);
            this.txtDIRECCION.Name = "txtDIRECCION";
            this.txtDIRECCION.Size = new System.Drawing.Size(388, 18);
            this.txtDIRECCION.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(54, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre:";
            // 
            // txtMAIL
            // 
            this.txtMAIL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMAIL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMAIL.Location = new System.Drawing.Point(119, 146);
            this.txtMAIL.Margin = new System.Windows.Forms.Padding(2);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(388, 18);
            this.txtMAIL.TabIndex = 7;
            this.txtMAIL.TextChanged += new System.EventHandler(this.txtMAIL_TextChanged);
            // 
            // lblLOCALIDAD
            // 
            this.lblLOCALIDAD.AutoSize = true;
            this.lblLOCALIDAD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLOCALIDAD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLOCALIDAD.Location = new System.Drawing.Point(46, 172);
            this.lblLOCALIDAD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLOCALIDAD.Name = "lblLOCALIDAD";
            this.lblLOCALIDAD.Size = new System.Drawing.Size(67, 17);
            this.lblLOCALIDAD.TabIndex = 7;
            this.lblLOCALIDAD.Text = "Localidad:";
            // 
            // lblDIRECCION
            // 
            this.lblDIRECCION.AutoSize = true;
            this.lblDIRECCION.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDIRECCION.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDIRECCION.Location = new System.Drawing.Point(48, 194);
            this.lblDIRECCION.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDIRECCION.Name = "lblDIRECCION";
            this.lblDIRECCION.Size = new System.Drawing.Size(65, 17);
            this.lblDIRECCION.TabIndex = 1;
            this.lblDIRECCION.Text = "Direccion:";
            // 
            // txtRAZONSOCIAL
            // 
            this.txtRAZONSOCIAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRAZONSOCIAL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAZONSOCIAL.Location = new System.Drawing.Point(119, 11);
            this.txtRAZONSOCIAL.Margin = new System.Windows.Forms.Padding(2);
            this.txtRAZONSOCIAL.Name = "txtRAZONSOCIAL";
            this.txtRAZONSOCIAL.Size = new System.Drawing.Size(388, 18);
            this.txtRAZONSOCIAL.TabIndex = 1;
            // 
            // lblMAIL
            // 
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMAIL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMAIL.Location = new System.Drawing.Point(77, 147);
            this.lblMAIL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(36, 17);
            this.lblMAIL.TabIndex = 17;
            this.lblMAIL.Text = "Mail:";
            // 
            // lblRAZONSOCIAL
            // 
            this.lblRAZONSOCIAL.AutoSize = true;
            this.lblRAZONSOCIAL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAZONSOCIAL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRAZONSOCIAL.Location = new System.Drawing.Point(29, 12);
            this.lblRAZONSOCIAL.Name = "lblRAZONSOCIAL";
            this.lblRAZONSOCIAL.Size = new System.Drawing.Size(85, 17);
            this.lblRAZONSOCIAL.TabIndex = 11;
            this.lblRAZONSOCIAL.Text = "Razon Social:";
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTELEFONO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTELEFONO.Location = new System.Drawing.Point(119, 124);
            this.txtTELEFONO.Margin = new System.Windows.Forms.Padding(2);
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(388, 18);
            this.txtTELEFONO.TabIndex = 6;
            this.txtTELEFONO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTELEFONO_KeyPress);
            // 
            // lblAPELLIDO
            // 
            this.lblAPELLIDO.AutoSize = true;
            this.lblAPELLIDO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAPELLIDO.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAPELLIDO.Location = new System.Drawing.Point(54, 56);
            this.lblAPELLIDO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAPELLIDO.Name = "lblAPELLIDO";
            this.lblAPELLIDO.Size = new System.Drawing.Size(59, 17);
            this.lblAPELLIDO.TabIndex = 11;
            this.lblAPELLIDO.Text = "Apellido:";
            // 
            // lblTELEFONO
            // 
            this.lblTELEFONO.AutoSize = true;
            this.lblTELEFONO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTELEFONO.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTELEFONO.Location = new System.Drawing.Point(52, 125);
            this.lblTELEFONO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTELEFONO.Name = "lblTELEFONO";
            this.lblTELEFONO.Size = new System.Drawing.Size(61, 17);
            this.lblTELEFONO.TabIndex = 15;
            this.lblTELEFONO.Text = "Telefono:";
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAPELLIDO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAPELLIDO.Location = new System.Drawing.Point(119, 55);
            this.txtAPELLIDO.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(388, 18);
            this.txtAPELLIDO.TabIndex = 3;
            this.txtAPELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPELLIDO_KeyPress);
            // 
            // lblDOCUMENTO
            // 
            this.lblDOCUMENTO.AutoSize = true;
            this.lblDOCUMENTO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDOCUMENTO.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDOCUMENTO.Location = new System.Drawing.Point(35, 103);
            this.lblDOCUMENTO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOCUMENTO.Name = "lblDOCUMENTO";
            this.lblDOCUMENTO.Size = new System.Drawing.Size(78, 17);
            this.lblDOCUMENTO.TabIndex = 13;
            this.lblDOCUMENTO.Text = "Documento:";
            // 
            // txtDOCUMENTO
            // 
            this.txtDOCUMENTO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDOCUMENTO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDOCUMENTO.Location = new System.Drawing.Point(119, 102);
            this.txtDOCUMENTO.Margin = new System.Windows.Forms.Padding(2);
            this.txtDOCUMENTO.Name = "txtDOCUMENTO";
            this.txtDOCUMENTO.Size = new System.Drawing.Size(388, 18);
            this.txtDOCUMENTO.TabIndex = 5;
            this.txtDOCUMENTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDOCUMENTO_KeyPress);
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
            this.btnSALIR.Location = new System.Drawing.Point(260, 0);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(260, 35);
            this.btnSALIR.TabIndex = 16;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.BtnSALIR_Click);
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
            this.btnGUARDAR.Size = new System.Drawing.Size(260, 35);
            this.btnGUARDAR.TabIndex = 16;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.BtnGUARDAR_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnSALIR);
            this.panel2.Controls.Add(this.btnGUARDAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 35);
            this.panel2.TabIndex = 17;
            // 
            // PROVEEDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PROVEEDOR";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "PROVEEDOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.ComboBox cmbESTADO;
        private System.Windows.Forms.ComboBox cmbTIPO;
        private System.Windows.Forms.Label lblESTADO;
        private System.Windows.Forms.ComboBox cmbLOCALIDAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTIPO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.ComboBox cmbTIPOD;
        private System.Windows.Forms.TextBox txtDIRECCION;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.Label lblLOCALIDAD;
        private System.Windows.Forms.Label lblDIRECCION;
        private System.Windows.Forms.TextBox txtRAZONSOCIAL;
        private System.Windows.Forms.Label lblMAIL;
        private System.Windows.Forms.Label lblRAZONSOCIAL;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.Label lblAPELLIDO;
        private System.Windows.Forms.Label lblTELEFONO;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.Label lblDOCUMENTO;
        private System.Windows.Forms.TextBox txtDOCUMENTO;
        private System.Windows.Forms.Button btnLupa;
        private System.Windows.Forms.Panel panel2;
    }
}