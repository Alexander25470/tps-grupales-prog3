using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string query = "Select S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, P.DescripcionProvincia as Provincia, S.DireccionSucursal from Sucursal as S inner join Provincia as P on P.Id_Provincia = S.Id_ProvinciaSucursal where Id_Sucursal = " + Convert.ToInt32(txtIdSucursal.Text);

            con.mostrarGridView(gdSucursales,query,"Sucursal");
        }

    }
}