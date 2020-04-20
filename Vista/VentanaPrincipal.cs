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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            CargarArticulos();
            CargarMarcas();
            CargarCategorias();
            tbxCodigo.Enabled = false;
            tbxNombre.Enabled = false;
            tbxDescripcion.Enabled = false;
            cbxMarca.Enabled = false;
            cbxCategoria.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            VentanaDetalle ventanaDetalle;
            try
            {
                articuloSeleccionado = new Articulo();
                articuloSeleccionado = (Articulo)dgbCatalogo.CurrentRow.DataBoundItem;
                ventanaDetalle = new VentanaDetalle(articuloSeleccionado);
                ventanaDetalle.ShowDialog();
                CargarArticulos();

            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CargarArticulos()
        {
            ControladorArticulo controladorArticulo;
            try
            {
                controladorArticulo = new ControladorArticulo();
                dgbCatalogo.DataSource = controladorArticulo.Listar();
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
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VentanaNuevoModificar ventanaNuevo;
            try
            {
                ventanaNuevo = new VentanaNuevoModificar();
                ventanaNuevo.ShowDialog();
                CargarArticulos();
                CargarMarcas();
                CargarCategorias();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            VentanaNuevoModificar ventanaModificar;
            try
            {
                articuloSeleccionado = new Articulo();
                articuloSeleccionado = (Articulo)dgbCatalogo.CurrentRow.DataBoundItem;
                ventanaModificar = new VentanaNuevoModificar(articuloSeleccionado);
                ventanaModificar.ShowDialog();
                CargarArticulos();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ckbFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFiltros.Checked)
            {
                tbxCodigo.Enabled = true;
                tbxNombre.Enabled = true;
                tbxDescripcion.Enabled = true;
                cbxMarca.Enabled = true;
                cbxCategoria.Enabled = true;
            }
            else
            {
                tbxCodigo.Enabled = false;
                tbxNombre.Enabled = false;
                tbxDescripcion.Enabled = false;
                cbxMarca.Enabled = false;
                cbxCategoria.Enabled = false;
            }
            CargarArticulos();

        }
    }
}
