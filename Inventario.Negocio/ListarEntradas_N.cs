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
    public class ListarEntradas_N
    {
        public List<ListarEntradas_E> Listar()
        {
            ListarEntradas_D Entradas_D = new ListarEntradas_D();
            return Entradas_D.Listar();
        }
    }
}
