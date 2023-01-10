namespace CaramelosPaco
{
    partial class datosUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datosUsuario));
            this.imagenUsuario = new System.Windows.Forms.PictureBox();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.usuarioTexto = new System.Windows.Forms.Label();
            this.datosPersonales = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.Label();
            this.codigoPostal = new System.Windows.Forms.Label();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.correoTexto = new System.Windows.Forms.Label();
            this.telefonoTexto = new System.Windows.Forms.Label();
            this.calleTexto = new System.Windows.Forms.Label();
            this.localidadTexto = new System.Windows.Forms.Label();
            this.codigoPostalTexto = new System.Windows.Forms.Label();
            this.flecha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenUsuario
            // 
            this.imagenUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imagenUsuario.Image")));
            this.imagenUsuario.Location = new System.Drawing.Point(12, 12);
            this.imagenUsuario.Name = "imagenUsuario";
            this.imagenUsuario.Size = new System.Drawing.Size(200, 200);
            this.imagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenUsuario.TabIndex = 0;
            this.imagenUsuario.TabStop = false;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.BackColor = System.Drawing.Color.White;
            this.nombreUsuario.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.Location = new System.Drawing.Point(269, 34);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(334, 37);
            this.nombreUsuario.TabIndex = 1;
            this.nombreUsuario.Text = "Francisco José  Pérez Delgado";
            // 
            // usuarioTexto
            // 
            this.usuarioTexto.AutoSize = true;
            this.usuarioTexto.BackColor = System.Drawing.Color.White;
            this.usuarioTexto.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTexto.Location = new System.Drawing.Point(269, 150);
            this.usuarioTexto.Name = "usuarioTexto";
            this.usuarioTexto.Size = new System.Drawing.Size(168, 37);
            this.usuarioTexto.TabIndex = 2;
            this.usuarioTexto.Text = "francispepe24";
            // 
            // datosPersonales
            // 
            this.datosPersonales.AutoSize = true;
            this.datosPersonales.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosPersonales.Location = new System.Drawing.Point(454, 250);
            this.datosPersonales.Name = "datosPersonales";
            this.datosPersonales.Size = new System.Drawing.Size(200, 37);
            this.datosPersonales.TabIndex = 3;
            this.datosPersonales.Text = "Datos personales:";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(13, 351);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(166, 28);
            this.correo.TabIndex = 4;
            this.correo.Text = "Correo Electrónico:";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.telefono.Location = new System.Drawing.Point(95, 427);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(84, 28);
            this.telefono.TabIndex = 5;
            this.telefono.Text = "Teléfono:";
            // 
            // calle
            // 
            this.calle.AutoSize = true;
            this.calle.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.calle.Location = new System.Drawing.Point(650, 328);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(55, 28);
            this.calle.TabIndex = 6;
            this.calle.Text = "Calle:";
            // 
            // localidad
            // 
            this.localidad.AutoSize = true;
            this.localidad.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.localidad.Location = new System.Drawing.Point(611, 398);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(94, 28);
            this.localidad.TabIndex = 7;
            this.localidad.Text = "Localidad:";
            // 
            // codigoPostal
            // 
            this.codigoPostal.AutoSize = true;
            this.codigoPostal.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.codigoPostal.Location = new System.Drawing.Point(579, 471);
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(126, 28);
            this.codigoPostal.TabIndex = 8;
            this.codigoPostal.Text = "Código Postal:";
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarSesion.Location = new System.Drawing.Point(850, 99);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(150, 50);
            this.botonCerrarSesion.TabIndex = 9;
            this.botonCerrarSesion.Text = "Cerrar sesión";
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // correoTexto
            // 
            this.correoTexto.AutoSize = true;
            this.correoTexto.BackColor = System.Drawing.Color.White;
            this.correoTexto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTexto.Location = new System.Drawing.Point(185, 351);
            this.correoTexto.Name = "correoTexto";
            this.correoTexto.Size = new System.Drawing.Size(173, 28);
            this.correoTexto.TabIndex = 10;
            this.correoTexto.Text = "correo@ejemplo.com";
            // 
            // telefonoTexto
            // 
            this.telefonoTexto.AutoSize = true;
            this.telefonoTexto.BackColor = System.Drawing.Color.White;
            this.telefonoTexto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTexto.Location = new System.Drawing.Point(185, 427);
            this.telefonoTexto.Name = "telefonoTexto";
            this.telefonoTexto.Size = new System.Drawing.Size(120, 28);
            this.telefonoTexto.TabIndex = 11;
            this.telefonoTexto.Text = "123456789";
            // 
            // calleTexto
            // 
            this.calleTexto.AutoSize = true;
            this.calleTexto.BackColor = System.Drawing.Color.White;
            this.calleTexto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calleTexto.Location = new System.Drawing.Point(729, 328);
            this.calleTexto.Name = "calleTexto";
            this.calleTexto.Size = new System.Drawing.Size(185, 28);
            this.calleTexto.TabIndex = 12;
            this.calleTexto.Text = "Calle Invetada 8, 4ºC";
            // 
            // localidadTexto
            // 
            this.localidadTexto.AutoSize = true;
            this.localidadTexto.BackColor = System.Drawing.Color.White;
            this.localidadTexto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadTexto.Location = new System.Drawing.Point(729, 398);
            this.localidadTexto.Name = "localidadTexto";
            this.localidadTexto.Size = new System.Drawing.Size(80, 28);
            this.localidadTexto.TabIndex = 13;
            this.localidadTexto.Text = "Móstoles";
            // 
            // codigoPostalTexto
            // 
            this.codigoPostalTexto.AutoSize = true;
            this.codigoPostalTexto.BackColor = System.Drawing.Color.White;
            this.codigoPostalTexto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoPostalTexto.Location = new System.Drawing.Point(729, 471);
            this.codigoPostalTexto.Name = "codigoPostalTexto";
            this.codigoPostalTexto.Size = new System.Drawing.Size(72, 28);
            this.codigoPostalTexto.TabIndex = 14;
            this.codigoPostalTexto.Text = "28923";
            // 
            // flecha
            // 
            this.flecha.Image = ((System.Drawing.Image)(resources.GetObject("flecha.Image")));
            this.flecha.Location = new System.Drawing.Point(1018, 522);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(45, 45);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha.TabIndex = 21;
            this.flecha.TabStop = false;
            this.flecha.Click += new System.EventHandler(this.flecha_Click);
            // 
            // datosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1075, 579);
            this.Controls.Add(this.flecha);
            this.Controls.Add(this.codigoPostalTexto);
            this.Controls.Add(this.localidadTexto);
            this.Controls.Add(this.calleTexto);
            this.Controls.Add(this.telefonoTexto);
            this.Controls.Add(this.correoTexto);
            this.Controls.Add(this.botonCerrarSesion);
            this.Controls.Add(this.codigoPostal);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.calle);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.datosPersonales);
            this.Controls.Add(this.usuarioTexto);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.imagenUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "datosUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenUsuario;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label usuarioTexto;
        private System.Windows.Forms.Label datosPersonales;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label calle;
        private System.Windows.Forms.Label localidad;
        private System.Windows.Forms.Label codigoPostal;
        private System.Windows.Forms.Button botonCerrarSesion;
        private System.Windows.Forms.Label correoTexto;
        private System.Windows.Forms.Label telefonoTexto;
        private System.Windows.Forms.Label calleTexto;
        private System.Windows.Forms.Label localidadTexto;
        private System.Windows.Forms.Label codigoPostalTexto;
        private System.Windows.Forms.PictureBox flecha;
    }
}