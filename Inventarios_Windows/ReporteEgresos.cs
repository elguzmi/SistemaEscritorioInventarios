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
    public partial class ReporteEgresos : Form
    {

        ReporteEgresos_N EgreN = new ReporteEgresos_N();
        public ReporteEgresos()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        private void ContarTotal()
        {
            decimal Vtotal = 0;
            foreach (DataGridViewRow row in DgvEgresos.Rows)
            {

                Vtotal += Convert.ToDecimal(row.Cells["Valortotal"].Value);
            }

            TxtTotalEgresos.Text = Vtotal.ToString();
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            DtpFechaIncial.Format = DateTimePickerFormat.Custom;
            DtpFechaIncial.CustomFormat = "yyyy-MM-dd";

            DtpFechaFinal.Format = DateTimePickerFormat.Custom;
            DtpFechaFinal.CustomFormat = "yyyy-MM-dd";

            DtpActual.Format = DateTimePickerFormat.Custom;
            DtpActual.CustomFormat = "yyyy-MM-dd";
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            string FechaInicio = DtpFechaIncial.Text.ToString();
            string FechaFinal = DtpFechaFinal.Text.ToString();

            EgreN.FechaInicio = FechaInicio;
            EgreN.FechaFinal = FechaFinal;

            DgvEgresos.DataSource= EgreN.Consulta();
            ContarTotal();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string msj = "";
            
                string descripcion = TxtDescripcion.Text;
                decimal Total = Convert.ToDecimal(TxtTotalEgresos.Text);
                EgreN.Descripcion = descripcion;
                EgreN.ValorTotal = Total;
                msj = EgreN.InsertarEgreso();

                if (msj != null && msj != "")
                {

                    for (int i = 0; i < DgvEgresos.Rows.Count - 1; i++)
                    {
                        EgreN.Id_Entrada = int.Parse(DgvEgresos[0, DgvEgresos.Rows[i].Index].Value.ToString());
                        msj = EgreN.modiificarProceso();
                        if (msj != null && msj != "")
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
                }
            
            
        }
    }
}
