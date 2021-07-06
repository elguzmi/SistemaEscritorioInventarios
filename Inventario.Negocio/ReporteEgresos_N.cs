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
    public class ReporteEgresos_N
    {
        ReporteEgresos_D ArtD = new ReporteEgresos_D();
        //Tabla entradas


        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorTotal { get; set; }
        public int Id_Entrada { get; set; }


        public String InsertarEgreso() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<ReporteEgresos_E> lst = new List<ReporteEgresos_E>();
            try
            {
                lst.Add(new ReporteEgresos_E("@dato", 1));
                lst.Add(new ReporteEgresos_E("@Descripcion", Descripcion));
                lst.Add(new ReporteEgresos_E("@ValorTotal", ValorTotal));
                lst.Add(new ReporteEgresos_E("@Id_Entrada", Id_Entrada));

                lst.Add(new ReporteEgresos_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("RepEgresos", lst);
                msj = lst[4].Valor.ToString();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento de salida de la base de datos
        }

        public String modiificarProceso() // nos va a devolver una cadena de texto
        {
            String msj = "";
            List<ReporteEgresos_E> lst = new List<ReporteEgresos_E>();
            try
            {
                lst.Add(new ReporteEgresos_E("@dato", 2));
                lst.Add(new ReporteEgresos_E("@Descripcion", ""));
                lst.Add(new ReporteEgresos_E("@ValorTotal", 0));
                lst.Add(new ReporteEgresos_E("@Id_Entrada", Id_Entrada));

                lst.Add(new ReporteEgresos_E("@mensaje", SqlDbType.VarChar, 100));
                ArtD.Insertar("RepEgresos", lst);
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
            List<ReporteEgresos_E> lst = new List<ReporteEgresos_E>();
            try
            {
                lst.Add(new ReporteEgresos_E("@FechaInicio", FechaInicio));
                lst.Add(new ReporteEgresos_E("@FechaFinal", FechaFinal));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("ConsultaEgresos", lst);
        }
    }
}
