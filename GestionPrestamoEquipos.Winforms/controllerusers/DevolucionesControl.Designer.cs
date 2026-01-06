namespace GestionPrestamosEquipos.ControllerUsers
{
    partial class DevolucionesControl
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblErrorDoc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocEmp = new System.Windows.Forms.TextBox();
            this.dGVEquiposPrestados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEquiposPrestados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(281, 251);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 40);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblErrorDoc
            // 
            this.lblErrorDoc.AutoSize = true;
            this.lblErrorDoc.Location = new System.Drawing.Point(58, 348);
            this.lblErrorDoc.Name = "lblErrorDoc";
            this.lblErrorDoc.Size = new System.Drawing.Size(0, 16);
            this.lblErrorDoc.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Devolver equipo(s)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Documento del empleado";
            // 
            // txtDocEmp
            // 
            this.txtDocEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocEmp.Location = new System.Drawing.Point(26, 255);
            this.txtDocEmp.MaxLength = 10;
            this.txtDocEmp.Name = "txtDocEmp";
            this.txtDocEmp.Size = new System.Drawing.Size(243, 30);
            this.txtDocEmp.TabIndex = 9;
            // 
            // dGVEquiposPrestados
            // 
            this.dGVEquiposPrestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVEquiposPrestados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVEquiposPrestados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVEquiposPrestados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVEquiposPrestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEquiposPrestados.Location = new System.Drawing.Point(26, 367);
            this.dGVEquiposPrestados.Name = "dGVEquiposPrestados";
            this.dGVEquiposPrestados.RowHeadersWidth = 51;
            this.dGVEquiposPrestados.RowTemplate.Height = 24;
            this.dGVEquiposPrestados.Size = new System.Drawing.Size(618, 194);
            this.dGVEquiposPrestados.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 82);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "DEVOLUCION DE EQUIPOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista de equipos prestados:";
            // 
            // DevolucionesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblErrorDoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocEmp);
            this.Controls.Add(this.dGVEquiposPrestados);
            this.Name = "DevolucionesControl";
            this.Size = new System.Drawing.Size(666, 644);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEquiposPrestados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblErrorDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocEmp;
        private System.Windows.Forms.DataGridView dGVEquiposPrestados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
