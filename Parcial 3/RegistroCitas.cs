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
    public partial class frmRegistroCitas : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private bool cargando = false; // evita llenar los campos mientras se carga la tabla

        public frmRegistroCitas()
        {
            InitializeComponent();

            // El ID de la cita lo genera la BD (este campo se llama txtIDEmpleado en el diseño)
            txtIDCita.ReadOnly = true;
            Ui.ConfigurarGrid(dgvRegistro);

            // El selector de hora solo muestra horas y minutos
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.ShowUpDown = true;

            // Valores fijos de los combos (los estados son los permitidos por la BD)
            cmbEstadoCita.Items.AddRange(new object[] { "Programada", "Atendida", "Cancelada", "No asistió" });
            cmbEstadoCita.SelectedIndex = 0;
            cmbTipoCita.Items.AddRange(new object[] { "Consulta", "Control", "Emergencia", "Procedimiento" });

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmRegistroCitas_Load;
            btnRegistrar.Click += btnRegistrar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            dgvRegistro.SelectionChanged += dgvRegistro_SelectionChanged;
        }

        private void frmRegistroCitas_Load(object sender, EventArgs e)
        {
            try
            {
                // Pacientes y médicos salen de la BD
                Ui.LlenarCombo(cmbPaciente, datos.ListarPacientesCombo(), "Nombre", "IdPaciente");
                Ui.LlenarCombo(cmbMedico, datos.ListarMedicosCombo(), "Nombre", "IdMedico");
            }
            catch (Exception ex) { Ui.Error(ex); }

            CargarTabla();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmCitas citas = new frmCitas();
            citas.Show();
            this.Close();

        }

        private void btnVerCalendario_Click(object sender, EventArgs e)
        {
            //Si, efectivamente hace lo mismo que el btn volver, pero es por practicidad (por si acaso se les olvida el orden de los formularios)
            frmCitas citas = new frmCitas();
            citas.Show();
            this.Close();
        }

        // ---------- Tabla ----------

        private void CargarTabla()
        {
            try
            {
                cargando = true;
                Ui.Enlazar(dgvRegistro, datos.ListarCitas(), "IdPaciente", "IdMedico");
            }
            catch (Exception ex) { Ui.Error(ex); }
            finally { cargando = false; }
        }

        // Al elegir una cita de la tabla se pasan sus datos al formulario
        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando || dgvRegistro.SelectedRows.Count == 0) return;

            DataGridViewRow f = dgvRegistro.SelectedRows[0];
            DateTime fechaHora = Convert.ToDateTime(f.Cells["FechaHora"].Value);

            txtIDCita.Text = Convert.ToString(f.Cells["IdCita"].Value);
            cmbPaciente.SelectedValue = Convert.ToInt32(f.Cells["IdPaciente"].Value);
            cmbMedico.SelectedValue = Convert.ToInt32(f.Cells["IdMedico"].Value);
            dtpFechaCita.Value = fechaHora;
            dtpHoraCita.Value = fechaHora;
            cmbEstadoCita.SelectedItem = Convert.ToString(f.Cells["Estado"].Value);

            // El tipo de cita se guarda al inicio del motivo como "[Tipo] motivo"
            string motivo = Convert.ToString(f.Cells["Motivo"].Value);
            System.Text.RegularExpressions.Match m =
                System.Text.RegularExpressions.Regex.Match(motivo, @"^\[(.+?)\]\s*(.*)$");
            if (m.Success)
            {
                cmbTipoCita.SelectedItem = m.Groups[1].Value;
                txtMotivo.Text = m.Groups[2].Value;
            }
            else
            {
                cmbTipoCita.SelectedIndex = -1;
                txtMotivo.Text = motivo;
            }
        }

        // ---------- Botones ----------

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;

            DateTime fechaHora = FechaHoraElegida();

            // Una cita nueva programada no puede quedar en el pasado
            if (cmbEstadoCita.SelectedItem.ToString() == "Programada" && fechaHora < DateTime.Now)
            {
                Ui.Aviso("La fecha y hora de una cita programada no pueden estar en el pasado.");
                return;
            }

            // Solo se puede agendar con médicos activos (no de vacaciones, licencia o inactivos)
            DataRowView medico = cmbMedico.SelectedItem as DataRowView;
            if (medico != null && Convert.ToString(medico["Estado"]) != "Activo")
            {
                Ui.Aviso("Ese médico no está activo (" + medico["Estado"] + "). Elija otro médico.");
                return;
            }

            try
            {
                datos.GuardarCita(Convert.ToInt32(cmbPaciente.SelectedValue),
                    Convert.ToInt32(cmbMedico.SelectedValue), fechaHora, MotivoCompleto(),
                    cmbEstadoCita.SelectedItem.ToString());

                datos.Bitacora("Citas", "INSERTAR", "Cita agendada para el " + fechaHora.ToString("dd/MM/yyyy HH:mm"));
                Ui.Info("Cita registrada correctamente.");
                Limpiar();
                CargarTabla();
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDCita.Text == "")
            {
                Ui.Aviso("Primero seleccione una cita de la tabla.");
                return;
            }
            if (!DatosValidos()) return;

            try
            {
                datos.ActualizarCita(int.Parse(txtIDCita.Text), Convert.ToInt32(cmbPaciente.SelectedValue),
                    Convert.ToInt32(cmbMedico.SelectedValue), FechaHoraElegida(), MotivoCompleto(),
                    cmbEstadoCita.SelectedItem.ToString());

                datos.Bitacora("Citas", "ACTUALIZAR", "Se actualizó la cita #" + txtIDCita.Text);
                Ui.Info("Cita actualizada correctamente.");
                Limpiar();
                CargarTabla();
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDCita.Text == "")
            {
                Ui.Aviso("Primero seleccione una cita de la tabla.");
                return;
            }
            if (!Ui.Confirmar("¿Desea eliminar (cancelar) la cita #" + txtIDCita.Text + "?")) return;

            try
            {
                // La cita no se borra: queda con estado Cancelada para mantener el registro
                datos.CancelarCita(int.Parse(txtIDCita.Text));
                datos.Bitacora("Citas", "ELIMINAR", "Se canceló la cita #" + txtIDCita.Text);
                Ui.Info("La cita fue cancelada correctamente.");
                Limpiar();
                CargarTabla();
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // ---------- Apoyo ----------

        // Junta la fecha del selector de fecha con la hora del selector de hora
        private DateTime FechaHoraElegida()
        {
            DateTime f = dtpFechaCita.Value;
            DateTime h = dtpHoraCita.Value;
            return new DateTime(f.Year, f.Month, f.Day, h.Hour, h.Minute, 0);
        }

        // Motivo tal como se guarda en la BD (con el tipo de cita al inicio, si se eligió)
        private string MotivoCompleto()
        {
            string motivo = txtMotivo.Text.Trim();
            return cmbTipoCita.SelectedItem != null ? "[" + cmbTipoCita.SelectedItem + "] " + motivo : motivo;
        }

        private void Limpiar()
        {
            txtIDCita.Clear();
            cmbPaciente.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
            cmbTipoCita.SelectedIndex = -1;
            cmbEstadoCita.SelectedIndex = 0;
            dtpFechaCita.Value = DateTime.Today;
            dtpHoraCita.Value = DateTime.Today.AddHours(8);
            txtMotivo.Clear();
            dgvRegistro.ClearSelection();
        }

        private bool DatosValidos()
        {
            if (cmbPaciente.SelectedValue == null)
            {
                Ui.Aviso("Seleccione el paciente.");
                return false;
            }
            if (cmbMedico.SelectedValue == null)
            {
                Ui.Aviso("Seleccione el médico.");
                return false;
            }
            if (txtMotivo.Text.Trim() == "")
            {
                Ui.Aviso("Escriba el motivo de la cita.");
                return false;
            }
            if (cmbEstadoCita.SelectedItem == null)
            {
                Ui.Aviso("Seleccione el estado de la cita.");
                return false;
            }
            if (MotivoCompleto().Length > 200)
            {
                Ui.Aviso("El motivo es demasiado largo (máximo 200 caracteres).");
                return false;
            }
            return true;
        }
    }
}
