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
        private bool Insertar(int CodVenta, int CodProd, int Cant, float Precio )
        {
            var db = GetConexion();//database
            SqlCommand command = new SqlCommand("", db);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodVenta", CodVenta);
            command.Parameters.AddWithValue("@CodProd", CodProd);
            command.Parameters.AddWithValue("@Cant", Cant);
            command.Parameters.AddWithValue("@Precio", Precio);


            var row = command.ExecuteNonQuery();
            return row > 0;



        }
    }
}
