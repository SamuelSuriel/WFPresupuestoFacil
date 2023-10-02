namespace WFPresupuestoFacil_Presentable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtNombreUsuario = new TextBox();
            btnGuardarUsuario = new Button();
            panel1 = new Panel();
            btnAtrasCRUD = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtClaveAdmin = new TextBox();
            label10 = new Label();
            label11 = new Label();
            cbPerfilesAdmin = new ComboBox();
            btnEditarUsuario = new Label();
            btnEliminarUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.MidnightBlue;
            dataGridView1.Location = new Point(12, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(698, 514);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(728, 190);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.White;
            txtNombreUsuario.ForeColor = Color.DimGray;
            txtNombreUsuario.Location = new Point(814, 190);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(280, 27);
            txtNombreUsuario.TabIndex = 2;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.BackColor = Color.DeepSkyBlue;
            btnGuardarUsuario.Cursor = Cursors.Hand;
            btnGuardarUsuario.FlatAppearance.BorderColor = Color.Magenta;
            btnGuardarUsuario.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarUsuario.ForeColor = Color.White;
            btnGuardarUsuario.Location = new Point(814, 422);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(280, 55);
            btnGuardarUsuario.TabIndex = 13;
            btnGuardarUsuario.Text = "Guardar";
            btnGuardarUsuario.UseVisualStyleBackColor = false;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnAtrasCRUD);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 72);
            panel1.TabIndex = 16;
            // 
            // btnAtrasCRUD
            // 
            btnAtrasCRUD.AutoSize = true;
            btnAtrasCRUD.BackColor = Color.Transparent;
            btnAtrasCRUD.Cursor = Cursors.Hand;
            btnAtrasCRUD.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtrasCRUD.ForeColor = Color.White;
            btnAtrasCRUD.Location = new Point(12, 19);
            btnAtrasCRUD.Name = "btnAtrasCRUD";
            btnAtrasCRUD.Size = new Size(26, 27);
            btnAtrasCRUD.TabIndex = 2;
            btnAtrasCRUD.Text = "<";
            btnAtrasCRUD.Click += btnAtrasCRUD_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1069, 18);
            label8.Name = "label8";
            label8.Size = new Size(25, 28);
            label8.TabIndex = 1;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(431, 19);
            label7.Name = "label7";
            label7.Size = new Size(261, 27);
            label7.TabIndex = 0;
            label7.Text = "ADMINISTRAR USUARIOS ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(244, 107);
            label9.Name = "label9";
            label9.Size = new Size(188, 28);
            label9.TabIndex = 17;
            label9.Text = "Listado de usuarios";
            // 
            // txtClaveAdmin
            // 
            txtClaveAdmin.BackColor = Color.White;
            txtClaveAdmin.ForeColor = Color.DimGray;
            txtClaveAdmin.Location = new Point(814, 268);
            txtClaveAdmin.Name = "txtClaveAdmin";
            txtClaveAdmin.Size = new Size(280, 27);
            txtClaveAdmin.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(728, 268);
            label10.Name = "label10";
            label10.Size = new Size(60, 28);
            label10.TabIndex = 18;
            label10.Text = "Clave";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(728, 347);
            label11.Name = "label11";
            label11.Size = new Size(58, 28);
            label11.TabIndex = 20;
            label11.Text = "Perfil";
            // 
            // cbPerfilesAdmin
            // 
            cbPerfilesAdmin.BackColor = Color.White;
            cbPerfilesAdmin.ForeColor = Color.DimGray;
            cbPerfilesAdmin.FormattingEnabled = true;
            cbPerfilesAdmin.Location = new Point(814, 347);
            cbPerfilesAdmin.Name = "cbPerfilesAdmin";
            cbPerfilesAdmin.Size = new Size(280, 28);
            cbPerfilesAdmin.TabIndex = 22;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.AutoSize = true;
            btnEditarUsuario.Cursor = Cursors.Hand;
            btnEditarUsuario.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEditarUsuario.ForeColor = Color.White;
            btnEditarUsuario.Location = new Point(814, 498);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(77, 27);
            btnEditarUsuario.TabIndex = 23;
            btnEditarUsuario.Text = "EDITAR";
            btnEditarUsuario.Click += btnEditarUsuario_Click_1;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.AutoSize = true;
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarUsuario.ForeColor = Color.White;
            btnEliminarUsuario.Location = new Point(992, 498);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(102, 27);
            btnEliminarUsuario.TabIndex = 24;
            btnEliminarUsuario.Text = "ELIMINAR";
            btnEliminarUsuario.Click += btnEliminarUsuario_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1108, 682);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(cbPerfilesAdmin);
            Controls.Add(label11);
            Controls.Add(txtClaveAdmin);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(btnGuardarUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtNombreUsuario;
        private Button btnGuardarUsuario;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtClaveAdmin;
        private Label label10;
        private Label label11;
        private ComboBox cbPerfilesAdmin;
        private Label btnAtrasCRUD;
        private Label btnEliminarArticuloGasto;
        private Label btnEditarArticuloGasto;
        private Label label2;
        private Label btnEditarUsuario;
        private Label label3;
        private Label btnEliminarUsuario;
    }
}