using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Inventario.Datos
{
    public class ListarSalidas_D
    {
        Cdconexion conexion = new Cdconexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public List<ListarSalidas_E> Listar()
        {
            //Metodo que carga en una lista el resultado de todos los registros  de la tabla
            List<ListarSalidas_E> lista = new List<ListarSalidas_E>();    //lista de objeto docente 
            {
                SqlCommand comando = new SqlCommand("ListarSalidas");
                comando.Connection = conexion.AbrirConexion();
                conexion.AbrirConexion();

                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                
                if (leer != null && leer.HasRows)
                {
                    //Al definir los campos de la lista deben ser iguales a los  campos definidos en el
                    //procedimiento almacenado ListarDocente
                    while (leer.Read())
                    {
                        ListarSalidas_E c = new ListarSalidas_E((int)leer["Id"],
                            leer["fecha"].ToString(), (string)leer["Nombre"], leer["VTotal"].ToString(),
                            leer["Estado"].ToString());
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }
    }
}
