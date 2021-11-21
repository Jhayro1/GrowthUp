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
    public partial class FormFactura : Form
    {
        NegReporte objNegFactura;
        public FormFactura()
        {
            InitializeComponent();
            objNegFactura = new NegReporte();
        }
      
        private void FormFactura_Load(object sender, EventArgs e)
        {
            LblPeriodoCapital.Visible = false;
            cmbperidodocapital.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) //registrar
        {
          
        }

        private void btnagregarIniciales_Click(object sender, EventArgs e)
        {

            //dgwCGI_Facturas.Columns["Motivo"].Visible = true;
            //dgwCGI_Facturas.Columns["Valor Expresado"].Visible = true;
            dgwCGI_Facturas.Rows.Add(cmbMotivoCGI_Factura.Text, Convert.ToDouble(txbValorCGI_Factura.Text));
            
        }

        private void btnAgregarFinales_Click(object sender, EventArgs e)
        {

            //dgwCGF_Facturas.Columns["Motivo"].Visible = false;
            //dgwCGF_Facturas.Columns["Valor Expresado"].Visible = false;
            dgwCGF_Facturas.Rows.Add(cmbMotivoCGF_Factura.Text, Convert.ToDouble(txbValorCGF_Factura.Text));

        }

        private void dgwCGI_Facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlFormLoaderFactura_ShowFactura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnagregarIniciales_Click_1(object sender, EventArgs e)
        {
            //dgwCGI_Facturas.Columns["Motivo"].Visible = true;
            //dgwCGI_Facturas.Columns["Valor Expresado"].Visible = true;
            dgwCGI_Facturas.Rows.Add(cmbMotivoCGI_Factura.Text, Convert.ToDouble(txbValorCGI_Factura.Text));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double sumavaloexpresadoIniciales = 0;
            double sumavaloexpresadoFinales = 0;
            if (txbNombre_Cliente.Text != "" && txbApellidos_Cliente.Text != "" && txbCorreo_Cliente.Text != ""
            && txbCelular_Cliente.Text != "" && txbDireccion_Cliente.Text != "" && txbDNI_Cliente.Text != ""
            && txbCiudad_Cliente.Text != "" && cmbTasaPlazo_Factura.Text != "" && txbTasa_Factura.Text != ""
            && dtpFechaDescuento_Factura.Text != "" && dtpFechaEmision_Factura.Text != "" && dtpFechaPago_Factura.Text != ""
            && txbTotalFacturado.Text != "" && txbRetencion_Factura.Text != "" && cmbMotivoCGI_Factura.Text != ""
            && txbValorCGI_Factura.Text != "" && cmbMotivoCGF_Factura.Text != "" && txbValorCGF_Factura.Text != ""
           )
            {
                int IDu = Nube.UsuarioLog.IdUsuario;
                int PlazodTasa = 0;
                double PeriodoCapital = 0;
                HerramientaCartera objherramientacartera = new HerramientaCartera();
                Factura objfactura = new Factura();

                objherramientacartera.Nombres = txbNombre_Cliente.Text;
                objherramientacartera.apellidos = txbApellidos_Cliente.Text;
                objherramientacartera.email = txbCorreo_Cliente.Text;
                objherramientacartera.celular = txbCelular_Cliente.Text;
                objherramientacartera.direccion = txbDireccion_Cliente.Text;
                objherramientacartera.DNI = txbDNI_Cliente.Text;
                objherramientacartera.ciudad = txbCiudad_Cliente.Text;
                objherramientacartera.PlazoTasa = Convert.ToString(cmbTasaPlazo_Factura.Text);
                objherramientacartera.TasaEoN = Convert.ToDouble(txbTasa_Factura.Text);
                objherramientacartera.FechaDescuento = Convert.ToDateTime(dtpFechaDescuento_Factura.Text);
                objherramientacartera.TipoTasa = Convert.ToString(cmbtipodetasa.Text);
                objherramientacartera.TipoMoneda = Convert.ToString(cmbtipomoneda.Text);
                objherramientacartera.fechaInicial = Convert.ToDateTime(dtpFechaEmision_Factura.Text);
                objherramientacartera.fechaFinal = Convert.ToDateTime(dtpFechaPago_Factura.Text);
                objherramientacartera.ValorNominal = Convert.ToDouble(txbTotalFacturado.Text);
                objherramientacartera.retencion = Convert.ToDouble(txbRetencion_Factura.Text);

                foreach (DataGridViewRow row in dgwCGI_Facturas.Rows)
                {
                    sumavaloexpresadoIniciales += Convert.ToDouble(row.Cells["clmvalorexpresadoIniciales"].Value);
                }
                objherramientacartera.ValorExpresadoCGI = Convert.ToDouble(sumavaloexpresadoIniciales);

                foreach (DataGridViewRow row in dgwCGF_Facturas.Rows)
                {
                    sumavaloexpresadoFinales += Convert.ToDouble(row.Cells["clmValorExpresadoCGF"].Value);
                }
                objherramientacartera.ValorExpresadoCGF = Convert.ToDouble(sumavaloexpresadoFinales);

                if (cmbTasaPlazo_Factura.Text == "Quincenal")
                {
                    PlazodTasa = 15;
                }
                if (cmbTasaPlazo_Factura.Text == "Mensual")
                {
                    PlazodTasa = 30;
                }
                if (cmbTasaPlazo_Factura.Text == "Bimestral")
                {
                    PlazodTasa = 60;
                }
                if (cmbTasaPlazo_Factura.Text == "Trimestral")
                {
                    PlazodTasa = 90;
                }
                if (cmbTasaPlazo_Factura.Text == "Cuatrimestral")
                {
                    PlazodTasa = 120;
                }
                if (cmbTasaPlazo_Factura.Text == "Semestral")
                {
                    PlazodTasa = 180;
                }
                if (cmbTasaPlazo_Factura.Text == "Anual")
                {
                    PlazodTasa = 360;
                }

                if (cmbperidodocapital.Text == "Quincenal")
                {
                    PeriodoCapital = 15;
                }
                if (cmbperidodocapital.Text == "Mensual")
                {
                    PeriodoCapital = 30;
                }
                if (cmbperidodocapital.Text == "Bimestral")
                {
                    PeriodoCapital = 60;
                }
                if (cmbperidodocapital.Text == "Trimestral")
                {
                    PeriodoCapital = 90;
                }
                if (cmbperidodocapital.Text == "Cuatrimestral")
                {
                    PeriodoCapital = 120;
                }
                if (cmbperidodocapital.Text == "Semestral")
                {
                    PeriodoCapital = 180;
                }
                if (cmbperidodocapital.Text == "Anual")
                {
                    PeriodoCapital = 360;
                }

                DateTime fechaInicial = dtpFechaEmision_Factura.Value.Date;
                DateTime fechaFinal = dtpFechaPago_Factura.Value.Date;
                DateTime fechaDescuento = dtpFechaDescuento_Factura.Value.Date;

                TimeSpan tSpan = fechaFinal - fechaInicial;
                TimeSpan tDesc = fechaDescuento - fechaInicial;

                int DiasDifIF = tSpan.Days;
                int DiasDifID = tDesc.Days;

                int DiasIF = DiasDifIF - DiasDifID;
                objherramientacartera.dias = Convert.ToInt32(DiasIF);

                int difdeFechas = 0;
                difdeFechas = (int)objherramientacartera.dias;

                double TE = 0;
                TE = (double)objherramientacartera.TasaEoN;


                if (lbltipotasa.Text == "Tasa Efectiva")
                {
                    TE = TE / 100;
                }

                else
                {
                    TE = TE / 100;
                    double difperiodotasa = (double)(PeriodoCapital / PlazodTasa);
                    TE = Math.Pow(1 + TE, difperiodotasa);
                    TE = TE - 1;
                }

                double TEP = 0;
                double diffechawTasoPlaza = 0;

                diffechawTasoPlaza = (double)DiasIF / PlazodTasa;

                TEP = (double)Math.Pow(1 + TE, diffechawTasoPlaza);

                TEP = TEP - 1;

                double Tasadescontada = TEP / (1 + TEP);

                double ValorNominal;
                ValorNominal = (double)objherramientacartera.ValorNominal;

                double Descuento = ValorNominal * Tasadescontada;

                double ValorNeto = ValorNominal * (1 - Tasadescontada);

                double CGIniciales;
                CGIniciales = (double)objherramientacartera.ValorExpresadoCGI;

                double retencion;
                retencion = (double)objherramientacartera.retencion;

                double ValorTotalaRecibir = ValorNeto - CGIniciales - retencion;


                double CGFinales;
                CGFinales = (double)objherramientacartera.ValorExpresadoCGF;

                double ValorTotalaEntregar = ValorNominal + CGFinales - retencion;

                double TCEA = Math.Pow(ValorTotalaEntregar / ValorTotalaRecibir, 360 / difdeFechas);
                TCEA = TCEA - 1;

                if (cmbtipomoneda.Text == "Soles")
                {
                    objherramientacartera.MonedaSoles = ValorTotalaRecibir;
                    objherramientacartera.MonedaDolares = ValorTotalaRecibir / 4.1;
                }
                else
                {
                    objherramientacartera.MonedaDolares = ValorTotalaRecibir;
                    objherramientacartera.MonedaSoles = ValorTotalaRecibir * 4.1;
                }

                objherramientacartera.Tipo = "Factura";
                objherramientacartera.TEporcentaje = Convert.ToDouble(TEP * 100);
                objherramientacartera.dporcentaje = Convert.ToDouble(Tasadescontada * 100);
                objherramientacartera.descuento = Convert.ToDouble(Descuento);
                objherramientacartera.valorNeto = Convert.ToDouble(ValorNeto);
                objherramientacartera.valorTotalaRecibir = Convert.ToDouble(ValorTotalaRecibir);
                objherramientacartera.valorTotalaEntregar = Convert.ToDouble(ValorTotalaEntregar);
                objherramientacartera.TCEA = Convert.ToDouble(TCEA * 100);
                objfactura.IdUsuario = Convert.ToInt32(IDu);
                objfactura.IdHerramientaCartera = Convert.ToInt32(objherramientacartera.IdHerramientaCartera);

                this.pnlFormFactura.Controls.Clear();
                MessageBox.Show(objNegFactura.RegistrarReporteFactura(objherramientacartera, objfactura));
                FormVRegistrados frmshowreporte = new FormVRegistrados() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmshowreporte.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormFactura.Controls.Add(frmshowreporte); 
                frmshowreporte.Show();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void btnAgregarFinales_Click_1(object sender, EventArgs e)
        {
            dgwCGF_Facturas.Rows.Add(cmbMotivoCGF_Factura.Text, Convert.ToDouble(txbValorCGF_Factura.Text));
        }

        private void cmbtipotasa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbtipodetasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbtipodetasa.SelectedIndex;
            lbltipotasa.Text = cmbtipodetasa.Items[indice].ToString();

            if(lbltipotasa.Text == "Tasa Nominal")
            {
                LblPeriodoCapital.Visible = true;
                cmbperidodocapital.Visible = true;
            }
            else
            {
                LblPeriodoCapital.Visible = false;
                cmbperidodocapital.Visible = false;
            }
        }

        private void cmbtipomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlFormFactura_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
