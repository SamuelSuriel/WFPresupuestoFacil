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
            btnAtras = new Label();
            ((System.ComponentModel.ISupportInitialize)perfilesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display Semib", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(490, 26);
            label3.Name = "label3";
            label3.Size = new Size(244, 37);
            label3.TabIndex = 11;
            label3.Text = "Actualizar usuario";
            // 
            // txtEditUsuarioClave
            // 
            txtEditUsuarioClave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEditUsuarioClave.ForeColor = Color.DimGray;
            txtEditUsuarioClave.Location = new Point(437, 205);
            txtEditUsuarioClave.MaxLength = 20;
            txtEditUsuarioClave.Name = "txtEditUsuarioClave";
            txtEditUsuarioClave.PasswordChar = '*';
            txtEditUsuarioClave.Size = new Size(331, 34);
            txtEditUsuarioClave.TabIndex = 10;
            // 
            // txtEditUsuarioNombre
            // 
            txtEditUsuarioNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEditUsuarioNombre.ForeColor = Color.DimGray;
            txtEditUsuarioNombre.Location = new Point(437, 118);
            txtEditUsuarioNombre.MaxLength = 50;
            txtEditUsuarioNombre.Name = "txtEditUsuarioNombre";
            txtEditUsuarioNombre.Size = new Size(331, 34);
            txtEditUsuarioNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(437, 174);
            label2.Name = "label2";
            label2.Size = new Size(114, 27);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(437, 93);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DeepSkyBlue;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(437, 443);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(331, 52);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(437, 296);
            label4.Name = "label4";
            label4.Size = new Size(58, 27);
            label4.TabIndex = 14;
            label4.Text = "Perfil";
            // 
            // cbPerfiles
            // 
            cbPerfiles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbPerfiles.ForeColor = Color.DimGray;
            cbPerfiles.FormattingEnabled = true;
            cbPerfiles.Location = new Point(437, 326);
            cbPerfiles.Name = "cbPerfiles";
            cbPerfiles.Size = new Size(331, 36);
            cbPerfiles.TabIndex = 18;
            // 
            // chkVerContraseña
            // 
            chkVerContraseña.AutoSize = true;
            chkVerContraseña.ForeColor = Color.RoyalBlue;
            chkVerContraseña.Location = new Point(437, 254);
            chkVerContraseña.Name = "chkVerContraseña";
            chkVerContraseña.Size = new Size(158, 24);
            chkVerContraseña.TabIndex = 19;
            chkVerContraseña.Text = "Mostrar contraseña";
            chkVerContraseña.UseVisualStyleBackColor = true;
            chkVerContraseña.CheckedChanged += chkVerContraseña_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 635);
            panel1.TabIndex = 20;
            // 
            // btnAtras
            // 
            btnAtras.AutoSize = true;
            btnAtras.Cursor = Cursors.Hand;
            btnAtras.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnAtras.ForeColor = Color.DimGray;
            btnAtras.Location = new Point(560, 508);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 24);
            btnAtras.TabIndex = 21;
            btnAtras.Text = "ATRÁS";
            btnAtras.Click += btnAtras_Click;
            // 
            // mdlEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 635);
            Controls.Add(btnAtras);
            Controls.Add(panel1);
            Controls.Add(chkVerContraseña);
            Controls.Add(cbPerfiles);
            Controls.Add(label4);
            Controls.Add(btnActualizar);
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
        private Label btnAtras;
    }
}