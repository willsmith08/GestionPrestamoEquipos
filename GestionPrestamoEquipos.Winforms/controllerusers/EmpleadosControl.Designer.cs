namespace GestionPrestamosEquipos.ControllerUsers
{
    partial class EmpleadosControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGVEmpleados = new System.Windows.Forms.DataGridView();
            this.btn_reg_edit_empleado = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel_regegistro_edit_empleados = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "GESTION DE EMPLEADOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 82);
            this.panel1.TabIndex = 1;
            // 
            // dGVEmpleados
            // 
            this.dGVEmpleados.AllowUserToAddRows = false;
            this.dGVEmpleados.AllowUserToDeleteRows = false;
            this.dGVEmpleados.AllowUserToResizeColumns = false;
            this.dGVEmpleados.AllowUserToResizeRows = false;
            this.dGVEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmpleados.Location = new System.Drawing.Point(14, 424);
            this.dGVEmpleados.MultiSelect = false;
            this.dGVEmpleados.Name = "dGVEmpleados";
            this.dGVEmpleados.ReadOnly = true;
            this.dGVEmpleados.RowHeadersWidth = 51;
            this.dGVEmpleados.RowTemplate.Height = 24;
            this.dGVEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEmpleados.Size = new System.Drawing.Size(639, 200);
            this.dGVEmpleados.TabIndex = 2;
            this.dGVEmpleados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEmpleados_RowEnter);
            // 
            // btn_reg_edit_empleado
            // 
            this.btn_reg_edit_empleado.Location = new System.Drawing.Point(469, 375);
            this.btn_reg_edit_empleado.Name = "btn_reg_edit_empleado";
            this.btn_reg_edit_empleado.Size = new System.Drawing.Size(184, 40);
            this.btn_reg_edit_empleado.TabIndex = 3;
            this.btn_reg_edit_empleado.Text = "Nuevo empleado ➕";
            this.btn_reg_edit_empleado.UseVisualStyleBackColor = true;
            this.btn_reg_edit_empleado.Click += new System.EventHandler(this.btn_reg_edit_empleado_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscar.Location = new System.Drawing.Point(14, 381);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(302, 34);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // panel_regegistro_edit_empleados
            // 
            this.panel_regegistro_edit_empleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_regegistro_edit_empleados.Location = new System.Drawing.Point(54, 107);
            this.panel_regegistro_edit_empleados.Name = "panel_regegistro_edit_empleados";
            this.panel_regegistro_edit_empleados.Size = new System.Drawing.Size(566, 242);
            this.panel_regegistro_edit_empleados.TabIndex = 6;
            // 
            // EmpleadosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel_regegistro_edit_empleados);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btn_reg_edit_empleado);
            this.Controls.Add(this.dGVEmpleados);
            this.Controls.Add(this.panel1);
            this.Name = "EmpleadosControl";
            this.Size = new System.Drawing.Size(666, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVEmpleados;
        private System.Windows.Forms.Button btn_reg_edit_empleado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel_regegistro_edit_empleados;
    }
}
