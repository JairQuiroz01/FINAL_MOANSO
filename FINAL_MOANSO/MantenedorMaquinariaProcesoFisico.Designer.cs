namespace FINAL_MOANSO
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
            this.cbmMaquinariaID = new System.Windows.Forms.ComboBox();
            this.cmbProcesoFisicoID = new System.Windows.Forms.ComboBox();
            this.btnVincular = new System.Windows.Forms.Button();
            this.dgvVinculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVinculos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmMaquinariaID
            // 
            this.cbmMaquinariaID.FormattingEnabled = true;
            this.cbmMaquinariaID.Location = new System.Drawing.Point(66, 100);
            this.cbmMaquinariaID.Name = "cbmMaquinariaID";
            this.cbmMaquinariaID.Size = new System.Drawing.Size(121, 21);
            this.cbmMaquinariaID.TabIndex = 0;
            // 
            // cmbProcesoFisicoID
            // 
            this.cmbProcesoFisicoID.FormattingEnabled = true;
            this.cmbProcesoFisicoID.Location = new System.Drawing.Point(574, 100);
            this.cmbProcesoFisicoID.Name = "cmbProcesoFisicoID";
            this.cmbProcesoFisicoID.Size = new System.Drawing.Size(119, 21);
            this.cmbProcesoFisicoID.TabIndex = 1;
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
            // 
            // dgvVinculos
            // 
            this.dgvVinculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVinculos.Location = new System.Drawing.Point(29, 163);
            this.dgvVinculos.Name = "dgvVinculos";
            this.dgvVinculos.Size = new System.Drawing.Size(707, 250);
            this.dgvVinculos.TabIndex = 3;
            // 
            // MantenedorMaquinariaProcesoFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVinculos);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.cmbProcesoFisicoID);
            this.Controls.Add(this.cbmMaquinariaID);
            this.Name = "MantenedorMaquinariaProcesoFisico";
            this.Text = "MantenedorMaquinariaProcesoFisico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVinculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmMaquinariaID;
        private System.Windows.Forms.ComboBox cmbProcesoFisicoID;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.DataGridView dgvVinculos;
    }
}