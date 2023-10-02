using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using PresupuestoFacil_CapaNegocio;
using System.Data;
using WFPresupuestoFacil_Presentable;
using WFPresupuestoFacil_Presentable.Clases;

namespace LoginSistem.Forms
{
    public partial class mdlEditarUsuario : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();

        public mdlEditarUsuario()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            PanelPresupuesto menuPrincipal = new PanelPresupuesto();
            menuPrincipal.lblUser.Text = Global.GlobalVarNombre;
            menuPrincipal.lblPerfil.Text = Global.GlobalVarPerfil;
            //menuPrincipal.ShowDialog();
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

            if (EsValido())
            {
                CN_Usuarios objetoUsuarioCN = new CN_Usuarios();
                string id = Global.GlobalVarId.ToString();
                string name = txtEditUsuarioNombre.Text;
                string passw = txtEditUsuarioClave.Text;
                int id_perfil = (int)cbPerfiles.SelectedValue;
                try
                {
                    objetoUsuarioCN.EditarProd(
                        name,
                        true,
                        id,
                        passw,
                        id_perfil);

                    MessageBox.Show("Se editó correctamente!");
                    Global.GlobalVarIdPerfil = (int)id_perfil;
                    Global.GlobalVarNombre = name;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo realizar la operación: " + ex);
                }

            }
            else
            {
                MessageBox.Show("no se pudo realizar la operación!");
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
