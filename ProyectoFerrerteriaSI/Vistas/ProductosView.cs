using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFerrerteriaSI.Database;

namespace ProyectoFerrerteriaSI.Vistas
{
    public partial class ProductosView : Form
    {
        Productos productos = new Productos();
        DataTable listaProdutos;
        public ProductosView()
        {
            InitializeComponent();
            listaProdutos = productos.GetProdutos();
            cargarProductos();
        }
        private void cargarProductos()
        {
            dgv_productos.DataSource = listaProdutos;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //listaProdutos
        }
    }
}
