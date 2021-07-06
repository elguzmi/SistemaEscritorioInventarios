using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Entidades;    //Se agrego la referencia para poder utlizarla
using System.Configuration;
using System.Data.SqlClient;   // librerias para la conexion a la base de datos
using System.Data;

namespace Inventario.Datos
{
    public class ReporteUtilidad_D
    {
        private Cdconexion conexion = new Cdconexion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();


        public DataTable Datos(string FechaI, string FechaF) // obtenemos los datos de la otra clase
        {
            DataTable Tabla = new DataTable();
            SqlCommand comando = new SqlCommand("ReporteUtilidad");
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaI", FechaI);
            comando.Parameters.AddWithValue("@FechaF", FechaF);
            SqlDataAdapter llenar = new SqlDataAdapter();
            llenar.SelectCommand = comando;
            llenar.Fill(Tabla);


            return Tabla;
        }
       
    }
}
