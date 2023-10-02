using LoginSistem.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using PresupuestoFacil_CapaDatos;
using WFPresupuestoFacil_Presentable.Clases;

namespace WFPresupuestoFacil_Presentable
{
    public partial class LoginPage : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            string usuarioValido = txtUsuarioLogin.Text;
            string passwordValido = txtContraseñaLogin.Text;

            if (!string.IsNullOrEmpty(usuarioValido) && !string.IsNullOrEmpty(passwordValido))
            {
                try
                {
                    conexion.AbrirConexion();
                    string query = conexion.query(passwordValido);

                    using (SqlCommand comando = new SqlCommand(query, conexion.Conexion))
                    {
                        using (SqlDataReader registro = comando.ExecuteReader())
                        {
                            if (registro.Read())
                            {
                                Usuarios usuario = new Usuarios
                                {
                                    Usuario_Id = (int)registro["Usuario_Id"],
                                    Usuario_Nombre = (string)registro["Usuario_Nombre"],
                                    Clave = (string)registro["Clave"],
                                    IdPerfil = (int)registro["IdPerfil"],
                                    Perfil = (string)registro["Perfil"]
                                };

                                bool esValido = (usuarioValido == usuario.Usuario_Nombre && passwordValido == usuario.Clave);

                                if (esValido)
                                {
                                    MessageBox.Show("Usuario y contraseña son correctos!");
                                    this.Hide();
                                    PanelPresupuesto menuPrincipal = new PanelPresupuesto();

                                    // Almacenar los datos en las variables globales
                                    Global.GlobalVarId = usuario.Usuario_Id;
                                    Global.GlobalVarNombre = usuario.Usuario_Nombre;
                                    Global.GlobalVarClave = usuario.Clave;
                                    Global.GlobalVarIdPerfil = (int)usuario.IdPerfil;
                                    Global.GlobalVarPerfil = usuario.Perfil;

                                    // Llenar los controles del formulario del menú principal
                                    menuPrincipal.lblUser.Text = Global.GlobalVarNombre;
                                    menuPrincipal.lblPerfil.Text = Global.GlobalVarPerfil;
                                    menuPrincipal.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña no son correctos!");
                                }
                            }
                        }
                    }

                    conexion.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado! Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos requeridos!");
            }
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.Show();
        }
    }
}
