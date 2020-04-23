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
        Marca marcaFiltro;
        Categoria categoriaFiltro;
        Boolean marcaFlagFiltro = false;
        Boolean categoriaFlagFiltro = false;
        string marca = String.Empty;
        String categoria = String.Empty;
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
            cbxMarca.Enabled = false;
            cbxMarca.Text = "Filtrar por Marca...";
            cbxCategoria.Enabled = false;
            cbxCategoria.Text = "Filtrar por Categoria...";
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
                dgbCatalogo.Columns[8].Visible = false;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CargarArticulosFiltrados(String codigo, String nombre, String marca, String categoria)
        {
            ControladorArticulo controladorArticulo;
            String[] listadoArgs = new String[4];
            try
            {
                listadoArgs[0] = codigo;
                listadoArgs[1] = nombre;
                listadoArgs[2] = marca;
                listadoArgs[3] = categoria;
                controladorArticulo = new ControladorArticulo();
                dgbCatalogo.DataSource = controladorArticulo.ListarFiltrado(listadoArgs);
                dgbCatalogo.Columns[8].Visible = false;
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
                tbxCodigo.ForeColor = Color.Black;
                tbxNombre.Enabled = true;
                tbxNombre.ForeColor = Color.Black;
                cbxMarca.Enabled = true;
                cbxMarca.ForeColor = Color.Black;
                cbxCategoria.Enabled = true;
                cbxCategoria.ForeColor = Color.Black;
                marcaFiltro = new Marca();
                categoriaFiltro = new Categoria();
            }
            else
            {
                tbxCodigo.Enabled = false;
                tbxCodigo.ForeColor = Color.FromArgb(64,64,64);
                tbxNombre.Enabled = false;
                tbxNombre.ForeColor = Color.FromArgb(64, 64, 64);
                cbxMarca.Enabled = false;
                cbxMarca.Text = "Filtrar por Marca...";
                cbxMarca.ForeColor = Color.FromArgb(64, 64, 64);
                cbxCategoria.Enabled = false;
                cbxCategoria.Text = "Filtrar por Categoria...";
                cbxCategoria.ForeColor = Color.FromArgb(64, 64, 64);
                marcaFiltro = null;
                categoriaFiltro = null;
                CargarArticulos();
            }
        }

        private void btnEleminar_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            ControladorArticulo controladorArticulo;
            try
            {
                articuloSeleccionado = new Articulo();
                articuloSeleccionado = (Articulo)dgbCatalogo.CurrentRow.DataBoundItem;
                controladorArticulo = new ControladorArticulo();
                controladorArticulo.EliminarLogico(articuloSeleccionado);
                CargarArticulos();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbxCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbxCodigo.Text == "Filtrar por Codigo...")
            {
                tbxCodigo.Text = "";
            }
        }

        private void tbxCodigo_Validating(object sender, CancelEventArgs e)
        {
            if(tbxCodigo.Text.Length == 0)
            {
                tbxCodigo.Text = "Filtrar por Codigo...";
            }
        }

        private void tbxCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            marcaFiltro = (Marca)cbxMarca.SelectedItem;
            categoriaFiltro = (Categoria)cbxCategoria.SelectedItem;

            if (marcaFlagFiltro)
            {
                marca = marcaFiltro.Id.ToString();
            }
            if (categoriaFlagFiltro)
            {
                categoria = categoriaFiltro.Id.ToString();
            }

            CargarArticulosFiltrados(tbxCodigo.Text, tbxNombre.Text, marca, categoria);
        }

        private void tbxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbxNombre.Text == "Filtrar por Nombre...")
            {
                tbxNombre.Text = "";
            }
        }

        private void tbxNombre_Validating(object sender, CancelEventArgs e)
        {
            if (tbxNombre.Text.Length == 0)
            {
                tbxNombre.Text = "Filtrar por Nombre...";
            }

        }

        private void tbxNombre_KeyUp(object sender, KeyEventArgs e)
        {
            marcaFiltro = (Marca)cbxMarca.SelectedItem;
            categoriaFiltro = (Categoria)cbxCategoria.SelectedItem;

            if (marcaFlagFiltro)
            {
                marca = marcaFiltro.Id.ToString();
            }
            if (categoriaFlagFiltro)
            {
                categoria = categoriaFiltro.Id.ToString();
            }

            CargarArticulosFiltrados(tbxCodigo.Text, tbxNombre.Text, marca, categoria);
        }

        private void cbxMarca_Validating(object sender, CancelEventArgs e)
        {
            if (cbxMarca.Text.Length == 0)
            {
                cbxMarca.Text = "Filtrar por Marca...";
                marcaFlagFiltro = false;
                marca = String.Empty;
                CargarArticulosFiltrados(tbxCodigo.Text, tbxNombre.Text, marca, categoria);
            }
        }

        private void cbxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            marcaFlagFiltro = true;
            marcaFiltro = (Marca)cbxMarca.SelectedItem;
            categoriaFiltro = (Categoria)cbxCategoria.SelectedItem;

            if (marcaFlagFiltro)
            {
                marca = marcaFiltro.Id.ToString();
            }
            if (categoriaFlagFiltro)
            {
                categoria = categoriaFiltro.Id.ToString();
            }

            CargarArticulosFiltrados(tbxCodigo.Text, tbxNombre.Text, marca, categoria);
        }

        private void cbxCategoria_Validating(object sender, CancelEventArgs e)
        {

            if (cbxCategoria.Text.Length == 0)
            {
                cbxCategoria.Text = "Filtrar por Categoria...";
                categoriaFlagFiltro = false;
                categoria = String.Empty;
                CargarArticulosFiltrados(tbxCodigo.Text, tbxNombre.Text, marca, categoria);
            }
        }

        private void cbxCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            categoriaFlagFiltro = true;
            marcaFiltro = (Marca)cbxMarca.SelectedItem;
            categoriaFiltro = (Categoria)cbxCategoria.SelectedItem;


            if (marcaFlagFiltro)
            {
                marca = marcaFiltro.Id.ToString();
            }
            if (categoriaFlagFiltro)
            {
                categoria = categoriaFiltro.Id.ToString();
            }

            CargarArticulosFiltrados(tbxCodigo.Text, tbxNombre.Text, marca, categoria);
        }
    }
}
