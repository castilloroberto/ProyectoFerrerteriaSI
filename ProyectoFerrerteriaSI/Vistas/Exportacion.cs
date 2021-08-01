using ClosedXML.Excel;
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

namespace ProyectoFerrerteriaSI.Vistas
{
    public partial class Exportacion : UserControl
    {
        Consultas consulta = new Consultas();
        List<Parametro> tablas;
        DataTable productos;
        DataTable clientes;
        DataTable ventas;
        DataTable empleados;
        Parametro ventaParametro;
        public Exportacion()
        {
            InitializeComponent();
            CargarDatos();
            CargarDataGrid(productos);
            ventaParametro = new Parametro()
            {
                Nombre = "Ventas",
                Valor = ventas
            };

            tablas = new List<Parametro>()
            {
                new Parametro()
                {
                    Nombre ="Inventario",
                    Valor = productos
                },
                new Parametro()
                {
                    Nombre ="Clientes",
                    Valor = clientes
                },
                
                 new Parametro()
                {
                    Nombre ="Empleados",
                    Valor = empleados
                }
                // 
            };
            tablas.Add(ventaParametro);

        }
        private void CargarDatos()
        {
            productos = consulta.select("select * from ProductosView");
            clientes = consulta.select("select * from clientes");

            CargarVentas();
            
            empleados = consulta.select("select * from empleadosView");

        }

        private void CargarVentas()
        {

            ventas = consulta.proc(
                "sp_ventasPorFecha",
                new List<Parametro>
                {
                    new Parametro { Nombre = "@fechaInicio", Valor = dtp_inicio.Value },
                    new Parametro { Nombre = "@fechaFin", Valor = dtp_fin.Value }
                }
            );
           
        }

        private void CargarDataGrid(DataTable tabla)
        {
            dgv_datos.DataSource = null;
            dgv_datos.DataSource = tabla;
        }
        private void ToggleDatePickers()
        {
            if (cb_tabla.SelectedIndex == 0)
            {
                dtp_fin.Visible = true;
                dtp_inicio.Visible = true;

            }
            else
            {
                dtp_fin.Visible = false;
                dtp_inicio.Visible = false;

            }
        }
        private void cb_tabla_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
            Ventas     0
            Inventario 1
            Clientes   2
            Empleados  3
             */
            ToggleDatePickers();

            CargarDataGrid( tablas.Find( item => item.Nombre == cb_tabla.Text).Valor );

           

        }

        private void dtp_inicio_ValueChanged(object sender, EventArgs e)
        {
            CargarVentas();
            CargarDataGrid(ventas);
            updateParametros();
        }
        private void updateParametros()
        {
            tablas.Remove(ventaParametro);
            ventaParametro.Valor = ventas;
            tablas.Add(ventaParametro);
        }

        private void dtp_fin_ValueChanged(object sender, EventArgs e)
        {
            CargarVentas();
            CargarDataGrid(ventas);
            updateParametros();

        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog() 
            {
                Filter = "Excel Workbook|*.xlsx"
            };

            if ( fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XLWorkbook workbook = new XLWorkbook();
                    workbook.Worksheets.Add( tablas.Find( item => item.Nombre == cb_tabla.Text ).Valor , cb_tabla.Text);
                    workbook.SaveAs(fileDialog.FileName);
                    MessageBox.Show("Archivo guardado con exito","Exportar archivo de Excel ",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Ha habido un problema al intentar guardar el archivo","Exportar archivo de Excel ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                }
            }

        }
    }
}
