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

namespace GestionPrestamosEquipos.Forms
{
    public partial class FormValidarCodigo : Form
    {
        public bool desdePrestamo { get; set; }
        public static bool verificacion = false;

        EmailService e_ms = new EmailService();
        int tiempoRestante = 300;

        public FormValidarCodigo()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            Console.WriteLine("si");

            lblTiempo.Text = TimeSpan.FromSeconds(tiempoRestante).ToString(@"mm\:ss");

            if (tiempoRestante<=0)
            {
                timer1.Stop();
                lblTiempo.Text = "00:00";
                MessageBox.Show("El tiempo a terminado");
                EmailService.codigo = 0;
            }
        }

        private void FormValidarCodigo_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTiempo.Text = "00:00";
            this.Close();
        }

        private async void linkLblEnviarCodigo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (desdePrestamo)
            {
                await e_ms.EnvioCodigoValidacionPrestamo();
            }
            else
            {
                await e_ms.EnvioCodigoValidacion(EmpleadoService.EmpleadosDTOReg);
            }
            tiempoRestante = 300;
            timer1.Start();
        }

        private void FormValidarCodigo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum1.Text+txtNum2.Text+txtNum3.Text,out int resultado) && resultado == EmailService.codigo )
            {
                verificacion = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Codigo incorrecto");
            }
        }
    }
}
