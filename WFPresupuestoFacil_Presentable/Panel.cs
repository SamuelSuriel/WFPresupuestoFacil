using LoginSistem.Clases;
using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using PresupuestoFacil_CapaNegocio;
using System.Data;
using System.Windows.Forms;
using WFPresupuestoFacil_Presentable;

namespace LoginSistem.Forms
{
    public partial class PanelPresupuesto : Form
    {
        CN_Gastos objetoGastosCN = new CN_Gastos();
        CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();

        private string? idGasto = null;
        private bool EsEditar = false;
        public PanelPresupuesto()
        {
            InitializeComponent();
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Limpiamos los datos en las variables globales
            Global.GlobalVarId = 0;
            Global.GlobalVarNombre = "";
            Global.GlobalVarClave = "";
            Global.GlobalVarIdPerfil = 0;
            Global.GlobalVarEdad = 0;
            Global.GlobalVarPerfil = "";
            Global.GlobalVarCorreo = "";
            Global.GlobalVarTelefono = "";
            Global.GlobalVarPosicion = "";

            //volvemos al formulario de login
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void PanelPresupuesto_Load(object sender, EventArgs e)
        {
            string date = DateTime.UtcNow.ToString("D");
            lblFecha.Text = date;

            MostrarGastos();

            LlenarComboBox(cbEstatusGasto, "Select * From Estatus where Activo = 1", "Estatus_Id", "Estatus");
            LlenarComboBox(cbArticuloGasto, "Select * From Articulos where Activo = 1", "Articulo_Id", "Articulo");
            LlenarComboBox(cbCategoriaGastos, "Select * From Categorias where Activo = 1", "Categoria_Id", "Categoria");
            //cbEstatusGasto.Text = Global.GlobalVarPerfil;
        }

        private void picModifyUser_Click(object sender, EventArgs e)
        {
            mdlEditarUsuario mdlEditarUsuario = new mdlEditarUsuario();
            mdlEditarUsuario.txtEditUsuarioNombre.Text = Global.GlobalVarNombre;
            mdlEditarUsuario.txtEditUsuarioClave.Text = Global.GlobalVarClave;
            mdlEditarUsuario.txtCorreoEdit.Text = Global.GlobalVarCorreo;
            mdlEditarUsuario.txtEdadEdit.Text = Global.GlobalVarEdad.ToString();
            mdlEditarUsuario.txtTelefonoEdit.Text = Global.GlobalVarTelefono;
            mdlEditarUsuario.txtPosicionEdit.Text = Global.GlobalVarPosicion;
            mdlEditarUsuario.ShowDialog();

        }
        public void LlenarComboBox(ComboBox combo, string strSql, string id, string desc)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion.Conexion);
            da.Fill(tabla);
            combo.ValueMember = id;
            combo.DisplayMember = desc;
            combo.DataSource = tabla;
        }

        private void picSetup_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void MostrarGastos()
        {
            dgvGastos.DataSource = objetoGastosCN.MostrarProd();
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            //System.Text.RegularExpressions.Regex.IsMatch(txtImporte.Text, "[ ^ 0-9]");

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardarGasto_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                string importe = txtImporte.Text;
                int estatus = (int)cbEstatusGasto.SelectedValue;
                int categoria = (int)cbCategoriaGastos.SelectedValue;
                int articulo = (int)cbArticuloGasto.SelectedValue;

                if (EsEditar == false)
                {
                    try
                    {

                        objetoGastosCN.InsertarPRod(Convert.ToInt32(importe), estatus, categoria, articulo, true);

                        MessageBox.Show("Se insertó correctamente!");
                        LimpiarCampos();
                        MostrarGastos();
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
                        objetoGastosCN.EditarProd(Convert.ToInt32(idGasto), Convert.ToInt32(importe), estatus, categoria, true, articulo);

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarCampos();
                        MostrarGastos();
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

        private bool EsValido()
        {
            bool articulo = cbArticuloGasto.Text != "";
            bool categoria = cbCategoriaGastos.Text != "";
            bool estatus = cbEstatusGasto.Text != "";
            bool importe = txtImporte.Text != "";

            if (articulo && categoria && estatus && importe)
                return true;
            else
                return false;

        }
        private void LimpiarCampos()
        {
            cbArticuloGasto.Text = "";
            cbCategoriaGastos.Text = "";
            cbEstatusGasto.Text = "";
            txtImporte.Clear();
        }

        private void btnEditarGasto_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtImporte.Text = dgvGastos.CurrentRow.Cells["Importe"].Value.ToString();
                cbArticuloGasto.Text = dgvGastos.CurrentRow.Cells["Articulo"].Value.ToString();
                cbCategoriaGastos.Text = dgvGastos.CurrentRow.Cells["Categoria"].Value.ToString();
                cbEstatusGasto.Text = dgvGastos.CurrentRow.Cells["Estatus"].Value.ToString();
                idGasto = dgvGastos.CurrentRow.Cells["Gasto_Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");
        }
    }
}
