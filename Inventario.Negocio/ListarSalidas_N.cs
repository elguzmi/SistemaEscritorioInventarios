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
    public class ListarSalidas_N
    {
        public List<ListarSalidas_E> Listar()
        {
            ListarSalidas_D Salidas_D = new ListarSalidas_D();
            return Salidas_D.Listar();
        }
    }
}
