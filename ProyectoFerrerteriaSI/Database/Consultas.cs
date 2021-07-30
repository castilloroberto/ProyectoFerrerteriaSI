using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class Consultas : Conexion
    {
        public DataTable select ( string Sql)
        {
            var db = GetConexion();
            db.Open();

            DataTable res = new DataTable();
            SqlCommand command = new SqlCommand(Sql, db);
            SqlDataReader reader = command.ExecuteReader();

            res.Load(reader);

            reader.Close();
            db.Close();

            return res;


        }


        public bool modificacion ( string Sql)
        {
            var db = GetConexion();
            db.Open();

            SqlCommand command = new SqlCommand(Sql, db);
            var rows = command.ExecuteNonQuery();
            
            db.Close();

            if (rows > 0)
                return true;
            else
                return false;

        }


    }
}
