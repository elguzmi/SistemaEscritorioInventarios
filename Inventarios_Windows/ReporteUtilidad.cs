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
    public partial class ReporteUtilidad : Form
    {
        List<Utilidad_E> lista = null;
        Utilidad_N ArtN = new Utilidad_N();
        Utilidad_E c;

        public ReporteUtilidad()
        {
            InitializeComponent();
            CargarDatos();
            SetMyCustomFormat();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            DtpFechaIncial.Format = DateTimePickerFormat.Custom;
            DtpFechaIncial.CustomFormat = "yyyy-MM-dd";

            DtpFechaFinal.Format = DateTimePickerFormat.Custom;
            DtpFechaFinal.CustomFormat = "yyyy-MM-dd";

        }

        private void ContarTotal()
        {
            decimal Vtotal = 0;
            foreach (DataGridViewRow row in DgvUtilidad.Rows)
            {
                Vtotal += Convert.ToDecimal(row.Cells["TotalVenta"].Value);
            }
            TxtTotalIngresos.Text = Vtotal.ToString();


            ///Total de compra
            decimal TotalCompra = 0;
            foreach (DataGridViewRow row in DgvUtilidad.Rows)
            {
                TotalCompra += Convert.ToDecimal(row.Cells["TotalCompra"].Value);
            }

            TxtTotalC.Text = TotalCompra.ToString();

            //Total diferencia
            decimal Diferencia = Vtotal - TotalCompra;
            TxtUtilidad.Text = Diferencia.ToString();
        }

        private void CargarDatos()
        {
            if (lista == null)
            {
                lista = ArtN.Listar();
            }
            if (lista.Count > 0)
            {
                DgvUtilidad.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    DgvUtilidad.Rows.Add(
                         lista[i].Fecha,
                         lista[i].Codigo,
                        lista[i].Producto,
                        lista[i].Cantidad,
                        lista[i].PrecioCompra,
                        lista[i].PrecioVenta,
                         lista[i].TotalVenta,
                          lista[i].PrecioCompra * lista[i].Cantidad
                        );
                }
            }
            ContarTotal();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ArtN.FechaI = DtpFechaIncial.Text;
            ArtN.FechaF = DtpFechaFinal.Text;

            lista = ArtN.Filtrar();

            
                MessageBox.Show("Entro");
                DgvUtilidad.Rows.Clear();

                for (int i = 0; i < lista.Count; i++)
                {
                    DgvUtilidad.Rows.Add(
                        lista[i].Fecha,
                        lista[i].Codigo,
                        lista[i].Producto,
                        lista[i].Cantidad,
                        lista[i].PrecioCompra,
                        lista[i].PrecioVenta,
                        lista[i].TotalVenta,
                        lista[i].PrecioCompra * lista[i].Cantidad
                        );
                }
            ContarTotal();
        }

        private void GbUtilidad_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            string fechaI = DtpFechaIncial.Text;
            string fechaF = DtpFechaFinal.Text;
            Reportes.ReporteUtilidad Report = new Reportes.ReporteUtilidad(fechaI,fechaF);
            Report.Show();
        }
    }
}
