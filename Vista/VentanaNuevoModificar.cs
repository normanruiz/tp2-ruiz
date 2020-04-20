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

                if(articulo.Id > 0)
                {
                    controladorArticulo.GuardarModificado(articulo);
                }
                else
                {
                    controladorArticulo.AgregarNuevo(articulo);
                }

                this.Close();
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
    }
}
