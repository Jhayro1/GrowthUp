using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Home : Form
    {
        NegUsuario objNegUsuario;
        NegReporte objNegReporte;
        Factura objfactura;
        List<Factura> CFacturas;
        List<Letra> CLetras;
        List<RecibosxHonorario> CRecibos;
        public Home()
        {
            InitializeComponent();
            objNegUsuario = new NegUsuario();
            objNegReporte = new NegReporte();
            objfactura = new Factura();
            CFacturas = new List<Factura>();
            CLetras = new List<Letra>();
            CRecibos = new List<RecibosxHonorario>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Home_Load(object sender, EventArgs e)
        {
            lblnombreusuario_home.Text = Nube.UsuarioLog.nombreusuario;
            lblcantidadFacturas_Home.Text = CFacturas.Count.ToString()+1;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblnombreusuario_home_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void picbFactura_Home_Click(object sender, EventArgs e)
        {

        }

        private void picbRecibosxH_Home_Click(object sender, EventArgs e)
        {

        }

        private void picbLetra_Home_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void picbFactura_Home_Click_1(object sender, EventArgs e)
        {
            this.pnlFormLoaderHome.Controls.Clear();
            FormFactura frmregistrarfactura = new FormFactura() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmregistrarfactura.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoaderHome.Controls.Add(frmregistrarfactura);
            frmregistrarfactura.Show();
        }

        private void pnlFormLoaderHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picbRecibosxH_Home_Click_1(object sender, EventArgs e)
        {
            this.pnlFormLoaderHome.Controls.Clear();
            FormRecibosxHonorario frmregistrarecibohonorario = new FormRecibosxHonorario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmregistrarecibohonorario.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoaderHome.Controls.Add(frmregistrarecibohonorario);
            frmregistrarecibohonorario.Show();
        }

        private void picbLetra_Home_Click_1(object sender, EventArgs e)
        {
            this.pnlFormLoaderHome.Controls.Clear();
            FormLetra frmRegistrarLetra = new FormLetra() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmRegistrarLetra.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoaderHome.Controls.Add(frmRegistrarLetra);
            frmRegistrarLetra.Show();
        }
    }
}
