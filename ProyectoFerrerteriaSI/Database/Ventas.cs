using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class Ventas: Conexion
    {
        private bool Insertar( int CodVenta, int CodCliente, String NomUsu)
        {
            var db = GetConexion();//database
            SqlCommand command = new SqlCommand("", db);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodVenta", CodVenta);
            command.Parameters.AddWithValue("@CodCliente", CodCliente);
            command.Parameters.AddWithValue("@NomUsuario", NomUsu);
          

            var row = command.ExecuteNonQuery();
            return row > 0;



        }

    }
}
