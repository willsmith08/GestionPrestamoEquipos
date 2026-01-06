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
    public partial class DtGVHistorialControl : UserControl
    {
        PrestamosService ps = new PrestamosService();
        public DtGVHistorialControl()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            dGVHistorialPres.DataSource = ps.ListarPrestamos();
            dGVHistorialPres.RowHeadersWidth = 30;

            foreach (DataGridViewColumn columna in dGVHistorialPres.Columns)
            {
                if (
                    columna.Name == "Empleado" || columna.Name == "Equipo" ||
                    columna.Name == "fechaPrestamo"
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
