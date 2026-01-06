using GestionPrestamosEquipos.Business;
using GestionPrestamosEquipos.Data;
using GestionPrestamosEquipos.DTOModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPrestamosEquipos.ControllerUsers.empleados_reg_edit
{
    public partial class EmpleadoEditControl : UserControl
    {
        EmpleadoService es = new EmpleadoService();
        CargosService cs = new CargosService();
        private EmpleadosDTO empleadoSel;
        public EmpleadoEditControl(EmpleadosDTO empleadosDTO)
        {
            InitializeComponent();
            this.empleadoSel = empleadosDTO;
            cargarCBCargoEmpleadoEdit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (empleadoSel == null)
            {
                MessageBox.Show("Seleccione el empleado que desea editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(validarEdicion() == false)
            {
                return;
            }

            if (
                MessageBox.Show($"Esta seguro que desea Editar al empleado:\n{this.empleadoSel.nombreEmpleado}",
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                )
            {

                EmpleadosDTO empleadActualizado = new EmpleadosDTO
                {
                    idEmpleado = empleadoSel.idEmpleado,
                    documentoEmpleado = string.IsNullOrWhiteSpace(txtNuevoDocumento.Text) ? 0 : int.Parse(txtNuevoDocumento.Text),
                    e_mail = txtNuevoGmail.Text,
                    idCargo = int.Parse(cBNuevoCargo.SelectedValue.ToString()),
                    nombreEmpleado = txtNuevoNombre.Text,

                };

                es.ActualizarEmpleadoControl(empleadActualizado);
                var padre = this.Parent.Parent as EmpleadosControl;
                padre?.refrescarTabla();
            }
        }

        private bool validarEdicion()
        {
            if (txtNuevoDocumento.Text.Trim() == null)
            {
                if (!int.TryParse(txtNuevoDocumento.Text, out int resultado))
                {
                    MessageBox.Show("El campo 'nuevo documento' solo permite numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                EmpleadosDTO emp = new EmpleadosDTO
                {
                    documentoEmpleado = int.Parse(txtNuevoDocumento.Text),
                };
                if (es.ExisteEmpleado(emp))
                {
                    MessageBox.Show("Ya existe un empleado registrado con este numero de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (!string.IsNullOrWhiteSpace(txtNuevoGmail.Text))
            {
                if (!Regex.IsMatch(txtNuevoGmail.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Ingrese un gmail valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (
                !string.IsNullOrWhiteSpace(txtNuevoDocumento.Text) || 
                !string.IsNullOrWhiteSpace(txtNuevoGmail.Text) || 
                !string.IsNullOrWhiteSpace(txtNuevoNombre.Text) ||
                cBNuevoCargo.SelectedValue.ToString() != "0"
            )
            {
                return true;
            }

            MessageBox.Show("Debe editar al menos un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void cargarCBCargoEmpleadoEdit()
        {
            cBNuevoCargo.DataSource = cs.ListarCargosControl();
            cBNuevoCargo.DisplayMember = "nombreCargo";
            cBNuevoCargo.ValueMember = "idCargo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cBNuevoCargo.SelectedValue = 0;
            txtNuevoDocumento.Text = string.Empty;
            txtNuevoGmail.Text = string.Empty;
            txtNuevoNombre.Text = string.Empty;
        }
    }
}
