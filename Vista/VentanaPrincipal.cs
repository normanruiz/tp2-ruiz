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
            Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = new Articulo();
            {
                //TODO: Obtener datos del dgb del articulo a modificar
            }
            VentanaDetalle ventanaDetalle = new VentanaDetalle(articuloSeleccionado);
            ventanaDetalle.ShowDialog();
            Cargar();
        }

        public void Cargar()
        {
            //TODO: Metodo Cargar()
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VentanaNuevoModificar ventanaNuevo = new VentanaNuevoModificar();
            ventanaNuevo.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = new Articulo();
            {
                //TODO: Obtener datos del dgb del articulo a modificar
            }
            VentanaNuevoModificar ventanaModificar = new VentanaNuevoModificar(articuloSeleccionado);
            ventanaModificar.ShowDialog();
            Cargar();
        }
    }
}
