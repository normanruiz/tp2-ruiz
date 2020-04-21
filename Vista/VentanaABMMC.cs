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
    public partial class VentanaABMMC : Form
    {
        String modo;
        public VentanaABMMC(String modoAux)
        {
            InitializeComponent();
            modo = modoAux;
        }

        private void VentanaABMMC_Load(object sender, EventArgs e)
        {
            if(modo == "marca")
            {
                lblTitulo.Text = "Administracion de marcas";
                CargarMarcas();
            }
            else
            {
                lblTitulo.Text = "Administracion de Categorias";
                CargarCategorias(); 
            }
            dgvABMMC.Columns[0].Visible = false;
            dgvABMMC.Select();
        }

        public void CargarMarcas()
        {
            ControladorMarca controladorMarca;
            try
            {
                controladorMarca = new ControladorMarca();
                dgvABMMC.DataSource = controladorMarca.Listar();
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
                dgvABMMC.DataSource = controladorCategoria.Listar();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ControladorMarca controladorMarca;
            ControladorCategoria controladorCategoria;
            Marca marca;
            Categoria categoria;
            try
            {
                if (tbxAgregar.Text.Length == 0)
                {
                        tbxAgregar.BackColor = Color.Red;
                    MessageBox.Show("Complete todos los campos antes de intentar continuar...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (modo == "marca")
                    {
                        marca = new Marca();
                        marca.Descripcion = tbxAgregar.Text;
                        controladorMarca = new ControladorMarca();
                        controladorMarca.AgregarNuevo(marca);
                        CargarMarcas();
                    }
                    else
                    {
                        categoria = new Categoria();
                        categoria.Descripcion = tbxAgregar.Text;
                        controladorCategoria = new ControladorCategoria();
                        controladorCategoria.AgregarNuevo(categoria);
                        CargarCategorias();
                    }
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbxAgregar_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
        }

        private void tbxAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxAgregar.BackColor = System.Drawing.SystemColors.Window;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ControladorMarca controladorMarca;
            ControladorCategoria controladorCategoria;
            Marca marca;
            Categoria categoria;
            try
            {
                if (modo == "marca")
                {
                    marca = new Marca();
                    marca = (Marca)dgvABMMC.CurrentRow.DataBoundItem;
                    controladorMarca = new ControladorMarca();
                    controladorMarca.EliminarFisico(marca);
                    CargarMarcas();
                }
                else
                {
                    categoria = new Categoria();
                    categoria = (Categoria)dgvABMMC.CurrentRow.DataBoundItem;
                    controladorCategoria = new ControladorCategoria();
                    controladorCategoria.EliminarFisico(categoria);
                    CargarCategorias();
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
