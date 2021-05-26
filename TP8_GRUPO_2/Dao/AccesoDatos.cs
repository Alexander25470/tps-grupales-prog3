﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dao
{
    class AccesoDatos
    {
        String rutaBDSucursales = "Data Source=localhost\\sqlexpress;Initial Catalog = BDSucursales; Integrated Security = True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);
            try
            {
                cn.Open();
                return cn;
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        public int ejecutarConsulta(String consulta, SqlConnection conexion)
        {
            SqlCommand comando = new SqlCommand(consulta, conexion);

            int filas = comando.ExecuteNonQuery();

            conexion.Close();

            return filas;
        }

        private SqlDataAdapter ObtenerAdaptador(string query, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(query, cn);
                return adaptador;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(string tabla, string sql)
        {
            DataSet ds = new DataSet();
            SqlConnection conexion = ObtenerConexion();
            SqlDataAdapter adapt = ObtenerAdaptador(sql, conexion);
            adapt.Fill(ds, tabla);
            conexion.Close();
            return ds.Tables[tabla];
        }

        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

   

    }
   
}
