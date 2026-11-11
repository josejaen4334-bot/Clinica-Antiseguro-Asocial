namespace Parcial_3
{
    partial class frmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.lblSeparador = new System.Windows.Forms.Label();
            this.grpVerPacientes = new System.Windows.Forms.GroupBox();
            this.dgvRegistroPacientes = new System.Windows.Forms.DataGridView();
            this.grpDatosPaciente = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTipoSangre = new System.Windows.Forms.TextBox();
            this.lblSangre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.lblIDPaciente = new System.Windows.Forms.Label();
            this.panBuscar = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpServicios = new System.Windows.Forms.GroupBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.lblBuscarRegistro = new System.Windows.Forms.Label();
            this.grpFactura = new System.Windows.Forms.GroupBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lablTotalNumero = new System.Windows.Forms.Label();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpVerPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPacientes)).BeginInit();
            this.grpDatosPaciente.SuspendLayout();
            this.panBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.grpFactura.SuspendLayout();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.Font = new System.Drawing.Font("Manrope", 9.791999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblSeparador.Location = new System.Drawing.Point(-40, 838);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(1520, 23);
            this.lblSeparador.TabIndex = 59;
            this.lblSeparador.Text = resources.GetString("lblSeparador.Text");
            // 
            // grpVerPacientes
            // 
            this.grpVerPacientes.BackColor = System.Drawing.Color.Transparent;
            this.grpVerPacientes.Controls.Add(this.dgvRegistroPacientes);
            this.grpVerPacientes.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerPacientes.Location = new System.Drawing.Point(75, 300);
            this.grpVerPacientes.Name = "grpVerPacientes";
            this.grpVerPacientes.Size = new System.Drawing.Size(1360, 311);
            this.grpVerPacientes.TabIndex = 58;
            this.grpVerPacientes.TabStop = false;
            this.grpVerPacientes.Text = "Pacientes Registrados";
            // 
            // dgvRegistroPacientes
            // 
            this.dgvRegistroPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistroPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroPacientes.Location = new System.Drawing.Point(6, 26);
            this.dgvRegistroPacientes.Name = "dgvRegistroPacientes";
            this.dgvRegistroPacientes.ReadOnly = true;
            this.dgvRegistroPacientes.RowHeadersWidth = 53;
            this.dgvRegistroPacientes.RowTemplate.Height = 24;
            this.dgvRegistroPacientes.Size = new System.Drawing.Size(1348, 279);
            this.dgvRegistroPacientes.TabIndex = 0;
            // 
            // grpDatosPaciente
            // 
            this.grpDatosPaciente.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosPaciente.Controls.Add(this.txtEdad);
            this.grpDatosPaciente.Controls.Add(this.txtTipoSangre);
            this.grpDatosPaciente.Controls.Add(this.lblSangre);
            this.grpDatosPaciente.Controls.Add(this.txtCedula);
            this.grpDatosPaciente.Controls.Add(this.lblCedula);
            this.grpDatosPaciente.Controls.Add(this.radMasculino);
            this.grpDatosPaciente.Controls.Add(this.radFemenino);
            this.grpDatosPaciente.Controls.Add(this.txtApellido);
            this.grpDatosPaciente.Controls.Add(this.txtNombre);
            this.grpDatosPaciente.Controls.Add(this.lblNacimiento);
            this.grpDatosPaciente.Controls.Add(this.lblGenero);
            this.grpDatosPaciente.Controls.Add(this.lblApellido);
            this.grpDatosPaciente.Controls.Add(this.lblNombre);
            this.grpDatosPaciente.Controls.Add(this.txtIDPaciente);
            this.grpDatosPaciente.Controls.Add(this.lblIDPaciente);
            this.grpDatosPaciente.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosPaciente.Location = new System.Drawing.Point(59, 630);
            this.grpDatosPaciente.Name = "grpDatosPaciente";
            this.grpDatosPaciente.Size = new System.Drawing.Size(1393, 188);
            this.grpDatosPaciente.TabIndex = 57;
            this.grpDatosPaciente.TabStop = false;
            this.grpDatosPaciente.Text = "Datos del Paciente Seleccionado";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(1083, 103);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(241, 24);
            this.txtEdad.TabIndex = 30;
            // 
            // txtTipoSangre
            // 
            this.txtTipoSangre.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoSangre.Location = new System.Drawing.Point(178, 150);
            this.txtTipoSangre.Name = "txtTipoSangre";
            this.txtTipoSangre.ReadOnly = true;
            this.txtTipoSangre.Size = new System.Drawing.Size(241, 24);
            this.txtTipoSangre.TabIndex = 29;
            // 
            // lblSangre
            // 
            this.lblSangre.AutoSize = true;
            this.lblSangre.BackColor = System.Drawing.Color.Transparent;
            this.lblSangre.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangre.Location = new System.Drawing.Point(22, 152);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(130, 22);
            this.lblSangre.TabIndex = 28;
            this.lblSangre.Text = "Tipo de Sangre:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(175, 99);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(241, 24);
            this.txtCedula.TabIndex = 21;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblCedula.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(19, 100);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(70, 22);
            this.lblCedula.TabIndex = 20;
            this.lblCedula.Text = "Cedula:";
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(782, 102);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(101, 23);
            this.radMasculino.TabIndex = 17;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Location = new System.Drawing.Point(642, 102);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(97, 23);
            this.radFemenino.TabIndex = 16;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(1083, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(241, 24);
            this.txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(639, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(241, 24);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblNacimiento.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(927, 98);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(53, 22);
            this.lblNacimiento.TabIndex = 13;
            this.lblNacimiento.Text = "Edad:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(486, 101);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(73, 22);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(927, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 22);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(483, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 22);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDPaciente.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPaciente.Location = new System.Drawing.Point(175, 46);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.ReadOnly = true;
            this.txtIDPaciente.Size = new System.Drawing.Size(241, 24);
            this.txtIDPaciente.TabIndex = 9;
            // 
            // lblIDPaciente
            // 
            this.lblIDPaciente.AutoSize = true;
            this.lblIDPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblIDPaciente.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPaciente.Location = new System.Drawing.Point(19, 47);
            this.lblIDPaciente.Name = "lblIDPaciente";
            this.lblIDPaciente.Size = new System.Drawing.Size(125, 22);
            this.lblIDPaciente.TabIndex = 1;
            this.lblIDPaciente.Text = "ID de Paciente:";
            // 
            // panBuscar
            // 
            this.panBuscar.BackColor = System.Drawing.Color.Transparent;
            this.panBuscar.Controls.Add(this.lblBuscar);
            this.panBuscar.Controls.Add(this.txtBuscar);
            this.panBuscar.Controls.Add(this.btnBuscar);
            this.panBuscar.Location = new System.Drawing.Point(839, 148);
            this.panBuscar.Name = "panBuscar";
            this.panBuscar.Size = new System.Drawing.Size(590, 116);
            this.panBuscar.TabIndex = 56;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(27, 35);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(332, 22);
            this.lblBuscar.TabIndex = 43;
            this.lblBuscar.Text = "Ingrese la cedula o el nombre del paciente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(31, 85);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(396, 24);
            this.txtBuscar.TabIndex = 42;
            this.txtBuscar.Text = "Buscar Paciente...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(457, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 40);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturacion.Font = new System.Drawing.Font("Manrope", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFacturacion.Location = new System.Drawing.Point(219, 91);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(123, 26);
            this.lblFacturacion.TabIndex = 55;
            this.lblFacturacion.Text = "Facturacion";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.picLogo.Location = new System.Drawing.Point(28, 35);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 54;
            this.picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1332, 67);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 40);
            this.btnVolver.TabIndex = 53;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpServicios
            // 
            this.grpServicios.BackColor = System.Drawing.Color.Transparent;
            this.grpServicios.Controls.Add(this.dgvServicios);
            this.grpServicios.Controls.Add(this.btnAgregar);
            this.grpServicios.Controls.Add(this.btnBuscarServicio);
            this.grpServicios.Controls.Add(this.txtServicio);
            this.grpServicios.Controls.Add(this.lblBuscarRegistro);
            this.grpServicios.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServicios.Location = new System.Drawing.Point(75, 894);
            this.grpServicios.Name = "grpServicios";
            this.grpServicios.Size = new System.Drawing.Size(723, 479);
            this.grpServicios.TabIndex = 60;
            this.grpServicios.TabStop = false;
            this.grpServicios.Text = "Servicios";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Precio,
            this.Seleccionar});
            this.dgvServicios.Location = new System.Drawing.Point(23, 144);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowHeadersWidth = 53;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.Size = new System.Drawing.Size(665, 306);
            this.dgvServicios.TabIndex = 61;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 7;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 7;
            this.Precio.Name = "Precio";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 7;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(565, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 40);
            this.btnAgregar.TabIndex = 43;
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarServicio.Location = new System.Drawing.Point(415, 67);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(116, 40);
            this.btnBuscarServicio.TabIndex = 42;
            this.btnBuscarServicio.Text = "Buscar";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.SystemColors.Window;
            this.txtServicio.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(23, 83);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(353, 24);
            this.txtServicio.TabIndex = 9;
            // 
            // lblBuscarRegistro
            // 
            this.lblBuscarRegistro.AutoSize = true;
            this.lblBuscarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarRegistro.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarRegistro.Location = new System.Drawing.Point(19, 47);
            this.lblBuscarRegistro.Name = "lblBuscarRegistro";
            this.lblBuscarRegistro.Size = new System.Drawing.Size(133, 22);
            this.lblBuscarRegistro.TabIndex = 1;
            this.lblBuscarRegistro.Text = "Buscar Servicio:";
            // 
            // grpFactura
            // 
            this.grpFactura.BackColor = System.Drawing.Color.Transparent;
            this.grpFactura.Controls.Add(this.lablTotalNumero);
            this.grpFactura.Controls.Add(this.lblTotal);
            this.grpFactura.Controls.Add(this.cmbPago);
            this.grpFactura.Controls.Add(this.label1);
            this.grpFactura.Controls.Add(this.cmbMedico);
            this.grpFactura.Controls.Add(this.lblMedico);
            this.grpFactura.Controls.Add(this.dtpFechaFactura);
            this.grpFactura.Controls.Add(this.lblFecha);
            this.grpFactura.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFactura.Location = new System.Drawing.Point(902, 943);
            this.grpFactura.Name = "grpFactura";
            this.grpFactura.Size = new System.Drawing.Size(494, 401);
            this.grpFactura.TabIndex = 62;
            this.grpFactura.TabStop = false;
            this.grpFactura.Text = "Factura";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Location = new System.Drawing.Point(205, 58);
            this.dtpFechaFactura.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFactura.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(239, 27);
            this.dtpFechaFactura.TabIndex = 21;
            this.dtpFechaFactura.Value = new System.DateTime(2026, 11, 4, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(48, 63);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 22);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(205, 128);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(239, 27);
            this.cmbMedico.TabIndex = 32;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblMedico.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(48, 133);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(72, 22);
            this.lblMedico.TabIndex = 31;
            this.lblMedico.Text = "Medico:";
            // 
            // cmbPago
            // 
            this.cmbPago.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(205, 198);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(239, 27);
            this.cmbPago.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo de Pago:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Manrope", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(84, 318);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 28);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total:";
            // 
            // lablTotalNumero
            // 
            this.lablTotalNumero.AutoSize = true;
            this.lablTotalNumero.BackColor = System.Drawing.Color.Transparent;
            this.lablTotalNumero.Font = new System.Drawing.Font("Manrope", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablTotalNumero.Location = new System.Drawing.Point(263, 318);
            this.lablTotalNumero.Name = "lablTotalNumero";
            this.lablTotalNumero.Size = new System.Drawing.Size(125, 28);
            this.lablTotalNumero.TabIndex = 37;
            this.lablTotalNumero.Text = "Aqui va el $";
            // 
            // grpDetalles
            // 
            this.grpDetalles.BackColor = System.Drawing.Color.Transparent;
            this.grpDetalles.Controls.Add(this.dgvDetalles);
            this.grpDetalles.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalles.Location = new System.Drawing.Point(75, 1407);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(1354, 408);
            this.grpDetalles.TabIndex = 63;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles de la Factura";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Cantidad,
            this.Subtotal});
            this.dgvDetalles.Location = new System.Drawing.Point(36, 40);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 53;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(1285, 259);
            this.dgvDetalles.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 7;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 7;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1100);
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1506, 1054);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.grpFactura);
            this.Controls.Add(this.grpServicios);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.grpVerPacientes);
            this.Controls.Add(this.grpDatosPaciente);
            this.Controls.Add(this.panBuscar);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medico:";
            this.grpVerPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPacientes)).EndInit();
            this.grpDatosPaciente.ResumeLayout(false);
            this.grpDatosPaciente.PerformLayout();
            this.panBuscar.ResumeLayout(false);
            this.panBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpServicios.ResumeLayout(false);
            this.grpServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.grpFactura.ResumeLayout(false);
            this.grpFactura.PerformLayout();
            this.grpDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.GroupBox grpVerPacientes;
        private System.Windows.Forms.DataGridView dgvRegistroPacientes;
        private System.Windows.Forms.GroupBox grpDatosPaciente;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTipoSangre;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.Label lblIDPaciente;
        private System.Windows.Forms.Panel panBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpServicios;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label lblBuscarRegistro;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.GroupBox grpFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lablTotalNumero;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}