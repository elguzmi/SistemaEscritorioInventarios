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
    public class Agregar_Articulos_N
    {
        public List<Agregar_Articulos_E> Listar()
        {
            Agregar_Articulos_D Articulos_D = new Agregar_Articulos_D();
            return Articulos_D.Listar();
        }
    }
}
