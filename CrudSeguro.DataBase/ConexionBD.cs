using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataBase
{
    internal class ConexionBD
    {
        private static readonly string CadenaConexion =
            "Server=localhost;Port=3306;Database=crud_seguro;Uid=cris;Pwd=lara#12114051;SslMode=Required;";

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
