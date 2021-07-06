using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Entidades
{
    public class ListarSalidas_E
    {
        int _Id;
        string _Fecha;
        string _Nombre;
        string _VTotal;
        
        string _Estado;
       
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string VTotal
        {
            get { return _VTotal; }
            set { _VTotal = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


        public ListarSalidas_E(int Id, string Fecha,string Nombre,string VTotal,string Estado)
        {
            this._Id = Id;
            this._Fecha = Fecha;
            this._Nombre = Nombre;
            this._VTotal = VTotal;
            this.Estado = Estado; 
        }
    

        public ListarSalidas_E() : this(0,"", "", "","")
        {
        }
    }
}
