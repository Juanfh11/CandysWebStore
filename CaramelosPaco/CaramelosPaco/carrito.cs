using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaramelosPaco
{
    public partial class carrito : Form
    {
        //Declaro variables
        public static int cantidad = 0;
        public static double precio = 0;
        public carrito()
        {
            InitializeComponent();
            //Pongo por pantalla el precio y la cantidad del pedido total
            cantidadPrecio.Text = "El total de la compra es de: " + precio + "€";
            cantidadProductos.Text = "El total de productos comprados son de: " + cantidad + " unidades";
        }

        //Controlo si hay algún formulario abierto para finalizar el programa
        private void carrito_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        //Si le doy a la imagen de la flecha se vuelve al formulario inicio
        private void imagenAtras_Click(object sender, EventArgs e)
        {
            new inicio().Show();
            this.Close();
        }

        //Si le doy al boton de finalizar compra
        private void botonFinalizar_Click(object sender, EventArgs e)
        {
            if (cantidad != 0 || precio != 0) //Si el precio y la cantidad es disitnto de 0
            {
                //Pongo el mensaje de compra finalizada en visible
                labelCompraFinalizada.Visible = true;
                //Por si acaso pongo en invisible el mensaje de error
                labelRecordatorio.Visible = false;
            }
            else //Si el precio es igual a 0 y la cantidad también
            {
                //Pongo el mensjae de error visible
                labelRecordatorio.Visible = true;
                //Por si acaso pongo el mensaje de compra finalizada invisible
                labelCompraFinalizada.Visible = false;
            }
        }

        //Si pulsas el boton de borrar carrito te borra todo lo que tengas en el carrito
        private void botonBorrar_Click(object sender, EventArgs e)
        {
            cantidad = 0;
            precio = 0;
            cantidadPrecio.Text = "El total de la compra es de: " + precio + "€";
            cantidadProductos.Text = "El total de productos comprados son de: " + cantidad + " unidades";

        }
    }
}
