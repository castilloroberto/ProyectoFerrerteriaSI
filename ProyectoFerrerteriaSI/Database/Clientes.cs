using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class Clientes: Conexion
    {
        private bool Insertar(String Prod, float precio, int stock, int CodCat, int CodMarca, int CodProv)
        {
            var db = GetConexion();//database
            SqlCommand command = new SqlCommand("" ,db );
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Producto",Prod);
            command.Parameters.AddWithValue("@Precio",precio);
            command.Parameters.AddWithValue("@Stock",stock);
            command.Parameters.AddWithValue("@CodCat",CodCat);
            command.Parameters.AddWithValue("@CodMarca",CodMarca);
            command.Parameters.AddWithValue("@CodProv",CodProv);

           var row=command.ExecuteNonQuery();
            return row > 0;



        }


    }
}
