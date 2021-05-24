using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private string _nombreSucursal;
        private string _descripcion;
        private int _IdProvincia;
        private string _direccion;

        public Sucursal()
        {
        }

        public string NombreSucursal { get => _nombreSucursal; set => _nombreSucursal = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int IdProvincia { get => _IdProvincia; set => _IdProvincia = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
