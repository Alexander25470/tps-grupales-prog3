using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP_6
{
    public class GestionProductos
    {
        private void ArmarParametroProductos(ref SqlCommand Comando, Producto prod)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = prod.IdProducto;
            SqlParametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 40);
            SqlParametros.Value = prod.NombreProducto;
            SqlParametros = Comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 20);
            SqlParametros.Value = prod.CantidadPorUnidad;
            SqlParametros = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            SqlParametros.Value = prod.PrecioUnidad;
        }

        private void ArmarParametrosProductoEliminar(ref SqlCommand Comando, Producto prod)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = prod.IdProducto;
        }

        public bool ActualizarProducto(Producto prod)
        {
            string query = "UPDATE Productos SET NombreProducto ="+prod.NombreProducto+", CantidadPorUnidad="+prod.CantidadPorUnidad+", PrecioUnidad="+prod.PrecioUnidad+"WHERE IdProducto = "+prod.IdProducto;
            Conexion ad = new Conexion();
            int FilasInsertadas = ad.ejecutarConsulta(query);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

        public bool EliminarProducto(Producto prod)
        {
            string query = "DELETE FROM Productos WHERE IdProducto = " + prod.IdProducto;

            
            Conexion ad = new Conexion();
            int FilasInsertadas = ad.ejecutarConsulta(query);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
    }

   

}