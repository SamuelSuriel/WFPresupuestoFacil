using LoginSistem.Forms;
using Microsoft.IdentityModel.Tokens;
using PresupuestoFacil_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPresupuestoFacil_Presentable.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WFPresupuestoFacil_Presentable
{
    public partial class Setup : Form
    {
        CN_Setup objetoCNSetup = new CN_Setup();

        private string? idArticulo = null;
        private string? idCategoria = null;
        private string? idEstatus = null;
        private bool EsEditar = false;
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            MostrarArticulos();
            MostrarCategorias();
            MostrarEstatus();
        }

        private void MostrarEstatus()
        {
            dgvEstatus.DataSource = objetoCNSetup.MostrarEstatusProc();
        }

        private void MostrarCategorias()
        {
            dgvCategorias.DataSource = objetoCNSetup.MostrarCategoriasProc();
        }



        private void btnAtrasSetup_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelPresupuesto panel = new();
            panel.ShowDialog();

        }

        #region Articulos
        private void MostrarArticulos()
        {

            dgvArticulos.DataSource = objetoCNSetup.MostrarArticulosProc();
        }

        private void btnEditarArticuloGasto_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtArticulo.Text = dgvArticulos.CurrentRow.Cells["Articulo"].Value.ToString();
                idArticulo = dgvArticulos.CurrentRow.Cells["Articulo_Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");
        }

        private void btnEliminarArticuloGasto_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedCells.Count > 0)
            {

                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar Artículo";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idArticulo = dgvArticulos.CurrentRow.Cells["Gasto_Id"].Value.ToString();
                    objetoCNSetup.EliminarArticuloPRod(idArticulo);
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarArticulos();

                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        private void btnGuardarArticuloGasto_Click(object sender, EventArgs e)
        {
            if (!txtArticulo.Text.IsNullOrEmpty())
            {

                string articulo = txtArticulo.Text;
                bool activo = true;
                bool esIngreso = false;
                int idArticulo = 0;
                if (checkEsIngreso.Checked)
                    esIngreso = true;

                if (EsEditar == false)
                {
                    try
                    {
                        objetoCNSetup.InsertarArticuloPRod(articulo, activo, esIngreso);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        txtArticulo.Clear();
                        MostrarArticulos();
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
                        objetoCNSetup.EditarArticuloProd(Convert.ToInt32(idArticulo), articulo, activo, esIngreso);
                        MessageBox.Show("Se editó correctamente!");
                        txtArticulo.Clear();
                        MostrarArticulos();
                        EsEditar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
                checkEsIngreso.Checked = false;
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos!");
            }
        }

        #endregion


    }
}
