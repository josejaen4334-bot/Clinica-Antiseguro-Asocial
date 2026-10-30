namespace Parcial_2_Jose_Jaen_1GS124
{
    partial class Registro_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Clientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pctrLOGO = new PictureBox();
            lblRegistro = new Label();
            pctrLinea = new PictureBox();
            grpBoxDatosClientes = new GroupBox();
            nmrcUpDownNumeroConsultas = new NumericUpDown();
            lblNumeroConsultas = new Label();
            lblPreferenciasServicios = new Label();
            lblCategoriaCliente = new Label();
            chckBoxOpcionLaboratorio = new CheckBox();
            chckBoxOpcionOdontologia = new CheckBox();
            chckBoxOpcionConsulta = new CheckBox();
            cmbBoxGenero = new ComboBox();
            dtTmPckrFechaNacimiento = new DateTimePicker();
            txtBoxCorreoUsuario = new TextBox();
            txtBoxTelefonoUsuario = new TextBox();
            rdBtnOpcionEmpresarial = new RadioButton();
            txtBoxCedulaUsuario = new TextBox();
            rdBtnOpcionParticular = new RadioButton();
            txtBoxApellidoUsuario = new TextBox();
            txtBoxNombreUsaurio = new TextBox();
            lblGeneroUsuaruio = new Label();
            lblFechaNacimientoUsuario = new Label();
            lblCorreoUsuario = new Label();
            lblTelefonoUsuario = new Label();
            lblCedulaUsuario = new Label();
            lblApellidoUsuario = new Label();
            lblNombreUsuario = new Label();
            grpBoxImagenUsuario = new GroupBox();
            btnAgregarImagen = new Button();
            lblSeleccionarUsuario = new Label();
            cmbBoxSeleccionarUsuario = new ComboBox();
            lblMostrarCategoriaUsuario = new Label();
            lblMostrarCedulaUsuario = new Label();
            lblMostrarNombreUsuario = new Label();
            lblVerCategoriaUsuario = new Label();
            lblVerCedulaUsuario = new Label();
            lblVerNombreUsuario = new Label();
            pctrBoxUsuario = new PictureBox();
            grpBoxClientesRegistrados = new GroupBox();
            lblTotalUsuarios = new Label();
            dtGridViewDatosUsuarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Fecha_Nacimiento = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            categoria_Cliente = new DataGridViewTextBoxColumn();
            Servicio = new DataGridViewTextBoxColumn();
            numeroConsultas = new DataGridViewTextBoxColumn();
            pctrBuscarUsuario = new PictureBox();
            txtBoxBuscarUsuarios = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSiguiente = new Button();
            svFilesDialogs = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pctrLOGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrLinea).BeginInit();
            grpBoxDatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownNumeroConsultas).BeginInit();
            grpBoxImagenUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBoxUsuario).BeginInit();
            grpBoxClientesRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewDatosUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrBuscarUsuario).BeginInit();
            SuspendLayout();
            // 
            // pctrLOGO
            // 
            pctrLOGO.BackColor = Color.Transparent;
            pctrLOGO.Image = (Image)resources.GetObject("pctrLOGO.Image");
            pctrLOGO.Location = new Point(10, 10);
            pctrLOGO.Name = "pctrLOGO";
            pctrLOGO.Size = new Size(159, 120);
            pctrLOGO.SizeMode = PictureBoxSizeMode.Zoom;
            pctrLOGO.TabIndex = 0;
            pctrLOGO.TabStop = false;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold | FontStyle.Italic);
            lblRegistro.ForeColor = Color.White;
            lblRegistro.Location = new Point(490, 9);
            lblRegistro.MaximumSize = new Size(857, 867);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(498, 62);
            lblRegistro.TabIndex = 1;
            lblRegistro.Text = "Registro de Usuarios";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // pctrLinea
            // 
            pctrLinea.BackColor = Color.LightSeaGreen;
            pctrLinea.BorderStyle = BorderStyle.FixedSingle;
            pctrLinea.Location = new Point(151, 73);
            pctrLinea.Margin = new Padding(0);
            pctrLinea.Name = "pctrLinea";
            pctrLinea.Size = new Size(1194, 10);
            pctrLinea.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrLinea.TabIndex = 2;
            pctrLinea.TabStop = false;
            // 
            // grpBoxDatosClientes
            // 
            grpBoxDatosClientes.BackColor = Color.Transparent;
            grpBoxDatosClientes.Controls.Add(nmrcUpDownNumeroConsultas);
            grpBoxDatosClientes.Controls.Add(lblNumeroConsultas);
            grpBoxDatosClientes.Controls.Add(lblPreferenciasServicios);
            grpBoxDatosClientes.Controls.Add(lblCategoriaCliente);
            grpBoxDatosClientes.Controls.Add(chckBoxOpcionLaboratorio);
            grpBoxDatosClientes.Controls.Add(chckBoxOpcionOdontologia);
            grpBoxDatosClientes.Controls.Add(chckBoxOpcionConsulta);
            grpBoxDatosClientes.Controls.Add(cmbBoxGenero);
            grpBoxDatosClientes.Controls.Add(dtTmPckrFechaNacimiento);
            grpBoxDatosClientes.Controls.Add(txtBoxCorreoUsuario);
            grpBoxDatosClientes.Controls.Add(txtBoxTelefonoUsuario);
            grpBoxDatosClientes.Controls.Add(rdBtnOpcionEmpresarial);
            grpBoxDatosClientes.Controls.Add(txtBoxCedulaUsuario);
            grpBoxDatosClientes.Controls.Add(rdBtnOpcionParticular);
            grpBoxDatosClientes.Controls.Add(txtBoxApellidoUsuario);
            grpBoxDatosClientes.Controls.Add(txtBoxNombreUsaurio);
            grpBoxDatosClientes.Controls.Add(lblGeneroUsuaruio);
            grpBoxDatosClientes.Controls.Add(lblFechaNacimientoUsuario);
            grpBoxDatosClientes.Controls.Add(lblCorreoUsuario);
            grpBoxDatosClientes.Controls.Add(lblTelefonoUsuario);
            grpBoxDatosClientes.Controls.Add(lblCedulaUsuario);
            grpBoxDatosClientes.Controls.Add(lblApellidoUsuario);
            grpBoxDatosClientes.Controls.Add(lblNombreUsuario);
            grpBoxDatosClientes.Font = new Font("Segoe UI", 9F);
            grpBoxDatosClientes.ForeColor = Color.White;
            grpBoxDatosClientes.Location = new Point(19, 136);
            grpBoxDatosClientes.Name = "grpBoxDatosClientes";
            grpBoxDatosClientes.Size = new Size(688, 288);
            grpBoxDatosClientes.TabIndex = 3;
            grpBoxDatosClientes.TabStop = false;
            grpBoxDatosClientes.Text = "Datos_Clientes";
            // 
            // nmrcUpDownNumeroConsultas
            // 
            nmrcUpDownNumeroConsultas.Location = new Point(500, 250);
            nmrcUpDownNumeroConsultas.Name = "nmrcUpDownNumeroConsultas";
            nmrcUpDownNumeroConsultas.Size = new Size(120, 27);
            nmrcUpDownNumeroConsultas.TabIndex = 16;
            // 
            // lblNumeroConsultas
            // 
            lblNumeroConsultas.AutoSize = true;
            lblNumeroConsultas.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblNumeroConsultas.ForeColor = Color.White;
            lblNumeroConsultas.Location = new Point(500, 227);
            lblNumeroConsultas.Name = "lblNumeroConsultas";
            lblNumeroConsultas.Size = new Size(155, 16);
            lblNumeroConsultas.TabIndex = 17;
            lblNumeroConsultas.Text = "Número de Consultas";
            lblNumeroConsultas.Click += lblNumeroConsultas_Click;
            // 
            // lblPreferenciasServicios
            // 
            lblPreferenciasServicios.AutoSize = true;
            lblPreferenciasServicios.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblPreferenciasServicios.ForeColor = Color.White;
            lblPreferenciasServicios.Location = new Point(497, 125);
            lblPreferenciasServicios.Name = "lblPreferenciasServicios";
            lblPreferenciasServicios.Size = new Size(173, 16);
            lblPreferenciasServicios.TabIndex = 17;
            lblPreferenciasServicios.Text = "Preferencias / Servicios";
            // 
            // lblCategoriaCliente
            // 
            lblCategoriaCliente.AutoSize = true;
            lblCategoriaCliente.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblCategoriaCliente.ForeColor = Color.White;
            lblCategoriaCliente.Location = new Point(497, 25);
            lblCategoriaCliente.Name = "lblCategoriaCliente";
            lblCategoriaCliente.Size = new Size(149, 16);
            lblCategoriaCliente.TabIndex = 16;
            lblCategoriaCliente.Text = "Categoria de Cliente";
            lblCategoriaCliente.Click += lblCategoriaCliente_Click;
            // 
            // chckBoxOpcionLaboratorio
            // 
            chckBoxOpcionLaboratorio.AutoSize = true;
            chckBoxOpcionLaboratorio.ForeColor = Color.White;
            chckBoxOpcionLaboratorio.Location = new Point(500, 195);
            chckBoxOpcionLaboratorio.Name = "chckBoxOpcionLaboratorio";
            chckBoxOpcionLaboratorio.Size = new Size(109, 24);
            chckBoxOpcionLaboratorio.TabIndex = 5;
            chckBoxOpcionLaboratorio.Text = "Laboratorio";
            chckBoxOpcionLaboratorio.UseVisualStyleBackColor = true;
            // 
            // chckBoxOpcionOdontologia
            // 
            chckBoxOpcionOdontologia.AutoSize = true;
            chckBoxOpcionOdontologia.ForeColor = Color.White;
            chckBoxOpcionOdontologia.Location = new Point(500, 172);
            chckBoxOpcionOdontologia.Name = "chckBoxOpcionOdontologia";
            chckBoxOpcionOdontologia.Size = new Size(116, 24);
            chckBoxOpcionOdontologia.TabIndex = 4;
            chckBoxOpcionOdontologia.Text = "Odontología";
            chckBoxOpcionOdontologia.UseVisualStyleBackColor = true;
            // 
            // chckBoxOpcionConsulta
            // 
            chckBoxOpcionConsulta.AutoSize = true;
            chckBoxOpcionConsulta.ForeColor = Color.White;
            chckBoxOpcionConsulta.Location = new Point(500, 148);
            chckBoxOpcionConsulta.Name = "chckBoxOpcionConsulta";
            chckBoxOpcionConsulta.Size = new Size(142, 24);
            chckBoxOpcionConsulta.TabIndex = 3;
            chckBoxOpcionConsulta.Text = "Consulta general";
            chckBoxOpcionConsulta.UseVisualStyleBackColor = true;
            // 
            // cmbBoxGenero
            // 
            cmbBoxGenero.FormattingEnabled = true;
            cmbBoxGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbBoxGenero.Location = new Point(170, 224);
            cmbBoxGenero.Name = "cmbBoxGenero";
            cmbBoxGenero.Size = new Size(290, 28);
            cmbBoxGenero.TabIndex = 13;
            cmbBoxGenero.SelectedIndexChanged += cmbBoxGenero_SelectedIndexChanged;
            // 
            // dtTmPckrFechaNacimiento
            // 
            dtTmPckrFechaNacimiento.Location = new Point(170, 191);
            dtTmPckrFechaNacimiento.Name = "dtTmPckrFechaNacimiento";
            dtTmPckrFechaNacimiento.Size = new Size(290, 27);
            dtTmPckrFechaNacimiento.TabIndex = 12;
            dtTmPckrFechaNacimiento.ValueChanged += dtTmPckrFechaNacimiento_ValueChanged;
            // 
            // txtBoxCorreoUsuario
            // 
            txtBoxCorreoUsuario.ForeColor = Color.Black;
            txtBoxCorreoUsuario.Location = new Point(113, 158);
            txtBoxCorreoUsuario.Name = "txtBoxCorreoUsuario";
            txtBoxCorreoUsuario.Size = new Size(347, 27);
            txtBoxCorreoUsuario.TabIndex = 11;
            txtBoxCorreoUsuario.TextChanged += txtBoxCorreoUsuario_TextChanged;
            // 
            // txtBoxTelefonoUsuario
            // 
            txtBoxTelefonoUsuario.ForeColor = Color.Black;
            txtBoxTelefonoUsuario.Location = new Point(113, 125);
            txtBoxTelefonoUsuario.Name = "txtBoxTelefonoUsuario";
            txtBoxTelefonoUsuario.Size = new Size(347, 27);
            txtBoxTelefonoUsuario.TabIndex = 10;
            txtBoxTelefonoUsuario.TextChanged += txtBoxTelefonoUsuario_TextChanged;
            txtBoxTelefonoUsuario.KeyPress += txtBoxTelefonoUsuario_KeyPress;
            // 
            // rdBtnOpcionEmpresarial
            // 
            rdBtnOpcionEmpresarial.AutoSize = true;
            rdBtnOpcionEmpresarial.ForeColor = Color.White;
            rdBtnOpcionEmpresarial.Location = new Point(497, 75);
            rdBtnOpcionEmpresarial.Name = "rdBtnOpcionEmpresarial";
            rdBtnOpcionEmpresarial.Size = new Size(108, 24);
            rdBtnOpcionEmpresarial.TabIndex = 1;
            rdBtnOpcionEmpresarial.TabStop = true;
            rdBtnOpcionEmpresarial.Text = "Empresarial";
            rdBtnOpcionEmpresarial.UseVisualStyleBackColor = true;
            rdBtnOpcionEmpresarial.CheckedChanged += rfdBtnOpcionEmpresarial_CheckedChanged;
            // 
            // txtBoxCedulaUsuario
            // 
            txtBoxCedulaUsuario.ForeColor = Color.Black;
            txtBoxCedulaUsuario.Location = new Point(113, 92);
            txtBoxCedulaUsuario.Name = "txtBoxCedulaUsuario";
            txtBoxCedulaUsuario.Size = new Size(347, 27);
            txtBoxCedulaUsuario.TabIndex = 9;
            txtBoxCedulaUsuario.TextChanged += txtBoxCedulaUsuario_TextChanged;
            txtBoxCedulaUsuario.KeyPress += txtBoxCedulaUsuario_KeyPress;
            // 
            // rdBtnOpcionParticular
            // 
            rdBtnOpcionParticular.AutoSize = true;
            rdBtnOpcionParticular.ForeColor = Color.White;
            rdBtnOpcionParticular.Location = new Point(497, 54);
            rdBtnOpcionParticular.Name = "rdBtnOpcionParticular";
            rdBtnOpcionParticular.Size = new Size(91, 24);
            rdBtnOpcionParticular.TabIndex = 0;
            rdBtnOpcionParticular.TabStop = true;
            rdBtnOpcionParticular.Text = "Particular";
            rdBtnOpcionParticular.UseVisualStyleBackColor = true;
            // 
            // txtBoxApellidoUsuario
            // 
            txtBoxApellidoUsuario.ForeColor = Color.Black;
            txtBoxApellidoUsuario.Location = new Point(113, 58);
            txtBoxApellidoUsuario.Name = "txtBoxApellidoUsuario";
            txtBoxApellidoUsuario.Size = new Size(347, 27);
            txtBoxApellidoUsuario.TabIndex = 8;
            txtBoxApellidoUsuario.TextChanged += txtBoxApellidoUsuario_TextChanged;
            // 
            // txtBoxNombreUsaurio
            // 
            txtBoxNombreUsaurio.ForeColor = Color.Black;
            txtBoxNombreUsaurio.Location = new Point(113, 25);
            txtBoxNombreUsaurio.Name = "txtBoxNombreUsaurio";
            txtBoxNombreUsaurio.Size = new Size(347, 27);
            txtBoxNombreUsaurio.TabIndex = 7;
            txtBoxNombreUsaurio.TextChanged += txtBoxNombreUsaurio_TextChanged;
            // 
            // lblGeneroUsuaruio
            // 
            lblGeneroUsuaruio.AutoSize = true;
            lblGeneroUsuaruio.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblGeneroUsuaruio.ForeColor = Color.White;
            lblGeneroUsuaruio.Location = new Point(15, 224);
            lblGeneroUsuaruio.Name = "lblGeneroUsuaruio";
            lblGeneroUsuaruio.Size = new Size(58, 16);
            lblGeneroUsuaruio.TabIndex = 6;
            lblGeneroUsuaruio.Text = "Género";
            // 
            // lblFechaNacimientoUsuario
            // 
            lblFechaNacimientoUsuario.AutoSize = true;
            lblFechaNacimientoUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblFechaNacimientoUsuario.ForeColor = Color.White;
            lblFechaNacimientoUsuario.Location = new Point(15, 193);
            lblFechaNacimientoUsuario.Name = "lblFechaNacimientoUsuario";
            lblFechaNacimientoUsuario.Size = new Size(154, 16);
            lblFechaNacimientoUsuario.TabIndex = 5;
            lblFechaNacimientoUsuario.Text = "Fecha de Nacimiento";
            // 
            // lblCorreoUsuario
            // 
            lblCorreoUsuario.AutoSize = true;
            lblCorreoUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblCorreoUsuario.ForeColor = Color.White;
            lblCorreoUsuario.Location = new Point(17, 161);
            lblCorreoUsuario.Name = "lblCorreoUsuario";
            lblCorreoUsuario.Size = new Size(54, 16);
            lblCorreoUsuario.TabIndex = 4;
            lblCorreoUsuario.Text = "Correo";
            // 
            // lblTelefonoUsuario
            // 
            lblTelefonoUsuario.AutoSize = true;
            lblTelefonoUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblTelefonoUsuario.ForeColor = Color.White;
            lblTelefonoUsuario.Location = new Point(17, 128);
            lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            lblTelefonoUsuario.Size = new Size(69, 16);
            lblTelefonoUsuario.TabIndex = 3;
            lblTelefonoUsuario.Text = "Teléfono";
            // 
            // lblCedulaUsuario
            // 
            lblCedulaUsuario.AutoSize = true;
            lblCedulaUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblCedulaUsuario.ForeColor = Color.White;
            lblCedulaUsuario.Location = new Point(17, 92);
            lblCedulaUsuario.Name = "lblCedulaUsuario";
            lblCedulaUsuario.Size = new Size(56, 16);
            lblCedulaUsuario.TabIndex = 2;
            lblCedulaUsuario.Text = "Cédula";
            // 
            // lblApellidoUsuario
            // 
            lblApellidoUsuario.AutoSize = true;
            lblApellidoUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblApellidoUsuario.ForeColor = Color.White;
            lblApellidoUsuario.Location = new Point(18, 58);
            lblApellidoUsuario.Name = "lblApellidoUsuario";
            lblApellidoUsuario.Size = new Size(65, 16);
            lblApellidoUsuario.TabIndex = 1;
            lblApellidoUsuario.Text = "Apellido";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(20, 28);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(62, 16);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Nombre";
            lblNombreUsuario.Click += lblNombreUsuario_Click;
            // 
            // grpBoxImagenUsuario
            // 
            grpBoxImagenUsuario.BackColor = Color.Transparent;
            grpBoxImagenUsuario.Controls.Add(btnAgregarImagen);
            grpBoxImagenUsuario.Controls.Add(lblSeleccionarUsuario);
            grpBoxImagenUsuario.Controls.Add(cmbBoxSeleccionarUsuario);
            grpBoxImagenUsuario.Controls.Add(lblMostrarCategoriaUsuario);
            grpBoxImagenUsuario.Controls.Add(lblMostrarCedulaUsuario);
            grpBoxImagenUsuario.Controls.Add(lblMostrarNombreUsuario);
            grpBoxImagenUsuario.Controls.Add(lblVerCategoriaUsuario);
            grpBoxImagenUsuario.Controls.Add(lblVerCedulaUsuario);
            grpBoxImagenUsuario.Controls.Add(lblVerNombreUsuario);
            grpBoxImagenUsuario.Controls.Add(pctrBoxUsuario);
            grpBoxImagenUsuario.Font = new Font("Segoe UI", 12F);
            grpBoxImagenUsuario.ForeColor = Color.White;
            grpBoxImagenUsuario.Location = new Point(736, 136);
            grpBoxImagenUsuario.Name = "grpBoxImagenUsuario";
            grpBoxImagenUsuario.Size = new Size(470, 288);
            grpBoxImagenUsuario.TabIndex = 14;
            grpBoxImagenUsuario.TabStop = false;
            grpBoxImagenUsuario.Text = "Imagen del Usuario";
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.Cursor = Cursors.AppStarting;
            btnAgregarImagen.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnAgregarImagen.ForeColor = Color.Black;
            btnAgregarImagen.Location = new Point(327, 236);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(123, 41);
            btnAgregarImagen.TabIndex = 26;
            btnAgregarImagen.Text = "Imagen";
            btnAgregarImagen.UseVisualStyleBackColor = true;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // lblSeleccionarUsuario
            // 
            lblSeleccionarUsuario.AutoSize = true;
            lblSeleccionarUsuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccionarUsuario.Location = new Point(260, 32);
            lblSeleccionarUsuario.Name = "lblSeleccionarUsuario";
            lblSeleccionarUsuario.Size = new Size(179, 20);
            lblSeleccionarUsuario.TabIndex = 25;
            lblSeleccionarUsuario.Text = "Seleccionar Usuario";
            // 
            // cmbBoxSeleccionarUsuario
            // 
            cmbBoxSeleccionarUsuario.ForeColor = Color.Black;
            cmbBoxSeleccionarUsuario.FormattingEnabled = true;
            cmbBoxSeleccionarUsuario.Location = new Point(260, 58);
            cmbBoxSeleccionarUsuario.Name = "cmbBoxSeleccionarUsuario";
            cmbBoxSeleccionarUsuario.Size = new Size(190, 36);
            cmbBoxSeleccionarUsuario.TabIndex = 24;
            cmbBoxSeleccionarUsuario.SelectedIndexChanged += cmbBoxSeleccionarUsuario_SelectedIndexChanged;
            cmbBoxSeleccionarUsuario.Click += cmbBoxSeleccionarUsuario_Click;
            // 
            // lblMostrarCategoriaUsuario
            // 
            lblMostrarCategoriaUsuario.AutoSize = true;
            lblMostrarCategoriaUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblMostrarCategoriaUsuario.ForeColor = Color.White;
            lblMostrarCategoriaUsuario.Location = new Point(109, 257);
            lblMostrarCategoriaUsuario.Name = "lblMostrarCategoriaUsuario";
            lblMostrarCategoriaUsuario.Size = new Size(168, 16);
            lblMostrarCategoriaUsuario.TabIndex = 23;
            lblMostrarCategoriaUsuario.Text = "Categoria del usuario...";
            // 
            // lblMostrarCedulaUsuario
            // 
            lblMostrarCedulaUsuario.AutoSize = true;
            lblMostrarCedulaUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblMostrarCedulaUsuario.ForeColor = Color.White;
            lblMostrarCedulaUsuario.Location = new Point(108, 224);
            lblMostrarCedulaUsuario.Name = "lblMostrarCedulaUsuario";
            lblMostrarCedulaUsuario.Size = new Size(149, 16);
            lblMostrarCedulaUsuario.TabIndex = 22;
            lblMostrarCedulaUsuario.Text = "Cedula del usuario...";
            // 
            // lblMostrarNombreUsuario
            // 
            lblMostrarNombreUsuario.AutoSize = true;
            lblMostrarNombreUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblMostrarNombreUsuario.ForeColor = Color.White;
            lblMostrarNombreUsuario.Location = new Point(109, 193);
            lblMostrarNombreUsuario.Name = "lblMostrarNombreUsuario";
            lblMostrarNombreUsuario.Size = new Size(155, 16);
            lblMostrarNombreUsuario.TabIndex = 21;
            lblMostrarNombreUsuario.Text = "Nombre del usuario...";
            // 
            // lblVerCategoriaUsuario
            // 
            lblVerCategoriaUsuario.AutoSize = true;
            lblVerCategoriaUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblVerCategoriaUsuario.ForeColor = Color.White;
            lblVerCategoriaUsuario.Location = new Point(22, 257);
            lblVerCategoriaUsuario.Name = "lblVerCategoriaUsuario";
            lblVerCategoriaUsuario.Size = new Size(83, 16);
            lblVerCategoriaUsuario.TabIndex = 20;
            lblVerCategoriaUsuario.Text = "Categoria: ";
            // 
            // lblVerCedulaUsuario
            // 
            lblVerCedulaUsuario.AutoSize = true;
            lblVerCedulaUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblVerCedulaUsuario.ForeColor = Color.White;
            lblVerCedulaUsuario.Location = new Point(22, 224);
            lblVerCedulaUsuario.Name = "lblVerCedulaUsuario";
            lblVerCedulaUsuario.Size = new Size(60, 16);
            lblVerCedulaUsuario.TabIndex = 19;
            lblVerCedulaUsuario.Text = "Cedula:";
            // 
            // lblVerNombreUsuario
            // 
            lblVerNombreUsuario.AutoSize = true;
            lblVerNombreUsuario.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblVerNombreUsuario.ForeColor = Color.White;
            lblVerNombreUsuario.Location = new Point(22, 191);
            lblVerNombreUsuario.Name = "lblVerNombreUsuario";
            lblVerNombreUsuario.Size = new Size(70, 16);
            lblVerNombreUsuario.TabIndex = 18;
            lblVerNombreUsuario.Text = "Nombre: ";
            lblVerNombreUsuario.Click += lblVerNombreUsuario_Click;
            // 
            // pctrBoxUsuario
            // 
            pctrBoxUsuario.AccessibleRole = AccessibleRole.None;
            pctrBoxUsuario.Image = (Image)resources.GetObject("pctrBoxUsuario.Image");
            pctrBoxUsuario.Location = new Point(22, 40);
            pctrBoxUsuario.Name = "pctrBoxUsuario";
            pctrBoxUsuario.Size = new Size(158, 130);
            pctrBoxUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pctrBoxUsuario.TabIndex = 0;
            pctrBoxUsuario.TabStop = false;
            // 
            // grpBoxClientesRegistrados
            // 
            grpBoxClientesRegistrados.BackColor = Color.Transparent;
            grpBoxClientesRegistrados.Controls.Add(lblTotalUsuarios);
            grpBoxClientesRegistrados.Controls.Add(dtGridViewDatosUsuarios);
            grpBoxClientesRegistrados.Controls.Add(pctrBuscarUsuario);
            grpBoxClientesRegistrados.Controls.Add(txtBoxBuscarUsuarios);
            grpBoxClientesRegistrados.ForeColor = Color.Black;
            grpBoxClientesRegistrados.Location = new Point(19, 441);
            grpBoxClientesRegistrados.Name = "grpBoxClientesRegistrados";
            grpBoxClientesRegistrados.Size = new Size(1327, 326);
            grpBoxClientesRegistrados.TabIndex = 4;
            grpBoxClientesRegistrados.TabStop = false;
            grpBoxClientesRegistrados.Text = "Clientes Registrados";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lblTotalUsuarios.ForeColor = Color.White;
            lblTotalUsuarios.Location = new Point(18, 77);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(219, 16);
            lblTotalUsuarios.TabIndex = 22;
            lblTotalUsuarios.Text = "Total de usuarios registrados: ";
            // 
            // dtGridViewDatosUsuarios
            // 
            dtGridViewDatosUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridViewDatosUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, Cedula, Telefono, Fecha_Nacimiento, Genero, categoria_Cliente, Servicio, numeroConsultas });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Menu;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtGridViewDatosUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            dtGridViewDatosUsuarios.Location = new Point(13, 106);
            dtGridViewDatosUsuarios.Name = "dtGridViewDatosUsuarios";
            dtGridViewDatosUsuarios.RowHeadersWidth = 51;
            dtGridViewDatosUsuarios.Size = new Size(1297, 220);
            dtGridViewDatosUsuarios.TabIndex = 2;
            dtGridViewDatosUsuarios.CellClick += dtGridViewDatosUsuarios_CellClick;
            dtGridViewDatosUsuarios.CellContentClick += dtGridViewDatosUsuarios_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Nombre";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Apellido";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Cedula";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Telefono";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Correo";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Fecha_Nacimiento
            // 
            Fecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            Fecha_Nacimiento.MinimumWidth = 6;
            Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            Fecha_Nacimiento.Width = 125;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 6;
            Genero.Name = "Genero";
            Genero.Width = 125;
            // 
            // categoria_Cliente
            // 
            categoria_Cliente.HeaderText = "Categoria de Usuario";
            categoria_Cliente.MinimumWidth = 6;
            categoria_Cliente.Name = "categoria_Cliente";
            categoria_Cliente.Width = 125;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Preferencias/Servicios";
            Servicio.MinimumWidth = 6;
            Servicio.Name = "Servicio";
            Servicio.Width = 125;
            // 
            // numeroConsultas
            // 
            numeroConsultas.HeaderText = "Numero de Consultas";
            numeroConsultas.MinimumWidth = 6;
            numeroConsultas.Name = "numeroConsultas";
            numeroConsultas.Width = 125;
            // 
            // pctrBuscarUsuario
            // 
            pctrBuscarUsuario.Cursor = Cursors.AppStarting;
            pctrBuscarUsuario.Image = (Image)resources.GetObject("pctrBuscarUsuario.Image");
            pctrBuscarUsuario.Location = new Point(1288, 23);
            pctrBuscarUsuario.Name = "pctrBuscarUsuario";
            pctrBuscarUsuario.Size = new Size(33, 29);
            pctrBuscarUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pctrBuscarUsuario.TabIndex = 1;
            pctrBuscarUsuario.TabStop = false;
            // 
            // txtBoxBuscarUsuarios
            // 
            txtBoxBuscarUsuarios.BackColor = Color.DarkGray;
            txtBoxBuscarUsuarios.ForeColor = Color.White;
            txtBoxBuscarUsuarios.Location = new Point(20, 29);
            txtBoxBuscarUsuarios.Name = "txtBoxBuscarUsuarios";
            txtBoxBuscarUsuarios.Size = new Size(1262, 23);
            txtBoxBuscarUsuarios.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.Cursor = Cursors.AppStarting;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(1223, 161);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 41);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.AppStarting;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(1223, 211);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 41);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.AppStarting;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnLimpiar.Location = new Point(1223, 264);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 41);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Cursor = Cursors.AppStarting;
            btnSiguiente.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSiguiente.Location = new Point(1223, 368);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(123, 41);
            btnSiguiente.TabIndex = 15;
            btnSiguiente.Text = "Sig";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // svFilesDialogs
            // 
            svFilesDialogs.Filter = "|*.jpg;*.png;*.jpeg;*.bmp";
            svFilesDialogs.FileOk += svFilesDialogs_FileOk;
            // 
            // Registro_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1358, 776);
            Controls.Add(btnSiguiente);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(grpBoxClientesRegistrados);
            Controls.Add(grpBoxDatosClientes);
            Controls.Add(pctrLinea);
            Controls.Add(grpBoxImagenUsuario);
            Controls.Add(lblRegistro);
            Controls.Add(pctrLOGO);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Registro_Clientes";
            Text = "Registro de Clientes";
            ((System.ComponentModel.ISupportInitialize)pctrLOGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrLinea).EndInit();
            grpBoxDatosClientes.ResumeLayout(false);
            grpBoxDatosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownNumeroConsultas).EndInit();
            grpBoxImagenUsuario.ResumeLayout(false);
            grpBoxImagenUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBoxUsuario).EndInit();
            grpBoxClientesRegistrados.ResumeLayout(false);
            grpBoxClientesRegistrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewDatosUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrBuscarUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctrClinica;
        private PictureBox pctrLOGO;
        private Label lblRegistro;
        private PictureBox pctrLinea;
        private GroupBox grpBoxDatosClientes;
        private Label lblGeneroUsuaruio;
        private Label lblFechaNacimientoUsuario;
        private Label lblCorreoUsuario;
        private Label lblTelefonoUsuario;
        private Label lblCedulaUsuario;
        private Label lblApellidoUsuario;
        private Label lblNombreUsuario;
        private ComboBox cmbBoxGenero;
        private DateTimePicker dtTmPckrFechaNacimiento;
        private TextBox txtBoxCorreoUsuario;
        private TextBox txtBoxTelefonoUsuario;
        private TextBox txtBoxCedulaUsuario;
        private TextBox txtBoxApellidoUsuario;
        private TextBox txtBoxNombreUsaurio;
        private GroupBox grpBoxClientesRegistrados;
        private TextBox txtBoxBuscarUsuarios;
        private PictureBox pctrBuscarUsuario;
        private Button btnGuardar;
        private Button btnEliminar;
        private GroupBox grpBoxImagenUsuario;
        private PictureBox pctrBoxUsuario;
        private Label lblNumeroConsultas;
        private NumericUpDown nmrcUpDownNumeroConsultas;
        private CheckBox chckBoxOpcionLaboratorio;
        private CheckBox chckBoxOpcionOdontologia;
        private CheckBox chckBoxOpcionConsulta;
        private Label lblPreferenciasServicios;
        private Label lblCategoriaCliente;
        private RadioButton rdBtnOpcionEmpresarial;
        private RadioButton rdBtnOpcionParticular;
        private Button btnLimpiar;
        private Label lblVerNombreUsuario;
        private Label lblMostrarNombreUsuario;
        private Label lblVerCategoriaUsuario;
        private Label lblVerCedulaUsuario;
        private Label lblSeleccionarUsuario;
        private Label lblMostrarCategoriaUsuario;
        private Label lblMostrarCedulaUsuario;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Fecha_Nacimiento;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn categoria_Cliente;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn numeroConsultas;
        private ComboBox cmbBoxSeleccionarUsuario;
        private Label lblTotalUsuarios;
        private Button btnSiguiente;
        private Button btnAgregarImagen;
        private SaveFileDialog svFilesDialogs;
        internal DataGridView dtGridViewDatosUsuarios;
    }
}