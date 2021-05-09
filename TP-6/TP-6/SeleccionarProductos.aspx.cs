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

                string query = "Select IdProducto, NombreProducto, idProveedor, CantidadPorUnidad, PrecioUnidad from Productos";

                con.cargarGridView(gvProductos, query, "Producto");
            }
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            string query = "Select IdProducto, NombreProducto, idProveedor, CantidadPorUnidad, PrecioUnidad from Productos";

            gvProductos.PageIndex = e.NewPageIndex;

            con.cargarGridView(gvProductos, query, "Producto");
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdProducto_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string s_IdProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_IdProducto")).Text;
            string s_NombreProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_NombreProducto")).Text;
            string s_IdProveedor = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_IdProveedor")).Text;
            string s_CantidadPorUnidad = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_CantidadPorUnidad")).Text;
            string s_PrecioUnidad = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_PrecioUnidad")).Text;

            lbl_Agregado.Text += "<br/>" + s_NombreProducto;
        }

        protected void gvProductos_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}