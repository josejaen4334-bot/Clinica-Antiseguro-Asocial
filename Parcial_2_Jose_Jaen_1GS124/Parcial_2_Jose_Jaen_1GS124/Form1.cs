namespace Parcial_2_Jose_Jaen_1GS124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblUniversidad.Text = "Universidad Tecnologica de Panamá";
            lblFacultad.Text = "Facultad de Ingeniería de Sistemas Computacionales";
            lblMateria.Text = "Materia: ";
            lblAsignatura.Text = "Desarrollo de Software IV";
            lblTituloParcial.Text = "Parcial 2 - Windows Forms";
            lblEstudiante.Text = "Estudiante:";
            lblNombreEstudiante.Text = "Jose Jaen 8-1049-1944";
            lblFecha.Text = "Fecha:";
            lblFechaParcial.Text = "Jueves 1 de Octubre de 2026";
        }

        private void lblUniversidad_Click(object sender, EventArgs e)
        {

        }

        private void lblFacultad_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Registro_Clientes form2 = new Registro_Clientes();
            form2.Show();
            this.Hide();
        }

        private void lblFechaParcial_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}