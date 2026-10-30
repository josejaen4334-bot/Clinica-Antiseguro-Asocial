using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Parcial_2_Jose_Jaen_1GS124
{
    public partial class Registro_Clientes : Form
    {
        public Registro_Clientes()
        {
            InitializeComponent();
            // primera parte de labels
            lblRegistro.Text = "Registro de Clientes";
            lblNombreUsuario.Text = "Nombre: ";
            lblApellidoUsuario.Text = "Apellido: ";
            lblCedulaUsuario.Text = "Cédula: ";
            lblTelefonoUsuario.Text = "Teléfono: ";
            lblCorreoUsuario.Text = "Correo: ";
            lblFechaNacimientoUsuario.Text = "Fecha de Nacimiento: ";
            lblGeneroUsuaruio.Text = "Género: ";
            lblCategoriaCliente.Text = "Categoría de Cliente";
            lblPreferenciasServicios.Text = "Preferencias / Servicios";
            lblNumeroConsultas.Text = "Número de Consultas";
            //primera parte textBoxs
            txtBoxNombreUsaurio.Text = "Ingrese su nombre...";
            txtBoxApellidoUsuario.Text = "Ingrese su apellido...";
            txtBoxCedulaUsuario.Text = "Ingrese su cédula...";
            txtBoxTelefonoUsuario.Text = "Ingrese su teléfono...";
            txtBoxCorreoUsuario.Text = "Ingrese su correo...";
            //imagenes del Usuario
            // labels
            lblVerNombreUsuario.Text = "Nombre: ";
            lblVerCedulaUsuario.Text = "Cédula: ";
            lblVerCategoriaUsuario.Text = "Categoría: ";
            lblMostrarNombreUsuario.Text = "Nombre del usuario...";
            lblMostrarCedulaUsuario.Text = "Cédula del usuario...";
            lblMostrarCategoriaUsuario.Text = "Categoría del usuario...";
            lblSeleccionarUsuario.Text = "Seleccione un usuario";
            btnAgregarImagen.Text = "Agg Imagen";
            //lbl de la parte del grid
            lblTotalUsuarios.Text = "Total de Usuarios Registrados: ";
        }

        //funcion para actualizar el contador de usuarios registrados en el Grid 
        private void ActualizarContador()
        {
            int totalUsuarios = dtGridViewDatosUsuarios.Rows.Count - 1;
            lblTotalUsuarios.Text = $"Usuarios Registrados: {totalUsuarios}";
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void rfdBtnOpcionEmpresarial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNombreUsaurio_TextChanged(object sender, EventArgs e)
        {
            //si el boton de texto es mayor a 0, se habilita el boton de registrar, de lo contrario se deshabilita
            if (txtBoxNombreUsaurio.Text.Trim().Length > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void lblVerNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroConsultas_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoriaCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCedulaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si el caracter ingresado no es un numero, ni un guion, no dejara ingresar un caracter
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtBoxApellidoUsuario_TextChanged(object sender, EventArgs e)
        {
            //si el boton de texto es mayor a 0, se habilita el boton de registrar, de lo contrario se deshabilita
            if (txtBoxApellidoUsuario.Text.Trim().Length > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtBoxTelefonoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTelefonoUsuario.Text.Trim().Length > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtBoxTelefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtBoxCedulaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCedulaUsuario.Text.Trim().Length > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtBoxCorreoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCorreoUsuario.Text.Trim().Length > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void rdBtnOpcionMasculino_Keypress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validaremos que ningun campo este vacio, si esta vacio mostraremos un mensaje de error
            if (string.IsNullOrWhiteSpace(txtBoxNombreUsaurio.Text) ||
                string.IsNullOrWhiteSpace(txtBoxApellidoUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCedulaUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtBoxTelefonoUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCorreoUsuario.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            //validar fecha de ncimiento, si es mayor a la fecha actual, mostrar un mensaje de error
            if (dtTmPckrFechaNacimiento.Value > DateTime.Now || dtTmPckrFechaNacimiento.Value < DateTime.Now.AddYears(-110))
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual o menor a 110 años.");
                return;
            }

            //validar que el genero no este vacio
            if (cmbBoxGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un género.");
                return;
            }

            //validar los radio buttons, si ninguno esta seleccionado , mostrar un mensaje de error
            string categoria = "";
            if (rdBtnOpcionParticular.Checked)
            {
                lblMostrarCategoriaUsuario.Text = "Particular";
                categoria = "Particular";
            }
            else if (rdBtnOpcionEmpresarial.Checked)
            {
                lblMostrarCategoriaUsuario.Text = "Empresarial";
                categoria = "Empresarial";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría de cliente.");
                return;
            }

            //obtener los servicios / categorias seleccionados
            string servicios = "";
            if (chckBoxOpcionConsulta.Checked) servicios += "Consulta general, ";
            if (chckBoxOpcionLaboratorio.Checked) servicios += "Odontología, ";
            if (chckBoxOpcionOdontologia.Checked) servicios += "Radiología, ";

            if (servicios.Length > 0)
            {
                servicios = servicios.TrimEnd(',', ',', ' ');
            }
            else
            {
                servicios = "Ninguno";
            }

            //guardar los datos en el Data Grid View
            string nombre = txtBoxNombreUsaurio.Text.Trim();
            string apellido = txtBoxApellidoUsuario.Text.Trim();
            string cedula = txtBoxCedulaUsuario.Text.Trim();
            string telefono = txtBoxTelefonoUsuario.Text.Trim();
            string correo = txtBoxCorreoUsuario.Text.Trim();
            string fechaNacimiento = dtTmPckrFechaNacimiento.Value.ToShortDateString();
            string genero = cmbBoxGenero.SelectedItem.ToString();
            int numConsultas = (int)nmrcUpDownNumeroConsultas.Value;

            //agregar los datos al Data Grid View
            dtGridViewDatosUsuarios.Rows.Add(nombre, apellido, cedula, telefono, correo, fechaNacimiento, genero, categoria, servicios, numConsultas, rutaImagenTemporal);
            cmbBoxSeleccionarUsuario.Items.Add(nombre + " " + apellido);
            rutaImagenTemporal = "";

            MessageBox.Show("Usuario registrado de forma exitosa");

            ActualizarContador();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //validar que se haya seleccionado una fila en el Data Grid View
            if (dtGridViewDatosUsuarios.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el usuario seleccionado?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //si el usuario selecciona "Sí", eliminar la fila seleccionada
                if (result == DialogResult.Yes)
                {

                    dtGridViewDatosUsuarios.Rows.RemoveAt(dtGridViewDatosUsuarios.SelectedRows[0].Index);
                    MessageBox.Show("Usuario eliminado de forma exitosa");
                }
                //si el usuario selecciona "No", mostrar un mensaje de cancelación
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Eliminación cancelada");
                }
                else
                {
                    MessageBox.Show("Si desea eliminar a un usuario, por favor seleccione a un cliente de la lista para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ActualizarContador();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxNombreUsaurio.Clear();
            txtBoxApellidoUsuario.Clear();
            txtBoxCedulaUsuario.Clear();
            txtBoxTelefonoUsuario.Clear();
            txtBoxCorreoUsuario.Clear();
            dtTmPckrFechaNacimiento.ResetText();
            cmbBoxGenero.SelectedIndex = -1;

            if (rdBtnOpcionParticular.Checked)
            {
                rdBtnOpcionParticular.Checked = false;
            }
            else if (rdBtnOpcionEmpresarial.Checked)
            {
                rdBtnOpcionEmpresarial.Checked = false;
            }

            chckBoxOpcionConsulta.Checked = false;
            chckBoxOpcionLaboratorio.Checked = false;
            chckBoxOpcionOdontologia.Checked = false;

            nmrcUpDownNumeroConsultas.Value = 0;
        }

        private void cmbBoxSeleccionarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxSeleccionarUsuario.SelectedIndex >= 0)
            {
                int indexSeleccionado = cmbBoxSeleccionarUsuario.SelectedIndex;

                if (indexSeleccionado < dtGridViewDatosUsuarios.Rows.Count - 1)
                {
                    // Extraer la fila correspondiente de la tabla
                    DataGridViewRow fila = dtGridViewDatosUsuarios.Rows[indexSeleccionado];

                    // Mostrar los datos 
                    lblMostrarNombreUsuario.Text = fila.Cells[0].Value.ToString() + " " + fila.Cells[1].Value.ToString(); //  Nombre y apellido
                    lblMostrarCedulaUsuario.Text = fila.Cells[2].Value.ToString();  //  Cédula
                    lblMostrarCategoriaUsuario.Text = fila.Cells[7].Value.ToString(); //  Categoría/Servicios
                    //mostrar la imagen del usuario gardada
                    string rutaImagen = fila.Cells[9].Value?.ToString();

                    //verificamos que la ruta de la imagen exista
                    if (!string.IsNullOrEmpty(rutaImagen) && System.IO.File.Exists(rutaImagen))
                    {
                        pctrBoxUsuario.Image = Image.FromFile(rutaImagen);
                    }
                }
            }
        }

        private void dtGridViewDatosUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Finanzas finanzasForm = new Finanzas(this);
            finanzasForm.Show();
            this.Hide();
        }

        private void dtTmPckrFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string rutaImagenTemporal = "";
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (svFilesDialogs.ShowDialog() == DialogResult.OK)
            {
                pctrBoxUsuario.Image = Image.FromFile(svFilesDialogs.FileName);
                rutaImagenTemporal = svFilesDialogs.FileName;
            }
        }

        private void cmbBoxSeleccionarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void dtGridViewDatosUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void svFilesDialogs_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}