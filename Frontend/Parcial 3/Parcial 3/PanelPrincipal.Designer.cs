namespace Parcial_3
{
    partial class frmPanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelPrincipal));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnHosptalizacion = new System.Windows.Forms.Button();
            this.btnHabitacion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBienvenido.Location = new System.Drawing.Point(151, 53);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(307, 22);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "¡Bienvenido al panel principal, Usuario!";
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPacientes.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.Location = new System.Drawing.Point(45, 132);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(216, 82);
            this.btnPacientes.TabIndex = 7;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMedicos.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMedicos.Image = global::Parcial_3.Properties.Resources.estetoscopio;
            this.btnMedicos.Location = new System.Drawing.Point(45, 258);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(216, 82);
            this.btnMedicos.TabIndex = 8;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpleados.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmpleados.Image = global::Parcial_3.Properties.Resources.empleados;
            this.btnEmpleados.Location = new System.Drawing.Point(45, 379);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(216, 82);
            this.btnEmpleados.TabIndex = 9;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorial.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHistorial.Image = global::Parcial_3.Properties.Resources.historial;
            this.btnHistorial.Location = new System.Drawing.Point(318, 379);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(216, 82);
            this.btnHistorial.TabIndex = 12;
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
            this.btnConsultas.Location = new System.Drawing.Point(318, 258);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(216, 82);
            this.btnConsultas.TabIndex = 11;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // btnCitas
            // 
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCitas.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCitas.Image = global::Parcial_3.Properties.Resources.cita;
            this.btnCitas.Location = new System.Drawing.Point(318, 132);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(216, 82);
            this.btnCitas.TabIndex = 10;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnHosptalizacion
            // 
            this.btnHosptalizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHosptalizacion.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHosptalizacion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHosptalizacion.Image = global::Parcial_3.Properties.Resources.hospitalizacion;
            this.btnHosptalizacion.Location = new System.Drawing.Point(591, 329);
            this.btnHosptalizacion.Name = "btnHosptalizacion";
            this.btnHosptalizacion.Size = new System.Drawing.Size(216, 82);
            this.btnHosptalizacion.TabIndex = 15;
            this.btnHosptalizacion.Text = "Hospitalizaciones";
            this.btnHosptalizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHosptalizacion.UseVisualStyleBackColor = true;
            // 
            // btnHabitacion
            // 
            this.btnHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHabitacion.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitacion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHabitacion.Image = global::Parcial_3.Properties.Resources.cama;
            this.btnHabitacion.Location = new System.Drawing.Point(591, 192);
            this.btnHabitacion.Name = "btnHabitacion";
            this.btnHabitacion.Size = new System.Drawing.Size(216, 82);
            this.btnHabitacion.TabIndex = 14;
            this.btnHabitacion.Text = "Habitaciones";
            this.btnHabitacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReportes.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReportes.Image = global::Parcial_3.Properties.Resources.reportes;
            this.btnReportes.Location = new System.Drawing.Point(863, 329);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(216, 82);
            this.btnReportes.TabIndex = 18;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFacturacion.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFacturacion.Image = global::Parcial_3.Properties.Resources.factura;
            this.btnFacturacion.Location = new System.Drawing.Point(863, 192);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(216, 82);
            this.btnFacturacion.TabIndex = 17;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.Location = new System.Drawing.Point(899, 41);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(146, 47);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 503);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnHosptalizacion);
            this.Controls.Add(this.btnHabitacion);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "frmPanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnHosptalizacion;
        private System.Windows.Forms.Button btnHabitacion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
    }
}