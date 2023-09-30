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
            label1 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            label5 = new Label();
            btnAtrasSetup = new Label();
            label8 = new Label();
            label7 = new Label();
            btnEliminarArticuloGasto = new Button();
            btnEditarArticuloGasto = new Button();
            btnGuardarArticuloGasto = new Button();
            txtArticulo = new TextBox();
            lblArticulo = new Label();
            dataGridView1 = new DataGridView();
            btnEliminarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnGuardarCategoria = new Button();
            txtCategoria = new TextBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            btnEliminarEstatus = new Button();
            btnEditarEstatus = new Button();
            btnGuardarEstatus = new Button();
            txtEstatus = new TextBox();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnAtrasSetup);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1700, 125);
            panel1.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(479, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(693, 124);
            panel5.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(185, 45);
            label4.Name = "label4";
            label4.Size = new Size(378, 37);
            label4.TabIndex = 3;
            label4.Text = "Configuración de Categorías";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(1238, 46);
            label5.Name = "label5";
            label5.Size = new Size(332, 37);
            label5.TabIndex = 4;
            label5.Text = "Configuración de Estatus";
            // 
            // btnAtrasSetup
            // 
            btnAtrasSetup.AutoSize = true;
            btnAtrasSetup.BackColor = Color.White;
            btnAtrasSetup.Cursor = Cursors.Hand;
            btnAtrasSetup.Font = new Font("Segoe Fluent Icons", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtrasSetup.ForeColor = Color.DimGray;
            btnAtrasSetup.Location = new Point(12, 39);
            btnAtrasSetup.Name = "btnAtrasSetup";
            btnAtrasSetup.Size = new Size(25, 28);
            btnAtrasSetup.TabIndex = 2;
            btnAtrasSetup.Text = "<";
            btnAtrasSetup.Click += btnAtrasSetup_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1342, 18);
            label8.Name = "label8";
            label8.Size = new Size(25, 28);
            label8.TabIndex = 1;
            label8.Text = "X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(97, 46);
            label7.Name = "label7";
            label7.Size = new Size(355, 37);
            label7.TabIndex = 0;
            label7.Text = "Configuración de Artículos";
            // 
            // btnEliminarArticuloGasto
            // 
            btnEliminarArticuloGasto.BackColor = Color.DimGray;
            btnEliminarArticuloGasto.FlatAppearance.BorderColor = Color.White;
            btnEliminarArticuloGasto.FlatAppearance.BorderSize = 5;
            btnEliminarArticuloGasto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarArticuloGasto.ForeColor = Color.White;
            btnEliminarArticuloGasto.Location = new Point(4, 405);
            btnEliminarArticuloGasto.Name = "btnEliminarArticuloGasto";
            btnEliminarArticuloGasto.Size = new Size(244, 55);
            btnEliminarArticuloGasto.TabIndex = 38;
            btnEliminarArticuloGasto.Text = "Eliminar";
            btnEliminarArticuloGasto.UseVisualStyleBackColor = false;
            // 
            // btnEditarArticuloGasto
            // 
            btnEditarArticuloGasto.BackColor = Color.DimGray;
            btnEditarArticuloGasto.FlatAppearance.BorderColor = Color.White;
            btnEditarArticuloGasto.FlatAppearance.BorderSize = 5;
            btnEditarArticuloGasto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarArticuloGasto.ForeColor = Color.White;
            btnEditarArticuloGasto.Location = new Point(4, 303);
            btnEditarArticuloGasto.Name = "btnEditarArticuloGasto";
            btnEditarArticuloGasto.Size = new Size(244, 55);
            btnEditarArticuloGasto.TabIndex = 37;
            btnEditarArticuloGasto.Text = "Editar";
            btnEditarArticuloGasto.UseVisualStyleBackColor = false;
            // 
            // btnGuardarArticuloGasto
            // 
            btnGuardarArticuloGasto.BackColor = Color.DimGray;
            btnGuardarArticuloGasto.FlatAppearance.BorderColor = Color.Magenta;
            btnGuardarArticuloGasto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarArticuloGasto.ForeColor = Color.White;
            btnGuardarArticuloGasto.Location = new Point(4, 199);
            btnGuardarArticuloGasto.Name = "btnGuardarArticuloGasto";
            btnGuardarArticuloGasto.Size = new Size(244, 55);
            btnGuardarArticuloGasto.TabIndex = 36;
            btnGuardarArticuloGasto.Text = "Guardar";
            btnGuardarArticuloGasto.UseVisualStyleBackColor = false;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(4, 104);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(244, 27);
            txtArticulo.TabIndex = 25;
            // 
            // lblArticulo
            // 
            lblArticulo.AutoSize = true;
            lblArticulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblArticulo.ForeColor = Color.White;
            lblArticulo.Location = new Point(87, 47);
            lblArticulo.Name = "lblArticulo";
            lblArticulo.Size = new Size(83, 28);
            lblArticulo.TabIndex = 24;
            lblArticulo.Text = "Artículo";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(265, 542);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.BackColor = Color.DimGray;
            btnEliminarCategoria.FlatAppearance.BorderColor = Color.White;
            btnEliminarCategoria.FlatAppearance.BorderSize = 5;
            btnEliminarCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarCategoria.ForeColor = Color.White;
            btnEliminarCategoria.Location = new Point(20, 406);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(244, 55);
            btnEliminarCategoria.TabIndex = 46;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.BackColor = Color.DimGray;
            btnEditarCategoria.FlatAppearance.BorderColor = Color.White;
            btnEditarCategoria.FlatAppearance.BorderSize = 5;
            btnEditarCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarCategoria.ForeColor = Color.White;
            btnEditarCategoria.Location = new Point(20, 304);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(244, 55);
            btnEditarCategoria.TabIndex = 45;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.BackColor = Color.DimGray;
            btnGuardarCategoria.FlatAppearance.BorderColor = Color.Magenta;
            btnGuardarCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCategoria.ForeColor = Color.White;
            btnGuardarCategoria.Location = new Point(20, 200);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(244, 55);
            btnGuardarCategoria.TabIndex = 44;
            btnGuardarCategoria.Text = "Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = false;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(20, 105);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(244, 27);
            txtCategoria.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 48);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 42;
            label2.Text = "Categorías";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Gray;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(566, 155);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(265, 542);
            dataGridView2.TabIndex = 41;
            // 
            // btnEliminarEstatus
            // 
            btnEliminarEstatus.BackColor = Color.DimGray;
            btnEliminarEstatus.FlatAppearance.BorderColor = Color.White;
            btnEliminarEstatus.FlatAppearance.BorderSize = 5;
            btnEliminarEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarEstatus.ForeColor = Color.White;
            btnEliminarEstatus.Location = new Point(16, 406);
            btnEliminarEstatus.Name = "btnEliminarEstatus";
            btnEliminarEstatus.Size = new Size(244, 55);
            btnEliminarEstatus.TabIndex = 52;
            btnEliminarEstatus.Text = "Eliminar";
            btnEliminarEstatus.UseVisualStyleBackColor = false;
            // 
            // btnEditarEstatus
            // 
            btnEditarEstatus.BackColor = Color.DimGray;
            btnEditarEstatus.FlatAppearance.BorderColor = Color.White;
            btnEditarEstatus.FlatAppearance.BorderSize = 5;
            btnEditarEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarEstatus.ForeColor = Color.White;
            btnEditarEstatus.Location = new Point(16, 304);
            btnEditarEstatus.Name = "btnEditarEstatus";
            btnEditarEstatus.Size = new Size(244, 55);
            btnEditarEstatus.TabIndex = 51;
            btnEditarEstatus.Text = "Editar";
            btnEditarEstatus.UseVisualStyleBackColor = false;
            // 
            // btnGuardarEstatus
            // 
            btnGuardarEstatus.BackColor = Color.DimGray;
            btnGuardarEstatus.FlatAppearance.BorderColor = Color.Magenta;
            btnGuardarEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarEstatus.ForeColor = Color.White;
            btnGuardarEstatus.Location = new Point(16, 200);
            btnGuardarEstatus.Name = "btnGuardarEstatus";
            btnGuardarEstatus.Size = new Size(244, 55);
            btnGuardarEstatus.TabIndex = 50;
            btnGuardarEstatus.Text = "Guardar";
            btnGuardarEstatus.UseVisualStyleBackColor = false;
            // 
            // txtEstatus
            // 
            txtEstatus.Location = new Point(16, 105);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(244, 27);
            txtEstatus.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(112, 48);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 48;
            label3.Text = "Estatus";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Gray;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(1132, 155);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(265, 542);
            dataGridView3.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminarArticuloGasto);
            panel2.Controls.Add(btnEditarArticuloGasto);
            panel2.Controls.Add(btnGuardarArticuloGasto);
            panel2.Controls.Add(txtArticulo);
            panel2.Controls.Add(lblArticulo);
            panel2.Location = new Point(293, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 543);
            panel2.TabIndex = 53;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEliminarCategoria);
            panel3.Controls.Add(btnEditarCategoria);
            panel3.Controls.Add(btnGuardarCategoria);
            panel3.Controls.Add(txtCategoria);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(839, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 540);
            panel3.TabIndex = 54;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnEliminarEstatus);
            panel4.Controls.Add(btnEditarEstatus);
            panel4.Controls.Add(btnGuardarEstatus);
            panel4.Controls.Add(txtEstatus);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(1405, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 541);
            panel4.TabIndex = 55;
            // 
            // Setup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1700, 727);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Setup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
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
        private Label label8;
        private Label label7;
        private Button btnEliminarArticuloGasto;
        private Button btnEditarArticuloGasto;
        private Button btnGuardarArticuloGasto;
        private TextBox txtArticulo;
        private Label lblArticulo;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Button btnEliminarCategoria;
        private Button btnEditarCategoria;
        private Button btnGuardarCategoria;
        private TextBox txtCategoria;
        private Label label2;
        private DataGridView dataGridView2;
        private Button btnEliminarEstatus;
        private Button btnEditarEstatus;
        private Button btnGuardarEstatus;
        private TextBox txtEstatus;
        private Label label3;
        private DataGridView dataGridView3;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}