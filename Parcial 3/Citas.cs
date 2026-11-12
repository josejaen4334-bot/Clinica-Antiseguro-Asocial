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
        private readonly DatosClinica datos = new DatosClinica();
        private readonly ToolTip detalle = new ToolTip();

        // Primer día del mes que se está viendo en el calendario
        private DateTime mesActual = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

        public frmCitas()
        {
            InitializeComponent();

            // Botones del calendario (no tenían evento en el diseño)
            this.Load += frmCitas_Load;
            btnAtras.Click += btnAtras_Click;
            btnAdelante.Click += btnAdelante_Click;
            btnHoy.Click += btnHoy_Click;
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            PintarCalendario();
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            frmRegistroCitas registroCitas = new frmRegistroCitas();
            registroCitas.Show();
            this.Close();
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

        // ---------- Navegación del calendario ----------

        private void btnAtras_Click(object sender, EventArgs e)
        {
            mesActual = mesActual.AddMonths(-1);
            PintarCalendario();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            mesActual = mesActual.AddMonths(1);
            PintarCalendario();
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            mesActual = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            PintarCalendario();
        }

        // Dibuja el mes en las 42 casillas (6 semanas x 7 días) con las citas guardadas en la BD
        private void PintarCalendario()
        {
            string mes = new System.Globalization.CultureInfo("es").DateTimeFormat.GetMonthName(mesActual.Month);
            lblMesAnio.Text = char.ToUpper(mes[0]) + mes.Substring(1) + " " + mesActual.Year;

            // La primera casilla es el domingo de la semana en que cae el día 1
            DateTime inicio = mesActual.AddDays(-(int)mesActual.DayOfWeek);

            // Se traen de una vez todas las citas del rango visible y se agrupan por día
            Dictionary<DateTime, List<DataRow>> porDia = new Dictionary<DateTime, List<DataRow>>();
            try
            {
                foreach (DataRow f in datos.ListarCitasRango(inicio, inicio.AddDays(42)).Rows)
                {
                    DateTime dia = ((DateTime)f["FechaHora"]).Date;
                    if (!porDia.ContainsKey(dia)) porDia[dia] = new List<DataRow>();
                    porDia[dia].Add(f);
                }
            }
            catch (Exception ex) { Ui.Error(ex); }

            for (int fila = 0; fila < 6; fila++)
            {
                for (int col = 0; col < 7; col++)
                {
                    FlowLayoutPanel celda = tlpCalendario.GetControlFromPosition(col, fila) as FlowLayoutPanel;
                    if (celda == null) continue;

                    DateTime dia = inicio.AddDays(fila * 7 + col);

                    celda.SuspendLayout();
                    while (celda.Controls.Count > 0) celda.Controls[0].Dispose();
                    celda.FlowDirection = FlowDirection.TopDown;
                    celda.WrapContents = false;
                    celda.AutoScroll = true;

                    // Número del día (gris si es de otro mes, resaltado si es hoy)
                    Label lblDia = new Label();
                    lblDia.AutoSize = true;
                    lblDia.Text = dia.Day.ToString();
                    lblDia.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
                    lblDia.ForeColor = dia.Month == mesActual.Month ? Color.Black : Color.Gray;
                    if (dia.Date == DateTime.Today) lblDia.BackColor = Color.LightSkyBlue;
                    celda.Controls.Add(lblDia);

                    // Una línea por cita: hora + paciente, con el color según el estado
                    if (porDia.ContainsKey(dia))
                    {
                        foreach (DataRow c in porDia[dia])
                        {
                            Label lblCita = new Label();
                            lblCita.AutoSize = false;
                            lblCita.AutoEllipsis = true;
                            lblCita.Width = Math.Max(celda.ClientSize.Width - 8, 60);
                            lblCita.Height = 16;
                            lblCita.Font = new Font("Segoe UI", 7.5f);
                            lblCita.Text = ((DateTime)c["FechaHora"]).ToString("HH:mm") + " " + c["Paciente"];
                            lblCita.ForeColor = ColorEstado(Convert.ToString(c["Estado"]));
                            detalle.SetToolTip(lblCita,
                                c["Paciente"] + "\n" + c["Medico"] + "\n" + c["Motivo"] + "\nEstado: " + c["Estado"]);
                            celda.Controls.Add(lblCita);
                        }
                    }
                    celda.ResumeLayout();
                }
            }
        }

        private Color ColorEstado(string estado)
        {
            switch (estado)
            {
                case "Atendida": return Color.SeaGreen;
                case "Cancelada": return Color.Gray;
                case "No asistió": return Color.Firebrick;
                default: return Color.RoyalBlue; // Programada
            }
        }
    }
}
