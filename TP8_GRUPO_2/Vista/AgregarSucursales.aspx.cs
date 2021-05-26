using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using Negocio;
using System.Data.SqlClient;

namespace Vista
{
    public partial class AgregarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_NombreSucursal.Text.Trim().Length == 0 || txt_Descripcion.Text.Trim().Length == 0 || txt_Direccion.Text.Trim().Length == 0)
            {
                lblAgregarSucursal.Text = "No se aceptan campos vacios";
            }
            else
            {
                Sucursal suc = new Sucursal();
                NegocioCategorias neg = new NegocioCategorias();
                suc.NombreSucursal = txt_NombreSucursal.Text;
                suc.DescripcionSucursal = txt_Descripcion.Text;
                suc.DireccionSucursal = txt_Direccion.Text;
                suc.Id_ProvinciaSucursal = ddl_Provincias.SelectedValue;

                neg.GuardarSucursal(suc);
                
                lblAgregarSucursal.Text = "Agregado con éxito";
            }
        }
    }
}