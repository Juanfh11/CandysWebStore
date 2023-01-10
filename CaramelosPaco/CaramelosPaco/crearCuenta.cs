using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaramelosPaco
{
    public partial class crearCuenta : Form
    {
        public crearCuenta()
        {
            InitializeComponent();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            //Compruebo si se han dejado algún campo vacío
            if (textBoxNombre.Text == "" || textBoxApellido.Text == "" || textBoxUsuario.Text == "" 
                || textBoxContrasena.Text == "" || textBoxCalle.Text == "" || textBoxCorreo.Text == "" 
                || textBoxCP.Text == "" || textBoxLocalidad.Text == "" || textBoxTelefono.Text == "")
            {
                //Si se han dejado uno vacío muestro mensaje de error
                labelCamposVacios.Visible = true;
            }
            else
            {
                //Si están todos llenos se almacenan en el fichero clientes.txt
                bool existe = false;
                StreamReader lector = new StreamReader("clientes.txt");
                while (lector.Peek() != -1)
                {
                    if (lector.ReadLine().Equals(textBoxUsuario.Text))
                    {
                        if (lector.ReadLine().Equals(textBoxContrasena.Text))
                        {
                            existe = true;
                            break;
                        }
                    }
                    else
                    {
                        lector.ReadLine();
                    }
                }
                lector.Close();
                if (existe) //Si ya exsiste el nombre de usuario introducido
                {
                    //Muestra mensaje de error
                    errorTexto.Visible = true;
                }
                else //Si no existe el nombre de usuario introducido
                {
                    //Se escribe en el fichero los datos y se pasa al formulario de inicio de sesión
                    StreamWriter escritor = new StreamWriter("clientes.txt", true);
                    escritor.WriteLine(textBoxUsuario.Text);
                    escritor.WriteLine(textBoxContrasena.Text);
                    escritor.WriteLine(textBoxNombre.Text);
                    escritor.WriteLine(textBoxApellido.Text);
                    escritor.WriteLine(textBoxCorreo.Text);
                    escritor.WriteLine(textBoxTelefono.Text);
                    escritor.WriteLine(textBoxCalle.Text);
                    escritor.WriteLine(textBoxLocalidad.Text);
                    escritor.WriteLine(textBoxCP.Text);
                    escritor.Close();
                    new CaramelosPaco().Show();
                    this.Close();
                }
            }
            
        }

        //Si pulsas al boton de atrás vuelves al formulario de iniciar sesión
        private void botonAtras_Click(object sender, EventArgs e)
        {
            new CaramelosPaco().Show();
            this.Close();
        }

        //Controlo si hay formularios abiertos para terminar el programa
        private void crearCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
