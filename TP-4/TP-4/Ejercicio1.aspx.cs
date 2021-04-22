using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TP_4
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rutaViajes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            string consultaSql = "Select * from Provincias";
            if(!IsPostBack)
            {
                SqlConnection cnViajes = new SqlConnection(rutaViajes);
                SqlCommand cmd = new SqlCommand(consultaSql, cnViajes);
                cnViajes.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ddlProvinciaInicio.Items.Add( dr["NombreProvincia"]+"" );
                }
                cnViajes.Close();
            }
        }
    }
}