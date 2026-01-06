namespace GestionPrestamosEquipos.ControllerUsers
{
    partial class DtGVEmpleadosMoraControl
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
            this.dGVEmpleadosMora = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmpleadosMora)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVEmpleadosMora
            // 
            this.dGVEmpleadosMora.AllowUserToAddRows = false;
            this.dGVEmpleadosMora.AllowUserToDeleteRows = false;
            this.dGVEmpleadosMora.AllowUserToResizeColumns = false;
            this.dGVEmpleadosMora.AllowUserToResizeRows = false;
            this.dGVEmpleadosMora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVEmpleadosMora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmpleadosMora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVEmpleadosMora.Location = new System.Drawing.Point(0, 0);
            this.dGVEmpleadosMora.MultiSelect = false;
            this.dGVEmpleadosMora.Name = "dGVEmpleadosMora";
            this.dGVEmpleadosMora.ReadOnly = true;
            this.dGVEmpleadosMora.RowHeadersWidth = 51;
            this.dGVEmpleadosMora.RowTemplate.Height = 24;
            this.dGVEmpleadosMora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVEmpleadosMora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEmpleadosMora.Size = new System.Drawing.Size(635, 177);
            this.dGVEmpleadosMora.TabIndex = 0;
            // 
            // DtGVEmpleadosMoraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVEmpleadosMora);
            this.Name = "DtGVEmpleadosMoraControl";
            this.Size = new System.Drawing.Size(635, 177);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmpleadosMora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVEmpleadosMora;
    }
}
