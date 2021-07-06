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
    public partial class ReporteGlobal : Form
    {
        ReporteGlobal_N RepG = new ReporteGlobal_N();
        public ReporteGlobal()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            DtpFechaInicial.Format = DateTimePickerFormat.Custom;
            DtpFechaInicial.CustomFormat = "yyyy-MM-dd";

            DtpFechaFinal.Format = DateTimePickerFormat.Custom;
            DtpFechaFinal.CustomFormat = "yyyy-MM-dd";
        }

        private string ExtraerValorT( DataGridView tabla)
        {
            decimal Vtotal = 0;
            foreach (DataGridViewRow row in tabla.Rows)
            {

                Vtotal += Convert.ToDecimal(row.Cells["Valortotal"].Value);
            }

            return Vtotal.ToString();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            RepG.FechaInicio = DtpFechaInicial.Text;
            RepG.FechaFinal = DtpFechaFinal.Text;

            DgvIngresos.DataSource = RepG.ConsultaIngresos();
            DgvEgresos.DataSource = RepG.ConsultaEgresos();

            TxtTotalEgre.Text =   ExtraerValorT(DgvEgresos);
            TxtTotalIng.Text = ExtraerValorT(DgvIngresos);

            decimal Diferencia = Convert.ToDecimal(TxtTotalEgre.Text) - Convert.ToDecimal(TxtTotalIng.Text);
            TxtDiferencia.Text = Diferencia.ToString();
        }

    }
}
