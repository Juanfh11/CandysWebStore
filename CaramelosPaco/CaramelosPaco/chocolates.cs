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
    public partial class chocolates : Form
    {
        public chocolates()
        {
            InitializeComponent();
        }

        //Si pulso la imagen de la flecha vuelve al formulario inicio
        private void imagenAtras_Click(object sender, EventArgs e)
        {
            new inicio().Show();
            this.Close();
        }

        //Controlo si hay formularios abiertos para finalizar el programa
        private void chocolates_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        //Si pulso en la imagen del usuario voy al formulario datosUsuario
        private void imagenUsuario_Click(object sender, EventArgs e)
        {
            new datosUsuario().Show();
            this.Close();
        }

        //Si pulso en la imagen del carrito voy al formulario carrito
        private void imagenCarrito_Click(object sender, EventArgs e)
        {
            new carrito().Show();
            this.Close();
        }

        //Si le doy al boton añadir al carrito de la caja roja...
        private void botonCajaRoja_Click(object sender, EventArgs e)
        {
            if (cantidadCajaRoja.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadCajaRoja.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadCajaRoja.Value * 15);
                //Pongo el valor a 0
                cantidadCajaRoja.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de la tableta Jungly...
        private void botonJungly_Click(object sender, EventArgs e)
        {
            if (cantidadJungly.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadJungly.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadJungly.Value * 1.5);
                //Pongo el valor a 0
                cantidadJungly.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los bombones lindt...
        private void botonLindt_Click(object sender, EventArgs e)
        {
            if (cantidadLindt.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadLindt.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadLindt.Value * 0.5);
                //Pongo el valor a 0
                cantidadLindt.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de las tabletas de kit kat...
        private void botonKitKat_Click(object sender, EventArgs e)
        {
            if (cantidadKitKat.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadKitKat.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadKitKat.Value * 3);
                //Pongo el valor a 0
                cantidadKitKat.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los ferrero...
        private void botonFerrero_Click(object sender, EventArgs e)
        {
            if (cantidadFerrero.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadFerrero.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadFerrero.Value * 0.5);
                //Pongo el valor a 0
                cantidadFerrero.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de las tabletas Milka...
        private void botonMilka_Click(object sender, EventArgs e)
        {
            if (cantidadMilka.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadMilka.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadMilka.Value * 1.5);
                //Pongo el valor a 0
                cantidadMilka.Value = 0;
            }
        }
    }
}
