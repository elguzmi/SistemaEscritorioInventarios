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
    public class Login_D
    {
        private Cdconexion conexion = new Cdconexion();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();

        public DataTable Ingreso(login_E obje1) // obtenemos los datos de la otra clase
        {
            SqlCommand comando = new SqlCommand("Logeo"); // procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();

            comando.Parameters.AddWithValue("@Usuario", obje1.Usuario);
            comando.Parameters.AddWithValue("@Clave", obje1.Clave);

            SqlDataAdapter da = new SqlDataAdapter(comando); //recuperamos los datos que devolvio
            DataTable dtable1 = new DataTable();
            da.Fill(dtable1); // los datos on llevados al datatable
            return dtable1; //retornamos lOS DATOS DE SALIDA 
        }
    }
}
