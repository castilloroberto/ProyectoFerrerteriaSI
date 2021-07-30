using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class Venta: Conexion
    {

        public Guid CodVenta { get; set; }
        public string CodCliente { get; set; }
        public string NomUsuario { get; set; }

        public int CodFact { get; set; }
        public DateTime fecha { get; set; }

        public List<DetalleVentas> Detalles { get; set; }

        public Venta() {

            Detalles = new List<DetalleVentas>();
        
        
        
        }

        public bool SaveVenta()
        {
           
           var res = Insertar();
            if (res==true)
            {
                foreach (DetalleVentas dv in Detalles ) {

                    res = dv.Insertar();
                   
                    
                  
                
                } //para recorrer los detalles
            }

            return res;
        }

        private bool Insertar()
        {
            var db = GetConexion();//database
            db.Open();
            SqlCommand command = new SqlCommand("sp_insertVenta", db);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodVenta", CodVenta);
            command.Parameters.AddWithValue("@CodCliente", CodCliente);
            command.Parameters.AddWithValue("@NomUsuario", NomUsuario);
           


            var row = command.ExecuteNonQuery();
            db.Close();
            return row > 0;



        }

    }
}
