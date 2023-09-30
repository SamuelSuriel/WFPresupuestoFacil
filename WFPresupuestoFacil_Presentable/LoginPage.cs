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

        private void btlCancelarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            var esValido = false;
            var usuarioValido = txtUsuarioLogin.Text;
            var passwordValido = txtContraseñaLogin.Text;

            //validamos si ingresaron datos correctos
            if (!usuarioValido.IsNullOrEmpty() && !passwordValido.IsNullOrEmpty())
            {

                try
                {
                    conexion.AbrirConexion();
                    SqlCommand comando = new SqlCommand(conexion.query(passwordValido), conexion.Conexion);
                    SqlDataReader registro = comando.ExecuteReader();

                    if (registro.Read())
                    {
                        Usuarios usuario = new Usuarios();
                        usuario.Usuario_Id = (int)registro["Usuario_Id"];
                        usuario.Usuario_Nombre = (string)registro["Usuario_Nombre"];
                        usuario.Clave = (string)registro["Clave"];
                        usuario.IdPerfil = (int)registro["IdPerfil"];
                        usuario.Perfil = (string)registro["Perfil"];
                        //usuario.Usuario_Edad = (int)registro["Usuario_Edad"];
                        //usuario.Usuario_Correo = (string)registro["Usuario_Correo"];
                        //usuario.Usuario_Telefono = (string)registro["Usuario_Telefono"];
                        //usuario.Usuario_Posicion = (string)registro["Usuario_Posicion"];

                        if (usuarioValido == usuario.Usuario_Nombre && passwordValido == usuario.Clave)
                            esValido = true;

                        if (esValido)
                        {
                            MessageBox.Show("Usuario y contraseña son correctos!");
                            this.Hide();
                            PanelPresupuesto menuPrincipal = new PanelPresupuesto();

                            //Almacenamos los datos en las variables globales
                            Global global = new Global();
                            Global.GlobalVarId = usuario.Usuario_Id;
                            Global.GlobalVarNombre = usuario.Usuario_Nombre;
                            Global.GlobalVarClave = usuario.Clave;
                            Global.GlobalVarIdPerfil = (int)usuario.IdPerfil;
                            Global.GlobalVarPerfil = usuario.Perfil;
                            Global.GlobalVarCorreo = usuario.Usuario_Correo;
                            //int num = (int)usuario.Usuario_Edad;
                            //string? edadString = num.ToString();
                            //Global.GlobalVarEdad = edadString;
                            //Global.GlobalVarTelefono = usuario.Usuario_Telefono;
                            //Global.GlobalVarPosicion = usuario.Usuario_Posicion;

                            //Llenamos el textbox del modal Menú principal
                            menuPrincipal.lblUser.Text = Global.GlobalVarNombre;
                            menuPrincipal.lblPerfil.Text = Global.GlobalVarPerfil;
                            menuPrincipal.Show();

                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña no son correctos!");
                        }

                    }
                    conexion.CerrarConexion();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ups, ocurrio un error inesperado! Error:" + ex);
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
    }
}
