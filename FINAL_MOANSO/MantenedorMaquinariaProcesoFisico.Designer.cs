﻿namespace FINAL_MOANSO
{
    partial class MantenedorMaquinariaProcesoFisico
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
            this.cmbMaquinaria = new System.Windows.Forms.ComboBox();
            this.cmbProcesoFisico = new System.Windows.Forms.ComboBox();
            this.btnVincular = new System.Windows.Forms.Button();
            this.dgvVinculos = new System.Windows.Forms.DataGridView();
            this.btnEliminarVinculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVinculos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaquinaria
            // 
            this.cmbMaquinaria.FormattingEnabled = true;
            this.cmbMaquinaria.Location = new System.Drawing.Point(66, 100);
            this.cmbMaquinaria.Name = "cmbMaquinaria";
            this.cmbMaquinaria.Size = new System.Drawing.Size(121, 21);
            this.cmbMaquinaria.TabIndex = 0;
            // 
            // cmbProcesoFisico
            // 
            this.cmbProcesoFisico.FormattingEnabled = true;
            this.cmbProcesoFisico.Location = new System.Drawing.Point(574, 100);
            this.cmbProcesoFisico.Name = "cmbProcesoFisico";
            this.cmbProcesoFisico.Size = new System.Drawing.Size(119, 21);
            this.cmbProcesoFisico.TabIndex = 1;
            // 
            // btnVincular
            // 
            this.btnVincular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincular.Location = new System.Drawing.Point(304, 12);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(156, 65);
            this.btnVincular.TabIndex = 2;
            this.btnVincular.Text = "Vincular";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // dgvVinculos
            // 
            this.dgvVinculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVinculos.Location = new System.Drawing.Point(29, 163);
            this.dgvVinculos.Name = "dgvVinculos";
            this.dgvVinculos.Size = new System.Drawing.Size(707, 250);
            this.dgvVinculos.TabIndex = 3;
            // 
            // btnEliminarVinculo
            // 
            this.btnEliminarVinculo.Location = new System.Drawing.Point(329, 98);
            this.btnEliminarVinculo.Name = "btnEliminarVinculo";
            this.btnEliminarVinculo.Size = new System.Drawing.Size(106, 23);
            this.btnEliminarVinculo.TabIndex = 4;
            this.btnEliminarVinculo.Text = "Eliminar Vinculo";
            this.btnEliminarVinculo.UseVisualStyleBackColor = true;
            this.btnEliminarVinculo.Click += new System.EventHandler(this.btnEliminarVinculo_Click);
            // 
            // MantenedorMaquinariaProcesoFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarVinculo);
            this.Controls.Add(this.dgvVinculos);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.cmbProcesoFisico);
            this.Controls.Add(this.cmbMaquinaria);
            this.Name = "MantenedorMaquinariaProcesoFisico";
            this.Text = "MantenedorMaquinariaProcesoFisico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVinculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaquinaria;
        private System.Windows.Forms.ComboBox cmbProcesoFisico;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.DataGridView dgvVinculos;
        private System.Windows.Forms.Button btnEliminarVinculo;
    }
}