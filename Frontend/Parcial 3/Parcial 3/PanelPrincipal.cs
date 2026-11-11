using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_3
{
    public partial class frmPanelPrincipal : Form
    {
        public frmPanelPrincipal()
        {
            InitializeComponent();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes pacientes = new frmPacientes();
            pacientes.Show();
            this.Close();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos medicos = new frmMedicos();
            medicos.Show();
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
           frmCitas citas = new frmCitas();
            citas.Show();
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas consultas = new frmConsultas();
            consultas.Show();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorialClinico historialClinico = new frmHistorialClinico();
            historialClinico.Show();
            this.Close();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion facturacion = new frmFacturacion();
            facturacion.Show();
            this.Close();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.Show();
            this.Close();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            frmVideos videos = new frmVideos();
            videos.Show();
            this.Close();
        }
    }
}
