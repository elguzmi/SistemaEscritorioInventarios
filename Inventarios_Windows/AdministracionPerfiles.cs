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
    public partial class AdministracionPerfiles : Form
    {
        List<Perfiles_E> lista = null;
        Perfiles_N PerfilN = new Perfiles_N();
        Perfiles_E c;
        bool _nuevo = false;
        public AdministracionPerfiles()
        {
            InitializeComponent();
            ActivarControlDatos(Gb_Datos, false);
            CargarDatos();
        }

        private void AdministracionPerfiles_Load(object sender, EventArgs e)
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
            BtnAgregar.Enabled = !Estado;
            BtnEliminar.Enabled = Estado;

        }
        private void CargarDatos()
        {
            if (lista == null)
            {
                lista = PerfilN.Listar();
            }
            if (lista.Count > 0)
            {
                DgvUsuarios.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    DgvUsuarios.Rows.Add(lista[i].Id,
                        lista[i].User,
                        lista[i].Password,
                        lista[i].Nombre,
                        lista[i].Correo,
                        lista[i].Cargo
                        );
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(Gb_Datos, true);
            BtnEditar.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(Gb_Datos);
            TxtUser.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _nuevo = false;

            if (BtnEditar.Text == "Cancelar")
            {
                LimpiarControl(Gb_Datos);

                ActivarControlDatos(Gb_Datos, false);

                ActivarButton(true);

                DgvUsuarios.Enabled = true;

                BtnEditar.Text = "Editar";

            }
            else
            {
                if (DgvUsuarios.RowCount > 0)

                {
                    MessageBox.Show(DgvUsuarios[0, DgvUsuarios.CurrentRow.Index].Value.ToString());
                    c = PerfilN.TraerPorId((int)DgvUsuarios[0, DgvUsuarios.CurrentRow.Index].Value);
                    

                    TxtId.Text = c.Id.ToString();

                    TxtUser.Text = c.User;

                    TxtPassword.Text = c.Password;

                    TxtCorreo.Text = c.Correo;

                    TxtCargo.Text = c.Cargo.ToString();

                    TxtEncargado.Text = c.Nombre;

                    ActivarControlDatos(Gb_Datos, true);

                    ActivarButton(false);

                    DgvUsuarios.Enabled = false;

                    BtnEditar.Text = "Cancelar";

                }

            }
        }
    }
}
