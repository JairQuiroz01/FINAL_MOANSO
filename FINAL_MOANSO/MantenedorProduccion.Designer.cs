using System.Windows.Forms;

namespace FINAL_MOANSO
{
    partial class MantenedorProduccion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblMaquinaria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblObservaciones;

        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cboProcesoFisico;
        private System.Windows.Forms.ComboBox cboMaquinaria;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvProduccion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblMaquinaria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();

            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cboProcesoFisico = new System.Windows.Forms.ComboBox();
            this.cboMaquinaria = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvProduccion = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).BeginInit();
            this.SuspendLayout();

            // Labels
            this.lblProducto.Text = "Producto:";
            this.lblProducto.Location = new System.Drawing.Point(30, 20);
            this.lblProducto.Size = new System.Drawing.Size(100, 20);

            this.lblProceso.Text = "Proceso Físico:";
            this.lblProceso.Location = new System.Drawing.Point(30, 60);
            this.lblProceso.Size = new System.Drawing.Size(100, 20);

            this.lblMaquinaria.Text = "Maquinaria:";
            this.lblMaquinaria.Location = new System.Drawing.Point(30, 100);
            this.lblMaquinaria.Size = new System.Drawing.Size(100, 20);

            this.lblCantidad.Text = "Cantidad a Producir:";
            this.lblCantidad.Location = new System.Drawing.Point(30, 140);
            this.lblCantidad.Size = new System.Drawing.Size(120, 20);

            this.lblInicio.Text = "Fecha Inicio:";
            this.lblInicio.Location = new System.Drawing.Point(30, 180);
            this.lblInicio.Size = new System.Drawing.Size(100, 20);

            this.lblFin.Text = "Fecha Fin:";
            this.lblFin.Location = new System.Drawing.Point(30, 220);
            this.lblFin.Size = new System.Drawing.Size(100, 20);

            this.lblEstado.Text = "Estado:";
            this.lblEstado.Location = new System.Drawing.Point(30, 260);
            this.lblEstado.Size = new System.Drawing.Size(100, 20);

            this.lblObservaciones.Text = "Observaciones:";
            this.lblObservaciones.Location = new System.Drawing.Point(30, 300);
            this.lblObservaciones.Size = new System.Drawing.Size(100, 20);

            // Inputs
            this.cboProducto.Location = new System.Drawing.Point(160, 20);
            this.cboProducto.Size = new System.Drawing.Size(250, 21);

            this.cboProcesoFisico.Location = new System.Drawing.Point(160, 60);
            this.cboProcesoFisico.Size = new System.Drawing.Size(250, 21);

            this.cboMaquinaria.Location = new System.Drawing.Point(160, 100);
            this.cboMaquinaria.Size = new System.Drawing.Size(250, 21);

            this.txtCantidad.Location = new System.Drawing.Point(160, 140);
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);

            this.dtpInicio.Location = new System.Drawing.Point(160, 180);
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);

            this.dtpFin.Location = new System.Drawing.Point(160, 220);
            this.dtpFin.Size = new System.Drawing.Size(200, 20);

            this.cboEstado.Location = new System.Drawing.Point(160, 260);
            this.cboEstado.Size = new System.Drawing.Size(200, 21);

            this.txtObservaciones.Location = new System.Drawing.Point(160, 300);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Size = new System.Drawing.Size(300, 60);

            this.btnRegistrar.Text = "Registrar Producción";
            this.btnRegistrar.Location = new System.Drawing.Point(160, 370);
            this.btnRegistrar.Size = new System.Drawing.Size(160, 30);

            this.dgvProduccion.Location = new System.Drawing.Point(30, 420);
            this.dgvProduccion.Size = new System.Drawing.Size(740, 200);
            this.dgvProduccion.ReadOnly = true;
            this.dgvProduccion.AllowUserToAddRows = false;
            this.dgvProduccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Form
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.cboProcesoFisico);
            this.Controls.Add(this.lblMaquinaria);
            this.Controls.Add(this.cboMaquinaria);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvProduccion);
            this.Text = "Registro de Producción";

            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
