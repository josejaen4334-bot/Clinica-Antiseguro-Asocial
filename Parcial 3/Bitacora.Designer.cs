namespace Parcial_3
{
    partial class frmBitacora
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
            this.grpBitacora = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblModulo = new System.Windows.Forms.Label();
            this.dtpFechaSuperior = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInferior = new System.Windows.Forms.DateTimePicker();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblVerBitacora = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvRegistroBitacora = new System.Windows.Forms.DataGridView();
            this.grpBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBitacora
            // 
            this.grpBitacora.BackColor = System.Drawing.Color.Transparent;
            this.grpBitacora.Controls.Add(this.dgvRegistroBitacora);
            this.grpBitacora.Controls.Add(this.cmbAccion);
            this.grpBitacora.Controls.Add(this.lblAccion);
            this.grpBitacora.Controls.Add(this.btnFiltrar);
            this.grpBitacora.Controls.Add(this.btnLimpiar);
            this.grpBitacora.Controls.Add(this.lblModulo);
            this.grpBitacora.Controls.Add(this.dtpFechaSuperior);
            this.grpBitacora.Controls.Add(this.dtpFechaInferior);
            this.grpBitacora.Controls.Add(this.cmbUsuario);
            this.grpBitacora.Controls.Add(this.cmbEstado);
            this.grpBitacora.Controls.Add(this.lblUsuario);
            this.grpBitacora.Controls.Add(this.lblFechas);
            this.grpBitacora.Font = new System.Drawing.Font("Manrope", 8.063999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBitacora.Location = new System.Drawing.Point(57, 159);
            this.grpBitacora.Name = "grpBitacora";
            this.grpBitacora.Size = new System.Drawing.Size(1131, 603);
            this.grpBitacora.TabIndex = 63;
            this.grpBitacora.TabStop = false;
            this.grpBitacora.Text = "Bitacora del Sistema";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(598, 206);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(192, 47);
            this.btnFiltrar.TabIndex = 56;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(850, 206);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(192, 47);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.BackColor = System.Drawing.Color.Transparent;
            this.lblModulo.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(594, 148);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(134, 22);
            this.lblModulo.TabIndex = 35;
            this.lblModulo.Text = "Modulo/Unidad:";
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
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(169, 148);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(241, 27);
            this.cmbUsuario.TabIndex = 32;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(774, 144);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(268, 27);
            this.cmbEstado.TabIndex = 31;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(44, 149);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 22);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuario:";
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
            // lblVerBitacora
            // 
            this.lblVerBitacora.AutoSize = true;
            this.lblVerBitacora.BackColor = System.Drawing.Color.Transparent;
            this.lblVerBitacora.Font = new System.Drawing.Font("Manrope", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerBitacora.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblVerBitacora.Location = new System.Drawing.Point(191, 68);
            this.lblVerBitacora.Name = "lblVerBitacora";
            this.lblVerBitacora.Size = new System.Drawing.Size(348, 26);
            this.lblVerBitacora.TabIndex = 65;
            this.lblVerBitacora.Text = "Unidad de Visualizacion de Bitacoras";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(146, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 64;
            this.picLogo.TabStop = false;
            // 
            // cmbAccion
            // 
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(169, 217);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(241, 27);
            this.cmbAccion.TabIndex = 58;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.BackColor = System.Drawing.Color.Transparent;
            this.lblAccion.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(44, 218);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(68, 22);
            this.lblAccion.TabIndex = 57;
            this.lblAccion.Text = "Accion:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1072, 54);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 40);
            this.btnVolver.TabIndex = 66;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvRegistroBitacora
            // 
            this.dgvRegistroBitacora.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistroBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroBitacora.Location = new System.Drawing.Point(33, 275);
            this.dgvRegistroBitacora.Name = "dgvRegistroBitacora";
            this.dgvRegistroBitacora.ReadOnly = true;
            this.dgvRegistroBitacora.RowHeadersWidth = 53;
            this.dgvRegistroBitacora.RowTemplate.Height = 24;
            this.dgvRegistroBitacora.Size = new System.Drawing.Size(1061, 302);
            this.dgvRegistroBitacora.TabIndex = 59;
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 787);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblVerBitacora);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpBitacora);
            this.Name = "frmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacoras / Logs";
            this.grpBitacora.ResumeLayout(false);
            this.grpBitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBitacora;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.DateTimePicker dtpFechaSuperior;
        private System.Windows.Forms.DateTimePicker dtpFechaInferior;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label lblVerBitacora;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvRegistroBitacora;
    }
}