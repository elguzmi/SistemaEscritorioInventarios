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

namespace Inventarios_Windows.FormsBusqueda
{
    public partial class BuscarArticulos : Form
    {
        Articulo_N ArtiN = new Articulo_N();
        string Mensaje;
        public BuscarArticulos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BuscarArticulos_Load(object sender, EventArgs e)
        {

        }
        private void CargarDatos()
        {
            CargarTabla();

        }
        private void CargarTabla()
        {
            DataTable Tabla = new DataTable();
            Tabla = ArtiN.ListarProductos();
            DgvProducto.DataSource = Tabla;
        }

        private void TxtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if(TxtBuscarNombre.Text != "")
            {
            ArtiN.Nombre = TxtBuscarNombre.Text;
            DgvProducto.DataSource=  ArtiN.ListarProductosXNombre();
            }
            else
            {
                CargarTabla();
            }
        }

        private void TxtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarCodigo.Text != "")
            {
                ArtiN.codigo = TxtBuscarCodigo.Text;
                DgvProducto.DataSource = ArtiN.ListarProductosXCodigo();
            }
            else
            {
                CargarTabla();
            }
        }

        private void DgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                TxtId.Text = (DgvProducto[0, DgvProducto.CurrentRow.Index].Value).ToString();
                TxtCodigo.Text = (DgvProducto[1, DgvProducto.CurrentRow.Index].Value).ToString();
                TxtNombre.Text = (DgvProducto[2, DgvProducto.CurrentRow.Index].Value).ToString();
            }catch(Exception E)
            {
                throw E;
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try {
                int Id = int.Parse(TxtId.Text);
                ArtiN.Id_Articulo = Id;
                Mensaje =  ArtiN.EliminarArticulo();
                MessageBox.Show(Mensaje); //has eliminado el articulo
                CargarDatos();
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Selecciona un registro");
            }
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
