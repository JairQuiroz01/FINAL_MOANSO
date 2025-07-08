namespace FINAL_MOANSO
{
    partial class MantenedorMaquinaria
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
            this.gbHV = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre_H = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtMarca_H = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnRegistrarHV = new System.Windows.Forms.Button();
            this.btnModificarHV = new System.Windows.Forms.Button();
            this.btnInhabilitarHV = new System.Windows.Forms.Button();
            this.dgvHerramienta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaPorId = new System.Windows.Forms.TextBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.gbHV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramienta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHV
            // 
            this.gbHV.Controls.Add(this.btnAceptar);
            this.gbHV.Controls.Add(this.lblNombre);
            this.gbHV.Controls.Add(this.txtNombre_H);
            this.gbHV.Controls.Add(this.lblDescripcion);
            this.gbHV.Controls.Add(this.txtMarca_H);
            this.gbHV.Controls.Add(this.chkEstado);
            this.gbHV.Controls.Add(this.btnRegistrarHV);
            this.gbHV.Controls.Add(this.btnModificarHV);
            this.gbHV.Controls.Add(this.btnInhabilitarHV);
            this.gbHV.Location = new System.Drawing.Point(12, 281);
            this.gbHV.Name = "gbHV";
            this.gbHV.Size = new System.Drawing.Size(656, 143);
            this.gbHV.TabIndex = 7;
            this.gbHV.TabStop = false;
            this.gbHV.Text = "Datos de Maquinaria";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(540, 90);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 44);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(20, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre_H
            // 
            this.txtNombre_H.Location = new System.Drawing.Point(90, 30);
            this.txtNombre_H.Name = "txtNombre_H";
            this.txtNombre_H.Size = new System.Drawing.Size(200, 20);
            this.txtNombre_H.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(20, 60);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(60, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Marca:";
            // 
            // txtMarca_H
            // 
            this.txtMarca_H.Location = new System.Drawing.Point(90, 60);
            this.txtMarca_H.Name = "txtMarca_H";
            this.txtMarca_H.Size = new System.Drawing.Size(200, 20);
            this.txtMarca_H.TabIndex = 3;
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(90, 90);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(70, 20);
            this.chkEstado.TabIndex = 4;
            this.chkEstado.Text = "Activo";
            // 
            // btnRegistrarHV
            // 
            this.btnRegistrarHV.Location = new System.Drawing.Point(320, 25);
            this.btnRegistrarHV.Name = "btnRegistrarHV";
            this.btnRegistrarHV.Size = new System.Drawing.Size(100, 35);
            this.btnRegistrarHV.TabIndex = 5;
            this.btnRegistrarHV.Text = "Registrar";
            // 
            // btnModificarHV
            // 
            this.btnModificarHV.Location = new System.Drawing.Point(430, 25);
            this.btnModificarHV.Name = "btnModificarHV";
            this.btnModificarHV.Size = new System.Drawing.Size(100, 35);
            this.btnModificarHV.TabIndex = 6;
            this.btnModificarHV.Text = "Modificar";
            // 
            // btnInhabilitarHV
            // 
            this.btnInhabilitarHV.Location = new System.Drawing.Point(320, 66);
            this.btnInhabilitarHV.Name = "btnInhabilitarHV";
            this.btnInhabilitarHV.Size = new System.Drawing.Size(100, 35);
            this.btnInhabilitarHV.TabIndex = 7;
            this.btnInhabilitarHV.Text = "Inhabilitar";
            // 
            // dgvHerramienta
            // 
            this.dgvHerramienta.AllowUserToAddRows = false;
            this.dgvHerramienta.AllowUserToDeleteRows = false;
            this.dgvHerramienta.Location = new System.Drawing.Point(12, 42);
            this.dgvHerramienta.Name = "dgvHerramienta";
            this.dgvHerramienta.ReadOnly = true;
            this.dgvHerramienta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHerramienta.Size = new System.Drawing.Size(645, 220);
            this.dgvHerramienta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por ID:";
            // 
            // txtBuscaPorId
            // 
            this.txtBuscaPorId.Location = new System.Drawing.Point(116, 6);
            this.txtBuscaPorId.Name = "txtBuscaPorId";
            this.txtBuscaPorId.Size = new System.Drawing.Size(120, 20);
            this.txtBuscaPorId.TabIndex = 12;
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(251, 1);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(80, 25);
            this.btnBuscarPorId.TabIndex = 13;
            this.btnBuscarPorId.Text = "Buscar";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(663, 42);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(87, 40);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar";
            // 
            // MantenedorMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.txtBuscaPorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHerramienta);
            this.Controls.Add(this.gbHV);
            this.Name = "MantenedorMaquinaria";
            this.Text = "Maquinaria";
            this.gbHV.ResumeLayout(false);
            this.gbHV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramienta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHV;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre_H;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtMarca_H;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnRegistrarHV;
        private System.Windows.Forms.Button btnModificarHV;
        private System.Windows.Forms.Button btnInhabilitarHV;
        private System.Windows.Forms.DataGridView dgvHerramienta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaPorId;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Button btnListar;
    }
}