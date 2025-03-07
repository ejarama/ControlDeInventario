
namespace ControlDeInventario
{
    partial class RegistrarInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlInventarios = new System.Windows.Forms.TabControl();
            this.tabRegistroInventario = new System.Windows.Forms.TabPage();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblTitulo_Registro_Inventario = new System.Windows.Forms.Label();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnVenderProducto = new System.Windows.Forms.Button();
            this.lblCantidadVenta = new System.Windows.Forms.Label();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.lblRegistroVentas = new System.Windows.Forms.Label();
            this.tabListaProductos = new System.Windows.Forms.TabPage();
            this.lblListadoProductos = new System.Windows.Forms.Label();
            this.listBoxInventario = new System.Windows.Forms.ListBox();
            this.tabControlInventarios.SuspendLayout();
            this.tabRegistroInventario.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabListaProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlInventarios
            // 
            this.tabControlInventarios.Controls.Add(this.tabRegistroInventario);
            this.tabControlInventarios.Controls.Add(this.tabVentas);
            this.tabControlInventarios.Controls.Add(this.tabListaProductos);
            this.tabControlInventarios.Location = new System.Drawing.Point(12, 12);
            this.tabControlInventarios.Name = "tabControlInventarios";
            this.tabControlInventarios.SelectedIndex = 0;
            this.tabControlInventarios.Size = new System.Drawing.Size(1220, 646);
            this.tabControlInventarios.TabIndex = 0;
            // 
            // tabRegistroInventario
            // 
            this.tabRegistroInventario.Controls.Add(this.txtCantidadStock);
            this.tabRegistroInventario.Controls.Add(this.txtPrecioProducto);
            this.tabRegistroInventario.Controls.Add(this.txtNombreProducto);
            this.tabRegistroInventario.Controls.Add(this.btnAgregarProducto);
            this.tabRegistroInventario.Controls.Add(this.lblCantidadStock);
            this.tabRegistroInventario.Controls.Add(this.lblPrecioProducto);
            this.tabRegistroInventario.Controls.Add(this.lblNombreProducto);
            this.tabRegistroInventario.Controls.Add(this.lblTitulo_Registro_Inventario);
            this.tabRegistroInventario.Location = new System.Drawing.Point(8, 39);
            this.tabRegistroInventario.Name = "tabRegistroInventario";
            this.tabRegistroInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroInventario.Size = new System.Drawing.Size(1204, 599);
            this.tabRegistroInventario.TabIndex = 0;
            this.tabRegistroInventario.Text = "Registro Inventario";
            this.tabRegistroInventario.UseVisualStyleBackColor = true;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(346, 256);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(454, 31);
            this.txtCantidadStock.TabIndex = 17;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(346, 200);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(454, 31);
            this.txtPrecioProducto.TabIndex = 16;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(346, 142);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(454, 31);
            this.txtNombreProducto.TabIndex = 15;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(888, 174);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(220, 77);
            this.btnAgregarProducto.TabIndex = 14;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Location = new System.Drawing.Point(115, 256);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(158, 25);
            this.lblCantidadStock.TabIndex = 12;
            this.lblCantidadStock.Text = "Cantidad Stock";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(115, 200);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(165, 25);
            this.lblPrecioProducto.TabIndex = 11;
            this.lblPrecioProducto.Text = "Precio Producto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(115, 142);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(179, 25);
            this.lblNombreProducto.TabIndex = 10;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblTitulo_Registro_Inventario
            // 
            this.lblTitulo_Registro_Inventario.AutoSize = true;
            this.lblTitulo_Registro_Inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_Registro_Inventario.Location = new System.Drawing.Point(312, 37);
            this.lblTitulo_Registro_Inventario.Name = "lblTitulo_Registro_Inventario";
            this.lblTitulo_Registro_Inventario.Size = new System.Drawing.Size(549, 46);
            this.lblTitulo_Registro_Inventario.TabIndex = 9;
            this.lblTitulo_Registro_Inventario.Text = "REGISTRO DE INVENTARIO";
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.txtCantidadVenta);
            this.tabVentas.Controls.Add(this.txtBuscarProducto);
            this.tabVentas.Controls.Add(this.btnVenderProducto);
            this.tabVentas.Controls.Add(this.lblCantidadVenta);
            this.tabVentas.Controls.Add(this.lblBuscarProducto);
            this.tabVentas.Controls.Add(this.lblRegistroVentas);
            this.tabVentas.Location = new System.Drawing.Point(8, 39);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(1204, 599);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(346, 206);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(454, 31);
            this.txtCantidadVenta.TabIndex = 17;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(346, 142);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(454, 31);
            this.txtBuscarProducto.TabIndex = 15;
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.Location = new System.Drawing.Point(869, 152);
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Size = new System.Drawing.Size(221, 79);
            this.btnVenderProducto.TabIndex = 14;
            this.btnVenderProducto.Text = "Vender Producto";
            this.btnVenderProducto.UseVisualStyleBackColor = true;
            this.btnVenderProducto.Click += new System.EventHandler(this.btnVenderProducto_Click);
            // 
            // lblCantidadVenta
            // 
            this.lblCantidadVenta.AutoSize = true;
            this.lblCantidadVenta.Location = new System.Drawing.Point(115, 206);
            this.lblCantidadVenta.Name = "lblCantidadVenta";
            this.lblCantidadVenta.Size = new System.Drawing.Size(160, 25);
            this.lblCantidadVenta.TabIndex = 12;
            this.lblCantidadVenta.Text = "Cantidad Venta";
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Location = new System.Drawing.Point(115, 142);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(171, 25);
            this.lblBuscarProducto.TabIndex = 10;
            this.lblBuscarProducto.Text = "Buscar Producto";
            // 
            // lblRegistroVentas
            // 
            this.lblRegistroVentas.AutoSize = true;
            this.lblRegistroVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroVentas.Location = new System.Drawing.Point(338, 42);
            this.lblRegistroVentas.Name = "lblRegistroVentas";
            this.lblRegistroVentas.Size = new System.Drawing.Size(467, 46);
            this.lblRegistroVentas.TabIndex = 9;
            this.lblRegistroVentas.Text = "REGISTRO DE VENTAS";
            // 
            // tabListaProductos
            // 
            this.tabListaProductos.Controls.Add(this.listBoxInventario);
            this.tabListaProductos.Controls.Add(this.lblListadoProductos);
            this.tabListaProductos.Location = new System.Drawing.Point(8, 39);
            this.tabListaProductos.Name = "tabListaProductos";
            this.tabListaProductos.Size = new System.Drawing.Size(1204, 599);
            this.tabListaProductos.TabIndex = 2;
            this.tabListaProductos.Text = "Lista de Productos";
            this.tabListaProductos.UseVisualStyleBackColor = true;
            // 
            // lblListadoProductos
            // 
            this.lblListadoProductos.AutoSize = true;
            this.lblListadoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoProductos.Location = new System.Drawing.Point(326, 64);
            this.lblListadoProductos.Name = "lblListadoProductos";
            this.lblListadoProductos.Size = new System.Drawing.Size(524, 46);
            this.lblListadoProductos.TabIndex = 14;
            this.lblListadoProductos.Text = "LISTADO DE PRODUCTOS";
            // 
            // listBoxInventario
            // 
            this.listBoxInventario.FormattingEnabled = true;
            this.listBoxInventario.ItemHeight = 25;
            this.listBoxInventario.Location = new System.Drawing.Point(118, 185);
            this.listBoxInventario.Name = "listBoxInventario";
            this.listBoxInventario.Size = new System.Drawing.Size(969, 229);
            this.listBoxInventario.TabIndex = 15;
            // 
            // RegistrarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 670);
            this.Controls.Add(this.tabControlInventarios);
            this.Name = "RegistrarInventario";
            this.Text = "Registrar Inventario";
            this.tabControlInventarios.ResumeLayout(false);
            this.tabRegistroInventario.ResumeLayout(false);
            this.tabRegistroInventario.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            this.tabListaProductos.ResumeLayout(false);
            this.tabListaProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInventarios;
        private System.Windows.Forms.TabPage tabRegistroInventario;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblTitulo_Registro_Inventario;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnVenderProducto;
        private System.Windows.Forms.Label lblCantidadVenta;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.Label lblRegistroVentas;
        private System.Windows.Forms.TabPage tabListaProductos;
        private System.Windows.Forms.Label lblListadoProductos;
        private System.Windows.Forms.ListBox listBoxInventario;
    }
}

