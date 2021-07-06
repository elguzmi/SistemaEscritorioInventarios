using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Entidades;
using Inventario.Negocio   ;

namespace Inventarios_Windows
{
    public partial class Login : Form
    {
        login_E Entidad = new login_E();
        Login_N Negocio = new Login_N();
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
           

            Entidad.Usuario = TxtUsuario.Text;
            Entidad.Clave = TxtClave.Text;

            DataTable tabla = new DataTable();
            tabla = Negocio.login(Entidad);

            if(tabla.Rows.Count > 0)
            {
                int Id_Usuario = int.Parse(tabla.Rows[0][0].ToString());
                string Usuario = tabla.Rows[0][1].ToString();
                string Clave = tabla.Rows[0][2].ToString();
                string Nombre = tabla.Rows[0][3].ToString();
                
                //MessageBox.Show(Id_Usuario+Usuario);
                //MessageBox.Show(Clave+ Nombre);
                //MessageBox.Show("Bienvenid@ " + Nombre);
                MenuPrincipal Main = new MenuPrincipal(Id_Usuario,Nombre);
                this.Hide();
                Main.Show();
                

            }
            else
            {
                MessageBox.Show("Has ingresado un usuario incorrecto");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
