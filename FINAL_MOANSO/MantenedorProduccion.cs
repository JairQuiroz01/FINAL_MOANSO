using System;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace FINAL_MOANSO
{
    public partial class MantenedorProduccion : Form
    {
        private logProduccion logicaProduccion = new logProduccion();
        private logProducto logicaProducto = new logProducto();

        public MantenedorProduccion()
        {
            InitializeComponent();
            CargarProductos();
            CargarEstados();
            ListarProducciones();
        }

        private void CargarProductos()
        {
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "ProductosID";
            cboProducto.DataSource = logicaProducto.Listar();
        }

        private void CargarEstados()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("En Proceso");
            cboEstado.Items.Add("Finalizado");
            cboEstado.Items.Add("Observado");
            cboEstado.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                EntProduccion prod = new EntProduccion
                {
                    ProductosID = Convert.ToInt32(cboProducto.SelectedValue),
                    CantidadProducir = Convert.ToInt32(txtCantidad.Text),
                    FechaInicio = dtpInicio.Value,
                    FechaFin = dtpFin.Value,
                    Estado = cboEstado.SelectedItem.ToString(),
                    Observaciones = txtObservaciones.Text
                };

                logicaProduccion.Registrar(prod);
                MessageBox.Show("Producción registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProducciones();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarProducciones()
        {
            dgvProduccion.DataSource = logicaProduccion.Listar();
        }

        private void LimpiarCampos()
        {
            txtCantidad.Clear();
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;
            txtObservaciones.Clear();
        }
    }
}

