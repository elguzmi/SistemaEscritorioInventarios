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
    public partial class Categorias : Form
    {
        bool _nuevo = false;
        Categorias_N CatN = new Categorias_N();
        string mensaje = "";


        public Categorias()
        {
            InitializeComponent();
            ActivarControlDatos(GbDatos, false);
            CargarDatos();
            ActivarButton(true);
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

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
            BtnEliminar.Enabled = Estado;
        }

        private void CargarDatos()
        {

            DataTable dte = CatN.Listar();
            DgvCategorias.DataSource = dte;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(GbDatos, true);
            BtnEditar.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(GbDatos);
            TxtNombre.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           

            if (_nuevo)
            {
                CatN.m_Nombre = TxtNombre.Text;
                CatN.m_Descripcion = TxtDescricpion.Text;

                mensaje = CatN.InsertarCategoria();
                if (mensaje != null && mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    CargarDatos();
                    LimpiarControl(GbDatos);
                    ActivarButton(true);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }

            }
            else
            {
                CatN.m_Id=  int.Parse(TxtId.Text);
                CatN.m_Nombre = TxtNombre.Text;
                CatN.m_Descripcion = TxtDescricpion.Text;
                mensaje = CatN.EditarCategoria();
                if (mensaje != null && mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    ActivarControlDatos(GbDatos, false);

                    ActivarButton(true);

                    DgvCategorias.Enabled = true;

                    LimpiarControl(GbDatos);

                    BtnEditar.Text = "Editar";

                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CatN.m_Id = ((int)DgvCategorias[0, DgvCategorias.CurrentRow.Index].Value);
            mensaje = CatN.EliminarCategoria();

            if (mensaje != null && mensaje != "")
            {
                MessageBox.Show(mensaje);

                DgvCategorias.Enabled = true;
                LimpiarControl(GbDatos);
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _nuevo = false;

            if (BtnEditar.Text == "Cancelar")

            {

                LimpiarControl(GbDatos);

                ActivarControlDatos(GbDatos, false);

                ActivarButton(true);

                DgvCategorias.Enabled = true;

                BtnEditar.Text = "Editar";

            }
            else
            {
                TxtId.Text = (DgvCategorias[0, DgvCategorias.CurrentRow.Index].Value).ToString();
                TxtNombre.Text = (DgvCategorias[1, DgvCategorias.CurrentRow.Index].Value).ToString();
                TxtDescricpion.Text = (DgvCategorias[2, DgvCategorias.CurrentRow.Index].Value).ToString();

                ActivarControlDatos(GbDatos, true);

                ActivarButton(false);

                DgvCategorias.Enabled = false;

                BtnEditar.Text = "Cancelar";
            }
        }
    }
}
