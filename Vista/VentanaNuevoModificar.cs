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
        public VentanaNuevoModificar()
        {
            InitializeComponent();
            MessageBox.Show("Area en construccion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public VentanaNuevoModificar(Articulo articuloAux)
        {
            InitializeComponent();
            //TODO: Manipular los datos obtenidos en el constructor.
        }

        private void VentanaNuevoModificar_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
