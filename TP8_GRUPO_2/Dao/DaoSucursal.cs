﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Dao
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();
        
        public void agregarSucursal(Sucursal suc)
        {
            string agregarSucursal = "insert into sucursal(NombreSucursal, DescripcionSucursal, id_ProvinciaSucursal, DireccionSucursal) Values ('" + suc.NombreSucursal + "','" + suc.DescripcionSucursal + "','" + suc.Id_ProvinciaSucursal + "','" + suc.DireccionSucursal + "')";
            SqlConnection conexion = ds.ObtenerConexion();
            ds.ejecutarConsulta(agregarSucursal, conexion);
        }


        public DataTable ObtenerTabla(string tabla, string sql)
        {
            return ds.ObtenerTabla(tabla, sql);
        }



    }
}
