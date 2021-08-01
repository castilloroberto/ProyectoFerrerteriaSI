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
    public partial class HistorialVentas : Form
    {
        Venta venta = new Venta();
        public HistorialVentas()
        {
            InitializeComponent();
            var fechas = venta.GetMinMaxFechas();
            dtp_inicio.Value = fechas.Field<DateTime>("min");
            dtp_fin.Value = fechas.Field<DateTime>("max");
        }

        private void HistorialVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'FerreteriaDBDataSet.sp_verVentasPorFecha' Puede moverla o quitarla según sea necesario.
            this.sp_verVentasPorFechaTableAdapter.Fill(this.FerreteriaDBDataSet.sp_verVentasPorFecha,dtp_inicio.Value,dtp_fin.Value);
            this.reportViewer1.RefreshReport();

          
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {

            this.sp_verVentasPorFechaTableAdapter.Fill(this.FerreteriaDBDataSet.sp_verVentasPorFecha,dtp_inicio.Value,dtp_fin.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
