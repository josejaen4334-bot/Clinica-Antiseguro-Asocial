namespace Parcial_3
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.lblReportes = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.grpReporte = new System.Windows.Forms.GroupBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFechaSuperior = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInferior = new System.Windows.Forms.DateTimePicker();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblFechas = new System.Windows.Forms.Label();
            this.grpVerPacientes = new System.Windows.Forms.GroupBox();
            this.dgvRegistroPacientes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpReporte.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.grpVerPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.BackColor = System.Drawing.Color.Transparent;
            this.lblReportes.Font = new System.Drawing.Font("Manrope", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblReportes.Location = new System.Drawing.Point(188, 79);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(194, 26);
            this.lblReportes.TabIndex = 57;
            this.lblReportes.Text = "Unidad de Reportes";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.picLogo.Location = new System.Drawing.Point(21, 23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 56;
            this.picLogo.TabStop = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFacturacion.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFacturacion.Image = global::Parcial_3.Properties.Resources.factura;
            this.btnFacturacion.Location = new System.Drawing.Point(766, 26);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(216, 82);
            this.btnFacturacion.TabIndex = 60;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnCitas
            // 
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCitas.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCitas.Image = global::Parcial_3.Properties.Resources.cita;
            this.btnCitas.Location = new System.Drawing.Point(275, 26);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(216, 82);
            this.btnCitas.TabIndex = 59;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPacientes.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.Location = new System.Drawing.Point(30, 26);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(216, 82);
            this.btnPacientes.TabIndex = 58;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacientes.UseVisualStyleBackColor = true;
            // 
            // grpReporte
            // 
            this.grpReporte.BackColor = System.Drawing.Color.Transparent;
            this.grpReporte.Controls.Add(this.btnHistorial);
            this.grpReporte.Controls.Add(this.btnConsultas);
            this.grpReporte.Controls.Add(this.btnPacientes);
            this.grpReporte.Controls.Add(this.btnFacturacion);
            this.grpReporte.Controls.Add(this.btnCitas);
            this.grpReporte.Font = new System.Drawing.Font("Manrope SemiBold", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReporte.Location = new System.Drawing.Point(87, 164);
            this.grpReporte.Name = "grpReporte";
            this.grpReporte.Size = new System.Drawing.Size(1250, 128);
            this.grpReporte.TabIndex = 61;
            this.grpReporte.TabStop = false;
            this.grpReporte.Text = "Tipo de Reporte";
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorial.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHistorial.Image = global::Parcial_3.Properties.Resources.historial;
            this.btnHistorial.Location = new System.Drawing.Point(1011, 26);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(216, 82);
            this.btnHistorial.TabIndex = 62;
            this.btnHistorial.Text = "Historial Clinico";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultas.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConsultas.Image = global::Parcial_3.Properties.Resources.consulta;
            this.btnConsultas.Location = new System.Drawing.Point(521, 26);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(216, 82);
            this.btnConsultas.TabIndex = 61;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.grpBusqueda.Controls.Add(this.btnLimpiar);
            this.grpBusqueda.Controls.Add(this.btnReporte);
            this.grpBusqueda.Controls.Add(this.lblEstado);
            this.grpBusqueda.Controls.Add(this.dtpFechaSuperior);
            this.grpBusqueda.Controls.Add(this.dtpFechaInferior);
            this.grpBusqueda.Controls.Add(this.cmbBuscarPor);
            this.grpBusqueda.Controls.Add(this.cmbEstado);
            this.grpBusqueda.Controls.Add(this.lblBuscar);
            this.grpBusqueda.Controls.Add(this.lblFechas);
            this.grpBusqueda.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBusqueda.Location = new System.Drawing.Point(127, 329);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(1183, 250);
            this.grpBusqueda.TabIndex = 62;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Filtro de Busqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(726, 164);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(192, 47);
            this.btnLimpiar.TabIndex = 56;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(941, 164);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(192, 47);
            this.btnReporte.TabIndex = 55;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(722, 49);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 22);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado:";
            // 
            // dtpFechaSuperior
            // 
            this.dtpFechaSuperior.Location = new System.Drawing.Point(334, 83);
            this.dtpFechaSuperior.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSuperior.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSuperior.Name = "dtpFechaSuperior";
            this.dtpFechaSuperior.Size = new System.Drawing.Size(239, 27);
            this.dtpFechaSuperior.TabIndex = 34;
            this.dtpFechaSuperior.Value = new System.DateTime(2026, 11, 4, 0, 0, 0, 0);
            // 
            // dtpFechaInferior
            // 
            this.dtpFechaInferior.Location = new System.Drawing.Point(48, 83);
            this.dtpFechaInferior.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInferior.Name = "dtpFechaInferior";
            this.dtpFechaInferior.Size = new System.Drawing.Size(239, 27);
            this.dtpFechaInferior.TabIndex = 33;
            this.dtpFechaInferior.Value = new System.DateTime(2026, 11, 4, 0, 0, 0, 0);
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Location = new System.Drawing.Point(48, 184);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(241, 27);
            this.cmbBuscarPor.TabIndex = 32;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(726, 86);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(305, 27);
            this.cmbEstado.TabIndex = 31;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(44, 149);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(97, 22);
            this.lblBuscar.TabIndex = 20;
            this.lblBuscar.Text = "Buscar Por:";
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.BackColor = System.Drawing.Color.Transparent;
            this.lblFechas.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechas.Location = new System.Drawing.Point(44, 49);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(145, 22);
            this.lblFechas.TabIndex = 1;
            this.lblFechas.Text = "Rango de Fechas:";
            // 
            // grpVerPacientes
            // 
            this.grpVerPacientes.BackColor = System.Drawing.Color.Transparent;
            this.grpVerPacientes.Controls.Add(this.dgvRegistroPacientes);
            this.grpVerPacientes.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerPacientes.Location = new System.Drawing.Point(21, 618);
            this.grpVerPacientes.Name = "grpVerPacientes";
            this.grpVerPacientes.Size = new System.Drawing.Size(1360, 311);
            this.grpVerPacientes.TabIndex = 63;
            this.grpVerPacientes.TabStop = false;
            this.grpVerPacientes.Text = "Ver Reporte";
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
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1221, 65);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 40);
            this.btnVolver.TabIndex = 64;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 861);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpVerPacientes);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.grpReporte);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.picLogo);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Reportea";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpReporte.ResumeLayout(false);
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpVerPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.GroupBox grpReporte;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaSuperior;
        private System.Windows.Forms.DateTimePicker dtpFechaInferior;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox grpVerPacientes;
        private System.Windows.Forms.DataGridView dgvRegistroPacientes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}