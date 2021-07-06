using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Datos;
using Inventario.Entidades;

namespace Inventario.Negocio
{
    public class Perfiles_N
    {
        private  Perfiles_D objetoCD = new Perfiles_D();

        public int Insertar(Perfiles_E perfiles)
        {
            
            return objetoCD.Insertar(perfiles);
        }

        public int Actualizar(Perfiles_E perfiles)
        {
           
            return objetoCD.Actualizar(perfiles);
        }

        public int Eliminar(int Cedula)
        { 
            return objetoCD.Eliminar(Cedula);
        }

        public List<Perfiles_E> Listar()
        {
            
            return objetoCD.Listar();
        }

        public Perfiles_E TraerPorId(int Id)
        {
            return objetoCD.TraerPorId(Id);
        }
    }
}
