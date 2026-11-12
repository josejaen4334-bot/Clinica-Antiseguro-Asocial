using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Parcial_3
{
    public partial class frmPacientes : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private bool cargando = false; // evita llenar los campos mientras se carga la tabla

        // Tipos de sangre permitidos por la BD
        private static readonly string[] TiposSangre = { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };

        public frmPacientes()
        {
            InitializeComponent();

            // El ID lo genera la BD solo, por eso no se puede escribir
            txtIDPaciente.ReadOnly = true;
            Ui.ConfigurarGrid(dgvRegistro);
            Ui.Placeholder(txtBuscar);

            // Estos botones no tenían evento en el diseño, así que se conectan aquí (sin tocar el Designer)
            this.Load += frmPacientes_Load;
            btnRegistrar.Click += btnRegistrar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            dgvRegistro.SelectionChanged += dgvRegistro_SelectionChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            CargarTabla("");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        // ---------- Tabla ----------

        // Trae los pacientes registrados en la BD (con filtro opcional)
        private void CargarTabla(string filtro)
        {
            try
            {
                cargando = true;
                Ui.Enlazar(dgvRegistro, datos.ListarPacientes(filtro), "IdPaciente");
            }
            catch (Exception ex) { Ui.Error(ex); }
            finally { cargando = false; }
        }

        // Al elegir una fila se pasan sus datos a los campos del formulario
        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando || dgvRegistro.SelectedRows.Count == 0) return;

            DataGridViewRow f = dgvRegistro.SelectedRows[0];
            txtIDPaciente.Text = Convert.ToString(f.Cells["IdPaciente"].Value);
            txtCedula.Text = Convert.ToString(f.Cells["Cedula"].Value);
            txtNombre.Text = Convert.ToString(f.Cells["Nombre"].Value);
            txtApellido.Text = Convert.ToString(f.Cells["Apellido"].Value);
            radMasculino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Masculino";
            radFemenino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Femenino";
            dtpNacimiento.Value = Convert.ToDateTime(f.Cells["FechaNacimiento"].Value);
            txtTelefono.Text = Convert.ToString(f.Cells["Telefono"].Value);
            txtCorreo.Text = Convert.ToString(f.Cells["Correo"].Value);
            txtDireccion.Text = Convert.ToString(f.Cells["Direccion"].Value);
            txtTipoSangre.Text = Convert.ToString(f.Cells["TipoSangre"].Value); // textBox1 = tipo de sangre
        }

        // ---------- Botones ----------

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;

            try
            {
                datos.GuardarPaciente(txtCedula.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                    Genero(), dtpNacimiento.Value, txtTelefono.Text.Trim(), txtCorreo.Text.Trim(),
                    txtDireccion.Text.Trim(), txtTipoSangre.Text.Trim().ToUpper());

                datos.Bitacora("Pacientes", "INSERTAR", "Se registró el paciente " + txtCedula.Text.Trim());
                Ui.Info("Paciente registrado correctamente.");
                Limpiar();
                CargarTabla("");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text == "")
            {
                Ui.Aviso("Primero seleccione un paciente de la tabla.");
                return;
            }
            if (!DatosValidos()) return;

            try
            {
                datos.ActualizarPaciente(int.Parse(txtIDPaciente.Text), txtCedula.Text.Trim(),
                    txtNombre.Text.Trim(), txtApellido.Text.Trim(), Genero(), dtpNacimiento.Value,
                    txtTelefono.Text.Trim(), txtCorreo.Text.Trim(), txtDireccion.Text.Trim(),
                    txtTipoSangre.Text.Trim().ToUpper());

                datos.Bitacora("Pacientes", "ACTUALIZAR", "Se actualizó el paciente " + txtCedula.Text.Trim());
                Ui.Info("Paciente actualizado correctamente.");
                Limpiar();
                CargarTabla("");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text == "")
            {
                Ui.Aviso("Primero seleccione un paciente de la tabla.");
                return;
            }
            if (!Ui.Confirmar("¿Desea eliminar al paciente " + txtNombre.Text + " " + txtApellido.Text + "?"))
                return;

            try
            {
                // No se borra de la BD: se desactiva para conservar sus citas, consultas y facturas
                datos.DesactivarPaciente(int.Parse(txtIDPaciente.Text));
                datos.Bitacora("Pacientes", "ELIMINAR", "Se eliminó (desactivó) el paciente " + txtCedula.Text.Trim());
                Ui.Info("Paciente eliminado correctamente.");
                Limpiar();
                CargarTabla("");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = Ui.Escrito(txtBuscar);
            CargarTabla(filtro);
            if (dgvRegistro.Rows.Count == 0) Ui.Info("No se encontraron pacientes con ese dato.");
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(sender, e);
            }
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            Ui.RestaurarPlaceholder(txtBuscar);
            CargarTabla("");
        }

        // ---------- Apoyo ----------

        private string Genero()
        {
            return radMasculino.Checked ? "M" : "F";
        }

        private void Limpiar()
        {
            txtIDPaciente.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            radMasculino.Checked = false;
            radFemenino.Checked = false;
            dtpNacimiento.Value = DateTime.Today;
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtTipoSangre.Clear();
            dgvRegistro.ClearSelection();
            txtCedula.Focus();
        }

        // Revisa los datos obligatorios antes de mandarlos a la BD
        private bool DatosValidos()
        {
            if (txtCedula.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "")
            {
                Ui.Aviso("La cédula, el nombre y el apellido son obligatorios.");
                return false;
            }

            // Validación de formato de cédula panameña y extranjeros (E, N, PE, etc.)
            string cedula = txtCedula.Text.Trim();
            Regex regexCedula = new Regex(@"^(?:[1-9]|1[0-3]|PE|E|N|PI)-\d{1,4}-\d{1,6}$", RegexOptions.IgnoreCase);
            if (!regexCedula.IsMatch(cedula))
            {
                Ui.Aviso("El formato de la cédula o identificación no es válido. Ejemplos correctos: 8-123-4567, E-8-123456.");
                return false;
            }

            if (!radMasculino.Checked && !radFemenino.Checked)
            {
                Ui.Aviso("Seleccione el género del paciente.");
                return false;
            }
            if (dtpNacimiento.Value.Date > DateTime.Today)
            {
                Ui.Aviso("La fecha de nacimiento no puede ser futura.");
                return false;
            }
            if (!Ui.CorreoValido(txtCorreo.Text))
            {
                Ui.Aviso("El correo no tiene un formato válido.");
                return false;
            }
            string sangre = txtTipoSangre.Text.Trim().ToUpper();
            if (sangre != "" && Array.IndexOf(TiposSangre, sangre) < 0)
            {
                Ui.Aviso("Tipo de sangre no válido. Use: A+, A-, B+, B-, AB+, AB-, O+ u O-.");
                return false;
            }
            return true;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}