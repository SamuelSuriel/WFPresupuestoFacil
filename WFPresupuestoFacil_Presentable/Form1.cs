using LoginSistem.Forms;
using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using PresupuestoFacil_CapaNegocio;
using System.Data;
using System.Windows.Forms;
using WFPresupuestoFacil_Presentable.Clases;

namespace WFPresupuestoFacil_Presentable
{
    public partial class Form1 : Form
    {
        CN_Usuarios objetoUsuarioCN = new CN_Usuarios();
        private string? idUsuario = null;
        private bool EsEditar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            LlenarComboBox(cbPerfilesAdmin, "Select * From Perfiles", "IdPerfil", "Perfil");

        }

        private void MostrarUsuarios()
        {
            CN_Usuarios objetoUsuario = new CN_Usuarios();
            dataGridView1.DataSource = objetoUsuario.MostrarProd();
            this.dataGridView1.Columns["Usuario_Id"].Visible = false;
            this.dataGridView1.Columns["Usuario_Apellidos"].Visible = false;
            this.dataGridView1.Columns["Usuario_Correo"].Visible = false;
            this.dataGridView1.Columns["Usuario_Telefono"].Visible = false;
            this.dataGridView1.Columns["Usuario_Edad"].Visible = false;
            this.dataGridView1.Columns["Usuario_Posicion"].Visible = false;
            this.dataGridView1.Columns["Activo"].Visible = false;
            this.dataGridView1.Columns["Usuario_Nombre"].Visible = false;
            this.dataGridView1.Columns["FechaCreacion"].Visible = false;
            this.dataGridView1.Columns["FechaModificacion"].Visible = false;
            this.dataGridView1.Columns["Clave"].Visible = false;
            this.dataGridView1.Columns["IdPerfil"].Visible = false;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!EsValido())
            {
                MessageBox.Show("Debe completar todos los datos!");
                return;
            }

            try
            {
                int idPerfil = (int)cbPerfilesAdmin.SelectedValue;

                if (EsEditar)
                {
                    objetoUsuarioCN.EditarProd(
                        txtNombreUsuario.Text,
                        true,
                        idUsuario,
                        txtClaveAdmin.Text,
                        idPerfil);

                    MessageBox.Show("Se editó correctamente!");
                }
                else
                {
                    objetoUsuarioCN.InsertarPRod(
                        txtNombreUsuario.Text,
                        txtClaveAdmin.Text,
                        true,
                        idPerfil);

                    MessageBox.Show("Se insertó correctamente!");
                }

                LimpiarCamposUsuario();
                MostrarUsuarios();
                EsEditar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
               
        private void LimpiarCamposUsuario()
        {

            txtNombreUsuario.Clear();
            txtClaveAdmin.Clear();
            cbPerfilesAdmin.SelectedValue = 0;
        }

        private void btnEditarUsuario_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtNombreUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario_Nombre"].Value.ToString();
                txtClaveAdmin.Text = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
                cbPerfilesAdmin.SelectedValue = dataGridView1.CurrentRow.Cells["IdPerfil"];
                idUsuario = dataGridView1.CurrentRow.Cells["Usuario_Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");
        }

        private bool EsValido()
        {
            bool nombre = txtNombreUsuario.Text != "";
            bool clave = txtClaveAdmin.Text != "";
            bool perfil = cbPerfilesAdmin.Text != "";

            if (nombre && clave && perfil)
                return true;
            else
                return false;

        }

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string user = dataGridView1.CurrentRow.Cells["Usuario_Nombre"].Value.ToString();
                string message = "¿Estás seguro de que quieres eliminar a '" + user + "' ? ";
                string title = "Eliminar usuario";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idUsuario = dataGridView1.CurrentRow.Cells["Usuario_Id"].Value.ToString();
                    objetoUsuarioCN.EliminarPRod(idUsuario);
                    MessageBox.Show("Se eliminó correctamente a '" + user + "'!");
                    MostrarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una celda para eliminar!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAtrasCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            //recargarUsuario();
            PanelPresupuesto panelPresupuesto = new PanelPresupuesto();
            panelPresupuesto.lblUser.Text = Global.GlobalVarNombre;
            panelPresupuesto.lblPerfil.Text = Global.GlobalVarPerfil;
            panelPresupuesto.Show();
        }

        private void recargarUsuario()
        {
            int id = Convert.ToInt32(idUsuario);
            try
            {
                CD_Conexion conexion = new CD_Conexion();
                conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand(conexion.queryBuscarUsuario(id), conexion.Conexion);
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Usuario_Id = (int)registro["Usuario_Id"];
                    usuario.Usuario_Nombre = (string)registro["Usuario_Nombre"];
                    usuario.Clave = (string)registro["Clave"];
                    usuario.IdPerfil = (int)registro["IdPerfil"];
                    usuario.Perfil = (string)registro["Perfil"];

                    PanelPresupuesto menuPrincipal = new PanelPresupuesto();

                    //Almacenamos los datos en las variables globales actualizado
                    Global global = new Global();
                    Global.GlobalVarId = usuario.Usuario_Id;
                    Global.GlobalVarNombre = usuario.Usuario_Nombre;
                    Global.GlobalVarClave = usuario.Clave;
                    Global.GlobalVarIdPerfil = (int)usuario.IdPerfil;
                    Global.GlobalVarPerfil = usuario.Perfil;

                    //Llenamos el textbox del modal Menú principal
                    menuPrincipal.lblUser.Text = Global.GlobalVarNombre;
                    menuPrincipal.lblPerfil.Text = Global.GlobalVarPerfil;
                    //menuPrincipal.Show();                    

                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarComboBox(ComboBox combo, string strSql, string id, string desc)
        {
            DataTable tabla = new DataTable();
            CD_Conexion conexion = new CD_Conexion();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion.Conexion);
            da.Fill(tabla);
            combo.ValueMember = id;
            combo.DisplayMember = desc;
            combo.DataSource = tabla;
        }


    }
}