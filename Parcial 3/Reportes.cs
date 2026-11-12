using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Parcial_3
{
    public partial class frmReportes : Form
    {
        private readonly DatosClinica datos = new DatosClinica();

        private string tipo = "";            // tipo de reporte elegido con los botones de la izquierda
        private bool filtrarFechas = false;  // el rango de fechas solo se aplica si el usuario lo cambió

        public frmReportes()
        {
            InitializeComponent();

            Ui.ConfigurarGrid(dgvRegistroPacientes);
            FechasPorDefecto();

            // Conexión de los eventos que no estaban en el diseño
            btnPacientes.Click += delegate { ElegirTipo("Pacientes"); };
            btnCitas.Click += delegate { ElegirTipo("Citas"); };
            btnConsultas.Click += delegate { ElegirTipo("Consultas"); };
            btnHistorial.Click += delegate { ElegirTipo("Historial"); };
            btnFacturacion.Click += delegate { ElegirTipo("Facturación"); };
            dtpFechaInferior.ValueChanged += delegate { filtrarFechas = true; };
            dtpFechaSuperior.ValueChanged += delegate { filtrarFechas = true; };
            btnReporte.Click += btnReporte_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            cmbEstado.Enabled = false;
            cmbBuscarPor.Enabled = false;
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

        // Al elegir el tipo de reporte se preparan los filtros que le corresponden
        private void ElegirTipo(string nuevoTipo)
        {
            tipo = nuevoTipo;
            grpReporte.Text = "Tipo de Reporte: " + tipo;

            try
            {
                // "Buscar por": médico para citas/consultas y paciente para los demás
                bool porMedico = tipo == "Citas" || tipo == "Consultas";
                DataTable origen = porMedico ? datos.ListarMedicosCombo() : datos.ListarPacientesCombo();

                DataTable lista = new DataTable();
                lista.Columns.Add("Id", typeof(int));
                lista.Columns.Add("Nombre", typeof(string));
                lista.Rows.Add(0, porMedico ? "(Todos los médicos)" : "(Todos los pacientes)");
                foreach (DataRow f in origen.Rows)
                    lista.Rows.Add(Convert.ToInt32(f[0]), f["Nombre"]);

                Ui.LlenarCombo(cmbBuscarPor, lista, "Nombre", "Id");
                cmbBuscarPor.SelectedIndex = 0;
                cmbBuscarPor.Enabled = true;
            }
            catch (Exception ex) { Ui.Error(ex); }

            // Estados según el reporte (consultas e historial no tienen estado)
            cmbEstado.Items.Clear();
            cmbEstado.Enabled = true;
            switch (tipo)
            {
                case "Pacientes": cmbEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" }); break;
                case "Citas": cmbEstado.Items.AddRange(new object[] { "Todos", "Programada", "Atendida", "Cancelada", "No asistió" }); break;
                case "Facturación": cmbEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Pagada", "Anulada" }); break;
                default: cmbEstado.Enabled = false; break;
            }
            if (cmbEstado.Enabled) cmbEstado.SelectedIndex = 0;
        }

        // ---------- Generar el reporte ----------

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (tipo == "")
            {
                Ui.Aviso("Primero seleccione el tipo de reporte (Pacientes, Citas, Consultas, Historial o Facturación).");
                return;
            }
            if (filtrarFechas && dtpFechaInferior.Value.Date > dtpFechaSuperior.Value.Date)
            {
                Ui.Aviso("La fecha inicial no puede ser mayor que la fecha final.");
                return;
            }

            List<MySqlParameter> ps = new List<MySqlParameter>();
            string sql;
            string campoFecha;

            // Valores elegidos en los filtros (0 / "Todos" = sin filtro)
            int entidad = cmbBuscarPor.SelectedValue != null ? Convert.ToInt32(cmbBuscarPor.SelectedValue) : 0;
            string estado = cmbEstado.Enabled && cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : "Todos";

            switch (tipo)
            {
                case "Pacientes":
                    campoFecha = "FechaRegistro";
                    sql = @"SELECT IdPaciente, Cedula, Nombre, Apellido,
                                CASE Genero WHEN 'M' THEN 'Masculino' ELSE 'Femenino' END AS Genero,
                                FechaNacimiento, Telefono, Correo, TipoSangre,
                                CASE Activo WHEN 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado, FechaRegistro
                            FROM Pacientes WHERE 1 = 1";
                    if (entidad > 0) { sql += " AND IdPaciente = @ent"; ps.Add(new MySqlParameter("@ent", entidad)); }
                    if (estado != "Todos") { sql += " AND Activo = @est"; ps.Add(new MySqlParameter("@est", estado == "Activo" ? 1 : 0)); }
                    break;

                case "Citas":
                    campoFecha = "FechaHora";
                    sql = @"SELECT IdCita, FechaHora, CedulaPaciente, Paciente, Medico, Especialidad, Motivo, Estado
                            FROM vw_Citas WHERE 1 = 1";
                    if (entidad > 0) { sql += " AND IdMedico = @ent"; ps.Add(new MySqlParameter("@ent", entidad)); }
                    if (estado != "Todos") { sql += " AND Estado = @est"; ps.Add(new MySqlParameter("@est", estado)); }
                    break;

                case "Consultas":
                    campoFecha = "co.Fecha";
                    sql = @"SELECT co.IdConsulta, co.Fecha, CONCAT(p.Nombre, ' ', p.Apellido) AS Paciente,
                                CONCAT('Dr(a). ', m.Nombre, ' ', m.Apellido) AS Medico,
                                es.Nombre AS Especialidad, co.Diagnostico, co.Tratamiento
                            FROM Consultas co
                                INNER JOIN Pacientes p ON p.IdPaciente = co.IdPaciente
                                INNER JOIN Medicos m ON m.IdMedico = co.IdMedico
                                INNER JOIN Especialidades es ON es.IdEspecialidad = m.IdEspecialidad
                            WHERE 1 = 1";
                    if (entidad > 0) { sql += " AND co.IdMedico = @ent"; ps.Add(new MySqlParameter("@ent", entidad)); }
                    break;

                case "Historial":
                    campoFecha = "Fecha";
                    sql = @"SELECT IdConsulta, Fecha, Paciente, EdadEnConsulta, TipoSangre, Medico, Especialidad,
                                Sintomas, Diagnostico, Tratamiento, Observaciones
                            FROM vw_HistorialClinico WHERE 1 = 1";
                    if (entidad > 0) { sql += " AND IdPaciente = @ent"; ps.Add(new MySqlParameter("@ent", entidad)); }
                    break;

                default: // Facturación
                    campoFecha = "Fecha";
                    sql = @"SELECT NumeroFactura, Fecha, Paciente, Subtotal, ITBMS, Total, Estado, MetodoPago, EmitidaPor
                            FROM vw_Facturas WHERE 1 = 1";
                    if (entidad > 0) { sql += " AND IdPaciente = @ent"; ps.Add(new MySqlParameter("@ent", entidad)); }
                    if (estado != "Todos") { sql += " AND Estado = @est"; ps.Add(new MySqlParameter("@est", estado)); }
                    break;
            }

            // Rango de fechas (el día final se incluye completo)
            if (filtrarFechas)
            {
                sql += " AND " + campoFecha + " >= @desde AND " + campoFecha + " < @hasta";
                ps.Add(new MySqlParameter("@desde", dtpFechaInferior.Value.Date));
                ps.Add(new MySqlParameter("@hasta", dtpFechaSuperior.Value.Date.AddDays(1)));
            }
            sql += " ORDER BY " + campoFecha + " DESC";

            try
            {
                DataTable dt = datos.Consultar(sql, ps.ToArray());
                Ui.Enlazar(dgvRegistroPacientes, dt);
                grpVerPacientes.Text = "Ver Reporte - " + tipo + " (" + dt.Rows.Count + " registros)";
                datos.Bitacora("Reportes", "CONSULTAR", "Reporte de " + tipo);

                if (dt.Rows.Count == 0) Ui.Info("No hay datos para los filtros elegidos.");
            }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (cmbBuscarPor.Enabled && cmbBuscarPor.Items.Count > 0) cmbBuscarPor.SelectedIndex = 0;
            if (cmbEstado.Enabled && cmbEstado.Items.Count > 0) cmbEstado.SelectedIndex = 0;
            FechasPorDefecto();

            dgvRegistroPacientes.DataSource = null;
            grpVerPacientes.Text = "Ver Reporte";
        }
    }
}
