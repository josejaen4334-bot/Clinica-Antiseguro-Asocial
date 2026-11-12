namespace Parcial_3
{
    partial class frmMedicos
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
            this.grpDatosMedico = new System.Windows.Forms.GroupBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDMedico = new System.Windows.Forms.TextBox();
            this.lblIDMedico = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpVerMedicos = new System.Windows.Forms.GroupBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblGestionMedicos = new System.Windows.Forms.Label();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpDatosMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpVerMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosMedico
            // 
            this.grpDatosMedico.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosMedico.Controls.Add(this.picFoto);
            this.grpDatosMedico.Controls.Add(this.lblFoto);
            this.grpDatosMedico.Controls.Add(this.cmbEstado);
            this.grpDatosMedico.Controls.Add(this.lblEstado);
            this.grpDatosMedico.Controls.Add(this.cmbEspecialidad);
            this.grpDatosMedico.Controls.Add(this.txtLicencia);
            this.grpDatosMedico.Controls.Add(this.lblLicencia);
            this.grpDatosMedico.Controls.Add(this.lblEspecialidad);
            this.grpDatosMedico.Controls.Add(this.txtCorreo);
            this.grpDatosMedico.Controls.Add(this.lblCorreo);
            this.grpDatosMedico.Controls.Add(this.txtTelefono);
            this.grpDatosMedico.Controls.Add(this.lblTelefono);
            this.grpDatosMedico.Controls.Add(this.txtCedula);
            this.grpDatosMedico.Controls.Add(this.lblCedula);
            this.grpDatosMedico.Controls.Add(this.dtpContratacion);
            this.grpDatosMedico.Controls.Add(this.radMasculino);
            this.grpDatosMedico.Controls.Add(this.radFemenino);
            this.grpDatosMedico.Controls.Add(this.txtApellido);
            this.grpDatosMedico.Controls.Add(this.txtNombre);
            this.grpDatosMedico.Controls.Add(this.lblNacimiento);
            this.grpDatosMedico.Controls.Add(this.lblGenero);
            this.grpDatosMedico.Controls.Add(this.lblApellido);
            this.grpDatosMedico.Controls.Add(this.lblNombre);
            this.grpDatosMedico.Controls.Add(this.txtIDMedico);
            this.grpDatosMedico.Controls.Add(this.lblIDMedico);
            this.grpDatosMedico.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosMedico.Location = new System.Drawing.Point(41, 156);
            this.grpDatosMedico.Name = "grpDatosMedico";
            this.grpDatosMedico.Size = new System.Drawing.Size(508, 855);
            this.grpDatosMedico.TabIndex = 22;
            this.grpDatosMedico.TabStop = false;
            this.grpDatosMedico.Text = "Datos del Medico";
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.LightGray;
            this.picFoto.BackgroundImage = global::Parcial_3.Properties.Resources.perfil_del_usuario1;
            this.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picFoto.Location = new System.Drawing.Point(241, 103);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(213, 171);
            this.picFoto.TabIndex = 34;
            this.picFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(27, 114);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(50, 22);
            this.lblFoto.TabIndex = 33;
            this.lblFoto.Text = "Foto:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(226, 779);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(239, 27);
            this.cmbEstado.TabIndex = 32;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(25, 784);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 22);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(224, 614);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(239, 27);
            this.cmbEspecialidad.TabIndex = 30;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencia.Location = new System.Drawing.Point(224, 675);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(241, 24);
            this.txtLicencia.TabIndex = 29;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.BackColor = System.Drawing.Color.Transparent;
            this.lblLicencia.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencia.Location = new System.Drawing.Point(25, 677);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(78, 22);
            this.lblLicencia.TabIndex = 28;
            this.lblLicencia.Text = "Licencia:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidad.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(25, 619);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(131, 22);
            this.lblEspecialidad.TabIndex = 26;
            this.lblEspecialidad.Text = "Especialidades:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(224, 562);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 24);
            this.txtCorreo.TabIndex = 25;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(25, 562);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(69, 22);
            this.lblCorreo.TabIndex = 24;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(224, 507);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(241, 24);
            this.txtTelefono.TabIndex = 23;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(25, 509);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 22);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(224, 402);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(241, 24);
            this.txtCedula.TabIndex = 21;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblCedula.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(25, 403);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(70, 22);
            this.lblCedula.TabIndex = 20;
            this.lblCedula.Text = "Cedula:";
            // 
            // dtpContratacion
            // 
            this.dtpContratacion.Location = new System.Drawing.Point(224, 727);
            this.dtpContratacion.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtpContratacion.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpContratacion.Name = "dtpContratacion";
            this.dtpContratacion.Size = new System.Drawing.Size(239, 27);
            this.dtpContratacion.TabIndex = 19;
            this.dtpContratacion.Value = new System.DateTime(2026, 11, 4, 0, 0, 0, 0);
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(362, 454);
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
            this.radFemenino.Location = new System.Drawing.Point(224, 455);
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
            this.txtApellido.Location = new System.Drawing.Point(224, 351);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 24);
            this.txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(224, 299);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 24);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblNacimiento.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(25, 732);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(190, 22);
            this.lblNacimiento.TabIndex = 13;
            this.lblNacimiento.Text = "Fecha de Contratación:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(25, 454);
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
            this.lblApellido.Location = new System.Drawing.Point(25, 352);
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
            this.lblNombre.Location = new System.Drawing.Point(25, 298);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 22);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtIDMedico
            // 
            this.txtIDMedico.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDMedico.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMedico.Location = new System.Drawing.Point(226, 55);
            this.txtIDMedico.Name = "txtIDMedico";
            this.txtIDMedico.ReadOnly = true;
            this.txtIDMedico.Size = new System.Drawing.Size(241, 24);
            this.txtIDMedico.TabIndex = 9;
            // 
            // lblIDMedico
            // 
            this.lblIDMedico.AutoSize = true;
            this.lblIDMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblIDMedico.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMedico.Location = new System.Drawing.Point(27, 56);
            this.lblIDMedico.Name = "lblIDMedico";
            this.lblIDMedico.Size = new System.Drawing.Size(113, 22);
            this.lblIDMedico.TabIndex = 1;
            this.lblIDMedico.Text = "ID de Medico:";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.picLogo.Location = new System.Drawing.Point(27, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 21;
            this.picLogo.TabStop = false;
            // 
            // grpVerMedicos
            // 
            this.grpVerMedicos.BackColor = System.Drawing.Color.Transparent;
            this.grpVerMedicos.Controls.Add(this.dgvRegistro);
            this.grpVerMedicos.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerMedicos.Location = new System.Drawing.Point(598, 156);
            this.grpVerMedicos.Name = "grpVerMedicos";
            this.grpVerMedicos.Size = new System.Drawing.Size(822, 482);
            this.grpVerMedicos.TabIndex = 23;
            this.grpVerMedicos.TabStop = false;
            this.grpVerMedicos.Text = "Medicos Registrados";
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(6, 26);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.RowHeadersWidth = 53;
            this.dgvRegistro.RowTemplate.Height = 24;
            this.dgvRegistro.Size = new System.Drawing.Size(807, 442);
            this.dgvRegistro.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1266, 54);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 40);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1227, 665);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(190, 47);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1017, 665);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 47);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(807, 665);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(190, 47);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(595, 665);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(190, 47);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblGestionMedicos
            // 
            this.lblGestionMedicos.AutoSize = true;
            this.lblGestionMedicos.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionMedicos.Font = new System.Drawing.Font("Manrope", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionMedicos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGestionMedicos.Location = new System.Drawing.Point(206, 68);
            this.lblGestionMedicos.Name = "lblGestionMedicos";
            this.lblGestionMedicos.Size = new System.Drawing.Size(289, 26);
            this.lblGestionMedicos.TabIndex = 35;
            this.lblGestionMedicos.Text = "Unidad de Gestion de Medicos";
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActualizarTabla.Location = new System.Drawing.Point(1203, 110);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(179, 40);
            this.btnActualizarTabla.TabIndex = 36;
            this.btnActualizarTabla.Text = "Actualizar Tabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(807, 126);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(241, 24);
            this.txtBuscar.TabIndex = 40;
            this.txtBuscar.Text = "Buscar...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(1078, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 40);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 1054);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.lblGestionMedicos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpVerMedicos);
            this.Controls.Add(this.grpDatosMedico);
            this.Controls.Add(this.picLogo);
            this.Name = "frmMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Medicos";
            this.grpDatosMedico.ResumeLayout(false);
            this.grpDatosMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpVerMedicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpDatosMedico;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.DateTimePicker dtpContratacion;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDMedico;
        private System.Windows.Forms.Label lblIDMedico;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpVerMedicos;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblGestionMedicos;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}