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
        private void MantenedorMaquinariaProcesoFisico_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ListarVinculos();
        }
        private void CargarCombos()
        {
            cmbMaquinaria.DataSource = LogMaquinaria.Instancia.ListarMaquinariaActiva();
            cmbMaquinaria.DisplayMember = "Nombre";
            cmbMaquinaria.ValueMember = "MaquinariaID";

            cmbProcesoFisico.DataSource = LogProcesoF.Instancia.ListarProcesosActivos();
            cmbProcesoFisico.DisplayMember = "Nombre";
            cmbProcesoFisico.ValueMember = "ProcesofisicoID";
        }


        private void btnVincular_Click(object sender, EventArgs e)
        {
            if (cmbMaquinaria.SelectedItem == null || cmbProcesoFisico.SelectedItem == null)
            {
                MessageBox.Show("⚠️ Debes seleccionar maquinaria y proceso físico.");
                return;
            }

            try
            {
                int maquinariaID = (int)cmbMaquinaria.SelectedValue;
                int procesoFisicoID = (int)cmbProcesoFisico.SelectedValue;

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
            dgvVinculos.DataSource = LogMaquinariaProcesoFisico.Instancia.ListarVinculos();
        }


        private void btnEliminarVinculo_Click(object sender, EventArgs e)
        {
            if (dgvVinculos.CurrentRow == null)
            {
                MessageBox.Show("⚠️ Selecciona un vínculo para eliminar.");
                return;
            }

            try
            {
                int maquinariaID = (int)dgvVinculos.CurrentRow.Cells["MaquinariaID"].Value;
                int procesoFisicoID = (int)dgvVinculos.CurrentRow.Cells["ProcesofisicoID"].Value;

                LogMaquinariaProcesoFisico.Instancia.EliminarVinculo(maquinariaID, procesoFisicoID);
                MessageBox.Show("✔️ Vínculo eliminado.");
                ListarVinculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error al eliminar: {ex.Message}");
            }
        }
    }
}
