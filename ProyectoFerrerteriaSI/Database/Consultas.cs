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

        public DataTable proc(string procName,List<Parametro> parametros)
        {
            var db = GetConexion();
            db.Open();
            SqlCommand command = new SqlCommand(procName, db);
            command.CommandType = CommandType.StoredProcedure;

            foreach (Parametro param in parametros)
            {
                command.Parameters.AddWithValue(param.Nombre, param.Valor);

            }

            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            db.Close();

            return dataTable;


        }
    }
}
