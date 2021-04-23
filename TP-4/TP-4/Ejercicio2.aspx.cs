using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from productos", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                grdProductos.DataSource = dr;
                grdProductos.DataBind();

                cn.Close();
            }
            
        }

        protected void ddlProducto_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from productos where idProducto "+ddlProducto.SelectedValue+txtProducto.Text, cn);

                SqlDataReader dr = cmd.ExecuteReader();

                grdProductos.DataSource = dr;
                grdProductos.DataBind();
                cn.Close();

        }

        protected void btonQuitarFiltro_Click(object sender, EventArgs e)
        {

           


            SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from productos", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            grdProductos.DataSource = dr;
            grdProductos.DataBind();

            cn.Close();
        }
    }  
}