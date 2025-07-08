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
    public partial class MantenedorUnidadMedida : Form
    {
        public MantenedorUnidadMedida()
        {
            InitializeComponent();
            listarUnidad();
            txtID.Enabled = false;
        }
        private void listarUnidad()
        {
            dgvUnidad.DataSource = logUnidadMedida.Instancia.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingresa un nombre.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAbreviatura.Text))
                {
                    MessageBox.Show("Por favor, ingresa una abreviatura.");
                    return;
                }

                entUnidadMedida u = new entUnidadMedida
                {
                    Nombre = txtNombre.Text.Trim(),
                    Abreviatura = txtAbreviatura.Text.Trim()
                };

                logUnidadMedida.Instancia.Insertar(u);
                MessageBox.Show("¡Unidad agregada correctamente!");
                listarUnidad();
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
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Selecciona una unidad para modificar.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingresa un nombre.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAbreviatura.Text))
                {
                    MessageBox.Show("Por favor, ingresa una abreviatura.");
                    return;
                }

                entUnidadMedida u = new entUnidadMedida
                {
                    UnidadmedidaID = int.Parse(txtID.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Abreviatura = txtAbreviatura.Text.Trim()
                };

                logUnidadMedida.Instancia.Editar(u);
                MessageBox.Show("¡Unidad modificada correctamente!");
                listarUnidad();
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
                    MessageBox.Show("Selecciona una unidad para eliminar.");
                    return;
                }

                int id = int.Parse(txtID.Text);
                logUnidadMedida.Instancia.Eliminar(id);
                MessageBox.Show("¡Unidad eliminada correctamente!");
                listarUnidad();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dgvUnidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUnidad.Rows[e.RowIndex];
                txtID.Text = fila.Cells["UnidadmedidaID"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtAbreviatura.Text = fila.Cells["Abreviatura"].Value.ToString();
            }
        }
        private void limpiarCampos()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtAbreviatura.Text = "";
        }
    }
}
