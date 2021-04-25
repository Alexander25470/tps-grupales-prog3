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
            string consulta2sql = "Select * from Localidades";
            if (!IsPostBack)
            {
                SqlConnection cnViajes = new SqlConnection(rutaViajes);
                SqlCommand cmd = new SqlCommand(consultaSql, cnViajes);
                cnViajes.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ddlProvinciaInicio.Items.Add(dr["NombreProvincia"] + "");
                }
                cnViajes.Close();
                
                SqlConnection cnLocalidades = new SqlConnection(rutaViajes);
                SqlCommand cmd1 = new SqlCommand(consulta2sql, cnLocalidades);
                cnLocalidades.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (dr1["IdProvincia"].Equals(ddlProvinciaInicio.SelectedIndex + 1) == true)
                    {
                        ddlLocalidadInicio.Items.Add(dr1["NombreLocalidad"] + "");
                    }

                }
                cnLocalidades.Close();

                SqlConnection cnProvinciasFin = new SqlConnection(rutaViajes);
                SqlCommand cmd3 = new SqlCommand(consultaSql, cnProvinciasFin);
                cnProvinciasFin.Open();
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    if (dr3["IdProvincia"].Equals(ddlProvinciaInicio.SelectedIndex + 1) == false)
                    {
                        ddlProvinciaFinal.Items.Add(dr3["NombreProvincia"] + "");
                    }

                }
                cnProvinciasFin.Close();

                
                SqlConnection cnLocalidadesFin = new SqlConnection(rutaViajes);
                SqlCommand cmd4 = new SqlCommand(consulta2sql, cnLocalidadesFin);
                cnLocalidadesFin.Open();
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    if (dr4["IdProvincia"].Equals(ddlProvinciaFinal.SelectedIndex + 1) == true && ddlProvinciaInicio.SelectedIndex.Equals(ddlProvinciaFinal.SelectedIndex) == false)
                    {
                        ddlLocalidadFinal.Items.Add(dr4["NombreLocalidad"] + "");
                    }

                }
                cnLocalidadesFin.Close();
            }
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlLocalidadInicio.Items.Clear();
            ddlProvinciaFinal.Items.Clear();
            string rutaViajes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            string consulta2sql = "Select * from Localidades";
            string consultaSql = "Select * from Provincias";
            SqlConnection cnLocalidades = new SqlConnection(rutaViajes);
            SqlCommand cmd1 = new SqlCommand(consulta2sql, cnLocalidades);
            cnLocalidades.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                if (dr1["IdProvincia"].Equals(ddlProvinciaInicio.SelectedIndex + 1) == true)
                {
                    ddlLocalidadInicio.Items.Add(dr1["NombreLocalidad"] + "");
                }

            }
            cnLocalidades.Close();

            SqlConnection cnProvinciasFin = new SqlConnection(rutaViajes);
            SqlCommand cmd3 = new SqlCommand(consultaSql, cnProvinciasFin);
            cnProvinciasFin.Open();
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                if (dr3["IdProvincia"].Equals(ddlProvinciaInicio.SelectedIndex + 1) == false)
                {
                    ddlProvinciaFinal.Items.Add(dr3["NombreProvincia"] + "");
                }

            }
            cnProvinciasFin.Close();
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlLocalidadFinal.Items.Clear();

            string rutaViajes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            string consulta2sql = "Select * from Localidades";

            SqlConnection cnLocalidadesFin = new SqlConnection(rutaViajes);
            SqlCommand cmd4 = new SqlCommand(consulta2sql, cnLocalidadesFin);
            cnLocalidadesFin.Open();
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                if (dr4["IdProvincia"].Equals(ddlProvinciaFinal.SelectedIndex + 1) == true && ddlProvinciaInicio.SelectedIndex.Equals(ddlProvinciaFinal.SelectedIndex) == false)
                {
                    ddlLocalidadFinal.Items.Add(dr4["NombreLocalidad"] + "");
                }

            }
            cnLocalidadesFin.Close();
        }
    }
}