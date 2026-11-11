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
    public partial class frmHistorialClinico : Form
    {
        public frmHistorialClinico()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmConsultas consultas = new frmConsultas();
            consultas.Show();
            this.Close();
        }
    }
}
