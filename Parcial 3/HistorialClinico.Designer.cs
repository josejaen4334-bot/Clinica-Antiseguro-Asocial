namespace Parcial_3
{
    partial class frmHistorialClinico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialClinico));
            this.panBuscar = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.grpVerPacientes = new System.Windows.Forms.GroupBox();
            this.dgvRegistroPacientes = new System.Windows.Forms.DataGridView();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpDatosPaciente.SuspendLayout();
            this.grpVerPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPacientes)).BeginInit();
            this.grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panBuscar
            // 
            this.panBuscar.BackColor = System.Drawing.Color.Transparent;
            this.panBuscar.Controls.Add(this.lblBuscar);
            this.panBuscar.Controls.Add(this.txtBuscar);
            this.panBuscar.Controls.Add(this.btnBuscar);
            this.panBuscar.Location = new System.Drawing.Point(841, 135);
            this.panBuscar.Name = "panBuscar";
            this.panBuscar.Size = new System.Drawing.Size(590, 116);
            this.panBuscar.TabIndex = 48;
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
            this.txtBuscar.ReadOnly = true;
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
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.Color.Transparent;
            this.lblHistorial.Font = new System.Drawing.Font("Manrope", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHistorial.Location = new System.Drawing.Point(197, 78);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(260, 26);
            this.lblHistorial.TabIndex = 46;
            this.lblHistorial.Text = "Unidad del Historial Clinico";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.picLogo.Location = new System.Drawing.Point(30, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 45;
            this.picLogo.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1334, 54);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 40);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.grpDatosPaciente.Location = new System.Drawing.Point(61, 617);
            this.grpDatosPaciente.Name = "grpDatosPaciente";
            this.grpDatosPaciente.Size = new System.Drawing.Size(1393, 188);
            this.grpDatosPaciente.TabIndex = 49;
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
            // grpVerPacientes
            // 
            this.grpVerPacientes.BackColor = System.Drawing.Color.Transparent;
            this.grpVerPacientes.Controls.Add(this.dgvRegistroPacientes);
            this.grpVerPacientes.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerPacientes.Location = new System.Drawing.Point(77, 287);
            this.grpVerPacientes.Name = "grpVerPacientes";
            this.grpVerPacientes.Size = new System.Drawing.Size(1360, 311);
            this.grpVerPacientes.TabIndex = 50;
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
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.Font = new System.Drawing.Font("Manrope", 9.791999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblSeparador.Location = new System.Drawing.Point(-38, 825);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(1520, 23);
            this.lblSeparador.TabIndex = 52;
            this.lblSeparador.Text = resources.GetString("lblSeparador.Text");
            // 
            // grpHistorial
            // 
            this.grpHistorial.BackColor = System.Drawing.Color.Transparent;
            this.grpHistorial.Controls.Add(this.btnEliminar);
            this.grpHistorial.Controls.Add(this.dataGridView1);
            this.grpHistorial.Controls.Add(this.btnActualizar);
            this.grpHistorial.Controls.Add(this.btnRegistrar);
            this.grpHistorial.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHistorial.Location = new System.Drawing.Point(49, 886);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Size = new System.Drawing.Size(1405, 511);
            this.grpHistorial.TabIndex = 53;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial de Registros anteriores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1393, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(974, 440);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(203, 47);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(608, 440);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(203, 47);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(228, 440);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(203, 47);
            this.btnRegistrar.TabIndex = 54;
            this.btnRegistrar.Text = "+ Nueva Consulta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1100);
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1506, 1034);
            this.Controls.Add(this.grpHistorial);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.grpVerPacientes);
            this.Controls.Add(this.grpDatosPaciente);
            this.Controls.Add(this.panBuscar);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmHistorialClinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion del Historial Clinico";
            this.panBuscar.ResumeLayout(false);
            this.panBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpDatosPaciente.ResumeLayout(false);
            this.grpDatosPaciente.PerformLayout();
            this.grpVerPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPacientes)).EndInit();
            this.grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpDatosPaciente;
        private System.Windows.Forms.TextBox txtTipoSangre;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.Label lblIDPaciente;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.GroupBox grpVerPacientes;
        private System.Windows.Forms.DataGridView dgvRegistroPacientes;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}