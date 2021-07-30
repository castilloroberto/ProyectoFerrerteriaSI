using ProyectoFerrerteriaSI.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFerrerteriaSI
{
    public partial class Ventas : UserControl
    {
        Productos productos = new Productos();
        
        Venta Venta = new Venta();

        public Ventas()
        {
            InitializeComponent();
            CargarProductos();
            limpiarventas();
         
        }

        private void limpiarventas()
        {

            Venta = new Venta();
            Venta.CodVenta = Guid.NewGuid();
            Cargarlistview();
            txtcodclien.Clear();
            txtclien.Clear();
            txttelclien.Clear();

        }

        private void CargarProductos()
        {
            
            dgvprod.DataSource = productos.GetProdutos();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DetalleVentas dtv = new DetalleVentas() {
                CodProd = getcell(0),
                Cantidad = int.Parse(txtcantprod.Text),
                Precio = decimal.Parse(txtprecio.Text),
                CodVenta = Venta.CodVenta,
                NomProd=getcell(1)
                
        };
            //llamar a la clase de ventas
            Venta.Detalles.Add(dtv);
            Cargarlistview();
            txtcantprod.Clear();
            txtprecio.Clear();

        }

        private void Cargarlistview()
        {
            lvproducto.DataSource = null;
            lvproducto.DataSource = Venta.Detalles;
            lvproducto.DisplayMember = "info";  //se va a mostrar en lview
        }

        private void dgvprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //para cualquier tipo de datos el dynamic
        private dynamic getcell(int cell)//celda
        {
            var index = dgvprod.CurrentRow.Index;
            return dgvprod.Rows[index].Cells[cell].Value;
        }

        private void dgvprod_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal cell = getcell(2);//esto es como mostrar la columna que le estas asignando
            txtprecio.Text = string.Format("{0}",cell) ;//insertando un valor dentro de esa expresion
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var ind = lvproducto.SelectedIndex;
            Venta.Detalles.RemoveAt(ind);
            Cargarlistview();
        }

        private void btntermventa_Click(object sender, EventArgs e)
        {
            Clientes Cliente = new Clientes()
            {

                CodCliente = txtcodclien.Text,
                NomCliente = txtclien.Text,
                Telefono = txttelclien.Text

            };

            Venta.CodCliente = txtcodclien.Text;
            Venta.NomUsuario = Menu.Usuario.NombreUsuario;
           


            string msg = "";
            var res = Cliente.SaveCliente(); //valor booleano
            if (res == true)
            {
                res = Venta.SaveVenta();

                if (res == true)
                {
                    msg = "Venta insertada correctamente";
                }
                else
                {
                    msg = "No se pudo insertar la venta";
                }
            }

            else
            {
                msg = "No se pudo insertar los datos del cliente";
            }

            MessageBox.Show(msg, "Mensaje del Sistema");

            limpiarventas();
        }
    }
}
