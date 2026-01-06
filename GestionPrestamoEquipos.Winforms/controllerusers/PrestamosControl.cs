using GestionPrestamosEquipos.Business;
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
    public partial class PrestamosControl : UserControl
    {
        PrestamosService ps = new PrestamosService();
        EmailService em_s = new EmailService();
        public PrestamosControl()
        {
            InitializeComponent();
            CargarPanelDtGV_His_Mora(new DtGVHistorialControl());
        }

        private void CargarPanelDtGV_His_Mora(UserControl uc)
        {
            panel_his_mora.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel_his_mora.Controls.Add(uc);
        }

        private void btnListarEmpMora_Click(object sender, EventArgs e)
        {
            if (ps.ListarPrestamosEmpleadosMora() != null)
            {
                CargarPanelDtGV_His_Mora(new DtGVEmpleadosMoraControl());
                lblHisMora.Text = "Listado de empleados en mora:";
                btnHistorial.Visible = true;
                btnListarEmpMora.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                    "No se encontraron empleados en mora.\nTodos los préstamos están al día.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if(ps.ListarPrestamos() != null)
            {
                CargarPanelDtGV_His_Mora(new DtGVHistorialControl());
                lblHisMora.Text = "Historial de Prestamos:";
                btnHistorial.Visible = false;
                btnListarEmpMora.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "No se encontraron prestamos registrados.\nTodos los préstamos están al día.",
                    "Sin préstamos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

            }
        }

        private async void btnAvisoMasivo_Click(object sender, EventArgs e)
        {
            var lista = ps.ListarPrestamosEmpleadosMora();
            if(lista != null)
            {

                await em_s.EnviarCorreoEmpleadosMora();
                MessageBox.Show(
                    "El aviso masivo se ha enviado correctamente.\nTodos los empleados fueron notificados exitosamente.",
                    "Proceso completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "No se encontraron empleados en mora.\nTodos los préstamos están al día.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var padre = Parent.Parent as FormMainAdmin;
            padre?.CargarControles(new RegistroPrestamoControl());
        }
    }
}
