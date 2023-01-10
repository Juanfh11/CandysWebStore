namespace CaramelosPaco
{
    partial class CaramelosPaco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaramelosPaco));
            this.logoImagen = new System.Windows.Forms.PictureBox();
            this.textoLogIn = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.nuevoUsuario = new System.Windows.Forms.Label();
            this.botonCrearCuenta = new System.Windows.Forms.Button();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.errorTexto = new System.Windows.Forms.Label();
            this.contadorUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImagen
            // 
            this.logoImagen.Image = ((System.Drawing.Image)(resources.GetObject("logoImagen.Image")));
            this.logoImagen.InitialImage = null;
            this.logoImagen.Location = new System.Drawing.Point(107, 180);
            this.logoImagen.Name = "logoImagen";
            this.logoImagen.Size = new System.Drawing.Size(200, 200);
            this.logoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImagen.TabIndex = 0;
            this.logoImagen.TabStop = false;
            // 
            // textoLogIn
            // 
            this.textoLogIn.AutoSize = true;
            this.textoLogIn.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLogIn.Location = new System.Drawing.Point(453, 55);
            this.textoLogIn.Name = "textoLogIn";
            this.textoLogIn.Size = new System.Drawing.Size(576, 112);
            this.textoLogIn.TabIndex = 1;
            this.textoLogIn.Text = "INICIAR SESIÓN";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(531, 242);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(72, 28);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(531, 352);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(102, 28);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(743, 234);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(200, 36);
            this.textBoxUsuario.TabIndex = 4;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.Location = new System.Drawing.Point(743, 349);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(200, 36);
            this.textBoxContrasena.TabIndex = 5;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Location = new System.Drawing.Point(691, 498);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(90, 35);
            this.botonAceptar.TabIndex = 6;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // nuevoUsuario
            // 
            this.nuevoUsuario.AutoSize = true;
            this.nuevoUsuario.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoUsuario.Location = new System.Drawing.Point(22, 433);
            this.nuevoUsuario.Name = "nuevoUsuario";
            this.nuevoUsuario.Size = new System.Drawing.Size(266, 28);
            this.nuevoUsuario.TabIndex = 7;
            this.nuevoUsuario.Text = "¿Eres nuevo? Crea tú cuenta ->\r\n";
            // 
            // botonCrearCuenta
            // 
            this.botonCrearCuenta.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearCuenta.Location = new System.Drawing.Point(294, 430);
            this.botonCrearCuenta.Name = "botonCrearCuenta";
            this.botonCrearCuenta.Size = new System.Drawing.Size(100, 35);
            this.botonCrearCuenta.TabIndex = 8;
            this.botonCrearCuenta.Text = "Registrarse";
            this.botonCrearCuenta.UseVisualStyleBackColor = true;
            this.botonCrearCuenta.Click += new System.EventHandler(this.botonCrearCuenta_Click);
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.Location = new System.Drawing.Point(98, 99);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(231, 51);
            this.labelBienvenida.TabIndex = 9;
            this.labelBienvenida.Text = "¡BIENVENIDO!";
            // 
            // errorTexto
            // 
            this.errorTexto.AutoSize = true;
            this.errorTexto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTexto.ForeColor = System.Drawing.Color.Red;
            this.errorTexto.Location = new System.Drawing.Point(579, 430);
            this.errorTexto.Name = "errorTexto";
            this.errorTexto.Size = new System.Drawing.Size(348, 28);
            this.errorTexto.TabIndex = 10;
            this.errorTexto.Text = "USUARIO O CONTRASEÑA INCORRECTA";
            this.errorTexto.Visible = false;
            // 
            // contadorUsuarios
            // 
            this.contadorUsuarios.AutoSize = true;
            this.contadorUsuarios.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorUsuarios.Location = new System.Drawing.Point(27, 519);
            this.contadorUsuarios.Name = "contadorUsuarios";
            this.contadorUsuarios.Size = new System.Drawing.Size(144, 23);
            this.contadorUsuarios.TabIndex = 11;
            this.contadorUsuarios.Text = "Número de usuarios:";
            // 
            // CaramelosPaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1075, 579);
            this.Controls.Add(this.contadorUsuarios);
            this.Controls.Add(this.errorTexto);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.botonCrearCuenta);
            this.Controls.Add(this.nuevoUsuario);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textoLogIn);
            this.Controls.Add(this.logoImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaramelosPaco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caramelos Paco";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaramelosPaco_FormClosed);
            this.Load += new System.EventHandler(this.CaramelosPaco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImagen;
        private System.Windows.Forms.Label textoLogIn;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label nuevoUsuario;
        private System.Windows.Forms.Button botonCrearCuenta;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label errorTexto;
        private System.Windows.Forms.Label contadorUsuarios;
    }
}

