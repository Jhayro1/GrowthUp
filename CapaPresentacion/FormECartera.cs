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
    public partial class FormECartera : Form
    {
        HerramientaCartera objHerramienta;
        NegReporte objNegReporte;
        List<Factura> CFacturas;
        public FormECartera()
        {
            InitializeComponent();
            objHerramienta = new HerramientaCartera();
            objNegReporte = new NegReporte();
            CFacturas = new List<Factura>();
        }
        void ActualizarDatagridReportesMonedas()
        {
            string mons = "Soles";
            string mond = "Dolares";
            DataGWMonedaNacional.DataSource = objNegReporte.ListarReportesSoles(mons);
            DataGWMonedaNacional.Columns["apellidos"].Visible = false;
            DataGWMonedaNacional.Columns["direccion"].Visible = false;
            DataGWMonedaNacional.Columns["email"].Visible = false;
            DataGWMonedaNacional.Columns["celular"].Visible = false;
            DataGWMonedaNacional.Columns["DNI"].Visible = false;
            DataGWMonedaNacional.Columns["ciudad"].Visible = false;
            DataGWMonedaNacional.Columns["IdHerramientaCartera"].Visible = false;
            DataGWMonedaNacional.Columns["FechaDescuento"].Visible = false;
            DataGWMonedaNacional.Columns["Factura"].Visible = false;
            DataGWMonedaNacional.Columns["Letra"].Visible = false;
            DataGWMonedaNacional.Columns["RecibosxHonorario"].Visible = false;
            DataGWMonedaNacional.Columns["PlazoTasa"].Visible = false;
            DataGWMonedaNacional.Columns["ValorNominal"].Visible = false;
            DataGWMonedaNacional.Columns["TipoTasa"].Visible = false;
            DataGWMonedaNacional.Columns["TasaEoN"].Visible = false;
            DataGWMonedaNacional.Columns["Letra"].Visible = false;
            DataGWMonedaNacional.Columns["RecibosxHonorario"].Visible = false;
            DataGWMonedaNacional.Columns["fechaInicial"].Visible = false;
            DataGWMonedaNacional.Columns["fechaFinal"].Visible = false;
            DataGWMonedaNacional.Columns["retencion"].Visible = false;
            DataGWMonedaNacional.Columns["ValorExpresadoCGI"].Visible = false;
            DataGWMonedaNacional.Columns["ValorExpresadoCGF"].Visible = false;
            DataGWMonedaNacional.Columns["TipoMoneda"].Visible = false;
            DataGWMonedaNacional.Columns["TEporcentaje"].Visible = false;
            DataGWMonedaNacional.Columns["FechaDescuento"].Visible = false;
            DataGWMonedaNacional.Columns["dporcentaje"].Visible = false;
            DataGWMonedaNacional.Columns["descuento"].Visible = false;
            DataGWMonedaNacional.Columns["valorNeto"].Visible = false;
            DataGWMonedaNacional.Columns["valorTotalaRecibir"].Visible = false;
            DataGWMonedaNacional.Columns["valorTotalaEntregar"].Visible = false;
            DataGWMonedaNacional.Columns["TCEA"].Visible = false;
            DataGWMonedaNacional.Columns["dias"].Visible = false;

            DgwMonedaExtranjera.DataSource = objNegReporte.ListarReportesDolares(mond);
            DgwMonedaExtranjera.Columns["apellidos"].Visible = false;
            DgwMonedaExtranjera.Columns["direccion"].Visible = false;
            DgwMonedaExtranjera.Columns["email"].Visible = false;
            DgwMonedaExtranjera.Columns["celular"].Visible = false;
            DgwMonedaExtranjera.Columns["DNI"].Visible = false;
            DgwMonedaExtranjera.Columns["ciudad"].Visible = false;
            DgwMonedaExtranjera.Columns["IdHerramientaCartera"].Visible = false;
            DgwMonedaExtranjera.Columns["FechaDescuento"].Visible = false;
            DgwMonedaExtranjera.Columns["Factura"].Visible = false;
            DgwMonedaExtranjera.Columns["Letra"].Visible = false;
            DgwMonedaExtranjera.Columns["RecibosxHonorario"].Visible = false;
            DgwMonedaExtranjera.Columns["PlazoTasa"].Visible = false;
            DgwMonedaExtranjera.Columns["ValorNominal"].Visible = false;
            DgwMonedaExtranjera.Columns["TipoTasa"].Visible = false;
            DgwMonedaExtranjera.Columns["TasaEoN"].Visible = false;
            DgwMonedaExtranjera.Columns["Letra"].Visible = false;
            DgwMonedaExtranjera.Columns["RecibosxHonorario"].Visible = false;
            DgwMonedaExtranjera.Columns["fechaInicial"].Visible = false;
            DgwMonedaExtranjera.Columns["fechaFinal"].Visible = false;
            DgwMonedaExtranjera.Columns["retencion"].Visible = false;
            DgwMonedaExtranjera.Columns["ValorExpresadoCGI"].Visible = false;
            DgwMonedaExtranjera.Columns["ValorExpresadoCGF"].Visible = false;
            DgwMonedaExtranjera.Columns["TipoMoneda"].Visible = false;
            DgwMonedaExtranjera.Columns["TEporcentaje"].Visible = false;
            DgwMonedaExtranjera.Columns["FechaDescuento"].Visible = false;
            DgwMonedaExtranjera.Columns["dporcentaje"].Visible = false;
            DgwMonedaExtranjera.Columns["descuento"].Visible = false;
            DgwMonedaExtranjera.Columns["valorNeto"].Visible = false;
            DgwMonedaExtranjera.Columns["valorTotalaRecibir"].Visible = false;
            DgwMonedaExtranjera.Columns["valorTotalaEntregar"].Visible = false;
            DgwMonedaExtranjera.Columns["TCEA"].Visible = false;
            DgwMonedaExtranjera.Columns["dias"].Visible = false;
        }
        private void FormECartera_Load(object sender, EventArgs e)
        {
            ActualizarDatagridReportesMonedas();
        }

        private void PnlFrmECartera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgmonedanacional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
