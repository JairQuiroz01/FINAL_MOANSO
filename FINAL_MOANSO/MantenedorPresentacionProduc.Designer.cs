using System.Windows.Forms;

namespace FINAL_MOANSO
{
    partial class MantenedorPresentacionProduc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.dgvPresentacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentacion)).BeginInit();
            this.SuspendLayout();

            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(110, 20);
            this.txtNombre.Size = new System.Drawing.Size(200, 20);

            // lblDescripcion
            this.lblDescripcion.Location = new System.Drawing.Point(20, 60);
            this.lblDescripcion.Size = new System.Drawing.Size(80, 20);
            this.lblDescripcion.Text = "Descripción:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(110, 60);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Size = new System.Drawing.Size(300, 60);

            // btnSeleccionarImagen
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(450, 20);
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(130, 30);
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";

            // picImagen
            this.picImagen.Location = new System.Drawing.Point(600, 20);
            this.picImagen.Size = new System.Drawing.Size(150, 100);
            this.picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            this.picImagen.BorderStyle = BorderStyle.FixedSingle;

            // btnRegistrar
            this.btnRegistrar.Location = new System.Drawing.Point(90, 140);
            this.btnRegistrar.Size = new System.Drawing.Size(90, 30);
            this.btnRegistrar.Text = "Registrar";

            // btnModificar
            this.btnModificar.Location = new System.Drawing.Point(200, 140);
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.Text = "Modificar";

            // btnInhabilitar
            this.btnInhabilitar.Location = new System.Drawing.Point(310, 140);
            this.btnInhabilitar.Size = new System.Drawing.Size(90, 30);
            this.btnInhabilitar.Text = "Inhabilitar";

            // dgvPresentacion
            this.dgvPresentacion.Location = new System.Drawing.Point(20, 190);
            this.dgvPresentacion.Size = new System.Drawing.Size(730, 200);
            this.dgvPresentacion.ReadOnly = true;
            this.dgvPresentacion.AllowUserToAddRows = false;
            this.dgvPresentacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Form
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.dgvPresentacion);
            this.Text = "Mantenedor Presentación de Producto";

            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.DataGridView dgvPresentacion;

    }
}