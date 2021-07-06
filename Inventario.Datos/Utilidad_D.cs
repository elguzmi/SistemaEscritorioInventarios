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
    public class Utilidad_D
    {
        Cdconexion conexion = new Cdconexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public List<Utilidad_E> Listar()
        {
            //Metodo que carga en una lista el resultado de todos los registros  de la tabla
            List<Utilidad_E> lista = new List<Utilidad_E>();    //lista de objeto docente 
            {
                SqlCommand comando = new SqlCommand("Utilidad");
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
                        Utilidad_E c = new Utilidad_E((string)leer["Codigo"],
                            (string)leer["Nombre"],
                            (int)leer["Cantidad"], (decimal)leer["PrecioCompra"],
                            (decimal)leer["PrecioVenta"], (string)leer["Fecha"].ToString(),
                            (decimal)leer["TotalVenta"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }


        public List<Utilidad_E> Filtrar(string FechaI, string FechaF)
        {
            //Metodo que carga en una lista el resultado de todos los registros  de la tabla
            List<Utilidad_E> lista = new List<Utilidad_E>();    //lista de objeto docente 

                SqlCommand comando = new SqlCommand("UtilidadFecha");
                comando.Connection = conexion.AbrirConexion();
                conexion.AbrirConexion();

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@FechaI",FechaI);
                comando.Parameters.AddWithValue("@FechaF", FechaF);
                leer = comando.ExecuteReader();

                if (leer != null && leer.HasRows)
                {
                    //Al definir los campos de la lista deben ser iguales a los  campos definidos en el
                    //procedimiento almacenado ListarDocente
                    while (leer.Read())
                    {
                        Utilidad_E c = new Utilidad_E((string)leer["Codigo"],
                            (string)leer["Nombre"],
                            (int)leer["Cantidad"], (decimal)leer["PrecioCompra"],
                            (decimal)leer["PrecioVenta"], (string)leer["Fecha"].ToString(),
                            (decimal)leer["TotalVenta"]);
                        lista.Add(c);
                    }
                }
            
            return lista;
        }
    }
}
