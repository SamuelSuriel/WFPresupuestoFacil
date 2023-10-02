using PresupuestoFacil_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresupuestoFacil_Presentable
{
    public partial class Registro : Form
    {
        CN_Usuarios objetoUsuarioCN = new CN_Usuarios();
        private string? idUsuario = null;
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistroAtras_Click(object sender, EventArgs e)
        {
            volverAlLogin();
        }

        private void volverAlLogin()
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (!EsValido())
            {
                MessageBox.Show("Debe completar todos los datos!");
                return;
            }

            try
            {
                objetoUsuarioCN.InsertarPRod(
                                  txtUsuarioRegistro.Text,
                                  txtClaveUsuarioRegistro.Text,
                                  true,
                                  3);

                MessageBox.Show("El usuario fué registrado exitosamente!");
                LimpiarCampos();
                volverAlLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtUsuarioRegistro.Clear();
            txtClaveUsuarioRegistro.Clear();
        }

        private bool EsValido()
        {
            bool nombre = txtUsuarioRegistro.Text != "";
            bool clave = txtClaveUsuarioRegistro.Text != "";

            if (nombre && clave)
                return true;
            else
                return false;

        }

        private void chkRegistroVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtClaveUsuarioRegistro.PasswordChar = chkRegistroVerContraseña.Checked ? '*' : '\0';
        }
    }
}