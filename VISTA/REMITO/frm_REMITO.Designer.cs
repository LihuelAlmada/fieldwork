namespace VISTA.REMITO
{
    partial class frm_REMITO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_REMITO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMATERIAL = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.txtORDENCOMPRA = new System.Windows.Forms.TextBox();
            this.dtpFECHARECEPCION = new System.Windows.Forms.DateTimePicker();
            this.txtNROREMITO = new System.Windows.Forms.TextBox();
            this.txtLOCALIDAD_PROV = new System.Windows.Forms.TextBox();
            this.txtDIRECCION_PROV = new System.Windows.Forms.TextBox();
            this.txtPROVEEDOR = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLUPA_OC = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMATERIALES = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVERIFCANT = new MetroFramework.Controls.MetroButton();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvUPDATED = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATERIALES)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUPDATED)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMATERIAL
            // 
            this.txtMATERIAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMATERIAL.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMATERIAL.Location = new System.Drawing.Point(72, 13);
            this.txtMATERIAL.Margin = new System.Windows.Forms.Padding(2);
            this.txtMATERIAL.Name = "txtMATERIAL";
            this.txtMATERIAL.Size = new System.Drawing.Size(1040, 18);
            this.txtMATERIAL.TabIndex = 64;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAGREGAR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAGREGAR.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAGREGAR.ForeColor = System.Drawing.Color.DimGray;
            this.btnAGREGAR.Location = new System.Drawing.Point(20, 551);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(1123, 40);
            this.btnAGREGAR.TabIndex = 61;
            this.btnAGREGAR.Text = "Confirmar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // txtORDENCOMPRA
            // 
            this.txtORDENCOMPRA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtORDENCOMPRA.Enabled = false;
            this.txtORDENCOMPRA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtORDENCOMPRA.Location = new System.Drawing.Point(551, 10);
            this.txtORDENCOMPRA.Margin = new System.Windows.Forms.Padding(2);
            this.txtORDENCOMPRA.Name = "txtORDENCOMPRA";
            this.txtORDENCOMPRA.Size = new System.Drawing.Size(341, 18);
            this.txtORDENCOMPRA.TabIndex = 23;
            // 
            // dtpFECHARECEPCION
            // 
            this.dtpFECHARECEPCION.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpFECHARECEPCION.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFECHARECEPCION.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFECHARECEPCION.Location = new System.Drawing.Point(1018, 8);
            this.dtpFECHARECEPCION.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFECHARECEPCION.Name = "dtpFECHARECEPCION";
            this.dtpFECHARECEPCION.Size = new System.Drawing.Size(94, 22);
            this.dtpFECHARECEPCION.TabIndex = 12;
            // 
            // txtNROREMITO
            // 
            this.txtNROREMITO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNROREMITO.Enabled = false;
            this.txtNROREMITO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNROREMITO.Location = new System.Drawing.Point(114, 11);
            this.txtNROREMITO.Margin = new System.Windows.Forms.Padding(2);
            this.txtNROREMITO.Name = "txtNROREMITO";
            this.txtNROREMITO.Size = new System.Drawing.Size(311, 18);
            this.txtNROREMITO.TabIndex = 9;
            // 
            // txtLOCALIDAD_PROV
            // 
            this.txtLOCALIDAD_PROV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLOCALIDAD_PROV.Enabled = false;
            this.txtLOCALIDAD_PROV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLOCALIDAD_PROV.Location = new System.Drawing.Point(815, 13);
            this.txtLOCALIDAD_PROV.Margin = new System.Windows.Forms.Padding(2);
            this.txtLOCALIDAD_PROV.Name = "txtLOCALIDAD_PROV";
            this.txtLOCALIDAD_PROV.Size = new System.Drawing.Size(287, 18);
            this.txtLOCALIDAD_PROV.TabIndex = 26;
            // 
            // txtDIRECCION_PROV
            // 
            this.txtDIRECCION_PROV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDIRECCION_PROV.Enabled = false;
            this.txtDIRECCION_PROV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDIRECCION_PROV.Location = new System.Drawing.Point(453, 12);
            this.txtDIRECCION_PROV.Margin = new System.Windows.Forms.Padding(2);
            this.txtDIRECCION_PROV.Name = "txtDIRECCION_PROV";
            this.txtDIRECCION_PROV.Size = new System.Drawing.Size(287, 18);
            this.txtDIRECCION_PROV.TabIndex = 25;
            // 
            // txtPROVEEDOR
            // 
            this.txtPROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPROVEEDOR.Enabled = false;
            this.txtPROVEEDOR.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPROVEEDOR.Location = new System.Drawing.Point(93, 12);
            this.txtPROVEEDOR.Margin = new System.Windows.Forms.Padding(2);
            this.txtPROVEEDOR.Name = "txtPROVEEDOR";
            this.txtPROVEEDOR.Size = new System.Drawing.Size(287, 18);
            this.txtPROVEEDOR.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpFECHARECEPCION);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtNROREMITO);
            this.panel1.Controls.Add(this.txtORDENCOMPRA);
            this.panel1.Controls.Add(this.btnLUPA_OC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 41);
            this.panel1.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(921, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Fecha entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(429, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Orden de Compra:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label18.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label18.Location = new System.Drawing.Point(9, 10);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Numero Remito:";
            // 
            // btnLUPA_OC
            // 
            this.btnLUPA_OC.BackColor = System.Drawing.SystemColors.Control;
            this.btnLUPA_OC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLUPA_OC.BackgroundImage")));
            this.btnLUPA_OC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLUPA_OC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLUPA_OC.FlatAppearance.BorderSize = 0;
            this.btnLUPA_OC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLUPA_OC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLUPA_OC.Location = new System.Drawing.Point(896, 7);
            this.btnLUPA_OC.Margin = new System.Windows.Forms.Padding(2);
            this.btnLUPA_OC.Name = "btnLUPA_OC";
            this.btnLUPA_OC.Size = new System.Drawing.Size(21, 24);
            this.btnLUPA_OC.TabIndex = 24;
            this.btnLUPA_OC.UseVisualStyleBackColor = false;
            this.btnLUPA_OC.Click += new System.EventHandler(this.btnLUPA_OC_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtMATERIAL);
            this.panel4.Location = new System.Drawing.Point(20, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1123, 44);
            this.panel4.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Material:";
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
            this.dgvMATERIALES.Location = new System.Drawing.Point(20, 331);
            this.dgvMATERIALES.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMATERIALES.Name = "dgvMATERIALES";
            this.dgvMATERIALES.RowHeadersVisible = false;
            this.dgvMATERIALES.RowHeadersWidth = 51;
            this.dgvMATERIALES.RowTemplate.Height = 24;
            this.dgvMATERIALES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMATERIALES.Size = new System.Drawing.Size(966, 164);
            this.dgvMATERIALES.TabIndex = 69;
            this.dgvMATERIALES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMATERIALES_CellClick);
            this.dgvMATERIALES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMATERIALES_CellContentClick);
            this.dgvMATERIALES.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMATERIALES_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnVERIFCANT);
            this.panel2.Controls.Add(this.txtCANTIDAD);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(991, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 164);
            this.panel2.TabIndex = 70;
            // 
            // btnVERIFCANT
            // 
            this.btnVERIFCANT.BackColor = System.Drawing.Color.Red;
            this.btnVERIFCANT.Location = new System.Drawing.Point(9, 84);
            this.btnVERIFCANT.Margin = new System.Windows.Forms.Padding(2);
            this.btnVERIFCANT.Name = "btnVERIFCANT";
            this.btnVERIFCANT.Size = new System.Drawing.Size(134, 54);
            this.btnVERIFCANT.TabIndex = 70;
            this.btnVERIFCANT.Text = "+";
            this.btnVERIFCANT.UseSelectable = true;
            this.btnVERIFCANT.Click += new System.EventHandler(this.btnVERIFCANT_Click);
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCANTIDAD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCANTIDAD.Location = new System.Drawing.Point(9, 52);
            this.txtCANTIDAD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(134, 18);
            this.txtCANTIDAD.TabIndex = 69;
            this.txtCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCANTIDAD_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Cantidad Ingresada:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtLOCALIDAD_PROV);
            this.panel3.Controls.Add(this.txtPROVEEDOR);
            this.panel3.Controls.Add(this.txtDIRECCION_PROV);
            this.panel3.Location = new System.Drawing.Point(20, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1123, 44);
            this.panel3.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(744, 13);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Localidad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(384, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Direccion:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(17, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Proveedor:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dgvUPDATED
            // 
            this.dgvUPDATED.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUPDATED.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUPDATED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUPDATED.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUPDATED.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUPDATED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUPDATED.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUPDATED.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUPDATED.EnableHeadersVisualStyles = false;
            this.dgvUPDATED.Location = new System.Drawing.Point(20, 106);
            this.dgvUPDATED.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUPDATED.Name = "dgvUPDATED";
            this.dgvUPDATED.RowHeadersVisible = false;
            this.dgvUPDATED.RowHeadersWidth = 51;
            this.dgvUPDATED.RowTemplate.Height = 24;
            this.dgvUPDATED.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUPDATED.Size = new System.Drawing.Size(1123, 171);
            this.dgvUPDATED.TabIndex = 73;
            this.dgvUPDATED.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUPDATED_CellContentClick);
            this.dgvUPDATED.DoubleClick += new System.EventHandler(this.dgvUPDATED_DoubleClick);
            // 
            // frm_REMITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 611);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvUPDATED);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvMATERIALES);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_REMITO";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Remito";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATERIALES)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUPDATED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMATERIAL;
        private System.Windows.Forms.DateTimePicker dtpFECHARECEPCION;
        private System.Windows.Forms.TextBox txtNROREMITO;
        private System.Windows.Forms.Button btnLUPA_OC;
        private System.Windows.Forms.TextBox txtORDENCOMPRA;
        private System.Windows.Forms.TextBox txtLOCALIDAD_PROV;
        private System.Windows.Forms.TextBox txtDIRECCION_PROV;
        private System.Windows.Forms.TextBox txtPROVEEDOR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMATERIALES;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MetroFramework.Controls.MetroButton btnVERIFCANT;
        private System.Windows.Forms.DataGridView dgvUPDATED;
        public System.Windows.Forms.Button btnAGREGAR;
    }
}