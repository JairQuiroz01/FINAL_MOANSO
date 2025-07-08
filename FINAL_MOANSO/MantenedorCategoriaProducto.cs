using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_MOANSO
{
    public partial class MantenedorCategoriaProducto : Form
    {
        public MantenedorCategoriaProducto()
        {
            InitializeComponent();
            listarCategoria();
            txtID.Enabled = false; // Solo lectura
        }

        private void listarCategoria()
        {
            dgvCategoria.DataSource = logCategoriaProducto.Instancia.Listar();
        }

        private void True(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void limpiarCampos()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";  // RichTextBox
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingresa un nombre.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingresa una descripción.");
                    return;
                }

                // Crear objeto entidad y enviar a la lógica
                entCategoriaProducto cat = new entCategoriaProducto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                logCategoriaProducto.Instancia.Insertar(cat);
                MessageBox.Show("¡Categoría agregada correctamente!");
                listarCategoria();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de selección
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Primero selecciona una categoría para modificar.");
                    return;
                }

                // Validación de campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingresa un nombre.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingresa una descripción.");
                    return;
                }

                // Preparar entidad y actualizar
                entCategoriaProducto cat = new entCategoriaProducto
                {
                    CategoriaProductoID = int.Parse(txtID.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                logCategoriaProducto.Instancia.Editar(cat);
                MessageBox.Show("¡Categoría modificada correctamente!");
                listarCategoria();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Selecciona una categoría para eliminar.");
                    return;
                }

                int id = int.Parse(txtID.Text);
                logCategoriaProducto.Instancia.Eliminar(id);
                MessageBox.Show("¡Categoría eliminada correctamente!");
                listarCategoria();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategoria.Rows[e.RowIndex];
                txtID.Text = fila.Cells["CategoriaProductoID"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            }
        }
    }
}
