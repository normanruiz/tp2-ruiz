namespace Vista
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgbCatalogo = new System.Windows.Forms.DataGridView();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEleminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ckbFiltros = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitulo.Location = new System.Drawing.Point(169, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(301, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Catalogo de articulos";
            // 
            // dgbCatalogo
            // 
            this.dgbCatalogo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgbCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbCatalogo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgbCatalogo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgbCatalogo.Location = new System.Drawing.Point(104, 164);
            this.dgbCatalogo.MultiSelect = false;
            this.dgbCatalogo.Name = "dgbCatalogo";
            this.dgbCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbCatalogo.Size = new System.Drawing.Size(856, 380);
            this.dgbCatalogo.TabIndex = 9;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.BackColor = System.Drawing.SystemColors.GrayText;
            this.tbxCodigo.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCodigo.Location = new System.Drawing.Point(104, 127);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(187, 24);
            this.tbxCodigo.TabIndex = 4;
            this.tbxCodigo.Text = "Filtrar por Codigo...";
            this.tbxCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxCodigo_MouseClick);
            this.tbxCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxCodigo_KeyUp);
            this.tbxCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.tbxCodigo_Validating);
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.SystemColors.GrayText;
            this.tbxNombre.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxNombre.Location = new System.Drawing.Point(314, 127);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(187, 24);
            this.tbxNombre.TabIndex = 5;
            this.tbxNombre.Text = "Filtrar por Nombre...";
            this.tbxNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxNombre_MouseClick);
            this.tbxNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxNombre_KeyUp);
            this.tbxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNombre_Validating);
            // 
            // cbxMarca
            // 
            this.cbxMarca.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxMarca.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(524, 126);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(187, 25);
            this.cbxMarca.TabIndex = 7;
            this.cbxMarca.Text = "Filtrar por Marca...";
            this.cbxMarca.SelectionChangeCommitted += new System.EventHandler(this.cbxMarca_SelectionChangeCommitted);
            this.cbxMarca.Validating += new System.ComponentModel.CancelEventHandler(this.cbxMarca_Validating);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxCategoria.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(734, 126);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(187, 25);
            this.cbxCategoria.TabIndex = 8;
            this.cbxCategoria.Text = "Filtrar por Categoria...";
            this.cbxCategoria.SelectionChangeCommitted += new System.EventHandler(this.cbxCategoria_SelectionChangeCommitted);
            this.cbxCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.cbxCategoria_Validating);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Vista.Properties.Resources.Logo;
            this.pbxLogo.Location = new System.Drawing.Point(17, 14);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(134, 104);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 12;
            this.pbxLogo.TabStop = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackgroundImage = global::Vista.Properties.Resources.btnDetalle;
            this.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetalle.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDetalle.Location = new System.Drawing.Point(24, 445);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(60, 60);
            this.btnDetalle.TabIndex = 3;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEleminar
            // 
            this.btnEleminar.BackgroundImage = global::Vista.Properties.Resources.btnEliminar;
            this.btnEleminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEleminar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEleminar.Location = new System.Drawing.Point(24, 361);
            this.btnEleminar.Name = "btnEleminar";
            this.btnEleminar.Size = new System.Drawing.Size(60, 60);
            this.btnEleminar.TabIndex = 2;
            this.btnEleminar.UseVisualStyleBackColor = true;
            this.btnEleminar.Click += new System.EventHandler(this.btnEleminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::Vista.Properties.Resources.btnModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnModificar.Location = new System.Drawing.Point(24, 277);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 60);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::Vista.Properties.Resources.btnNuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnNuevo.Location = new System.Drawing.Point(24, 193);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Vista.Properties.Resources.btnSalirVolver;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(896, 25);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 60);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ckbFiltros
            // 
            this.ckbFiltros.AutoSize = true;
            this.ckbFiltros.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ckbFiltros.Location = new System.Drawing.Point(939, 131);
            this.ckbFiltros.Name = "ckbFiltros";
            this.ckbFiltros.Size = new System.Drawing.Size(15, 14);
            this.ckbFiltros.TabIndex = 13;
            this.ckbFiltros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ckbFiltros.UseVisualStyleBackColor = true;
            this.ckbFiltros.CheckedChanged += new System.EventHandler(this.ckbFiltros_CheckedChanged);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ckbFiltros);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEleminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.dgbCatalogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgbCatalogo;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEleminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.CheckBox ckbFiltros;
    }
}