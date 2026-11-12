using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_3
{
    public partial class frmVideos : Form
    {
        // Los videos son archivos que se colocan en la carpeta "Videos" junto al programa
        private readonly string carpetaVideos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Videos");
        private static readonly string[] Extensiones = { ".mp4", ".wmv", ".avi", ".mov", ".mkv" };

        // Elemento de la lista: muestra el nombre y guarda la ruta del archivo
        private class VideoItem
        {
            public string Nombre;
            public string Ruta;
            public override string ToString() { return Nombre; }
        }

        public frmVideos()
        {
            InitializeComponent();

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmVideos_Load;
            btnReproducir.Click += btnReproducir_Click;
            lstVideos.DoubleClick += btnReproducir_Click; // doble clic también reproduce
        }

        private void frmVideos_Load(object sender, EventArgs e)
        {
            CargarVideos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        // Llena la lista con los videos que haya en la carpeta
        private void CargarVideos()
        {
            lstVideos.Items.Clear();

            try
            {
                Directory.CreateDirectory(carpetaVideos); // se crea si no existe, para que sepan dónde copiarlos

                foreach (string ruta in Directory.GetFiles(carpetaVideos).OrderBy(r => r))
                {
                    if (Array.IndexOf(Extensiones, Path.GetExtension(ruta).ToLower()) >= 0)
                    {
                        VideoItem v = new VideoItem();
                        v.Nombre = Path.GetFileNameWithoutExtension(ruta);
                        v.Ruta = ruta;
                        lstVideos.Items.Add(v);
                    }
                }
            }
            catch (Exception ex)
            {
                Ui.Aviso("No se pudo leer la carpeta de videos: " + ex.Message);
            }

            if (lstVideos.Items.Count == 0)
                lstVideos.Items.Add("(No hay videos. Copie archivos .mp4 a la carpeta \"Videos\" junto al programa)");
        }

        // Abre el video elegido con el reproductor predeterminado de Windows
        private void btnReproducir_Click(object sender, EventArgs e)
        {
            VideoItem video = lstVideos.SelectedItem as VideoItem;
            if (video == null)
            {
                Ui.Aviso("Seleccione un video de la lista.");
                return;
            }

            try
            {
                Process.Start(video.Ruta);
            }
            catch (Exception ex)
            {
                Ui.Aviso("No se pudo reproducir el video: " + ex.Message);
            }
        }
    }
}
