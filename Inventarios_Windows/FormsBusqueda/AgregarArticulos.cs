using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Inventario.Entidades;
using Inventario.Negocio;


namespace Inventarios_Windows.FormsBusqueda
{
    public partial class AgregarArticulos : Form
    {
        public DataTable Tabla = new DataTable();
        List<Agregar_Articulos_E> lista = null;
        Agregar_Articulos_N ArtN = new Agregar_Articulos_N();
        Agregar_Articulos_E c;
        bool _nuevo = false;


        public AgregarArticulos()
        {
            InitializeComponent();
            CargarDatos();
            Additems();

            //DataTable tabla = new DataTable();
            Tabla.Columns.Add("Id", typeof(int));
            Tabla.Columns.Add("Codigo", typeof(String));
            Tabla.Columns.Add("Nombre", typeof(String));
            Tabla.Columns.Add("Descripcion", typeof(String));
            Tabla.Columns.Add("Cantidad", typeof(String));
            Tabla.Columns.Add("PrecioUnidad", typeof(String));
            Tabla.Columns.Add("Total", typeof(String));
        }


        private void CargarDatos()
        {
            
            if (lista == null)
            {
                lista = ArtN.Listar();
                
            }

            if (lista.Count > 0)
            {
                DgvProductos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    
                    DgvProductos.Rows.Add(lista[i].Id_Articulo,
                        lista[i].Codigo,
                        lista[i].Nombre,
                        lista[i].Descripcion,
                        1,
                        lista[i].PrecioUnidad
                        );
                }
            }
        }

        private void AgregarArticulos_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Additems()
        {
            for (int i = 1; i <= 100; i++)
            {
                CmbCantidad.Items.Add(i);
            }
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
          
        }

        

        private void Btn_Editar(object sender, DataGridViewCellEventArgs e)
        {
            
            List<string> Lista = new List<string>();
            try
            {
                if (DgvProductos.CurrentRow.DefaultCellStyle.BackColor == System.Drawing.Color.FromName("LightRed"))
                {
                    int Id = int.Parse(DgvProductos[0, DgvProductos.CurrentRow.Index].Value.ToString());
                    MessageBox.Show(Id.ToString());
                    for (int i = 0; i < DgvSeleccion.Rows.Count; i++)
                    {
                        int valor = int.Parse(DgvSeleccion[0, DgvProductos.Rows[i].Index].Value.ToString());
                        if(valor == Id)
                        {
                            DgvSeleccion.Rows.Remove(DgvProductos.Rows[i]);
                        }
                        else
                        {
                            continue;
                        }
                    }                      
                    DgvSeleccion.DataSource = Tabla;
                }
                else
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        Lista.Add(DgvProductos[i, DgvProductos.CurrentRow.Index].Value.ToString());
                    }
                    decimal cantidad = Convert.ToDecimal(Lista[4]);
                    decimal Valor = Convert.ToDecimal(Lista[5]);
                    decimal Total = Valor * cantidad;
                    Tabla.Rows.Add(Lista[0], Lista[1], Lista[2], Lista[3], Lista[4], Lista[5], Total);
                    DgvProductos.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromName("LightRed");
                    DgvSeleccion.DataSource = Tabla;
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }

        }
    }
}
