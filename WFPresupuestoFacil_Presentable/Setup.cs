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

        private void btnAtrasSetup_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelPresupuesto menuPrincipal = new PanelPresupuesto();
            menuPrincipal.lblUser.Text = Global.GlobalVarNombre;
            menuPrincipal.lblPerfil.Text = Global.GlobalVarPerfil;
            menuPrincipal.ShowDialog();

        }

        #region Articulos
        private void MostrarArticulos()
        {

            dgvArticulos.DataSource = objetoCNSetup.MostrarArticulosProc();
            this.dgvArticulos.Columns["Articulo_Id"].Visible = false;
        }

        private void btnEditarArticuloGasto_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedCells.Count > 0)
            {
                string? EsIngresostr;
                EsEditar = true;
                txtArticulo.Text = dgvArticulos.CurrentRow.Cells["Articulo"].Value.ToString();
                idArticulo = dgvArticulos.CurrentRow.Cells["Articulo_Id"].Value.ToString();
                EsIngresostr = dgvArticulos.CurrentRow.Cells["EsIngreso"].Value.ToString();

                if (EsIngresostr == "True")
                {
                    checkEsIngreso.Checked = true;
                }
                else
                {
                    checkEsIngreso.Checked = false;
                }
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
                    idArticulo = dgvArticulos.CurrentRow.Cells["Articulo_Id"].Value.ToString();
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

        #region Categorías
        private void MostrarCategorias()
        {
            dgvCategorias.DataSource = objetoCNSetup.MostrarCategoriasProc();
            this.dgvCategorias.Columns["Categoria_Id"].Visible = false;
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (!txtCategoria.Text.IsNullOrEmpty())
            {
                string categoria = txtCategoria.Text;
                bool activo = true;

                if (EsEditar == false)
                {
                    try
                    {
                        objetoCNSetup.InsertarCategoriaPRod(categoria, activo);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        txtCategoria.Clear();
                        MostrarCategorias();
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
                        objetoCNSetup.EditarCategoriaProd(Convert.ToInt32(idCategoria), categoria, activo);
                        MessageBox.Show("Se editó correctamente!");
                        txtCategoria.Clear();
                        MostrarCategorias();
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

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtCategoria.Text = dgvCategorias.CurrentRow.Cells["Categoria"].Value.ToString();
                idCategoria = dgvCategorias.CurrentRow.Cells["Categoria_Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedCells.Count > 0)
            {

                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar Categoría";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idCategoria = dgvCategorias.CurrentRow.Cells["Categoria_Id"].Value.ToString();
                    objetoCNSetup.EliminarCategoriaPRod(idCategoria);
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarCategorias();

                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        #endregion

        #region Estatus
        private void MostrarEstatus()
        {
            dgvEstatus.DataSource = objetoCNSetup.MostrarEstatusProc();
            this.dgvEstatus.Columns["Estatus_Id"].Visible = false;
        }

        private void btnGuardarEstatus_Click(object sender, EventArgs e)
        {
            if (!txtEstatus.Text.IsNullOrEmpty())
            {
                string Estatus = txtEstatus.Text;
                bool activo = true;

                if (EsEditar == false)
                {
                    try
                    {
                        objetoCNSetup.InsertarEstatusPRod(Estatus, activo);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        txtEstatus.Clear();
                        MostrarEstatus();
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
                        objetoCNSetup.EditarEstatusProd(Convert.ToInt32(idEstatus), Estatus, activo);
                        MessageBox.Show("Se editó correctamente!");
                        txtEstatus.Clear();
                        MostrarEstatus();
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

        private void btnEditarEstatus_Click(object sender, EventArgs e)
        {
            if (dgvEstatus.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtEstatus.Text = dgvEstatus.CurrentRow.Cells["Estatus"].Value.ToString();
                idEstatus = dgvEstatus.CurrentRow.Cells["Estatus_Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");
        }

        private void btnEliminarEstatus_Click(object sender, EventArgs e)
        {
            if (dgvEstatus.SelectedCells.Count > 0)
            {

                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar Estatus";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idEstatus = dgvEstatus.CurrentRow.Cells["Estatus_Id"].Value.ToString();
                    objetoCNSetup.EliminarEstatusPRod(idEstatus);
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarEstatus();

                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        #endregion


    }
}
