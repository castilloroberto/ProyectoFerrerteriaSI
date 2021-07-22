using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class Productos : Conexion
    {

        private SqlDataReader reader;

        public DataTable GetProdutos()
        {

            var db = GetConexion();
            db.Open();

            DataTable productos = new DataTable();
            SqlCommand command = new SqlCommand("select * from productos",db);
            reader = command.ExecuteReader();

            productos.Load(reader);
            
            reader.Close();
            db.Close();

            return productos;

            

        }

    }
}
