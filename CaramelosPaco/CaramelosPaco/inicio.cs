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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        //Cuando pulso en la imagen de chuches paso al formulario chcuherias
        private void imagenChuches_Click(object sender, EventArgs e)
        {
            new chucherias().Show();
            this.Close();
        }

        //Cuando pulso la imagen de los caramelos paso al formulario caramelos
        private void imagenCaramelos_Click(object sender, EventArgs e)
        {
            new cramelos().Show();
            this.Close();
        }

        //Cuando pulso la imagen de los chocolates paso al formulario chocolates
        private void imagenBombones_Click(object sender, EventArgs e)
        {
            new chocolates().Show();
            this.Close();
        }

        //Controlo si hay formularios abiertos para finalizar el programa
        private void inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            } 
        }

        //Si pulso en la imagen del usuario paso al formulario datosUsuario
        private void imagenUsuario_Click(object sender, EventArgs e)
        {
            new datosUsuario().Show();
            this.Close();
        }

        //Si pulso en la imagen del carrito paso al formulario carito
        private void carrito_Click(object sender, EventArgs e)
        {
            new carrito().Show();
            this.Close();
        }
    }
}
