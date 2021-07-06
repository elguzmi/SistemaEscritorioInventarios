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
    public class ReporteIngresos_N
    {
        ReporteIngresos_D ArtD = new ReporteIngresos_D();
        //Tabla entradas


        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorTotal { get; set; }
        public int Id_Salida { get; set; }




        public String InsertarIngreso() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<ReporteIngresos_E> lst = new List<ReporteIngresos_E>();
            try
            {
                lst.Add(new ReporteIngresos_E("@dato", 1));
                lst.Add(new ReporteIngresos_E("@Descripcion", Descripcion));
                lst.Add(new ReporteIngresos_E("@ValorTotal", ValorTotal));
                lst.Add(new ReporteIngresos_E("@Id_Salida", Id_Salida));

                lst.Add(new ReporteIngresos_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("RepIngresos", lst);
                msj = lst[4].Valor.ToString(); 

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public String ModificarProceso() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<ReporteIngresos_E> lst = new List<ReporteIngresos_E>();
            try
            {
                lst.Add(new ReporteIngresos_E("@dato", 2));
                lst.Add(new ReporteIngresos_E("@Descripcion", ""));
                lst.Add(new ReporteIngresos_E("@ValorTotal", 0));
                lst.Add(new ReporteIngresos_E("@Id_Salida", Id_Salida));

                lst.Add(new ReporteIngresos_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("RepIngresos", lst);
                msj = lst[4].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public DataTable Consulta()
        {
            String msj = "";
            List<ReporteIngresos_E> lst = new List<ReporteIngresos_E>();
            try
            {
                lst.Add(new ReporteIngresos_E("@FechaInicio", FechaInicio));
                lst.Add(new ReporteIngresos_E("@FechaFinal", FechaFinal));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("ConsultaIngresos", lst);
        }
    }
}
