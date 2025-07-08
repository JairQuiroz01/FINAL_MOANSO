using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace FINAL_MOANSO
{
    public partial class MantenedorMaquinaria : Form
    {
        public MantenedorMaquinaria()
        {
            InitializeComponent();
        }
        public DataGridViewRow MaquinariaSeleccionada { get; set; }
        private int ObtenerIDSeleccionado()
        {
            if (dgvMaquinaria.CurrentRow != null && dgvMaquinaria.CurrentRow.Index >= 0)
            {
                return Convert.ToInt32(dgvMaquinaria.CurrentRow.Cells["MaquinariaID"].Value);
            }
            throw new Exception("⚠️ Debes seleccionar una fila en la tabla.");
        }
        private void LimpiarCampos()
        {
            txtNombre_H.Clear();
            txtMarca_H.Clear();
            chkEstado.Checked = false;
        }
        private void Listar()
        {
            dgvMaquinaria.DataSource = null;
            dgvMaquinaria.DataSource = LogMaquinaria.Instancia.ListarMaquinaria();
        }

        private void btnRegistrarHV_Click(object sender, EventArgs e)
        {
            try
            {
                EntMaquinaria entidad = new EntMaquinaria
                {
                    Nombre = txtNombre_H.Text,
                    Marca = txtMarca_H.Text,
                    EstadoMaquinaria = chkEstado.Checked
                };

                LogMaquinaria.Instancia.RegistrarMaquinaria(entidad);
                MessageBox.Show("✔️ Maquinaria registrada correctamente.");

                LimpiarCampos();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al registrar: {ex.Message}");
            }
        }

        private void btnModificarHV_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIDSeleccionado();

                EntMaquinaria entidad = new EntMaquinaria
                {
                    MaquinariaID = id,
                    Nombre = txtNombre_H.Text,
                    Marca = txtMarca_H.Text,
                    EstadoMaquinaria = chkEstado.Checked
                };

                LogMaquinaria.Instancia.ModificarMaquinaria(entidad);
                MessageBox.Show("✔️ Maquinaria modificada correctamente.");

                LimpiarCampos();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al modificar: {ex.Message}");
            }
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMaquinaria.DataSource = null; // Limpiamos antes de mostrar resultado

                if (!int.TryParse(txtBuscaPorId.Text, out int id))
                {
                    MessageBox.Show("⚠️ Debes ingresar un ID válido (número entero).");
                    return;
                }

                var herramienta = LogMaquinaria.Instancia.BuscarMaquinariaPorID(id);

                if (herramienta != null)
                {
                    // Mostrar en campos
                    txtNombre_H.Text = herramienta.Nombre;
                    txtMarca_H.Text = herramienta.Marca;
                    chkEstado.Checked = herramienta.EstadoMaquinaria;

                    // Mostrar en tabla
                    dgvMaquinaria.DataSource = new List<EntMaquinaria> { herramienta };

                    MessageBox.Show("✔️ Maquinaria encontrada.");
                }
                else
                {
                    MessageBox.Show("❌ ID no registrado.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al buscar: {ex.Message}");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al listar: {ex.Message}");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvMaquinaria.CurrentRow != null && dgvMaquinaria.CurrentRow.Index >= 0)
            {
                MaquinariaSeleccionada = dgvMaquinaria.CurrentRow;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("⚠️ Por favor selecciona una Maquinaria de la tabla.");
            }
        }

        private void dgvMaquinaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Asegura que no se haga doble clic en el header
                {
                    DataGridViewRow fila = dgvMaquinaria.Rows[e.RowIndex];

                    txtNombre_H.Text = fila.Cells["Nombre"].Value.ToString();
                    txtMarca_H.Text = fila.Cells["Marca"].Value.ToString();
                    chkEstado.Checked = Convert.ToBoolean(fila.Cells["EstadoMaquinaria"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al obtener datos: {ex.Message}");
            }
        }
    }
}
