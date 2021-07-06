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
using Inventario.Negocio;

namespace Inventarios_Windows
{
    public partial class Salidas : Form
    {
        
        List<Agregar_Articulos_E> lista = null;
        Agregar_Articulos_N ArtN = new Agregar_Articulos_N();//para traer todos los articulos
        Agregar_Articulos_E c;
        AgregarSalida_N AddN = new AgregarSalida_N();

        public Salidas()
        {
            InitializeComponent();
            CargarDatos();
            Additems();
            UltimoId();
        }

        private void UltimoId()
        {
            DataTable Tabla = AddN.UltimoId();
            if (Tabla.Rows.Count == 0)
            {
                TxtId.Text = 1.ToString();
            }
            else
            {
                int Id = int.Parse(Tabla.Rows[0][0].ToString());
                TxtId.Text = (Id + 1).ToString();
            }     
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
                        lista[i].PrecioV
                        );
                }
            }
        }

        private void Additems()
        {
            CmbCantidad.Items.Clear();
            for (int i = 1; i < 100; i++)
            {
                CmbCantidad.Items.Add(i);
            }
        }
        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }


        //Para cuando salga un error con e combo box de el datagridview
        private void DgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Exception.Message == "DataGridViewComboBoxCell value is not valid")
            {
                object value = DgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (!((DataGridViewComboBoxColumn)DgvProductos.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)DgvProductos.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Boton de Añadir en el Datagridview
        private void Btn_Editar(object sender, DataGridViewCellEventArgs e)
        {

            List<string> ls = new List<string>();
            try
            {
                    for (int i = 0; i <= 5; i++)
                    {
                        ls.Add(DgvProductos[i, DgvProductos.CurrentRow.Index].Value.ToString());
                    }
                    int cantidad = int.Parse(ls[4]);
                    decimal Valor = Convert.ToDecimal(ls[5]);
                    decimal Total = Valor * cantidad;
                    MessageBox.Show(Total.ToString());

                DataTable Cantidad = AddN.Verificacion(int.Parse(ls[0]));
                int cant = int.Parse(Cantidad.Rows[0][0].ToString());
                if (cant< cantidad )
                {
                    MessageBox.Show("No hay sufienciente stock");
                }
                else
                {
                    DgvFactura.Rows.Add(ls[0], ls[1], ls[2], ls[3], ls[4], ls[5], Total);
                    ContarTotal();
                }
                     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
        private void ContarTotal()
        {
            decimal Vtotal = 0;
            foreach (DataGridViewRow row in DgvFactura.Rows)
            {
                
                Vtotal += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            TxtTotal.Text = Vtotal.ToString();
        }

        private void GbProductos_Enter(object sender, EventArgs e)
        {
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string Msj = "";

            //Insertar Salida
            int Id = int.Parse(TxtId.Text);
            string Nombre = TxtNombre.Text;
            decimal ValorTotal =Convert.ToDecimal(TxtTotal.Text);

            AddN.NombreSalida = Nombre;
            AddN.ValorTotal = ValorTotal;
            Msj=  AddN.InsertarSalida();
            
            int conteo = DgvFactura.RowCount;
            conteo -= 1;
            MessageBox.Show(conteo.ToString());
            //Insertar Detalles de Salida
            
            for(int i =0; i<conteo; i++)
            {
                //MessageBox.Show(DgvFactura[0, DgvFactura.Rows[i].Index].Value.ToString());
                AddN.Id_Salida = int.Parse(TxtId.Text.ToString());
                AddN.Id_Ar = int.Parse(DgvFactura[0, DgvFactura.Rows[i].Index].Value.ToString()); //Id
                AddN.Cantidad = int.Parse(DgvFactura[4, DgvFactura.Rows[i].Index].Value.ToString());  //Cantidad
                AddN.Total = Convert.ToDecimal(DgvFactura[6, DgvFactura.Rows[i].Index].Value.ToString()); //Total
                Msj = AddN.InsertarDetalles();
                if (Msj == "Si")
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Hace falta stock");
                    UltimoId();
                    break;
                }
            }

            MessageBox.Show("Se ha guardado");
            limpiar();
        }

        private void limpiar()
        {
            DgvFactura.Rows.Clear();
            TxtNombre.Clear();
            UltimoId();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DgvFactura.Rows.RemoveAt(DgvFactura.CurrentRow.Index);
            ContarTotal();
        }
    }


}
