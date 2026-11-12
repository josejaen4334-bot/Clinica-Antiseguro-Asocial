using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Con Enter se inicia sesion (igual que presionar el boton Login)
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validar que se llenaron los tres campos (textBox1 es el campo de la contraseña)
            if (txtUsuario.Text.Trim() == "" || textBox1.Text.Trim() == "" || cmbRoles.SelectedItem == null)
            {
                Ui.Aviso("Ingrese el usuario, la contraseña y seleccione un rol.");
                return;
            }

            // 2. Validar contra la BD (procedimiento sp_Login: compara el hash de la contraseña)
            try
            {
                bool acceso = new DatosClinica().IniciarSesion(
                    txtUsuario.Text.Trim(), textBox1.Text, cmbRoles.SelectedItem.ToString());

                if (!acceso)
                {
                    Ui.Aviso("Usuario, contraseña o rol incorrectos.");
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
                return;
            }

            // 3. Acceso correcto: se abre el panel principal
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }
    }
}
