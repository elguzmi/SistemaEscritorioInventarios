using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Entidades;
using Inventario.Datos;
using System.Data;
using System.Data.SqlClient;

namespace Inventario.Negocio
{
    public class Utilidad_N
    {
        public string FechaI { get; set; }
        public string FechaF { get; set; }
        public List<Utilidad_E> Listar()
        {
            Utilidad_D Salidas_D = new Utilidad_D();
            return Salidas_D.Listar();
        }

        public List<Utilidad_E> Filtrar()
        {
            Utilidad_D Salidas_D = new Utilidad_D();
            return Salidas_D.Filtrar(FechaI,FechaF);
        }
    }
}
