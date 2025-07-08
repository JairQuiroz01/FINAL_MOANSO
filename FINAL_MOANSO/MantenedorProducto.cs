using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace FINAL_MOANSO
{
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
            CargarCombos();
            ListarProductos();
        }

        private void MantenedorProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void CargarCombos()
        {

        }

        private void ListarProductos()
        {
            dgvProductos.DataSource = logProducto.Instancia.Listar();

            dgvProductos.Columns["ProductosID"].Visible = false;
            dgvProductos.Columns["CategoriaproductoID"].Visible = false;
            dgvProductos.Columns["PresentacionproductoID"].Visible = false;
            dgvProductos.Columns["UnidadmedidaID"].Visible = false;

            dgvProductos.Columns["CategoriaNombre"].HeaderText = "Categoría";
            dgvProductos.Columns["PresentacionNombre"].HeaderText = "Presentación";
            dgvProductos.Columns["UnidadNombre"].HeaderText = "Unidad de Medida";
        }

        private void Limpiar()
        {
            cbCategoria.SelectedIndex = 0;
            cbPresentacion.SelectedIndex = 0;
            cbUnidadMedida.SelectedIndex = 0;
            txtBuscar.Text = "";
            dgvProductos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entProducto p = new entProducto
            {
                CategoriaproductoID = Convert.ToInt32(cbCategoria.SelectedValue),
                PresentacionproductoID = Convert.ToInt32(cbPresentacion.SelectedValue),
                UnidadmedidaID = Convert.ToInt32(cbUnidadMedida.SelectedValue)
            };

            bool rpta = logProducto.Instancia.Insertar(p);
            if (rpta)
            {
                MessageBox.Show("Producto registrado correctamente.");
                ListarProductos();
                Limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                entProducto p = new entProducto
                {
                    ProductosID = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductosID"].Value),
                    CategoriaproductoID = Convert.ToInt32(cbCategoria.SelectedValue),
                    PresentacionproductoID = Convert.ToInt32(cbPresentacion.SelectedValue),
                    UnidadmedidaID = Convert.ToInt32(cbUnidadMedida.SelectedValue)
                };

                bool rpta = logProducto.Instancia.Editar(p);
                if (rpta)
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                    ListarProductos();
                    Limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductosID"].Value);
                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool rpta = logProducto.Instancia.Eliminar(id);
                    if (rpta)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        ListarProductos();
                        Limpiar();
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(filtro))
            {
                dgvProductos.DataSource = logProducto.Instancia.Buscar(filtro);
            }
            else
            {
                ListarProductos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbCategoria.SelectedValue = dgvProductos.Rows[e.RowIndex].Cells["CategoriaproductoID"].Value;
                cbPresentacion.SelectedValue = dgvProductos.Rows[e.RowIndex].Cells["PresentacionproductoID"].Value;
                cbUnidadMedida.SelectedValue = dgvProductos.Rows[e.RowIndex].Cells["UnidadmedidaID"].Value;
            }
        }
    }
}
