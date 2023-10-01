using LoginSistem.Forms;
using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using PresupuestoFacil_CapaNegocio;
using System.Data;
using System.Windows.Forms;

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
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                if (EsEditar == false)
                {
                    try
                    {
                        int idPerfil = (int)cbPerfilesAdmin.SelectedValue;
                        objetoUsuarioCN.InsertarPRod(
                            txtNombreUsuario.Text,
                            txtClaveAdmin.Text,
                            true,
                            idPerfil);

                        MessageBox.Show("Se insertó correctamente!");
                        LimpiarCamposUsuario();
                        MostrarUsuarios();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
                if (EsEditar == true)
                {
                    try
                    {
                        objetoUsuarioCN.EditarProd(
                            txtNombreUsuario.Text,
                            true,
                            idUsuario,
                            txtClaveAdmin.Text,
                            (int)cbPerfilesAdmin.SelectedValue);

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarCamposUsuario();
                        MostrarUsuarios();
                        EsEditar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos!");
            }

        }

        private void LimpiarCamposUsuario()
        {

            txtNombreUsuario.Clear();
            txtClaveAdmin.Clear();
            cbPerfilesAdmin.SelectedValue = 0;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtNombreUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario_Nombre"].Value.ToString();
                txtClaveAdmin.Text = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
                cbPerfilesAdmin.Text = dataGridView1.CurrentRow.Cells["IdPerfil"].Value.ToString();
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

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void btnAtrasCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelPresupuesto panelPresupuesto = new PanelPresupuesto();
            panelPresupuesto.ShowDialog();
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