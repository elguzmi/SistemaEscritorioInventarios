using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventario.Datos
{
    public class Cdconexion
    {
        string cadena = "Server=GAMINGUZMI\\SERVERSANTI;Database=Kardex;Integrated Security=true";
        public SqlConnection Conexion = new SqlConnection();

        public Cdconexion()
        {
            Conexion.ConnectionString = cadena;
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
