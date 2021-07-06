using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Inventario.Datos;
using Inventario.Entidades;

namespace Inventario.Negocio
{
    public class Categorias_N
    {
        Categorias_D CatD = new Categorias_D();
        
        public int m_Id { get; set; }
        public string m_Nombre { get; set; }
        public  string m_Descripcion { get; set; }

        public DataTable Listar()
        {
            return CatD.listar("listarCategorias", null);
        }

        public String InsertarCategoria() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<Categorias_E> lst = new List<Categorias_E>();
            try
            {

                lst.Add(new Categorias_E("@dato", 1));
                lst.Add(new Categorias_E("@Id", 0));
                lst.Add(new Categorias_E("@Nombre", m_Nombre));
                lst.Add(new Categorias_E("@Descripcion", m_Descripcion));

                // pasar parametros de salida 

                lst.Add(new Categorias_E("@mensaje", SqlDbType.VarChar, 100));
                CatD.Insertar("AdminCategorias", lst);
                msj = lst[4].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public String EditarCategoria() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<Categorias_E> lst = new List<Categorias_E>();
            try
            {

                lst.Add(new Categorias_E("@dato", 2));
                lst.Add(new Categorias_E("@Id", m_Id));
                lst.Add(new Categorias_E("@Nombre", m_Nombre));
                lst.Add(new Categorias_E("@Descripcion", m_Descripcion));

                // pasar parametros de salida 

                lst.Add(new Categorias_E("@mensaje", SqlDbType.VarChar, 100));
                CatD.Insertar("AdminCategorias", lst);
                msj = lst[4].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }


        public String EliminarCategoria() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<Categorias_E> lst = new List<Categorias_E>();
            try
            {

                lst.Add(new Categorias_E("@dato", 3));
                lst.Add(new Categorias_E("@Id", m_Id));
                lst.Add(new Categorias_E("@Nombre", ""));
                lst.Add(new Categorias_E("@Descripcion", ""));

                // pasar parametros de salida 

                lst.Add(new Categorias_E("@mensaje", SqlDbType.VarChar, 100));
                CatD.Insertar("AdminCategorias", lst);
                msj = lst[4].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }
    }
}
