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
    public partial class cramelos : Form
    {
        public cramelos()
        {
            InitializeComponent();
        }

        //Si pulso la imagen de la flecha vuelve al formulario inicio
        private void imagenFlecha_Click(object sender, EventArgs e)
        {
            new inicio().Show();
            this.Close();
        }

        //Controlo si hay formularios abiertos para finalizar el programa
        private void cramelos_FormClosed(object sender, FormClosedEventArgs e)
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
        private void usuarioCarrito_Click(object sender, EventArgs e)
        {
            new carrito().Show();
            this.Close();
        }

        //Si le doy al boton añadir al carrito de los ChupaChups...
        private void botonChupaChups_Click(object sender, EventArgs e)
        {
            if (cantidadChupaChups.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadChupaChups.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadChupaChups.Value * 0.2);
                //Pongo el valor a 0
                cantidadChupaChups.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los ChupaChups...
        private void botonMenta_Click(object sender, EventArgs e)
        {
            if (cantidadMenta.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadMenta.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadMenta.Value * 0.05);
                //Pongo el valor a 0
                cantidadMenta.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los ChupaChups...
        private void botonFresquitos_Click(object sender, EventArgs e)
        {
            if (cantidadFresquitos.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadFresquitos.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadFresquitos.Value * 0.5);
                //Pongo el valor a 0
                cantidadFresquitos.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los ChupaChups...
        private void botonLadrillos_Click(object sender, EventArgs e)
        {
            if (cantidadLadrillos.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadLadrillos.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadLadrillos.Value * 0.1);
                //Pongo el valor a 0
                cantidadLadrillos.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los ChupaChups...
        private void botonFesaNata_Click(object sender, EventArgs e)
        {
            if (cantidadFresaNata.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadFresaNata.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadFresaNata.Value * 0.05);
                //Pongo el valor a 0
                cantidadFresaNata.Value = 0;
            }
        }

        //Si le doy al boton añadir al carrito de los ChupaChups...
        private void botonSolano_Click(object sender, EventArgs e)
        {
            if (cantidadSolano.Value > 0)//Si es mayor que 0
            {
                //Sumo a la variable cantidad el número que he puesto
                carrito.cantidad = carrito.cantidad + (int)cantidadSolano.Value;
                //Sumo a la variable precio el valor de lo que pedido
                carrito.precio = carrito.precio + ((double)cantidadSolano.Value * 0.05);
                //Pongo el valor a 0
                cantidadSolano.Value = 0;
            }
        }
    }
}
