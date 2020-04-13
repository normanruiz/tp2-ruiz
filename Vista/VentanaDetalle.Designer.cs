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
            this.btnVolver.Location = new System.Drawing.Point(591, 374);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(60, 60);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(591, 290);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 60);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblEtiquetaTitulo
            // 
            this.lblEtiquetaTitulo.AutoSize = true;
            this.lblEtiquetaTitulo.Location = new System.Drawing.Point(59, 24);
            this.lblEtiquetaTitulo.Name = "lblEtiquetaTitulo";
            this.lblEtiquetaTitulo.Size = new System.Drawing.Size(92, 13);
            this.lblEtiquetaTitulo.TabIndex = 2;
            this.lblEtiquetaTitulo.Text = "Detalle de articulo";
            // 
            // lblEtiquetaCodigo
            // 
            this.lblEtiquetaCodigo.AutoSize = true;
            this.lblEtiquetaCodigo.Location = new System.Drawing.Point(22, 100);
            this.lblEtiquetaCodigo.Name = "lblEtiquetaCodigo";
            this.lblEtiquetaCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblEtiquetaCodigo.TabIndex = 3;
            this.lblEtiquetaCodigo.Text = "Codigo";
            // 
            // lblEtiquetaNombre
            // 
            this.lblEtiquetaNombre.AutoSize = true;
            this.lblEtiquetaNombre.Location = new System.Drawing.Point(22, 146);
            this.lblEtiquetaNombre.Name = "lblEtiquetaNombre";
            this.lblEtiquetaNombre.Size = new System.Drawing.Size(44, 13);
            this.lblEtiquetaNombre.TabIndex = 4;
            this.lblEtiquetaNombre.Text = "Nombre";
            // 
            // lblEtiquetaDescripcion
            // 
            this.lblEtiquetaDescripcion.AutoSize = true;
            this.lblEtiquetaDescripcion.Location = new System.Drawing.Point(335, 290);
            this.lblEtiquetaDescripcion.Name = "lblEtiquetaDescripcion";
            this.lblEtiquetaDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblEtiquetaDescripcion.TabIndex = 5;
            this.lblEtiquetaDescripcion.Text = "Descripcion";
            // 
            // lblEtiquetaMarca
            // 
            this.lblEtiquetaMarca.AutoSize = true;
            this.lblEtiquetaMarca.Location = new System.Drawing.Point(22, 192);
            this.lblEtiquetaMarca.Name = "lblEtiquetaMarca";
            this.lblEtiquetaMarca.Size = new System.Drawing.Size(37, 13);
            this.lblEtiquetaMarca.TabIndex = 6;
            this.lblEtiquetaMarca.Text = "Marca";
            // 
            // lblEtiquetaCategoria
            // 
            this.lblEtiquetaCategoria.AutoSize = true;
            this.lblEtiquetaCategoria.Location = new System.Drawing.Point(22, 238);
            this.lblEtiquetaCategoria.Name = "lblEtiquetaCategoria";
            this.lblEtiquetaCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblEtiquetaCategoria.TabIndex = 7;
            this.lblEtiquetaCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(348, 36);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(106, 100);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(106, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 10;
            // 
            // lblDEscripcion
            // 
            this.lblDEscripcion.Location = new System.Drawing.Point(206, 322);
            this.lblDEscripcion.Name = "lblDEscripcion";
            this.lblDEscripcion.Size = new System.Drawing.Size(318, 93);
            this.lblDEscripcion.TabIndex = 11;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(106, 192);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 13);
            this.lblMarca.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(106, 238);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblCategoria.TabIndex = 13;
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(209, 68);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(315, 203);
            this.ptbImagen.TabIndex = 14;
            this.ptbImagen.TabStop = false;
            // 
            // VentanaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(673, 450);
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