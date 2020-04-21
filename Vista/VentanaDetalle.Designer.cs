namespace Vista
{
    partial class VentanaDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDetalle));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblEtiquetaTitulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDEscripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.gpbCodigo = new System.Windows.Forms.GroupBox();
            this.gpbNombre = new System.Windows.Forms.GroupBox();
            this.gpbMarca = new System.Windows.Forms.GroupBox();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.gpbDescripcion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.gpbCodigo.SuspendLayout();
            this.gpbNombre.SuspendLayout();
            this.gpbMarca.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            this.gpbDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Vista.Properties.Resources.btnSalirVolver;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVolver.Location = new System.Drawing.Point(604, 17);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(60, 60);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::Vista.Properties.Resources.btnModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnModificar.Location = new System.Drawing.Point(102, 420);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 60);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblEtiquetaTitulo
            // 
            this.lblEtiquetaTitulo.AutoSize = true;
            this.lblEtiquetaTitulo.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaTitulo.Location = new System.Drawing.Point(47, 30);
            this.lblEtiquetaTitulo.Name = "lblEtiquetaTitulo";
            this.lblEtiquetaTitulo.Size = new System.Drawing.Size(211, 29);
            this.lblEtiquetaTitulo.TabIndex = 2;
            this.lblEtiquetaTitulo.Text = "Detalle de articulo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(312, 314);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(315, 23);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(28, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 18);
            this.lblCodigo.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 18);
            this.lblNombre.TabIndex = 10;
            // 
            // lblDEscripcion
            // 
            this.lblDEscripcion.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEscripcion.Location = new System.Drawing.Point(20, 24);
            this.lblDEscripcion.Name = "lblDEscripcion";
            this.lblDEscripcion.Size = new System.Drawing.Size(368, 105);
            this.lblDEscripcion.TabIndex = 11;
            this.lblDEscripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(28, 23);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 18);
            this.lblMarca.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(28, 23);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 18);
            this.lblCategoria.TabIndex = 13;
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(312, 92);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(315, 203);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 14;
            this.ptbImagen.TabStop = false;
            // 
            // gpbCodigo
            // 
            this.gpbCodigo.Controls.Add(this.lblCodigo);
            this.gpbCodigo.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodigo.Location = new System.Drawing.Point(32, 92);
            this.gpbCodigo.Name = "gpbCodigo";
            this.gpbCodigo.Size = new System.Drawing.Size(200, 60);
            this.gpbCodigo.TabIndex = 15;
            this.gpbCodigo.TabStop = false;
            this.gpbCodigo.Text = " Codigo ";
            // 
            // gpbNombre
            // 
            this.gpbNombre.Controls.Add(this.lblNombre);
            this.gpbNombre.Location = new System.Drawing.Point(32, 171);
            this.gpbNombre.Name = "gpbNombre";
            this.gpbNombre.Size = new System.Drawing.Size(200, 60);
            this.gpbNombre.TabIndex = 16;
            this.gpbNombre.TabStop = false;
            this.gpbNombre.Text = " Nombre ";
            // 
            // gpbMarca
            // 
            this.gpbMarca.Controls.Add(this.lblMarca);
            this.gpbMarca.Location = new System.Drawing.Point(32, 250);
            this.gpbMarca.Name = "gpbMarca";
            this.gpbMarca.Size = new System.Drawing.Size(200, 60);
            this.gpbMarca.TabIndex = 17;
            this.gpbMarca.TabStop = false;
            this.gpbMarca.Text = " Marca ";
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.lblCategoria);
            this.gpbCategoria.Location = new System.Drawing.Point(32, 329);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(200, 60);
            this.gpbCategoria.TabIndex = 18;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = " Categoria ";
            // 
            // gpbDescripcion
            // 
            this.gpbDescripcion.Controls.Add(this.lblDEscripcion);
            this.gpbDescripcion.Location = new System.Drawing.Point(265, 377);
            this.gpbDescripcion.Name = "gpbDescripcion";
            this.gpbDescripcion.Size = new System.Drawing.Size(408, 147);
            this.gpbDescripcion.TabIndex = 19;
            this.gpbDescripcion.TabStop = false;
            this.gpbDescripcion.Text = " Descripcion";
            // 
            // VentanaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.gpbDescripcion);
            this.Controls.Add(this.gpbCategoria);
            this.Controls.Add(this.gpbMarca);
            this.Controls.Add(this.gpbNombre);
            this.Controls.Add(this.gpbCodigo);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblEtiquetaTitulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVolver);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 580);
            this.Name = "VentanaDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VentanaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.gpbCodigo.ResumeLayout(false);
            this.gpbCodigo.PerformLayout();
            this.gpbNombre.ResumeLayout(false);
            this.gpbNombre.PerformLayout();
            this.gpbMarca.ResumeLayout(false);
            this.gpbMarca.PerformLayout();
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            this.gpbDescripcion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblEtiquetaTitulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDEscripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.GroupBox gpbCodigo;
        private System.Windows.Forms.GroupBox gpbNombre;
        private System.Windows.Forms.GroupBox gpbMarca;
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.GroupBox gpbDescripcion;
    }
}