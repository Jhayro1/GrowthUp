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
    public partial class FormLetra : Form
    {
        NegReporte objNegReporte;
        public FormLetra()
        {
            InitializeComponent();
            objNegReporte = new NegReporte();
            LblPeriodoCapital.Visible = false;
            cmbperidodocapital.Visible = false;
        }
        private void FormLetra_Load(object sender, EventArgs e)
        {

        }
        private void BtnRegLetra_Click(object sender, EventArgs e)
        {

            double sumavaloexpresadoIniciales = 0;
            double sumavaloexpresadoFinales = 0;
            if (txbNombre_Cliente.Text != "" && txbApellidos_Cliente.Text != "" && txbCorreo_Cliente.Text != ""
            && txbCelular_Cliente.Text != "" && txbDireccion_Cliente.Text != "" && txbDNI_Cliente.Text != ""
            && txbCiudad_Cliente.Text != "" && cmbTasaPlazo_Letra.Text != "" && txbTasa_Letra.Text != ""
            && dtpFechaDescuento_Letra.Text != "" && dtpFechaEmision_Letra.Text != "" && dtpFechaPago_Letra.Text != ""
            && txbTotalFacturado.Text != "" && txbRetencion_Letra.Text != "" && cmbMotivoCGI_Letra.Text != ""
            && txbValorCGI_Letra.Text != "" && cmbMotivoCGF_Letra.Text != "" && txbValorCGF_Letra.Text != ""
           )
            {
                int IDu = Nube.UsuarioLog.IdUsuario;
                int PlazodTasa = 0;
                double PeriodoCapital = 0;
                HerramientaCartera objherramientacartera = new HerramientaCartera();
                Letra objletra = new Letra();

                objherramientacartera.Nombres = txbNombre_Cliente.Text;
                objherramientacartera.apellidos = txbApellidos_Cliente.Text;
                objherramientacartera.email = txbCorreo_Cliente.Text;
                objherramientacartera.celular = txbCelular_Cliente.Text;
                objherramientacartera.direccion = txbDireccion_Cliente.Text;
                objherramientacartera.DNI = txbDNI_Cliente.Text;
                objherramientacartera.ciudad = txbCiudad_Cliente.Text;
                objherramientacartera.PlazoTasa = Convert.ToString(cmbTasaPlazo_Letra.Text);
                objherramientacartera.TasaEoN = Convert.ToDouble(txbTasa_Letra.Text);
                objherramientacartera.FechaDescuento = Convert.ToDateTime(dtpFechaDescuento_Letra.Text);
                objherramientacartera.TipoTasa = Convert.ToString(cmbtipodetasa.Text);
                objherramientacartera.TipoMoneda = Convert.ToString(cmbtipomoneda.Text);
                objherramientacartera.fechaInicial = Convert.ToDateTime(dtpFechaEmision_Letra.Text);
                objherramientacartera.fechaFinal = Convert.ToDateTime(dtpFechaPago_Letra.Text);
                objherramientacartera.ValorNominal = Convert.ToDouble(txbTotalFacturado.Text);
                objherramientacartera.retencion = Convert.ToDouble(txbRetencion_Letra.Text);

                foreach (DataGridViewRow row in dgwCGI_Letra.Rows)
                {
                    sumavaloexpresadoIniciales += Convert.ToDouble(row.Cells["clmvalorexpresadoIniciales"].Value);
                }
                objherramientacartera.ValorExpresadoCGI = Convert.ToDouble(sumavaloexpresadoIniciales);

                foreach (DataGridViewRow row in dgwCGF_Letra.Rows)
                {
                    sumavaloexpresadoFinales += Convert.ToDouble(row.Cells["clmValorExpresadoCGF"].Value);
                }
                objherramientacartera.ValorExpresadoCGF = Convert.ToDouble(sumavaloexpresadoFinales);

                if (cmbTasaPlazo_Letra.Text == "Quincenal")
                {
                    PlazodTasa = 15;
                }
                if (cmbTasaPlazo_Letra.Text == "Mensual")
                {
                    PlazodTasa = 30;
                }
                if (cmbTasaPlazo_Letra.Text == "Bimestral")
                {
                    PlazodTasa = 60;
                }
                if (cmbTasaPlazo_Letra.Text == "Trimestral")
                {
                    PlazodTasa = 90;
                }
                if (cmbTasaPlazo_Letra.Text == "Cuatrimestral")
                {
                    PlazodTasa = 120;
                }
                if (cmbTasaPlazo_Letra.Text == "Semestral")
                {
                    PlazodTasa = 180;
                }
                if (cmbTasaPlazo_Letra.Text == "Anual")
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

                DateTime fechaInicial = dtpFechaEmision_Letra.Value.Date;
                DateTime fechaFinal = dtpFechaPago_Letra.Value.Date;
                DateTime fechaDescuento = dtpFechaDescuento_Letra.Value.Date;

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

                if (label11.Text == "Tasa Efectiva")
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

                objherramientacartera.Tipo = "Letra";
                objherramientacartera.TEporcentaje = Convert.ToDouble(TEP * 100);
                objherramientacartera.dporcentaje = Convert.ToDouble(Tasadescontada * 100);
                objherramientacartera.descuento = Convert.ToDouble(Descuento);
                objherramientacartera.valorNeto = Convert.ToDouble(ValorNeto);
                objherramientacartera.valorTotalaRecibir = Convert.ToDouble(ValorTotalaRecibir);
                objherramientacartera.valorTotalaEntregar = Convert.ToDouble(ValorTotalaEntregar);
                objherramientacartera.TCEA = Convert.ToDouble(TCEA * 100);

                objletra.IdUsuario = Convert.ToInt32(IDu);
                objletra.IdHerramientaCartera = Convert.ToInt32(objherramientacartera.IdHerramientaCartera);

                this.pnlFormLetra.Controls.Clear();
                MessageBox.Show(objNegReporte.RegistrarReporteLetra(objherramientacartera, objletra));
                FormVRegistrados frmshowreporte = new FormVRegistrados() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmshowreporte.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLetra.Controls.Add(frmshowreporte);
                frmshowreporte.Show();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void cmbtipodetasa_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = cmbtipodetasa.SelectedIndex;
            label11.Text = cmbtipodetasa.Items[indice].ToString();
            if (label11.Text == "Tasa Nominal")
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

        private void btnagregarIniciales_Click(object sender, EventArgs e)
        {

            dgwCGI_Letra.Rows.Add(cmbMotivoCGI_Letra.Text, Convert.ToDouble(txbValorCGI_Letra.Text));
        }

        private void btnAgregarFinales_Click(object sender, EventArgs e)
        {

            dgwCGF_Letra.Rows.Add(cmbMotivoCGF_Letra.Text, Convert.ToDouble(txbValorCGF_Letra.Text));
        }

   
    }
}
