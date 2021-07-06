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
using Inventario.Entidades;

namespace Inventarios_Windows
{
    public partial class Entradas : Form
    {
        AgregarEntrada_N EntradaN = new AgregarEntrada_N();
        DataTable Tabla = new DataTable();
        List<Agregar_Articulos_E> lista = null;
        Agregar_Articulos_N ArtN = new Agregar_Articulos_N();

        public Entradas()
        {
            InitializeComponent();
            UltimoId();
            CargarDatos();
            Additems();
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {
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

        //Agregar item al combo box
        private void Additems()
        {
            CmbCantidad.Items.Clear();
            for (int i = 1; i < 100; i++)
            {
                CmbCantidad.Items.Add(i);
            }
        }

        private void ContarTotal()
        {
            decimal Vtotal = 0;
            foreach (DataGridViewRow row in DgvEntradas.Rows)
            {

                Vtotal += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            TxtTotal.Text = Vtotal.ToString();
        }
        //Agregar un proveedor
        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            using (FormsBusqueda.BuscarProveedores Proveedores = new FormsBusqueda.BuscarProveedores())
            {
                if (Proveedores.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //buscar registro por Id
                    int idP = int.Parse(Proveedores.TxtId.Text.ToString());
                    int Nit = int.Parse(Proveedores.TxtNit.Text.ToString());
                    String Razon = Proveedores.TxtRazonSocial.Text;
                    this.TxtIdP.Text = idP.ToString();
                    this.TxtNit.Text = Nit.ToString();
                    this.TxtRazon.Text = Razon;
                }
            }
        }

        //extraer el ultimo Id de la base de datos
        private void UltimoId()
        {
            DataTable tabla = EntradaN.UltimoId();
            if (tabla.Rows.Count == 0 || tabla == null)
            {
                TxtIdEntrada.Text = 1.ToString();
            }
            else
            {
                DataTable Tabla = EntradaN.UltimoId();
                int Id = int.Parse(Tabla.Rows[0][0].ToString());
                TxtIdEntrada.Text = (Id + 1).ToString();
            }
            
        }
        public void BtnProductos_Click(object sender, EventArgs e)
        {
            using(FormsBusqueda.AgregarArticulos Add = new FormsBusqueda.AgregarArticulos())
            {
                if (Add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    decimal Total=0;
                    if(DgvEntradas.RowCount > 0)
                    {
                        MessageBox.Show("Ya tienes articulos añadidos");
                    }
                    else
                    {
                        DgvEntradas.DataSource = Add.Tabla;
                    }

                    foreach (DataGridViewRow row  in DgvEntradas.Rows)
                    {
                        Total += Convert.ToDecimal(row.Cells["Total"].Value);
                    }
                    TxtTotal.Text = Total.ToString();
                }
            }
        }

        public void BtnPrueba_Click(object sender, EventArgs e)
        {
            FormsBusqueda.AgregarArticulos Add = new FormsBusqueda.AgregarArticulos();
            Add.Show();
        }

        private void DgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                DgvEntradas.Rows.Add(ls[0], ls[1], ls[2], ls[3], ls[4], ls[5], Total);
                ContarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GbDatos_Enter(object sender, EventArgs e)
        {

        }

        


        //Para cuando salga un error con e combo box de el datagridview
        private void DgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid")
            {
                object value = DgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (!((DataGridViewComboBoxColumn)DgvProductos.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)DgvProductos.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

       

        //Agregar la entrada
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string msj = "";
            try
            {
                EntradaN.Id_Entrada = int.Parse(TxtIdEntrada.Text);
                EntradaN.Nombre = TxtNombreEntrada.Text;
                EntradaN.ValorTotal = Convert.ToDecimal(TxtTotal.Text);
                EntradaN.Nit = int.Parse(TxtIdP.Text);
                msj = EntradaN.InsertarEntrada();

                try
                {
                    if (msj == "Insertado")
                    {
                        for (int i = 0; i < DgvEntradas.Rows.Count - 1; i++)
                        {

                            EntradaN.Id_Ar = int.Parse(DgvEntradas[0, DgvEntradas.Rows[i].Index].Value.ToString());
                            EntradaN.Cantidad = int.Parse(DgvEntradas[4, DgvEntradas.Rows[i].Index].Value.ToString());
                            EntradaN.PrecioXUni = Convert.ToDecimal(DgvEntradas[5, DgvEntradas.Rows[i].Index].Value.ToString());
                            EntradaN.Total = Convert.ToDecimal(DgvEntradas[6, DgvEntradas.Rows[i].Index].Value.ToString());
                            msj = EntradaN.InsertarDetalles();
                            if (msj == "Correcto")
                            {
                                continue;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error contacta al administrador");
                                break;
                            }
                        }
                        MessageBox.Show("Se ha insertado");
                        limpiar();

                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un erro al insertar los detalles");
                }
            }
            catch
            {
                MessageBox.Show("Completa todos los campos");
            }

        }

        private void limpiar()
        {
            TxtRazon.Clear();
            TxtNit.Clear();
            DgvEntradas.Rows.Clear();
            TxtNombreEntrada.Clear();
            UltimoId();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
