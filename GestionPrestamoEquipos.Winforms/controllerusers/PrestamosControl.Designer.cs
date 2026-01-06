namespace GestionPrestamosEquipos.ControllerUsers
{
    partial class PrestamosControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHisMora = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListarEmpMora = new System.Windows.Forms.Button();
            this.btnAvisoMasivo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panel_his_mora = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 82);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "PRESTAMO DE EQUIPOS";
            // 
            // lblHisMora
            // 
            this.lblHisMora.AutoSize = true;
            this.lblHisMora.Location = new System.Drawing.Point(14, 432);
            this.lblHisMora.Name = "lblHisMora";
            this.lblHisMora.Size = new System.Drawing.Size(145, 16);
            this.lblHisMora.TabIndex = 2;
            this.lblHisMora.Text = "Historial de prestamos:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(247, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = " Registrar prestamo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "EMPLEADOS EN MORA";
            // 
            // btnListarEmpMora
            // 
            this.btnListarEmpMora.Location = new System.Drawing.Point(31, 61);
            this.btnListarEmpMora.Name = "btnListarEmpMora";
            this.btnListarEmpMora.Size = new System.Drawing.Size(152, 33);
            this.btnListarEmpMora.TabIndex = 1;
            this.btnListarEmpMora.Text = "Listar empleados";
            this.btnListarEmpMora.UseVisualStyleBackColor = true;
            this.btnListarEmpMora.Click += new System.EventHandler(this.btnListarEmpMora_Click);
            // 
            // btnAvisoMasivo
            // 
            this.btnAvisoMasivo.Location = new System.Drawing.Point(210, 61);
            this.btnAvisoMasivo.Name = "btnAvisoMasivo";
            this.btnAvisoMasivo.Size = new System.Drawing.Size(145, 33);
            this.btnAvisoMasivo.TabIndex = 2;
            this.btnAvisoMasivo.Text = "Avisar masivamente";
            this.btnAvisoMasivo.UseVisualStyleBackColor = true;
            this.btnAvisoMasivo.Click += new System.EventHandler(this.btnAvisoMasivo_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnAvisoMasivo);
            this.panel2.Controls.Add(this.btnListarEmpMora);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(134, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 125);
            this.panel2.TabIndex = 3;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHistorial.Location = new System.Drawing.Point(481, 368);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(171, 40);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "Historial de prestamos";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Visible = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // panel_his_mora
            // 
            this.panel_his_mora.Location = new System.Drawing.Point(17, 453);
            this.panel_his_mora.Name = "panel_his_mora";
            this.panel_his_mora.Size = new System.Drawing.Size(635, 177);
            this.panel_his_mora.TabIndex = 6;
            // 
            // PrestamosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel_his_mora);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblHisMora);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "PrestamosControl";
            this.Size = new System.Drawing.Size(666, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHisMora;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListarEmpMora;
        private System.Windows.Forms.Button btnAvisoMasivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Panel panel_his_mora;
    }
}
