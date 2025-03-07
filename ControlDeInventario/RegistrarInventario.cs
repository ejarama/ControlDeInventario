using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeInventario
{
    public partial class RegistrarInventario : Form
    {
        List<clsProductos> inventario = new List<clsProductos>();
        
        public RegistrarInventario()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                //validaciones
                string nombreProd = txtNombreProducto.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(nombreProd))
                {
                    MessageBox.Show("El nombre del producto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precioProd) || precioProd < 0)
                {
                    MessageBox.Show("Precio inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtCantidadStock.Text, out int cantidadProd) || cantidadProd < 0 )
                {
                    MessageBox.Show("Cantidad inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                //instancio el producto nuevo
                clsProductos producto = new clsProductos(nombreProd, precioProd, cantidadProd, inventario);

                inventario.Add(producto);
                actualizarLista();
                limpiarCampos();

                MessageBox.Show("El productó se registró con éxito", "Información", MessageBoxButtons.OK);
                tabControlInventarios.SelectedTab = tabListaProductos;


            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos válidos para el producto.");
            }
        }
    

        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                string productoBuscar = txtBuscarProducto.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(productoBuscar))
                {
                    MessageBox.Show("El nombre del producto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtCantidadVenta.Text, out int cantidadVenta) || cantidadVenta < 0)
                {
                    MessageBox.Show("Cantidad inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //instancio el producto nuevo
                clsProductos productoVenta = new clsProductos(productoBuscar, 0, cantidadVenta, inventario);

                int indiceProd = productoVenta.buscarIndiceProducto(productoVenta.NombreProducto);
                //si el indice es -1 no se encontró producto 
                if (indiceProd != -1)
                {
                    bool vender = productoVenta.venderProducto(indiceProd, productoVenta.CantidadProducto);
                    if (vender)
                    {
                        inventario[indiceProd].CantidadProducto -= productoVenta.CantidadProducto;

                        limpiarCampos();
                        MessageBox.Show("La venta se realizó con éxito", "Información", MessageBoxButtons.OK);
                        tabControlInventarios.SelectedTab = tabListaProductos;
                        actualizarLista();
                        quitarProductoSinStock();
                        
                    }
                    else
                        MessageBox.Show("No hay stock suficiente para la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos válidos para el producto");
            }
        }

        public void limpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadStock.Clear();
            txtBuscarProducto.Clear();
            txtCantidadVenta.Clear();

        }
        public void actualizarLista()
        {
            listBoxInventario.Items.Clear();
            foreach (var prod in inventario)
            {
                listBoxInventario.Items.Add($"{prod.NombreProducto} - Precio: {prod.PrecioProducto}, Stock: {prod.CantidadProducto}");
            }
        }

        public void quitarProductoSinStock()
        {
            for (int i = inventario.Count-1; i >= 0; i--)
            {
                if (inventario[i].CantidadProducto == 0)
                    inventario.RemoveAt(i);
            }
            actualizarLista();
        }
    }
}
