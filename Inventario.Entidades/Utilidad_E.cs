using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Entidades
{
    public class Utilidad_E
    {
        string _Codigo;
        string _Producto;
        int _Cantidad;
        decimal _PrecioCompra;
        decimal _PrecioVenta;
        string _Fecha;
        string _TotalCompra;
        decimal _TotalVenta;

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        public string Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        public decimal PrecioCompra
        {
            get { return _PrecioCompra; }
            set { _PrecioCompra = value; }
        }
        public decimal PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }
        public decimal TotalVenta
        {
            get { return _TotalVenta; }
            set { _TotalVenta = value; }
        }
        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }




        public Utilidad_E(string Codigo, string Producto,int Cantidad, decimal PrecioCompra, decimal PrecioVenta,string Fecha,decimal TotalVenta)
        {
            this._Codigo = Codigo;
            this._Producto = Producto;
            this._Cantidad =Cantidad;
            this._PrecioCompra = PrecioCompra;
            this._PrecioVenta = PrecioVenta;
            this._Fecha = Fecha;
            this._TotalVenta = TotalVenta;
        }


        public Utilidad_E() : this("", "", 0, 0, 0,"",0)
        {
        }
    }
}
