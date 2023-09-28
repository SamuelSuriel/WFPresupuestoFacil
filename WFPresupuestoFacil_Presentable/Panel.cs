using LoginSistem.Clases;
using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using PresupuestoFacil_CapaNegocio;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using WFPresupuestoFacil_Presentable;
using WFPresupuestoFacil_Presentable.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            System.Text.RegularExpressions.Regex.IsMatch(txtImporte.Text, "[ ^ 0-9]");

            if (Global.GlobalVarIdPerfil == 1) {
                    panelAdmin.Visible = true;
            } else {
                    panelAdmin.Visible = false;
            }

            //Llenar DataGridView
            MostrarGastos();

            //Llenar combo Articulos
            cbArticuloGasto.DataSource = ObtenerArticulos();
            cbArticuloGasto.DisplayMember = "Articulo";
            cbArticuloGasto.ValueMember = "Articulo_Id";

            //Llenar combo Categorias
            cbCategoriaGastos.DataSource = ObtenerCategorias();
            cbCategoriaGastos.DisplayMember = "Categoria";
            cbCategoriaGastos.ValueMember = "Categoria_Id";

            //Llenar combo Estatus
            cbEstatusGasto.DataSource = ObtenerEstatus();
            cbEstatusGasto.DisplayMember = "Estatu";
            cbEstatusGasto.ValueMember = "Estatus_Id";

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


        public List<Articulos> ObtenerArticulos()
        {
            List<Articulos> oListaArticulos = new List<Articulos>();
            {
                SqlCommand cmd = new SqlCommand("prcGetArticulos", conexion.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListaArticulos.Add(new Articulos
                    {
                        Articulo_Id = Convert.ToInt32(dr["Articulo_Id"]),
                        Articulo = Convert.ToString(dr["Articulo"].ToString())
                    });

                }
                dr.Close();
            }
            return oListaArticulos;

        }

        public List<Categorias> ObtenerCategorias()
        {
            List<Categorias> oListaCategorias = new List<Categorias>();
            {
                SqlCommand cmd = new SqlCommand("prcGetCategorias", conexion.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListaCategorias.Add(new Categorias
                    {
                        Categoria_Id = Convert.ToInt32(dr["Categoria_Id"]),
                        Categoria = Convert.ToString(dr["Categoria"].ToString())
                    });

                }
                dr.Close();
            }
            return oListaCategorias;

        }


        public List<Estatus> ObtenerEstatus()
        {
            List<Estatus> oListaCategorias = new List<Estatus>();
            {
                SqlCommand cmd = new SqlCommand("prcGetEstatus", conexion.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListaCategorias.Add(new Estatus
                    {
                        Estatus_Id = Convert.ToInt32(dr["Estatus_Id"]),
                        Estatu = Convert.ToString(dr["Estatu"].ToString())
                    });

                }
                dr.Close();
            }
            return oListaCategorias;
        }

        private void picSetup_Click(object sender, EventArgs e)
        {

            Setup setupForm = new Setup();
            setupForm.ShowDialog();
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
                bool activo = true;
                int articulo = (int)cbArticuloGasto.SelectedValue;

                if (EsEditar == false)
                {
                    try
                    {

                        objetoGastosCN.InsertarPRod(Convert.ToInt32(importe), estatus, categoria, activo, articulo);

                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
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
            cbArticuloGasto.SelectedValue = 0;
            cbCategoriaGastos.SelectedValue = 0;
            cbEstatusGasto.SelectedValue = 0;
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

        private void lblAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
