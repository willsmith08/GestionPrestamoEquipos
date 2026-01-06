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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPrestamosEquipos.ControllerUsers
{
    public partial class RegistroPrestamoControl : UserControl
    {
        EmpleadoService emps = new EmpleadoService();
        TiposEquiposService tes = new TiposEquiposService();
        EquiposService es = new EquiposService();
        PrestamosService ps = new PrestamosService();
        EmailService e_ms = new EmailService();

        public RegistroPrestamoControl()
        {
            InitializeComponent();
            cargarTipoEquipos();
        }

        private void cargarTipoEquipos()
        {
            cBTipoEquipos.DataSource = tes.ListarTipoEquipos();
            cBTipoEquipos.DisplayMember = "nombreTipo";
            cBTipoEquipos.ValueMember = "idTipo";
        }

        private void cargarEquipos()
        {
            EquiposDTO ed = new EquiposDTO
            {
                idTipo = int.Parse(cBTipoEquipos.SelectedValue.ToString())
            };

            var ListaEquipos = es.ListarEquiposDisponibles(ed);

            cBEquipos.DataSource = ListaEquipos;
            cBEquipos.DisplayMember = "nombreEquipo";
            cBEquipos.ValueMember = "idEquipo";

            if (ListaEquipos == null) cBEquipos.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var padre = Parent.Parent as FormMainAdmin;
            padre?.CargarControles(new PrestamosControl());
        }

        //Cuando se elija un tipo de equipo
        private void cBTipoEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBTipoEquipos.SelectedIndex != 0)
            {
                cargarEquipos();
                cBEquipos.Enabled = true;
            }
            else
            {
                cBEquipos.DataSource = null;
                cBEquipos.Enabled = false;
            }
        }

        private bool validacionCampos()
        {
            DateTime fechaPrestamo = DateTime.Today;
            TimeSpan horaPrestamo = DateTime.Now.TimeOfDay;
            var Fechaestimada = mFechaEstimadaDev.SelectionStart;
            var horaEstimada = dHoraEstimadaDev.Value.TimeOfDay;

            if (cBTipoEquipos.SelectedIndex == 0) { lblErrorTipoE.Text = "Seleccione un tipo de Equipo"; return false; }
            if (cBEquipos.SelectedIndex == 0) { lblErrorEquipo.Text = "Seleccione un Equipo"; return false; }

            if (string.IsNullOrWhiteSpace(txtDocEmpleado.Text) || string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                MessageBox.Show("No pueden haber campos vacios");
                return false;
            }

            int resultado = 0;
            if (!int.TryParse(txtDocEmpleado.Text, out resultado))
            {
                lblErrorDoc.Text = "Solo puede ingresar numeros";
                return false;
            }
            if (!emps.ExisteEmpleado(new EmpleadosDTO { documentoEmpleado = resultado }))
            {
                MessageBox.Show("No existe registro con este numero de documento");
                return false;
            }


            if (Fechaestimada < fechaPrestamo)
            {
                MessageBox.Show("La fecha seleccionada no puede ser menor a la actual");
                return false;
            }
            else
            if (Fechaestimada == fechaPrestamo)
            {
                if (horaEstimada <= horaPrestamo)
                {

                    MessageBox.Show("La hora seleccionada no puede ser menor o igual a la actual");
                    return false;
                }
            }

            return true;
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (validacionCampos())
            {
                DateTime fechaPrestamo = DateTime.Today;
                TimeSpan horaPrestamo = DateTime.Now.TimeOfDay;
                var Fechaestimada = mFechaEstimadaDev.SelectionStart;
                var horaEstimada = dHoraEstimadaDev.Value.TimeOfDay;

                PrestamosDTO pd = new PrestamosDTO
                {
                    Documento = int.Parse(txtDocEmpleado.Text),
                    idEquipo = int.Parse(cBEquipos.SelectedValue.ToString()),
                    observaciones = txtObservaciones.Text,
                    fechaPrestamo = fechaPrestamo + horaPrestamo,
                    FechaEstimadaDevolucion = Fechaestimada + horaEstimada,
                };

                EquiposService.EquipoDtoPrestamo = new EquiposDTO
                {
                    nombreEquipo = cBEquipos.SelectedText,
                };

                EmpleadoService.EmpleadosDTOPrest = new EmpleadosDTO
                {
                    documentoEmpleado = int.Parse(txtDocEmpleado.Text)
                };

                await e_ms.EnvioCodigoValidacionPrestamo();

                FormValidarCodigo fvc = new FormValidarCodigo();
                fvc.desdePrestamo = true;
                fvc.ShowDialog();

                if (FormValidarCodigo.verificacion)
                {
                    ps.RegistrarPrestamos(pd);

                    FormValidarCodigo.verificacion = false;
                    cargarCampos();
                }

                
                
            }

        }

        private void cargarCampos()
        {
            cargarTipoEquipos();
            txtDocEmpleado.Text = "";
            txtObservaciones.Text = "";

            mFechaEstimadaDev.SelectionStart = DateTime.Today;
            mFechaEstimadaDev.SelectionEnd = DateTime.Today;
            dHoraEstimadaDev.Value = DateTime.Parse(DateTime.Now.TimeOfDay.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarCampos();
        }
    }
}
