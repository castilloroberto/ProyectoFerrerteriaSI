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

        public int CodVenta { get; set; }
        public string CodCliente { get; set; }
        public string NomUsuario { get; set; }

        private bool Insertar()
        {
            var db = GetConexion();//database
            db.Open();
            SqlCommand command = new SqlCommand("", db);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodVenta", CodVenta);
            command.Parameters.AddWithValue("@CodCliente", CodCliente);
            command.Parameters.AddWithValue("@NomUsuario", NomUsuario);
            db.Close();


            var row = command.ExecuteNonQuery();
            return row > 0;



        }

    }
}
