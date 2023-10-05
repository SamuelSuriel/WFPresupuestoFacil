namespace WFPresupuestoFacil_Presentable
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            btnRegistroAtras = new Label();
            chkRegistroVerContraseña = new CheckBox();
            btnRegistrarse = new Button();
            label3 = new Label();
            txtClaveUsuarioRegistro = new TextBox();
            txtUsuarioRegistro = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // btnRegistroAtras
            // 
            btnRegistroAtras.AutoSize = true;
            btnRegistroAtras.BackColor = Color.Transparent;
            btnRegistroAtras.Cursor = Cursors.Hand;
            btnRegistroAtras.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnRegistroAtras.ForeColor = Color.DimGray;
            btnRegistroAtras.Location = new Point(472, 365);
            btnRegistroAtras.Name = "btnRegistroAtras";
            btnRegistroAtras.Size = new Size(64, 24);
            btnRegistroAtras.TabIndex = 31;
            btnRegistroAtras.Text = "ATRÁS";
            btnRegistroAtras.Click += btnRegistroAtras_Click;
            // 
            // chkRegistroVerContraseña
            // 
            chkRegistroVerContraseña.AutoSize = true;
            chkRegistroVerContraseña.ForeColor = Color.MidnightBlue;
            chkRegistroVerContraseña.Location = new Point(356, 246);
            chkRegistroVerContraseña.Name = "chkRegistroVerContraseña";
            chkRegistroVerContraseña.Size = new Size(158, 24);
            chkRegistroVerContraseña.TabIndex = 30;
            chkRegistroVerContraseña.Text = "Mostrar contraseña";
            chkRegistroVerContraseña.UseVisualStyleBackColor = true;
            chkRegistroVerContraseña.CheckedChanged += chkRegistroVerContraseña_CheckedChanged;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.DeepSkyBlue;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(356, 299);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(331, 52);
            btnRegistrarse.TabIndex = 27;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Display Semib", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(449, 23);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 26;
            label3.Text = "Registro";
            // 
            // txtClaveUsuarioRegistro
            // 
            txtClaveUsuarioRegistro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtClaveUsuarioRegistro.ForeColor = Color.DimGray;
            txtClaveUsuarioRegistro.Location = new Point(356, 197);
            txtClaveUsuarioRegistro.MaxLength = 20;
            txtClaveUsuarioRegistro.Name = "txtClaveUsuarioRegistro";
            txtClaveUsuarioRegistro.PasswordChar = '*';
            txtClaveUsuarioRegistro.Size = new Size(331, 34);
            txtClaveUsuarioRegistro.TabIndex = 25;
            // 
            // txtUsuarioRegistro
            // 
            txtUsuarioRegistro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuarioRegistro.ForeColor = Color.DimGray;
            txtUsuarioRegistro.Location = new Point(356, 114);
            txtUsuarioRegistro.MaxLength = 50;
            txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            txtUsuarioRegistro.Size = new Size(331, 34);
            txtUsuarioRegistro.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(356, 166);
            label2.Name = "label2";
            label2.Size = new Size(114, 27);
            label2.TabIndex = 23;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(356, 85);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 22;
            label1.Text = "Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 424);
            panel2.TabIndex = 32;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(712, 424);
            Controls.Add(btnRegistroAtras);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(chkRegistroVerContraseña);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtClaveUsuarioRegistro);
            Controls.Add(txtUsuarioRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnRegistroAtras;
        private CheckBox chkRegistroVerContraseña;
        private Button btnRegistrarse;
        private Label label3;
        public TextBox txtClaveUsuarioRegistro;
        public TextBox txtUsuarioRegistro;
        private Label label2;
        private Label label1;
        private Panel panel2;
    }
}