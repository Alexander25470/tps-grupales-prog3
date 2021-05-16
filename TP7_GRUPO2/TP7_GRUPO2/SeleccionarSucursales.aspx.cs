using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP7_GRUPO2
{
    public partial class SeleccionarSucursales : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        TablaSesion ts = new TablaSesion();
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
                if (Session["Seleccionados"] == null)
                {
                    Session["Seleccionados"] = TablaSesion.CrearTabla();
                }
                string[] cols = e.CommandArgument.ToString().Split(',');
                TablaSesion.AgregarFila( (DataTable)Session["Seleccionados"] , cols);

            }
        }

        protected void btnSeleccion_Command(object sender, CommandEventArgs e)
        {

        }

        protected void btnProvincias_Command(object sender, CommandEventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarSucursal.Text == "")
            {
                SqlDataSource1.SelectCommand = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_HorarioSucursal], [Id_ProvinciaSucursal], [DireccionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal]";
            }
            else
            {
                SqlDataSource1.SelectCommand = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_HorarioSucursal], [Id_ProvinciaSucursal], [DireccionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal] where [NombreSucursal] =('" + txtBuscarSucursal.Text + "')";
                txtBuscarSucursal.Text = "";
                
            }
            
        }

        protected void btnProvincias_Click(object sender, EventArgs e)
        {
            
        }
    }
}