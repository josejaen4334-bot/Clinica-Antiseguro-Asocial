namespace Parcial_2_Jose_Jaen_1GS124
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblUniversidad = new Label();
            lblFacultad = new Label();
            lblMateria = new Label();
            lblTituloParcial = new Label();
            lblEstudiante = new Label();
            pctrUtpLogo = new PictureBox();
            SaveFileImgs = new SaveFileDialog();
            pctrFISC = new PictureBox();
            btnSiguiente = new Button();
            lblAsignatura = new Label();
            lblNombreEstudiante = new Label();
            lblFecha = new Label();
            lblFechaParcial = new Label();
            ((System.ComponentModel.ISupportInitialize)pctrUtpLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrFISC).BeginInit();
            SuspendLayout();
            // 
            // lblUniversidad
            // 
            lblUniversidad.AutoSize = true;
            lblUniversidad.BackColor = Color.Transparent;
            lblUniversidad.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUniversidad.ForeColor = SystemColors.ControlLightLight;
            lblUniversidad.Location = new Point(486, 35);
            lblUniversidad.Name = "lblUniversidad";
            lblUniversidad.Size = new Size(479, 37);
            lblUniversidad.TabIndex = 0;
            lblUniversidad.Text = "Universidad Tecnologica de Panama";
            lblUniversidad.TextAlign = ContentAlignment.MiddleCenter;
            lblUniversidad.Click += lblUniversidad_Click;
            // 
            // lblFacultad
            // 
            lblFacultad.AutoSize = true;
            lblFacultad.BackColor = Color.Transparent;
            lblFacultad.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFacultad.ForeColor = SystemColors.ControlLightLight;
            lblFacultad.Location = new Point(388, 84);
            lblFacultad.Name = "lblFacultad";
            lblFacultad.Size = new Size(681, 37);
            lblFacultad.TabIndex = 1;
            lblFacultad.Text = "Facultad de Ingeniera de Sistemas Computacionales";
            lblFacultad.TextAlign = ContentAlignment.MiddleCenter;
            lblFacultad.Click += lblFacultad_Click;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.BackColor = Color.Transparent;
            lblMateria.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMateria.ForeColor = SystemColors.ControlLightLight;
            lblMateria.Location = new Point(651, 148);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(125, 37);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia:";
            lblMateria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloParcial
            // 
            lblTituloParcial.AutoSize = true;
            lblTituloParcial.BackColor = Color.Transparent;
            lblTituloParcial.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloParcial.ForeColor = SystemColors.ControlLightLight;
            lblTituloParcial.Location = new Point(546, 289);
            lblTituloParcial.Name = "lblTituloParcial";
            lblTituloParcial.Size = new Size(356, 37);
            lblTituloParcial.TabIndex = 3;
            lblTituloParcial.Text = "Parcial 2 - Windows Forms";
            lblTituloParcial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.BackColor = Color.Transparent;
            lblEstudiante.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblEstudiante.ForeColor = SystemColors.ControlLightLight;
            lblEstudiante.Location = new Point(629, 378);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(166, 37);
            lblEstudiante.TabIndex = 4;
            lblEstudiante.Text = "Estudiante: ";
            lblEstudiante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pctrUtpLogo
            // 
            pctrUtpLogo.BackColor = Color.Transparent;
            pctrUtpLogo.BackgroundImage = (Image)resources.GetObject("pctrUtpLogo.BackgroundImage");
            pctrUtpLogo.Image = (Image)resources.GetObject("pctrUtpLogo.Image");
            pctrUtpLogo.Location = new Point(14, 16);
            pctrUtpLogo.Margin = new Padding(3, 4, 3, 4);
            pctrUtpLogo.Name = "pctrUtpLogo";
            pctrUtpLogo.Size = new Size(296, 212);
            pctrUtpLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctrUtpLogo.TabIndex = 6;
            pctrUtpLogo.TabStop = false;
            pctrUtpLogo.Click += pictureBox2_Click;
            // 
            // SaveFileImgs
            // 
            SaveFileImgs.Filter = "|*.jpg;*.png;*.jpeg;";
            // 
            // pctrFISC
            // 
            pctrFISC.BackColor = Color.Transparent;
            pctrFISC.BackgroundImage = (Image)resources.GetObject("pctrFISC.BackgroundImage");
            pctrFISC.Image = (Image)resources.GetObject("pctrFISC.Image");
            pctrFISC.Location = new Point(1085, 16);
            pctrFISC.Margin = new Padding(3, 4, 3, 4);
            pctrFISC.Name = "pctrFISC";
            pctrFISC.Size = new Size(245, 212);
            pctrFISC.SizeMode = PictureBoxSizeMode.Zoom;
            pctrFISC.TabIndex = 7;
            pctrFISC.TabStop = false;
            pctrFISC.Click += pictureBox1_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Transparent;
            btnSiguiente.FlatAppearance.BorderColor = Color.Gray;
            btnSiguiente.FlatAppearance.BorderSize = 20;
            btnSiguiente.FlatAppearance.MouseDownBackColor = Color.White;
            btnSiguiente.FlatAppearance.MouseOverBackColor = Color.White;
            btnSiguiente.FlatStyle = FlatStyle.System;
            btnSiguiente.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSiguiente.ForeColor = SystemColors.ControlLightLight;
            btnSiguiente.Location = new Point(1195, 658);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(135, 43);
            btnSiguiente.TabIndex = 8;
            btnSiguiente.Text = "Sig";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.BackColor = Color.Transparent;
            lblAsignatura.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAsignatura.ForeColor = SystemColors.ControlLightLight;
            lblAsignatura.Location = new Point(546, 191);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(348, 37);
            lblAsignatura.TabIndex = 9;
            lblAsignatura.Text = "Desarrollo de Software IV";
            lblAsignatura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreEstudiante
            // 
            lblNombreEstudiante.AutoSize = true;
            lblNombreEstudiante.BackColor = Color.Transparent;
            lblNombreEstudiante.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNombreEstudiante.ForeColor = SystemColors.ControlLightLight;
            lblNombreEstudiante.Location = new Point(572, 427);
            lblNombreEstudiante.Name = "lblNombreEstudiante";
            lblNombreEstudiante.Size = new Size(311, 37);
            lblNombreEstudiante.TabIndex = 10;
            lblNombreEstudiante.Text = "Jose Jaen 8-1049-1944";
            lblNombreEstudiante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFecha.ForeColor = SystemColors.ControlLightLight;
            lblFecha.Location = new Point(651, 517);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(97, 37);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha:";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFechaParcial
            // 
            lblFechaParcial.AutoSize = true;
            lblFechaParcial.BackColor = Color.Transparent;
            lblFechaParcial.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFechaParcial.ForeColor = SystemColors.ControlLightLight;
            lblFechaParcial.Location = new Point(517, 579);
            lblFechaParcial.Name = "lblFechaParcial";
            lblFechaParcial.Size = new Size(384, 37);
            lblFechaParcial.TabIndex = 12;
            lblFechaParcial.Text = "Jueves 1 de Octubre de 2026";
            lblFechaParcial.TextAlign = ContentAlignment.MiddleCenter;
            lblFechaParcial.Click += lblFechaParcial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1352, 714);
            Controls.Add(lblFechaParcial);
            Controls.Add(lblFecha);
            Controls.Add(lblNombreEstudiante);
            Controls.Add(lblAsignatura);
            Controls.Add(btnSiguiente);
            Controls.Add(pctrFISC);
            Controls.Add(pctrUtpLogo);
            Controls.Add(lblEstudiante);
            Controls.Add(lblTituloParcial);
            Controls.Add(lblMateria);
            Controls.Add(lblFacultad);
            Controls.Add(lblUniversidad);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctrUtpLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrFISC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUniversidad;
        private Label lblFacultad;
        private Label lblMateria;
        private Label lblTituloParcial;
        private Label lblEstudiante;
        private PictureBox pctrUtpLogo;
        private SaveFileDialog SaveFileImgs;
        private PictureBox pctrFISC;
        private Button btnSiguiente;
        private Label lblAsignatura;
        private Label lblNombreEstudiante;
        private Label lblFecha;
        private Label lblFechaParcial;
    }
}
