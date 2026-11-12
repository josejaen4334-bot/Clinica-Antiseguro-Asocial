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
    public partial class frmMedicos : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private bool cargando = false; // evita llenar los campos mientras se carga la tabla

        public frmMedicos()
        {
            InitializeComponent();

            // El ID lo genera la BD solo
            txtIDMedico.ReadOnly = true;
            Ui.ConfigurarGrid(dgvRegistro);
            Ui.Placeholder(txtBuscar);

            // Estados permitidos por la BD
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo", "Vacaciones", "Licencia" });
            cmbEstado.SelectedIndex = 0;

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmMedicos_Load;
            btnRegistrar.Click += btnRegistrar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            dgvRegistro.SelectionChanged += dgvRegistro_SelectionChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            picFoto.Click += picFoto_Click;
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            try
            {
                // Las especialidades salen de la tabla Especialidades
                Ui.LlenarCombo(cmbEspecialidad, datos.ListarEspecialidades(), "Nombre", "IdEspecialidad");
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
                Ui.Enlazar(dgvRegistro, datos.ListarMedicos(filtro), "IdEspecialidad");
            }
            catch (Exception ex) { Ui.Error(ex); }
            finally { cargando = false; }
        }

        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando || dgvRegistro.SelectedRows.Count == 0) return;

            DataGridViewRow f = dgvRegistro.SelectedRows[0];
            txtIDMedico.Text = Convert.ToString(f.Cells["IdMedico"].Value);
            txtCedula.Text = Convert.ToString(f.Cells["Cedula"].Value);
            txtNombre.Text = Convert.ToString(f.Cells["Nombre"].Value);
            txtApellido.Text = Convert.ToString(f.Cells["Apellido"].Value);
            radMasculino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Masculino";
            radFemenino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Femenino";
            dtpContratacion.Value = Convert.ToDateTime(f.Cells["FechaContratacion"].Value);
            txtTelefono.Text = Convert.ToString(f.Cells["Telefono"].Value);
            txtCorreo.Text = Convert.ToString(f.Cells["Correo"].Value);
            textBox1.Text = Convert.ToString(f.Cells["Licencia"].Value); // textBox1 = licencia
            cmbEspecialidad.SelectedValue = Convert.ToInt32(f.Cells["IdEspecialidad"].Value);
            cmbEstado.SelectedItem = Convert.ToString(f.Cells["Estado"].Value);
        }

        // ---------- Botones ----------

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;

            try
            {
                datos.GuardarMedico(txtCedula.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                    Genero(), dtpContratacion.Value, txtTelefono.Text.Trim(), txtCorreo.Text.Trim(),
                    textBox1.Text.Trim(), Convert.ToInt32(cmbEspecialidad.SelectedValue),
                    cmbEstado.SelectedItem.ToString());

                datos.Bitacora("Medicos", "INSERTAR", "Se registró el médico " + txtCedula.Text.Trim());
                Ui.Info("Médico registrado correctamente.");
                Limpiar();
                CargarTabla("");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDMedico.Text == "")
            {
                Ui.Aviso("Primero seleccione un médico de la tabla.");
                return;
            }
            if (!DatosValidos()) return;

            try
            {
                datos.ActualizarMedico(int.Parse(txtIDMedico.Text), txtCedula.Text.Trim(),
                    txtNombre.Text.Trim(), txtApellido.Text.Trim(), Genero(), dtpContratacion.Value,
                    txtTelefono.Text.Trim(), txtCorreo.Text.Trim(), textBox1.Text.Trim(),
                    Convert.ToInt32(cmbEspecialidad.SelectedValue), cmbEstado.SelectedItem.ToString());

                datos.Bitacora("Medicos", "ACTUALIZAR", "Se actualizó el médico " + txtCedula.Text.Trim());
                Ui.Info("Médico actualizado correctamente.");
                Limpiar();
                CargarTabla("");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDMedico.Text == "")
            {
                Ui.Aviso("Primero seleccione un médico de la tabla.");
                return;
            }
            if (!Ui.Confirmar("¿Desea eliminar al médico " + txtNombre.Text + " " + txtApellido.Text + "?"))
                return;

            try
            {
                // No se borra de la BD: pasa a estado Inactivo para conservar sus citas y consultas
                datos.DesactivarMedico(int.Parse(txtIDMedico.Text));
                datos.Bitacora("Medicos", "ELIMINAR", "Se eliminó (inactivó) el médico " + txtCedula.Text.Trim());
                Ui.Info("Médico eliminado correctamente (quedó como Inactivo).");
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
            if (dgvRegistro.Rows.Count == 0) Ui.Info("No se encontraron médicos con ese dato.");
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

        // La BD no tiene columna para la foto, así que solo se muestra como vista previa
        private void picFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    picFoto.Image = Image.FromFile(dlg.FileName);
                }
            }
        }

        // ---------- Apoyo ----------

        private string Genero()
        {
            return radMasculino.Checked ? "M" : "F";
        }

        private void Limpiar()
        {
            txtIDMedico.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            radMasculino.Checked = false;
            radFemenino.Checked = false;
            dtpContratacion.Value = DateTime.Today;
            txtTelefono.Clear();
            txtCorreo.Clear();
            textBox1.Clear();
            cmbEspecialidad.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;
            dgvRegistro.ClearSelection();
            txtCedula.Focus();
        }

        private bool DatosValidos()
        {
            if (txtCedula.Text.Trim() == "" || txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" || textBox1.Text.Trim() == "")
            {
                Ui.Aviso("La cédula, el nombre, el apellido y la licencia son obligatorios.");
                return false;
            }
            if (!radMasculino.Checked && !radFemenino.Checked)
            {
                Ui.Aviso("Seleccione el género del médico.");
                return false;
            }
            if (cmbEspecialidad.SelectedValue == null)
            {
                Ui.Aviso("Seleccione la especialidad.");
                return false;
            }
            if (cmbEstado.SelectedItem == null)
            {
                Ui.Aviso("Seleccione el estado del médico.");
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
