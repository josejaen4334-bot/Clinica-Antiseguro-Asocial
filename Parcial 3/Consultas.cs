using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Parcial_3
{
    public partial class frmConsultas : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private int idPaciente = 0; // paciente al que se le registra la consulta

        public frmConsultas()
        {
            InitializeComponent();

            // La fecha de la consulta es la de ahora y no se puede cambiar
            txtFechaRegistro.ReadOnly = true;
            txtFechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmConsultas_Load;
            btnRegistrar.Click += btnRegistrar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            try
            {
                Ui.LlenarCombo(cmbMedicoResponsable, datos.ListarMedicosCombo(), "Nombre", "IdMedico");

                // Si quien inició sesión es un médico, él es el responsable de la consulta
                if (Sesion.Rol == "Medico" && Sesion.IdMedico.HasValue)
                {
                    cmbMedicoResponsable.SelectedValue = Sesion.IdMedico.Value;
                    cmbMedicoResponsable.Enabled = false;
                }

                // El paciente es el que se eligió en el Historial Clínico
                idPaciente = Sesion.IdPacienteSeleccionado;
                DataRow p = idPaciente > 0 ? datos.ObtenerPaciente(idPaciente) : null;

                if (p != null)
                {
                    this.Text = "Gestion de Consultas Medicas - Paciente: " + p["Nombre"] + " " + p["Apellido"]
                        + " (" + p["Cedula"] + ")";
                }
                else
                {
                    idPaciente = 0;
                    Ui.Aviso("No hay un paciente seleccionado.\n\nVaya al Historial Clínico, seleccione un paciente " +
                        "y presione \"+ Nueva Consulta\".");
                }
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        // Campos del diseño: txtMotivo = síntomas, textBox2 = diagnóstico,
        // txtTratamiento = tratamiento, textBox1 = observaciones
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (idPaciente == 0)
            {
                Ui.Aviso("No hay un paciente seleccionado. Elíjalo desde el Historial Clínico.");
                return;
            }
            if (cmbMedicoResponsable.SelectedValue == null)
            {
                Ui.Aviso("Seleccione el médico responsable.");
                return;
            }
            if (txtDiagnostico.Text.Trim() == "")
            {
                Ui.Aviso("El diagnóstico es obligatorio.");
                return;
            }

            DataRowView medico = cmbMedicoResponsable.SelectedItem as DataRowView;
            if (medico != null && Convert.ToString(medico["Estado"]) != "Activo")
            {
                Ui.Aviso("Ese médico no está activo (" + medico["Estado"] + "). Elija otro médico.");
                return;
            }

            // La BD no tiene columna para el tipo de registro, se guarda al inicio de las observaciones
            string observaciones = txtObservaciones.Text.Trim();
            if (cmbTipo.SelectedItem != null) observaciones = "[" + cmbTipo.SelectedItem + "] " + observaciones;

            if (txtMotivo.Text.Length > 500 || txtDiagnostico.Text.Length > 500 ||
                txtTratamiento.Text.Length > 500 || observaciones.Length > 500)
            {
                Ui.Aviso("Cada campo de texto puede tener máximo 500 caracteres.");
                return;
            }

            try
            {
                datos.GuardarConsulta(idPaciente, Convert.ToInt32(cmbMedicoResponsable.SelectedValue),
                    txtMotivo.Text.Trim(), txtDiagnostico.Text.Trim(), txtTratamiento.Text.Trim(), observaciones.Trim());

                datos.Bitacora("Consultas", "INSERTAR", "Nueva consulta para el paciente #" + idPaciente);
                Ui.Info("Consulta registrada correctamente.");
                Limpiar();
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtFechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            cmbTipo.SelectedIndex = -1;
            if (cmbMedicoResponsable.Enabled) cmbMedicoResponsable.SelectedIndex = -1;
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            txtObservaciones.Clear();
        }
    }
}
