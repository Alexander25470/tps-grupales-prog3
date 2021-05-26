﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Data.SqlClient;
using Dao;

namespace Vista
{
    public partial class AgregarSucursales : System.Web.UI.Page
    {
        NegocioCategorias neg = new NegocioCategorias();
        
        protected void Page_Load(object sender, EventArgs e)
        {
                ddl_Provincias.DataSource = neg.ObtenerTablaProvincias();
                ddl_Provincias.DataTextField = "DescripcionProvincia";
                ddl_Provincias.DataBind();
            
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
                //suc.Id_ProvinciaSucursal = ddl_Provincias.SelectedValue;
                suc.Id_ProvinciaSucursal = "1";

                neg.GuardarSucursal(suc);
                
                lblAgregarSucursal.Text = "Agregado con éxito";
            }
        }

        protected void ddl_Provincias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}