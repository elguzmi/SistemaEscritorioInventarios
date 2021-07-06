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
    public class AgregarSalida_N
    {
        AgregarSalida_D ArtD = new AgregarSalida_D();
        //Tabla entradas
        public string NombreSalida { get; set; }
        public string Fecha{ get; set; }
        public decimal ValorTotal { get; set; }

        //Agrehar a tabla Detalles entradas
        public int Id_Salida { get; set; }
        public int Id_Ar{ get; set; }
        public double Cantidad { get; set; }
        //public decimal PrecioXUni { get; set; }
        public decimal Total { get; set; }




        public DataTable UltimoId()
        {
            return ArtD.listar("UltimoIdSalida", null);
        }

        public String InsertarSalida() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<AgregarSalida_E> lst = new List<AgregarSalida_E>();
            try
            {
                lst.Add(new AgregarSalida_E("@dato", 1));
                lst.Add(new AgregarSalida_E("@Id_Articulo", 0));
                lst.Add(new AgregarSalida_E("@Id_Salidas", 0));
                lst.Add(new AgregarSalida_E("@Cantidad", 0));
                lst.Add(new AgregarSalida_E("@ValorT", 0));
                lst.Add(new AgregarSalida_E("@NombreSalida", NombreSalida));
                lst.Add(new AgregarSalida_E("@PrecioTotal", ValorTotal));


                lst.Add(new AgregarSalida_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("InsertarSalida", lst);
                msj = lst[7].Valor.ToString();

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
            List<AgregarSalida_E> lst = new List<AgregarSalida_E>();
            try
            {
                lst.Add(new AgregarSalida_E("@dato", 2));
                lst.Add(new AgregarSalida_E("@Id_Articulo", Id_Ar));
                lst.Add(new AgregarSalida_E("@Id_Salidas", Id_Salida));
                lst.Add(new AgregarSalida_E("@Cantidad", Cantidad));
                lst.Add(new AgregarSalida_E("@ValorT", Total));
                lst.Add(new AgregarSalida_E("@NombreSalida", ""));
                lst.Add(new AgregarSalida_E("@PrecioTotal", 0));


                lst.Add(new AgregarSalida_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("InsertarSalida", lst);
                msj = lst[7].Valor.ToString(); 

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public DataTable TraerDetalles(int Id)
        {
            String msj = "";
            List<AgregarSalida_E> lst = new List<AgregarSalida_E>();
            try
            {
                lst.Add(new AgregarSalida_E("@Dato", 2));
                lst.Add(new AgregarSalida_E("@Id", Id));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("TraerDetalles", lst);
        }

        public DataTable Verificacion(int Id)
        {
            String msj = "";
            List<AgregarSalida_E> lst = new List<AgregarSalida_E>();
            try
            {
                lst.Add(new AgregarSalida_E("@Dato", 3));
                lst.Add(new AgregarSalida_E("@Id", Id));

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
            List<AgregarSalida_E> lst = new List<AgregarSalida_E>();
            try
            {
                lst.Add(new AgregarSalida_E("@dato", 2));
                lst.Add(new AgregarSalida_E("@Id", Id));
                lst.Add(new AgregarSalida_E("@Estado", Estado));


                lst.Add(new AgregarSalida_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("ChangeState", lst);
                msj = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public String UpdateArticles(string Codigo,int Cantidad,int Estado) // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<AgregarSalida_E> lst = new List<AgregarSalida_E>();
            try
            {
                lst.Add(new AgregarSalida_E("@dato", 2));
                lst.Add(new AgregarSalida_E("@Codigo", Codigo));
                lst.Add(new AgregarSalida_E("@Cantidad", Cantidad));
                lst.Add(new AgregarSalida_E("@Estado", Estado));

                lst.Add(new AgregarSalida_E("@mensaje", SqlDbType.VarChar, 100));
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
