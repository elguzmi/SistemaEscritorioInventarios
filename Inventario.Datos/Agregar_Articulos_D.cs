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
    public class Agregar_Articulos_D
    {
        Cdconexion conexion = new Cdconexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public List<Agregar_Articulos_E> Listar()
        {
            //Metodo que carga en una lista el resultado de todos los registros  de la tabla
            List<Agregar_Articulos_E> lista = new List<Agregar_Articulos_E>();    //lista de objeto docente 
            {
                SqlCommand comando = new SqlCommand("ListarArti");
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
                        Agregar_Articulos_E c = new Agregar_Articulos_E((int)leer["Id"],
                            (string)leer["Codigo"], (string)leer["Nombre"], (string)leer["Descripcion"],
                            leer["PrecioC"].ToString(), (string)leer["PrecioV"].ToString());
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }
    }
}
