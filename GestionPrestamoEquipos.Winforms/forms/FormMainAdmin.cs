using GestionPrestamosEquipos.ControllerUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPrestamosEquipos.Forms
{
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin()
        {
            InitializeComponent();
        }

        public void CargarControles(UserControl uc)
        {
            panelControl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            CargarControles(new PrestamosControl());

            btnPrestamo.BackColor = Color.PaleTurquoise;
            btnEquipos.BackColor = Color.AliceBlue;
            btnDevoluciones.BackColor = Color.AliceBlue;
            btnEmpleados.BackColor = Color.AliceBlue;
            
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            CargarControles(new EmpleadosControl());

            btnPrestamo.BackColor = Color.AliceBlue;
            btnEquipos.BackColor = Color.AliceBlue;
            btnDevoluciones.BackColor = Color.AliceBlue;
            btnEmpleados.BackColor = Color.PaleTurquoise;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            CargarControles(new EquiposControl());

            btnPrestamo.BackColor = Color.AliceBlue;
            btnEquipos.BackColor = Color.PaleTurquoise;
            btnDevoluciones.BackColor = Color.AliceBlue;
            btnEmpleados.BackColor = Color.AliceBlue;
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            CargarControles(new DevolucionesControl());

            btnPrestamo.BackColor = Color.AliceBlue;
            btnEquipos.BackColor = Color.AliceBlue;
            btnDevoluciones.BackColor = Color.PaleTurquoise;
            btnEmpleados.BackColor = Color.AliceBlue;
        }
    }
}
