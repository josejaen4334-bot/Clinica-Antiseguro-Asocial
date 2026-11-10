namespace Parcial_3
{
    partial class frmPacientes
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpDatosPaciente = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSangre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
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
            this.grpVerPacientes = new System.Windows.Forms.GroupBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblGestionEmpleados = new System.Windows.Forms.Label();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.grpDatosPaciente.SuspendLayout();
            this.grpVerPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1263, 54);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 40);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpDatosPaciente
            // 
            this.grpDatosPaciente.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosPaciente.Controls.Add(this.textBox1);
            this.grpDatosPaciente.Controls.Add(this.lblSangre);
            this.grpDatosPaciente.Controls.Add(this.txtDireccion);
            this.grpDatosPaciente.Controls.Add(this.lblDireccion);
            this.grpDatosPaciente.Controls.Add(this.txtCorreo);
            this.grpDatosPaciente.Controls.Add(this.lblCorreo);
            this.grpDatosPaciente.Controls.Add(this.txtTelefono);
            this.grpDatosPaciente.Controls.Add(this.lblTelefono);
            this.grpDatosPaciente.Controls.Add(this.txtCedula);
            this.grpDatosPaciente.Controls.Add(this.lblCedula);
            this.grpDatosPaciente.Controls.Add(this.dtpNacimiento);
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
            this.grpDatosPaciente.Location = new System.Drawing.Point(40, 151);
            this.grpDatosPaciente.Name = "grpDatosPaciente";
            this.grpDatosPaciente.Size = new System.Drawing.Size(477, 606);
            this.grpDatosPaciente.TabIndex = 8;
            this.grpDatosPaciente.TabStop = false;
            this.grpDatosPaciente.Text = "Datos del Paciente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(175, 528);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 24);
            this.textBox1.TabIndex = 29;
            // 
            // lblSangre
            // 
            this.lblSangre.AutoSize = true;
            this.lblSangre.BackColor = System.Drawing.Color.Transparent;
            this.lblSangre.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangre.Location = new System.Drawing.Point(19, 530);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(130, 22);
            this.lblSangre.TabIndex = 28;
            this.lblSangre.Text = "Tipo de Sangre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(175, 472);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(241, 24);
            this.txtDireccion.TabIndex = 27;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(19, 472);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(88, 22);
            this.lblDireccion.TabIndex = 26;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(175, 415);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 24);
            this.txtCorreo.TabIndex = 25;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(19, 415);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(69, 22);
            this.lblCorreo.TabIndex = 24;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(175, 360);
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
            this.lblTelefono.Location = new System.Drawing.Point(19, 362);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 22);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(175, 204);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(241, 24);
            this.txtCedula.TabIndex = 21;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblCedula.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(19, 205);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(70, 22);
            this.lblCedula.TabIndex = 20;
            this.lblCedula.Text = "Cedula:";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(200, 305);
            this.dtpNacimiento.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(216, 27);
            this.dtpNacimiento.TabIndex = 19;
            this.dtpNacimiento.Value = new System.DateTime(2026, 11, 4, 0, 0, 0, 0);
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(315, 257);
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
            this.radFemenino.Location = new System.Drawing.Point(175, 257);
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
            this.txtApellido.Location = new System.Drawing.Point(175, 153);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 24);
            this.txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(175, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 24);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblNacimiento.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(19, 309);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(175, 22);
            this.lblNacimiento.TabIndex = 13;
            this.lblNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(19, 256);
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
            this.lblApellido.Location = new System.Drawing.Point(19, 154);
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
            this.lblNombre.Location = new System.Drawing.Point(19, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 22);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.BackColor = System.Drawing.SystemColors.Window;
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
            // grpVerPacientes
            // 
            this.grpVerPacientes.BackColor = System.Drawing.Color.Transparent;
            this.grpVerPacientes.Controls.Add(this.dgvRegistro);
            this.grpVerPacientes.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerPacientes.Location = new System.Drawing.Point(566, 151);
            this.grpVerPacientes.Name = "grpVerPacientes";
            this.grpVerPacientes.Size = new System.Drawing.Size(822, 482);
            this.grpVerPacientes.TabIndex = 9;
            this.grpVerPacientes.TabStop = false;
            this.grpVerPacientes.Text = "Pacientes Registrados";
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
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(566, 663);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(190, 47);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(778, 663);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(190, 47);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(988, 663);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 47);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1198, 663);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(190, 47);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.picLogo.Location = new System.Drawing.Point(24, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 20;
            this.picLogo.TabStop = false;
            // 
            // lblGestionEmpleados
            // 
            this.lblGestionEmpleados.AutoSize = true;
            this.lblGestionEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionEmpleados.Font = new System.Drawing.Font("Manrope", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEmpleados.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGestionEmpleados.Location = new System.Drawing.Point(191, 68);
            this.lblGestionEmpleados.Name = "lblGestionEmpleados";
            this.lblGestionEmpleados.Size = new System.Drawing.Size(302, 26);
            this.lblGestionEmpleados.TabIndex = 35;
            this.lblGestionEmpleados.Text = "Unidad de Gestion de Pacientes";
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActualizarTabla.Location = new System.Drawing.Point(1200, 105);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(179, 40);
            this.btnActualizarTabla.TabIndex = 36;
            this.btnActualizarTabla.Text = "Actualizar Tabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = true;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 849);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.lblGestionEmpleados);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpVerPacientes);
            this.Controls.Add(this.grpDatosPaciente);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Pacientes";
            this.grpDatosPaciente.ResumeLayout(false);
            this.grpDatosPaciente.PerformLayout();
            this.grpVerPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpDatosPaciente;
        private System.Windows.Forms.GroupBox grpVerPacientes;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Label lblIDPaciente;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblGestionEmpleados;
        private System.Windows.Forms.Button btnActualizarTabla;
    }
}