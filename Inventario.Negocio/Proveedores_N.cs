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
    public class Proveedores_N
    {
        Categorias_D CatD = new Categorias_D();
        
        public int m_Id { get; set; }
        public string m_RazonSocial { get; set; }
        public  int m_Nit { get; set; }
        public string m_Observacion { get; set; }
        public int m_Telefono { get; set; }
        public string m_Direccion { get; set; }
        public string m_Correo { get; set; }

        public DataTable Listar()
        {
            return CatD.listar("listarProveedores", null);
        }

        public DataTable ListarProveedoresXRazon()
        {
            List<Categorias_E> lst = new List<Categorias_E>();
            try
            {
                lst.Add(new Categorias_E("@dato", 2));
                lst.Add(new Categorias_E("@Codigo", m_Nit));
                lst.Add(new Categorias_E("@Nombre", m_RazonSocial));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CatD.listar("FiltroProveedores", lst);
        }

        public DataTable ListarProveedoresXNit()
        {
            List<Categorias_E> lst = new List<Categorias_E>();
            try
            {
                lst.Add(new Categorias_E("@dato", 1));
                lst.Add(new Categorias_E("@Codigo", m_Nit));
                lst.Add(new Categorias_E("@Nombre", m_RazonSocial));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CatD.listar("FiltroProveedores", lst);
        }

        public String InsertarCategoria() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<Categorias_E> lst = new List<Categorias_E>();
            try
            {

                lst.Add(new Categorias_E("@dato", 1));
                lst.Add(new Categorias_E("@Id", 0));
                lst.Add(new Categorias_E("@Nit", m_Nit));
                lst.Add(new Categorias_E("@RazonSocial", m_RazonSocial));
                lst.Add(new Categorias_E("@Telefono", m_Telefono));
                lst.Add(new Categorias_E("@Direccion", m_Direccion));
                lst.Add(new Categorias_E("@Correo", m_Correo));
                lst.Add(new Categorias_E("@Observacion", m_Observacion));

                // pasar parametros de salida 

                lst.Add(new Categorias_E("@mensaje", SqlDbType.VarChar, 100));
                CatD.Insertar("AdminProveedores", lst);
                msj = lst[8].Valor.ToString();

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
                lst.Add(new Categorias_E("@Nit", m_Nit));
                lst.Add(new Categorias_E("@RazonSocial", m_RazonSocial));
                lst.Add(new Categorias_E("@Telefono", m_Telefono));
                lst.Add(new Categorias_E("@Direccion", m_Direccion));
                lst.Add(new Categorias_E("@Correo", m_Correo));
                lst.Add(new Categorias_E("@Observacion", m_Observacion));

                // pasar parametros de salida 

                lst.Add(new Categorias_E("@mensaje", SqlDbType.VarChar, 100));
                CatD.Insertar("AdminProveedores", lst);
                msj = lst[8].Valor.ToString();

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
                lst.Add(new Categorias_E("@Nit", 0));
                lst.Add(new Categorias_E("@RazonSocial", ""));
                lst.Add(new Categorias_E("@Telefono", 0));
                lst.Add(new Categorias_E("@Direccion", ""));
                lst.Add(new Categorias_E("@Correo", ""));
                lst.Add(new Categorias_E("@Observacion", ""));

                // pasar parametros de salida 

                lst.Add(new Categorias_E("@mensaje", SqlDbType.VarChar, 100));
                CatD.Insertar("AdminProveedores", lst);
                msj = lst[8].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }
    }
}
