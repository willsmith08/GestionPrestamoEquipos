using GestionPrestamosEquipos.Business;
using GestionPrestamosEquipos.DTOModels;
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
    public partial class DevolucionesControl : UserControl
    {
        PrestamosService ps = new PrestamosService();
        DevolucionesService ds = new DevolucionesService();
        public DevolucionesControl()
        {
            InitializeComponent();
        }


        private void cargarDatos(int resultado)
        {
            dGVEquiposPrestados.AutoGenerateColumns = true;

            EmpleadosDTO empleado = new EmpleadosDTO
            {
                documentoEmpleado = resultado,
            };

            var lista = ps.ListarPrestamosPorEmpleado(empleado);
            if (lista != null)
            {

                dGVEquiposPrestados.AllowUserToAddRows = false;
                if (!dGVEquiposPrestados.Columns.Contains(dGVEquiposPrestados.Columns["columCheck"]))
                {
                    DataGridViewCheckBoxColumn columCheck = new DataGridViewCheckBoxColumn();
                    columCheck.HeaderText = "";
                    columCheck.Name = "columCheck";
                    columCheck.Width = 30;
                    columCheck.ReadOnly = false;
                    columCheck.TrueValue = true;
                    columCheck.FalseValue = false;
                    columCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dGVEquiposPrestados.Columns.Add(columCheck);
                }

                dGVEquiposPrestados.DataSource = lista;

                dGVEquiposPrestados.Columns["Equipo"].ReadOnly = true;
                dGVEquiposPrestados.Columns["Serial"].ReadOnly = true;
                dGVEquiposPrestados.Columns["e_mail"].ReadOnly = true;


                dGVEquiposPrestados.Columns["idPrestamo"].Visible = false;
                dGVEquiposPrestados.Columns["idEquipo"].Visible = false;
                dGVEquiposPrestados.Columns["Empleado"].Visible = false;
                dGVEquiposPrestados.Columns["Documento"].Visible = false;
                dGVEquiposPrestados.Columns["fechaPrestamo"].Visible = false;
                dGVEquiposPrestados.Columns["fechaEstimadaDevolucion"].Visible = false;
                dGVEquiposPrestados.Columns["observaciones"].Visible = false;
                dGVEquiposPrestados.Columns["idEmpleado"].Visible = false;
                dGVEquiposPrestados.Columns["fechaDevolucion"].Visible = false;


            }
            else
            {
                dGVEquiposPrestados.DataSource = null;
                MessageBox.Show("Empleado no tiene prestamos registrados","ERROR AL BUSCAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var resultado = validacionCampos();

            if (resultado != null)
            {
                cargarDatos(int.Parse(resultado.ToString()));
            }
        }

        private int? validacionCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDocEmp.Text))
            {
                MessageBox.Show("Debe llenar el campo de documento");
                return null;
            }

            if (int.TryParse(txtDocEmp.Text, out int resultado))
            {
                return resultado;
            }
            else
            {
                MessageBox.Show("Solo puede ingresar numero");
                return null;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (validacionCampos() != null)
            {
                List<PrestamosDTO> listaPrestamosDev = new List<PrestamosDTO>();
                foreach (DataGridViewRow fila in dGVEquiposPrestados.Rows)
                {
                    if (Convert.ToBoolean(dGVEquiposPrestados.Rows[fila.Index].Cells["columCheck"].Value))
                    {
                        PrestamosDTO pd = new PrestamosDTO
                        {
                            idPrestamo = Convert.ToInt32(dGVEquiposPrestados.Rows[fila.Index].Cells["idPrestamo"].Value),
                            idEquipo = Convert.ToInt32(dGVEquiposPrestados.Rows[fila.Index].Cells["idEquipo"].Value),
                            fechaDevolucion = DateTime.Now,
                        };

                        listaPrestamosDev.Add(pd);
                    }
                }

                if (listaPrestamosDev.Count() == 0)
                {
                    MessageBox.Show("Seleccione el/los equipo/s que desea devolver","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                ds.DevolverPrestamos(listaPrestamosDev);
                cargarDatos(int.Parse(txtDocEmp.Text));
            }
        }
    }
}
