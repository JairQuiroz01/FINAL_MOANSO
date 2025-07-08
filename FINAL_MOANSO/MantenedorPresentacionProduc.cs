using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace FINAL_MOANSO
{
    public partial class MantenedorPresentacionProduc : Form
    {
        private string rutaImagenSeleccionada = "";

        public MantenedorPresentacionProduc()
        {
            InitializeComponent();
            CargarPresentaciones();
        }

        private void CargarPresentaciones()
        {
            dgvPresentacion.DataSource = logPresentacionProducto.Instancia.Listar();
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de imagen|*.jpg;*.png;*.jpeg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rutaImagenSeleccionada = openFile.FileName;
                picImagen.Image = Image.FromFile(rutaImagenSeleccionada);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EntPresentacionProducto obj = new EntPresentacionProducto
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };

            logPresentacionProducto.Instancia.Registrar(obj);
            MessageBox.Show("Presentación registrada con éxito");
            CargarPresentaciones();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPresentacion.SelectedRows.Count > 0)
            {
                EntPresentacionProducto obj = new EntPresentacionProducto
                {
                    PresentacionProductoID = Convert.ToInt32(dgvPresentacion.CurrentRow.Cells["PresentacionProductoID"].Value),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
                };

                logPresentacionProducto.Instancia.Modificar(obj);
                MessageBox.Show("Presentación modificada con éxito");
                CargarPresentaciones();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar");
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dgvPresentacion.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPresentacion.CurrentRow.Cells["PresentacionProductoID"].Value);
                logPresentacionProducto.Instancia.Eliminar(id);
                MessageBox.Show("Presentación eliminada");
                CargarPresentaciones();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
        }

        private void dgvPresentacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombre.Text = dgvPresentacion.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvPresentacion.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                picImagen.Image = null;
                rutaImagenSeleccionada = "";
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            picImagen.Image = null;
            rutaImagenSeleccionada = "";
        }
    }
}