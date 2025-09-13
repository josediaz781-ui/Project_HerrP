using System.Data.SqlClient;

namespace Project_HerrP
{
    public static class DBConexion
    {
        // Cadena de conexión a la base de datos local de SQL Server.
        private static string cadenaConexion = "Server=localhost;Database=SistemaFacturacion;Integrated Security=True;";

        /// <summary>
        /// Abre y devuelve una nueva conexión a la base de datos.
        /// </summary>
        /// <returns>Una conexión abierta de SQL.</returns>
        public static SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        /// <summary>
        /// Cierra la conexión a la base de datos.
        /// </summary>
        /// <param name="conexion">La conexión a cerrar.</param>
        public static void CerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
