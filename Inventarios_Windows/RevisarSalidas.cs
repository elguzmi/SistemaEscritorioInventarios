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
    public partial class RevisarSalidas : Form
    {
        
        List<ListarSalidas_E> lista = null;
        ListarSalidas_N ArtN = new ListarSalidas_N();
        ListarEntradas_E c;
        AgregarEntrada_N AddE = new AgregarEntrada_N();
        AgregarSalida_N AddN = new AgregarSalida_N();
        bool _nuevo = false;
        public RevisarSalidas()
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
                Dgv_Salidas.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Dgv_Salidas.Rows.Add(lista[i].Id,
                        lista[i].Nombre,
                        lista[i].Fecha,
                        lista[i].VTotal,
                        lista[i].Estado
                        );
                }
            }
        }
        private void DgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = int.Parse(Dgv_Salidas[0, Dgv_Salidas.CurrentRow.Index].Value.ToString());
            DgvDetalles.DataSource = AddN.TraerDetalles(Id);
            TxtIdDetalles.Text = Id.ToString();
        }
        private void TituloLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            
        }

        private void ChangeState_Click(object sender, EventArgs e)
        {

            int Id = int.Parse(TxtIdDetalles.Text);
            string Estado = Dgv_Salidas[4, Dgv_Salidas.CurrentRow.Index].Value.ToString();

            int State = 0;
            if (Estado == "True")
            {
                State = 1;
            }
            else if (Estado == "False")
            {
                State = 0;
            }
            String msj = "";
            string finalState = AddN.ChangeState(Id, State);

            int conteo = DgvDetalles.RowCount;
            conteo -= 1;
            int i = 0;
            while(i < conteo)
            {
               
                String Codigo = DgvDetalles[0, DgvDetalles.Rows[i].Index].Value.ToString(); //Codigo
                int Cantidad = int.Parse(DgvDetalles[2, DgvDetalles.Rows[i].Index].Value.ToString()) ; //Codigo
                msj = AddN.UpdateArticles(Codigo,Cantidad, int.Parse(finalState));

                i++;

                if (i == conteo)
                {
                    MessageBox.Show("Se ha modificado Correctamente");
                    lista = ArtN.Listar();
                    Dgv_Salidas.Rows.Clear();
                    for (int l = 0; l < lista.Count; l++)
                    {
                        Dgv_Salidas.Rows.Add(lista[l].Id,
                        lista[l].Nombre,
                        lista[l].Fecha,
                        lista[l].VTotal,
                        lista[l].Estado
                        );
                    }
                }   
            }
        }
    }
}
