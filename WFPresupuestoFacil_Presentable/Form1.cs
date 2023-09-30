using LoginSistem.Forms;
using PresupuestoFacil_CapaNegocio;

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
                        objetoUsuarioCN.InsertarPRod(
                            txtNombreUsuario.Text,
                            txtApellidosUsuario.Text,
                            txtCorreoUsuario.Text,
                            txtTelefonoUsuario.Text,
                            txtEdadUsuario.Text,
                            txtPosicionUsuario.Text,
                            true);

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
                            txtApellidosUsuario.Text,
                            txtCorreoUsuario.Text,
                            txtTelefonoUsuario.Text,
                            txtEdadUsuario.Text,
                            txtPosicionUsuario.Text,
                            true,
                            idUsuario,
                            txtClaveEdit.Text,
                            (int)cbPerfiles.SelectedValue);

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
            txtApellidosUsuario.Clear();
            txtCorreoUsuario.Clear();
            txtTelefonoUsuario.Clear();
            txtEdadUsuario.Clear();
            txtPosicionUsuario.Clear();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtNombreUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario_Nombre"].Value.ToString();
                txtApellidosUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario_Apellidos"].Value.ToString();
                txtCorreoUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario_Correo"].Value.ToString();
                txtTelefonoUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario_Telefono"].Value.ToString();
                txtEdadUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario_Edad"].Value.ToString();
                txtPosicionUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario_Posicion"].Value.ToString();
                idUsuario = dataGridView1.CurrentRow.Cells["Usuario_Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");

        }

        private bool EsValido()
        {
            bool nombre = txtNombreUsuario.Text != "";
            bool apellidos = txtApellidosUsuario.Text != "";
            bool correo = txtCorreoUsuario.Text != "";
            bool telefono = txtTelefonoUsuario.Text != "";
            bool edad = txtEdadUsuario.Text != "";
            bool posicion = txtPosicionUsuario.Text != "";

            if (nombre && apellidos && correo && telefono && edad && posicion)
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
    }
}