using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Entidades;
using Inventario.Datos;
using System.Data;


namespace Inventario.Negocio
{
    public class Articulo_N
    {
        public int Id_Articulo { get; set; }
        public string codigo {get; set;}
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int cantidad { get; set; }

        public double PrecioCosto { get; set;}
        public double PrecioVenta { get; set;}
        public int stock_Ideal { get; set; }
        public int estado { get; set; }
        public int Id_Categoria { get; set; }


        
        Articulos_D ArtD = new Articulos_D();
        public DataTable ListarCategorias()
        {
            return ArtD.listar("ListarCategorias", null);
        }

        public DataTable UltimoId()
        {
            return ArtD.listar("UltimoIdArticulo", null);
        }

        //Listado Completo 
        public DataTable ListarProductos()
        {
            List<Articulos_E> lst = new List<Articulos_E>();
            try
            {
                lst.Add(new Articulos_E("@dato", 3));
                lst.Add(new Articulos_E("@Codigo", ""));
                lst.Add(new Articulos_E("@Nombre", ""));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("FiltroProductos", lst);
        }

       
        //Filtro por codigo
        public DataTable ListarProductosXCodigo()
        {

            List<Articulos_E> lst = new List<Articulos_E>();
            try
            {
                lst.Add(new Articulos_E("@dato", 1));
                lst.Add(new Articulos_E("@Codigo", codigo));
                lst.Add(new Articulos_E("@Nombre", Nombre));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("FiltroProductos", lst);
        }


        
        //Filtro por Nombre
        public DataTable ListarProductosXNombre()
        {
            List<Articulos_E> lst = new List<Articulos_E>();
            try
            {
                lst.Add(new Articulos_E("@dato", 2));
                lst.Add(new Articulos_E("@Codigo", codigo));
                lst.Add(new Articulos_E("@Nombre", Nombre));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("FiltroProductos", lst);
        }

        public DataTable TraerXId()
        {
            List<Articulos_E> lst = new List<Articulos_E>();
            try
            {
                lst.Add(new Articulos_E("@Id", Id_Articulo));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("TraerXId", lst);
        }

        //Metodo para insertar ARTICULO
        public String InsertarArticulo() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<Articulos_E> lst = new List<Articulos_E>();
            try
            {

                lst.Add(new Articulos_E("@dato", 1));
                lst.Add(new Articulos_E("@Id", 0));
                lst.Add(new Articulos_E("@Codigo", codigo));
                lst.Add(new Articulos_E("@Nombre", Nombre));
                lst.Add(new Articulos_E("@Descripcion", Descripcion));
                lst.Add(new Articulos_E("@Cantidad", cantidad));
                lst.Add(new Articulos_E("@StockIdeal", stock_Ideal));
                lst.Add(new Articulos_E("@PrecioV", PrecioVenta));
                lst.Add(new Articulos_E("@PrecioC", PrecioCosto));
                lst.Add(new Articulos_E("@Estado", estado));
                lst.Add(new Articulos_E("@IdCategoria", Id_Categoria));
                // pasar parametros de salida 

                lst.Add(new Articulos_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("AdminArticulos", lst);
                msj = lst[11].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public String EditarArticulo() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<Articulos_E> lst = new List<Articulos_E>();
            try
            {

                lst.Add(new Articulos_E("@dato", 2));
                lst.Add(new Articulos_E("@Id", Id_Articulo));
                lst.Add(new Articulos_E("@Codigo", codigo));
                lst.Add(new Articulos_E("@Nombre", Nombre));
                lst.Add(new Articulos_E("@Descripcion", Descripcion));
                lst.Add(new Articulos_E("@Cantidad", cantidad));
                lst.Add(new Articulos_E("@StockIdeal", stock_Ideal));
                lst.Add(new Articulos_E("@PrecioV", PrecioVenta));
                lst.Add(new Articulos_E("@PrecioC", PrecioCosto));
                lst.Add(new Articulos_E("@Estado", estado));
                lst.Add(new Articulos_E("@IdCategoria", Id_Categoria));
                // pasar parametros de salida 

                lst.Add(new Articulos_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("AdminArticulos", lst);
                msj = lst[11].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public String EliminarArticulo() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<Articulos_E> lst = new List<Articulos_E>();
            try
            {

                lst.Add(new Articulos_E("@dato", 3));
                lst.Add(new Articulos_E("@Id", Id_Articulo));
                lst.Add(new Articulos_E("@Codigo", ""));
                lst.Add(new Articulos_E("@Nombre", ""));
                lst.Add(new Articulos_E("@Descripcion", ""));
                lst.Add(new Articulos_E("@Cantidad", 0));
                lst.Add(new Articulos_E("@StockIdeal", 0));
                lst.Add(new Articulos_E("@PrecioV", 0));
                lst.Add(new Articulos_E("@PrecioC", 0));
                lst.Add(new Articulos_E("@Estado", 0));
                lst.Add(new Articulos_E("@IdCategoria", 0));
                // pasar parametros de salida 

                lst.Add(new Articulos_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("AdminArticulos", lst);
                msj = lst[11].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }




        //------------------------------------------------Modulo de stock


        
        //Filtro por Nombre
        public DataTable FiltrarArticulos(int Dato)
        {
            List<Articulos_E> lst = new List<Articulos_E>();
            if(Dato == 1)
            {
                try
                {
                    lst.Add(new Articulos_E("@dato", 1));
                    lst.Add(new Articulos_E("@Codigo", codigo));
                    lst.Add(new Articulos_E("@Nombre", ""));
                    lst.Add(new Articulos_E("@Cantidad", 0));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }else if (Dato == 2)
            {
                try
                {
                    lst.Add(new Articulos_E("@dato", 2));
                    lst.Add(new Articulos_E("@Codigo", ""));
                    lst.Add(new Articulos_E("@Nombre", Nombre));
                    lst.Add(new Articulos_E("@Cantidad", 0));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            else if (Dato == 3)
            {
                try
                {
                    lst.Add(new Articulos_E("@dato", 3));
                    lst.Add(new Articulos_E("@Codigo", ""));
                    lst.Add(new Articulos_E("@Nombre", ""));
                    lst.Add(new Articulos_E("@Cantidad", cantidad));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return ArtD.listar("FiltrarArticulos", lst);
        }
    }
}
