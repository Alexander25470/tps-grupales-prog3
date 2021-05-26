using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Dao;
using System.Data;

namespace Negocio
{
    public class NegocioCategorias
    {
        DaoSucursal dao = new DaoSucursal();

        public void GuardarSucursal(Sucursal suc)
        {
            dao.agregarSucursal(suc);
        }
    }
}
