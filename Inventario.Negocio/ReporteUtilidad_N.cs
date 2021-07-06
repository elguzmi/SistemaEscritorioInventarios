using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Entidades;
using Inventario.Datos;
using System.Data;
using System.Globalization;

namespace Inventario.Negocio
{
    public class ReporteUtilidad_N
    {

        public List<ReporteUtilidad_E> Listar(string FechaI,string FechaF)
        {
            List<ReporteUtilidad_E> Agregar = new List<ReporteUtilidad_E>();
            ReporteUtilidad_D ReporteD = new ReporteUtilidad_D();
            foreach (DataRow lista in ReporteD.Datos(FechaI,FechaF).Rows)
            {
                Agregar.Add(new ReporteUtilidad_E
                {
                    Fecha = lista[0].ToString(),
                    Codigo = lista[1].ToString(),
                    Producto = lista[2].ToString(),
                    Cantidad = lista[3].ToString(),
                    PrecioCompra = Convert.ToDecimal(lista[4]),
                    PrecioVenta = Convert.ToDecimal(lista[5]),
                    TotalVenta = Convert.ToDecimal(lista[6]),
                    TotalCompra= Convert.ToDecimal(lista[7]),
                });
            }
            return Agregar;
        }
    }
}
