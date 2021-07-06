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
    public partial class Empresas : Form
    {
        bool _nuevo = false;
        Proveedores_N CatN = new Proveedores_N();
        string mensaje = "";


        public Empresas()
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
            DgvProvedores.DataSource = dte;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(GbDatos, true);
            BtnEditar.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(GbDatos);
            TxtRazonSocial.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           

            if (_nuevo)
            {
                CatN.m_Nit = int.Parse(TxtNit.Text.ToString());
                CatN.m_RazonSocial = TxtRazonSocial.Text;
                CatN.m_Telefono = int.Parse(TxtTelefono.Text);
                CatN.m_Direccion = TxtDireccion.Text;
                CatN.m_Correo = TxtCorreo.Text;
                CatN.m_Observacion = TxtObservacion.Text; 

                mensaje = CatN.InsertarCategoria();
                if (mensaje != null && mensaje != "")
                {
                   MessageBox.Show(mensaje);
                    ActivarButton(true);
                    LimpiarControl(GbDatos);
                    _nuevo = false;
                    ActivarControlDatos(GbDatos, false);
                    CargarDatos();
                }
                else
                {
                   MessageBox.Show("Ocurrio un error");
                }

            }
            else
            {
                CatN.m_Id = int.Parse(TxtId.Text);
                CatN.m_Nit = int.Parse(TxtNit.Text);
                CatN.m_RazonSocial = TxtRazonSocial.Text;
                CatN.m_Telefono = int.Parse(TxtTelefono.Text);
                CatN.m_Direccion = TxtDireccion.Text;
                CatN.m_Correo = TxtCorreo.Text;
                CatN.m_Observacion = TxtObservacion.Text;
                mensaje = CatN.EditarCategoria();
                if (mensaje != null && mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    ActivarControlDatos(GbDatos, false);

                    ActivarButton(true);

                    DgvProvedores.Enabled = true;

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
            CatN.m_Id = ((int)DgvProvedores[0, DgvProvedores.CurrentRow.Index].Value);
            mensaje = CatN.EliminarCategoria();

            if (mensaje != null && mensaje != "")
            {
                MessageBox.Show(mensaje);

                DgvProvedores.Enabled = true;
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

                DgvProvedores.Enabled = true;

                BtnEditar.Text = "Editar";

            }
            else
            {
                try
                {
                    TxtId.Text = (DgvProvedores[0, DgvProvedores.CurrentRow.Index].Value).ToString();
                    TxtNit.Text = (DgvProvedores[1, DgvProvedores.CurrentRow.Index].Value).ToString();
                    TxtRazonSocial.Text = (DgvProvedores[2, DgvProvedores.CurrentRow.Index].Value).ToString();
                    TxtTelefono.Text = (DgvProvedores[3, DgvProvedores.CurrentRow.Index].Value).ToString();
                    TxtDireccion.Text = (DgvProvedores[4, DgvProvedores.CurrentRow.Index].Value).ToString();
                    TxtCorreo.Text = (DgvProvedores[5, DgvProvedores.CurrentRow.Index].Value).ToString();
                    TxtObservacion.Text = (DgvProvedores[6, DgvProvedores.CurrentRow.Index].Value).ToString();
                }
                catch(Exception Ex)
                {

                }
                

                ActivarControlDatos(GbDatos, true);

                ActivarButton(false);

                DgvProvedores.Enabled = false;

                BtnEditar.Text = "Cancelar";
            }
        }
    }
}
