using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_5
{
    public class Conexion
    {
        public const String ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=BDsucursales;Integrated Security=True";



        public int ejecutarConsulta(String consulta)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();
            
            SqlCommand comando = new SqlCommand(consulta, conexion);

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas;
        }

        public int loadDdl(DropDownList ddl,string query,int colValue, int colId)
        {
            SqlConnection conn = new SqlConnection(Conexion.ruta);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //ddl.Items.Insert(0, new ListItem(dr[colValue]+"", dr[colId]+""));
                //ddl.Items.Add(dr[colValue] + "");
                ListItem item = new ListItem(dr[colValue] + "", dr[colId] + "");
                ddl.Items.Add(item);

            }
            conn.Close();
            return 0;
        }

    }
}