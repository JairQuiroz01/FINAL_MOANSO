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
using CapaEntidad;

namespace FINAL_MOANSO
{
    public partial class MantenedorProcesoFisico : Form
    {
        public MantenedorProcesoFisico()
        {
            InitializeComponent();
        }
        private int ObtenerIDSeleccionado()
        {
            if (dgvProcesoFisico.CurrentRow != null && dgvProcesoFisico.CurrentRow.Index >= 0)
            {
                return Convert.ToInt32(dgvProcesoFisico.CurrentRow.Cells["ProcesoFisicoID"].Value);
            }
            throw new Exception("⚠️ Debes seleccionar una fila en la tabla.");
        }
        public void ListarProcesoFisico()
        {
            var lista = LogProcesoF.Instancia.ListarProcesoFisico();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("⚠️ No hay procesos físicos registrados.");
                return;
            }
            dgvProcesoFisico.DataSource = null;
            dgvProcesoFisico.DataSource = LogProcesoF.Instancia.ListarProcesoFisico();
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cbDuracion.SelectedIndex = 0;
            chkEstado.Checked = false;
            txtProcesoFisico.Clear();
            txtMarca.Clear();
            txtEstadoMaquinaria.Clear();
            txtBuscarId.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                EntProcesoF entidad = new EntProcesoF
                {
                    ProcesofisicoID = int.Parse(txtProcesoFisico.Text),
                    Nombre = txtNombre.Text,
                    Duracion = cbDuracion.Text,
                    EstadoProcesoFisico = chkEstado.Checked
                };

                LogProcesoF.Instancia.RegistrarProcesoFisico(entidad);
                MessageBox.Show("✔️ Proceso físico registrado correctamente.");

                LimpiarCampos();
                ListarProcesoFisico();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al registrar: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del ProcesoFisico seleccionado en la tabla
                int procesoSeleccionado = ObtenerIDSeleccionado();

                // Armar la entidad con los datos actualizados del formulario
                EntProcesoF entidad = new EntProcesoF
                {
                    ProcesofisicoID = procesoSeleccionado,   // Clave para el WHERE
                    Nombre = txtNombre.Text,
                    Duracion = cbDuracion.SelectedItem?.ToString(),
                    EstadoProcesoFisico = chkEstado.Checked
                };

                // Enviar a capa lógica
                LogProcesoF.Instancia.ModificarProcesoFisico(entidad);

                MessageBox.Show("✔️ Proceso físico modificado correctamente.");

                LimpiarCampos();
                ListarProcesoFisico();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al modificar: {ex.Message}");
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIDSeleccionado();

                LogProcesoF.Instancia.InhabilitarProcesoFisico(id);
                MessageBox.Show("✔️ Proceso físico inhabilitado correctamente.");

                LimpiarCampos();
                ListarProcesoFisico();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al inhabilitar: {ex.Message}");
            }
        }

        private void cbLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                ListarProcesoFisico();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al listar: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBuscarId.Text, out int id))
                {
                    MessageBox.Show("⚠️ Debes ingresar un ID válido (número entero).");
                    return;
                }

                EntProcesoF proceso = LogProcesoF.Instancia.BuscarProcesoFisicoPorID(id);

                if (proceso != null)
                {
                    txtProcesoFisico.Text = proceso.ProcesofisicoID.ToString();
                    txtNombre.Text = proceso.Nombre;
                    cbDuracion.Text = proceso.Duracion;
                    chkEstado.Checked = proceso.EstadoProcesoFisico;
                    MessageBox.Show("✔️ Proceso físico encontrado.");
                }
                else
                {
                    MessageBox.Show("⚠️ No se encontró el proceso físico con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al buscar: {ex.Message}");
            }
        }

        private void btnListaH_Click(object sender, EventArgs e)
        {
            MantenedorMaquinaria frmHV = new MantenedorMaquinaria();

            if (frmHV.ShowDialog() == DialogResult.OK)
            {
                if (frmHV.MaquinariaSeleccionada != null)
                {
                    txtHerramienta.Text = frmHV.MaquinariaSeleccionada.Cells["MaquinariaID"].Value.ToString();
                    txtMarca.Text = frmHV.MaquinariaSeleccionada.Cells["Marca"].Value.ToString();
                    var estado = Convert.ToBoolean(frmHV.MaquinariaSeleccionada.Cells["EstadoMaquinaria"].Value)
                    ? "Disponible"
                    : "No Disponible";

                    txtEstadoMaquinaria.Text = estado;
                }
            }
        }
    }
}
