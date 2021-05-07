using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_6
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion con = new Conexion();
                string query = "Select IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad from Productos";

                con.cargarGridView(gvProductos, query, "Producto");
            }
        }
    }
}