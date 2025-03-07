using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventario
{
    class clsProductos
    {
        public string NombreProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }

        public List<clsProductos> listaProductos = new List<clsProductos>();

        
        public clsProductos(string nombreProducto, decimal precioProducto, int cantidadProducto, List<clsProductos> inventario)
        {
            NombreProducto = nombreProducto;
            PrecioProducto = precioProducto;
            CantidadProducto = cantidadProducto;
            listaProductos = inventario;
        }  



        public int buscarIndiceProducto(string nombre)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].NombreProducto.Equals(nombre))
                    return i;

            }

            return -1;
        }

        public bool venderProducto(int indice, int cantidadVenta)
        {
            if (listaProductos[indice].CantidadProducto >= cantidadVenta)
                return true;
            return false;
        }
    }
}
