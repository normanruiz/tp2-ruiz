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
            this.lblEtiquetaCodigo = new System.Windows.Forms.Label();
            this.lblEtiquetaNombre = new System.Windows.Forms.Label();
            this.lblEtiquetaDescripcion = new System.Windows.Forms.Label();
            this.lblEtiquetaMarca = new System.Windows.Forms.Label();
            this.lblEtiquetaCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDEscripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Vista.Properties.Resources.btnSalirVolver;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVolver.Location = new System.Drawing.Point(599, 19);
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
            this.btnModificar.Location = new System.Drawing.Point(65, 420);
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
            this.lblEtiquetaTitulo.Location = new System.Drawing.Point(42, 32);
            this.lblEtiquetaTitulo.Name = "lblEtiquetaTitulo";
            this.lblEtiquetaTitulo.Size = new System.Drawing.Size(211, 29);
            this.lblEtiquetaTitulo.TabIndex = 2;
            this.lblEtiquetaTitulo.Text = "Detalle de articulo";
            // 
            // lblEtiquetaCodigo
            // 
            this.lblEtiquetaCodigo.AutoSize = true;
            this.lblEtiquetaCodigo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaCodigo.Location = new System.Drawing.Point(62, 94);
            this.lblEtiquetaCodigo.Name = "lblEtiquetaCodigo";
            this.lblEtiquetaCodigo.Size = new System.Drawing.Size(54, 18);
            this.lblEtiquetaCodigo.TabIndex = 3;
            this.lblEtiquetaCodigo.Text = "Codigo";
            // 
            // lblEtiquetaNombre
            // 
            this.lblEtiquetaNombre.AutoSize = true;
            this.lblEtiquetaNombre.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaNombre.Location = new System.Drawing.Point(62, 162);
            this.lblEtiquetaNombre.Name = "lblEtiquetaNombre";
            this.lblEtiquetaNombre.Size = new System.Drawing.Size(59, 18);
            this.lblEtiquetaNombre.TabIndex = 4;
            this.lblEtiquetaNombre.Text = "Nombre";
            // 
            // lblEtiquetaDescripcion
            // 
            this.lblEtiquetaDescripcion.AutoSize = true;
            this.lblEtiquetaDescripcion.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaDescripcion.Location = new System.Drawing.Point(379, 358);
            this.lblEtiquetaDescripcion.Name = "lblEtiquetaDescripcion";
            this.lblEtiquetaDescripcion.Size = new System.Drawing.Size(77, 17);
            this.lblEtiquetaDescripcion.TabIndex = 5;
            this.lblEtiquetaDescripcion.Text = "Descripcion";
            // 
            // lblEtiquetaMarca
            // 
            this.lblEtiquetaMarca.AutoSize = true;
            this.lblEtiquetaMarca.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaMarca.Location = new System.Drawing.Point(62, 230);
            this.lblEtiquetaMarca.Name = "lblEtiquetaMarca";
            this.lblEtiquetaMarca.Size = new System.Drawing.Size(50, 18);
            this.lblEtiquetaMarca.TabIndex = 6;
            this.lblEtiquetaMarca.Text = "Marca";
            // 
            // lblEtiquetaCategoria
            // 
            this.lblEtiquetaCategoria.AutoSize = true;
            this.lblEtiquetaCategoria.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaCategoria.Location = new System.Drawing.Point(62, 298);
            this.lblEtiquetaCategoria.Name = "lblEtiquetaCategoria";
            this.lblEtiquetaCategoria.Size = new System.Drawing.Size(71, 18);
            this.lblEtiquetaCategoria.TabIndex = 7;
            this.lblEtiquetaCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(387, 316);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 23);
            this.lblPrecio.TabIndex = 8;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(62, 128);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 18);
            this.lblCodigo.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(62, 196);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 18);
            this.lblNombre.TabIndex = 10;
            // 
            // lblDEscripcion
            // 
            this.lblDEscripcion.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEscripcion.Location = new System.Drawing.Point(197, 394);
            this.lblDEscripcion.Name = "lblDEscripcion";
            this.lblDEscripcion.Size = new System.Drawing.Size(441, 112);
            this.lblDEscripcion.TabIndex = 11;
            this.lblDEscripcion.Click += new System.EventHandler(this.lblDEscripcion_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(62, 264);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 18);
            this.lblMarca.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(62, 332);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 18);
            this.lblCategoria.TabIndex = 13;
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(260, 94);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(315, 203);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 14;
            this.ptbImagen.TabStop = false;
            // 
            // VentanaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(701, 525);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDEscripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblEtiquetaCategoria);
            this.Controls.Add(this.lblEtiquetaMarca);
            this.Controls.Add(this.lblEtiquetaDescripcion);
            this.Controls.Add(this.lblEtiquetaNombre);
            this.Controls.Add(this.lblEtiquetaCodigo);
            this.Controls.Add(this.lblEtiquetaTitulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVolver);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VentanaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblEtiquetaTitulo;
        private System.Windows.Forms.Label lblEtiquetaCodigo;
        private System.Windows.Forms.Label lblEtiquetaNombre;
        private System.Windows.Forms.Label lblEtiquetaDescripcion;
        private System.Windows.Forms.Label lblEtiquetaMarca;
        private System.Windows.Forms.Label lblEtiquetaCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDEscripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox ptbImagen;
    }
}