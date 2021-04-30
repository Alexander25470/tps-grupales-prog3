using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TP_5
{
    public class Class1
    {
        private String ruta = "Data Source = localhost\\sqlexpress;Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int ejecutarConsulta(String consulta)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();
            
            SqlCommand comando = new SqlCommand(consulta, conexion);

            int filas = comando.ExecuteNonQuery();

            return filas;
        }
    }
}