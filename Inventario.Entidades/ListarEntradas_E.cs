using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Entidades
{
    public class ListarEntradas_E
    {
        int _Id;
        string _Fecha;
        string _Nombre;
        string _VTotal;
        string _Razon;
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
        public string Razon
        {
            get { return _Razon; }
            set { _Razon = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


        public ListarEntradas_E(int Id, string Fecha,string Nombre,string VTotal,string Razon,string Estado)
        {
            this._Id = Id;
            this._Fecha = Fecha;
            this._Nombre = Nombre;
            this._VTotal = VTotal;
            this.Razon = Razon;
            this.Estado = Estado; 
        }
    

        public ListarEntradas_E() : this(0,"", "", "", "","")
        {
        }
    }
}
