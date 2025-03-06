using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventario
{
    class clsInventarioProductos
    {
        public string NombreProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }

        List<clsInventarioProductos> listaProductos = new List<clsInventarioProductos>();

        public clsInventarioProductos(string nombreProducto, decimal precioProducto, int cantidadProducto)
        {
            NombreProducto = nombreProducto;
            PrecioProducto = precioProducto;
            CantidadProducto = cantidadProducto;
        }  

        public void agregarProducto(clsInventarioProductos nuevoProducto)
        {
            listaProductos.Add(nuevoProducto);
        }

    }
}
