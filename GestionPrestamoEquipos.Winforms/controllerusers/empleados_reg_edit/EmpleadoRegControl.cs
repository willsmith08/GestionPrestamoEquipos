using GestionPrestamosEquipos.Business;
using GestionPrestamosEquipos.DTOModels;
using GestionPrestamosEquipos.Forms;
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
    public partial class EmpleadoRegControl : UserControl
    {
        EmpleadoService es = new EmpleadoService();
        CargosService cs = new CargosService();
        EmailService e_ms = new EmailService();
        public EmpleadoRegControl()
        {
            InitializeComponent();
            cargarCBCargos();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            validatioCampos();

            EmpleadosDTO empl = new EmpleadosDTO
            {
                idCargo = int.Parse(cBCargos.SelectedValue.ToString()),
                documentoEmpleado = int.Parse(txtDocumento.Text),
                e_mail = txtGmail.Text,
                nombreEmpleado = txtNombre.Text
            };

            await e_ms.EnvioCodigoValidacion(empl);
            EmpleadoService.EmpleadosDTOReg = empl;

            FormValidarCodigo fvc = new FormValidarCodigo();
            fvc.ShowDialog();

            if (FormValidarCodigo.verificacion)
            {
                es.RegistrarEmpleadoControl(empl);

                var padre = this.Parent.Parent as EmpleadosControl;
                padre?.refrescarTabla();

                limpiarCampos();
                FormValidarCodigo.verificacion = false;
            }

            
        }

        private void validatioCampos()
        {
            if (
                string.IsNullOrWhiteSpace(txtGmail.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text)
            )
            {
                MessageBox.Show("No pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cBCargos.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Seleccione un cargo para el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtDocumento.Text,out int resultado))
            {
                MessageBox.Show("El campo documento solo permite numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EmpleadosDTO emp = new EmpleadosDTO
            {
                documentoEmpleado = int.Parse(txtDocumento.Text),
            };
            if (es.ExisteEmpleado(emp))
            {
                MessageBox.Show("Ya existe un empleado registrado con este numero de documento","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(txtGmail.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Ingrese un gmail valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cargarCBCargos()
        {
            cBCargos.DataSource = cs.ListarCargosControl();
            cBCargos.ValueMember = "idCargo";
            cBCargos.DisplayMember = "nombreCargo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtGmail.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cBCargos.SelectedValue = 0;
        }
    }
}
