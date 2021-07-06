using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Entidades
{
    public class Agregar_Articulos_E
    {
        int _Id;
        string _Codigo;
        string _Nombre;
        string _Descripcion;
        string _PrecioUnidad;
        string _PrecioV;
       
        public int Id_Articulo
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string PrecioUnidad
        {
            get { return _PrecioUnidad; }
            set { _PrecioUnidad = value; }
        }

        public string PrecioV
        {
            get { return _PrecioV; }
            set { _PrecioV = value; }
        }


        public Agregar_Articulos_E(int Id, string Codigo,string Nombre,string Descripcion,string PrecioU,string PrecioV)
        {
            this._Id = Id;
            this._Codigo = Codigo;
            this._Descripcion = Descripcion;
            this._Nombre = Nombre;
            this._Descripcion = Descripcion;
            this._PrecioUnidad = PrecioU;
            this._PrecioV = PrecioV;
        }

        public Agregar_Articulos_E(string Codigo, string Nombre, string Descripcion, string PrecioU, string PrecioV)
        {

            this._Codigo = Codigo;
            this._Descripcion = Descripcion;
            this._Nombre = Nombre;
            this._Descripcion = Descripcion;
            this._PrecioUnidad = PrecioU;
            this._PrecioV = PrecioV;
        }

        public Agregar_Articulos_E() : this(0, "", "", "", "","")
        {
        }
    }
}
