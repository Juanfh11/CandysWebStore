namespace CaramelosPaco
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.panel = new System.Windows.Forms.Panel();
            this.imagenUsuario = new System.Windows.Forms.PictureBox();
            this.carrito = new System.Windows.Forms.PictureBox();
            this.imagenChuches = new System.Windows.Forms.PictureBox();
            this.imagenCaramelos = new System.Windows.Forms.PictureBox();
            this.imagenBombones = new System.Windows.Forms.PictureBox();
            this.labelChuches = new System.Windows.Forms.Label();
            this.labelCaramelos = new System.Windows.Forms.Label();
            this.labelChocolate = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenChuches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCaramelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBombones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.imagenUsuario);
            this.panel.Controls.Add(this.carrito);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1076, 45);
            this.panel.TabIndex = 0;
            // 
            // imagenUsuario
            // 
            this.imagenUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imagenUsuario.Image")));
            this.imagenUsuario.Location = new System.Drawing.Point(12, 0);
            this.imagenUsuario.Name = "imagenUsuario";
            this.imagenUsuario.Size = new System.Drawing.Size(45, 45);
            this.imagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenUsuario.TabIndex = 7;
            this.imagenUsuario.TabStop = false;
            this.imagenUsuario.Click += new System.EventHandler(this.imagenUsuario_Click);
            // 
            // carrito
            // 
            this.carrito.Image = ((System.Drawing.Image)(resources.GetObject("carrito.Image")));
            this.carrito.Location = new System.Drawing.Point(1018, 0);
            this.carrito.Name = "carrito";
            this.carrito.Size = new System.Drawing.Size(45, 45);
            this.carrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carrito.TabIndex = 1;
            this.carrito.TabStop = false;
            this.carrito.Click += new System.EventHandler(this.carrito_Click);
            // 
            // imagenChuches
            // 
            this.imagenChuches.Image = ((System.Drawing.Image)(resources.GetObject("imagenChuches.Image")));
            this.imagenChuches.Location = new System.Drawing.Point(33, 127);
            this.imagenChuches.Name = "imagenChuches";
            this.imagenChuches.Size = new System.Drawing.Size(310, 414);
            this.imagenChuches.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenChuches.TabIndex = 1;
            this.imagenChuches.TabStop = false;
            this.imagenChuches.Click += new System.EventHandler(this.imagenChuches_Click);
            // 
            // imagenCaramelos
            // 
            this.imagenCaramelos.Image = ((System.Drawing.Image)(resources.GetObject("imagenCaramelos.Image")));
            this.imagenCaramelos.Location = new System.Drawing.Point(373, 127);
            this.imagenCaramelos.Name = "imagenCaramelos";
            this.imagenCaramelos.Size = new System.Drawing.Size(310, 414);
            this.imagenCaramelos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenCaramelos.TabIndex = 2;
            this.imagenCaramelos.TabStop = false;
            this.imagenCaramelos.Click += new System.EventHandler(this.imagenCaramelos_Click);
            // 
            // imagenBombones
            // 
            this.imagenBombones.Image = ((System.Drawing.Image)(resources.GetObject("imagenBombones.Image")));
            this.imagenBombones.Location = new System.Drawing.Point(731, 127);
            this.imagenBombones.Name = "imagenBombones";
            this.imagenBombones.Size = new System.Drawing.Size(310, 414);
            this.imagenBombones.TabIndex = 3;
            this.imagenBombones.TabStop = false;
            this.imagenBombones.Click += new System.EventHandler(this.imagenBombones_Click);
            // 
            // labelChuches
            // 
            this.labelChuches.AutoSize = true;
            this.labelChuches.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuches.Location = new System.Drawing.Point(121, 83);
            this.labelChuches.Name = "labelChuches";
            this.labelChuches.Size = new System.Drawing.Size(124, 37);
            this.labelChuches.TabIndex = 4;
            this.labelChuches.Text = "CHUCHES";
            // 
            // labelCaramelos
            // 
            this.labelCaramelos.AutoSize = true;
            this.labelCaramelos.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaramelos.Location = new System.Drawing.Point(444, 83);
            this.labelCaramelos.Name = "labelCaramelos";
            this.labelCaramelos.Size = new System.Drawing.Size(156, 37);
            this.labelCaramelos.TabIndex = 5;
            this.labelCaramelos.Text = "CARAMELOS";
            // 
            // labelChocolate
            // 
            this.labelChocolate.AutoSize = true;
            this.labelChocolate.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChocolate.Location = new System.Drawing.Point(800, 83);
            this.labelChocolate.Name = "labelChocolate";
            this.labelChocolate.Size = new System.Drawing.Size(155, 37);
            this.labelChocolate.TabIndex = 6;
            this.labelChocolate.Text = "CHOCOLATE";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1075, 579);
            this.Controls.Add(this.labelChocolate);
            this.Controls.Add(this.labelCaramelos);
            this.Controls.Add(this.labelChuches);
            this.Controls.Add(this.imagenBombones);
            this.Controls.Add(this.imagenCaramelos);
            this.Controls.Add(this.imagenChuches);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.inicio_FormClosed);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenChuches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCaramelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBombones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox carrito;
        private System.Windows.Forms.PictureBox imagenChuches;
        private System.Windows.Forms.PictureBox imagenCaramelos;
        private System.Windows.Forms.PictureBox imagenBombones;
        private System.Windows.Forms.PictureBox imagenUsuario;
        private System.Windows.Forms.Label labelChuches;
        private System.Windows.Forms.Label labelCaramelos;
        private System.Windows.Forms.Label labelChocolate;
    }
}