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

        // propiedades que se insertan en la tabla Productos
        public string Producto { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public int CodCategoria { get; set; }
        public int CodMarca { get; set; }
        public int CodProveedor { get; set; }

        public Productos()
        {
            CodCategoria = 1;
            CodMarca = 1;
            CodProveedor = 1;
        }

        // propiedades para consultas 
        private SqlDataReader reader;

        public DataTable GetProdutos()
        {

            var db = GetConexion();
            db.Open();

            DataTable productos = new DataTable();
            SqlCommand command = new SqlCommand("select * from ProductosView", db);
            reader = command.ExecuteReader();

            productos.Load(reader);
            
            reader.Close();
            db.Close();

            return productos;

        }

        public bool Insertar()
        {

            var db = GetConexion();
            db.Open();
            SqlCommand command = new SqlCommand("sp_insertProducto", db);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Producto", Producto);
            command.Parameters.AddWithValue("@Precio", Precio);
            command.Parameters.AddWithValue("@Stock", Stock);
            command.Parameters.AddWithValue("@CodCat ", CodCategoria);
            command.Parameters.AddWithValue("@CodMarca", CodMarca);
            command.Parameters.AddWithValue("@CodProv", CodProveedor);

            var rows = command.ExecuteNonQuery();

            db.Close();

            return rows > 0;

        }

    }
}
