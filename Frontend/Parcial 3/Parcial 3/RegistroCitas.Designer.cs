namespace Parcial_3
{
    partial class frmRegistroCitas
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
            this.grpDatosCitas = new System.Windows.Forms.GroupBox();
            this.cmbTipoCita = new System.Windows.Forms.ComboBox();
            this.lblTipoCita = new System.Windows.Forms.Label();
            this.dtpHoraCita = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCita = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.lblIDCita = new System.Windows.Forms.Label();
            this.lblCitas = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpVerCitas = new System.Windows.Forms.GroupBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnVerCalendario = new System.Windows.Forms.Button();
            this.grpDatosCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpVerCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosCitas
            // 
            this.grpDatosCitas.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosCitas.Controls.Add(this.cmbTipoCita);
            this.grpDatosCitas.Controls.Add(this.lblTipoCita);
            this.grpDatosCitas.Controls.Add(this.dtpHoraCita);
            this.grpDatosCitas.Controls.Add(this.lblHora);
            this.grpDatosCitas.Controls.Add(this.dtpFechaCita);
            this.grpDatosCitas.Controls.Add(this.lblFecha);
            this.grpDatosCitas.Controls.Add(this.cmbMedico);
            this.grpDatosCitas.Controls.Add(this.cmbPaciente);
            this.grpDatosCitas.Controls.Add(this.cmbEstadoCita);
            this.grpDatosCitas.Controls.Add(this.lblEstado);
            this.grpDatosCitas.Controls.Add(this.txtMotivo);
            this.grpDatosCitas.Controls.Add(this.lblMotivo);
            this.grpDatosCitas.Controls.Add(this.lblMedico);
            this.grpDatosCitas.Controls.Add(this.lblPaciente);
            this.grpDatosCitas.Controls.Add(this.txtIDEmpleado);
            this.grpDatosCitas.Controls.Add(this.lblIDCita);
            this.grpDatosCitas.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosCitas.Location = new System.Drawing.Point(37, 199);
            this.grpDatosCitas.Name = "grpDatosCitas";
            this.grpDatosCitas.Size = new System.Drawing.Size(508, 548);
            this.grpDatosCitas.TabIndex = 39;
            this.grpDatosCitas.TabStop = false;
            this.grpDatosCitas.Text = "Registro para Citas";
            // 
            // cmbTipoCita
            // 
            this.cmbTipoCita.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbTipoCita.FormattingEnabled = true;
            this.cmbTipoCita.Location = new System.Drawing.Point(216, 321);
            this.cmbTipoCita.Name = "cmbTipoCita";
            this.cmbTipoCita.Size = new System.Drawing.Size(243, 27);
            this.cmbTipoCita.TabIndex = 40;
            // 
            // lblTipoCita
            // 
            this.lblTipoCita.AutoSize = true;
            this.lblTipoCita.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCita.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCita.Location = new System.Drawing.Point(18, 326);
            this.lblTipoCita.Name = "lblTipoCita";
            this.lblTipoCita.Size = new System.Drawing.Size(107, 22);
            this.lblTipoCita.TabIndex = 39;
            this.lblTipoCita.Text = "Tipo de CIta:";
            // 
            // dtpHoraCita
            // 
            this.dtpHoraCita.Location = new System.Drawing.Point(216, 265);
            this.dtpHoraCita.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtpHoraCita.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpHoraCita.Name = "dtpHoraCita";
            this.dtpHoraCita.Size = new System.Drawing.Size(243, 27);
            this.dtpHoraCita.TabIndex = 38;
            this.dtpHoraCita.Value = new System.DateTime(2026, 11, 4, 0, 0, 0, 0);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(19, 270);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 22);
            this.lblHora.TabIndex = 37;
            this.lblHora.Text = "Hora:";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(216, 206);
            this.dtpFechaCita.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtpFechaCita.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(243, 27);
            this.dtpFechaCita.TabIndex = 36;
            this.dtpFechaCita.Value = new System.DateTime(2026, 11, 4, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(19, 211);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 22);
            this.lblFecha.TabIndex = 35;
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
            this.cmbMedico.Location = new System.Drawing.Point(216, 149);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(243, 27);
            this.cmbMedico.TabIndex = 34;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(216, 95);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(243, 27);
            this.cmbPaciente.TabIndex = 33;
            // 
            // cmbEstadoCita
            // 
            this.cmbEstadoCita.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbEstadoCita.FormattingEnabled = true;
            this.cmbEstadoCita.Location = new System.Drawing.Point(216, 430);
            this.cmbEstadoCita.Name = "cmbEstadoCita";
            this.cmbEstadoCita.Size = new System.Drawing.Size(243, 27);
            this.cmbEstadoCita.TabIndex = 32;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(18, 435);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 22);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(216, 377);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(243, 24);
            this.txtMotivo.TabIndex = 25;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.BackColor = System.Drawing.Color.Transparent;
            this.lblMotivo.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(18, 379);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(69, 22);
            this.lblMotivo.TabIndex = 24;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblMedico.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(19, 154);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(72, 22);
            this.lblMedico.TabIndex = 11;
            this.lblMedico.Text = "Medico:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblPaciente.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(19, 100);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(84, 22);
            this.lblPaciente.TabIndex = 10;
            this.lblPaciente.Text = "Paciente:";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDEmpleado.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmpleado.Location = new System.Drawing.Point(216, 46);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.ReadOnly = true;
            this.txtIDEmpleado.Size = new System.Drawing.Size(243, 24);
            this.txtIDEmpleado.TabIndex = 9;
            // 
            // lblIDCita
            // 
            this.lblIDCita.AutoSize = true;
            this.lblIDCita.BackColor = System.Drawing.Color.Transparent;
            this.lblIDCita.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCita.Location = new System.Drawing.Point(19, 47);
            this.lblIDCita.Name = "lblIDCita";
            this.lblIDCita.Size = new System.Drawing.Size(88, 22);
            this.lblIDCita.TabIndex = 1;
            this.lblIDCita.Text = "ID de Cita:";
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.BackColor = System.Drawing.Color.Transparent;
            this.lblCitas.Font = new System.Drawing.Font("Manrope", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCitas.Location = new System.Drawing.Point(195, 77);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(340, 26);
            this.lblCitas.TabIndex = 38;
            this.lblCitas.Text = "Unidad de Gestion de Citas Medicas";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.picLogo.Location = new System.Drawing.Point(12, 29);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 37;
            this.picLogo.TabStop = false;
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActualizarTabla.Location = new System.Drawing.Point(1229, 199);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(179, 40);
            this.btnActualizarTabla.TabIndex = 46;
            this.btnActualizarTabla.Text = "Actualizar Tabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1253, 754);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(190, 47);
            this.btnLimpiar.TabIndex = 45;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1043, 754);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 47);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(833, 754);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(190, 47);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(621, 754);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(190, 47);
            this.btnRegistrar.TabIndex = 42;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1229, 143);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(179, 40);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpVerCitas
            // 
            this.grpVerCitas.BackColor = System.Drawing.Color.Transparent;
            this.grpVerCitas.Controls.Add(this.dgvRegistro);
            this.grpVerCitas.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerCitas.Location = new System.Drawing.Point(624, 245);
            this.grpVerCitas.Name = "grpVerCitas";
            this.grpVerCitas.Size = new System.Drawing.Size(822, 482);
            this.grpVerCitas.TabIndex = 40;
            this.grpVerCitas.TabStop = false;
            this.grpVerCitas.Text = "Citas Registradas";
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
            // btnVerCalendario
            // 
            this.btnVerCalendario.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCalendario.ForeColor = System.Drawing.Color.Green;
            this.btnVerCalendario.Location = new System.Drawing.Point(1026, 199);
            this.btnVerCalendario.Name = "btnVerCalendario";
            this.btnVerCalendario.Size = new System.Drawing.Size(179, 40);
            this.btnVerCalendario.TabIndex = 47;
            this.btnVerCalendario.Text = "Ver CALENDARIO";
            this.btnVerCalendario.UseVisualStyleBackColor = true;
            this.btnVerCalendario.Click += new System.EventHandler(this.btnVerCalendario_Click);
            // 
            // frmRegistroCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1475, 849);
            this.Controls.Add(this.btnVerCalendario);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpVerCitas);
            this.Controls.Add(this.grpDatosCitas);
            this.Controls.Add(this.lblCitas);
            this.Controls.Add(this.picLogo);
            this.Name = "frmRegistroCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroCitas";
            this.grpDatosCitas.ResumeLayout(false);
            this.grpDatosCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpVerCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCitas;
        private System.Windows.Forms.ComboBox cmbTipoCita;
        private System.Windows.Forms.Label lblTipoCita;
        private System.Windows.Forms.DateTimePicker dtpHoraCita;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbEstadoCita;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label lblIDCita;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpVerCitas;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Button btnVerCalendario;
    }
}