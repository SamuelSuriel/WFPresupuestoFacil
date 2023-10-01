namespace LoginSistem.Forms
{
    partial class mdlEditarUsuario
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
            components = new System.ComponentModel.Container();
            btAtras = new Button();
            label3 = new Label();
            txtEditUsuarioClave = new TextBox();
            txtEditUsuarioNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnActualizar = new Button();
            label4 = new Label();
            cbPerfiles = new ComboBox();
            perfilesBindingSource = new BindingSource(components);
            chkVerContraseña = new CheckBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)perfilesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btAtras
            // 
            btAtras.BackColor = Color.DimGray;
            btAtras.Cursor = Cursors.Hand;
            btAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAtras.ForeColor = Color.White;
            btAtras.Location = new Point(437, 501);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(195, 52);
            btAtras.TabIndex = 12;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = false;
            btAtras.Click += btAtras_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display Semib", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(538, 23);
            label3.Name = "label3";
            label3.Size = new Size(244, 37);
            label3.TabIndex = 11;
            label3.Text = "Actualizar usuario";
            // 
            // txtEditUsuarioClave
            // 
            txtEditUsuarioClave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEditUsuarioClave.ForeColor = Color.DimGray;
            txtEditUsuarioClave.Location = new Point(437, 199);
            txtEditUsuarioClave.MaxLength = 20;
            txtEditUsuarioClave.Name = "txtEditUsuarioClave";
            txtEditUsuarioClave.Size = new Size(206, 34);
            txtEditUsuarioClave.TabIndex = 10;
            // 
            // txtEditUsuarioNombre
            // 
            txtEditUsuarioNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEditUsuarioNombre.ForeColor = Color.DimGray;
            txtEditUsuarioNombre.Location = new Point(437, 118);
            txtEditUsuarioNombre.MaxLength = 50;
            txtEditUsuarioNombre.Name = "txtEditUsuarioNombre";
            txtEditUsuarioNombre.Size = new Size(206, 34);
            txtEditUsuarioNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(437, 174);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(437, 93);
            label1.Name = "label1";
            label1.Size = new Size(69, 22);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DimGray;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(701, 501);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(192, 52);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(437, 292);
            label4.Name = "label4";
            label4.Size = new Size(57, 27);
            label4.TabIndex = 14;
            label4.Text = "Perfil";
            // 
            // cbPerfiles
            // 
            cbPerfiles.ForeColor = Color.DimGray;
            cbPerfiles.FormattingEnabled = true;
            cbPerfiles.Location = new Point(437, 326);
            cbPerfiles.Name = "cbPerfiles";
            cbPerfiles.Size = new Size(206, 28);
            cbPerfiles.TabIndex = 18;
            // 
            // chkVerContraseña
            // 
            chkVerContraseña.AutoSize = true;
            chkVerContraseña.ForeColor = Color.DimGray;
            chkVerContraseña.Location = new Point(437, 245);
            chkVerContraseña.Name = "chkVerContraseña";
            chkVerContraseña.Size = new Size(155, 24);
            chkVerContraseña.TabIndex = 19;
            chkVerContraseña.Text = "Ocultar contraseña";
            chkVerContraseña.UseVisualStyleBackColor = true;
            chkVerContraseña.CheckedChanged += chkVerContraseña_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 635);
            panel1.TabIndex = 20;
            // 
            // mdlEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 635);
            Controls.Add(panel1);
            Controls.Add(chkVerContraseña);
            Controls.Add(cbPerfiles);
            Controls.Add(label4);
            Controls.Add(btnActualizar);
            Controls.Add(btAtras);
            Controls.Add(label3);
            Controls.Add(txtEditUsuarioClave);
            Controls.Add(txtEditUsuarioNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mdlEditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            Load += mdlEditarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)perfilesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAtras;
        private Label label3;
        public TextBox txtEditUsuarioClave;
        public TextBox txtEditUsuarioNombre;
        private Label label2;
        private Label label1;
        private Button btnActualizar;
        public ComboBox cbPerfiles;
        private BindingSource perfilesBindingSource;
        private CheckBox chkVerContraseña;
        public Label label4;
        private Panel panel1;
    }
}