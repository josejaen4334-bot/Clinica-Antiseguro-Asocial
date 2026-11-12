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

            // Saludo con el nombre de quien inició sesión y permisos según su rol
            if (Sesion.IdUsuario > 0)
            {
                string nombre = (string.IsNullOrEmpty(Sesion.Persona) || Sesion.Persona == "(sin vincular)")
                    ? Sesion.NombreUsuario : Sesion.Persona;
                lblBienvenido.Text = "¡Bienvenido al panel principal, " + nombre + "!";
                AplicarPermisos();
            }
        }

        // Según la descripción de los roles en la BD: Admin ve todo,
        // Médico trabaja con citas/consultas/historial y Paciente con citas/historial/facturas
        private void AplicarPermisos()
        {
            if (Sesion.Rol == "Medico")
            {
                btnPacientes.Enabled = false;
                btnMedicos.Enabled = false;
                btnEmpleados.Enabled = false;
                btnFacturacion.Enabled = false;
                btnReportes.Enabled = false;
            }
            else if (Sesion.Rol == "Paciente")
            {
                btnPacientes.Enabled = false;
                btnMedicos.Enabled = false;
                btnEmpleados.Enabled = false;
                btnConsultas.Enabled = false;
                btnReportes.Enabled = false;
            }
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
            // Se deja constancia del cierre de sesión, se limpia la sesión y se vuelve al login
            new DatosClinica().Bitacora("Login", "LOGOUT", "Cierre de sesión");
            Sesion.Cerrar();
            frmLogin login = new frmLogin();
            login.Show();
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
            this.Close();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            frmBitacora bitacora = new frmBitacora();
            bitacora.Show();
            this.Close();
        }
    }
}
