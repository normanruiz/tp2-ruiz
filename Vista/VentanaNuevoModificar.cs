using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class VentanaNuevoModificar : Form
    {
        Articulo articulo;
        public VentanaNuevoModificar()
        {
            InitializeComponent();
            lblTitulo.Text = "Nuevo articulo";
            articulo = new Articulo();
        }

        public VentanaNuevoModificar(Articulo articuloAux)
        {
            InitializeComponent();
            lblTitulo.Text = "Modificar articulo";
            articulo = articuloAux;
        }

        private void VentanaNuevoModificar_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            CargarCategorias();
            if(articulo.Id > 0)
            {
                tbxCodigo.Text = articulo.Codigo;
                tbxNombre.Text = articulo.Nombre;
                cbxMarca.SelectedValue = articulo.marca.Id;
                cbxCategoria.SelectedValue = articulo.categoria.Id;
                tbxDescripcion.Text = articulo.Descripcion;
                tbxURLImagen.Text = articulo.Imagen;
                ptbImagen.Load(tbxURLImagen.Text);
                ptbImagen.Visible = true;
                tbxPrecio.Text = articulo.Precio.ToString();
            } 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ControladorArticulo controladorArticulo;
            try
            {
                if(tbxCodigo.Text.Length == 0 || tbxNombre.Text.Length == 0 || tbxPrecio.Text.Length == 0 || tbxDescripcion.Text.Length == 0 || tbxURLImagen.Text.Length == 0)
                {
                    if (tbxCodigo.Text.Length == 0)
                    {
                        tbxCodigo.BackColor = Color.Red;
                    }
                    if (tbxNombre.Text.Length == 0)
                    {
                         tbxNombre.BackColor = Color.Red;
                    }
                    if (tbxPrecio.Text.Length == 0)
                    {
                        tbxPrecio.BackColor = Color.Red;
                    }
                    if (tbxDescripcion.Text.Length == 0)
                    {
                        tbxDescripcion.BackColor = Color.Red;
                    }
                    if (tbxURLImagen.Text.Length == 0)
                    {
                         tbxURLImagen.BackColor = Color.Red;
                    }
                    MessageBox.Show("Complete todos los campos antes de intentar continuar...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {


                    controladorArticulo = new ControladorArticulo();
                    articulo.Codigo = tbxCodigo.Text;
                    articulo.Nombre = tbxNombre.Text;
                    articulo.marca = new Marca();
                    articulo.marca = (Marca)cbxMarca.SelectedItem;
                    articulo.categoria = new Categoria();
                    articulo.categoria = (Categoria)cbxCategoria.SelectedItem;
                    articulo.Imagen = tbxURLImagen.Text;
                    articulo.Precio = Convert.ToDecimal(tbxPrecio.Text);
                    articulo.Descripcion = tbxDescripcion.Text;

                    if (articulo.Id > 0)
                    {
                        controladorArticulo.GuardarModificado(articulo);
                    }
                    else
                    {
                        controladorArticulo.AgregarNuevo(articulo);
                    }

                    this.Close();
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CargarMarcas()
        {
            ControladorMarca controladorMarca;
            try
            {
                controladorMarca = new ControladorMarca();
                cbxMarca.DataSource = controladorMarca.Listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CargarCategorias()
        {
            ControladorCategoria controladorCategoria;
            try
            {
                controladorCategoria = new ControladorCategoria();
                cbxCategoria.DataSource = controladorCategoria.Listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxURLImagen.Visible)
                {
                    lblTituloURL.Visible = false;
                    tbxURLImagen.Visible = false;
                    ptbImagen.Visible = true;
                    ptbImagen.Load(tbxURLImagen.Text);
                }
                else
                {
                    ptbImagen.Visible = false;
                    lblTituloURL.Visible = true;
                    tbxURLImagen.Visible = true;
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
            else
            {
                tbxPrecio.BackColor = System.Drawing.SystemColors.Window;
            }

        }

        private void tbxCodigo_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
        }

        private void tbxNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }

            //ValidarOk();
        }

        private void tbxPrecio_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }

            //ValidarOk();
        }

        private void tbxURLImagen_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }

            //ValidarOk();
        }

        private void tbxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }

            //ValidarOk();
        }

        private void tbxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxCodigo.BackColor = System.Drawing.SystemColors.Window;
        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxNombre.BackColor = System.Drawing.SystemColors.Window;
        }

        private void tbxURLImagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxURLImagen.BackColor = System.Drawing.SystemColors.Window;
        }

        private void tbxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxDescripcion.BackColor = System.Drawing.SystemColors.Window;
        }
    }
}
