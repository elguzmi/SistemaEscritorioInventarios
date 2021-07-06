using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Negocio;

namespace Inventarios_Windows
{
    public partial class RevisarStock : Form
    {

        Articulo_N ArtiN = new Articulo_N();
        
        public RevisarStock()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void TituloLabel_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            DataTable Tabla = new DataTable();
            Tabla = ArtiN.ListarProductos();
            DgvStock.DataSource = Tabla;
        }

        private void TxtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            ArtiN.codigo = TxtBuscarCodigo.Text;
            DgvStock.DataSource = ArtiN.FiltrarArticulos(1);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if(TxtBuscarCodigo.Text != ""  && TxtBuscarCodigo.Text != null)
            {
                ArtiN.Nombre = TxtBuscarCodigo.Text;
                DgvStock.DataSource = ArtiN.FiltrarArticulos(2);
            }
            else
            {
                CargarDatos();
            }
           
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ArtiN.cantidad = int.Parse(TxtBuscarCodigo.Text);
                DgvStock.DataSource = ArtiN.FiltrarArticulos(3);
            }
            catch
            {
                CargarDatos();
            }
            
        }
    }
}
