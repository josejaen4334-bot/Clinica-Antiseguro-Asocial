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
    public partial class frmHistorialClinico : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private bool cargando = false; // evita llenar los campos mientras se carga la tabla

        public frmHistorialClinico()
        {
            InitializeComponent();

            // En el diseño el buscador quedó de solo lectura; se habilita para poder escribir
            txtBuscar.ReadOnly = false;
            Ui.Placeholder(txtBuscar);

            // Los datos del paciente son solo para mostrar: los botones de género no se pueden cambiar
            radMasculino.AutoCheck = false;
            radFemenino.AutoCheck = false;

            Ui.ConfigurarGrid(dgvRegistroPacientes);
            Ui.ConfigurarGrid(dgvHistorialRegistro, false); // el historial se puede editar y luego presionar Actualizar

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmHistorialClinico_Load;
            btnBuscar.Click += btnBuscar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            dgvRegistroPacientes.SelectionChanged += dgvRegistroPacientes_SelectionChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
        }

        private void frmHistorialClinico_Load(object sender, EventArgs e)
        {
            CargarPacientes("");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            // Recarga la lista de pacientes
            Ui.RestaurarPlaceholder(txtBuscar);
            CargarPacientes("");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmConsultas consultas = new frmConsultas();
            consultas.Show();
            this.Close();
        }

        // ---------- Pacientes ----------

        private void CargarPacientes(string filtro)
        {
            try
            {
                cargando = true;
                Ui.Enlazar(dgvRegistroPacientes, datos.ListarPacientes(filtro), "IdPaciente", "Direccion", "Correo");
            }
            catch (Exception ex) { Ui.Error(ex); }
            finally { cargando = false; }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPacientes(Ui.Escrito(txtBuscar));
            if (dgvRegistroPacientes.Rows.Count == 0) Ui.Info("No se encontraron pacientes con ese dato.");
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(sender, e);
            }
        }

        // Al elegir un paciente se muestran sus datos y su historial de consultas
        private void dgvRegistroPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando || dgvRegistroPacientes.SelectedRows.Count == 0) return;

            DataGridViewRow f = dgvRegistroPacientes.SelectedRows[0];
            int id = Convert.ToInt32(f.Cells["IdPaciente"].Value);
            DateTime nacimiento = Convert.ToDateTime(f.Cells["FechaNacimiento"].Value);

            txtIDPaciente.Text = id.ToString();
            txtCedula.Text = Convert.ToString(f.Cells["Cedula"].Value);
            txtNombre.Text = Convert.ToString(f.Cells["Nombre"].Value);
            txtApellido.Text = Convert.ToString(f.Cells["Apellido"].Value);
            radMasculino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Masculino";
            radFemenino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Femenino";
            txtTipoSangre.Text = Convert.ToString(f.Cells["TipoSangre"].Value);
            txtEdad.Text = CalcularEdad(nacimiento).ToString();

            // Se recuerda el paciente para que "+ Nueva Consulta" sepa a quién registrarle la consulta
            Sesion.IdPacienteSeleccionado = id;
            CargarHistorial(id);
        }

        private int CalcularEdad(DateTime nacimiento)
        {
            int edad = DateTime.Today.Year - nacimiento.Year;
            if (nacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
            return edad;
        }

        // ---------- Historial de consultas ----------

        private void CargarHistorial(int idPaciente)
        {
            try
            {
                Ui.Enlazar(dgvHistorialRegistro, datos.ListarConsultasPaciente(idPaciente), "IdConsulta");

                // Estas columnas no se editan; síntomas, diagnóstico, tratamiento y observaciones sí
                foreach (string col in new string[] { "Fecha", "Medico", "Especialidad" })
                    if (dgvHistorialRegistro.Columns.Contains(col)) dgvHistorialRegistro.Columns[col].ReadOnly = true;
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        // Guarda en la BD los cambios hechos en la fila seleccionada del historial
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow f = dgvHistorialRegistro.CurrentRow;
            if (f == null)
            {
                Ui.Aviso("Primero seleccione un registro del historial.");
                return;
            }

            dgvHistorialRegistro.EndEdit();
            string diagnostico = Convert.ToString(f.Cells["Diagnostico"].Value).Trim();
            if (diagnostico == "")
            {
                Ui.Aviso("El diagnóstico no puede quedar vacío.");
                return;
            }

            try
            {
                datos.ActualizarConsulta(Convert.ToInt32(f.Cells["IdConsulta"].Value),
                    Convert.ToString(f.Cells["Sintomas"].Value).Trim(), diagnostico,
                    Convert.ToString(f.Cells["Tratamiento"].Value).Trim(),
                    Convert.ToString(f.Cells["Observaciones"].Value).Trim());

                datos.Bitacora("Historial", "ACTUALIZAR", "Se actualizó la consulta #" + f.Cells["IdConsulta"].Value);
                Ui.Info("Registro actualizado correctamente.");
                CargarHistorial(Sesion.IdPacienteSeleccionado);
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow f = dgvHistorialRegistro.CurrentRow;
            if (f == null)
            {
                Ui.Aviso("Primero seleccione un registro del historial.");
                return;
            }
            if (!Ui.Confirmar("¿Desea eliminar este registro del historial clínico?")) return;

            try
            {
                datos.EliminarConsulta(Convert.ToInt32(f.Cells["IdConsulta"].Value));
                datos.Bitacora("Historial", "ELIMINAR", "Se eliminó la consulta #" + f.Cells["IdConsulta"].Value);
                Ui.Info("Registro eliminado correctamente.");
                CargarHistorial(Sesion.IdPacienteSeleccionado);
            }
            catch (Exception ex) { Ui.Error(ex); } // si la consulta ya fue facturada la BD no deja borrarla
        }
    }
}