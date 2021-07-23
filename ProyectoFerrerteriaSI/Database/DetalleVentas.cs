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
        public float Precio { get; set; }
        private bool Insertar( )
        {
            var db = GetConexion();//database
            db.Open();
            SqlCommand command = new SqlCommand("", db);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodVenta", CodVenta);
            command.Parameters.AddWithValue("@CodProd", CodProd);
            command.Parameters.AddWithValue("@Cant", Cantidad);
            command.Parameters.AddWithValue("@Precio", Precio);
            db.Close();

            var row = command.ExecuteNonQuery();
            return row > 0;



        }
    }
}
