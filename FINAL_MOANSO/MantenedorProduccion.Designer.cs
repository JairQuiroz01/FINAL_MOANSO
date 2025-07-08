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
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(30, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(100, 20);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // lblProceso
            // 
            this.lblProceso.Location = new System.Drawing.Point(30, 60);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(100, 20);
            this.lblProceso.TabIndex = 2;
            this.lblProceso.Text = "Proceso Físico:";
            // 
            // lblMaquinaria
            // 
            this.lblMaquinaria.Location = new System.Drawing.Point(30, 100);
            this.lblMaquinaria.Name = "lblMaquinaria";
            this.lblMaquinaria.Size = new System.Drawing.Size(100, 20);
            this.lblMaquinaria.TabIndex = 4;
            this.lblMaquinaria.Text = "Maquinaria:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(30, 140);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(120, 20);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad a Producir:";
            // 
            // lblInicio
            // 
            this.lblInicio.Location = new System.Drawing.Point(30, 180);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(100, 20);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "Fecha Inicio:";
            // 
            // lblFin
            // 
            this.lblFin.Location = new System.Drawing.Point(30, 220);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(100, 20);
            this.lblFin.TabIndex = 10;
            this.lblFin.Text = "Fecha Fin:";
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(30, 260);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(100, 20);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Location = new System.Drawing.Point(30, 300);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(100, 20);
            this.lblObservaciones.TabIndex = 14;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // cboProducto
            // 
            this.cboProducto.Location = new System.Drawing.Point(160, 20);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(250, 21);
            this.cboProducto.TabIndex = 1;
            // 
            // cboProcesoFisico
            // 
            this.cboProcesoFisico.Location = new System.Drawing.Point(160, 60);
            this.cboProcesoFisico.Name = "cboProcesoFisico";
            this.cboProcesoFisico.Size = new System.Drawing.Size(250, 21);
            this.cboProcesoFisico.TabIndex = 3;
            // 
            // cboMaquinaria
            // 
            this.cboMaquinaria.Location = new System.Drawing.Point(160, 100);
            this.cboMaquinaria.Name = "cboMaquinaria";
            this.cboMaquinaria.Size = new System.Drawing.Size(250, 21);
            this.cboMaquinaria.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(160, 140);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(160, 180);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 9;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(160, 220);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 11;
            // 
            // cboEstado
            // 
            this.cboEstado.Location = new System.Drawing.Point(160, 260);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(200, 21);
            this.cboEstado.TabIndex = 13;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(160, 300);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(300, 60);
            this.txtObservaciones.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(160, 370);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(160, 30);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar Producción";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvProduccion
            // 
            this.dgvProduccion.AllowUserToAddRows = false;
            this.dgvProduccion.Location = new System.Drawing.Point(30, 420);
            this.dgvProduccion.Name = "dgvProduccion";
            this.dgvProduccion.ReadOnly = true;
            this.dgvProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduccion.Size = new System.Drawing.Size(740, 200);
            this.dgvProduccion.TabIndex = 17;
            // 
            // MantenedorProduccion
            // 
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
            this.Name = "MantenedorProduccion";
            this.Text = "Registro de Producción";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
