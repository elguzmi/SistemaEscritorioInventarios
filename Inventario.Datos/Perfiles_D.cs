using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Inventario.Entidades;

namespace Inventario.Datos
{
    public class Perfiles_D
    {
        private Cdconexion conexion = new Cdconexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public Perfiles_E TraerPorId(int Id)
        {
            //Metodo que carga en un objeto el resultado del registro filtrado  por ID de la tabla
            Perfiles_E perfiles = new Perfiles_E();

            {
                SqlCommand comando = new SqlCommand("TraerUser");
                comando.Connection = conexion.AbrirConexion();
                conexion.AbrirConexion(); 

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", Id);
                leer = comando.ExecuteReader();
                if (leer != null && leer.HasRows)
                {
                    leer.Read();
                    perfiles = new Perfiles_E((int)leer["Id"],
                        (string)leer["User"], (string)leer["Clave"], (string)leer["Nombre"],
                            (string)leer["Correo"], (string)leer["Cargo"]
                           );
                }
            }
            return perfiles;
        }



        public int Insertar(Perfiles_E perfiles)
        {
            // Metodo que permite enviar los datos del Insert a la BD
            int n = -1;
            {
                SqlCommand comando = new SqlCommand("PerfilesA");
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Dato", 1);
                comando.Parameters.AddWithValue("@Id", 0);
                comando.Parameters.AddWithValue("@User", perfiles.User);
                comando.Parameters.AddWithValue("@Nombre", perfiles.Nombre);
                comando.Parameters.AddWithValue("@Clave", perfiles.Password);
                comando.Parameters.AddWithValue("@Correo", perfiles.Correo);
                comando.Parameters.AddWithValue("@Cargo", perfiles.Cargo);
                n = comando.ExecuteNonQuery();
            }
            return n;
        }

        public int Actualizar(Perfiles_E perfiles)
        {
            int n = -1;
            {
                SqlCommand comando = new SqlCommand("PerfilesA");
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Dato", 2);
                comando.Parameters.AddWithValue("@Id", perfiles.Id);
                comando.Parameters.AddWithValue("@User", perfiles.User);
                comando.Parameters.AddWithValue("@Nombre", perfiles.Nombre);
                comando.Parameters.AddWithValue("@Clave", perfiles.Password);
                comando.Parameters.AddWithValue("@Correo", perfiles.Correo);
                comando.Parameters.AddWithValue("@Cargo", perfiles.Cargo);
                n = comando.ExecuteNonQuery();
            }
            return n;
        }

        public int Eliminar(int Cedula)
        {
            int n = -1;
            {
                SqlCommand comando = new SqlCommand("PerfilesA");
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Dato", 1);
                comando.Parameters.AddWithValue("@Id", Cedula);
                n = comando.ExecuteNonQuery();
            }
            return n;
        }


        public List<Perfiles_E> Listar()
        {
            //Metodo que carga en una lista el resultado de todos los registros  de la tabla
            List<Perfiles_E> lista = new List<Perfiles_E>();
            {
                SqlCommand comando = new SqlCommand("ListarUsuarios");
                comando.Connection = conexion.AbrirConexion();
                conexion.AbrirConexion();

                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                if (leer != null && leer.HasRows)
                {
                    //Al definir los campos de la lista deben ser iguales a los  campos definidos en el
                    
                    while (leer.Read())
                    {
                        Perfiles_E c = new Perfiles_E((int)leer["Id"],
                        (string)leer["User"], (string)leer["Clave"], (string)leer["Nombre"],
                            (string)leer["Correo"], (string)leer["Cargo"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }
    }
}
