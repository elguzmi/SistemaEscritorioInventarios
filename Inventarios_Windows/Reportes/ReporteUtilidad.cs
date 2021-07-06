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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Inventarios_Windows.Reportes
{
    public partial class ReporteUtilidad : Form
    {
        ReporteUtilidad_N Report = new ReporteUtilidad_N();
        public string FechaI { get; set; }
        public string FechaF { get; set; }
        public ReporteUtilidad(string FechaI ,string FechaF)
        {
            InitializeComponent();
            this.FechaI = FechaI;
            this.FechaF = FechaF;
            CargarDatos();
        }

        private void ReporteEntrada_Load(object sender, EventArgs e)
        {

            
        }

        public void CargarDatos()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventarios_Windows.ReporteUtilidad.rdlc";
            ReportDataSource rds1 = new ReportDataSource("Data_Utilidad", Report.Listar(FechaI,FechaF));
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }


    }
}
