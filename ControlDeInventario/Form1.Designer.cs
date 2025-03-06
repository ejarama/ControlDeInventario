
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
            this.lblTitulo_Registro_Inventario = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.listBoxInventario = new System.Windows.Forms.ListBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo_Registro_Inventario
            // 
            this.lblTitulo_Registro_Inventario.AutoSize = true;
            this.lblTitulo_Registro_Inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_Registro_Inventario.Location = new System.Drawing.Point(340, 41);
            this.lblTitulo_Registro_Inventario.Name = "lblTitulo_Registro_Inventario";
            this.lblTitulo_Registro_Inventario.Size = new System.Drawing.Size(549, 46);
            this.lblTitulo_Registro_Inventario.TabIndex = 0;
            this.lblTitulo_Registro_Inventario.Text = "REGISTRO DE INVENTARIO";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(143, 146);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(179, 25);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(143, 204);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(165, 25);
            this.lblPrecioProducto.TabIndex = 2;
            this.lblPrecioProducto.Text = "Precio Producto";
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Location = new System.Drawing.Point(143, 260);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(158, 25);
            this.lblCantidadStock.TabIndex = 3;
            this.lblCantidadStock.Text = "Cantidad Stock";
            // 
            // listBoxInventario
            // 
            this.listBoxInventario.FormattingEnabled = true;
            this.listBoxInventario.ItemHeight = 25;
            this.listBoxInventario.Location = new System.Drawing.Point(101, 336);
            this.listBoxInventario.Name = "listBoxInventario";
            this.listBoxInventario.Size = new System.Drawing.Size(1070, 229);
            this.listBoxInventario.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(923, 177);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(194, 58);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(374, 146);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(454, 31);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(374, 204);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(454, 31);
            this.txtPrecioProducto.TabIndex = 7;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(374, 260);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(454, 31);
            this.txtCantidadStock.TabIndex = 8;
            // 
            // RegistrarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 670);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.listBoxInventario);
            this.Controls.Add(this.lblCantidadStock);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblTitulo_Registro_Inventario);
            this.Name = "RegistrarInventario";
            this.Text = "Registrar Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo_Registro_Inventario;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.ListBox listBoxInventario;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCantidadStock;
    }
}

