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
    public partial class frmUsuarios : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private bool cargando = false;   // evita llenar los campos mientras se carga la tabla
        private int idSeleccionado = 0;  // usuario elegido en la tabla (0 = ninguno)

        public frmUsuarios()
        {
            InitializeComponent();

            Ui.ConfigurarGrid(dgvRegistro);
            Ui.Placeholder(txtBuscar);

            // La contraseña se escribe oculta
            txtContrasena.UseSystemPasswordChar = true;
            new ToolTip().SetToolTip(txtContrasena, "Al actualizar, déjela vacía para conservar la contraseña actual");

            // Los combos del diseño traían valores de ejemplo; se vacían y se llenan con datos de la BD
            cmbRol.Items.Clear();
            cmbPersona.Items.Clear();
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.SelectedIndex = 0;
            radNadie.Checked = true;
            cmbPersona.Enabled = false;

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmUsuarios_Load;
            btnRegistrar.Click += btnRegistrar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnBuscar.Click += btnBuscar_Click;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            dgvRegistro.SelectionChanged += dgvRegistro_SelectionChanged;

            // Al cambiar "Vincular a" se cambia la lista de personas
            radNadie.CheckedChanged += radVincular_CheckedChanged;
            radMedico.CheckedChanged += radVincular_CheckedChanged;
            radEmpleado.CheckedChanged += radVincular_CheckedChanged;
            radPaciente.CheckedChanged += radVincular_CheckedChanged;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // Los roles salen de la tabla Roles
                Ui.LlenarCombo(cmbRol, datos.ListarRoles(), "Nombre", "IdRol");
            }
            catch (Exception ex) { Ui.Error(ex); }

            CargarTabla("");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        // ---------- Tabla y persona vinculada ----------

        private void CargarTabla(string filtro)
        {
            try
            {
                cargando = true;
                Ui.Enlazar(dgvRegistro, datos.ListarUsuarios(filtro),
                    "IdUsuario", "IdRol", "IdMedico", "IdEmpleado", "IdPaciente");
            }
            catch (Exception ex) { Ui.Error(ex); }
            finally { cargando = false; }
        }

        private void radVincular_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) CargarPersonas();
        }

        // Llena la lista de personas según a quién se vaya a vincular el usuario
        private void CargarPersonas()
        {
            cmbPersona.DataSource = null;
            cmbPersona.Items.Clear();

            if (radNadie.Checked)
            {
                cmbPersona.Enabled = false;
                return;
            }

            try
            {
                cmbPersona.Enabled = true;
                if (radMedico.Checked)
                    Ui.LlenarCombo(cmbPersona, datos.ListarMedicosCombo(), "Nombre", "IdMedico");
                else if (radEmpleado.Checked)
                    Ui.LlenarCombo(cmbPersona, datos.ListarEmpleadosCombo(), "Nombre", "IdEmpleado");
                else
                    Ui.LlenarCombo(cmbPersona, datos.ListarPacientesCombo(), "Nombre", "IdPaciente");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        // Al elegir un usuario de la tabla se pasan sus datos al formulario
        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando || dgvRegistro.SelectedRows.Count == 0) return;

            DataGridViewRow f = dgvRegistro.SelectedRows[0];
            idSeleccionado = Convert.ToInt32(f.Cells["IdUsuario"].Value);
            txtUsuario.Text = Convert.ToString(f.Cells["NombreUsuario"].Value);
            txtContrasena.Clear(); // la contraseña no se puede leer (solo se guarda su hash)
            cmbRol.SelectedValue = Convert.ToInt32(f.Cells["IdRol"].Value);
            cmbEstado.SelectedItem = Convert.ToString(f.Cells["Estado"].Value);

            object medico = f.Cells["IdMedico"].Value;
            object empleado = f.Cells["IdEmpleado"].Value;
            object paciente = f.Cells["IdPaciente"].Value;

            if (medico != DBNull.Value) { radMedico.Checked = true; cmbPersona.SelectedValue = Convert.ToInt32(medico); }
            else if (empleado != DBNull.Value) { radEmpleado.Checked = true; cmbPersona.SelectedValue = Convert.ToInt32(empleado); }
            else if (paciente != DBNull.Value) { radPaciente.Checked = true; cmbPersona.SelectedValue = Convert.ToInt32(paciente); }
            else radNadie.Checked = true;
        }

        // ---------- Botones ----------

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos(true)) return;

            try
            {
                datos.GuardarUsuario(txtUsuario.Text.Trim(), txtContrasena.Text,
                    Convert.ToInt32(cmbRol.SelectedValue), Vinculo(radMedico), Vinculo(radEmpleado),
                    Vinculo(radPaciente), cmbEstado.SelectedItem.ToString() == "Activo");

                datos.Bitacora("Usuarios", "INSERTAR", "Se creó el usuario \"" + txtUsuario.Text.Trim() + "\"");
                Ui.Info("Usuario registrado correctamente.");
                Limpiar();
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                Ui.Aviso("Primero seleccione un usuario de la tabla.");
                return;
            }
            if (!DatosValidos(false)) return;

            try
            {
                datos.ActualizarUsuario(idSeleccionado, txtUsuario.Text.Trim(), Convert.ToInt32(cmbRol.SelectedValue),
                    Vinculo(radMedico), Vinculo(radEmpleado), Vinculo(radPaciente),
                    cmbEstado.SelectedItem.ToString() == "Activo");

                // La contraseña solo se cambia si se escribió una nueva
                if (txtContrasena.Text != "") datos.CambiarContrasena(idSeleccionado, txtContrasena.Text);

                datos.Bitacora("Usuarios", "ACTUALIZAR", "Se actualizó el usuario \"" + txtUsuario.Text.Trim() + "\"");
                Ui.Info("Usuario actualizado correctamente.");
                Limpiar();
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                Ui.Aviso("Primero seleccione un usuario de la tabla.");
                return;
            }
            if (idSeleccionado == Sesion.IdUsuario)
            {
                Ui.Aviso("No puede eliminar el usuario con el que inició sesión.");
                return;
            }
            if (!Ui.Confirmar("¿Desea eliminar al usuario \"" + txtUsuario.Text + "\"?")) return;

            try
            {
                // No se borra de la BD: queda inactivo (la bitácora y las facturas lo referencian)
                datos.DesactivarUsuario(idSeleccionado);
                datos.Bitacora("Usuarios", "ELIMINAR", "Se eliminó (desactivó) el usuario \"" + txtUsuario.Text.Trim() + "\"");
                Ui.Info("Usuario eliminado correctamente (quedó como Inactivo).");
                Limpiar();
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarTabla(Ui.Escrito(txtBuscar));
            if (dgvRegistro.Rows.Count == 0) Ui.Info("No se encontraron usuarios con ese dato.");
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscar_Click(sender, e);
            }
        }

        // ---------- Apoyo ----------

        // Id de la persona elegida si el radio indicado es el marcado (si no, null = sin vínculo)
        private int? Vinculo(RadioButton radio)
        {
            if (radio.Checked && cmbPersona.SelectedValue != null)
                return Convert.ToInt32(cmbPersona.SelectedValue);
            return null;
        }

        private void Limpiar()
        {
            idSeleccionado = 0;
            txtUsuario.Clear();
            txtContrasena.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;
            radNadie.Checked = true;
            Ui.RestaurarPlaceholder(txtBuscar);
            CargarTabla("");
            dgvRegistro.ClearSelection();
            txtUsuario.Focus();
        }

        // esNuevo = true cuando se va a registrar (ahí la contraseña es obligatoria)
        private bool DatosValidos(bool esNuevo)
        {
            string usuario = txtUsuario.Text.Trim();
            if (usuario.Length < 3 || usuario.Length > 30 ||
                !System.Text.RegularExpressions.Regex.IsMatch(usuario, @"^[A-Za-z0-9._-]+$"))
            {
                Ui.Aviso("El usuario debe tener de 3 a 30 caracteres (letras, números, punto, guion o guion bajo).");
                return false;
            }
            if ((esNuevo || txtContrasena.Text != "") && txtContrasena.Text.Length < 6)
            {
                Ui.Aviso("La contraseña debe tener al menos 6 caracteres.");
                return false;
            }
            if (cmbRol.SelectedValue == null)
            {
                Ui.Aviso("Seleccione el rol.");
                return false;
            }
            if (cmbEstado.SelectedItem == null)
            {
                Ui.Aviso("Seleccione el estado.");
                return false;
            }
            if (!radNadie.Checked && cmbPersona.SelectedValue == null)
            {
                Ui.Aviso("Seleccione la persona a la que se vincula el usuario, o marque \"Nadie\".");
                return false;
            }

            // Un usuario Médico o Paciente debe estar vinculado a su ficha (el sistema la usa al iniciar sesión)
            string rol = ((DataRowView)cmbRol.SelectedItem)["Nombre"].ToString();
            if (rol == "Medico" && !radMedico.Checked)
            {
                Ui.Aviso("Un usuario con rol Médico debe vincularse a un médico.");
                return false;
            }
            if (rol == "Paciente" && !radPaciente.Checked)
            {
                Ui.Aviso("Un usuario con rol Paciente debe vincularse a un paciente.");
                return false;
            }

            // Protección: no se puede quitar el acceso a uno mismo
            if (!esNuevo && idSeleccionado == Sesion.IdUsuario &&
                (cmbEstado.SelectedItem.ToString() != "Activo" || rol != Sesion.Rol))
            {
                Ui.Aviso("No puede desactivar su propio usuario ni cambiar su propio rol.");
                return false;
            }
            return true;
        }
    }
}
