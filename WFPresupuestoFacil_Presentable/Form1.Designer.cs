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
            txtApellidosUsuario = new TextBox();
            label2 = new Label();
            txtCorreoUsuario = new TextBox();
            label3 = new Label();
            txtTelefonoUsuario = new TextBox();
            label4 = new Label();
            txtEdadUsuario = new TextBox();
            label5 = new Label();
            txtPosicionUsuario = new TextBox();
            label6 = new Label();
            btnGuardarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnEliminarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(967, 560);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(994, 58);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(1063, 55);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(304, 27);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtApellidosUsuario
            // 
            txtApellidosUsuario.Location = new Point(1063, 88);
            txtApellidosUsuario.Name = "txtApellidosUsuario";
            txtApellidosUsuario.Size = new Size(304, 27);
            txtApellidosUsuario.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(994, 91);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // txtCorreoUsuario
            // 
            txtCorreoUsuario.Location = new Point(1063, 121);
            txtCorreoUsuario.Name = "txtCorreoUsuario";
            txtCorreoUsuario.Size = new Size(304, 27);
            txtCorreoUsuario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(994, 124);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Correo";
            // 
            // txtTelefonoUsuario
            // 
            txtTelefonoUsuario.Location = new Point(1063, 154);
            txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            txtTelefonoUsuario.Size = new Size(304, 27);
            txtTelefonoUsuario.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(994, 157);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 7;
            label4.Text = "Teléfono";
            // 
            // txtEdadUsuario
            // 
            txtEdadUsuario.Location = new Point(1063, 187);
            txtEdadUsuario.Name = "txtEdadUsuario";
            txtEdadUsuario.Size = new Size(304, 27);
            txtEdadUsuario.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(994, 190);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 9;
            label5.Text = "Edad";
            // 
            // txtPosicionUsuario
            // 
            txtPosicionUsuario.Location = new Point(1063, 220);
            txtPosicionUsuario.Name = "txtPosicionUsuario";
            txtPosicionUsuario.Size = new Size(304, 27);
            txtPosicionUsuario.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(994, 223);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 11;
            label6.Text = "Posición";
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.Location = new Point(994, 288);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(373, 55);
            btnGuardarUsuario.TabIndex = 13;
            btnGuardarUsuario.Text = "Guardar";
            btnGuardarUsuario.UseVisualStyleBackColor = true;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Location = new Point(12, 592);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(111, 45);
            btnEditarUsuario.TabIndex = 14;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(140, 592);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(111, 45);
            btnEliminarUsuario.TabIndex = 15;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 672);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnGuardarUsuario);
            Controls.Add(txtPosicionUsuario);
            Controls.Add(label6);
            Controls.Add(txtEdadUsuario);
            Controls.Add(label5);
            Controls.Add(txtTelefonoUsuario);
            Controls.Add(label4);
            Controls.Add(txtCorreoUsuario);
            Controls.Add(label3);
            Controls.Add(txtApellidosUsuario);
            Controls.Add(label2);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtNombreUsuario;
        private TextBox txtApellidosUsuario;
        private Label label2;
        private TextBox txtCorreoUsuario;
        private Label label3;
        private TextBox txtTelefonoUsuario;
        private Label label4;
        private TextBox txtEdadUsuario;
        private Label label5;
        private TextBox txtPosicionUsuario;
        private Label label6;
        private Button btnGuardarUsuario;
        private Button btnEditarUsuario;
        private Button btnEliminarUsuario;
    }
}