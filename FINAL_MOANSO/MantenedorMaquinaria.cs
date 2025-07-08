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

    }
}
