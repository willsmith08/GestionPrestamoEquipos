namespace GestionPrestamosEquipos.ControllerUsers
{
    partial class DtGVHistorialControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVHistorialPres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistorialPres)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVHistorialPres
            // 
            this.dGVHistorialPres.AllowUserToAddRows = false;
            this.dGVHistorialPres.AllowUserToDeleteRows = false;
            this.dGVHistorialPres.AllowUserToResizeColumns = false;
            this.dGVHistorialPres.AllowUserToResizeRows = false;
            this.dGVHistorialPres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVHistorialPres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHistorialPres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHistorialPres.Location = new System.Drawing.Point(0, 0);
            this.dGVHistorialPres.MultiSelect = false;
            this.dGVHistorialPres.Name = "dGVHistorialPres";
            this.dGVHistorialPres.ReadOnly = true;
            this.dGVHistorialPres.RowHeadersWidth = 51;
            this.dGVHistorialPres.RowTemplate.Height = 24;
            this.dGVHistorialPres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVHistorialPres.Size = new System.Drawing.Size(635, 177);
            this.dGVHistorialPres.TabIndex = 0;
            // 
            // DtGVHistorialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVHistorialPres);
            this.Name = "DtGVHistorialControl";
            this.Size = new System.Drawing.Size(635, 177);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistorialPres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVHistorialPres;
    }
}
