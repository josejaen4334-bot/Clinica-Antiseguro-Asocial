using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parcial_2_Jose_Jaen_1GS124
{
    public partial class Finanzas : Form
    {
        private Registro_Clientes registro_Clientes;
        public Finanzas(Registro_Clientes registro_Clientes)
        {
            InitializeComponent();
            registro_Clientes = new Registro_Clientes();
            this.registro_Clientes = registro_Clientes;
        }

        //agregar datos predeterminados al comboBox de usuarios en el formulario de ventas
        private void form_Ventas_Load(object sender, EventArgs e)
        {
            cmbBoxSeleccionarServicio.Items.Add("Consulta General");
            cmbBoxSeleccionarServicio.Items.Add("Odontología");
            cmbBoxSeleccionarServicio.Items.Add("Laboratorio");

            cmbBoxUsuariosVentas.SelectedIndex = -1;
            cmbBoxSeleccionarServicio.SelectedIndex = -1;

            txtBoxCategoriaUsuario.Text = "";
            nmrcUpDownCantidad.Value = 1;

            lblSubtotal.Text = "0.00";
            lblITBMS.Text = "0.00";
            lblDescuento.Text = "0.00";
            lblTotal.Text = "0.00";

            foreach (DataGridViewRow fila in registro_Clientes.dtGridViewDatosUsuarios.Rows)
            {
                // Evitamos la fila vacía del asterisco al final
                if (!fila.IsNewRow)
                {
                    string nombreCompleto = fila.Cells[0].Value.ToString() + " " + fila.Cells[1].Value.ToString();
                    cmbBoxUsuariosVentas.Items.Add(nombreCompleto);
                }
            }


        }

        private void cmbBoxUsuariosVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxUsuariosVentas.SelectedIndex == -1)
            {
                txtBoxCategoriaUsuario.Text = "";
                return;
            }

            DataGridViewRow fila = registro_Clientes.dtGridViewDatosUsuarios.Rows[cmbBoxUsuariosVentas.SelectedIndex];
            txtBoxCategoriaUsuario.Text = fila.Cells[7].Value.ToString();
        }

        private void cmbBoxSeleccionarServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxSeleccionarServicio.SelectedIndex != -1)
            {
                MessageBox.Show("Servicio seleccionado: " + cmbBoxSeleccionarServicio.Text);
            }
        }

        private void calcularTotal()
        {
            double subtotal = 0;

            foreach (string item in lstBoxResumenVenta.Items)
            {
                string[] lista = item.Split('-');

                string precioTexto = lista[1].Trim().Replace("B/", "");

                double precio;

                if (double.TryParse(precioTexto, out precio))
                {
                    subtotal += precio;
                }
            }

            double ITBMS = subtotal * 0.07;

            double descuento = 0;

            if (txtBoxCategoriaUsuario.Text == "Empresarial")
            {
                descuento = subtotal * 0.10;
            }

            double total = subtotal + ITBMS - descuento;

            lblSubtotal.Text = "B/. " + subtotal.ToString("0.00");
            lblITBMS.Text = "B/. " + ITBMS.ToString("0.00");
            lblDescuento.Text = "B/. " + descuento.ToString("0.00");
            lblTotal.Text = "B/. " + total.ToString("0.00");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbBoxUsuariosVentas.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un usuario antes de agregar un servicio.");
                return;
            }

            if (cmbBoxSeleccionarServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un servicio antes de agregarlo.");
                return;
            }

            int cantidad = (int)nmrcUpDownCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            double precio = 0;

            if (cmbBoxSeleccionarServicio.Text == "Consulta General")
            {
                precio = 50.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Odontología")
            {
                precio = 100.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Laboratorio")
            {
                precio = 75.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Pediatría")
            {
                precio = 25.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Cardiología")
            {
                precio = 50.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Dermatología")
            {
                precio = 40.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Oftalmología")
            {
                precio = 35.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Nutrición y Dietética")
            {
                precio = 20.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Fisioterapia y Rehabilitación")
            {
                precio = 30.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Ginecología")
            {
                precio = 45.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Psicología Clínica")
            {
                precio = 35.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Ortopedia")
            {
                precio = 50.00;
            }
            else if (cmbBoxSeleccionarServicio.Text == "Medicina General de Urgencias")
            {
                precio = 20.00;
            }

            double subtotal = precio * cantidad;

            lstBoxResumenVenta.Items.Add(cmbBoxSeleccionarServicio.Text + " x" + cantidad + " - B/" + subtotal.ToString("0.00"));

            calcularTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (lstBoxResumenVenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una venta para eliminar.");
                return;
            }

            lstBoxResumenVenta.Items.RemoveAt(
                lstBoxResumenVenta.SelectedIndex
            );

            calcularTotal();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstBoxResumenVenta.Items.Clear();

            cmbBoxUsuariosVentas.SelectedIndex = -1;
            cmbBoxSeleccionarServicio.SelectedIndex = -1;

            txtBoxCategoriaUsuario.Clear();

            nmrcUpDownCantidad.Value = 1;

            lblSubtotal.Text = "B/. 0.00";
            lblITBMS.Text = "B/. 0.00";
            lblDescuento.Text = "B/. 0.00";
            lblTotal.Text = "B/. 0.00";
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (cmbBoxUsuariosVentas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (lstBoxResumenVenta.Items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un servicio.");
                return;
            }

            MessageBox.Show("Venta registrada correctamente.\n\n" + "Cliente: " + cmbBoxUsuariosVentas.Text + "\n" + "Total: " + lblTotal.Text
            );
        }

        private void txtBoxObservacion_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxObservacion.Text.Length > 100)
            {
                MessageBox.Show("La observación no puede superar los 100 caracteres.");
                txtBoxObservacion.Text = txtBoxObservacion.Text.Substring(0, 100);

                txtBoxObservacion.SelectionStart = txtBoxObservacion.Text.Length;
            }
        }

        private void btnRegistrarVenta_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarVenta.BackColor = Color.LightSeaGreen;
        }

        private void btnRegistrarVenta_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarVenta.BackColor = Color.White;
        }

        private void chckBoxConsultaGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxConsultaGeneral.Checked)
            {
                cmbBoxSeleccionarServicio.SelectedItem = "Consulta General";
            }
        }

        private void chckBoxOdontologia_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxOdontologia.Checked)
            {
                cmbBoxSeleccionarServicio.SelectedItem = "Odontología";
            }
        }

        private void chckBoxLaboratorio_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxLaboratorio.Checked)
            {
                cmbBoxSeleccionarServicio.SelectedItem = "Laboratorio";
            }
        }

        private void cmbBoxSeleccionarServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}