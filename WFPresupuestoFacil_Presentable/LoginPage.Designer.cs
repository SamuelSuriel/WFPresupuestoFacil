namespace WFPresupuestoFacil_Presentable
{
    partial class LoginPage
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
            txtUsuarioLogin = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtContraseñaLogin = new TextBox();
            label2 = new Label();
            btnEntrarLogin = new Button();
            label3 = new Label();
            label4 = new Label();
            btnCancelarLogin = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(408, 206);
            label1.Name = "label1";
            label1.Size = new Size(83, 27);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(532, 207);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(242, 27);
            txtUsuarioLogin.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(402, 450);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // txtContraseñaLogin
            // 
            txtContraseñaLogin.Location = new Point(532, 256);
            txtContraseñaLogin.Name = "txtContraseñaLogin";
            txtContraseñaLogin.PasswordChar = '*';
            txtContraseñaLogin.Size = new Size(242, 27);
            txtContraseñaLogin.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(408, 255);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.BackColor = Color.DeepSkyBlue;
            btnEntrarLogin.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrarLogin.ForeColor = Color.Transparent;
            btnEntrarLogin.Location = new Point(408, 316);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(366, 55);
            btnEntrarLogin.TabIndex = 6;
            btnEntrarLogin.Text = "ENTRAR";
            btnEntrarLogin.UseVisualStyleBackColor = false;
            btnEntrarLogin.Click += btnEntrarLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(532, 100);
            label3.Name = "label3";
            label3.Size = new Size(163, 27);
            label3.TabIndex = 7;
            label3.Text = "INICIAR SESIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(763, 9);
            label4.Name = "label4";
            label4.Size = new Size(25, 28);
            label4.TabIndex = 8;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // btnCancelarLogin
            // 
            btnCancelarLogin.AutoSize = true;
            btnCancelarLogin.BackColor = Color.Transparent;
            btnCancelarLogin.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarLogin.ForeColor = Color.White;
            btnCancelarLogin.Location = new Point(532, 388);
            btnCancelarLogin.Name = "btnCancelarLogin";
            btnCancelarLogin.Size = new Size(118, 27);
            btnCancelarLogin.TabIndex = 9;
            btnCancelarLogin.Text = "CANCELAR";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEntrarLogin);
            Controls.Add(txtContraseñaLogin);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtUsuarioLogin;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtContraseñaLogin;
        private Label label2;
        private Button btnEntrarLogin;
        private Label label3;
        private Label label4;
        private Label btnCancelarLogin;
    }
}