using LoginSistem.Clases;
using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using PresupuestoFacil_CapaNegocio;
using System.Data;
using WFPresupuestoFacil_Presentable.Clases;

namespace LoginSistem.Forms
{
    public partial class mdlEditarUsuario : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        //CN_Usuarios objetoUsuarioCN = new CN_Usuarios();
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
                    string correo = txtCorreoEdit.Text;
                    string tel = txtTelefonoEdit.Text;
                    string edad = txtEdadEdit.Text;
                    string posicion = txtPosicionEdit.Text;
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
            bool correo = txtCorreoEdit.Text != "";
            bool telefono = txtTelefonoEdit.Text != "";
            bool edad = txtEdadEdit.Text != "";
            bool posicion = txtPosicionEdit.Text != "";
            bool idPerfil = (int)cbPerfiles.SelectedValue > 0;

            if (nombre && correo && telefono && edad && posicion && idPerfil)
                return true;
            else
                return false;

        }

        private void txtEdadEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Text.RegularExpressions.Regex.IsMatch(txtEdadEdit.Text, "[ ^ 0-9]");

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
