using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_3
{
    public partial class frmRegistroCitas : Form
    {
        public frmRegistroCitas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmCitas citas = new frmCitas();
            citas.Show();
            this.Close();

        }

        private void btnVerCalendario_Click(object sender, EventArgs e)
        {
            //Si, efectivamente hace lo mismo que el btn volver, pero es por practicidad (por si acaso se les olvida el orden de los formularios)
            frmCitas citas = new frmCitas();
            citas.Show();
            this.Close();
        }
    }
}
