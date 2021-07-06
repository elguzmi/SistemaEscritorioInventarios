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
    public partial class ReporteIngresos : Form
    {

        ReporteIngresos_N IngreN = new ReporteIngresos_N();
        public ReporteIngresos()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        private void ContarTotal()
        {
            decimal Vtotal = 0;
            foreach (DataGridViewRow row in DgvIngresos.Rows)
            {

                Vtotal += Convert.ToDecimal(row.Cells["Valortotal"].Value);
            }

            TxtTotal.Text = Vtotal.ToString();
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

            IngreN.FechaInicio = FechaInicio;
            IngreN.FechaFinal = FechaFinal;

            DgvIngresos.DataSource= IngreN.Consulta();
            ContarTotal();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string msj = "";
            try
            {
                string descripcion = TxtDescripcion.Text;
                decimal Total = Convert.ToDecimal(TxtTotal.Text);
                IngreN.Descripcion = descripcion;
                IngreN.ValorTotal = Total;
                msj=  IngreN.InsertarIngreso();

                if(msj != null && msj != "")
                {
                    
                    for(int i =0; i <DgvIngresos.Rows.Count-1; i++)
                    {
                        IngreN.Id_Salida = int.Parse(DgvIngresos[0, DgvIngresos.Rows[i].Index].Value.ToString());
                        msj = IngreN.ModificarProceso();
                        if (msj != null && msj!="")
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
            catch
            {
                MessageBox.Show("Completa los campos");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
