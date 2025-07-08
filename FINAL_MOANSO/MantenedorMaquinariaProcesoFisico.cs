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
    public partial class MantenedorMaquinariaProcesoFisico : Form
    {
        public MantenedorMaquinariaProcesoFisico()
        {
            InitializeComponent();
        }
        private void MantenedorVincularMaquinariaProcesoFisico_Load(object sender, EventArgs e)
        {
            CargarListas();
            ListarVinculos();
        }
        private void CargarListas()
        {
            cmbMaquinariaID.DataSource = null;
            cmbMaquinariaID.DisplayMember = "Nombre";
            cmbMaquinariaID.ValueMember = "MaquinariaID";
            cmbMaquinariaID.DataSource = LogMaquinaria.Instancia.ListarMaquinaria();

            cmbProcesoFisicoID.DataSource = null;
            cmbProcesoFisicoID.DisplayMember = "Nombre";
            cmbProcesoFisicoID.ValueMember = "ProcesofisicoID";
            cmbProcesoFisicoID.DataSource = LogProcesoF.Instancia.ListarProcesosActivos();
        }


        private void btnVincular_Click(object sender, EventArgs e)
        {
            try
            {
                int maquinariaID = Convert.ToInt32(cmbMaquinariaID.SelectedValue);
                int procesoFisicoID = Convert.ToInt32(cmbProcesoFisicoID.SelectedValue);

                LogMaquinariaProcesoFisico.Instancia.Vincular(maquinariaID, procesoFisicoID);
                MessageBox.Show("✔️ Vinculado correctamente.");

                ListarVinculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al vincular: {ex.Message}");
            }
        }
        private void ListarVinculos()
        {
            dgvVinculos.DataSource = null;
            dgvVinculos.DataSource = LogMaquinariaProcesoFisico.Instancia.Listar();
        }

        private void btnEliminarVinculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVinculos.CurrentRow != null)
                {
                    int maquinariaID = Convert.ToInt32(dgvVinculos.CurrentRow.Cells["MaquinariaID"].Value);
                    int procesoFisicoID = Convert.ToInt32(dgvVinculos.CurrentRow.Cells["ProcesofisicoID"].Value);

                    LogMaquinariaProcesoFisico.Instancia.EliminarVinculo(maquinariaID, procesoFisicoID);
                    MessageBox.Show("✔️ Vínculo eliminado.");

                    ListarVinculos();
                }
                else
                {
                    MessageBox.Show("⚠️ Selecciona un vínculo en la tabla.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al eliminar: {ex.Message}");
            }
        }
        private void MantenedorMaquinariaProcesoFisico_Load(object sender, EventArgs e)
        {
            // Asumiendo que tienes cargadores para estos ComboBox
            cmbMaquinariaID.DataSource = LogMaquinaria.Instancia.ListarMaquinaria();
            cmbMaquinariaID.DisplayMember = "Nombre";
            cmbMaquinariaID.ValueMember = "MaquinariaID";

            cmbProcesoFisicoID.DataSource = LogProcesoF.Instancia.ListarProcesosActivos();
            cmbProcesoFisicoID.DisplayMember = "Nombre";
            cmbProcesoFisicoID.ValueMember = "ProcesofisicoID";

            ListarVinculos();
        }
    }
}
