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
    public partial class BuscarProveedores : Form
    {
        Proveedores_N ArtiN = new Proveedores_N();
        string Mensaje;
        public BuscarProveedores()
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
            Tabla = ArtiN.Listar();
            DgvProveedores.DataSource = Tabla;
        }

        private void TxtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if(TxtBuscarNombre.Text != "")
            {
                ArtiN.m_Nit = 0;
                ArtiN.m_RazonSocial = TxtBuscarNombre.Text;
            DgvProveedores.DataSource=  ArtiN.ListarProveedoresXRazon();
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
                ArtiN.m_Nit = int.Parse(TxtBuscarCodigo.Text);
                ArtiN.m_RazonSocial = "";
                DgvProveedores.DataSource = ArtiN.ListarProveedoresXNit();
            }
            else
            {
                CargarTabla();
            }
        }

        private void DgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                TxtId.Text = (DgvProveedores[0, DgvProveedores.CurrentRow.Index].Value).ToString();
                TxtNit.Text = (DgvProveedores[1, DgvProveedores.CurrentRow.Index].Value).ToString();
                TxtRazonSocial.Text = (DgvProveedores[2, DgvProveedores.CurrentRow.Index].Value).ToString();
            }catch(Exception E)
            {
                throw E;
            }
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
