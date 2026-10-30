namespace Parcial_2_Jose_Jaen_1GS124
{
    partial class Finanzas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finanzas));
            cmbBoxUsuariosVentas = new ComboBox();
            svFileDialogFinanzas = new SaveFileDialog();
            pctrBoxLogo = new PictureBox();
            pctrLinea = new PictureBox();
            lblFinanzas = new Label();
            grpBoxDatosVenta = new GroupBox();
            grpBoxTipoPago = new GroupBox();
            txtBoxObservacion = new TextBox();
            lblObservacion = new Label();
            rdButtonTarjeta = new RadioButton();
            rdButtonEfectivo = new RadioButton();
            grpBoxItemPrincipal = new GroupBox();
            btnAgregar = new Button();
            nmrcUpDownCantidad = new NumericUpDown();
            lblCantidad = new Label();
            cmbBoxSeleccionarServicio = new ComboBox();
            grpBpxProductoServicios = new GroupBox();
            chckBoxLaboratorio = new CheckBox();
            chckBoxOdontologia = new CheckBox();
            chckBoxConsultaGeneral = new CheckBox();
            txtBoxCategoriaUsuario = new TextBox();
            lblCategoria = new Label();
            lblCliente = new Label();
            grpBoxDetalleVenta = new GroupBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            lstBoxResumenVenta = new ListBox();
            grpBoxResumen = new GroupBox();
            btnRegistrarVenta = new Button();
            lblTotal = new Label();
            pictureBox1 = new PictureBox();
            lblDescuento = new Label();
            lblITBMS = new Label();
            lblSubtotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pctrBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrLinea).BeginInit();
            grpBoxDatosVenta.SuspendLayout();
            grpBoxTipoPago.SuspendLayout();
            grpBoxItemPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownCantidad).BeginInit();
            grpBpxProductoServicios.SuspendLayout();
            grpBoxDetalleVenta.SuspendLayout();
            grpBoxResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbBoxUsuariosVentas
            // 
            cmbBoxUsuariosVentas.FormattingEnabled = true;
            cmbBoxUsuariosVentas.Location = new Point(19, 77);
            cmbBoxUsuariosVentas.Name = "cmbBoxUsuariosVentas";
            cmbBoxUsuariosVentas.Size = new Size(448, 31);
            cmbBoxUsuariosVentas.TabIndex = 0;
            cmbBoxUsuariosVentas.SelectedIndexChanged += cmbBoxUsuariosVentas_SelectedIndexChanged;
            // 
            // svFileDialogFinanzas
            // 
            svFileDialogFinanzas.Filter = "|*.jpg;*.png;*.jpeg;*.bmp";
            // 
            // pctrBoxLogo
            // 
            pctrBoxLogo.Image = (Image)resources.GetObject("pctrBoxLogo.Image");
            pctrBoxLogo.Location = new Point(-1, 12);
            pctrBoxLogo.Name = "pctrBoxLogo";
            pctrBoxLogo.Size = new Size(206, 155);
            pctrBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctrBoxLogo.TabIndex = 1;
            pctrBoxLogo.TabStop = false;
            // 
            // pctrLinea
            // 
            pctrLinea.BackColor = Color.LightSeaGreen;
            pctrLinea.BorderStyle = BorderStyle.FixedSingle;
            pctrLinea.Location = new Point(185, 94);
            pctrLinea.Margin = new Padding(0);
            pctrLinea.Name = "pctrLinea";
            pctrLinea.Size = new Size(1139, 10);
            pctrLinea.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrLinea.TabIndex = 3;
            pctrLinea.TabStop = false;
            // 
            // lblFinanzas
            // 
            lblFinanzas.AutoSize = true;
            lblFinanzas.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold | FontStyle.Italic);
            lblFinanzas.ForeColor = Color.White;
            lblFinanzas.Location = new Point(591, 12);
            lblFinanzas.MaximumSize = new Size(857, 867);
            lblFinanzas.Name = "lblFinanzas";
            lblFinanzas.Size = new Size(230, 62);
            lblFinanzas.TabIndex = 4;
            lblFinanzas.Text = "Finanzas";
            // 
            // grpBoxDatosVenta
            // 
            grpBoxDatosVenta.Controls.Add(grpBoxTipoPago);
            grpBoxDatosVenta.Controls.Add(grpBoxItemPrincipal);
            grpBoxDatosVenta.Controls.Add(grpBpxProductoServicios);
            grpBoxDatosVenta.Controls.Add(txtBoxCategoriaUsuario);
            grpBoxDatosVenta.Controls.Add(lblCategoria);
            grpBoxDatosVenta.Controls.Add(lblCliente);
            grpBoxDatosVenta.Controls.Add(cmbBoxUsuariosVentas);
            grpBoxDatosVenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxDatosVenta.ForeColor = SystemColors.ControlLightLight;
            grpBoxDatosVenta.Location = new Point(26, 173);
            grpBoxDatosVenta.Name = "grpBoxDatosVenta";
            grpBoxDatosVenta.Size = new Size(754, 493);
            grpBoxDatosVenta.TabIndex = 5;
            grpBoxDatosVenta.TabStop = false;
            grpBoxDatosVenta.Text = "Datos de Venta";
            // 
            // grpBoxTipoPago
            // 
            grpBoxTipoPago.Controls.Add(txtBoxObservacion);
            grpBoxTipoPago.Controls.Add(lblObservacion);
            grpBoxTipoPago.Controls.Add(rdButtonTarjeta);
            grpBoxTipoPago.Controls.Add(rdButtonEfectivo);
            grpBoxTipoPago.ForeColor = Color.White;
            grpBoxTipoPago.Location = new Point(19, 362);
            grpBoxTipoPago.Name = "grpBoxTipoPago";
            grpBoxTipoPago.Size = new Size(718, 115);
            grpBoxTipoPago.TabIndex = 5;
            grpBoxTipoPago.TabStop = false;
            grpBoxTipoPago.Text = "Tipo de Pago";
            // 
            // txtBoxObservacion
            // 
            txtBoxObservacion.BorderStyle = BorderStyle.None;
            txtBoxObservacion.Location = new Point(213, 48);
            txtBoxObservacion.Multiline = true;
            txtBoxObservacion.Name = "txtBoxObservacion";
            txtBoxObservacion.Size = new Size(499, 61);
            txtBoxObservacion.TabIndex = 3;
            txtBoxObservacion.TextChanged += txtBoxObservacion_TextChanged;
            // 
            // lblObservacion
            // 
            lblObservacion.AutoSize = true;
            lblObservacion.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Italic);
            lblObservacion.Location = new Point(213, 26);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(88, 19);
            lblObservacion.TabIndex = 2;
            lblObservacion.Text = "Observacion";
            // 
            // rdButtonTarjeta
            // 
            rdButtonTarjeta.AutoSize = true;
            rdButtonTarjeta.Location = new Point(24, 71);
            rdButtonTarjeta.Name = "rdButtonTarjeta";
            rdButtonTarjeta.Size = new Size(87, 27);
            rdButtonTarjeta.TabIndex = 1;
            rdButtonTarjeta.TabStop = true;
            rdButtonTarjeta.Text = "Tarjeta";
            rdButtonTarjeta.UseVisualStyleBackColor = true;
            // 
            // rdButtonEfectivo
            // 
            rdButtonEfectivo.AutoSize = true;
            rdButtonEfectivo.Location = new Point(24, 38);
            rdButtonEfectivo.Name = "rdButtonEfectivo";
            rdButtonEfectivo.Size = new Size(93, 27);
            rdButtonEfectivo.TabIndex = 0;
            rdButtonEfectivo.TabStop = true;
            rdButtonEfectivo.Text = "Efectivo";
            rdButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // grpBoxItemPrincipal
            // 
            grpBoxItemPrincipal.BackColor = Color.Black;
            grpBoxItemPrincipal.Controls.Add(btnAgregar);
            grpBoxItemPrincipal.Controls.Add(nmrcUpDownCantidad);
            grpBoxItemPrincipal.Controls.Add(lblCantidad);
            grpBoxItemPrincipal.Controls.Add(cmbBoxSeleccionarServicio);
            grpBoxItemPrincipal.ForeColor = Color.WhiteSmoke;
            grpBoxItemPrincipal.Location = new Point(339, 135);
            grpBoxItemPrincipal.Name = "grpBoxItemPrincipal";
            grpBoxItemPrincipal.Size = new Size(398, 213);
            grpBoxItemPrincipal.TabIndex = 4;
            grpBoxItemPrincipal.TabStop = false;
            grpBoxItemPrincipal.Text = "Item Principal";
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(17, 162);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(360, 45);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nmrcUpDownCantidad
            // 
            nmrcUpDownCantidad.Location = new Point(17, 117);
            nmrcUpDownCantidad.Name = "nmrcUpDownCantidad";
            nmrcUpDownCantidad.Size = new Size(360, 30);
            nmrcUpDownCantidad.TabIndex = 3;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(17, 91);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(82, 23);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // cmbBoxSeleccionarServicio
            // 
            cmbBoxSeleccionarServicio.FormattingEnabled = true;
            cmbBoxSeleccionarServicio.Items.AddRange(new object[] { "cmbBoxSeleccionarServicio.Items.Add(\"Pediatría\");", "cmbBoxSeleccionarServicio.Items.Add(\"Cardiología\");", "cmbBoxSeleccionarServicio.Items.Add(\"Dermatología\");", "cmbBoxSeleccionarServicio.Items.Add(\"Oftalmología\");", "cmbBoxSeleccionarServicio.Items.Add(\"Nutrición y Dietética\");", "cmbBoxSeleccionarServicio.Items.Add(\"Fisioterapia y Rehabilitación\");", "cmbBoxSeleccionarServicio.Items.Add(\"Ginecología\");", "cmbBoxSeleccionarServicio.Items.Add(\"Psicología Clínica\");", "cmbBoxSeleccionarServicio.Items.Add(\"Ortopedia\");", "cmbBoxSeleccionarServicio.Items.Add(\"Medicina General de Urgencias\");" });
            cmbBoxSeleccionarServicio.Location = new Point(17, 38);
            cmbBoxSeleccionarServicio.Name = "cmbBoxSeleccionarServicio";
            cmbBoxSeleccionarServicio.Size = new Size(360, 31);
            cmbBoxSeleccionarServicio.TabIndex = 0;
            cmbBoxSeleccionarServicio.Text = "Seleccionar servicio";
            cmbBoxSeleccionarServicio.SelectedIndexChanged += cmbBoxSeleccionarServicio_SelectedIndexChanged;
            cmbBoxSeleccionarServicio.SelectedValueChanged += cmbBoxSeleccionarServico_SelectedIndexChanged;
            // 
            // grpBpxProductoServicios
            // 
            grpBpxProductoServicios.BackColor = Color.Black;
            grpBpxProductoServicios.Controls.Add(chckBoxLaboratorio);
            grpBpxProductoServicios.Controls.Add(chckBoxOdontologia);
            grpBpxProductoServicios.Controls.Add(chckBoxConsultaGeneral);
            grpBpxProductoServicios.ForeColor = Color.WhiteSmoke;
            grpBpxProductoServicios.Location = new Point(19, 135);
            grpBpxProductoServicios.Name = "grpBpxProductoServicios";
            grpBpxProductoServicios.Size = new Size(305, 213);
            grpBpxProductoServicios.TabIndex = 3;
            grpBpxProductoServicios.TabStop = false;
            grpBpxProductoServicios.Text = "Productos / Servicios";
            // 
            // chckBoxLaboratorio
            // 
            chckBoxLaboratorio.AutoSize = true;
            chckBoxLaboratorio.Location = new Point(17, 108);
            chckBoxLaboratorio.Name = "chckBoxLaboratorio";
            chckBoxLaboratorio.Size = new Size(207, 27);
            chckBoxLaboratorio.TabIndex = 6;
            chckBoxLaboratorio.Text = "Laboratorio - B/50.00";
            chckBoxLaboratorio.UseVisualStyleBackColor = true;
            chckBoxLaboratorio.CheckedChanged += chckBoxLaboratorio_CheckedChanged;
            // 
            // chckBoxOdontologia
            // 
            chckBoxOdontologia.AutoSize = true;
            chckBoxOdontologia.Location = new Point(17, 75);
            chckBoxOdontologia.Name = "chckBoxOdontologia";
            chckBoxOdontologia.Size = new Size(212, 27);
            chckBoxOdontologia.TabIndex = 5;
            chckBoxOdontologia.Text = "Odontologia - B/25.00";
            chckBoxOdontologia.UseVisualStyleBackColor = true;
            chckBoxOdontologia.CheckedChanged += chckBoxOdontologia_CheckedChanged;
            // 
            // chckBoxConsultaGeneral
            // 
            chckBoxConsultaGeneral.AutoSize = true;
            chckBoxConsultaGeneral.Location = new Point(17, 42);
            chckBoxConsultaGeneral.Name = "chckBoxConsultaGeneral";
            chckBoxConsultaGeneral.Size = new Size(249, 27);
            chckBoxConsultaGeneral.TabIndex = 4;
            chckBoxConsultaGeneral.Text = "Consulta General - B/10.00";
            chckBoxConsultaGeneral.UseVisualStyleBackColor = true;
            chckBoxConsultaGeneral.CheckedChanged += chckBoxConsultaGeneral_CheckedChanged;
            // 
            // txtBoxCategoriaUsuario
            // 
            txtBoxCategoriaUsuario.Location = new Point(507, 78);
            txtBoxCategoriaUsuario.Name = "txtBoxCategoriaUsuario";
            txtBoxCategoriaUsuario.Size = new Size(230, 30);
            txtBoxCategoriaUsuario.TabIndex = 2;
            txtBoxCategoriaUsuario.Text = "Particular";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(507, 42);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 23);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(19, 42);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 23);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // grpBoxDetalleVenta
            // 
            grpBoxDetalleVenta.Controls.Add(btnLimpiar);
            grpBoxDetalleVenta.Controls.Add(btnEliminar);
            grpBoxDetalleVenta.Controls.Add(lstBoxResumenVenta);
            grpBoxDetalleVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxDetalleVenta.ForeColor = Color.White;
            grpBoxDetalleVenta.Location = new Point(802, 184);
            grpBoxDetalleVenta.Name = "grpBoxDetalleVenta";
            grpBoxDetalleVenta.Size = new Size(550, 238);
            grpBoxDetalleVenta.TabIndex = 6;
            grpBoxDetalleVenta.TabStop = false;
            grpBoxDetalleVenta.Text = "Detalle de Venta";
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(290, 181);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(240, 45);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(16, 181);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(255, 45);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstBoxResumenVenta
            // 
            lstBoxResumenVenta.FormattingEnabled = true;
            lstBoxResumenVenta.Location = new Point(16, 31);
            lstBoxResumenVenta.Name = "lstBoxResumenVenta";
            lstBoxResumenVenta.Size = new Size(514, 144);
            lstBoxResumenVenta.TabIndex = 0;
            // 
            // grpBoxResumen
            // 
            grpBoxResumen.Controls.Add(btnRegistrarVenta);
            grpBoxResumen.Controls.Add(lblTotal);
            grpBoxResumen.Controls.Add(pictureBox1);
            grpBoxResumen.Controls.Add(lblDescuento);
            grpBoxResumen.Controls.Add(lblITBMS);
            grpBoxResumen.Controls.Add(lblSubtotal);
            grpBoxResumen.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBoxResumen.ForeColor = Color.White;
            grpBoxResumen.Location = new Point(802, 428);
            grpBoxResumen.Name = "grpBoxResumen";
            grpBoxResumen.Size = new Size(550, 238);
            grpBoxResumen.TabIndex = 7;
            grpBoxResumen.TabStop = false;
            grpBoxResumen.Text = "Resumen";
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRegistrarVenta.ForeColor = Color.Black;
            btnRegistrarVenta.Location = new Point(16, 192);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(516, 40);
            btnRegistrarVenta.TabIndex = 8;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            btnRegistrarVenta.MouseEnter += btnRegistrarVenta_MouseEnter;
            btnRegistrarVenta.MouseLeave += btnRegistrarVenta_MouseLeave;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(299, 136);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(231, 23);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:                            0.00";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSeaGreen;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(11, 114);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 10);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(333, 88);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(198, 20);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento:                    0.00";
            // 
            // lblITBMS
            // 
            lblITBMS.AutoSize = true;
            lblITBMS.Location = new Point(333, 54);
            lblITBMS.Name = "lblITBMS";
            lblITBMS.Size = new Size(199, 20);
            lblITBMS.TabIndex = 1;
            lblITBMS.Text = "ITBMS (7%):                  0.00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(333, 23);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(197, 20);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal:                       0.00";
            // 
            // Finanzas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1364, 753);
            Controls.Add(grpBoxResumen);
            Controls.Add(grpBoxDetalleVenta);
            Controls.Add(grpBoxDatosVenta);
            Controls.Add(lblFinanzas);
            Controls.Add(pctrLinea);
            Controls.Add(pctrBoxLogo);
            Name = "Finanzas";
            Text = "Finanzas";
            Load += form_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)pctrBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrLinea).EndInit();
            grpBoxDatosVenta.ResumeLayout(false);
            grpBoxDatosVenta.PerformLayout();
            grpBoxTipoPago.ResumeLayout(false);
            grpBoxTipoPago.PerformLayout();
            grpBoxItemPrincipal.ResumeLayout(false);
            grpBoxItemPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownCantidad).EndInit();
            grpBpxProductoServicios.ResumeLayout(false);
            grpBpxProductoServicios.PerformLayout();
            grpBoxDetalleVenta.ResumeLayout(false);
            grpBoxResumen.ResumeLayout(false);
            grpBoxResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoxUsuariosVentas;
        private SaveFileDialog svFileDialogFinanzas;
        private PictureBox pctrBoxLogo;
        private PictureBox pctrLinea;
        private Label lblFinanzas;
        private GroupBox grpBoxDatosVenta;
        private Label lblCliente;
        private GroupBox grpBpxProductoServicios;
        private TextBox txtBoxCategoriaUsuario;
        private Label lblCategoria;
        private CheckBox chckBoxConsultaGeneral;
        private CheckBox chckBoxOdontologia;
        private GroupBox grpBoxItemPrincipal;
        private Label lblCantidad;
        private ComboBox cmbBoxSeleccionarServicio;
        private GroupBox grpBoxTipoPago;
        private Button btnAgregar;
        private NumericUpDown nmrcUpDownCantidad;
        private TextBox txtBoxObservacion;
        private Label lblObservacion;
        private RadioButton rdButtonTarjeta;
        private RadioButton rdButtonEfectivo;
        private GroupBox grpBoxDetalleVenta;
        private Button btnLimpiar;
        private Button btnEliminar;
        private ListBox lstBoxResumenVenta;
        private GroupBox grpBoxResumen;
        private Label lblTotal;
        private PictureBox pictureBox1;
        private Label lblDescuento;
        private Label lblITBMS;
        private Label lblSubtotal;
        private Button btnRegistrarVenta;
        private CheckBox chckBoxLaboratorio;
    }
}