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
    public partial class VentanaDetalle : Form
    {
        Articulo articuloSeleccionado;
        public VentanaDetalle(Articulo articulo)
        {
            InitializeComponent();
            articuloSeleccionado = new Articulo();
            articuloSeleccionado = articulo;
        }

        public void CargarArticulo()
        {
            lblCodigo.Text = articuloSeleccionado.Codigo;
            lblNombre.Text = articuloSeleccionado.Nombre;
            lblMarca.Text = articuloSeleccionado.marca.Descripcion;
            lblCategoria.Text = articuloSeleccionado.categoria.Descripcion;
            lblDEscripcion.Text = articuloSeleccionado.Descripcion;
            lblPrecio.Text = "$ " + articuloSeleccionado.Precio;
            ptbImagen.Load(articuloSeleccionado.Imagen);
        }

        private void VentanaDetalle_Load(object sender, EventArgs e)
        {
            CargarArticulo();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            VentanaNuevoModificar ventanaModificar;
            try
            {
                ventanaModificar = new VentanaNuevoModificar(articuloSeleccionado);
                ventanaModificar.ShowDialog();
                CargarArticulo();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}
