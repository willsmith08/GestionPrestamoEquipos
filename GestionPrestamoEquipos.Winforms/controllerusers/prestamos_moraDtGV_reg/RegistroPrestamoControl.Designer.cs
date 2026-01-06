namespace GestionPrestamosEquipos.ControllerUsers
{
    partial class RegistroPrestamoControl
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBEquipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBTipoEquipos = new System.Windows.Forms.ComboBox();
            this.mFechaEstimadaDev = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dHoraEstimadaDev = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblErrorTipoE = new System.Windows.Forms.Label();
            this.lblErrorEquipo = new System.Windows.Forms.Label();
            this.lblErrorDoc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "REGISTRO DE PRESTAMOS";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Documento empleado:*";
            // 
            // txtDocEmpleado
            // 
            this.txtDocEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocEmpleado.Location = new System.Drawing.Point(48, 357);
            this.txtDocEmpleado.MaxLength = 10;
            this.txtDocEmpleado.Name = "txtDocEmpleado";
            this.txtDocEmpleado.Size = new System.Drawing.Size(241, 30);
            this.txtDocEmpleado.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Equipos:*";
            // 
            // cBEquipos
            // 
            this.cBEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBEquipos.Enabled = false;
            this.cBEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBEquipos.FormattingEnabled = true;
            this.cBEquipos.Location = new System.Drawing.Point(48, 267);
            this.cBEquipos.Name = "cBEquipos";
            this.cBEquipos.Size = new System.Drawing.Size(241, 33);
            this.cBEquipos.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de equipos:*";
            // 
            // cBTipoEquipos
            // 
            this.cBTipoEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTipoEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTipoEquipos.FormattingEnabled = true;
            this.cBTipoEquipos.Location = new System.Drawing.Point(48, 181);
            this.cBTipoEquipos.Name = "cBTipoEquipos";
            this.cBTipoEquipos.Size = new System.Drawing.Size(241, 33);
            this.cBTipoEquipos.TabIndex = 18;
            this.cBTipoEquipos.SelectedIndexChanged += new System.EventHandler(this.cBTipoEquipos_SelectedIndexChanged);
            // 
            // mFechaEstimadaDev
            // 
            this.mFechaEstimadaDev.Location = new System.Drawing.Point(343, 181);
            this.mFechaEstimadaDev.Name = "mFechaEstimadaDev";
            this.mFechaEstimadaDev.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha estimada de devolucion:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Hora estimada devolucion:*";
            // 
            // dHoraEstimadaDev
            // 
            this.dHoraEstimadaDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dHoraEstimadaDev.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dHoraEstimadaDev.Location = new System.Drawing.Point(343, 444);
            this.dHoraEstimadaDev.Name = "dHoraEstimadaDev";
            this.dHoraEstimadaDev.ShowUpDown = true;
            this.dHoraEstimadaDev.Size = new System.Drawing.Size(269, 27);
            this.dHoraEstimadaDev.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Observaciones:*";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(48, 454);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(238, 155);
            this.txtObservaciones.TabIndex = 31;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Green;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(385, 499);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(164, 43);
            this.btnRegistrar.TabIndex = 33;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(385, 566);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 43);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(506, 106);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(106, 34);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblErrorTipoE
            // 
            this.lblErrorTipoE.AutoSize = true;
            this.lblErrorTipoE.BackColor = System.Drawing.Color.Red;
            this.lblErrorTipoE.Location = new System.Drawing.Point(48, 217);
            this.lblErrorTipoE.Name = "lblErrorTipoE";
            this.lblErrorTipoE.Size = new System.Drawing.Size(0, 16);
            this.lblErrorTipoE.TabIndex = 36;
            // 
            // lblErrorEquipo
            // 
            this.lblErrorEquipo.AutoSize = true;
            this.lblErrorEquipo.BackColor = System.Drawing.Color.Red;
            this.lblErrorEquipo.Location = new System.Drawing.Point(48, 303);
            this.lblErrorEquipo.Name = "lblErrorEquipo";
            this.lblErrorEquipo.Size = new System.Drawing.Size(0, 16);
            this.lblErrorEquipo.TabIndex = 37;
            // 
            // lblErrorDoc
            // 
            this.lblErrorDoc.AutoSize = true;
            this.lblErrorDoc.BackColor = System.Drawing.Color.Red;
            this.lblErrorDoc.Location = new System.Drawing.Point(48, 390);
            this.lblErrorDoc.Name = "lblErrorDoc";
            this.lblErrorDoc.Size = new System.Drawing.Size(0, 16);
            this.lblErrorDoc.TabIndex = 38;
            // 
            // RegistroPrestamoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblErrorDoc);
            this.Controls.Add(this.lblErrorEquipo);
            this.Controls.Add(this.lblErrorTipoE);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dHoraEstimadaDev);
            this.Controls.Add(this.mFechaEstimadaDev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDocEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBEquipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBTipoEquipos);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroPrestamoControl";
            this.Size = new System.Drawing.Size(666, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBEquipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBTipoEquipos;
        private System.Windows.Forms.MonthCalendar mFechaEstimadaDev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dHoraEstimadaDev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblErrorTipoE;
        private System.Windows.Forms.Label lblErrorEquipo;
        private System.Windows.Forms.Label lblErrorDoc;
    }
}
