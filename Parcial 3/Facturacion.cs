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
    public partial class frmFacturacion : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private bool cargando = false; // evita llenar los campos mientras se carga la tabla
        private Button btnGuardarFactura;

        public frmFacturacion()
        {
            InitializeComponent();

            // Los datos del paciente son solo para mostrar
            radMasculino.AutoCheck = false;
            radFemenino.AutoCheck = false;

            Ui.Placeholder(txtBuscar);
            Ui.ConfigurarGrid(dgvRegistroPacientes);
            Ui.ConfigurarGrid(dgvDetalles);

            // Servicios: solo se marca la casilla "Seleccionar"
            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.RowHeadersVisible = false;
            dgvServicios.Columns["Precio"].ReadOnly = true;
            dgvServicios.Columns["Precio"].DefaultCellStyle.Format = "N2";

            cmbPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia", "Yappy", "Seguro" });
            grpDetalles.Text = grpDetalles.Text + " (Supr para quitar una línea)";

            CrearBotonGuardar();

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmFacturacion_Load;
            btnBuscar.Click += btnBuscar_Click;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            dgvRegistroPacientes.SelectionChanged += dgvRegistroPacientes_SelectionChanged;
            btnBuscarServicio.Click += btnBuscarServicio_Click;
            txtServicio.KeyDown += txtServicio_KeyDown;
            btnAgregar.Click += btnAgregar_Click;
            dgvDetalles.KeyDown += dgvDetalles_KeyDown;
        }

        // El diseño no trae un botón para guardar la factura. Si algún día lo agregan en el Designer
        // con el nombre "btnGuardarFactura" se usa ese; si no, se crea aquí debajo del total.
        private void CrearBotonGuardar()
        {
            Control[] existente = this.Controls.Find("btnGuardarFactura", true);
            btnGuardarFactura = existente.Length > 0 ? existente[0] as Button : null;

            if (btnGuardarFactura == null)
            {
                btnGuardarFactura = new Button();
                btnGuardarFactura.Name = "btnGuardarFactura";
                btnGuardarFactura.Text = "Guardar Factura";
                btnGuardarFactura.Location = new Point(84, 352);
                btnGuardarFactura.Size = new Size(360, 40);
                // Mismo estilo que el botón "+ Agregar"
                btnGuardarFactura.Font = btnAgregar.Font;
                btnGuardarFactura.FlatStyle = btnAgregar.FlatStyle;
                btnGuardarFactura.FlatAppearance.BorderSize = btnAgregar.FlatAppearance.BorderSize;
                btnGuardarFactura.BackColor = btnAgregar.BackColor;
                btnGuardarFactura.ForeColor = btnAgregar.ForeColor;
                btnGuardarFactura.UseVisualStyleBackColor = false;
                grpFactura.Controls.Add(btnGuardarFactura);
            }
            btnGuardarFactura.Click += btnGuardarFactura_Click;
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                Ui.LlenarCombo(cmbMedico, datos.ListarMedicosCombo(), "Nombre", "IdMedico");

                // Servicios con sus precios, tomados de la BD
                dgvServicios.Rows.Clear();
                foreach (DataRow s in datos.ListarServicios().Rows)
                    dgvServicios.Rows.Add(s["Descripcion"], Convert.ToDecimal(s["Precio"]), false);
                dgvServicios.ClearSelection();
            }
            catch (Exception ex) { Ui.Error(ex); }

            CargarPacientes("");
            ActualizarTotal();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
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

        private void dgvRegistroPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando || dgvRegistroPacientes.SelectedRows.Count == 0) return;

            DataGridViewRow f = dgvRegistroPacientes.SelectedRows[0];
            DateTime nacimiento = Convert.ToDateTime(f.Cells["FechaNacimiento"].Value);
            int edad = DateTime.Today.Year - nacimiento.Year;
            if (nacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;

            txtIDPaciente.Text = Convert.ToString(f.Cells["IdPaciente"].Value);
            txtCedula.Text = Convert.ToString(f.Cells["Cedula"].Value);
            txtNombre.Text = Convert.ToString(f.Cells["Nombre"].Value);
            txtApellido.Text = Convert.ToString(f.Cells["Apellido"].Value);
            radMasculino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Masculino";
            radFemenino.Checked = Convert.ToString(f.Cells["Genero"].Value) == "Femenino";
            txtTipoSangre.Text = Convert.ToString(f.Cells["TipoSangre"].Value);
            txtEdad.Text = edad.ToString();
        }

        // ---------- Servicios ----------

        // Filtra la lista de servicios por lo escrito (oculta las filas que no coinciden)
        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            string texto = txtServicio.Text.Trim().ToLower();
            dgvServicios.CurrentCell = null; // no se puede ocultar la fila activa

            foreach (DataGridViewRow fila in dgvServicios.Rows)
                fila.Visible = texto == "" ||
                    Convert.ToString(fila.Cells["Descripcion"].Value).ToLower().Contains(texto);
        }

        private void txtServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscarServicio_Click(sender, e);
            }
        }

        // Pasa los servicios marcados al detalle de la factura
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvServicios.EndEdit();
            int agregados = 0;

            foreach (DataGridViewRow s in dgvServicios.Rows)
            {
                if (!Convert.ToBoolean(s.Cells["Seleccionar"].Value ?? false)) continue;

                string servicio = Convert.ToString(s.Cells["Descripcion"].Value);
                decimal precio = Convert.ToDecimal(s.Cells["Precio"].Value);

                // Si el servicio ya está en el detalle solo se suma una unidad
                DataGridViewRow existente = null;
                foreach (DataGridViewRow d in dgvDetalles.Rows)
                    if (Convert.ToString(d.Cells[0].Value) == servicio) { existente = d; break; }

                if (existente != null)
                {
                    int cant = Convert.ToInt32(existente.Cells[2].Value) + 1;
                    existente.Cells[2].Value = cant;
                    existente.Cells[3].Value = precio * cant;
                }
                else
                {
                    dgvDetalles.Rows.Add(servicio, precio, 1, precio);
                }

                s.Cells["Seleccionar"].Value = false; // se desmarca después de agregarlo
                agregados++;
            }

            if (agregados == 0) Ui.Aviso("Marque al menos un servicio en la casilla \"Seleccionar\".");
            ActualizarTotal();
        }

        // Con la tecla Supr se quita la línea seleccionada del detalle
        private void dgvDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvDetalles.CurrentRow != null && !dgvDetalles.CurrentRow.IsNewRow)
            {
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow d in dgvDetalles.Rows)
                total += Convert.ToDecimal(d.Cells[3].Value);
            lablTotalNumero.Text = "B/. " + total.ToString("N2");
        }

        // ---------- Guardar la factura ----------

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text == "")
            {
                Ui.Aviso("Primero seleccione el paciente al que se le va a facturar.");
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                Ui.Aviso("Agregue al menos un servicio al detalle de la factura.");
                return;
            }

            // Si se eligió médico, se anota en las líneas de consulta
            string medico = cmbMedico.SelectedItem != null ? ((DataRowView)cmbMedico.SelectedItem)["Nombre"].ToString() : "";

            List<object[]> lineas = new List<object[]>();
            foreach (DataGridViewRow d in dgvDetalles.Rows)
            {
                string concepto = Convert.ToString(d.Cells[0].Value);
                if (medico != "" && concepto.StartsWith("Consulta")) concepto += " (" + medico + ")";
                lineas.Add(new object[] { concepto, Convert.ToInt32(d.Cells[2].Value), Convert.ToDecimal(d.Cells[1].Value) });
            }

            string metodo = cmbPago.SelectedItem != null ? cmbPago.SelectedItem.ToString() : null;
            string estado = metodo == null ? "Pendiente" : "Pagada";

            if (!Ui.Confirmar("¿Guardar la factura de " + txtNombre.Text + " " + txtApellido.Text + " por " +
                lablTotalNumero.Text + "?\n\nQuedará como " + estado + "."))
                return;

            try
            {
                int id = datos.GuardarFactura(int.Parse(txtIDPaciente.Text), dtpFechaFactura.Value, metodo, lineas);
                datos.Bitacora("Facturacion", "INSERTAR", "Factura FAC-" + id.ToString("D6") + " emitida");
                Ui.Info("Factura FAC-" + id.ToString("D6") + " guardada correctamente (" + estado + ").");

                // Se deja el formulario listo para otra factura
                dgvDetalles.Rows.Clear();
                cmbPago.SelectedIndex = -1;
                cmbMedico.SelectedIndex = -1;
                ActualizarTotal();
            }
            catch (Exception ex) { Ui.Error(ex); }
        }
    }
}
