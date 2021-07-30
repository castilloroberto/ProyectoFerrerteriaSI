using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class DetalleVentas:Conexion
    {
        public Guid CodVenta { get; set; }
        public int CodProd { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public string NomProd { get; set; }


        public string info { 
            
            get {

                return $"{Cantidad} - {NomProd} - sub: {Precio*Cantidad}";
            
            
            
            }
            
            
             }

        public bool Insertar( )
        {
            var db = GetConexion();//database
            db.Open();
            SqlCommand command = new SqlCommand("sp_insertarDetalleVenta", db);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodVenta", CodVenta);
            command.Parameters.AddWithValue("@CodProd", CodProd);
            command.Parameters.AddWithValue("@Cant", Cantidad);
            command.Parameters.AddWithValue("@Precio", Precio);
           

            var row = command.ExecuteNonQuery();
            db.Close();
            return row > 0;



        }
    }
}
