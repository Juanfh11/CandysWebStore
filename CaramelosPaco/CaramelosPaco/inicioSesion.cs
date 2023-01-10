using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaramelosPaco
{
    public partial class CaramelosPaco : Form
    {
        
        public CaramelosPaco()
        {
            InitializeComponent();
        }

        //Si le das al boton de crear cuenta pasa al formulario de crearCuenta
        private void botonCrearCuenta_Click(object sender, EventArgs e)
        {
            new crearCuenta().Show();
            this.Close();
        }

        //Si le das al boton de aceptar primero comprueba si el
        //usuario existe y si coincide con su contraseña
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            //Abro el lector
            StreamReader lector = new StreamReader("clientes.txt");
            while (lector.Peek() != -1)
            {
                if (lector.ReadLine().Equals(textBoxUsuario.Text))
                {
                    if (lector.ReadLine().Equals(textBoxContrasena.Text))
                    {
                        //Si existe
                        existe = true;
                        break;
                    }
                    else
                    {
                        //Si no existe
                        //Muestra mensaje de error
                        errorTexto.Visible = true;
                    }
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        lector.ReadLine();
                    }
                }
            }
            lector.Close();
            if (existe) //Si el usuario existe y su contraseña está bien
            {
                //Paso el nombre del usuario al formulario datosUsuario
                datosUsuario.usuario = textBoxUsuario.Text;
                //Paso al formulario inicio
                new inicio().Show();
                this.Close();
            }
            else //Si el usuario no existe
            {
                //Muestra mensaje de error 
                errorTexto.Visible = true;
            }
        
        }

        //Controlo si no hay ningun formulario abierto para finalizar el programa
        private void CaramelosPaco_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }


        //Cuando carga la pantalla
        private void CaramelosPaco_Load(object sender, EventArgs e)
        {
            //Cuento cuantos usuarios hay registrados para ponerlo en la pantalla
            StreamReader lector = new StreamReader("clientes.txt", true);
            int i = 1;
            ArrayList lista = new ArrayList();
            while (lector.Peek() != -1)
            {
                if (i == 9)
                {
                    i = 1;
                    lista.Add(lector.ReadLine());
                }
                else
                {
                    lector.ReadLine();
                }
                i++;
            }
            lector.Close();

            contadorUsuarios.Text = ("Número de usuarios: " + lista.Count);
        }
    }
}
