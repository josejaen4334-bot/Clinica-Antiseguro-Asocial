namespace Parcial_3
{
    partial class frmUsuarios
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblGestionUsuarios = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpVerUsuarios = new System.Windows.Forms.GroupBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.grpDatosUsuario = new System.Windows.Forms.GroupBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.radMedico = new System.Windows.Forms.RadioButton();
            this.radPaciente = new System.Windows.Forms.RadioButton();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblSangre = new System.Windows.Forms.Label();
            this.lblVincular = new System.Windows.Forms.Label();
            this.radNadie = new System.Windows.Forms.RadioButton();
            this.radEmpleado = new System.Windows.Forms.RadioButton();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpVerUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.grpDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(965, 133);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(241, 21);
            this.txtBuscar.TabIndex = 42;
            this.txtBuscar.Text = "Buscar...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(1236, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 40);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblGestionUsuarios
            // 
            this.lblGestionUsuarios.AutoSize = true;
            this.lblGestionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuarios.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGestionUsuarios.Location = new System.Drawing.Point(191, 68);
            this.lblGestionUsuarios.Name = "lblGestionUsuarios";
            this.lblGestionUsuarios.Size = new System.Drawing.Size(300, 24);
            this.lblGestionUsuarios.TabIndex = 40;
            this.lblGestionUsuarios.Text = "Unidad de Gestion de Usuarios";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.picLogo.Location = new System.Drawing.Point(24, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 39;
            this.picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1256, 52);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 40);
            this.btnVolver.TabIndex = 43;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpVerUsuarios
            // 
            this.grpVerUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.grpVerUsuarios.Controls.Add(this.dgvRegistro);
            this.grpVerUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerUsuarios.Location = new System.Drawing.Point(53, 185);
            this.grpVerUsuarios.Name = "grpVerUsuarios";
            this.grpVerUsuarios.Size = new System.Drawing.Size(1319, 271);
            this.grpVerUsuarios.TabIndex = 44;
            this.grpVerUsuarios.TabStop = false;
            this.grpVerUsuarios.Text = "Usuarios Registrados";
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(19, 22);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.RowHeadersWidth = 53;
            this.dgvRegistro.RowTemplate.Height = 24;
            this.dgvRegistro.Size = new System.Drawing.Size(1280, 231);
            this.dgvRegistro.TabIndex = 0;
            // 
            // grpDatosUsuario
            // 
            this.grpDatosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosUsuario.Controls.Add(this.lblPersona);
            this.grpDatosUsuario.Controls.Add(this.cmbPersona);
            this.grpDatosUsuario.Controls.Add(this.label1);
            this.grpDatosUsuario.Controls.Add(this.cmbEstado);
            this.grpDatosUsuario.Controls.Add(this.radMedico);
            this.grpDatosUsuario.Controls.Add(this.radPaciente);
            this.grpDatosUsuario.Controls.Add(this.cmbRol);
            this.grpDatosUsuario.Controls.Add(this.lblSangre);
            this.grpDatosUsuario.Controls.Add(this.lblVincular);
            this.grpDatosUsuario.Controls.Add(this.radNadie);
            this.grpDatosUsuario.Controls.Add(this.radEmpleado);
            this.grpDatosUsuario.Controls.Add(this.txtContrasena);
            this.grpDatosUsuario.Controls.Add(this.lblEstado);
            this.grpDatosUsuario.Controls.Add(this.lblRol);
            this.grpDatosUsuario.Controls.Add(this.lblContrasena);
            this.grpDatosUsuario.Controls.Add(this.txtUsuario);
            this.grpDatosUsuario.Controls.Add(this.lblUsuario);
            this.grpDatosUsuario.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosUsuario.Location = new System.Drawing.Point(12, 479);
            this.grpDatosUsuario.Name = "grpDatosUsuario";
            this.grpDatosUsuario.Size = new System.Drawing.Size(1393, 196);
            this.grpDatosUsuario.TabIndex = 50;
            this.grpDatosUsuario.TabStop = false;
            this.grpDatosUsuario.Text = "Datos de Usuario";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.BackColor = System.Drawing.Color.Transparent;
            this.lblPersona.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(19, 151);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(74, 22);
            this.lblPersona.TabIndex = 39;
            this.lblPersona.Text = "Persona";
            // 
            // cmbPersona
            // 
            this.cmbPersona.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(175, 151);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(239, 27);
            this.cmbPersona.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 37;
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
            this.cmbEstado.Location = new System.Drawing.Point(1083, 94);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(239, 27);
            this.cmbEstado.TabIndex = 36;
            // 
            // radMedico
            // 
            this.radMedico.AutoSize = true;
            this.radMedico.Location = new System.Drawing.Point(315, 97);
            this.radMedico.Name = "radMedico";
            this.radMedico.Size = new System.Drawing.Size(80, 23);
            this.radMedico.TabIndex = 35;
            this.radMedico.TabStop = true;
            this.radMedico.Text = "Medico";
            this.radMedico.UseVisualStyleBackColor = true;
            // 
            // radPaciente
            // 
            this.radPaciente.AutoSize = true;
            this.radPaciente.Location = new System.Drawing.Point(175, 97);
            this.radPaciente.Name = "radPaciente";
            this.radPaciente.Size = new System.Drawing.Size(90, 23);
            this.radPaciente.TabIndex = 34;
            this.radPaciente.TabStop = true;
            this.radPaciente.Text = "Paciente";
            this.radPaciente.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            this.cmbRol.AutoCompleteCustomSource.AddRange(new string[] {
            "Medicina General",
            "Oftalmologia",
            "Cirugia",
            "Odontologia",
            "Cardiologo"});
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(1083, 49);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(239, 27);
            this.cmbRol.TabIndex = 33;
            // 
            // lblSangre
            // 
            this.lblSangre.AutoSize = true;
            this.lblSangre.BackColor = System.Drawing.Color.Transparent;
            this.lblSangre.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangre.Location = new System.Drawing.Point(22, 152);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(0, 22);
            this.lblSangre.TabIndex = 28;
            // 
            // lblVincular
            // 
            this.lblVincular.AutoSize = true;
            this.lblVincular.BackColor = System.Drawing.Color.Transparent;
            this.lblVincular.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVincular.Location = new System.Drawing.Point(19, 100);
            this.lblVincular.Name = "lblVincular";
            this.lblVincular.Size = new System.Drawing.Size(89, 22);
            this.lblVincular.TabIndex = 20;
            this.lblVincular.Text = "Vincular a:";
            // 
            // radNadie
            // 
            this.radNadie.AutoSize = true;
            this.radNadie.Location = new System.Drawing.Point(606, 98);
            this.radNadie.Name = "radNadie";
            this.radNadie.Size = new System.Drawing.Size(69, 23);
            this.radNadie.TabIndex = 17;
            this.radNadie.TabStop = true;
            this.radNadie.Text = "Nadie";
            this.radNadie.UseVisualStyleBackColor = true;
            // 
            // radEmpleado
            // 
            this.radEmpleado.AutoSize = true;
            this.radEmpleado.Location = new System.Drawing.Point(466, 98);
            this.radEmpleado.Name = "radEmpleado";
            this.radEmpleado.Size = new System.Drawing.Size(98, 23);
            this.radEmpleado.TabIndex = 16;
            this.radEmpleado.TabStop = true;
            this.radEmpleado.Text = "Empleado";
            this.radEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(639, 49);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(241, 24);
            this.txtContrasena.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(927, 98);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 22);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(927, 50);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 22);
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "Rol:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasena.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(483, 48);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(107, 22);
            this.lblContrasena.TabIndex = 10;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.Font = new System.Drawing.Font("Manrope SemiBold", 6.911999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(175, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(241, 24);
            this.txtUsuario.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(19, 47);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 22);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(919, 685);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(190, 47);
            this.btnLimpiar.TabIndex = 54;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(709, 685);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 47);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(499, 685);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(190, 47);
            this.btnActualizar.TabIndex = 52;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(287, 685);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(190, 47);
            this.btnRegistrar.TabIndex = 51;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1419, 744);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpDatosUsuario);
            this.Controls.Add(this.grpVerUsuarios);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblGestionUsuarios);
            this.Controls.Add(this.picLogo);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpVerUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.grpDatosUsuario.ResumeLayout(false);
            this.grpDatosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblGestionUsuarios;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpVerUsuarios;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.GroupBox grpDatosUsuario;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.Label lblVincular;
        private System.Windows.Forms.RadioButton radNadie;
        private System.Windows.Forms.RadioButton radEmpleado;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.RadioButton radMedico;
        private System.Windows.Forms.RadioButton radPaciente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPersona;
    }
}