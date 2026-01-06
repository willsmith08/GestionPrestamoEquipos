using GestionPrestamosEquipos.Business;
using GestionPrestamosEquipos.ControllerUsers.empleados_reg_edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPrestamosEquipos.DTOModels;

namespace GestionPrestamosEquipos.ControllerUsers
{
    public partial class EmpleadosControl : UserControl
    {
        EmpleadosDTO empleadoSeleccionado = new EmpleadosDTO();
        EmpleadoService es = new EmpleadoService();
        public EmpleadosControl()
        {
            InitializeComponent();
            cargardGVEmpleados();
        }

        private void cargarPaneel_edit_regis(UserControl uc)
        {
            panel_regegistro_edit_empleados.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel_regegistro_edit_empleados.Controls.Add(uc);
        }

        private void btn_reg_edit_empleado_Click(object sender, EventArgs e)
        {
            if (btn_reg_edit_empleado.Text == "Editar empleados")
            {
                btn_reg_edit_empleado.Text = "Nuevo empleado ➕";
                cargarPaneel_edit_regis(new EmpleadoEditControl(empleadoSeleccionado));
            }
            else
            {
                btn_reg_edit_empleado.Text = "Editar empleados";
                cargarPaneel_edit_regis(new EmpleadoRegControl());
            }
        }

        private void cargardGVEmpleados()
        {
            dGVEmpleados.DataSource = es.ListarEmpleadosControl(txtBuscar.Text);

            dGVEmpleados.RowHeadersWidth = 30;
            dGVEmpleados.Columns["idEmpleado"].Visible = false;
            dGVEmpleados.Columns["idCargo"].Visible = false;

            dGVEmpleados.Columns["nombreEmpleado"].HeaderText = "EMPLEADO";
            dGVEmpleados.Columns["documentoEmpleado"].HeaderText = "DOCUMENTO";
            dGVEmpleados.Columns["nombreCargo"].HeaderText = "CARGO";
            dGVEmpleados.Columns["e_mail"].HeaderText = "GMAIL";
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = string.Empty;
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargardGVEmpleados();
        }

        private void dGVEmpleados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EmpleadosDTO empleado = new EmpleadosDTO
                {
                    idEmpleado = int.Parse(dGVEmpleados.Rows[e.RowIndex].Cells["idEmpleado"].Value.ToString()),
                    nombreEmpleado = dGVEmpleados.Rows[e.RowIndex].Cells["nombreEmpleado"].Value.ToString()
                };
                empleadoSeleccionado = empleado;

                if (btn_reg_edit_empleado.Text == "Nuevo empleado ➕")
                {
                    // Evita la excepción de llamada reentrante
                    this.BeginInvoke(new Action(() =>
                    {
                        EmpleadoEditControl controlEdit = new EmpleadoEditControl(empleado);
                        cargarPaneel_edit_regis(controlEdit);
                    }));
                }
            }
            else { empleadoSeleccionado = null; }
        }

        public void refrescarTabla()
        {
            cargardGVEmpleados();
        }
    }
}
