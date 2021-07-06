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
    public partial class RevisarEntradas : Form
    {
        
        List<ListarEntradas_E> lista = null;
        ListarEntradas_N ArtN = new ListarEntradas_N();
        ListarEntradas_E c;
        AgregarEntrada_N AddE = new AgregarEntrada_N();
        bool _nuevo = false;
        public RevisarEntradas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (lista == null)
            {
                lista = ArtN.Listar();
            }
            if (lista.Count > 0)
            {
                Dgv_Entradas.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Dgv_Entradas.Rows.Add(lista[i].Id,
                        lista[i].Nombre,
                        lista[i].Fecha,
                        lista[i].Razon,
                        lista[i].VTotal,
                        lista[i].Estado
                        );
                }
            }
        }


        private void DgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Id = int.Parse(Dgv_Entradas[0, Dgv_Entradas.CurrentRow.Index].Value.ToString());
                DgvDetalles.DataSource = AddE.TraerDetalles(Id);
                TxtIdDetalles.Text = Id.ToString();
            }
            catch
            {
                MessageBox.Show("No has seleccionado ningun registro");
            }
            

        }
        private void TituloLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(TxtIdDetalles.Text);
            string Estado = Dgv_Entradas[5, Dgv_Entradas.CurrentRow.Index].Value.ToString();
            int State=0;
            if (Estado =="True")
            {
                State = 1;
            }
            else if(Estado == "False")
            {
                State = 0;
            }
            String msj = "";
            msj= AddE.ChangeState(Id,State);
            string finalState = AddE.ChangeState(Id, State);

            int conteo = DgvDetalles.RowCount;
            conteo -= 1;
            int i = 0;
            while (i < conteo)
            {

                String Codigo = DgvDetalles[0, DgvDetalles.Rows[i].Index].Value.ToString(); //Codigo
                int Cantidad = int.Parse(DgvDetalles[2, DgvDetalles.Rows[i].Index].Value.ToString()); //Codigo
                msj = AddE.UpdateArticles(Codigo, Cantidad, int.Parse(finalState));

                i++;

                if (i == conteo)
                {
                    MessageBox.Show("Se ha modificado Correctamente");
                    lista = ArtN.Listar();
                    Dgv_Entradas.Rows.Clear();
                    for (int l = 0; l < lista.Count; l++)
                    {
                        Dgv_Entradas.Rows.Add(lista[l].Id,
                            lista[l].Nombre,
                            lista[l].Fecha,
                            lista[l].Razon,
                            lista[l].VTotal,
                            lista[l].Estado
                            );
                    }
                }

            }
         }


        
    }
}
