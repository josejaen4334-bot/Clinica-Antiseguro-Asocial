using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace Parcial_3
{
    public class DatosClinica
    {
        private readonly string cadena =
            ConfigurationManager.ConnectionStrings["ClinicaCIA"].ConnectionString;

        private MySqlConnection Conectar()
        {
            MySqlConnection cn = new MySqlConnection(cadena);
            cn.Open();
            return cn;
        }

        public void GuardarPaciente(string cedula, string nombre, string apellido,
            string genero, DateTime nacimiento, string telefono, string correo,
            string direccion, string sangre)
        {
            using (MySqlConnection cn = Conectar())
            {
                string sql = @"INSERT INTO Pacientes
                    (Cedula, Nombre, Apellido, Genero, FechaNacimiento,
                     Telefono, Correo, Direccion, TipoSangre)
                    VALUES
                    (@cedula, @nombre, @apellido, @genero, @fecha,
                     @telefono, @correo, @direccion, @sangre)";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@fecha", nacimiento.Date);
                    cmd.Parameters.AddWithValue("@telefono", string.IsNullOrWhiteSpace(telefono) ? (object)DBNull.Value : telefono);
                    cmd.Parameters.AddWithValue("@correo", string.IsNullOrWhiteSpace(correo) ? (object)DBNull.Value : correo);
                    cmd.Parameters.AddWithValue("@direccion", string.IsNullOrWhiteSpace(direccion) ? (object)DBNull.Value : direccion);
                    cmd.Parameters.AddWithValue("@sangre", string.IsNullOrWhiteSpace(sangre) ? (object)DBNull.Value : sangre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void GuardarMedico(string cedula, string nombre, string apellido,
            string genero, DateTime contratacion, string telefono, string correo,
            string licencia, int especialidad, string estado)
        {
            using (MySqlConnection cn = Conectar())
            {
                string sql = @"INSERT INTO Medicos
                    (Cedula, Nombre, Apellido, Genero, FechaContratacion,
                     Telefono, Correo, Licencia, IdEspecialidad, Estado)
                    VALUES
                    (@cedula, @nombre, @apellido, @genero, @fecha,
                     @telefono, @correo, @licencia, @especialidad, @estado)";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@fecha", contratacion.Date);
                    cmd.Parameters.AddWithValue("@telefono", string.IsNullOrWhiteSpace(telefono) ? (object)DBNull.Value : telefono);
                    cmd.Parameters.AddWithValue("@correo", string.IsNullOrWhiteSpace(correo) ? (object)DBNull.Value : correo);
                    cmd.Parameters.AddWithValue("@licencia", licencia);
                    cmd.Parameters.AddWithValue("@especialidad", especialidad);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void GuardarEmpleado(string cedula, string nombre, string apellido,
            string genero, DateTime contratacion, string telefono, string correo,
            int cargo, string estado)
        {
            using (MySqlConnection cn = Conectar())
            {
                string sql = @"INSERT INTO Empleados
                    (Cedula, Nombre, Apellido, Genero, FechaContratacion,
                     Telefono, Correo, IdCargo, Estado)
                    VALUES
                    (@cedula, @nombre, @apellido, @genero, @fecha,
                     @telefono, @correo, @cargo, @estado)";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@fecha", contratacion.Date);
                    cmd.Parameters.AddWithValue("@telefono", string.IsNullOrWhiteSpace(telefono) ? (object)DBNull.Value : telefono);
                    cmd.Parameters.AddWithValue("@correo", string.IsNullOrWhiteSpace(correo) ? (object)DBNull.Value : correo);
                    cmd.Parameters.AddWithValue("@cargo", cargo);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int ObtenerIdEspecialidad(string nombre)
        {
            nombre = nombre.Trim();

            switch (nombre)
            {
                case "Oftalmologia": nombre = "Oftalmología"; break;
                case "Cirugia": nombre = "Cirugía"; break;
                case "Odontologia": nombre = "Odontología"; break;
                case "Cardiologo":
                case "Cardiologia": nombre = "Cardiología"; break;
            }

            using (MySqlConnection cn = Conectar())
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT IdEspecialidad FROM Especialidades WHERE Nombre = @nombre", cn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                    throw new Exception("No se encontró la especialidad seleccionada en la tabla Especialidades.");

                return Convert.ToInt32(resultado);
            }
        }

        public int ObtenerIdCargo(string nombre)
        {
            using (MySqlConnection cn = Conectar())
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT IdCargo FROM Cargos WHERE Nombre = @nombre", cn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre.Trim());
                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                    throw new Exception("No se encontró el cargo seleccionado en la tabla Cargos.");

                return Convert.ToInt32(resultado);
            }
        }

        // =====================================================================
        //  METODOS NUEVOS (se agregaron debajo de los que ya existian)
        // =====================================================================

        // ---------- Utilidades genericas de acceso a datos ----------

        // Crea un parametro; si el valor es null o texto vacio se manda NULL a la BD
        public static MySqlParameter P(string nombre, object valor)
        {
            if (valor == null) valor = DBNull.Value;
            else if (valor is string && string.IsNullOrWhiteSpace((string)valor)) valor = DBNull.Value;
            return new MySqlParameter(nombre, valor);
        }

        // Ejecuta un SELECT y devuelve el resultado en un DataTable
        public DataTable Consultar(string sql, params MySqlParameter[] parametros)
        {
            using (MySqlConnection cn = Conectar())
            using (MySqlCommand cmd = new MySqlCommand(sql, cn))
            {
                if (parametros != null && parametros.Length > 0)
                    cmd.Parameters.AddRange(parametros);

                DataTable dt = new DataTable();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
                return dt;
            }
        }

        // Ejecuta INSERT / UPDATE / DELETE y devuelve las filas afectadas
        public int Ejecutar(string sql, params MySqlParameter[] parametros)
        {
            using (MySqlConnection cn = Conectar())
            using (MySqlCommand cmd = new MySqlCommand(sql, cn))
            {
                if (parametros != null && parametros.Length > 0)
                    cmd.Parameters.AddRange(parametros);
                return cmd.ExecuteNonQuery();
            }
        }

        // ---------- Login y bitacora ----------

        // Valida usuario/contrasena/rol con el procedimiento sp_Login de la BD.
        // Si es correcto llena la clase Sesion y devuelve true.
        public bool IniciarSesion(string usuario, string clave, string rol)
        {
            using (MySqlConnection cn = Conectar())
            using (MySqlCommand cmd = new MySqlCommand("CALL sp_Login(@u, @c, @r)", cn))
            {
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@c", clave);
                cmd.Parameters.AddWithValue("@r", rol);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    // Si el acceso es invalido el procedimiento no devuelve filas
                    if (!dr.HasRows || !dr.Read()) return false;

                    Sesion.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    Sesion.NombreUsuario = Convert.ToString(dr["NombreUsuario"]);
                    Sesion.Rol = Convert.ToString(dr["Rol"]);
                    Sesion.Persona = Convert.ToString(dr["PersonaVinculada"]);
                    Sesion.IdMedico = dr["IdMedico"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["IdMedico"]);
                    Sesion.IdPaciente = dr["IdPaciente"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["IdPaciente"]);
                    return true;
                }
            }
        }

        // Guarda quien hizo que en la tabla Bitacora (si falla no interrumpe al usuario)
        public void Bitacora(string modulo, string accion, string descripcion)
        {
            try
            {
                if (descripcion != null && descripcion.Length > 400) descripcion = descripcion.Substring(0, 400);
                Ejecutar("CALL sp_RegistrarBitacora(@u, @m, @a, @d)",
                    P("@u", Sesion.IdUsuario > 0 ? (object)Sesion.IdUsuario : null),
                    P("@m", modulo), P("@a", accion), P("@d", descripcion));
            }
            catch { /* la bitacora nunca debe detener la operacion principal */ }
        }

        // ---------- Listas para los ComboBox ----------

        public DataTable ListarEspecialidades()
        {
            return Consultar("SELECT IdEspecialidad, Nombre FROM Especialidades ORDER BY Nombre");
        }

        public DataTable ListarCargos()
        {
            return Consultar("SELECT IdCargo, Nombre FROM Cargos ORDER BY Nombre");
        }

        public DataTable ListarMedicosCombo()
        {
            return Consultar(@"SELECT IdMedico, Estado,
                    CONCAT('Dr(a). ', Nombre, ' ', Apellido,
                           IF(Estado = 'Activo', '', CONCAT(' (', Estado, ')'))) AS Nombre
                FROM Medicos ORDER BY Apellido, Nombre");
        }

        public DataTable ListarPacientesCombo()
        {
            return Consultar(@"SELECT IdPaciente,
                    CONCAT(Nombre, ' ', Apellido, ' (', Cedula, ')') AS Nombre
                FROM Pacientes WHERE Activo = 1 ORDER BY Apellido, Nombre");
        }

        // ---------- Pacientes ----------

        public DataTable ListarPacientes(string filtro)
        {
            return Consultar(@"SELECT IdPaciente, Cedula, Nombre, Apellido,
                    CASE Genero WHEN 'M' THEN 'Masculino' ELSE 'Femenino' END AS Genero,
                    FechaNacimiento, Telefono, Correo, Direccion, TipoSangre
                FROM Pacientes
                WHERE Activo = 1
                  AND (@f = '' OR Cedula LIKE @l OR Nombre LIKE @l OR Apellido LIKE @l
                       OR CONCAT(Nombre, ' ', Apellido) LIKE @l)
                ORDER BY Apellido, Nombre",
                new MySqlParameter("@f", filtro ?? ""), new MySqlParameter("@l", "%" + filtro + "%"));
        }

        public void ActualizarPaciente(int id, string cedula, string nombre, string apellido,
            string genero, DateTime nacimiento, string telefono, string correo,
            string direccion, string sangre)
        {
            Ejecutar(@"UPDATE Pacientes SET Cedula=@cedula, Nombre=@nombre, Apellido=@apellido,
                    Genero=@genero, FechaNacimiento=@fecha, Telefono=@telefono, Correo=@correo,
                    Direccion=@direccion, TipoSangre=@sangre
                WHERE IdPaciente=@id",
                P("@cedula", cedula), P("@nombre", nombre), P("@apellido", apellido), P("@genero", genero),
                P("@fecha", nacimiento.Date), P("@telefono", telefono), P("@correo", correo),
                P("@direccion", direccion), P("@sangre", sangre), P("@id", id));
        }

        // "Eliminar" paciente: se desactiva (Activo = 0) para no perder su historial ni sus facturas
        public void DesactivarPaciente(int id)
        {
            Ejecutar("UPDATE Pacientes SET Activo = 0 WHERE IdPaciente = @id", P("@id", id));
        }

        // ---------- Medicos ----------

        public DataTable ListarMedicos(string filtro)
        {
            return Consultar(@"SELECT * FROM vw_Medicos
                WHERE (@f = '' OR Cedula LIKE @l OR Nombre LIKE @l OR Apellido LIKE @l
                       OR Licencia LIKE @l OR Especialidad LIKE @l
                       OR CONCAT(Nombre, ' ', Apellido) LIKE @l)
                ORDER BY Apellido, Nombre",
                new MySqlParameter("@f", filtro ?? ""), new MySqlParameter("@l", "%" + filtro + "%"));
        }

        public void ActualizarMedico(int id, string cedula, string nombre, string apellido,
            string genero, DateTime contratacion, string telefono, string correo,
            string licencia, int especialidad, string estado)
        {
            Ejecutar(@"UPDATE Medicos SET Cedula=@cedula, Nombre=@nombre, Apellido=@apellido,
                    Genero=@genero, FechaContratacion=@fecha, Telefono=@telefono, Correo=@correo,
                    Licencia=@licencia, IdEspecialidad=@esp, Estado=@estado
                WHERE IdMedico=@id",
                P("@cedula", cedula), P("@nombre", nombre), P("@apellido", apellido), P("@genero", genero),
                P("@fecha", contratacion.Date), P("@telefono", telefono), P("@correo", correo),
                P("@licencia", licencia), P("@esp", especialidad), P("@estado", estado), P("@id", id));
        }

        // "Eliminar" medico: pasa a Inactivo (tiene citas, consultas y facturas ligadas)
        public void DesactivarMedico(int id)
        {
            Ejecutar("UPDATE Medicos SET Estado = 'Inactivo' WHERE IdMedico = @id", P("@id", id));
        }

        // ---------- Empleados ----------

        public DataTable ListarEmpleados(string filtro)
        {
            return Consultar(@"SELECT * FROM vw_Empleados
                WHERE (@f = '' OR Cedula LIKE @l OR Nombre LIKE @l OR Apellido LIKE @l
                       OR Cargo LIKE @l OR CONCAT(Nombre, ' ', Apellido) LIKE @l)
                ORDER BY Apellido, Nombre",
                new MySqlParameter("@f", filtro ?? ""), new MySqlParameter("@l", "%" + filtro + "%"));
        }

        public void ActualizarEmpleado(int id, string cedula, string nombre, string apellido,
            string genero, DateTime contratacion, string telefono, string correo,
            int cargo, string estado)
        {
            Ejecutar(@"UPDATE Empleados SET Cedula=@cedula, Nombre=@nombre, Apellido=@apellido,
                    Genero=@genero, FechaContratacion=@fecha, Telefono=@telefono, Correo=@correo,
                    IdCargo=@cargo, Estado=@estado
                WHERE IdEmpleado=@id",
                P("@cedula", cedula), P("@nombre", nombre), P("@apellido", apellido), P("@genero", genero),
                P("@fecha", contratacion.Date), P("@telefono", telefono), P("@correo", correo),
                P("@cargo", cargo), P("@estado", estado), P("@id", id));
        }

        // "Eliminar" empleado: pasa a Inactivo
        public void DesactivarEmpleado(int id)
        {
            Ejecutar("UPDATE Empleados SET Estado = 'Inactivo' WHERE IdEmpleado = @id", P("@id", id));
        }

        // ---------- Citas ----------

        public DataTable ListarCitas()
        {
            return Consultar("SELECT * FROM vw_Citas ORDER BY FechaHora DESC");
        }

        // Citas de un rango de fechas (se usa para pintar el calendario del mes)
        public DataTable ListarCitasRango(DateTime desde, DateTime hasta)
        {
            return Consultar(@"SELECT IdCita, FechaHora, Paciente, Medico, Motivo, Estado
                FROM vw_Citas WHERE FechaHora >= @d AND FechaHora < @h ORDER BY FechaHora",
                P("@d", desde), P("@h", hasta));
        }

        public void GuardarCita(int paciente, int medico, DateTime fechaHora, string motivo, string estado)
        {
            Ejecutar(@"INSERT INTO Citas (IdPaciente, IdMedico, FechaHora, Motivo, Estado, IdUsuarioRegistro)
                VALUES (@p, @m, @f, @mo, @e, @u)",
                P("@p", paciente), P("@m", medico), P("@f", fechaHora), P("@mo", motivo),
                P("@e", estado), P("@u", Sesion.IdUsuario));
        }

        public void ActualizarCita(int id, int paciente, int medico, DateTime fechaHora, string motivo, string estado)
        {
            Ejecutar(@"UPDATE Citas SET IdPaciente=@p, IdMedico=@m, FechaHora=@f, Motivo=@mo, Estado=@e
                WHERE IdCita=@id",
                P("@p", paciente), P("@m", medico), P("@f", fechaHora), P("@mo", motivo),
                P("@e", estado), P("@id", id));
        }

        // "Eliminar" cita: queda como Cancelada (asi no se pierde el registro)
        public void CancelarCita(int id)
        {
            Ejecutar("UPDATE Citas SET Estado = 'Cancelada' WHERE IdCita = @id", P("@id", id));
        }

        // ---------- Consultas / historial clinico ----------

        public DataRow ObtenerPaciente(int id)
        {
            DataTable dt = Consultar("SELECT * FROM Pacientes WHERE IdPaciente = @id", P("@id", id));
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public void GuardarConsulta(int paciente, int medico, string sintomas, string diagnostico,
            string tratamiento, string observaciones)
        {
            Ejecutar(@"INSERT INTO Consultas (IdPaciente, IdMedico, Fecha, Sintomas, Diagnostico, Tratamiento, Observaciones)
                VALUES (@p, @m, @f, @s, @d, @t, @o)",
                P("@p", paciente), P("@m", medico), P("@f", DateTime.Now), P("@s", sintomas),
                P("@d", diagnostico), P("@t", tratamiento), P("@o", observaciones));
        }

        public DataTable ListarConsultasPaciente(int paciente)
        {
            return Consultar(@"SELECT co.IdConsulta, co.Fecha,
                    CONCAT('Dr(a). ', m.Nombre, ' ', m.Apellido) AS Medico,
                    es.Nombre AS Especialidad,
                    co.Sintomas, co.Diagnostico, co.Tratamiento, co.Observaciones
                FROM Consultas co
                    INNER JOIN Medicos m ON m.IdMedico = co.IdMedico
                    INNER JOIN Especialidades es ON es.IdEspecialidad = m.IdEspecialidad
                WHERE co.IdPaciente = @p ORDER BY co.Fecha DESC",
                P("@p", paciente));
        }

        public void ActualizarConsulta(int id, string sintomas, string diagnostico,
            string tratamiento, string observaciones)
        {
            Ejecutar(@"UPDATE Consultas SET Sintomas=@s, Diagnostico=@d, Tratamiento=@t, Observaciones=@o
                WHERE IdConsulta=@id",
                P("@s", sintomas), P("@d", diagnostico), P("@t", tratamiento), P("@o", observaciones), P("@id", id));
        }

        public void EliminarConsulta(int id)
        {
            Ejecutar("DELETE FROM Consultas WHERE IdConsulta = @id", P("@id", id));
        }

        // ---------- Facturacion ----------

        // Servicios que se pueden cobrar, sacados de los precios guardados en la BD
        public DataTable ListarServicios()
        {
            return Consultar(@"SELECT CONCAT('Consulta - ', Nombre) AS Descripcion, CostoConsulta AS Precio
                FROM Especialidades
                UNION ALL
                SELECT CONCAT('Estancia habitacion ', Tipo, ' (por dia)'), MIN(PrecioDia)
                FROM Habitaciones GROUP BY Tipo");
        }

        // Guarda la factura y sus lineas en una sola transaccion (o se guarda todo o nada).
        // lineas: cada item es { concepto (string), cantidad (int), precio (decimal) }
        public int GuardarFactura(int paciente, DateTime fecha, string metodoPago, List<object[]> lineas)
        {
            using (MySqlConnection cn = Conectar())
            using (MySqlTransaction tx = cn.BeginTransaction())
            {
                int idFactura;
                // Si se eligio un metodo de pago queda Pagada; si no, Pendiente
                string estado = string.IsNullOrWhiteSpace(metodoPago) ? "Pendiente" : "Pagada";

                using (MySqlCommand cmd = new MySqlCommand(@"INSERT INTO Facturas
                        (IdPaciente, Fecha, PorcentajeITBMS, Estado, MetodoPago, IdUsuario)
                    VALUES (@p, @f, 0, @e, @m, @u)", cn, tx))
                {
                    cmd.Parameters.Add(P("@p", paciente));
                    cmd.Parameters.Add(P("@f", fecha));
                    cmd.Parameters.Add(P("@e", estado));
                    cmd.Parameters.Add(P("@m", metodoPago));
                    cmd.Parameters.Add(P("@u", Sesion.IdUsuario));
                    cmd.ExecuteNonQuery();
                    idFactura = (int)cmd.LastInsertedId;
                }

                foreach (object[] l in lineas)
                {
                    using (MySqlCommand cmd = new MySqlCommand(@"INSERT INTO DetalleFactura
                            (IdFactura, Concepto, Cantidad, PrecioUnitario)
                        VALUES (@fa, @c, @q, @pr)", cn, tx))
                    {
                        cmd.Parameters.Add(P("@fa", idFactura));
                        cmd.Parameters.Add(P("@c", l[0]));
                        cmd.Parameters.Add(P("@q", l[1]));
                        cmd.Parameters.Add(P("@pr", l[2]));
                        cmd.ExecuteNonQuery();
                    }
                }

                tx.Commit();
                return idFactura;
            }
        }
    }

    // Datos del usuario que inicio sesion (se llena en el Login y se usa en los demas Forms)
    public static class Sesion
    {
        public static int IdUsuario;
        public static string NombreUsuario;
        public static string Rol;
        public static string Persona;           // nombre de la persona vinculada (medico, empleado o paciente)
        public static int? IdMedico;
        public static int? IdPaciente;

        // Paciente que se selecciono en el Historial Clinico (lo usa el Form de Consultas)
        public static int IdPacienteSeleccionado;

        public static void Cerrar()
        {
            IdUsuario = 0;
            NombreUsuario = null;
            Rol = null;
            Persona = null;
            IdMedico = null;
            IdPaciente = null;
            IdPacienteSeleccionado = 0;
        }
    }

    // Funciones de apoyo que se repiten en varios Forms (mensajes, grids, validaciones)
    public static class Ui
    {
        public static void Info(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica CIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica CIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirmar(string pregunta)
        {
            return MessageBox.Show(pregunta, "Clinica CIA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;
        }

        // Convierte los errores de MySQL en mensajes que el usuario entienda
        public static void Error(Exception ex)
        {
            string msg;
            MySqlException my = ex as MySqlException;

            if (my != null)
            {
                switch (my.Number)
                {
                    case 1062: // llave unica repetida
                        if (my.Message.Contains("MedicoFechaHora")) msg = "Ese medico ya tiene una cita a esa fecha y hora.";
                        else if (my.Message.Contains("Cedula")) msg = "Ya existe un registro con esa cedula.";
                        else if (my.Message.Contains("Licencia")) msg = "Ya existe un medico con esa licencia.";
                        else msg = "Ya existe un registro con esos datos.";
                        break;
                    case 1451: msg = "No se puede eliminar porque tiene registros relacionados (citas, facturas, etc.)."; break;
                    case 1452: msg = "Uno de los datos seleccionados no existe en la base de datos."; break;
                    case 3819: msg = "Algun dato no cumple las reglas de la base de datos (genero, estado, tipo de sangre, etc.)."; break;
                    case 1644: msg = my.Message; break; // mensajes de los triggers de la BD
                    default:
                        msg = "Error de base de datos: " + my.Message
                            + "\n\nVerifique que MySQL este encendido y que la cadena de conexion en App.config sea correcta.";
                        break;
                }
            }
            else
            {
                msg = "Ocurrio un error: " + ex.Message;
            }

            MessageBox.Show(msg, "Clinica CIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool CorreoValido(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo)) return true; // el correo es opcional
            return System.Text.RegularExpressions.Regex.IsMatch(correo.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Configuracion comun de las tablas: solo lectura, fila completa, sin fila vacia al final
        public static void ConfigurarGrid(DataGridView dgv, bool soloLectura = true)
        {
            dgv.ReadOnly = soloLectura;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Muestra un DataTable en el grid, oculta columnas internas (ids) y da formato a las fechas
        public static void Enlazar(DataGridView dgv, DataTable dt, params string[] ocultar)
        {
            dgv.DataSource = dt;

            foreach (string nombre in ocultar)
                if (dgv.Columns.Contains(nombre)) dgv.Columns[nombre].Visible = false;

            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType != typeof(DateTime) || !dgv.Columns.Contains(col.ColumnName)) continue;

                // Si alguna fecha trae hora se muestra con hora, si no solo la fecha
                bool conHora = false;
                foreach (DataRow r in dt.Rows)
                    if (r[col] != DBNull.Value && ((DateTime)r[col]).TimeOfDay != TimeSpan.Zero) { conHora = true; break; }

                dgv.Columns[col.ColumnName].DefaultCellStyle.Format = conHora ? "dd/MM/yyyy HH:mm" : "dd/MM/yyyy";
            }

            dgv.ClearSelection();
        }

        // Llena un ComboBox con los datos de una tabla de la BD
        public static void LlenarCombo(ComboBox cmb, DataTable dt, string mostrar, string valor)
        {
            cmb.DataSource = dt;
            cmb.DisplayMember = mostrar;
            cmb.ValueMember = valor;
            cmb.SelectedIndex = -1;
        }

        // Hace que el texto de ejemplo ("Buscar...") desaparezca al escribir y vuelva si queda vacio
        public static void Placeholder(TextBox txt)
        {
            string ejemplo = txt.Text;
            txt.Tag = ejemplo;
            txt.Enter += delegate { if (txt.Text == ejemplo) txt.Text = ""; };
            txt.Leave += delegate { if (txt.Text.Trim() == "") txt.Text = ejemplo; };
        }

        // Texto realmente escrito por el usuario (vacio si todavia esta el texto de ejemplo)
        public static string Escrito(TextBox txt)
        {
            string ejemplo = txt.Tag as string;
            return (ejemplo != null && txt.Text == ejemplo) ? "" : txt.Text.Trim();
        }

        public static void RestaurarPlaceholder(TextBox txt)
        {
            string ejemplo = txt.Tag as string;
            if (ejemplo != null) txt.Text = ejemplo;
        }
    }
}