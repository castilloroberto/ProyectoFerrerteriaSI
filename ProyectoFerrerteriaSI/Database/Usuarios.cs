using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class Usuarios:Conexion
    {

        public string NombreUsuario { get; set; }

        public string Clave { get; set; }
        public string CodEmpleado { get; set; }
        public int IDNivel { get; set; }


        public bool Loggear()
        {
            var db = GetConexion();
            db.Open();


            SqlCommand query = new SqlCommand( "sp_loggear" , db );
            query.CommandType = CommandType.StoredProcedure;
            query.Parameters.AddWithValue("@Nom_Usuario", NombreUsuario);
            query.Parameters.AddWithValue("@Contra_Usuario", Clave);


            DataTable res = new DataTable();
            SqlDataReader reader = query.ExecuteReader();

            res.Load(reader);


            db.Close();


            if (res.Rows.Count > 0)
            {
                CodEmpleado = res.Rows[0].Field<string>("Cod_Empleado");
                IDNivel = res.Rows[0].Field<int>("IDNivel");
                return true; 

            } 
                else
            {

                return false; 
            } 

        }



    }
}
