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
            Global.GlobalVarPerfil = "";

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

            //Control Chart
            //void FrmChartExample_Load(object sender, EventArgs e)
            //{
            //    BarExample(); //Show bar chart
            //                  //SplineChartExample();
            //}

            //Resumen
            ObtenerTotalesResumen();

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

        //public void BarExample()
        //{
        //this.chartControl.Series.Clear();

        //// Data arrays
        //string[] seriesArray = { "Cat", "Dog", "Bird", "Monkey" };
        //int[] pointsArray = { 2, 1, 7, 5 };

        //// Set palette
        //this.chartControl.Palette = ChartColorPalette.EarthTones;

        //// Set title
        //this.chartControl.Titles.Add("Animals");

        //// Add series.
        //for (int i = 0; i < seriesArray.Length; i++)
        //{
        //    Series series = this.chartControl.Series.Add(seriesArray[i]);
        //    series.Points.Add(pointsArray[i]);
        //}
        //}

        private void picModifyUser_Click(object sender, EventArgs e)
        {
            mdlEditarUsuario mdlEditarUsuario = new mdlEditarUsuario();
            mdlEditarUsuario.txtEditUsuarioNombre.Text = Global.GlobalVarNombre;
            mdlEditarUsuario.txtEditUsuarioClave.Text = Global.GlobalVarClave;
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

        private void ObtenerTotalesResumen()
        {

            {
                int Usuario_Id = Global.GlobalVarId;
                SqlCommand cmd = new SqlCommand("MostrarTotales", conexion.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", Usuario_Id);
                conexion.AbrirConexion();
                SqlDataReader dr = cmd.ExecuteReader();

                int saldo = 0;
                int ttingresos = 0;
                int ttgastos = 0;

                lblTotalGastos.Text = "";
                lblTotalIngresos.Text = "";
                lblsaldo.Text = "";
                lblsaldo.BackColor = Color.White;

                while (dr.Read())
                {
                     ttgastos = Convert.ToInt32(dr["TotalGastos"]);
                     ttingresos = Convert.ToInt32(dr["TotalIngresos"]);

                    if (ttgastos > 0 && ttingresos > 0)
                    {
                        saldo = ttingresos - ttgastos;
                    }

                    lblTotalGastos.Text = "$ " + Convert.ToString(dr["TotalGastos"].ToString());
                    lblTotalIngresos.Text = "$ " + Convert.ToString(dr["TotalIngresos"].ToString());
                    lblsaldo.Text = "$ " + Convert.ToString(saldo);

                    if (saldo < 0)
                    {
                        lblsaldo.BackColor = Color.Red;
                    }
                    else
                    {
                        lblsaldo.BackColor = Color.White;
                    }
                }
                dr.Close();
            }

        }

        private void MostrarGastos()
        {
            CN_Gastos objetoGastos = new CN_Gastos();
            int Usuario_Id = Global.GlobalVarId;
            dgvGastos.DataSource = objetoGastos.MostrarProd(Usuario_Id);
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
                int Usuario_Id = Global.GlobalVarId;

                if (EsEditar == false)
                {
                    try
                    {

                        objetoGastosCN.InsertarPRod(Convert.ToInt32(importe), estatus, categoria, activo, articulo, Usuario_Id);

                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarCampos();
                        MostrarGastos();
                        ObtenerTotalesResumen();
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
                        objetoGastosCN.EditarProd(Convert.ToInt32(idGasto), Convert.ToInt32(importe), estatus, categoria, activo, articulo, Usuario_Id);

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarCampos();
                        MostrarGastos();
                        ObtenerTotalesResumen();
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
                    int Usuario_Id = Global.GlobalVarId;

                    objetoGastosCN.EliminarPRod(idGasto, Usuario_Id);
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarGastos();
                    ObtenerTotalesResumen();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        #endregion Gastos

        #region Ingresos

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
                int Usuario_Id = Global.GlobalVarId;

                if (EsEditar == false)
                {
                    try
                    {

                        objetoIngresoCN.InsertarPRod(Convert.ToInt32(articulo), Convert.ToInt32(importe), activo, Convert.ToInt32(Usuario_Id));

                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarCamposIngresos();
                        MostrarIngresos();
                        ObtenerTotalesResumen();
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
                        objetoIngresoCN.EditarProd(Convert.ToInt32(idIngreso), Convert.ToInt32(articulo), Convert.ToInt32(importe), activo, Convert.ToInt32(Usuario_Id));

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarCamposIngresos();
                        MostrarIngresos();
                        ObtenerTotalesResumen();
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
            int Usuario_Id = Global.GlobalVarId;
            dgvIngresos.DataSource = objetoIngreso.MostrarProd(Usuario_Id);
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
                    int Usuario_Id = Global.GlobalVarId;

                    objetoIngresoCN.EliminarPRod(idIngreso, Convert.ToInt32(Usuario_Id));
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarIngresos();
                    ObtenerTotalesResumen();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }


        #endregion Ingresos

    }
}
