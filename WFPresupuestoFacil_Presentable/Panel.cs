using LoginSistem.Clases;
using Microsoft.Data.SqlClient;
using PresupuestoFacil_CapaDatos;
using PresupuestoFacil_CapaNegocio;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using WFPresupuestoFacil_Presentable;
using WFPresupuestoFacil_Presentable.Clases;

namespace LoginSistem.Forms
{
    public partial class PanelPresupuesto : Form
    {
        CN_Gastos objetoGastosCN = new CN_Gastos();
        CN_Ingresos objetoIngresoCN = new CN_Ingresos();
        CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();

        private string? idGasto = null;
        private string? idIngreso = null;
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

            if (Global.GlobalVarIdPerfil == 1)
            {
                panelAdmin.Visible = true;
            }
            else
            {
                panelAdmin.Visible = false;
            }

            //Llenar DataGridView
            MostrarGastos();

            //Llenar combo Articulos
            cbArticuloGasto.DataSource = ObtenerArticulos("prcGetArticulos");
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


            MostrarIngresos();
            //Llenar combo Articulos Ingresos
            cbArticuloIngreso.DataSource = ObtenerArticulos("prcGetArticulosIngresos");
            cbArticuloIngreso.DisplayMember = "Articulo";
            cbArticuloIngreso.ValueMember = "Articulo_Id";
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


        public List<Articulos> ObtenerArticulos(string proc)
        {
            List<Articulos> oListaArticulos = new List<Articulos>();
            {
                SqlCommand cmd = new SqlCommand(proc, conexion.Conexion);
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
        #region Gastos

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
            CN_Gastos objetoGastos = new CN_Gastos();
            dgvGastos.DataSource = objetoGastos.MostrarProd();
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Text.RegularExpressions.Regex.IsMatch(txtImporte.Text, "[ ^ 0-9]");

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


        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedCells.Count > 0)
            {

                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idGasto = dgvGastos.CurrentRow.Cells["Gasto_Id"].Value.ToString();
                    objetoGastosCN.EliminarPRod(idGasto);
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarGastos();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        #endregion Gastos

        #region M Ingresos

        private void btnEditarIngresos_Click(object sender, EventArgs e)
        {
            if (dgvIngresos.SelectedCells.Count > 0)
            {
                EsEditar = true;
                cbArticuloIngreso.Text = dgvIngresos.CurrentRow.Cells["Articulo"].Value.ToString();
                txtImporteIngreso.Text = dgvIngresos.CurrentRow.Cells["Importe"].Value.ToString();
                idIngreso = dgvIngresos.CurrentRow.Cells["Ingreso_Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");
        }

        private void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            if (EsValidoIngresos())
            {
                int articulo = (int)cbArticuloIngreso.SelectedValue;
                string importe = txtImporteIngreso.Text;
                bool activo = true;

                if (EsEditar == false)
                {
                    try
                    {

                        objetoIngresoCN.InsertarPRod(Convert.ToInt32(articulo), Convert.ToInt32(importe), activo);

                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarCamposIngresos();
                        MostrarIngresos();
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
                        objetoIngresoCN.EditarProd(Convert.ToInt32(idIngreso), Convert.ToInt32(articulo), Convert.ToInt32(importe), activo);

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarCamposIngresos();
                        MostrarIngresos();
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

        private void MostrarIngresos()
        {
            CN_Ingresos objetoIngreso = new CN_Ingresos();
            dgvIngresos.DataSource = objetoIngreso.MostrarProd();
        }

        private bool EsValidoIngresos()
        {
            bool articulo = cbArticuloIngreso.Text != "";
            bool importe = txtImporteIngreso.Text != "";

            if (articulo && importe)
                return true;
            else
                return false;

        }
        
        private void LimpiarCamposIngresos()
        {
            cbArticuloIngreso.SelectedValue = 0;
            txtImporteIngreso.Clear();
        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
          
            if (dgvIngresos.SelectedCells.Count > 0)
            {
                
                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idIngreso = dgvIngresos.CurrentRow.Cells["Ingreso_Id"].Value.ToString();
                    objetoIngresoCN.EliminarPRod(idIngreso);
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarIngresos();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }


# endregion Ingresos

    }
}
