﻿namespace LoginSistem.Forms
{
    partial class PanelPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPresupuesto));
            panel1 = new Panel();
            label15 = new Label();
            label14 = new Label();
            lblDivisor = new Label();
            picClose = new PictureBox();
            picSetup = new PictureBox();
            picModifyUser = new PictureBox();
            picAbout = new PictureBox();
            lblCloseSession = new Label();
            lblSetup = new Label();
            lblModifyUser = new Label();
            lblAbout = new Label();
            label6 = new Label();
            label04 = new Label();
            lblUser = new Label();
            lblPerfil = new Label();
            lblFecha = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabResumen = new TabControl();
            tabPage1 = new TabPage();
            pbrResumen = new ProgressBar();
            panel3 = new Panel();
            panel2 = new Panel();
            lblSaldo = new Label();
            lblTotalGastos = new Label();
            lblTotalIngresos = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabIngresos = new TabPage();
            btnEditarIngresos = new Button();
            btnGuardarIngreso = new Button();
            label12 = new Label();
            label13 = new Label();
            cbArticuloIngreso = new ComboBox();
            txtImporteIngreso = new TextBox();
            panel4 = new Panel();
            label8 = new Label();
            dgvIngresos = new DataGridView();
            tabGastos = new TabPage();
            btnEditarGasto = new Button();
            label16 = new Label();
            cbArticuloGasto = new ComboBox();
            btnGuardarGasto = new Button();
            label11 = new Label();
            label10 = new Label();
            cbCategoriaGastos = new ComboBox();
            txtImporte = new TextBox();
            label9 = new Label();
            cbEstatusGasto = new ComboBox();
            panel5 = new Panel();
            label4 = new Label();
            dgvGastos = new DataGridView();
            label5 = new Label();
            panel6 = new Panel();
            btnCerrarPanel = new Label();
            label7 = new Label();
            label17 = new Label();
            btnAdministrarUsuarios = new PictureBox();
            lblAdministrarUsuarios = new Label();
            panelAdmin = new Panel();
            btnEliminarIngreso = new Button();
            btnEliminarGasto = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSetup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picModifyUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAbout).BeginInit();
            tabResumen.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabIngresos.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            tabGastos.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdministrarUsuarios).BeginInit();
            panelAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblDivisor);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(picSetup);
            panel1.Controls.Add(picModifyUser);
            panel1.Controls.Add(picAbout);
            panel1.Controls.Add(lblCloseSession);
            panel1.Controls.Add(lblSetup);
            panel1.Controls.Add(lblModifyUser);
            panel1.Controls.Add(lblAbout);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label04);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(lblPerfil);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 734);
            panel1.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(48, 543);
            label15.Name = "label15";
            label15.Size = new Size(147, 20);
            label15.TabIndex = 26;
            label15.Text = "-----------------------";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(48, 474);
            label14.Name = "label14";
            label14.Size = new Size(147, 20);
            label14.TabIndex = 25;
            label14.Text = "-----------------------";
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDivisor.ForeColor = Color.Gray;
            lblDivisor.Location = new Point(53, 410);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(147, 20);
            lblDivisor.TabIndex = 24;
            lblDivisor.Text = "-----------------------";
            // 
            // picClose
            // 
            picClose.Cursor = Cursors.Hand;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(53, 573);
            picClose.Name = "picClose";
            picClose.Size = new Size(32, 32);
            picClose.SizeMode = PictureBoxSizeMode.AutoSize;
            picClose.TabIndex = 23;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // picSetup
            // 
            picSetup.Cursor = Cursors.Hand;
            picSetup.Image = (Image)resources.GetObject("picSetup.Image");
            picSetup.Location = new Point(55, 504);
            picSetup.Name = "picSetup";
            picSetup.Size = new Size(32, 32);
            picSetup.SizeMode = PictureBoxSizeMode.AutoSize;
            picSetup.TabIndex = 22;
            picSetup.TabStop = false;
            picSetup.Click += picSetup_Click;
            // 
            // picModifyUser
            // 
            picModifyUser.Cursor = Cursors.Hand;
            picModifyUser.Image = (Image)resources.GetObject("picModifyUser.Image");
            picModifyUser.Location = new Point(56, 442);
            picModifyUser.Name = "picModifyUser";
            picModifyUser.Size = new Size(32, 21);
            picModifyUser.SizeMode = PictureBoxSizeMode.AutoSize;
            picModifyUser.TabIndex = 21;
            picModifyUser.TabStop = false;
            picModifyUser.Click += picModifyUser_Click;
            // 
            // picAbout
            // 
            picAbout.Cursor = Cursors.Hand;
            picAbout.Image = (Image)resources.GetObject("picAbout.Image");
            picAbout.Location = new Point(55, 367);
            picAbout.Name = "picAbout";
            picAbout.Size = new Size(32, 32);
            picAbout.SizeMode = PictureBoxSizeMode.AutoSize;
            picAbout.TabIndex = 20;
            picAbout.TabStop = false;
            // 
            // lblCloseSession
            // 
            lblCloseSession.AutoSize = true;
            lblCloseSession.Location = new Point(89, 580);
            lblCloseSession.Name = "lblCloseSession";
            lblCloseSession.Size = new Size(98, 20);
            lblCloseSession.TabIndex = 19;
            lblCloseSession.Text = "Close Session";
            // 
            // lblSetup
            // 
            lblSetup.AutoSize = true;
            lblSetup.Location = new Point(89, 510);
            lblSetup.Name = "lblSetup";
            lblSetup.Size = new Size(47, 20);
            lblSetup.TabIndex = 18;
            lblSetup.Text = "Setup";
            // 
            // lblModifyUser
            // 
            lblModifyUser.AutoSize = true;
            lblModifyUser.Location = new Point(91, 445);
            lblModifyUser.Name = "lblModifyUser";
            lblModifyUser.Size = new Size(87, 20);
            lblModifyUser.TabIndex = 17;
            lblModifyUser.Text = "Modify user";
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Location = new Point(90, 373);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(50, 20);
            lblAbout.TabIndex = 4;
            lblAbout.Text = "About";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(17, 129);
            label6.Name = "label6";
            label6.Size = new Size(160, 27);
            label6.TabIndex = 16;
            label6.Text = "Bienvenido Sr/a:";
            // 
            // label04
            // 
            label04.AutoSize = true;
            label04.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label04.ForeColor = Color.Gray;
            label04.Location = new Point(12, 205);
            label04.Name = "label04";
            label04.Size = new Size(63, 27);
            label04.TabIndex = 15;
            label04.Text = "Perfil:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.White;
            lblUser.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.ForeColor = Color.Gray;
            lblUser.Location = new Point(19, 168);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(17, 27);
            lblUser.TabIndex = 14;
            lblUser.Text = " ";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = Color.White;
            lblPerfil.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.ForeColor = Color.Gray;
            lblPerfil.Location = new Point(17, 237);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(17, 27);
            lblPerfil.TabIndex = 14;
            lblPerfil.Text = " ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.DimGray;
            lblFecha.Font = new Font("Segoe UI Variable Small", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(273, 176);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(12, 17);
            lblFecha.TabIndex = 27;
            lblFecha.Text = " ";
            // 
            // tabResumen
            // 
            tabResumen.Controls.Add(tabPage1);
            tabResumen.Controls.Add(tabIngresos);
            tabResumen.Controls.Add(tabGastos);
            tabResumen.Location = new Point(269, 205);
            tabResumen.Name = "tabResumen";
            tabResumen.SelectedIndex = 0;
            tabResumen.Size = new Size(801, 529);
            tabResumen.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pbrResumen);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 496);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Resumen";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbrResumen
            // 
            pbrResumen.Location = new Point(28, 103);
            pbrResumen.Name = "pbrResumen";
            pbrResumen.Size = new Size(665, 31);
            pbrResumen.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Location = new Point(23, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(677, 310);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSaldo);
            panel2.Controls.Add(lblTotalGastos);
            panel2.Controls.Add(lblTotalIngresos);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 78);
            panel2.TabIndex = 6;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(458, 49);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(17, 20);
            lblSaldo.TabIndex = 5;
            lblSaldo.Text = "0";
            // 
            // lblTotalGastos
            // 
            lblTotalGastos.AutoSize = true;
            lblTotalGastos.Location = new Point(231, 49);
            lblTotalGastos.Name = "lblTotalGastos";
            lblTotalGastos.Size = new Size(0, 20);
            lblTotalGastos.TabIndex = 4;
            // 
            // lblTotalIngresos
            // 
            lblTotalIngresos.AutoSize = true;
            lblTotalIngresos.Location = new Point(5, 49);
            lblTotalIngresos.Name = "lblTotalIngresos";
            lblTotalIngresos.Size = new Size(0, 20);
            lblTotalIngresos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 15);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Saldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 15);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 1;
            label2.Text = "Total de gastos mensuales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 0;
            label1.Text = "Total de ingresos mensuales";
            // 
            // tabIngresos
            // 
            tabIngresos.Controls.Add(btnEliminarIngreso);
            tabIngresos.Controls.Add(btnEditarIngresos);
            tabIngresos.Controls.Add(btnGuardarIngreso);
            tabIngresos.Controls.Add(label12);
            tabIngresos.Controls.Add(label13);
            tabIngresos.Controls.Add(cbArticuloIngreso);
            tabIngresos.Controls.Add(txtImporteIngreso);
            tabIngresos.Controls.Add(panel4);
            tabIngresos.Controls.Add(dgvIngresos);
            tabIngresos.Location = new Point(4, 29);
            tabIngresos.Name = "tabIngresos";
            tabIngresos.Padding = new Padding(3);
            tabIngresos.Size = new Size(793, 496);
            tabIngresos.TabIndex = 1;
            tabIngresos.Text = "Ingresos";
            tabIngresos.UseVisualStyleBackColor = true;
            // 
            // btnEditarIngresos
            // 
            btnEditarIngresos.BackColor = Color.DimGray;
            btnEditarIngresos.ForeColor = Color.White;
            btnEditarIngresos.Location = new Point(463, 339);
            btnEditarIngresos.Name = "btnEditarIngresos";
            btnEditarIngresos.Size = new Size(112, 46);
            btnEditarIngresos.TabIndex = 16;
            btnEditarIngresos.Text = "Editar";
            btnEditarIngresos.UseVisualStyleBackColor = false;
            btnEditarIngresos.Click += btnEditarIngresos_Click;
            // 
            // btnGuardarIngreso
            // 
            btnGuardarIngreso.BackColor = Color.DimGray;
            btnGuardarIngreso.ForeColor = Color.White;
            btnGuardarIngreso.Location = new Point(603, 339);
            btnGuardarIngreso.Name = "btnGuardarIngreso";
            btnGuardarIngreso.Size = new Size(118, 46);
            btnGuardarIngreso.TabIndex = 15;
            btnGuardarIngreso.Text = "Guardar";
            btnGuardarIngreso.UseVisualStyleBackColor = false;
            btnGuardarIngreso.Click += btnGuardarIngreso_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(497, 202);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 14;
            label12.Text = "Importe";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(497, 134);
            label13.Name = "label13";
            label13.Size = new Size(61, 20);
            label13.TabIndex = 12;
            label13.Text = "Artículo";
            // 
            // cbArticuloIngreso
            // 
            cbArticuloIngreso.FormattingEnabled = true;
            cbArticuloIngreso.Location = new Point(497, 157);
            cbArticuloIngreso.Name = "cbArticuloIngreso";
            cbArticuloIngreso.Size = new Size(205, 28);
            cbArticuloIngreso.TabIndex = 13;
            // 
            // txtImporteIngreso
            // 
            txtImporteIngreso.Location = new Point(497, 225);
            txtImporteIngreso.Name = "txtImporteIngreso";
            txtImporteIngreso.Size = new Size(208, 27);
            txtImporteIngreso.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Location = new Point(463, 26);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 84);
            panel4.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 31);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 4;
            label8.Text = "INGRESOS MENSUALES";
            // 
            // dgvIngresos
            // 
            dgvIngresos.BackgroundColor = Color.White;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.GridColor = Color.White;
            dgvIngresos.Location = new Point(8, 26);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.RowHeadersWidth = 51;
            dgvIngresos.RowTemplate.Height = 29;
            dgvIngresos.Size = new Size(433, 447);
            dgvIngresos.TabIndex = 0;
            // 
            // tabGastos
            // 
            tabGastos.Controls.Add(btnEliminarGasto);
            tabGastos.Controls.Add(btnEditarGasto);
            tabGastos.Controls.Add(label16);
            tabGastos.Controls.Add(cbArticuloGasto);
            tabGastos.Controls.Add(btnGuardarGasto);
            tabGastos.Controls.Add(label11);
            tabGastos.Controls.Add(label10);
            tabGastos.Controls.Add(cbCategoriaGastos);
            tabGastos.Controls.Add(txtImporte);
            tabGastos.Controls.Add(label9);
            tabGastos.Controls.Add(cbEstatusGasto);
            tabGastos.Controls.Add(panel5);
            tabGastos.Controls.Add(dgvGastos);
            tabGastos.Location = new Point(4, 29);
            tabGastos.Name = "tabGastos";
            tabGastos.Padding = new Padding(3);
            tabGastos.Size = new Size(793, 496);
            tabGastos.TabIndex = 2;
            tabGastos.Text = "Gastos";
            tabGastos.UseVisualStyleBackColor = true;
            // 
            // btnEditarGasto
            // 
            btnEditarGasto.BackColor = Color.DimGray;
            btnEditarGasto.ForeColor = Color.White;
            btnEditarGasto.Location = new Point(501, 394);
            btnEditarGasto.Name = "btnEditarGasto";
            btnEditarGasto.Size = new Size(112, 46);
            btnEditarGasto.TabIndex = 11;
            btnEditarGasto.Text = "Editar";
            btnEditarGasto.UseVisualStyleBackColor = false;
            btnEditarGasto.Click += btnEditarGasto_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(524, 123);
            label16.Name = "label16";
            label16.Size = new Size(61, 20);
            label16.TabIndex = 9;
            label16.Text = "Artículo";
            // 
            // cbArticuloGasto
            // 
            cbArticuloGasto.FormattingEnabled = true;
            cbArticuloGasto.Location = new Point(524, 146);
            cbArticuloGasto.Name = "cbArticuloGasto";
            cbArticuloGasto.Size = new Size(205, 28);
            cbArticuloGasto.TabIndex = 10;
            // 
            // btnGuardarGasto
            // 
            btnGuardarGasto.BackColor = Color.DimGray;
            btnGuardarGasto.ForeColor = Color.White;
            btnGuardarGasto.Location = new Point(647, 394);
            btnGuardarGasto.Name = "btnGuardarGasto";
            btnGuardarGasto.Size = new Size(112, 46);
            btnGuardarGasto.TabIndex = 8;
            btnGuardarGasto.Text = "Guardar";
            btnGuardarGasto.UseVisualStyleBackColor = false;
            btnGuardarGasto.Click += btnGuardarGasto_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(524, 252);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 7;
            label11.Text = "Importe";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(524, 188);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 5;
            label10.Text = "Categiría";
            // 
            // cbCategoriaGastos
            // 
            cbCategoriaGastos.FormattingEnabled = true;
            cbCategoriaGastos.Location = new Point(524, 211);
            cbCategoriaGastos.Name = "cbCategoriaGastos";
            cbCategoriaGastos.Size = new Size(205, 28);
            cbCategoriaGastos.TabIndex = 6;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(524, 279);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(208, 27);
            txtImporte.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(524, 323);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 1;
            label9.Text = "Estatus";
            // 
            // cbEstatusGasto
            // 
            cbEstatusGasto.FormattingEnabled = true;
            cbEstatusGasto.Location = new Point(524, 346);
            cbEstatusGasto.Name = "cbEstatusGasto";
            cbEstatusGasto.Size = new Size(205, 28);
            cbEstatusGasto.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Location = new Point(501, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 84);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 33);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 0;
            label4.Text = "GASTOS MENSUALES";
            // 
            // dgvGastos
            // 
            dgvGastos.BackgroundColor = Color.White;
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastos.Location = new Point(10, 38);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.RowHeadersWidth = 51;
            dgvGastos.RowTemplate.Height = 29;
            dgvGastos.Size = new Size(460, 423);
            dgvGastos.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(492, 119);
            label5.Name = "label5";
            label5.Size = new Size(227, 20);
            label5.TabIndex = 2;
            label5.Text = "PRESUPUESTO MENSUAL SIMPLE";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(btnCerrarPanel);
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(263, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(807, 63);
            panel6.TabIndex = 3;
            // 
            // btnCerrarPanel
            // 
            btnCerrarPanel.AutoSize = true;
            btnCerrarPanel.Cursor = Cursors.Hand;
            btnCerrarPanel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarPanel.ForeColor = Color.DimGray;
            btnCerrarPanel.Location = new Point(770, 11);
            btnCerrarPanel.Name = "btnCerrarPanel";
            btnCerrarPanel.Size = new Size(25, 28);
            btnCerrarPanel.TabIndex = 4;
            btnCerrarPanel.Text = "X";
            btnCerrarPanel.Click += btnCerrarPanel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(287, 9);
            label7.Name = "label7";
            label7.Size = new Size(229, 31);
            label7.TabIndex = 17;
            label7.Text = "PRESUPUESTO FÁCIL";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(30, 51);
            label17.Name = "label17";
            label17.Size = new Size(147, 20);
            label17.TabIndex = 28;
            label17.Text = "-----------------------";
            // 
            // btnAdministrarUsuarios
            // 
            btnAdministrarUsuarios.Cursor = Cursors.Hand;
            btnAdministrarUsuarios.Image = (Image)resources.GetObject("btnAdministrarUsuarios.Image");
            btnAdministrarUsuarios.Location = new Point(9, 16);
            btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            btnAdministrarUsuarios.Size = new Size(32, 21);
            btnAdministrarUsuarios.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAdministrarUsuarios.TabIndex = 27;
            btnAdministrarUsuarios.TabStop = false;
            // 
            // lblAdministrarUsuarios
            // 
            lblAdministrarUsuarios.AutoSize = true;
            lblAdministrarUsuarios.Cursor = Cursors.Hand;
            lblAdministrarUsuarios.Location = new Point(44, 19);
            lblAdministrarUsuarios.Name = "lblAdministrarUsuarios";
            lblAdministrarUsuarios.Size = new Size(144, 20);
            lblAdministrarUsuarios.TabIndex = 26;
            lblAdministrarUsuarios.Text = "Administrar usuarios";
            lblAdministrarUsuarios.Click += lblAdministrarUsuarios_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.White;
            panelAdmin.Controls.Add(btnAdministrarUsuarios);
            panelAdmin.Controls.Add(label17);
            panelAdmin.Controls.Add(lblAdministrarUsuarios);
            panelAdmin.Location = new Point(856, 80);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(202, 83);
            panelAdmin.TabIndex = 29;
            // 
            // btnEliminarIngreso
            // 
            btnEliminarIngreso.BackColor = Color.DimGray;
            btnEliminarIngreso.ForeColor = Color.White;
            btnEliminarIngreso.Location = new Point(541, 401);
            btnEliminarIngreso.Name = "btnEliminarIngreso";
            btnEliminarIngreso.Size = new Size(112, 46);
            btnEliminarIngreso.TabIndex = 17;
            btnEliminarIngreso.Text = "Eliminar";
            btnEliminarIngreso.UseVisualStyleBackColor = false;
            btnEliminarIngreso.Click += btnEliminarIngreso_Click;
            // 
            // btnEliminarGasto
            // 
            btnEliminarGasto.BackColor = Color.DimGray;
            btnEliminarGasto.ForeColor = Color.White;
            btnEliminarGasto.Location = new Point(583, 444);
            btnEliminarGasto.Name = "btnEliminarGasto";
            btnEliminarGasto.Size = new Size(112, 46);
            btnEliminarGasto.TabIndex = 18;
            btnEliminarGasto.Text = "Eliminar";
            btnEliminarGasto.UseVisualStyleBackColor = false;
            btnEliminarGasto.Click += btnEliminarGasto_Click;
            // 
            // PanelPresupuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1070, 734);
            Controls.Add(panelAdmin);
            Controls.Add(lblFecha);
            Controls.Add(panel6);
            Controls.Add(label5);
            Controls.Add(tabResumen);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "PanelPresupuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel";
            Load += PanelPresupuesto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSetup).EndInit();
            ((System.ComponentModel.ISupportInitialize)picModifyUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAbout).EndInit();
            tabResumen.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabIngresos.ResumeLayout(false);
            tabIngresos.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            tabGastos.ResumeLayout(false);
            tabGastos.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdministrarUsuarios).EndInit();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Clases.RoundButton roundButton1;
        private TabControl tabResumen;
        private TabPage tabPage1;
        private TabPage tabIngresos;
        private TabPage tabGastos;
        private Label lblSaldo;
        private Label lblTotalGastos;
        private Label lblTotalIngresos;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvIngresos;
        private DataGridView dgvGastos;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label04;
        public Label lblPerfil;
        public Label lblUser;
        private Panel panel6;
        private Label btnCerrarPanel;
        private Label label7;
        private Label label8;
        private Button btnGuardarGasto;
        private Label label11;
        private Label label10;
        private TextBox txtImporte;
        private Label label9;
        private ProgressBar pbrResumen;
        private Button btnGuardarIngreso;
        private Label label12;
        private Label label13;
        private ComboBox cbArticuloIngreso;
        private TextBox txtImporteIngreso;
        private Label lblCloseSession;
        private Label lblSetup;
        private Label lblModifyUser;
        private Label lblAbout;
        private PictureBox picClose;
        private PictureBox picSetup;
        private PictureBox picModifyUser;
        private PictureBox picAbout;
        private Label label15;
        private Label label14;
        private Label lblDivisor;
        public Label lblFecha;
        private Label label16;
        private Button btnEditarGasto;
        private ComboBox cbCategoriaGastos;
        private ComboBox cbEstatusGasto;
        private ComboBox cbArticuloGasto;
        private Label label17;
        private PictureBox btnAdministrarUsuarios;
        private Label lblAdministrarUsuarios;
        private Panel panelAdmin;
        private Button btnEditarIngresos;
        private Button btnEliminarIngreso;
        private Button btnEliminarGasto;
    }
}