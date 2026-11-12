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
    public partial class frmBitacora : Form
    {
        private readonly DatosClinica datos = new DatosClinica();
        private bool filtrarFechas = false; // el rango de fechas solo se aplica si el usuario lo cambió

        private const string Todos = "(Todos)";

        public frmBitacora()
        {
            InitializeComponent();

            Ui.ConfigurarGrid(dgvRegistroBitacora);
            FechasPorDefecto();

            // Conexión de los eventos que no estaban en el diseño
            this.Load += frmBitacora_Load;
            btnFiltrar.Click += btnFiltrar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            dtpFechaInferior.ValueChanged += delegate { filtrarFechas = true; };
            dtpFechaSuperior.ValueChanged += delegate { filtrarFechas = true; };
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            try
            {
                // Usuarios y módulos que aparecen en la bitácora (cmbEstado es el filtro "Modulo/Unidad")
                LlenarFiltro(cmbUsuario, datos.ListarValoresBitacora("Usuario"));
                LlenarFiltro(cmbEstado, datos.ListarValoresBitacora("Modulo"));

                // Acciones permitidas por la BD
                cmbAccion.Items.Clear();
                cmbAccion.Items.AddRange(new object[] { Todos, "LOGIN", "LOGIN_FALLIDO", "LOGOUT",
                    "INSERTAR", "ACTUALIZAR", "ELIMINAR", "CONSULTAR" });
                cmbAccion.SelectedIndex = 0;
            }
            catch (Exception ex) { Ui.Error(ex); }

            Filtrar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPanelPrincipal panelPrincipal = new frmPanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        // ---------- Filtros ----------

        private void FechasPorDefecto()
        {
            dtpFechaInferior.Value = DateTime.Today.AddMonths(-1);
            dtpFechaSuperior.Value = DateTime.Today;
            filtrarFechas = false;
        }

        // Llena un combo con "(Todos)" y los valores que vienen de la BD
        private void LlenarFiltro(ComboBox cmb, DataTable valores)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.Items.Add(Todos);
            foreach (DataRow f in valores.Rows) cmb.Items.Add(Convert.ToString(f[0]));
            cmb.SelectedIndex = 0;
        }

        // Devuelve null si está en "(Todos)" para que la consulta no filtre por ese campo
        private string Valor(ComboBox cmb)
        {
            string v = cmb.SelectedItem as string;
            return (v == null || v == Todos) ? null : v;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            if (filtrarFechas && dtpFechaInferior.Value.Date > dtpFechaSuperior.Value.Date)
            {
                Ui.Aviso("La fecha inicial no puede ser mayor que la fecha final.");
                return;
            }

            try
            {
                // El día final se incluye completo
                DateTime? desde = filtrarFechas ? (DateTime?)dtpFechaInferior.Value.Date : null;
                DateTime? hasta = filtrarFechas ? (DateTime?)dtpFechaSuperior.Value.Date.AddDays(1) : null;

                DataTable dt = datos.ListarBitacora(Valor(cmbUsuario), Valor(cmbEstado), Valor(cmbAccion), desde, hasta);
                Ui.Enlazar(dgvRegistroBitacora, dt, "IdBitacora");
                grpBitacora.Text = "Bitacora del Sistema (" + dt.Rows.Count + " registros)";

                if (dt.Rows.Count == 0) Ui.Info("No hay registros con los filtros elegidos.");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbUsuario.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbAccion.SelectedIndex = 0;
            FechasPorDefecto();
            Filtrar();
        }
    }
}
