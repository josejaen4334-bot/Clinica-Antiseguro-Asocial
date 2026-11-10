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
    public partial class frmCitas : Form
    {
        public frmCitas()
        {
            InitializeComponent();
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            frmRegistroCitas registroCitas = new frmRegistroCitas();
            registroCitas.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        private void btnVerListadoCitas_Click(object sender, EventArgs e)
        {
            frmRegistroCitas registroCitas = new frmRegistroCitas();
            registroCitas.Show();
            this.Close();
        }
    }
}
