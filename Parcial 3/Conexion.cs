using MySqlConnector;
using System.Configuration;
using System.Data.SqlClient;

namespace Parcial_3
{
    public class Conexion
    {
        private readonly string cadena;

        public Conexion()
        {
            cadena = ConfigurationManager.ConnectionStrings["ClinicaCIA"].ConnectionString;
        }

        public MySqlConnection Conectar()
        {
            MySqlConnection cn = new MySqlConnection(cadena);
            cn.Open();
            return cn;
        }
    }
}