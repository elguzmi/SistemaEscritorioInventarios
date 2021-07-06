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
    public partial class Articulos : Form
    {
        bool _nuevo = false;
        bool _editar = false;
        Articulo_N ArtN = new Articulo_N();
        String Mensaje = "";
        public Articulos()
        {
            InitializeComponent();
            CargarDatos();
            UltimoId();
        }
        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void CargarDatos()
        {
            CargarCategorias();
            ActivarControlDatos(GbDatos, false);
            ActivarButton(true);
        }
        private void CargarCategorias()
        {
            DataTable tabla = ArtN.ListarCategorias();
            CmbCategorias.DataSource = tabla;
            CmbCategorias.DisplayMember = "Nombre";
            CmbCategorias.ValueMember = "Id_Categoria";

        }

        private void UltimoId()
        {
            DataTable Tabla = ArtN.UltimoId();
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

        private void ActivarControlDatos(Control Contenedor, bool Estado)
        {
            try
            {
                foreach (var item in Contenedor.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).Enabled = Estado;
                        

                    }
                    if (item.GetType() == typeof(ComboBox))
                    {
                        ((ComboBox)item).Enabled = Estado;

                    }


                }
            }
            catch (Exception)
            {
            }
        }

        private void LimpiarControl(Control Contenedor)
        {
            foreach (var item in Contenedor.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void ActivarButton(bool Estado)
        {
            BtnNuevo.Enabled = Estado;
            BtnGuardar.Enabled = !Estado;
            //BtnEliminar.Enabled = Estado;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ActivarButton(false);
            ActivarControlDatos(GbDatos, true);
            _nuevo = true;
            BtnActualizar.Text = "Cancelar";
            UltimoId();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (_nuevo)
            {
                ArtN.Id_Articulo = 0;
                ArtN.codigo = TxtCodigo.Text;
                ArtN.Nombre = TxtNombre.Text;
                ArtN.Descripcion = TxtDescricpion.Text;
                ArtN.cantidad = int.Parse(CmbCantidad.Text.ToString());
                ArtN.PrecioCosto = double.Parse(TxtPrecioC.Text);
                ArtN.PrecioVenta = double.Parse(TxtPrecioV.Text);
                ArtN.Id_Categoria = int.Parse(CmbCategorias.SelectedValue.ToString());
                ArtN.stock_Ideal = int.Parse(CmbStockIdeal.Text.ToString());
                if (CmbEstado.Text == "Activo") {
                    ArtN.estado = 1;
                }
                else
                {
                    ArtN.estado = 0;
                }
                Mensaje = ArtN.InsertarArticulo();
                MessageBox.Show(Mensaje);
                if (Mensaje != "" || Mensaje != null)
                {
                    BtnActualizar.Text = "Actualizar";
                    _nuevo = false;
                    ActivarControlDatos(GbDatos, false);
                    LimpiarControl(GbDatos);
                    ActivarButton(true);
                }
            }
            else
            {
                //cuando nuevo es igual a false es decir se va a editar el registro

                ArtN.Id_Articulo = int.Parse(TxtId.Text);
                ArtN.codigo = TxtCodigo.Text;
                ArtN.Nombre = TxtNombre.Text;
                ArtN.Descripcion = TxtDescricpion.Text;
                ArtN.cantidad = int.Parse(CmbCantidad.SelectedItem.ToString());
                ArtN.PrecioCosto = double.Parse(TxtPrecioC.Text);
                ArtN.PrecioVenta = double.Parse(TxtPrecioV.Text);
                ArtN.Id_Categoria = int.Parse(CmbCategorias.SelectedValue.ToString());
                ArtN.stock_Ideal = int.Parse(CmbStockIdeal.SelectedItem.ToString());
                if (CmbEstado.Text == "Activo")
                {
                    ArtN.estado = 1;
                }
                else
                {
                    ArtN.estado = 0;
                }
                Mensaje = ArtN.EditarArticulo();
                MessageBox.Show(Mensaje);
                if(Mensaje != "" || Mensaje != null)
                {
                    BtnActualizar.Text = "Actualizar";
                    _nuevo = false;
                    ActivarControlDatos(GbDatos, false);
                    LimpiarControl(GbDatos);
                    _editar = false;
                    ActivarButton(true);

                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            
            if (_nuevo)
            {
                BtnActualizar.Text = "Actualizar";
                _nuevo = false;
                _editar = false;
                ActivarControlDatos(GbDatos, false);
                LimpiarControl(GbDatos);
                ActivarButton(true);
            }
            else if (_editar)
            {
                BtnActualizar.Text = "Actualizar";
                _nuevo = false;
                _editar = false;
                ActivarControlDatos(GbDatos, false);
                LimpiarControl(GbDatos);
                ActivarButton(true);
            }

            else
            {
                //hacemos el using form y recuperamos los datos a editar
                using (FormsBusqueda.BuscarArticulos BuscarArt = new FormsBusqueda.BuscarArticulos())
                {
                    if (BuscarArt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //buscar registro por Id
                        try
                        {
                            int Id = int.Parse(BuscarArt.TxtId.Text.ToString());
                            ArtN.Id_Articulo = Id;
                            DataTable datos = ArtN.TraerXId();

                            //MessageBox.Show(datos.Rows[0]["Codigo"].ToString());
                            TxtCodigo.Text = datos.Rows[0]["Codigo"].ToString();
                            TxtId.Text = datos.Rows[0]["Id"].ToString();
                            TxtNombre.Text = datos.Rows[0]["Nombre_Articulo"].ToString();
                            TxtDescricpion.Text = datos.Rows[0]["Descripcion"].ToString();
                            CmbCantidad.Text = datos.Rows[0]["Cantidad"].ToString();
                            TxtPrecioC.Text = datos.Rows[0]["Precio_Costo"].ToString();
                            TxtPrecioV.Text = datos.Rows[0]["Precio_Venta"].ToString();
                            CmbStockIdeal.Text = datos.Rows[0]["Stock_Ideal"].ToString();
                            bool Estado = bool.Parse(datos.Rows[0]["Estado"].ToString());
                            if (Estado == true)
                            {
                                CmbEstado.SelectedIndex = 0;
                            }
                            else
                            {
                                CmbEstado.SelectedIndex = 1;
                            }

                            _nuevo = false;
                            _editar = true;
                            ActivarControlDatos(GbDatos, true);
                            BtnActualizar.Text = "Cancelar";
                            ActivarButton(false);
                        }
                        catch
                        {
                            MessageBox.Show("No has seleccionado nada");
                        }
                        
                        
                        
                        
                       
                    }
                }
            }
        }//final del metodo o evento
    }
}
