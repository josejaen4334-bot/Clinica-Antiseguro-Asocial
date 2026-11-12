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
    public partial class frmEmpleados : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private bool cargando = false; // evita llenar los campos mientras se carga la tabla

        public frmEmpleados()
        {
            InitializeComponent();

            // El ID lo genera la BD solo
            txtIDEmpleado.ReadOnly = true;
            Ui.ConfigurarGrid(dgvRegistro);
            Ui.Placeholder(txtBuscar);

            // Estados permitidos por la BD
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo", "Vacaciones", "Licencia" });
            cmbEstado.SelectedIndex = 0;

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmEmpleados_Load;
            btnRegistrar.Click += btnRegistrar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            dgvRegistro.SelectionChanged += dgvRegistro_SelectionChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                // Los cargos salen de la tabla Cargos
                Ui.LlenarCombo(cmbCargo, datos.ListarCargos(), "Nombre", "IdCargo");
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

        // ---------- Tabla ----------

        private void CargarTabla(string filtro)
        {
            try
            {
                cargando = true;
                Ui.Enlazar(dgvRegistro, datos.ListarEmpleados(filtro), "IdCargo");
            }
            catch (Exception ex) { Ui.Error(ex); }
            finally { cargando = false; }
        }

        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando || dgvRegistro.SelectedRows.Count == 0) return;

            DataGridViewRow f = dgvRegistro.SelectedRows[0];
            txtIDEmpleado.Text = Convert.ToString(f.Cells["IdEmpleado"].Value);
            txtCedula.Text = Convert.ToString(f.Cells["Cedula"].Value);
            txtNombre.Text = Convert.ToString(f.Cells["Nombre"].Value);
            txtApellido.Text = Convert.ToString(f.Cells["Apellido"].Value);
            radMasculino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Masculino";
            radFemenino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Femenino";
            dtpContratacion.Value = Convert.ToDateTime(f.Cells["FechaContratacion"].Value);
            txtTelefono.Text = Convert.ToString(f.Cells["Telefono"].Value);
            txtCorreo.Text = Convert.ToString(f.Cells["Correo"].Value);
            cmbCargo.SelectedValue = Convert.ToInt32(f.Cells["IdCargo"].Value);
            cmbEstado.SelectedItem = Convert.ToString(f.Cells["Estado"].Value);
        }

        // ---------- Botones ----------

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;

            try
            {
                datos.GuardarEmpleado(txtCedula.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                    Genero(), dtpContratacion.Value, txtTelefono.Text.Trim(), txtCorreo.Text.Trim(),
                    Convert.ToInt32(cmbCargo.SelectedValue), cmbEstado.SelectedItem.ToString());

                datos.Bitacora("Empleados", "INSERTAR", "Se registró el empleado " + txtCedula.Text.Trim());
                Ui.Info("Empleado registrado correctamente.");
                Limpiar();
                CargarTabla("");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDEmpleado.Text == "")
            {
                Ui.Aviso("Primero seleccione un empleado de la tabla.");
                return;
            }
            if (!DatosValidos()) return;

            try
            {
                datos.ActualizarEmpleado(int.Parse(txtIDEmpleado.Text), txtCedula.Text.Trim(),
                    txtNombre.Text.Trim(), txtApellido.Text.Trim(), Genero(), dtpContratacion.Value,
                    txtTelefono.Text.Trim(), txtCorreo.Text.Trim(),
                    Convert.ToInt32(cmbCargo.SelectedValue), cmbEstado.SelectedItem.ToString());

                datos.Bitacora("Empleados", "ACTUALIZAR", "Se actualizó el empleado " + txtCedula.Text.Trim());
                Ui.Info("Empleado actualizado correctamente.");
                Limpiar();
                CargarTabla("");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDEmpleado.Text == "")
            {
                Ui.Aviso("Primero seleccione un empleado de la tabla.");
                return;
            }
            if (!Ui.Confirmar("¿Desea eliminar al empleado " + txtNombre.Text + " " + txtApellido.Text + "?"))
                return;

            try
            {
                // No se borra de la BD: pasa a estado Inactivo (puede tener usuarios y facturas ligadas)
                datos.DesactivarEmpleado(int.Parse(txtIDEmpleado.Text));
                datos.Bitacora("Empleados", "ELIMINAR", "Se eliminó (inactivó) el empleado " + txtCedula.Text.Trim());
                Ui.Info("Empleado eliminado correctamente (quedó como Inactivo).");
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
            CargarTabla(Ui.Escrito(txtBuscar));
            if (dgvRegistro.Rows.Count == 0) Ui.Info("No se encontraron empleados con ese dato.");
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
            txtIDEmpleado.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            radMasculino.Checked = false;
            radFemenino.Checked = false;
            dtpContratacion.Value = DateTime.Today;
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;
            dgvRegistro.ClearSelection();
            txtCedula.Focus();
        }

        private bool DatosValidos()
        {
            if (txtCedula.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "")
            {
                Ui.Aviso("La cédula, el nombre y el apellido son obligatorios.");
                return false;
            }
            if (!radMasculino.Checked && !radFemenino.Checked)
            {
                Ui.Aviso("Seleccione el género del empleado.");
                return false;
            }
            if (cmbCargo.SelectedValue == null)
            {
                Ui.Aviso("Seleccione el cargo.");
                return false;
            }
            if (cmbEstado.SelectedItem == null)
            {
                Ui.Aviso("Seleccione el estado del empleado.");
                return false;
            }
            if (dtpContratacion.Value.Date > DateTime.Today)
            {
                Ui.Aviso("La fecha de contratación no puede ser futura.");
                return false;
            }
            if (!Ui.CorreoValido(txtCorreo.Text))
            {
                Ui.Aviso("El correo no tiene un formato válido.");
                return false;
            }
            return true;
        }
    }
}
