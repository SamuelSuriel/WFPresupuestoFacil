﻿using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using System.Data;
using WFPresupuestoFacil_Presentable.Clases;

namespace LoginSistem.Forms
{
    public partial class mdlEditarUsuario : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        public mdlEditarUsuario()
        {
            InitializeComponent();
        }
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelPresupuesto menuPrincipal = new PanelPresupuesto();
            menuPrincipal.lblUser.Text = Global.GlobalVarNombre;
            menuPrincipal.lblPerfil.Text = Global.GlobalVarPerfil;
            menuPrincipal.ShowDialog();
        }

        private void mdlEditarUsuario_Load(object sender, EventArgs e)
        {
            txtEditUsuarioNombre.Text = Global.GlobalVarNombre;
            txtEditUsuarioClave.Text = Global.GlobalVarClave;

            if (Global.GlobalVarIdPerfil == 1)
            {
                LlenarComboBox(cbPerfiles, "Select * From Perfiles", "IdPerfil", "Perfil");
                cbPerfiles.Text = Global.GlobalVarPerfil;
            }
            else
            {
                label4.Visible = false;
                cbPerfiles.Visible = false;
            }

            txtEditUsuarioClave.MaxLength = 20;
            txtEditUsuarioNombre.MaxLength = 50;
        }

        private void chkVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtEditUsuarioClave.PasswordChar = chkVerContraseña.Checked ? '*' : '\0';

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsValido())
                {
                    string id = Global.GlobalVarId.ToString();
                    string name = txtEditUsuarioNombre.Text;
                    string passw = txtEditUsuarioClave.Text;
                    int id_perfil = (int)cbPerfiles.SelectedValue;

                    MessageBox.Show("Se editó correctamente!");
                    Global.GlobalVarIdPerfil = (int)id_perfil;
                }
                else
                {
                    MessageBox.Show("no se pudo realizar la operación!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo realizar la operación: " + ex);
            }

        }

        public void LlenarComboBox(ComboBox combo, string strSql, string id, string desc)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion.Conexion);
            da.Fill(tabla);
            combo.ValueMember = id;
            combo.DisplayMember = desc;
            combo.DataSource = tabla;
        }

        private bool EsValido()
        {

            bool nombre = txtEditUsuarioNombre.Text != "";
            bool clave = txtEditUsuarioClave.Text != "";
            bool idPerfil = (int)cbPerfiles.SelectedValue > 0;

            if (nombre && clave && idPerfil)
                return true;
            else
                return false;

        }

    }
}
