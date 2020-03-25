using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace _1920FirstDataTest
{
    public class BaseDatos
    {

        public static DataTable ObtenerDatosPrueba()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection("Server=(localdb)\\mssqllocaldb;Integrated Security=true;Initial Catalog=BD");
            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PRUEBA", conexion);
            da.Fill(dt);
            conexion.Close();

            return dt;

        }

    }
}
