namespace Vista
{
    partial class VentanaNuevoModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaNuevoModificar));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloURL = new System.Windows.Forms.Label();
            this.tbxURLImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(259, 343);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(26, 170);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 18);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(26, 216);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(71, 18);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(26, 262);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 18);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(105, 121);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(167, 25);
            this.tbxNombre.TabIndex = 8;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            this.tbxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNombre_Validating);
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(84, 376);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(437, 121);
            this.tbxDescripcion.TabIndex = 9;
            this.tbxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDescripcion_KeyPress);
            this.tbxDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.tbxDescripcion_Validating);
            // 
            // cbxMarca
            // 
            this.cbxMarca.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(105, 167);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(167, 26);
            this.cbxMarca.TabIndex = 10;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(105, 213);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(167, 26);
            this.cbxCategoria.TabIndex = 11;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrecio.Location = new System.Drawing.Point(105, 259);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(167, 25);
            this.tbxPrecio.TabIndex = 12;
            this.tbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecio_KeyPress);
            this.tbxPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPrecio_Validating);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(105, 75);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(167, 25);
            this.tbxCodigo.TabIndex = 16;
            this.tbxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCodigo_KeyPress);
            this.tbxCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.tbxCodigo_Validating);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(26, 78);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 18);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(72, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(377, 23);
            this.lblTitulo.TabIndex = 17;
            // 
            // lblTituloURL
            // 
            this.lblTituloURL.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloURL.Location = new System.Drawing.Point(330, 142);
            this.lblTituloURL.Name = "lblTituloURL";
            this.lblTituloURL.Size = new System.Drawing.Size(248, 23);
            this.lblTituloURL.TabIndex = 18;
            this.lblTituloURL.Text = "Ingrese la URL de la imagen";
            this.lblTituloURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloURL.Visible = false;
            // 
            // tbxURLImagen
            // 
            this.tbxURLImagen.Location = new System.Drawing.Point(333, 194);
            this.tbxURLImagen.Name = "tbxURLImagen";
            this.tbxURLImagen.Size = new System.Drawing.Size(245, 20);
            this.tbxURLImagen.TabIndex = 19;
            this.tbxURLImagen.Visible = false;
            this.tbxURLImagen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxURLImagen_KeyPress);
            this.tbxURLImagen.Validating += new System.ComponentModel.CancelEventHandler(this.tbxURLImagen_Validating);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackgroundImage = global::Vista.Properties.Resources.btnMas;
            this.btnAgregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(278, 213);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(30, 26);
            this.btnAgregarCategoria.TabIndex = 21;
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackgroundImage = global::Vista.Properties.Resources.btnMas;
            this.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMarca.Location = new System.Drawing.Point(278, 167);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(30, 26);
            this.btnAgregarMarca.TabIndex = 20;
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.BackgroundImage = global::Vista.Properties.Resources.btnCargarImagen;
            this.btnImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImagen.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnImagen.Location = new System.Drawing.Point(425, 298);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(60, 60);
            this.btnImagen.TabIndex = 14;
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImagen.Location = new System.Drawing.Point(343, 78);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(225, 204);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 13;
            this.ptbImagen.TabStop = false;
            this.ptbImagen.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Vista.Properties.Resources.btnSalirVolver;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVolver.Location = new System.Drawing.Point(364, 518);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(60, 60);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Vista.Properties.Resources.btnAceptar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuardar.Location = new System.Drawing.Point(181, 518);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 60);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // VentanaNuevoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(604, 601);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.tbxURLImagen);
            this.Controls.Add(this.lblTituloURL);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(620, 640);
            this.Name = "VentanaNuevoModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VentanaNuevoModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloURL;
        private System.Windows.Forms.TextBox tbxURLImagen;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
    }
}