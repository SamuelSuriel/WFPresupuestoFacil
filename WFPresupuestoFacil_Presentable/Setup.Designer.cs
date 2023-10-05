namespace WFPresupuestoFacil_Presentable
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            label1 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            btnAtrasSetup = new Label();
            btnGuardarArticuloGasto = new Button();
            txtArticulo = new TextBox();
            lblArticulo = new Label();
            dgvArticulos = new DataGridView();
            btnGuardarCategoria = new Button();
            txtCategoria = new TextBox();
            label2 = new Label();
            dgvCategorias = new DataGridView();
            btnGuardarEstatus = new Button();
            txtEstatus = new TextBox();
            label3 = new Label();
            dgvEstatus = new DataGridView();
            panel2 = new Panel();
            checkEsIngreso = new CheckBox();
            btnEliminarArticuloGasto = new Label();
            btnEditarArticuloGasto = new Label();
            panel3 = new Panel();
            btnEliminarCategoria = new Label();
            btnEditarCategoria = new Label();
            panel4 = new Panel();
            btnEliminarEstatus = new Label();
            btnEditarEstatus = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstatus).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 46);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Configurar Artículos ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(-201, 38);
            label9.Name = "label9";
            label9.Size = new Size(188, 28);
            label9.TabIndex = 40;
            label9.Text = "Listado de usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnAtrasSetup);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1547, 66);
            panel1.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(431, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(693, 65);
            panel5.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(233, 11);
            label4.Name = "label4";
            label4.Size = new Size(203, 37);
            label4.TabIndex = 3;
            label4.Text = "Configuración ";
            // 
            // btnAtrasSetup
            // 
            btnAtrasSetup.AutoSize = true;
            btnAtrasSetup.BackColor = Color.Transparent;
            btnAtrasSetup.Cursor = Cursors.Hand;
            btnAtrasSetup.Font = new Font("Segoe Fluent Icons", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtrasSetup.ForeColor = Color.White;
            btnAtrasSetup.Location = new Point(16, 20);
            btnAtrasSetup.Name = "btnAtrasSetup";
            btnAtrasSetup.Size = new Size(25, 28);
            btnAtrasSetup.TabIndex = 2;
            btnAtrasSetup.Text = "<";
            btnAtrasSetup.Click += btnAtrasSetup_Click;
            // 
            // btnGuardarArticuloGasto
            // 
            btnGuardarArticuloGasto.BackColor = Color.DeepSkyBlue;
            btnGuardarArticuloGasto.Cursor = Cursors.Hand;
            btnGuardarArticuloGasto.FlatAppearance.BorderColor = Color.Magenta;
            btnGuardarArticuloGasto.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarArticuloGasto.ForeColor = Color.White;
            btnGuardarArticuloGasto.Location = new Point(14, 264);
            btnGuardarArticuloGasto.Name = "btnGuardarArticuloGasto";
            btnGuardarArticuloGasto.Size = new Size(218, 42);
            btnGuardarArticuloGasto.TabIndex = 36;
            btnGuardarArticuloGasto.Text = "Guardar";
            btnGuardarArticuloGasto.UseVisualStyleBackColor = false;
            btnGuardarArticuloGasto.Click += btnGuardarArticuloGasto_Click;
            // 
            // txtArticulo
            // 
            txtArticulo.BackColor = Color.White;
            txtArticulo.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtArticulo.ForeColor = Color.DimGray;
            txtArticulo.Location = new Point(14, 157);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(218, 31);
            txtArticulo.TabIndex = 25;
            // 
            // lblArticulo
            // 
            lblArticulo.AutoSize = true;
            lblArticulo.Font = new Font("Segoe UI Variable Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblArticulo.ForeColor = Color.White;
            lblArticulo.Location = new Point(68, 97);
            lblArticulo.Name = "lblArticulo";
            lblArticulo.Size = new Size(112, 31);
            lblArticulo.TabIndex = 24;
            lblArticulo.Text = "Artículos";
            // 
            // dgvArticulos
            // 
            dgvArticulos.BackgroundColor = Color.White;
            dgvArticulos.BorderStyle = BorderStyle.None;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(16, 82);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.RowTemplate.Height = 29;
            dgvArticulos.Size = new Size(265, 509);
            dgvArticulos.TabIndex = 23;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.BackColor = Color.DeepSkyBlue;
            btnGuardarCategoria.Cursor = Cursors.Hand;
            btnGuardarCategoria.FlatAppearance.BorderColor = Color.Magenta;
            btnGuardarCategoria.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCategoria.ForeColor = Color.White;
            btnGuardarCategoria.Location = new Point(29, 264);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(210, 42);
            btnGuardarCategoria.TabIndex = 44;
            btnGuardarCategoria.Text = "Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = false;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.White;
            txtCategoria.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtCategoria.ForeColor = Color.DimGray;
            txtCategoria.Location = new Point(14, 157);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(244, 31);
            txtCategoria.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 97);
            label2.Name = "label2";
            label2.Size = new Size(204, 31);
            label2.TabIndex = 42;
            label2.Text = "Categorías Gastos";
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(566, 82);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.RowTemplate.Height = 29;
            dgvCategorias.Size = new Size(183, 509);
            dgvCategorias.TabIndex = 41;
            // 
            // btnGuardarEstatus
            // 
            btnGuardarEstatus.BackColor = Color.DeepSkyBlue;
            btnGuardarEstatus.Cursor = Cursors.Hand;
            btnGuardarEstatus.FlatAppearance.BorderColor = Color.Magenta;
            btnGuardarEstatus.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarEstatus.ForeColor = Color.White;
            btnGuardarEstatus.Location = new Point(34, 264);
            btnGuardarEstatus.Name = "btnGuardarEstatus";
            btnGuardarEstatus.Size = new Size(211, 42);
            btnGuardarEstatus.TabIndex = 50;
            btnGuardarEstatus.Text = "Guardar";
            btnGuardarEstatus.UseVisualStyleBackColor = false;
            btnGuardarEstatus.Click += btnGuardarEstatus_Click;
            // 
            // txtEstatus
            // 
            txtEstatus.BackColor = Color.White;
            txtEstatus.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtEstatus.ForeColor = Color.DimGray;
            txtEstatus.Location = new Point(16, 160);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(244, 31);
            txtEstatus.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 97);
            label3.Name = "label3";
            label3.Size = new Size(167, 31);
            label3.TabIndex = 48;
            label3.Text = "Estatus Gastos";
            // 
            // dgvEstatus
            // 
            dgvEstatus.BackgroundColor = Color.White;
            dgvEstatus.BorderStyle = BorderStyle.None;
            dgvEstatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstatus.Location = new Point(1051, 82);
            dgvEstatus.Name = "dgvEstatus";
            dgvEstatus.RowHeadersWidth = 51;
            dgvEstatus.RowTemplate.Height = 29;
            dgvEstatus.Size = new Size(183, 509);
            dgvEstatus.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(checkEsIngreso);
            panel2.Controls.Add(btnEliminarArticuloGasto);
            panel2.Controls.Add(btnEditarArticuloGasto);
            panel2.Controls.Add(btnGuardarArticuloGasto);
            panel2.Controls.Add(txtArticulo);
            panel2.Controls.Add(lblArticulo);
            panel2.Location = new Point(293, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 511);
            panel2.TabIndex = 53;
            // 
            // checkEsIngreso
            // 
            checkEsIngreso.AutoSize = true;
            checkEsIngreso.ForeColor = Color.White;
            checkEsIngreso.Location = new Point(14, 205);
            checkEsIngreso.Name = "checkEsIngreso";
            checkEsIngreso.Size = new Size(98, 24);
            checkEsIngreso.TabIndex = 42;
            checkEsIngreso.Text = "Es ingreso";
            checkEsIngreso.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticuloGasto
            // 
            btnEliminarArticuloGasto.AutoSize = true;
            btnEliminarArticuloGasto.Cursor = Cursors.Hand;
            btnEliminarArticuloGasto.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarArticuloGasto.ForeColor = Color.White;
            btnEliminarArticuloGasto.Location = new Point(141, 340);
            btnEliminarArticuloGasto.Name = "btnEliminarArticuloGasto";
            btnEliminarArticuloGasto.Size = new Size(91, 25);
            btnEliminarArticuloGasto.TabIndex = 40;
            btnEliminarArticuloGasto.Text = "ELIMINAR";
            btnEliminarArticuloGasto.Click += btnEliminarArticuloGasto_Click;
            // 
            // btnEditarArticuloGasto
            // 
            btnEditarArticuloGasto.AutoSize = true;
            btnEditarArticuloGasto.Cursor = Cursors.Hand;
            btnEditarArticuloGasto.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            btnEditarArticuloGasto.ForeColor = Color.White;
            btnEditarArticuloGasto.Location = new Point(13, 340);
            btnEditarArticuloGasto.Name = "btnEditarArticuloGasto";
            btnEditarArticuloGasto.Size = new Size(70, 25);
            btnEditarArticuloGasto.TabIndex = 39;
            btnEditarArticuloGasto.Text = "EDITAR";
            btnEditarArticuloGasto.Click += btnEditarArticuloGasto_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnEliminarCategoria);
            panel3.Controls.Add(btnEditarCategoria);
            panel3.Controls.Add(btnGuardarCategoria);
            panel3.Controls.Add(txtCategoria);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(767, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 511);
            panel3.TabIndex = 54;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.AutoSize = true;
            btnEliminarCategoria.Cursor = Cursors.Hand;
            btnEliminarCategoria.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarCategoria.ForeColor = Color.White;
            btnEliminarCategoria.Location = new Point(148, 340);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(91, 25);
            btnEliminarCategoria.TabIndex = 42;
            btnEliminarCategoria.Text = "ELIMINAR";
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.AutoSize = true;
            btnEditarCategoria.Cursor = Cursors.Hand;
            btnEditarCategoria.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            btnEditarCategoria.ForeColor = Color.White;
            btnEditarCategoria.Location = new Point(29, 340);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(70, 25);
            btnEditarCategoria.TabIndex = 41;
            btnEditarCategoria.Text = "EDITAR";
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnEliminarEstatus);
            panel4.Controls.Add(btnEditarEstatus);
            panel4.Controls.Add(btnGuardarEstatus);
            panel4.Controls.Add(txtEstatus);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(1249, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 509);
            panel4.TabIndex = 55;
            // 
            // btnEliminarEstatus
            // 
            btnEliminarEstatus.AutoSize = true;
            btnEliminarEstatus.Cursor = Cursors.Hand;
            btnEliminarEstatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarEstatus.ForeColor = Color.White;
            btnEliminarEstatus.Location = new Point(154, 340);
            btnEliminarEstatus.Name = "btnEliminarEstatus";
            btnEliminarEstatus.Size = new Size(91, 25);
            btnEliminarEstatus.TabIndex = 48;
            btnEliminarEstatus.Text = "ELIMINAR";
            btnEliminarEstatus.Click += btnEliminarEstatus_Click;
            // 
            // btnEditarEstatus
            // 
            btnEditarEstatus.AutoSize = true;
            btnEditarEstatus.Cursor = Cursors.Hand;
            btnEditarEstatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            btnEditarEstatus.ForeColor = Color.White;
            btnEditarEstatus.Location = new Point(34, 340);
            btnEditarEstatus.Name = "btnEditarEstatus";
            btnEditarEstatus.Size = new Size(70, 25);
            btnEditarEstatus.TabIndex = 47;
            btnEditarEstatus.Text = "EDITAR";
            btnEditarEstatus.Click += btnEditarEstatus_Click;
            // 
            // Setup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1547, 615);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvEstatus);
            Controls.Add(dgvCategorias);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(dgvArticulos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Setup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setup";
            Load += Setup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstatus).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label9;
        private Panel panel1;
        private Label btnAtrasSetup;
        private Button btnGuardarArticuloGasto;
        private TextBox txtArticulo;
        private Label lblArticulo;
        private DataGridView dgvArticulos;
        private Label label4;
        private Button btnGuardarCategoria;
        private TextBox txtCategoria;
        private Label label2;
        private DataGridView dgvCategorias;
        private Button btnGuardarEstatus;
        private TextBox txtEstatus;
        private Label label3;
        private DataGridView dgvEstatus;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label btnEliminarArticuloGasto;
        private Label btnEditarArticuloGasto;
        private Label btnEliminarCategoria;
        private Label btnEditarCategoria;
        private Label btnEliminarEstatus;
        private Label btnEditarEstatus;
        private CheckBox checkEsIngreso;
    }
}