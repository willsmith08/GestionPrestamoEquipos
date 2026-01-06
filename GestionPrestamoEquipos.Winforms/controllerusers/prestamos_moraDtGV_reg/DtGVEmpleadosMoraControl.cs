using GestionPrestamosEquipos.Business;
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
    public partial class DtGVEmpleadosMoraControl : UserControl
    {
        PrestamosService ps = new PrestamosService();
        public DtGVEmpleadosMoraControl()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            dGVEmpleadosMora.DataSource = ps.ListarPrestamosEmpleadosMora();
            dGVEmpleadosMora.RowHeadersWidth = 30;
            foreach (DataGridViewColumn columna in dGVEmpleadosMora.Columns)
            {
                if (
                    columna.Name == "Empleado" ||
                    columna.Name == "Equipo" ||
                    columna.Name == "FechaEstimadaDevolucion"
                )
                {
                    columna.Visible = true;
                }
                else
                {
                    columna.Visible = false;
                }
            }
        }
    }
}
