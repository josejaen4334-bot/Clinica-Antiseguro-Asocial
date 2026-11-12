namespace Parcial_3
{
    partial class frmVideos
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
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.panVideos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVideos = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstVideos
            // 
            this.lstVideos.Font = new System.Drawing.Font("Manrope SemiBold", 9.791999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.ItemHeight = 23;
            this.lstVideos.Location = new System.Drawing.Point(842, 121);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(469, 464);
            this.lstVideos.TabIndex = 0;
            // 
            // panVideos
            // 
            this.panVideos.Location = new System.Drawing.Point(26, 148);
            this.panVideos.Name = "panVideos";
            this.panVideos.Size = new System.Drawing.Size(771, 407);
            this.panVideos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Parcial_3.Properties.Resources.CIA_logo_2_chiquito;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblVideos
            // 
            this.lblVideos.AutoSize = true;
            this.lblVideos.BackColor = System.Drawing.Color.Transparent;
            this.lblVideos.Font = new System.Drawing.Font("Manrope SemiBold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVideos.Location = new System.Drawing.Point(151, 53);
            this.lblVideos.Name = "lblVideos";
            this.lblVideos.Size = new System.Drawing.Size(379, 22);
            this.lblVideos.TabIndex = 20;
            this.lblVideos.Text = "Disfrute de nuestros videos y eduque su salud!!";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(1210, 44);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 40);
            this.btnVolver.TabIndex = 45;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Font = new System.Drawing.Font("Manrope", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.ForeColor = System.Drawing.Color.Black;
            this.btnReproducir.Location = new System.Drawing.Point(999, 613);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(165, 44);
            this.btnReproducir.TabIndex = 46;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            // 
            // frmVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_3.Properties.Resources.fondo_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1377, 685);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVideos);
            this.Controls.Add(this.panVideos);
            this.Controls.Add(this.lstVideos);
            this.Name = "frmVideos";
            this.Text = "Videos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVideos;
        private System.Windows.Forms.Panel panVideos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVideos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnReproducir;
    }
}