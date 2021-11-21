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
    public partial class FormVRegistrados : Form
    {
        DataReporte objDataReporte;
        HerramientaCartera objHerramienta;
        NegReporte objNegReporte;
        public FormVRegistrados()
        {
            InitializeComponent();
            objHerramienta = new HerramientaCartera();
            objNegReporte = new NegReporte();
            objDataReporte = new DataReporte();
        }
        void ActualizarDatagridReporte()
        {
            dgvRegistrados.DataSource = objNegReporte.ListarReportes();
            dgvRegistrados.Columns["apellidos"].Visible = false;
            dgvRegistrados.Columns["direccion"].Visible = false;
            dgvRegistrados.Columns["email"].Visible = false;
            dgvRegistrados.Columns["celular"].Visible = false;
            dgvRegistrados.Columns["DNI"].Visible = false;
            dgvRegistrados.Columns["ciudad"].Visible = false;
            dgvRegistrados.Columns["IdHerramientaCartera"].Visible = false;
            dgvRegistrados.Columns["MonedaSoles"].Visible = false;
            dgvRegistrados.Columns["MonedaDolares"].Visible = false;
            dgvRegistrados.Columns["Factura"].Visible = false;
            dgvRegistrados.Columns["Letra"].Visible = false;
            dgvRegistrados.Columns["RecibosxHonorario"].Visible = false;
            dgvRegistrados.Focus();
        }
        private void FormVRegistrados_Load(object sender, EventArgs e)
        {
            ActualizarDatagridReporte();
        }
    }
}
