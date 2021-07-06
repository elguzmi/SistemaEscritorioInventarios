using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Inventario.Datos;
using Inventario.Entidades;

namespace Inventario.Negocio
{
    public class MenuPrincipal_N
    {
        MenuPrincipal_D CatD = new MenuPrincipal_D();
        


        public DataTable ListarArticulo()
        {
            List<MenuPrincipal_E> lst = new List<MenuPrincipal_E>();
                try
                {
                    lst.Add(new MenuPrincipal_E("@dato", 1));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return CatD.listar("MenuPrincipal", lst);
        }

        public DataTable ListarSalidas()
        {
            List<MenuPrincipal_E> lst = new List<MenuPrincipal_E>();
            try
            {
                lst.Add(new MenuPrincipal_E("@dato", 2));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CatD.listar("MenuPrincipal", lst);

        }
        public DataTable ListarEntradas()
        {
            List<MenuPrincipal_E> lst = new List<MenuPrincipal_E>();
            try
            {
                lst.Add(new MenuPrincipal_E("@dato", 3));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CatD.listar("MenuPrincipal", lst);
        }
        public DataTable ListarArticulosStock()
        {
            List<MenuPrincipal_E> lst = new List<MenuPrincipal_E>();
            try
            {
                lst.Add(new MenuPrincipal_E("@dato", 4));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CatD.listar("MenuPrincipal", lst);
        }

        public DataTable UltimasEntradas()
        {
            List<MenuPrincipal_E> lst = new List<MenuPrincipal_E>();
            try
            {
                lst.Add(new MenuPrincipal_E("@dato", 5));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CatD.listar("MenuPrincipal", lst);
        }

        public DataTable UltimasSalidas()
        {
            List<MenuPrincipal_E> lst = new List<MenuPrincipal_E>();
            try
            {
                lst.Add(new MenuPrincipal_E("@dato", 6));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CatD.listar("MenuPrincipal", lst);
        }


    }
}
