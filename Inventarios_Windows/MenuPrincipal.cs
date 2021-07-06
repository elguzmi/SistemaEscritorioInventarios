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
    public partial class MenuPrincipal : Form
    {
        int Id;
        string nombre;
        MenuPrincipal_N Menu = new MenuPrincipal_N();
        
        public MenuPrincipal(int Id, string Nombre)
        {
            InitializeComponent();
            CustomizeDesing();
            Labeluser.Text = Nombre;
            this.Id = Id;
            this.nombre = Nombre;
            CargarDatos();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            DgvStock.DataSource = Menu.ListarArticulosStock();
            DgvEntradas.DataSource = Menu.UltimasEntradas();
            DgvSalidas.DataSource = Menu.UltimasSalidas();

            DataTable TablaArticulos = Menu.ListarArticulo();
            LblArticulos.Text = (TablaArticulos.Rows[0][0]).ToString();
            DataTable TablaEntradas = Menu.ListarEntradas();
            LblEntradas.Text = (TablaEntradas.Rows[0][0]).ToString();
            DataTable Salidas = Menu.ListarSalidas();
            LblSalidas.Text = (Salidas.Rows[0][0]).ToString();
        }

        private void CustomizeDesing()
        {
            panelArticulosSubmenu.Visible = false;
            panelEntradasSubmenu.Visible = false;
            panelSalidasSubmenu.Visible = false;
            panelReportesSubmenu.Visible = false;
            panelConfiguracionSubmenu.Visible = false;
        }

        private void hidesubmenu()
        {

            if(panelArticulosSubmenu.Visible == true)
            {
                panelArticulosSubmenu.Visible = false;
            }
            if (panelEntradasSubmenu.Visible == true)
            {
                panelEntradasSubmenu.Visible = false;
            }
            if (panelSalidasSubmenu.Visible == true)
            {
                panelSalidasSubmenu.Visible = false;
            }
            if(panelReportesSubmenu.Visible == true)
            {
                panelReportesSubmenu.Visible = false;
            }
            if (panelConfiguracionSubmenu.Visible == true)
            {
                panelConfiguracionSubmenu.Visible = false;
            }
        }

        private void showSubmenu(Panel Submenu)
        {
            if(Submenu.Visible== false)
            {
                hidesubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        #region Articulos
        private void BtnMenuArticulos_Click(object sender, EventArgs e)
        {
            showSubmenu(panelArticulosSubmenu);
        }
        private void BtnAgregarArticulos_Click(object sender, EventArgs e)
        {
            /*      
             mi codigo
             */
            Articulos Arti = new Articulos();
            OpenChildForm(Arti);
            hidesubmenu();
        }

        private void BtnRevisarStock_Click(object sender, EventArgs e)
        {
            /*      
             mi codigo
             */
            RevisarStock stock = new RevisarStock();
            OpenChildForm(stock);
            hidesubmenu();
        }

        #endregion

        #region entradas
        private void BtnMenuEntradas_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEntradasSubmenu);
        }

        private void BtnIngresarEntrada_Click(object sender, EventArgs e)
        {
            /*      
            mi codigo
            */
            Entradas entrar = new Entradas();
            OpenChildForm(entrar);
            hidesubmenu();
        }

        private void BtnRevisarEntrada_Click(object sender, EventArgs e)
        {
            RevisarEntradas entradas = new RevisarEntradas();
            OpenChildForm(entradas);
            
            hidesubmenu();
        }

        private void BtnCancelarCompra_Click(object sender, EventArgs e)
        {
            /*      
           mi codigo
           */
            hidesubmenu();
        }

        #endregion

        #region salidas
        private void BtnMenuSalidas_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSalidasSubmenu);
        }

        private void BtnIngresarSalidas_Click(object sender, EventArgs e)
        {
            /*      
          mi codigo
          */
            Salidas Sali = new Salidas();
            OpenChildForm(Sali);
            hidesubmenu();
        }

        private void BtnRevisarSalidas_Click(object sender, EventArgs e)
        {
            /*      
          mi codigo
          */
            RevisarSalidas Sali = new RevisarSalidas();
            OpenChildForm(Sali);
            hidesubmenu();
        }

        private void BtnCancelarVentas_Click(object sender, EventArgs e)
        {
            /*      
          mi codigo
          */
            hidesubmenu();
        }
        #endregion

        #region reportes

        private void BtnMenuReportes_Click(object sender, EventArgs e)
        {
            showSubmenu(panelReportesSubmenu);
        }

        private void BtnReporteGlobal_Click(object sender, EventArgs e)
        {
            /*      
          mi codigo
          */
            ReporteGlobal Global = new ReporteGlobal();
            OpenChildForm(Global);
            hidesubmenu();
        }

        private void BtnUtilidad_Click(object sender, EventArgs e)
        {
            /*      
          mi codigo
          */
            ReporteUtilidad utilidad = new ReporteUtilidad();
            OpenChildForm(utilidad);
            hidesubmenu();
        }

        private void BtnEgresos_Click(object sender, EventArgs e)
        {
            ReporteIngresos ingresos = new ReporteIngresos();
            OpenChildForm(ingresos);
            hidesubmenu();
        }
        private void BtnIngresos_Click(object sender, EventArgs e)
        {
            /*      
          mi codigo
          */
            hidesubmenu();
        }
       
        #endregion

        #region Configuracion
        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            showSubmenu(panelConfiguracionSubmenu);

        }
        private void BtnAdministrarPerfiles_Click(object sender, EventArgs e)
        {
            AdministracionPerfiles perfiles = new AdministracionPerfiles();
            OpenChildForm(perfiles);
            hidesubmenu();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }


        #endregion

        private Form ActiveForm = null;
        private void OpenChildForm( Form ChildForm)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BtnEgresos_Click_1(object sender, EventArgs e)
        {
            ReporteEgresos egresos = new ReporteEgresos();
            OpenChildForm(egresos);
            hidesubmenu();
        }
        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            Acercade acerca = new Acercade();
            OpenChildForm(acerca);
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            Categorias cat= new Categorias();
            OpenChildForm(cat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresas Prov= new Empresas();
            OpenChildForm(Prov);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
