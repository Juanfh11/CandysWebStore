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
    public partial class datosUsuario : Form
    {
        //Declaro variables
        String nombre;
        String apellido;
        public static String usuario;

        public datosUsuario()
        {
            InitializeComponent();
            //Leo del fichero los usuarios y si coinciden con el puesto
            //en el inicio de sesión imprimo sus datos en la pantalla
            StreamReader reader = new StreamReader("clientes.txt");
            while (reader.Peek() != -1)
            {
                if (reader.ReadLine().Equals(usuario))
                {
                    usuarioTexto.Text = usuario;
                    reader.ReadLine();
                    nombre = reader.ReadLine();
                    apellido = reader.ReadLine();
                    nombreUsuario.Text = nombre + " " + apellido;
                    correoTexto.Text = reader.ReadLine();
                    telefonoTexto.Text = reader.ReadLine();
                    calleTexto.Text = reader.ReadLine();
                    localidadTexto.Text = reader.ReadLine();
                    codigoPostalTexto.Text = reader.ReadLine();
                }
                else{
                    for (int i = 0; i < 8; i++)
                    {
                        reader.ReadLine();
                    }
                }
            }
            
        }

        //Si le doy al boton de cerrar sesíon cierra sesión y va a la pantalla de inicio de sesión.
        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            new CaramelosPaco().Show();
            this.Close();
        }

        //Si le doy a la flecha vuelve a la pantalla de inicio
        private void flecha_Click(object sender, EventArgs e)
        {
            new inicio().Show();
            this.Close();
        }
    }
}
