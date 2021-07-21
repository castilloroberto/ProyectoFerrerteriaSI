using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class Conexion
    {

        private string cadena => @"Server=tcp:su-mueble-server.database.windows.net,1433;Initial Catalog=FerreteriaDB;Persist Security Info=False;User ID=adminSuMueble;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection GetConexion => new SqlConnection(cadena); 

    }
}
