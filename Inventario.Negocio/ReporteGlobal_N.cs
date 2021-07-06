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
    public class ReporteGlobal_N
    {
        ReporteGlobal_D ArtD = new ReporteGlobal_D();
        //Tabla entradas


        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
       

        public DataTable ConsultaIngresos()
        {
            
            List<ReporteGlobal_E> lst = new List<ReporteGlobal_E>();
            try
            {
                lst.Add(new ReporteGlobal_E("@Dato",1));
                lst.Add(new ReporteGlobal_E("@FechaInicio", FechaInicio));
                lst.Add(new ReporteGlobal_E("@FechaFinal", FechaFinal));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("ReporteGlobal", lst);
        }

        public DataTable ConsultaEgresos()
        {
            
            List<ReporteGlobal_E> lst = new List<ReporteGlobal_E>();
            try
            {
                lst.Add(new ReporteGlobal_E("@Dato", 2));
                lst.Add(new ReporteGlobal_E("@FechaInicio", FechaInicio));
                lst.Add(new ReporteGlobal_E("@FechaFinal", FechaFinal));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ArtD.listar("ReporteGlobal", lst);
        }
    }
}
