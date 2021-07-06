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
    public class AgregarEntrada_N
    {
        AgregarEntrada_D ArtD = new AgregarEntrada_D();
        //Tabla entradas

        //Agregar la entrada
        public string Nombre { get; set; }
        public string Fecha{ get; set; }  //pendiente
        public decimal ValorTotal { get; set; }
        public int Nit{ get; set; }

        //Agrehar a tabla Detalles entradas
        public int Id_Entrada { get; set; }
        public int Id_Ar{ get; set; }
        public double Cantidad { get; set; }
        public decimal PrecioXUni { get; set; }
        public decimal Total { get; set; }




        public DataTable UltimoId()
        {
            return ArtD.listar("UltimoIdEntrada", null);
        }

        public String InsertarEntrada() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<AgregaEntrada_E> lst = new List<AgregaEntrada_E>();
            try
            {

                lst.Add(new AgregaEntrada_E("@dato", 1));
                lst.Add(new AgregaEntrada_E("@Nombre", Nombre));
                lst.Add(new AgregaEntrada_E("@ValorTotal", ValorTotal));
                lst.Add(new AgregaEntrada_E("@Nit", Nit));
                //datos de detalles de entrada
                lst.Add(new AgregaEntrada_E("@Id_Entrada", Id_Entrada));
                lst.Add(new AgregaEntrada_E("@Id_Articulo", Id_Ar));
                lst.Add(new AgregaEntrada_E("@Cantidad", Cantidad));
                lst.Add(new AgregaEntrada_E("@Precio", PrecioXUni));
                lst.Add(new AgregaEntrada_E("@Total", Total));

                lst.Add(new AgregaEntrada_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("InsertarEntrada", lst);
                msj = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }


        public String InsertarDetalles() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<AgregaEntrada_E> lst = new List<AgregaEntrada_E>();
            try
            {
                lst.Add(new AgregaEntrada_E("@dato", 2));
                lst.Add(new AgregaEntrada_E("@Nombre", Nombre));
                lst.Add(new AgregaEntrada_E("@ValorTotal", ValorTotal));
                lst.Add(new AgregaEntrada_E("@Nit", Nit));
                //datos de detalles de entrada
                lst.Add(new AgregaEntrada_E("@Id_Entrada", Id_Entrada));
                lst.Add(new AgregaEntrada_E("@Id_Articulo", Id_Ar));
                lst.Add(new AgregaEntrada_E("@Cantidad", Cantidad));
                lst.Add(new AgregaEntrada_E("@Precio", PrecioXUni));
                lst.Add(new AgregaEntrada_E("@Total", Total));

                lst.Add(new AgregaEntrada_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("InsertarEntrada", lst);
                msj = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public DataTable TraerDetalles(int Id)
        {
            
            List<AgregaEntrada_E> lst = new List<AgregaEntrada_E>();
            try
            {
                lst.Add(new AgregaEntrada_E("@Dato", 1));
                lst.Add(new AgregaEntrada_E("@Id", Id));
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("TraerDetalles", lst);
        }


        public String ChangeState(int Id, int Estado) // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<AgregaEntrada_E> lst = new List<AgregaEntrada_E>();
            try
            {
                lst.Add(new AgregaEntrada_E("@dato", 1));
                lst.Add(new AgregaEntrada_E("@Id", Id));
                lst.Add(new AgregaEntrada_E("@Estado", Estado));
           

                lst.Add(new AgregaEntrada_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("ChangeState", lst);
                msj = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public String UpdateArticles(string Codigo, int Cantidad, int Estado) // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<AgregaEntrada_E> lst = new List<AgregaEntrada_E>();
            try
            {
                lst.Add(new AgregaEntrada_E("@dato", 1));
                lst.Add(new AgregaEntrada_E("@Codigo", Codigo));
                lst.Add(new AgregaEntrada_E("@Cantidad", Cantidad));
                lst.Add(new AgregaEntrada_E("@Estado", Estado));

                lst.Add(new AgregaEntrada_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("UpdateArticles", lst);
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
