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
        public VentanaDetalle(Articulo articuloAux)
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            {
                //TODO: Obtener datos del detalle del articulo a modificar
            }
            VentanaNuevoModificar ventanaModificar = new VentanaNuevoModificar(articulo);
            ventanaModificar.ShowDialog();
            // TODO: Agregar metodo para recargar la ventana detalle

        }

        private void VentanaDetalle_Load(object sender, EventArgs e)
        {

        }

    }
}
