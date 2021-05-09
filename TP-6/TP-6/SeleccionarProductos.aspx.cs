using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string query = "Select IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad from Productos";

                con.cargarGridView(gvProductos, query, "Producto");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            string query = "Select IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad from Productos";

            gvProductos.PageIndex = e.NewPageIndex;

            con.cargarGridView(gvProductos, query, "Producto");
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvProductos_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}