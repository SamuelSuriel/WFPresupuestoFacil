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
            btnCancelarLogin = new Button();
            label1 = new Label();
            txtUsuarioLogin = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtContraseñaLogin = new TextBox();
            label2 = new Label();
            btnEntrarLogin = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancelarLogin
            // 
            btnCancelarLogin.Location = new Point(448, 370);
            btnCancelarLogin.Name = "btnCancelarLogin";
            btnCancelarLogin.Size = new Size(134, 46);
            btnCancelarLogin.TabIndex = 0;
            btnCancelarLogin.Text = "CANCELAR";
            btnCancelarLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 258);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(522, 251);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(242, 27);
            txtUsuarioLogin.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(402, 450);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // txtContraseñaLogin
            // 
            txtContraseñaLogin.Location = new Point(522, 300);
            txtContraseñaLogin.Name = "txtContraseñaLogin";
            txtContraseñaLogin.Size = new Size(242, 27);
            txtContraseñaLogin.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 307);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.Location = new Point(630, 370);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(134, 46);
            btnEntrarLogin.TabIndex = 6;
            btnEntrarLogin.Text = "ENTRAR";
            btnEntrarLogin.UseVisualStyleBackColor = true;
            btnEntrarLogin.Click += btnEntrarLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 147);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 7;
            label3.Text = "INICIAR SESIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(770, 9);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 8;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEntrarLogin);
            Controls.Add(txtContraseñaLogin);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(label1);
            Controls.Add(btnCancelarLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarLogin;
        private Label label1;
        private TextBox txtUsuarioLogin;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtContraseñaLogin;
        private Label label2;
        private Button btnEntrarLogin;
        private Label label3;
        private Label label4;
    }
}