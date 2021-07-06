using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Entidades
{
    public class Perfiles_E
    {
        int _Id;
        string _User;
        string _Nombre;
        string _Password;
        string _Cargo;
        string _Correo;



        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
        public string   Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        public Perfiles_E(int Id, string User, string Nombre, string Password,string Correo, string Cargo)
        {
            _Id = Id;
            _Nombre = Nombre;
            _User = User;
            _Password = Password;
            _Cargo = Cargo;
            _Correo = Correo;
        }

        public Perfiles_E( string User, string Nombre, string Password, string Cargo)
        {
            _Nombre = Nombre;
            _User = User;
            _Password = Password;
            _Cargo = Cargo;
        }

        public Perfiles_E() : this(0, "", "", "", "","")
        {
        }
    }
}
