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
    public partial class EquiposControl : UserControl
    {
        EquiposService es = new EquiposService();
        EstadoService esS = new EstadoService();
        TiposEquiposService tes = new TiposEquiposService();

        public EquiposControl()
        {
            InitializeComponent();

            cargardGVEquipos();
            cargarCBEstadoEquipo();
            cargarCBTipoEquipo();
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Buscar")
            {
                txtBusqueda.Text = string.Empty;
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Buscar";
                txtBusqueda.ForeColor = Color.Gray;
            }
        }

        public void cargardGVEquipos()
        {
            dGVEquipos.DataSource = es.ListarEquiposControl(txtBusqueda.Text);

            dGVEquipos.Columns["idEquipo"].Visible = false;
            dGVEquipos.Columns["idEstado"].Visible = false;
            dGVEquipos.Columns["descripcion"].Visible = false;
            dGVEquipos.Columns["idTipo"].Visible = false;

            dGVEquipos.Columns["nombreTipo"].HeaderText = "TIPO";
            dGVEquipos.Columns["nombreEquipo"].HeaderText = "EQUIPO";
            dGVEquipos.Columns["serial"].HeaderText = "SERIAL";
            dGVEquipos.Columns["nombreEstado"].HeaderText = "ESTADO";
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            cargardGVEquipos();
        }

        private void cargarCBEstadoEquipo()
        {
            cBEstadosEquipo.DataSource = esS.ListarEstadosControl();
            cBEstadosEquipo.ValueMember = "idEstado";
            cBEstadosEquipo.DisplayMember = "nombreEstado";
        }

        private void cargarCBTipoEquipo()
        {
            cBTiposEquipo.DataSource = tes.ListarTipoEquipos();
            cBTiposEquipo.ValueMember = "idTipo";
            cBTiposEquipo.DisplayMember = "nombreTipo";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!validacion())
            {
                return;
            }

            EquiposDTO ed = new EquiposDTO
            {
                nombreEquipo = txtNombreEquipo.Text,
                descripcion = txtDescrpcion.Text,
                idEstado = int.Parse(cBEstadosEquipo.SelectedValue.ToString()),
                idTipo = int.Parse(cBTiposEquipo.SelectedValue.ToString()),
                serial = txtSerial.Text,
            };

            es.AgregarEquipo(ed);

            cargardGVEquipos();
            limpiarCampos();
        }

        private bool validacion()
        {
            if 
            (
                string.IsNullOrEmpty(txtDescrpcion.Text) ||
                string.IsNullOrEmpty(txtNombreEquipo.Text) ||
                string.IsNullOrEmpty(txtSerial.Text)
            )
            {
                MessageBox.Show("No pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (
                cBEstadosEquipo.SelectedValue.ToString() == "0"
                )
            {
                MessageBox.Show("Seleccione un estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (
                cBTiposEquipo.SelectedValue.ToString() == "0"
                )
            {
                MessageBox.Show("Seleccione un tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNombreEquipo.Text = string.Empty;
            txtDescrpcion.Text = string.Empty;
            cBEstadosEquipo.SelectedValue = 0;
            cBTiposEquipo.SelectedValue = 0;
            txtSerial.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dGVEquipos.CurrentRow.Index >= 0)
            {
                EquiposDTO equ = new EquiposDTO
                {
                    idEquipo = int.Parse(dGVEquipos.CurrentRow.Cells["idEquipo"].Value.ToString()),
                    nombreEquipo = dGVEquipos.CurrentRow.Cells["nombreEquipo"].Value.ToString()
                };

                if (es.VerifacarPrestamoControl(equ) == false)
                {
                    return;
                }

                if (MessageBox.Show($"¿Esta seguro que desea eliminar el equipo con nombre: {equ.nombreEquipo}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    es.EliminarEquipoControl(equ);
                    cargardGVEquipos();
                }
            }
            else
            {
                MessageBox.Show("Para eliminar un equipo debe seleccionarlo de la lista", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
