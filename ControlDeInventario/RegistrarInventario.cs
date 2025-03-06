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
        public RegistrarInventario()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                //validaciones
                string nombreProd = txtNombreProducto.Text;
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
                clsInventarioProductos producto = new clsInventarioProductos(nombreProd, precioProd, cantidadProd);
                
                //agrego el nuevo producto a la lista
                producto.agregarProducto(producto);

                //se muestran registros en listBoxEstudiantes
                listBoxInventario.Items.Add($"{producto.NombreProducto} - Precio: {producto.PrecioProducto}, Stock: {producto.CantidadProducto}");

                limpiarRegistroInventario();


            }
            catch (Exception)
            {

                throw;
            }
        }
        public void limpiarRegistroInventario()
        {
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtCantidadStock.Text = "";
            

        }

    }
}
