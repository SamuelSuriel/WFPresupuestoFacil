namespace WFPresupuestoFacil_Presentable
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            btnCancelarLogin = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnCancelarLogin
            // 
            btnCancelarLogin.AutoSize = true;
            btnCancelarLogin.BackColor = Color.Transparent;
            btnCancelarLogin.Cursor = Cursors.Hand;
            btnCancelarLogin.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            btnCancelarLogin.ForeColor = Color.DimGray;
            btnCancelarLogin.Location = new Point(1155, 482);
            btnCancelarLogin.Name = "btnCancelarLogin";
            btnCancelarLogin.Size = new Size(71, 22);
            btnCancelarLogin.TabIndex = 19;
            btnCancelarLogin.Text = "VOLVER";
            btnCancelarLogin.Click += btnCancelarLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(515, 53);
            label3.Name = "label3";
            label3.Size = new Size(278, 27);
            label3.TabIndex = 17;
            label3.Text = "ABOUT PRESUPUESTO FÁCIL";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(472, 530);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(609, 141);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 11;
            label1.Text = "Versión";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.MidnightBlue;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(834, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(392, 426);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Small Semilig", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(626, 171);
            label2.Name = "label2";
            label2.Size = new Size(43, 22);
            label2.TabIndex = 22;
            label2.Text = "1.0.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Small Semilig", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(557, 251);
            label4.Name = "label4";
            label4.Size = new Size(209, 22);
            label4.TabIndex = 24;
            label4.Text = "sramirezsuriel@gmail.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(574, 222);
            label6.Name = "label6";
            label6.Size = new Size(163, 27);
            label6.TabIndex = 23;
            label6.Text = "Developer email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Variable Small Semilig", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(609, 347);
            label7.Name = "label7";
            label7.Size = new Size(96, 22);
            label7.TabIndex = 26;
            label7.Text = "Oct 2, 2023";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(596, 319);
            label8.Name = "label8";
            label8.Size = new Size(126, 27);
            label8.TabIndex = 25;
            label8.Text = "Released On";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1280, 530);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(btnCancelarLogin);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnCancelarLogin;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}