using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Inventario.Entidades;
using Inventario.Datos;

namespace Inventario.Negocio
{
    public class Login_N
    {
        Login_D Datos = new Login_D();

        public DataTable login(login_E obj)
        {
            
            return Datos.Ingreso(obj);
        }
    }
}
