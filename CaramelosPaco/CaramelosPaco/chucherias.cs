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
    public partial class chucherias : Form
    {
        
        public chucherias()
        {
            InitializeComponent();
        }

        //Si pulso la imagen de la flecha vuelve al formulario inicio
        private void flecha_Click(object sender, EventArgs e)
        {
            new inicio().Show();
            this.Close();
        }

        //Controlo si hay formularios abiertos para finalizar el programa
        private void chucherias_FormClosed(object sender, FormClosedEventArgs e)
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

        //Si le doy al boton añadir al carrito de las fresas...
        private void botonFresas_Click(object sender, EventArgs e)
        {
            if (cantidadFresas.Value > 0) //Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadFresas.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadFresas.Value * 0.05);
                //Pongo el valor a 0
                cantidadFresas.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de las cocacolas...
        private void botonCocaCola_Click(object sender, EventArgs e)
        {
            if (cantidadCocaCola.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadCocaCola.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadCocaCola.Value * 0.05);
                //Pongo el valor a 0
                cantidadCocaCola.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los pulpitos...
        private void botonPulpitos_Click(object sender, EventArgs e)
        {
            if (cantidadPulpitos.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadPulpitos.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadPulpitos.Value * 0.05);
                //Pongo el valor a 0
                cantidadPulpitos.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los regalices...
        private void botonRegalices_Click(object sender, EventArgs e)
        {
            if (cantidadRegalices.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadRegalices.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadRegalices.Value * 0.1);
                //Pongo el valor a 0
                cantidadRegalices.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de las moras...
        private void botonMoras_Click(object sender, EventArgs e)
        {
            if (cantidadMoras.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadMoras.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadMoras.Value * 0.05);
                //Pongo el valor a 0
                cantidadMoras.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de las sandias...
        private void botonSandias_Click(object sender, EventArgs e)
        {
            if (cantidadSandias.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadSandias.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadSandias.Value * 0.05);
                //Pongo el valor a 0
                cantidadSandias.Value = 0;
            }
        }
    }
}
