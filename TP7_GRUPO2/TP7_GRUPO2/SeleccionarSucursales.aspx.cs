using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP7_GRUPO2
{
    public partial class SeleccionarSucursales : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string consulta = "Select * from Provincia";
                string tabla = "Provincia";
                con.cargarDatosdl(dlProvincias, consulta, tabla);
            }
        }

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "eventButton")
            {
                Session["Seleccion"] += e.CommandArgument.ToString();
            }
        }

        protected void btnSeleccion_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "eventButton")
            {
                Session["Seleccion"] += e.CommandArgument.ToString();
            }
        }

        protected void btnProvincias_Command(object sender, CommandEventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}