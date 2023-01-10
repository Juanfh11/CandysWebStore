namespace CaramelosPaco
{
    partial class carrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carrito));
            this.carritoCompra = new System.Windows.Forms.Label();
            this.imagenCarrito = new System.Windows.Forms.PictureBox();
            this.datosCesta = new System.Windows.Forms.Label();
            this.cantidadProductos = new System.Windows.Forms.Label();
            this.cantidadPrecio = new System.Windows.Forms.Label();
            this.imagenAtras = new System.Windows.Forms.PictureBox();
            this.botonFinalizar = new System.Windows.Forms.Button();
            this.labelCompraFinalizada = new System.Windows.Forms.Label();
            this.labelRecordatorio = new System.Windows.Forms.Label();
            this.botonBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // carritoCompra
            // 
            this.carritoCompra.AutoSize = true;
            this.carritoCompra.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carritoCompra.Location = new System.Drawing.Point(463, 80);
            this.carritoCompra.Name = "carritoCompra";
            this.carritoCompra.Size = new System.Drawing.Size(386, 47);
            this.carritoCompra.TabIndex = 0;
            this.carritoCompra.Text = "CARRITO DE LA COMPRA";
            // 
            // imagenCarrito
            // 
            this.imagenCarrito.Image = ((System.Drawing.Image)(resources.GetObject("imagenCarrito.Image")));
            this.imagenCarrito.Location = new System.Drawing.Point(12, 12);
            this.imagenCarrito.Name = "imagenCarrito";
            this.imagenCarrito.Size = new System.Drawing.Size(200, 200);
            this.imagenCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenCarrito.TabIndex = 1;
            this.imagenCarrito.TabStop = false;
            // 
            // datosCesta
            // 
            this.datosCesta.AutoSize = true;
            this.datosCesta.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosCesta.Location = new System.Drawing.Point(13, 230);
            this.datosCesta.Name = "datosCesta";
            this.datosCesta.Size = new System.Drawing.Size(148, 28);
            this.datosCesta.TabIndex = 2;
            this.datosCesta.Text = "Total de la cesta:";
            // 
            // cantidadProductos
            // 
            this.cantidadProductos.AutoSize = true;
            this.cantidadProductos.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadProductos.Location = new System.Drawing.Point(13, 324);
            this.cantidadProductos.Name = "cantidadProductos";
            this.cantidadProductos.Size = new System.Drawing.Size(172, 28);
            this.cantidadProductos.TabIndex = 3;
            this.cantidadProductos.Text = "Texto de ejemplo 1:";
            // 
            // cantidadPrecio
            // 
            this.cantidadPrecio.AutoSize = true;
            this.cantidadPrecio.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadPrecio.Location = new System.Drawing.Point(13, 420);
            this.cantidadPrecio.Name = "cantidadPrecio";
            this.cantidadPrecio.Size = new System.Drawing.Size(164, 28);
            this.cantidadPrecio.TabIndex = 4;
            this.cantidadPrecio.Text = "Texto de ejmplo 2:";
            // 
            // imagenAtras
            // 
            this.imagenAtras.Image = ((System.Drawing.Image)(resources.GetObject("imagenAtras.Image")));
            this.imagenAtras.Location = new System.Drawing.Point(1018, 522);
            this.imagenAtras.Name = "imagenAtras";
            this.imagenAtras.Size = new System.Drawing.Size(45, 45);
            this.imagenAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenAtras.TabIndex = 5;
            this.imagenAtras.TabStop = false;
            this.imagenAtras.Click += new System.EventHandler(this.imagenAtras_Click);
            // 
            // botonFinalizar
            // 
            this.botonFinalizar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFinalizar.Location = new System.Drawing.Point(757, 375);
            this.botonFinalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonFinalizar.Name = "botonFinalizar";
            this.botonFinalizar.Size = new System.Drawing.Size(159, 34);
            this.botonFinalizar.TabIndex = 6;
            this.botonFinalizar.Text = "Finalizar compra";
            this.botonFinalizar.UseVisualStyleBackColor = true;
            this.botonFinalizar.Click += new System.EventHandler(this.botonFinalizar_Click);
            // 
            // labelCompraFinalizada
            // 
            this.labelCompraFinalizada.AutoSize = true;
            this.labelCompraFinalizada.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompraFinalizada.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelCompraFinalizada.Location = new System.Drawing.Point(329, 487);
            this.labelCompraFinalizada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompraFinalizada.Name = "labelCompraFinalizada";
            this.labelCompraFinalizada.Size = new System.Drawing.Size(372, 84);
            this.labelCompraFinalizada.TabIndex = 7;
            this.labelCompraFinalizada.Text = "Compra finalizada.\r\n¡Muchas gracias por confíar en nosotros!\r\nSu pedido le llegar" +
    "á de 1 a 2 días laborables.";
            this.labelCompraFinalizada.Visible = false;
            // 
            // labelRecordatorio
            // 
            this.labelRecordatorio.AutoSize = true;
            this.labelRecordatorio.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecordatorio.ForeColor = System.Drawing.Color.Red;
            this.labelRecordatorio.Location = new System.Drawing.Point(227, 268);
            this.labelRecordatorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecordatorio.Name = "labelRecordatorio";
            this.labelRecordatorio.Size = new System.Drawing.Size(579, 28);
            this.labelRecordatorio.TabIndex = 8;
            this.labelRecordatorio.Text = "Recuerda meter algo antes en la cesta para poder realizar un pedido :)";
            this.labelRecordatorio.Visible = false;
            // 
            // botonBorrar
            // 
            this.botonBorrar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.Location = new System.Drawing.Point(44, 502);
            this.botonBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(156, 35);
            this.botonBorrar.TabIndex = 9;
            this.botonBorrar.Text = "Borrar carrito";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1075, 579);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.labelRecordatorio);
            this.Controls.Add(this.labelCompraFinalizada);
            this.Controls.Add(this.botonFinalizar);
            this.Controls.Add(this.imagenAtras);
            this.Controls.Add(this.cantidadPrecio);
            this.Controls.Add(this.cantidadProductos);
            this.Controls.Add(this.datosCesta);
            this.Controls.Add(this.imagenCarrito);
            this.Controls.Add(this.carritoCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito de la compra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.carrito_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imagenCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carritoCompra;
        private System.Windows.Forms.PictureBox imagenCarrito;
        private System.Windows.Forms.Label datosCesta;
        private System.Windows.Forms.Label cantidadProductos;
        private System.Windows.Forms.Label cantidadPrecio;
        private System.Windows.Forms.PictureBox imagenAtras;
        private System.Windows.Forms.Button botonFinalizar;
        private System.Windows.Forms.Label labelCompraFinalizada;
        private System.Windows.Forms.Label labelRecordatorio;
        private System.Windows.Forms.Button botonBorrar;
    }
}