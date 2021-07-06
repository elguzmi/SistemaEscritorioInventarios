using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Entidades
{
    public class ReporteUtilidad_E
    {
        public string Fecha { get; set; }

        public string Codigo { get; set; }
        public string Producto { get; set; }
        public string Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal TotalCompra{ get; set; }

        public ReporteUtilidad_E()
        {

        }

        public ReporteUtilidad_E(ReporteUtilidad_E Add)
        {
            Fecha = Add.Fecha;
            Codigo = Add.Codigo;
            Producto = Add.Producto;
            Cantidad = Add.Cantidad;
            PrecioCompra = Add.PrecioCompra;
            PrecioVenta = Add.PrecioVenta;
            TotalVenta = Add.TotalVenta;
            TotalCompra = Add.TotalCompra;
        }
    }
}
